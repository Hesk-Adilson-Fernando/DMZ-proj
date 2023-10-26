using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Data;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.Basic;

namespace DMZ.UI.UI
{
    public partial class FrmContas : Basic.FrmClasse
    {
        public FrmContas()
        {
            InitializeComponent();
        }
        private void FrmContas_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "descricao";
            Ctabela = "contas";
            tbSaldo.Visible=!Pbl.Usr.Mostrasaldo;
            tbSaldoMextrangeira.Visible=!Pbl.Usr.Mostrasaldo;
            tbSaldoReconciliado.Visible=!Pbl.Usr.Mostrasaldo;
        }
        private Contas _contas;
        public void Alert(string msg, Form_Alert.EnmType type)
        {
            var frm = new Form_Alert();
            frm.ShowAlert(msg,type);
        }
        public override void DefaultValues()
        {
            _contas = DoAddline<Contas>();
            status.SetStatus();
            base.DefaultValues();
        }
        public override void AfterSave()
        {
            var ct = SQL.GetDT("EmpresaMod", "sigla", "Sigla='CT'", null);
            if(ct?.Rows.Count<0) return;
                if (SQL.GetField("select Criacontas from param").ToBool())
                {
                    var tipoconta = tbTipoConta.Text2.Trim();
                    var decscicao = tbBanco.Text2.Trim() + " " + tipoconta + tbNumeroConta.tb1.Text+" " +tbMoeda.tb1.Text;
                    var conta = tipoconta + tbNumeroConta.tb1.Text;
                    Helper.GravaConta(_contas.Contasstamp, decscicao, conta,OldcConta);
                    //SQL.SqlCmd($"update contas set ContaPgc='{conta}' where Contasstamp='{_contas.Contasstamp}'");
                    //SQL.SqlCmd($"update pgc set integracao = 1 where conta ='{tipoconta}' and ano =(select ano from param)");
                    //tbContaPgc.tB1.Text = conta;
                }

                if (tbTipoConta.Text2.ToDecimal() <= 11) return;
                {
                    if (tbTipoConta.Text2.ToDecimal() == 121)
                    {
                        if (SQL.GetField("select Criacontasprazo from param").ToBool())
                        {
                            var decscicao = tbBanco.Text2.Trim() + " " + "122" + tbNumeroConta.tb1.Text+" " +tbMoeda.tb1.Text;
                            var conta = "122" + tbNumeroConta.tb1.Text;
                            Helper.GravaConta(_contas.Contasstamp, decscicao, conta,OldcConta);
                            SQL.SqlCmd("update pgc set integracao = 1 where conta ='122' and ano =(select ano from param)");
                            decscicao = tbBanco.Text2.Trim() + " " + "123" + tbNumeroConta.tb1.Text+" " +tbMoeda.tb1.Text;
                            conta = "123" + tbNumeroConta.tb1.Text;
                            Helper.GravaConta(_contas.Contasstamp, decscicao, conta,OldcConta);
                            SQL.SqlCmd("update pgc set integracao = 1 where conta ='123' and ano =(select ano from param)");
                        }
                    }

                    if (tbTipoConta.Text2.ToDecimal() == 122)
                    {
                        if (SQL.GetField("select Criacontasprazo from param").ToBool())
                        {
                            var decscicao = tbBanco.Text2.Trim() + " " + "121" + tbNumeroConta.tb1.Text+" " +tbMoeda.tb1.Text;
                            var conta = "121" + tbNumeroConta.tb1.Text;
                            Helper.GravaConta(_contas.Contasstamp, decscicao, conta,OldcConta);
                            SQL.SqlCmd("update pgc set integracao = 1 where conta ='121' and ano =(select ano from param)");
                            decscicao = tbBanco.Text2.Trim() + " " + "123" + tbNumeroConta.tb1.Text;
                            conta = "123" + tbNumeroConta.tb1.Text;
                            Helper.GravaConta(_contas.Contasstamp, decscicao, conta,OldcConta);
                            SQL.SqlCmd("update pgc set integracao = 1 where conta ='123' and ano =(select ano from param)");
                        }
                    }

                    if (tbTipoConta.Text2.ToDecimal() != 123) return;
                    {
                        if (!SQL.GetField("select Criacontasprazo from param").ToBool()) return;
                        var decscicao = tbBanco.Text2.Trim() + " " + "122" + tbNumeroConta.tb1.Text+" " +tbMoeda.tb1.Text;
                        var conta = "122" + tbNumeroConta.tb1.Text;
                        Helper.GravaConta(_contas.Contasstamp, decscicao, conta,OldcConta);
                        SQL.SqlCmd($"update pgc set integracao = 1 where conta ='122' and ano =(select ano from param)");
                        decscicao = tbBanco.Text2.Trim() + " " + "121" + tbNumeroConta.tb1.Text+" " +tbMoeda.tb1.Text;
                        conta = "121" + tbNumeroConta.tb1.Text;
                        Helper.GravaConta(_contas.Contasstamp, decscicao, conta,OldcConta);
                        SQL.SqlCmd($"update pgc set integracao = 1 where conta ='121' and ano =(select ano from param)");
                    }
                }
        }
        public override bool BeforeSave()
        {
            if (Procurou) return base.BeforeSave();
            if (!SQL.CheckExist($"select Numero from Contas where numero ={tbNumeroConta.tb1.Text.ToDecimal()} "))
                return base.BeforeSave();
            MsBox.Show($"Desculpe já existe uma conta com o numero: \r\n{tbNumeroConta.tb1.Text}");
            return false;
        }
        public override void Save()
        {
            FillEntity(_contas);
            EF.Save(_contas);
        }

