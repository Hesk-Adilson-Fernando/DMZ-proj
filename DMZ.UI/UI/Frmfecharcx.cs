using DMZ.BL.Classes;
using DMZ.UI.Classes;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.Model.Model;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using Microsoft.Reporting.WinForms;
using DMZ.DAL.Migrations;

namespace DMZ.UI.UI
{
    public partial class Frmfecharcx : Basic.FrmClasse2
    {

        public string Origem { get; set; }
        private LocalReport _reportViewer1;

        public Frmfecharcx()
        {
            InitializeComponent();
        }
        public string DefaultPrinter { get; set; }
        private DataTable FechoMvt { get; set; }
        public Caixa Caixa { get; set; }
        //public Action<Caixa> Enviar { get; internal set; }

        public Action<Caixa> Enviar;
        private void Frmfecharcx_Load(object sender, EventArgs e)
        {
            CarregaMov(Caixa);
        }

        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            var nMsg = MsBox.Show("Deseja Fechar o Caixa ?", DResult.YesNo);
            if (nMsg.DialogResult != DialogResult.Yes) return;
            if (tbTotaldefice.Text.ToDecimal()==0)
            {
                if (!tbtotalemcaixa.Text.IsNullOrEmpty() || !tbTotalsaldo.Text.IsNullOrEmpty())
                {
                    FecharCaixa();
                }
                else
                {
                    MsBox.Show("Deve lançar os valores em caixa!");
                }
            }
            else
            {
                MsBox.Show($"Desculpe o fecho tem défice de: {tbTotaldefice.Text}, será lançado como nota de debito.");
                FecharCaixa();
            }
        }
        private void FecharCaixa()
        {
            Caixa.Entrada = tbEntrada.Text.ToDecimal();
            Caixa.Fechado = true;
            Caixa.Saida = tbSaida.Text.ToDecimal();
            Caixa.Saldo = tbTotalsaldo.Text.ToDecimal();
            Caixa.TotalCaixa = tbtotalemcaixa.Text.ToDecimal();
            Caixa.Defice = tbTotaldefice.Text.ToDecimal();
            Caixa.Qmf = Pbl.Usr.Usrstamp;
            Caixa.Dhorafecho =Pbl.SqlDate;
            EF.Save(Caixa);
            var caixal = SQL.Initialize("caixal");
            foreach (var row in FechoMvt.AsEnumerable())
            {
                if (row == null) continue;
                var dr = caixal.NewRow();
                dr["Caixalstamp"] = Pbl.Stamp();
                dr["Caixastamp"] = Caixa.Caixastamp;
                dr["Contasstamp"] = row["Contasstamp"];
                dr["Data"] = Pbl.SqlDate;
                dr["Codtz"] = row["Codlocal"];
                dr["Contatesoura"] = row["Local"];
                dr["Qmf"] = Pbl.Usr.Usrstamp;
                dr["Qmfdathora"] = Pbl.SqlDate;
                dr["Entrada"] = row["Entrada"];
                dr["Saida"] = row["Saida"];
                dr["Saldo"] = row["caixa"];
                dr["Lancado"] = row["Lancado"];
                dr["TotalDefice"] = row["TotalDefice"];
                dr["Campo1"] = 0;
                dr["Campo2"] = 0;
                dr["Campo3"] = "";
                dr["Obs"] = "";
                caixal.Rows.Add(dr);
            }
            SQL.Save(caixal, "caixal", false,"", "");
            UpdateMVT();
            MsBox.Show("Caixa fechado com sucesso!");
            Close();
            Enviar.Invoke(null);
        }
        //
        private void UpdateMVT()
        {
            foreach (var row in FechoMvt.AsEnumerable())
            {
                if (row != null)
                    // and CONVERT(date, Datamov) = '{dateTimePicker1.Value.ToSqlDate()}'
                    SQL.SqlCmd($"update mvt set fechado =1 where Contasstamp='{row["Contasstamp"].ToTrim()}' and UsrLogin='{Pbl.Usr.Usrstamp}' and origem in ('ABERTURA','POSRCL','EFM','RF')");
            }
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Imprimir folha do caixa do dia .....
            var lista = new List<ReportParameter>();
            var cTituloRelat = "Folha de Caixa";
            var ccSubtitulo = $"[Data: ] {Pbl.SqlDate.Date} -Número: {Pbl.Usr.Codtz} -Responsavel: {TbResponsavel.Text.Trim()}";
            lista.Add(new ReportParameter("cTituloRelat", cTituloRelat));
            lista.Add(new ReportParameter("ccSubtitulo", ccSubtitulo));
            ReportHelper.PrintReport(lista, true);

            #endregion
        }

