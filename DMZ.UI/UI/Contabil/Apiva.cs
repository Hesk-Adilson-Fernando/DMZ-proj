using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using Microsoft.Reporting.WinForms;

namespace DMZ.UI.UI.Contabil
{
    public partial class Apiva : FrmClasse2
    {
        private decimal _dedutivel, _liquido, _anoContabil;
        private DataTable _dt;

        public Apiva()
        {
            InitializeComponent();
        }

        private void Apiva_Load(object sender, EventArgs e)
        {
            _anoContabil = Pbl.AnoContabil();
            cbMes.Update(true);
            var mes = SQL.GetRow($"select codigo,ltrim(rtrim(mes)) as descricao from mescont where codigo={Pbl.SqlDate.Month}");
            cbMeses.tb1.Text = mes["descricao"].ToString();
            cbMeses.Text2 = mes["codigo"].ToString();
            mesInicio.Value = 1;
            mesFim.Value = 12;

            numericDia.Value = Pbl.SqlDate.Day;
            numericMes.Value = Pbl.SqlDate.Month;
            numericAno.Value = _anoContabil;
        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            var codigomes = cbMeses.Text2.ToDecimal();
            if (codigomes >= 1 && codigomes <= 12)
            {
                Periodo = $"mes = {codigomes} and  ano ={_anoContabil} ";
                var sel = @" conta,descricao, isnull(cre,0) as cre,isnull(deb,0) as deb, (Cast(0 as bit)) as subt,
                        (Cast(0 as bit)) as apura,''as apcontastamp ,(Cast(0 as bit)) as ded,(Cast(0 as bit)) as liq,'' as Contastamp";
                _dt = SQL.GetDT("ml", sel, "1=2", null);
                Dtap = SQL.GetGenDT("apparam", "where origem ='IVA'"); // Tabela de Paramentros de apuramento......
                if (Dtap.HasRows())
                {
                    var apparamstamp = Dtap.RowZero("apparamstamp").ToString().Trim();
                    //Tabela de Contas de IVA Dedutível... 
                    var apivded = SQL.GetGenDT("apivded", $"where apparamstamp ='{apparamstamp}' order by conta",
                        "conta,descricao");
                    //Tabela de Contas de IVA Liquidados... 
                    var apivliq = SQL.GetGenDT("apivliq", $"where apparamstamp ='{apparamstamp}' order by conta",
                        "conta,descricao");

                    #region Apuramento das contas do Dedutível.....
                    if (apivded.HasRows())
                    {
                        foreach (var r in apivded.AsEnumerable())
                        {
                            if (r == null) continue;
                            AdicionaLinha( r["conta"].ToTrim(), true, false, r);
                        }
                        AdicionaLinhaTotal(true);
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "As contas de IVA dedutível não foram configuradas!");
                        return;
                    }

                    #endregion

                    #region Apuramento das contas do Liquidado.....

                    if (apivliq.HasRows())
                    {
                        foreach (var r in apivliq.AsEnumerable())
                        {
                            if (r == null) continue;
                            AdicionaLinha(r["conta"].ToTrim(), false, true, r);
                        }
                        AdicionaLinhaTotal(false);
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "As contas de IVA Liquidado não foram configuradas!");
                    }
                    #endregion

                    #region Apuramento da conta do mes anterior [Iva a recuperar]...
                    var dtIvaant = SQL.GetGen2DT($"select deb,cre,mlstamp from ml where conta ='{Dtap.RowZero("cc2").ToTrim()}' and Processado=0 and ano=(select ano from param)");
                    if (dtIvaant.HasRows())
                    {
                        if (dtIvaant.RowZero("deb").ToDecimal() > 0)
                        {
                            //|| dtIvaant.RowZero("cre").ToDecimal() > 0
                            var r7 = _dt.NewRow().Inicialize();
                            r7["conta"] = Dtap.RowZero("cc2");
                            r7["descricao"] = Dtap.RowZero("ivaant") + " - ANTERIOR";
                            r7["cre"] = dtIvaant.RowZero("deb").ToDecimal();
                            r7["deb"] = 0;//dtIvaant.RowZero("deb").ToDecimal();
                            r7["ded"] = true;
                            Contastamp = dtIvaant.RowZero("mlstamp").ToString();
                            r7["apcontastamp"] = dtIvaant.RowZero("mlstamp");
                            r7["apura"] = true;
                            r7["subt"] = true;
                            _dt.Rows.Add(r7);
                            _dt.Rows.Add(_dt.NewRow().Inicialize());
                        }
                    }

                    #endregion

                    decimal total = 0;
                    //Debito - Credito
                    if (_dt.HasRows()) //linha vazia....
                    {
                        total = _dt.Sum("cre", "subt")- _dt.Sum("deb", "subt");
                    }
                    #region Resultado de apuramento [IVA a pagar ou a receber]........

                    //Se debito -credito < 0, entao temos iva a recuperar, se nao iva a pagar  
                    if (total > 0)
                    {
                        //IVA a recuperar 
                        var r9 = _dt.NewRow();
                        r9["conta"] = Dtap.Rows[0]["cc1"];
                        r9["descricao"] = Dtap.Rows[0]["ivarec"];
                        r9["cre"] = 0; 
                        r9["deb"] = total.ToRound((int)Pbl.Param.Aredondamento);
                        r9["apura"] = true;
                        r9["apcontastamp"] = "";
                        _dt.Rows.Add(r9);
                    }
                    else if (total < 0)
                    {
                        //Iva a pagar..
                        var r8 = _dt.NewRow();
                        r8["conta"] = Dtap.Rows[0]["cc3"];
                        r8["descricao"] = Dtap.Rows[0]["ivapag"];
                        r8["cre"] = -1 * total.ToRound((int)Pbl.Param.Aredondamento);
                        r8["deb"] = 0;
                        r8["apura"] = true;
                        r8["apcontastamp"] = "";
                        _dt.Rows.Add(r8);
                    }

                    #endregion
                    dgvApura.SetDataSource(_dt);
                }
                else

