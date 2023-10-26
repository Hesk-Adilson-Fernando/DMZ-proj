using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmCaixa : Basic.FrmClasse
    {
        private Caixa _caixa;
        public DataTable Formasp { get; set; }
        private DataRow Conta;
        public Action<Caixa> Enviar;
        public FrmCaixa()
        {
            InitializeComponent();
        }

        private void FrmCaixa_Load(object sender, EventArgs e)
        {
            Campo1 = "Numero";
            Campo2 = "Contatesoura";
            Ctabela = "caixa";
            CCondicao = $"Usrstamp='{Pbl.Usr.Usrstamp}'";
            Formasp = SQL.Initialize("Formasp");
            if (Pbl.DtContas.HasRows())
            {
                Conta = Pbl.DtContas.GetFirstOrDefault("cx=1");
            }
        }

        public override void DefaultValues()
        {
            _caixa = DoAddline<Caixa>();
            _caixa.No = Pbl.Usr.Numero;
            _caixa.Nome = Pbl.Usr.Nome;
            _caixa.Qmc = Pbl.Usr.Login;
            _caixa.Moeda = Pbl.MoedaBase;
            _caixa.Usrstamp = Pbl.Usr.Usrstamp;    
            if (!Conta.DataRowIsNull())
            {
                caixa.tb1.Text = Conta["contas"].ToString();
                caixa.Text2 = Conta["Codtz"].ToString();
                caixa.Text3 = Conta["Contasstamp"].ToString();
            }
            tbVendedor.tb1.Text = Pbl.Usr.Nome;
            tbCCusto.tb1.Text = Pbl.Usr.Ccusto;
            tbCCusto.Text2 = Pbl.Usr.Codccu;
            tbCCusto.Text3 = Pbl.Usr.Ccustamp;
            _caixa.Supervisor = Pbl.Usr.Supervisor;
            base.DefaultValues();
        }

        public int Origem = 0;
        public override bool BeforeSave()
        {
            var check = SQL.GetGen2DT($@"Select * from caixa where fechado = 0 and Caixastamp ='{caixa.Text3.Trim()}' and 
                            Convert(date,Data)='{dtDefault1.dt1.Value.ToSqlDate()}' and Usrstamp='{Pbl.Usr.Usrstamp}'");
            if (!check.HasRows()) return base.BeforeSave();
            MsBox.Show($"O caixa {caixa.tb1.Text} já foi aberto hoje!");
            return false;
        }

        
        public override void Save()
        {
            _caixa.Ccusto = Pbl.Usr.Ccusto;
            _caixa.Ccustamp = Pbl.Usr.Ccustamp;
            FillEntity(_caixa);
            _caixa.Numero = caixa.Text2.ToDecimal();
            if (EF.Save(_caixa).ret != 1) return;
            Enviar(_caixa);
        }

        public override void AfterSave()
        {
            var fp = BL.Classes.Utilities.DoAddline<Formasp>();
            fp.Codtz = caixa.Text2.ToDecimal();
            fp.Contasstamp = caixa.Text3.ToString();
            fp.Contatesoura = caixa.tb1.Text;
            fp.Valor = tbValor.tb1.Text.ToDecimal();
            fp.Dcheque = _caixa.Data;
            fp.UsrLogin = Pbl.Usr.Usrstamp;
            fp.Titulo = "ABERTURA";
            fp.Codmovtz = 6;
            fp.Descmovtz = "ABERTURA";
            fp.AberturaCaixa = true;
            fp.Ccusto=_caixa.Ccusto;
            fp.Ccustamp = Pbl.Usr.Ccustamp;
            fp.Oristamp = _caixa.Caixastamp;
            fp.No = _caixa.No;
            fp.Origem = "ABERTURA";
            fp.Nome = _caixa.Nome;
            fp.Moeda = Pbl.MoedaBase;
            fp.Banco = "CAIXA";
            EF.Save(fp);
        }



        public override void PreencheCampos(DataTable dt, int i)
        {
            _caixa = FillControls(_caixa, dt, i);
        }

        private void tbTvendas_CondicaProcura()
        {
            tbTvendas.Condicao =$"Ccustamp='{Pbl.Usr.Ccustamp}'";
        }
    }
}