        private void btnQuerry_Click(object sender, EventArgs e)
        {
            var crFechocx = GenBl.GetCaixa(dateTimePicker1.Value,Pbl.Usr.Usrstamp);
            if (crFechocx !=null)
            {
                CarregaMov(crFechocx);
            }
            else
            {
                MsBox.Show("Não tem caixa em aberto");
            }
        }

        private void CarregaMov(Caixa crFechocx)
        {
            if (crFechocx != null)
            {
                tbInicial.Text = crFechocx.Entrada.ToString();
                tbNumero.Text = crFechocx.Numero.ToString();
                tbCaixa.Text = crFechocx.Contatesoura;
                TbResponsavel.Text = crFechocx.Nome;
                dateTimePicker1.Value = crFechocx.Data;
                //and CONVERT(date, Datamov) = '{dateTimePicker1.Value.ToSqlDate()}'
                var xx = $@"select *, caixa=sum(entrada-saida),cast(0 as decimal) Lancado,cast(0 as decimal) TotalDefice,Contasstamp from (
                            Select  local,ISNULL(SUM(entrada), 0) as Entrada, ISNULL(SUM(saida), 0) as Saida,Codlocal,Contasstamp
                             from mvt where fechado = 0 and origem in ('ABERTURA','POSRCL','EFM','RF') and UsrLogin='{Pbl.Usr.Usrstamp}'   group by Local,Codlocal,Contasstamp  
                            )tmp1 group by tmp1.Local,tmp1.Codlocal,Entrada,Saida,tmp1.Contasstamp";
                FechoMvt = SQL.GetGen2DT(xx);
                gridUIArm.SetDataSource(FechoMvt);
                if (!FechoMvt.HasRows()) return;
                tbEntrada.Text = FechoMvt.Select().Sum(x => x.Field<decimal>("Entrada")).ToString();
                tbSaida.Text = FechoMvt.Select().Sum(x => x.Field<decimal>("saida")).ToString();
                tbTotalsaldo.Text = (tbEntrada.Text.ToDecimal() - tbSaida.Text.ToDecimal()).ToString();
            }
        }
        //+ tbInicial.Text.ToDecimal()
        private void gridUIArm_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            decimal tot = 0;
            foreach (DataGridViewRow r in gridUIArm.Rows)
            {
                if (r == null) continue;
                tot = tot + r.Cells["LANCAR"].Value.ToDecimal();
                r.Cells["defice"].Value = (r.Cells["Valorcx"].Value.ToDecimal() - r.Cells["LANCAR"].Value.ToDecimal()).ToDecimal();
            }
            // + tbInicial.Text.ToDecimal()
            tbtotalemcaixa.Text = tot.ToString();
            tbTotaldefice.Text = (tbTotalsaldo.Text.ToDecimal()-tbtotalemcaixa.Text.ToDecimal()).ToString();
        }

        private void tbEntrada_TextChanged(object sender, EventArgs e)
        {
            tbEntrada.Text= tbEntrada.Text.SetMask();  
        }

        private void tbSaida_TextChanged(object sender, EventArgs e)
        {
            tbSaida.Text= tbSaida.Text.SetMask();  
        }

        private void tbTotalsaldo_TextChanged(object sender, EventArgs e)
        {
            tbTotalsaldo.Text= tbTotalsaldo.Text.SetMask();  
        }

        private void tbTotaldefice_TextChanged(object sender, EventArgs e)
        {
            tbTotaldefice.Text= tbTotaldefice.Text.SetMask();  
        }

        private void tbtotalemcaixa_TextChanged(object sender, EventArgs e)
        {
            tbtotalemcaixa.Text= tbtotalemcaixa.Text.SetMask();  
        }
    }
}
