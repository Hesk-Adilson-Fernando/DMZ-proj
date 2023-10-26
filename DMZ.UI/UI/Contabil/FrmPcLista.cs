using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DMZ.UI.UI.Contabil
{
    public partial class FrmPcLista : DMZ.UI.Basic.FrmClasse2
    {
        public FrmPcLista()
        {
            InitializeComponent();
        }

        public string Condicao { get; internal set; }

        private void FrmPcLista_Load(object sender, EventArgs e)
        {
            nrAno.Value= Pbl.AnoContabil();
            filtro=$"ANO ={Pbl.AnoContabil()}";
            BindGrid();
        }

        private void BindGrid()
        {
            var str=$"select conta,descricao,ano,tipo=iif(integracao=1,'I','M') from pgc where {Condicao} order by Conta";
            var dt = SQL.GetGen2DT(str);
            if (dt?.Rows.Count>0)
            {
                gridContas.DataSource=null;
                gridContas.AutoGenerateColumns=false;
                gridContas.DataSource=dt;
            }
        }
        string filtro ="";
        private void btnProcessar_Click(object sender, EventArgs e)
        {
            Condicao="";
            if (rbContasDois.cb1.Checked)
            {
                if (string.IsNullOrEmpty(Condicao))
                {
                    Condicao ="len(conta)=2";
                    filtro="Contas de dois dígitos";
                }
                else
                {
                    Condicao=Condicao+" and len(conta)=2";
                    filtro=filtro+"\r\nContas de dois dígitos";
                }
            }
            if (rbInteg.cb1.Checked)
            {
                if (string.IsNullOrEmpty(Condicao))
                {
                    Condicao ="integracao=1";
                    filtro="Contas de integração";
                }
                else
                {
                    Condicao=Condicao+" and integracao=1";
                    filtro=filtro+"\r\nContas de integração";
                }
            }
            if (rbContasMov.cb1.Checked)
            {
                if (string.IsNullOrEmpty(Condicao))
                {
                    Condicao ="integracao=0";
                    filtro="Contas de movimento";
                }
                else
                {
                    Condicao=Condicao+" and integracao=0";
                    filtro=filtro+"Contas de dois dígitos";
                }
            }
            Condicao=Condicao+$" and ano ={nrAno.Value}";
            BindGrid();
        }

        private void rbContasMov_CheckedChangeds()
        {
            rbContasDois.Update(false);
            rbInteg.Update(false);
        }

        private void rbInteg_CheckedChangeds()
        {
            rbContasDois.Update(false);
            rbContasMov.Update(false);
        }

        private void rbContasDois_CheckedChangeds()
        {
            rbContasMov.Update(false);
            rbInteg.Update(false);
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            var dt = gridContas.DataSource as DataTable;
            if (dt?.Rows.Count > 0)
            {
                DS ds = new DS();
                var ret = Imprimir.FillData(null, dt, null, ds.DMZ, null);
                Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false, label1.Text, "", "RptPgcLista", "CT", this, "", true, ds,filtro, $"Plano de Contas".ToUpper());
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial()+"Não tem nada para imprimir");
            }

        }
    }
}
