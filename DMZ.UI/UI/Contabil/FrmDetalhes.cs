using System;
using System.Collections.Generic;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;

namespace DMZ.UI.UI.Contabil
{
    public partial class FrmDetalhes : FrmClasse2
    {
        public FrmDetalhes()
        {
            InitializeComponent();
        }
        public List<Usracessos> ListaUsracessos { get; set; }
        public  string Tabela { get; set; }
        public string PjStamp { get; set; }
        public string Origem { get; set; }
        public string Condicao { get; set; }

        private void FrmDetalhes_Load(object sender, EventArgs e)
        {
            Condicao = $"pjstamp='{PjStamp}'";
            var qry = $"select Nome Cliente,Sigla,(Nomedoc+' '+Convert(varchar,Numero)) documento,Numero nrdoc,pjstamp,{Tabela}stamp as localstamp,Pjnome,Convert(date,Data) Data,Total valordoc from {Tabela} where {Condicao} order by Convert(datetime,Data) desc,Nomedoc";
            var dt = SQL.GetGen2DT(qry);
            gridUi1.DataSource = null;
            gridUi1.AutoGenerateColumns = false;
            gridUi1.DataSource = dt;
            if (gridUi1.Rows.Count <= 0) return;
            Processar();
        }

        private void Processar()
        {
            if (gridUi1.Rows.Count <= 0) return;
            decimal sum = 0;
            var contagem = 0;
            for (var i = 0; i < gridUi1.Rows.Count; ++i)
            {
                sum += gridUi1.Rows[i].Cells["valordoc"].Value.ToDecimal();
            }
            tbValorReg.Text = sum.ToString("N2");
        }

        private void gridUi1_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if (gridUi1.CurrentCell==null)return;
            if (!gridUi1.CurrentCell.OwningColumn.Name.Equals("viewdoc")) return;
            switch (Tabela.ToLower())
            {
                case "fact":
                        Helper.CallForm("fact","FrmFt",gridUi1,ParentForm,ListaUsracessos);
                    break;
                case "di":
                    if (gridUi1.CurrentRow == null) return;
                        Helper.CallForm("di","FrmPjdi",gridUi1,ParentForm,ListaUsracessos);
                    break;
                case "facc":
                        Helper.CallForm("facc","FrmCp",gridUi1,ParentForm,ListaUsracessos);
                    break;
                case "rcl":
                        Helper.CallForm("rcl","FrmRcl",gridUi1,ParentForm,ListaUsracessos);
                    break;
                case "pgf":
                        Helper.CallForm("pgf","FrmPgf",gridUi1,ParentForm,ListaUsracessos);
                    break;
            }
        }
    }
}
