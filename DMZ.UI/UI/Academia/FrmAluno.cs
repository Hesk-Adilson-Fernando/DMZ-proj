using System;
using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI
{
    public partial class FrmAluno : Basic.FrmClasse
    {
        private Cl _cl;
        public FrmAluno()
        {
            InitializeComponent();
        }

        private void FrmEst_Load(object sender, EventArgs e)
        {
            Campo1 = "no";
            Campo2 = "nome"; 
            Ctabela = "cl";
            CCondicao = "Aluno=1";
        }
        public override void DefaultValues()
        {
            _cl = DoAddline<Cl>();
            base.DefaultValues();
            status.SetStatusValue();
            var pais = SQL.GetField("select Descricao from Paises where Codigo='MZ'");
            tbPais.tb1.Text = pais.ToString();
            _cl.Aluno = true;
            tbNumero.tb1.Text = "..";
            tbCcusto.SetCCustoValue();
            gridUiPlano.DataSource = null;
        }
        public override void Save()
        {
            FillEntity(_cl);
            EF.Save(_cl);
        }
        public override bool BeforeSave()
        {
            if (!Procurou)
            {
                var xx = $@"Select Max(convert(int,dbo.UDF_ExtractNumbers(no)))+1 as maxvalue  from cl where aluno =1";
                var dt = SQL.GetGenDT(xx);
                if (dt.HasRows())
                {
                    tbNumero.tb1.Text = GetValueByMascara(Pbl.Param.Anolectivo.ToString(), Pbl.Param.Mascaracl, dt);
                }
            }
            return base.BeforeSave();   
        }
        internal  string GetValueByMascara(string sigla, string mascara, DataTable dt)
        {
            var refec = "";
            var numero = dt.Rows[0][0].ToDecimal();
            if (numero>Pbl.Param.Anolectivo.ToDecimal())
            {
                numero = numero.ToString().Substring(4, Pbl.Param.Mascaracl.Length).ToDecimal();
            }
            switch (numero.ToString().Length)
            {
                case 1:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 1) + numero;
                    break;

                case 2:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 2) + numero;
                    break;
                case 3:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 3) + numero;
                    break;
                case 4:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 4) + numero;
                    break;
                case 5:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 5) + numero;
                    break;
                case 6:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 6) + numero;
                    break;
                case 7:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 7) + numero;
                    break;
                case 8:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 8) + numero;
                    break;
                case 9:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 9) + numero;
                    break;
                case 10:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 10) + numero;
                    break;
            }
            return refec;
        }
        public override bool BeforeDelete()
        {

            return base.BeforeDelete(); 
        }
        public override bool CheckDelete()
        {
            var dt = SQL.GetGenDT($"select top 1 no from fact where no ={tbNumero.tb1.Text.ToDecimal()}");
            if (!(dt?.Rows.Count > 0)) return base.CheckDelete();
            MsBox.Show($"Descupla mas o cliente: \r\n {tbNome.tb1.Text} tem facturas emitidas já não se pode eliminar!.. ");
            return false;
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _cl = FillControls(_cl, dt, i);
            PreenchePlanoCurricularCurso();
            AgendaDivida();
            Turmas();
        }

        private void Turmas()
        {
            var xx = $@"select Turma.Codigo,Turma.Descanoaem,Turma.Turmastamp from Turma 
                                join Turmal on Turma.Turmastamp=Turmal.Turmastamp where Clstamp='{CLocalStamp.Trim()}' and Turma.Descanoaem=(select AnoSem from param) order by Turma.codigo";
            var dt = SQL.GetGen2DT(xx);
            gridUiTurmas.SetDataSource(dt);
        }

        private void AgendaDivida()
        {
            var xx = $@"select descricao,valorreg,ccstamp,Fact.data,Fact.Dataven,tmp1.Referencia,fact.Numero,tmp1.Entidadebanc from (
                                select* from ClCCF() where Clstamp = '{CLocalStamp}')tmp1 join fact on tmp1.ccstamp = fact.Factstamp order by Numero";
            var dtcc = SQL.GetGen2DT(xx);
            gridUiCC.SetDataSource(dtcc);
            if (dtcc.HasRows())
            {
                tbTotal.Text = dtcc.Sum("valorreg").ToString("N2");
            }
            else
            {
                tbTotal.Text = "";
            }
        }

        private void gridFiliacao_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridFiliacao.CurrentRow == null) return;
            var name = gridFiliacao.CurrentCell.OwningColumn.Name;
            string qry;
            if (name.Equals("GrauParentesco"))
            {
                qry = "select descricao from PeAuxiliar where tabela =7";
                Helper.SetBinds(e.Control, "descricao", qry);
            }

        }

        private void dgvDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.SetDateTimePicker(dgvDocumento);
            Helper.SetPdfFile(dgvDocumento, "anexo", "pdf");
            Helper.ViewPdfFile(dgvDocumento, "ver", "pdf");
        }

        private void dgvDocumento_EditingControlShowing(object sender,DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDocumento.CurrentRow == null) return;
            const string qry = "select descricao from PeAuxiliar where tabela =1";
            var name = dgvDocumento.CurrentCell.OwningColumn.Name;
            if (name.Equals("TipoDocumento"))
            {
                Helper.SetBinds(e.Control, "descricao", qry);
            }
            if (dgvDocumento.CurrentRow == null) return;
            const string qrypr = "select descricao from prov";
            var nameLocalEmissao = dgvDocumento.CurrentCell.OwningColumn.Name;
            if (nameLocalEmissao.Equals("localEmissao"))
            {
                Helper.SetBinds(e.Control, "descricao", qrypr);
            }

        }
        private void gridUi3_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridBolsa.CurrentRow == null) return;
            var qry = "select Descricao from Alauxiliar where";
            var name = gridBolsa.CurrentCell.OwningColumn.Name;
            if (name.Equals("clnInstituicao"))
            {
                qry += " tabela =3";
                Helper.SetBinds(e.Control, "descricao", qry);
            }
            else if (name.Equals("clntipobolsa"))
            {
                qry += " tabela =4";
                Helper.SetBinds(e.Control, "descricao", qry);
            }
        }

        private void gridBolsa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Helper.SetDateTimePicker(gridBolsa); 
        }
        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            MenuLateral.ShowMenuStrip(btnMenuLateral);
        }

        private void procura1_RefreshControls()
        {
            tbPlanocurricular.Condicao = $"Cursostamp ='{procura1.Text2.Trim()}'";
        }

        private void tbPlanocurricular_Load(object sender, EventArgs e)
        {

        }

        private void tbPlanocurricular_CondicaProcura()
        {
            tbPlanocurricular.Condicao = $"Cursostamp ='{procura1.Text2.Trim()}'";
        }

        private void tbPlanocurricular_RefreshControls()
        {
            PreenchePlanoCurricularCurso();
        }

        private void PreenchePlanoCurricularCurso()
        {
            var dt = SQL.GetGenDT($"select * from gradel where gradestamp='{tbPlanocurricular.Text2}' order by Codetapa ");
            gridUiPlano.SetDataSource(dt);
        }

        private void ucProvincia_RefreshControls()
        {
            ucDistrito.Condicao = $" prov.Descricao='{ucProvincia.tb1.Text.Trim()}'"; ;
            ucDistrito.tb1.Text = "";
        }

        private void btnCcorrente_Click(object sender, EventArgs e)
        {
            var f = new FrmRelatorios { Modulo = "GES" };
            f.label1.Text = @"CONTA CORRENTE DO ALUNO";
            f.CondicaoOrigem = "and Mostracfe =1";
            f.ShowForm(this);
        }

        private void últimasComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNome.tb1.Text))
            {
                var f = new FrmCc
                {
                    txtNome = { Text = tbNome.tb1.Text },
                    txtNumero = { Text = tbNumero.tb1.Text },
                    label1 = { Text = @"Extrato de vendas e regularizações" },
                    Cl = true,
                    Tipo = "Cliente"
                };
                f.Moeda.tb1.Text = "MZN";
                f.Clstamp = CLocalStamp;
                f.ShowForm(this);
            }
            else
            {
                MsBox.Show("Deve indicar o cliente!..");
            }
        }

        private void dgvLingua_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvLingua.CurrentRow == null) return;
            string qry;
            var name = dgvLingua.CurrentCell.OwningColumn.Name;
            if (name.Equals("Lingua"))
            {
                qry = "select descricao from PeAuxiliar where tabela =2 ";
                Helper.SetBinds(e.Control, "descricao", qry);
            }
            else
            {
                qry = "select descricao from PeAuxiliar where tabela =12 ";
                if (name.Equals("fala"))
                {
                    Helper.SetBinds(e.Control, "descricao", qry);
                }
                if (name.Equals("Leitura"))
                {
                    Helper.SetBinds(e.Control, "descricao", qry);
                }
                if (name.Equals("Escrita"))
                {
                    Helper.SetBinds(e.Control, "descricao", qry);
                }
                if (name.Equals("Compreensao"))
                {
                    Helper.SetBinds(e.Control, "descricao", qry);
                }
            }
        }

        private void listagemDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmGenreport
            {
                Gendt = SQL.GetGen2DT("Select Codigo, nome, Convert(date, Data) [Data], Convert(date, Datavenc) [DataVenc] from cl join clcart on cl.Clstamp = ClCart.Clstamp where aluno = 1"),
                Titulo = "Listagem de alunos"
            };
            f.ShowForm(this);
        }
        //Copia ess3s dois metidos
        private void importarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var alunos = SQL.GetGen2DT("select * from estudante");
            if (alunos.HasRows())
            {
                Helper.DoProgressProcess(alunos, RecebeDados, "nome_completo");
            }
        }

        string lista = "";
        private void RecebeDados(DataRow dr, bool fim)
        {
            if (dr != null)
            {
                var cl = DoAddline<Cl>();
                cl.Ccusto = Pbl.Usr.Ccusto;
                if (!dr["numero"].ToString().IsNullOrEmpty())
                {
                    if (!SQL.CheckExist("no", "cl", $"no='{dr["numero"].ToString().Trim()}'"))
                    {
                        cl.No = dr["numero"].ToString();
                    }
                    else
                    {
                        var ano = dr["numero"].ToString().Substring(0, 4);
                        if (!SQL.CheckExist("no", "cl", $"no='{dr["numero"].ToString().Replace(ano, "2015").Trim()}'"))
                        {
                            cl.No = dr["numero"].ToString().Replace(ano, "2015");
                        }
                        else
                        {
                            cl.No = dr["numero"].ToString().Replace(ano, "2014");
                        }

                    }

                }
                //else
                //{
                //    if (dr["ano_ingresso"].ToDecimal() != 0)
                //    {
                //        var xx = $@"Select Max(convert(int,dbo.UDF_ExtractNumbers(no)))+1 as maxvalue  from cl where aluno =1 and year(Anoingresso)={dr["ano_ingresso"].ToDecimal()}";
                //        var dt = SQL.GetGenDT(xx);
                //        if (dt.HasRows())
                //        {
                //            cl.No = GetValueByMascara(dr["ano_ingresso"].ToString(), Pbl.Param.Mascaracl, dt);
                //        }
                //    }
                //}
                cl.Nome = dr["nome_completo"].ToString();
                if (!dr["data_nascimento"].ToString().IsNullOrEmpty())
                {
                    cl.Datanasc = dr["data_nascimento"].ToDateTimeValue();
                }
                else
                {
                    cl.Datanasc = new DateTime(1900, 1, 1);
                }
                if (dr["ano_ingresso"].ToDecimal() != 0)
                {
                    cl.Anoingresso = new DateTime(dr["ano_ingresso"].ToInt(), 1, 1);// dr["ano_ingresso"].ToDateTimeValue();
                }
                else
                {
                    var ano = dr["numero"].ToString().Substring(0, 4);
                    if (ano.ToString().Length==4)
                    {
                        cl.Anoingresso = new DateTime(ano.ToInt(), 1, 1);
                    }
                    //else
                    //{
                    //    MsBox.Show(ano.ToString());
                    //}
                    // dr["ano_ingresso"].ToDateTimeValue();
                }
                cl.Obs = "IMPORTADO";
                cl.Aluno = true;
                cl.Email = dr["Email"].ToString();
                cl.Morada = dr["endereco"].ToString();
                cl.Nuit = dr["Nuit"].ToDecimal();//
                cl.Celular = dr["telefone"].ToInt().ToString();
                cl.Sexo = dr["sexo_id"].ToInt() == 1 ? "Masculino" : "Femenino";
                var curso = SQL.GetRowToEnt<Curso>($"obs='{dr["curso_id"].ToInt()}'");
                if (curso != null)
                {
                    cl.Curso = curso.Desccurso;
                    cl.Codcurso = curso.Cursostamp;
                    var Grade = SQL.GetGen2DT($"select Gradestamp,Descricao,Codigo from Grade where Cursostamp='{curso.Cursostamp}'");
                    if (Grade.HasRows())
                    {
                        cl.Gradestamp = Grade.RowZero("Gradestamp").ToString();
                        cl.Descgrelha = Grade.RowZero("Descricao").ToString();
                    }
                }
                cl.Ccustostamp = Pbl.Usr.Ccustamp;
                cl.Ccusto= Pbl.Usr.Ccusto;
                if (EF.Save(cl).ret>0)
                {
                    if (!dr["nome_pai"].ToString().IsNullOrEmpty() && !dr["nome_mae"].ToString().IsNullOrEmpty())
                    {
                        var clfam = SQL.Initialize("ClContact");
                        if (!dr["nome_mae"].ToString().IsNullOrEmpty())
                        {

                            var r = clfam.NewRow().Inicialize();
                            r["clstamp"] = cl.Clstamp;
                            r["nome"] = dr["nome_mae"];
                            r["mae"] = true;
                            clfam.Rows.Add(r);
                        }
                        if (!dr["nome_pai"].ToString().IsNullOrEmpty())
                        {
                            var r2 = clfam.NewRow().Inicialize();
                            r2["clstamp"] = cl.Clstamp;
                            r2["nome"] = dr["nome_pai"];
                            r2["pai"] = true;
                            clfam.Rows.Add(r2);
                        }
                        if (clfam.HasRows())
                        {
                            SQL.Save(clfam, "ClContact", true, cl.Clstamp, "Cl");
                        }
                    }
                }
                else
                {
                    lista = $"{lista}\r\n{cl.Nome},{cl.No}";
                }
                if (fim)
                {
                    MsBox.Show(lista.ToString());
                }
            }
        }

        private void importarContaCorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Util.ShowForm(this, "Frmimportarconta");
        }
    }
}
