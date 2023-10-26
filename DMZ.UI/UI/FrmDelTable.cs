using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.Properties;
using DMZ.UI.UC;

namespace DMZ.UI.UI
{
    public partial class FrmDelTable : Basic.FrmClasse2
    {
        public FrmDelTable()
        {
            InitializeComponent();
        }

        private void FrmDelTable_Load(object sender, EventArgs e)
        {

        }

        private void cbDefault12_CheckedChangeds()
        {
            var value = cbDefault12.cb1.Checked;
            var c3 = Helper.GetAll(this, typeof(CbDefault)).ToList();
            foreach (var c in c3)
            {
                if (c == null) continue;
                ((CbDefault) c).cb1.Checked = value;
                ((CbDefault)c).btnCheck.Image = !value ? Resources.Unchecked_Checkbox_23px : Resources.Checked_Checkbox_2_23px;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var dr = MsBox.Show("Deseja eliminar dados nas tabelas selecionadas?..", DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            var listaTabelas = new List<string>();
            var c3 = Helper.GetAll(this, typeof(CbDefault)).ToList();
            foreach (var c in c3)
            {
                if (c == null) continue;
                if (string.IsNullOrEmpty(((CbDefault)c).Value)) continue;
                listaTabelas.Add(((CbDefault)c).Value);
            }

            foreach (var tabela in listaTabelas)
            {
                if (tabela == null) continue;
                SQL.SqlCmd($"Delete from {tabela.Trim()}");
            }

            MsBox.Show("Dados processados com sucesso!");
        }
    }
}