                {
                    MsBox.Show(Messagem.ParteInicial() + "A tabela de parâmentros de IVA não foi configurada!..");
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "O Apuramento do IVA só pode ser exectudo de Janeiro a Dezembro! ");
            }
        }

        public string Periodo { get; set; }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (_dt.HasRows())
            {
                //var titulo1 = "APURAMENTO DE IVA - SIMULAÇÃO";
                //titulo1 = $"{titulo1}\r\nPeríodo: {cbMeses.tb1.Text}";
                //var pr = new FrmReport
                //{
                //    Dt = _dt,
                //    Origem = "AIVA",
                //    CTituloRelatorio = titulo1,
                //};
                //pr.ShowDialog();
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial()+"Não temos nada para imprimir!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (_dt.HasRows())
            {
                var codigomes = cbMeses.Text2.ToDecimal();
                if (codigomes > 0)
                {
                    Data=new DateTime((int)numericAno.Value, (int)numericMes.Value, (int)numericDia.Value);
                    var lcontstamp = SQL.GetValue("lcontstamp", "lcont", $"Apuraiva=1 and ano= (select ano from param) and mes = {codigomes}");
                    if (lcontstamp.IsNullOrEmpty())
                    {
                        var w = new FrmLContab();
                        w.ShowForm(this);
                        w.btnNovo.PerformClick();
                        w.Lc.Apuraiva = true;
                        w.numericMes.Value = numericMes.Value;
                        w.numericDia.Value = numericDia.Value;
                        w.numericAno.Value = numericAno.Value;
                        w.ContaIvaAntestamp = Contastamp;
                        w.dtData.dt1.Value = Data;
                        var d = SQL.GetRowToEnt<Diario>($"Apura =1 and Diano={Pbl.Param.Ano}");// EF.GetEnt<Diario>(x => x.Apura && x.Diano == Pbl.AnoContabil());
                        if (d != null)
                        {
                            w.ucDiario.tb1.Text = d.Descricao;
                            w.ucDiario.Text2 = d.Dino.ToString();
                            w.ucDiario.Text3= d.Diariostamp;
                            var doc = SQL.GetRowToEnt<Dc>($"Apuraiva=1'");// EF.GetEnt<Dc>(x => x.Apuraiva);
                            if (doc != null)
                            {
                                w.ucDoc.tb1.Text = doc.Docnome;
                                w.ucDoc.Text2 = doc.Docno.ToString();
                                w.ucMoeda.tb1.Text = "MZN";
                                w.tbAdoc.tb1.Text = "AIVA " + cbMeses.Text2;
                                //var CondMax = $"docno ={doc.Docno}";
                                var str = $"SELECT dbo.func_GenNumber({d.Dino},{Pbl.SqlDate.Month},{Pbl.SqlDate.Year})";
                                var maximo = SQL.SQLExecScalar(str);
                                w.tbNumero.tb1.Text = maximo.ToString();
                                GerarLancamento(w);
                            }
                            else
                            {
                                MsBox.Show(Messagem.ParteInicial() + "Não foi encontrado o documento de apuramento de resultados, vai verificar nos dossiers!");
                            }
                        }
                        else
                        {
                            MsBox.Show(Messagem.ParteInicial() + "Não foi encontrado o diário de apuramento, vai verificar nos diários!");
                        }
                    }
                    else
                    {
                        var result = MsBox.Show(Messagem.ParteInicial()+
                            $"já exite um apuramento no mês de: {codigomes}/{Pbl.AnoContabil()} \r\n Deseja Recriar o Movimento ?",
                            DResult.YesNo);
                        if (result.DialogResult != DialogResult.Yes) return;
                        SQL.Apagar("lcont", lcontstamp.Trim());
                    }
                }
                else
                {
                    MsBox.Show("Estimado(a), Deve indicar o mê do apuramento!");
                }
            }
            else
            {
                MsBox.Show("Estimado(a), Deve apurar IVA primeiro!");
            }

        }

        public DataTable Dtap { get; set; }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (!Maximizado)
            {
                Maximizar();
            }
            else
            {
                Minimizar();
            }
        }

        public string Contastamp { get; set; } = "";

        private void AdicionaLinhaTotal(bool origemdeb)
        {
            string descricao;
            decimal total;   
            if (origemdeb)
            {
                total= _dt.Sum("deb", "ded") - _dt.Sum("cre", "ded").ToRound((int)Pbl.Param.Aredondamento);
                descricao = "SUBTOTAL DEDUTÍVEL.....";
                _dedutivel = total<0?total*-1:total;   
                _liquido = 0;
            }
            else
            {
                total= _dt.Sum("deb", "liq") - _dt.Sum("cre", "liq").ToRound((int)Pbl.Param.Aredondamento);
                descricao = "SUBTOTAL LIQUIDADO.....";
                _dedutivel = 0;
                _liquido = total < 0 ? total * -1 : total;
            }

            if (!_dt.HasRows()) return;
            var rw2 = _dt.NewRow().Inicialize();
            rw2["descricao"] = descricao;
            rw2["subt"] = true;
            rw2["cre"] = _dedutivel;
            rw2["deb"] = _liquido; 
            _dt.Rows.Add(rw2);
            //Linha vazia
            _dt.Rows.Add(_dt.NewRow().Inicialize());
        }

        private void AdicionaLinha(string conta, bool ded, bool liq,DataRow dr)
        {
            var dt = SQL.GetGen2DT($"select sum(Deb) deb,sum(cre) cre from ml where conta ='{conta.Trim()}' and Apuraiva=0 and {Periodo}");
            if (!dt.HasRows()) return;
            var rw0 = _dt.NewRow().Inicialize();
            rw0["conta"] = dr["conta"];
            rw0["descricao"] = dr["descricao"]; 
            rw0["cre"] = dt.RowZero("deb");
            rw0["deb"] = dt.RowZero("cre");
            rw0["apura"] = true;
            rw0["ded"] = ded;
            rw0["liq"] = liq;
            _dt.AddRow(rw0);

            //rw0["cre"] = credito ? Valor(dt) : 0; //
            //rw0["deb"] = credito ? 0 : Valor(dt);
        }
        private void GerarLancamento(FrmLContab w)
        {
            var dt = w.GridMovim.DtDS;
            var max = 0;
            foreach (var drap in _dt.AsEnumerable())
            {
                if (drap["conta"].ToString() == "" || drap["deb"].ToDecimal() + drap["cre"].ToDecimal() == 0)
                    continue;
                var dr = dt.NewRow().Inicialize();
                dr["lcontstamp"] = w.CLocalStamp;
                dr["Conta"] = drap["conta"];
                dr["descricao"] = drap["descricao"];
                dr["descritivo"] = "";
                dr["mes"] = numericMes.Value;
                dr["dia"] = numericDia.Value;
                dr["Ano"] = numericAno.Value;
                dr["data"] = Data;
                var valor = drap["deb"].ToDecimal() - drap["cre"].ToDecimal();
                if (drap["deb"].ToDecimal()>0 && drap["cre"].ToDecimal()>0)
                {
                    dr["deb"] = drap["ded"].ToBool() ? 0 : valor < 0 ? -1 * valor : valor;
                    dr["cre"] = drap["ded"].ToBool() ? valor < 0 ? -1 * valor : valor:0;//drap["cre"]; 
                }
                else
                {
                    dr["deb"] = drap["deb"];
                    dr["cre"] = drap["cre"];     
                }
                dr["descritivo"] = "AIVA " + cbMeses.Text2;
                dr["ordem"] = max + 1;
                dr["Apuraiva"] =true;
                if (!drap["apcontastamp"].ToString().IsNullOrEmpty())
                {
                    dr["Oristampl"] = drap["apcontastamp"];
                }
                dt.Rows.Add(dr);
                max++;
            }

            w.Totais();
            w.Refresh();

        }

        public DateTime Data { get; set; }

        #region Maximizar

        public bool Maximizado { get; set; }

        private void Maximizar()
        {
            NSize = Size;
            NLocation = Location;
            if (MdiParent != null)
            {
                var height = MdiParent.Size.Height;
                var width = MdiParent.Size.Width;
                Size = new Size(width - 190, height - 165);
                var x = MdiParent.Location.X;
                var y = MdiParent.Location.Y;
                Location = new Point(x + 175, y + 110);
                Maximizado = true;
                var lista = Application.OpenForms;
                foreach (Form frm in lista)
                {
                    if (frm == null) continue;
                    if (frm.IsMdiContainer)
                    {
                        if (frm is DemoMdi)
                        {
                            if (((DemoMdi) frm).Ocultado)
                            {
                                MoveUp();
                            }
                        }
                        else
                        {
                            MoveUp();
                        }
                    }
                }
            }
            else
            {
                var height = Screen.PrimaryScreen.WorkingArea.Size.Height;
                var width = Screen.PrimaryScreen.WorkingArea.Size.Width;
                Size = new Size(width - 190, height - 165);
                var x = Screen.PrimaryScreen.WorkingArea.Location.X;
                var y = Screen.PrimaryScreen.WorkingArea.Location.Y;
                Location = new Point(x + 175, y + 110);
            }
        }

        public void MoveUp()
        {
            NSize = Size;
            NLocation = Location;
            var height = MdiParent.Size.Height;
            var width = MdiParent.Size.Width;
            Size = new Size(width - 70, height - 165);
            var x = MdiParent.Location.X;
            var y = MdiParent.Location.Y;
            Location = new Point(48, y + 110);
        }

        public void MoveDow()
        {
            Size = NSize;
            Location = NLocation;
        }

        public void Minimizar()
        {
            Size = NSize;
            Location = NLocation;
            Maximizado = false;
        }

        private void cbMes_CheckedChangeds()
        {
            cbEntreMeses.Update(!cbMes.cb1.Checked);
        }

        private void cbEntreMeses_CheckedChangeds()
        {
            cbMes.Update(!cbEntreMeses.cb1.Checked);
        }

        private void cbMeses_RefreshControls()
        {
            numericMes.Value = cbMeses.Text2.ToDecimal();
        }

        public Size NSize { get; set; }

        public Point NLocation { get; set; }

        #endregion
    }
}


