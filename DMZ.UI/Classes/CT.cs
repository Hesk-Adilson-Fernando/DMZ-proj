using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Generic;

namespace DMZ.UI.Classes
{
    public static class Ct
    {
        public static DataTable EditControl(DataGridViewCell currentCell, DataGridViewEditingControlShowingEventArgs e,List<Ec> lista)
        {
            string qry;
            DataTable dtconta = null;
            var nome = currentCell.OwningColumn.Name.ToLower();
            var el=lista.FirstOrDefault(x=>x.Nome.ToString().Trim().ToLower().Equals(nome));
            if (el != null)
            {
                qry = "select conta,descricao,Pgcstamp from pgc where ano =(select ano from param) and integracao = 0";
                dtconta = Helper.SetBinds(e.Control, el.Conta?"Conta":"Descricao", qry);
            }
            else if (nome.Equals("ccusto"))
            {
                qry = "select Descricao as ccusto from CCu";
                Helper.SetBinds(e.Control, "ccusto",qry);
            }
            else
            {
                var autoText = e.Control as TextBox;
                if (autoText != null) 
                    autoText.AutoCompleteCustomSource = null;
            }

            return dtconta;
        }

        public static void CellEndEdit(GridUi gridUi,DataTable dtconta,List<string> lista, bool Adding = false)
        {
            var nome = gridUi.CurrentCell.OwningColumn.Name.ToLower();
            if (!lista.Any(x => x.ToString().Trim().ToLower().Equals(nome))) return;
            switch (nome)
            {
                case "descricao":
                case "descricao2":
                    SetDcli("descricao",gridUi,dtconta,nome.Equals("descricao")?"clnconta":"clnconta2",Adding);
                    break;
                case "clnconta":
                case "clnconta2":
                    SetDcli("conta",gridUi,dtconta,nome.Equals("clnconta")?"descricao":"descricao2",Adding);
                    break;
            }
        }

        private static void SetDcli(string campo,DataGridView gridUi,DataTable dtconta,string colName, bool Adding = false)
        {
            if (gridUi.CurrentRow == null) return;
            if (gridUi.CurrentCell.Value == null) return;
            var valor = gridUi.CurrentCell.Value.ToString().Trim();
            var dr = dtconta?.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));
            if (dr == null)
            {
                switch (campo)
                {
                    case "descricao":
                    {
                        var dialogr =MsBox.Show($"A Descrição:  {valor}, não exite para o ano: {Pbl.AnoContabil()}. \r\nDeseja eliminar?..",DResult.YesNo);
                        if (dialogr.DialogResult==DialogResult.Yes)
                        {
                            gridUi.CurrentCell.Value = "";
                        }

                        break;
                    }
                    case "conta":
                    {
                        var dialogr =MsBox.Show($"A Conta:  {valor}, não exite para o ano: {Pbl.AnoContabil()}. \r\nDeseja eliminar?..",DResult.YesNo);
                        if (dialogr.DialogResult==DialogResult.Yes)
                        {
                            gridUi.CurrentCell.Value = "";
                        }

                        break;
                    }
                }
            }
            else
            {
                if (campo == "descricao")
                {
                    gridUi.CurrentRow.Cells[colName].Value = dr["conta"];
                }
                if (campo != "conta") return;
                {
                    gridUi.CurrentRow.Cells[colName].Value = dr["descricao"];
                }
                if (gridUi.Columns.Contains("Pgcstamp"))//
                {
                    gridUi.CurrentRow.Cells["Pgcstamp"].Value = dr["Pgcstamp"];
                }

                if (Adding)
                {

                    if (gridUi.Columns.Contains("dia"))//
                    {
                        gridUi.CurrentRow.Cells["dia"].Value = Pbl.SqlDate.Day;
                    }
                    if (gridUi.Columns.Contains("ano"))//
                    {
                        gridUi.CurrentRow.Cells["ano"].Value =Pbl.AnoContabil();
                    }
                    if (gridUi.Columns.Contains("mes"))//
                    {
                        gridUi.CurrentRow.Cells["mes"].Value = Pbl.SqlDate.Month;
                    }
                    if (gridUi.Columns.Contains("data"))//
                    {
                        gridUi.CurrentRow.Cells["data"].Value = Pbl.DataContabil();
                    }
                }
            }

        }

        public static void CallQuerryForm(FrmClasse frm)
        {
            var tmpFound = SQL.GetGen2DT($"select conta,descricao from pgc where ano ={Pbl.AnoContabil()} and integracao=0 order by conta  ");
            var qr = new Querry
            {
                radGridView1 = {DataSource = null, AutoGenerateColumns = false},
                Campo1 = "conta",
                Campo2 = "descricao",
                Campo3 = "",
                PControl2 = frm.UpdateGrid,
                ShowStk = false,
                Width1 = 90,
                Origem = true,
                Width2 = 270,
                Caption1 = "Código",
                Caption2 = "Descrição"
            };
            qr.radGridView1.DataSource = tmpFound;
            qr.cbPorReferencia.Text = @"Conta";
            qr.cbPorReferencia.Checked = true;
            qr.labelX1.Text = tmpFound.Rows.Count + @" registos encontados";
            qr.ShowForm(frm,true);
        }

        public static DataTable GetDt(string apparamstamp)
        {
            var str = $@"select * from(select apivded.Conta,Sequec,tipo=1 from apivded join Apparam on Apparam.Apparamstamp=Apivded.Apparamstamp where ltrim(rtrim(Apparam.apparamstamp)) ='{apparamstamp.Trim()}'
                        union all 
                        select apivliq.Conta,Sequec,tipo=2 from apivliq join Apparam on Apparam.Apparamstamp=apivliq.Apparamstamp where ltrim(rtrim(apivliq.apparamstamp)) ='{apparamstamp.Trim()}') temp  order by Conta asc";
            return SQL.GetGen2DT(str);
        }
    }
}