        public string OldcConta { get; set; }
        public override bool CheckDelete()
        {
            var existe = SQL.CheckExist($"select top 1 Codlocal from mvt where Codlocal ={tbNumero.tb1.Text.ToDecimal()} and local LIKE('%{tbNumeroConta.tb1.Text.ToDecimal()}%') ");
            if (existe.ToBool())
            {
                MsBox.Show($"Descupla mas a conta: \r\n {tbNome.tb1.Text} tem movimentos emitidos já não se pode eliminar!.. ");
                return false;
            }
            return base.CheckDelete();
        }
        public override void PreencheCampos(DataTable dt, int i) => _contas = FillControls(_contas, dt, i);

        private void btnExtratos_Click(object sender, EventArgs e)
        {

        }

        private void btnCriaContasCT_Click(object sender, EventArgs e)
        {

        }

        private void tbMoeda_RefreshControls()
        {
            if (tbMoeda.tb1.Text.Equals("MZN"))
            {
                cbMoedaEst.Update(true);
            }
            else
            {
                cbMoedaEst.Update(false);
            }
        }

        private void tbDefault2_Load(object sender, EventArgs e)
        {

        }

        private void Extrato_Click(object sender, EventArgs e)
        {
            if (!Pbl.Usr.Mostrasaldo)
            {
                if (!string.IsNullOrEmpty(tbNumero.tb1.Text)) 
                {
                    var frmMvtcc = new FrmMvtcc
                    {
                        cbConta = {Text = tbNome.tb1.Text +@"-"+tbNumeroConta.tb1.Text }
                    };
                    frmMvtcc.Moeda=tbMoeda.tb1.Text;
                    frmMvtcc.Contasstamp = CLocalStamp.Trim();
                    frmMvtcc.ShowForm(this);
                    frmMvtcc.cbConta.SelectedValue = CLocalStamp.Trim();
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial()+"Deve indicar a conta que pretende ver os movimentos!");
                }
            }
            else
            {
                    MsBox.Show(Messagem.ParteInicial()+"Não tem permisão ao extrato das contas!");
            }

        }

        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            Menu.ShowMenuStrip(btnMenuLateral);
        }

        private void refrescarSaldoToolStripMenuItem_Click(object sender, EventArgs e)
        {
                if (!string.IsNullOrEmpty(tbNumero.tb1.Text)) 
                {
                var qry = $@"update contas set saldo=tmp1.saldo,msaldo=tmp1.msaldo from (
				SELECT ISNULL(SUM(entrada-saida),0) saldo,ISNULL(SUM(mentrada-msaida),0) msaldo,codlocal FROM mvt (nolock) where mvt.Contasstamp='{CLocalStamp.Trim()}' group by mvt.codlocal
			            )tmp1 inner join contas on contas.codigo=tmp1.codlocal ";
                    if (SQL.SqlCmd(qry)>0)
                    {
                        btnRefresh.PerformClick();
                        Alert("Actualização feita com sucesso",Form_Alert.EnmType.Success);
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial()+"Deve indicar a conta que pretende ver os movimentos!");
                }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                if (!string.IsNullOrEmpty(tbNome.tb1.Text))
                {

                    if (!CLocalStamp.IsNullOrEmpty())
                    {
                        if (!tbNumeroConta.tb1.Text.IsNullOrEmpty())
                        {
                            if (!tbTipoConta.Text2.IsNullOrEmpty())
                            {
                                var conta = tbTipoConta.Text2.Trim() + tbNumeroConta.tb1.Text.Trim();
                                if (!SQL.CheckExist($"select oristamp from pgc where oristamp ='{CLocalStamp.Trim()}' and ano ={Pbl.Param.Ano} and conta ='{conta.Trim()}'"))
                                {
                                    var pgc = Utilities.DoAddline<Pgc>();
                                    pgc.Pgcstamp = Pbl.Stamp();
                                    pgc.Oristamp = CLocalStamp.Trim();
                                    pgc.Conta = conta;
                                    pgc.Descricao = tbNome.tb1.Text;
                                    pgc.Ano = Pbl.Param.Ano;
                                    if (EF.Save(pgc).ret > 0)
                                    {
                                        tbContaPGC.tb1.Text = conta;
                                        MsBox.Show("Conta gravada na contabilidade com sucesso!");
                                    }
                                }
                                else
                                {
                                    MsBox.Show("Ja existe a conta na contabilidade ");
                                }
                            }
                            else
                            {
                                MsBox.Show("O tipo da conta não pode estar vazia");
                            }
                        }
                        else
                        {
                            MsBox.Show("O número da conta não pode estar vazia");
                        }
                    }
                }
                else
                {
                    MsBox.Show("A descrição não pode estar vazia");
                }
            }
            else
            {
                MsBox.Show("Deve estar em modo de ediçaão, e lembre se de gravar os dados da conta");
            }
        }

        private void actualizarOStampParaMovimentosImportadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dr = MsBox.Show("Deseja executar essa operação? \r\nNote que ela é ariscada pode afectar a integridade de dados",DResult.YesNo);
            if (dr.DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                if (Procurou)
                {

                    var xx=SQL.SqlCmd($"update formasp set Contasstamp ='{_contas.Contasstamp.Trim()}' where codtz={_contas.Codigo} and contatesoura like('%{_contas.Numero}%')");
                    if (xx>1)
                    {
                        MsBox.Show("Processo executado com sucesso!");
                    }
                }
            }
        }
    }
}
