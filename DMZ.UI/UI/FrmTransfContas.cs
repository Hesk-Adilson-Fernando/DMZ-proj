using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Controls;

namespace DMZ.UI.UI
{
    public partial class FrmTransfContas : Basic.FrmClasse
    {
        public FrmTransfContas()
        {
            InitializeComponent();
        }

        private Trf _trf;
        private void FrmTransfContas_Load(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "Origem";
            Ctabela = "Trf";
            ContaOrigem.ReturnDt = true;
        }
        public override void DefaultValues()
        {
            _trf = DoAddline<Trf>();
            base.DefaultValues();
        }

        public override bool IsValido()
        {
            var conta = SQLExec.QEnt<Contas>($"Select * from contas (nolock) where codigo={_trf.Orinum}");
            var str = "Select ISNULL(SUM(entrada-saida),0) saldo,codlocal FROM mvt (nolock) " +
                      $"where codlocal ={_trf.Orinum}  and convert(varchar,datamov, 103) <= '{dtData.dt1.Value.Date}' and LTRIM(RTRIM(oristamp))<> '{_trf.Trfstamp.Trim()}' " +
                      "group by codlocal";
            var dt = SQLExec.GetGenDT(str);
            if (conta != null)
            {
                if (conta.Noneg)
                {
                    if (dt?.Rows.Count > 0)
                    {
                        if (dt.Rows[0]["Saldo"].ToDecimal() - tbValor.tB1.Text.ToDecimal() < 0)
                        {
                            MsBox.Show("Desculpe a conta de Origem tem Saldo inferior ao valor do Movimento. Obrigado");
                            return false;
                        }
                        return true;
                    }
                    MsBox.Show("Desculpe a conta de Origem não tem Saldo para este Movimento. Obrigado");
                    return false;
                }
                return true;
            }

            MsBox.Show("Desculpe mas a conta de Origem não existe. Obrigado");
            return false;
        }
        public override void Gravar()
        {
            FillEntity(_trf);
            SQLExec.Save(_trf);
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _trf = FillControls(_trf, dt, i);
        }

        private void FormaP_RefreshControls()
        {
            tbTitulo.tB1.ReadOnly = !FormaP.Text3.Trim().Equals("1");
        }

        private void ContaOrigem_RefreshControls()
        {
            _trf.Orinum = ContaOrigem.TmpFound.Rows[0]["codigo"].ToString().ToDecimal();
            _trf.Moeda1 = ContaOrigem.TmpFound.Rows[0]["moeda"].ToString();
            var cod = ContaOrigem.TmpFound.Rows[0]["codTipo"].ToString().ToDecimal();
            
            if (cod == 1)
            {
                FormaP.tb1.Text = @"NUMERÁRIO";
                tbTitulo.tB1.ReadOnly = true;
            }
            else
            {
                FormaP.tb1.Text = @"TRANSF. BANCÁRIA";
                tbTitulo.tB1.ReadOnly = false;
            }
        }
    }
}
