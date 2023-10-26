using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.Contabil
{
    public partial class FrmImport : FrmClasse2
    {

        private DataTable _dt;
        private DataTable _dtPgc;
        private DataTable _dtDiario;
        private DataTable _dtDiariodos;
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();
        private decimal _cont;
        public FrmImport()
        {
            InitializeComponent();
        }

        private void frmImport_Load(object sender, EventArgs e)
        {
            var ano = Pbl.AnoContabil();
            nupdAnoOrig.Value = ano - 1;
            nupDest.Value = ano;
            _dtPgc = SQL.Initialize("pgc");
            _dtDiario = SQL.Initialize("diario");
            _dtDiariodos = SQL.Initialize("Diariodoc");
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var dr = MsBox.Show(Messagem.ParteInicial()+"Deseja iniciar processamento?", DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            dataGridView1.Update();
            _dtDiario.Rows.Clear();
            _dtDiariodos.Rows.Clear();
            _listaContas = "";
            _dtPgc.Rows.Clear();
            if (dataGridView1.GetBindedTable().HasRows("ok"))
            {
                var tabela = dataGridView1.GetBindedTable().HasRowsCopyToDataTable("ok");
                Helper.DoProgressProcess(tabela, RecebeDados, "descricao","Criando ");
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Deve selecçionar a(s) conta(s) ou diário(s) desejada(s)!");
            }
        }

        private string _listaContas = "";
        private void RecebeDados(DataRow r, bool fim)
        {
            if (r == null) return;
            switch (r["origem"])
            {
                case "pgc":
                    if (!SQL.CheckExist("conta","pgc",$"conta='{r["codigo"].ToTrim()}' and ano ={nupDest.Value}"))
                    {
                        var dr = _dtPgc.NewRow().Inicialize();
                        dr["ano"] = nupDest.Value;
                        dr["pgcstamp"] = Pbl.Stamp();
                        dr["conta"] = r["codigo"];
                        dr["Descricao"] = r["Descricao"];
                        _dtPgc.Rows.Add(dr);
                    }
                    else
                    {
                        AddToList(r["Descricao"].ToString());
                    }
                    if (fim)
                    {
                        GravarDados(_dtPgc, "pgc");
                    }
                    break;

                case "diario":
                    if (!SQL.CheckExist("Dino", "diario", $"Dino={r["codigo"].ToTrim()} and diano ={nupDest.Value}"))
                    {
                        var stamp= Pbl.Stamp();
                        var dr2 = _dtDiario.NewRow().Inicialize();
                        dr2["diano"] = nupDest.Value;
                        dr2["Dino"] = r["codigo"];
                        dr2["Descricao"] = r["Descricao"];
                        dr2["diariostamp"] = stamp;
                        _dtDiario.Rows.Add(dr2);
                        var docs = SQL.GetGen2DT($"select * from Diariodoc where Diariostamp='{r["pgcstamp"].ToString().Trim()}'");
                        if (docs?.Rows.Count>0)
                        {
                            foreach (var d in docs.AsEnumerable())
                            {
                                if (d == null) continue;
                                var dr3 = _dtDiariodos.NewRow().Inicialize();
                                dr3["Diariodocstamp"] = Pbl.Stamp();
                                dr3["diariostamp"] = stamp;
                                dr3["codigo"] =d["codigo"];
                                dr3["Descricao"] = d["Descricao"];
                                dr3["Padrao"] = d["Padrao"];
                                _dtDiariodos.Rows.Add(dr3);
                            }
                        }
                    }
                    else
                    {
                        AddToList(r["Descricao"].ToString());
                    }
                    if (fim)
                    {
                        if (GravarDados(_dtDiario, "diario")>0)
                        {
                            GravarDados(_dtDiariodos, "Diariodoc",true);
                        }
                    }
                    break;
            }
        }

        private void AddToList(string descicao)
        {
            if (_listaContas.IsNullOrEmpty())
            {
                _listaContas = descicao;
            }
            else
            {
                _listaContas = _listaContas + "\r\n" + descicao;
            }
        }

        private int GravarDados(DataTable dt, string tabela,bool filha=false)
        {
            var ret = SQL.Save(dt, tabela, true, "", "");
            if (filha) return ret.numero;
            if (ret.numero > 0)
            {
                //Helper.Alert("Processo finalizado com sucesso", Form_Alert.EnmType.Success);
                //MsBox.Show(Messagem.ParteInicial() + "Processo finalizado com sucesso");
                if (!_listaContas.IsNullOrEmpty())
                    switch (tabela)
                    {
                        case "diario":
                            MsBox.Show(Messagem.ParteInicial() +
                                       $"O Software informa que os seguintes diários já tinha sido criados no referido ano !\r\n{_listaContas}");
                            break;
                        case "pgc":
                            MsBox.Show(Messagem.ParteInicial() +
                                       $"O Software informa que as seguintes contas já tinha sido criadas no referido ano !\r\n{_listaContas}");
                            break;
                    }
                else
                    return ret.numero;
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + $"Erro ao gravar dados!\r\n{ret.messagem}");
            }
            return ret.numero;
        }

        private void BtnProcura_Click(object sender, EventArgs e)
        {
            if (nupdAnoOrig.Value == nupDest.Value)
            {
                MsBox.Show("O ano de origem e destino deve ser diferente!");
                return;
            }
            var str = "";
            if (rbPgc.cb1.Checked)
            {
                str = $"select conta as codigo,descricao,ano,pgcstamp,integracao, ok=Cast( 0 as bit),origem='pgc' from pgc where ano={nupdAnoOrig.Value} order by conta";
            }
            if (rbDiario.cb1.Checked)
            {
                str = $"select convert(varchar(3),dino) as codigo,descricao,ano=diano,pgcstamp=Diariostamp,integracao=0, ok=Cast( 0 as bit),origem='diario' from diario where diano={nupdAnoOrig.Value} order by dino";
            }
            _dt = SQL.GetGen2DT(str);
            if (_dt.Rows.Count == 0)
                MsBox.Show($"Não existe nenhum registo para as condicoes dadas: Ano '{nupdAnoOrig.Value}'");
            else
            {
                dataGridView1.SetDataSource(_dt);
            }
        }

        private void rbPgc_CheckedChangeds()
        {
            rbDiario.Update(!rbPgc.cb1.Checked);
        }

        private void rbDiario_CheckedChangeds()
        {
            rbPgc.Update(!rbDiario.cb1.Checked);
        }

        private void cbDefault1_CheckedChangeds()
        {
            dataGridView1.CheckUncheckAll("ok", cbDefault1.cb1.Checked);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                if (dataGridView1.CurrentCell.OwningColumn.Name.Equals("ok"))
                {
                    dataGridView1.CurrentCell.Value = !(dataGridView1.CurrentCell.Value is DBNull) && !dataGridView1.CurrentCell.Value.ToBool();//aqui seta o true ou false quando clica manualmente 
                    dataGridView1.Update();
                }
        }

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
    }
}
