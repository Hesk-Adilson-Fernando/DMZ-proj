using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmAddProf : FrmClasse2
    {
        private DataTable dtProf;

        public FrmAddProf()
        {
            InitializeComponent();
        }

        public string Turmadiscstamp1 { get; set; }
        public string Ststamp1 { get;  set; }
        public string Turmastamp { get; internal set; }

        private void gridProf_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            var nome = gridProf.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("nome"))
            {
                var qry = $"select pe.pestamp,nome from pe join Pedisc on pe.Pestamp = Pedisc.Pestamp where Pedisc.Ststamp ='{Ststamp1.Trim()}'";
                dtProf = Helper.SetBinds(e.Control, "nome", qry);
            }
        }
        private void FrmAddProf_Load(object sender, EventArgs e)
        {
            gridProf.Condicao = $"Turmadiscstamp='{Turmadiscstamp1}'";
            gridProf.BindGridView();
            CLocalStamp = Turmadiscstamp1;
        }

        private void gridProf_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridProf.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("nome"))
            {
                if (gridProf.CurrentCell?.Value == null) return;
                var valor = gridProf.CurrentCell.Value.ToString().Trim();
                if (!(dtProf?.Rows.Count > 0)) return;
                var dr = dtProf.AsEnumerable().FirstOrDefault(s => s.Field<string>("nome").Trim().Equals(valor));
                if (dr == null) return;
                gridProf.CurrentRow.Cells["pestamp"].Value = dr["pestamp"].ToString();
                gridProf.CurrentRow.Cells["Turmadiscstamp"].Value = Turmadiscstamp1;
                gridProf.CurrentRow.Cells["Ststamp"].Value = Ststamp1;
                gridProf.Update();
            }
        }
        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void ReceiveInfo(DataTable dt)
        {
            if (dt.HasRows())
            {
                foreach (var dr in dt.AsEnumerable())
                {
                    if (!dr.DataRowIsNull())
                    {
                        gridProf.AddLine();
                        gridProf.DataRowr["pestamp"] = dr["pestamp"].ToString();
                        gridProf.DataRowr["nome"] = dr["nome"].ToString();
                        gridProf.DataRowr["Turmadiscstamp"] = Turmadiscstamp1;
                        gridProf.DataRowr["Ststamp"]= Ststamp1;
                    }
                }
                gridProf.Update();
            }
        }
        private bool gridPanel21_BeforeAddLineEvent()
        {
            var qry = $"select pe.pestamp,nome from pe join Pedisc on pe.Pestamp = Pedisc.Pestamp where Pedisc.Ststamp ='{Ststamp1.Trim()}'";
            dtProf = SQL.GetGen2DT(qry);
            if (dtProf.HasRows())
            {
                var f = new FrmSelect
                {
                    SelectCampos = "",
                    HideFirstColumn = true,
                    Tamanhos = new List<decimal>() { 0,150 },
                    ColFillName = "nome",
                    Tabela = "",
                    Condicao = "",
                    SendData = ReceiveInfo,
                    _dt = dtProf
                };
                var xx = $"select pe.pestamp,nome from pe join Pedisc on pe.Pestamp = Pedisc.Pestamp where 1=0";
                f._dt2 = SQL.GetGen2DT(xx);
                f.ShowDialog();
            }
            else
            {
                MsBox.Show("Não existe professor indicado para esta disciplina, porfavor consulte o RH");
            }
            return true;
        }

        private bool gridPanel21_BeforeDellLineEvent()
        {
            var cur = gridProf.CurrentRow; //.DataRowr["pestamp"];
            if (cur!=null)
            {
                if (SQL.CheckExist($"select Turmanotastamp from Turmanota where Turmastamp ='{Turmastamp}' and Coddis='{Ststamp1}' and Pestamp='{cur.Cells["pestamp"].Value.ToTrim()}'"))
                {
                    MsBox.Show("Não pode eliminar o professor porque está associado a turma primeiro mude ");
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
