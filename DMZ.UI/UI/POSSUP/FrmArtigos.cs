using DMZ.BL.Classes;
using System;
using System.Data;
using System.Windows.Forms;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmArtigos : Basic.FrmClasse2
    {
        private DataTable _dt;
        public Action<string,decimal,string> SendData { get; set; }
        public string Ccusto { get; set; }
        public FrmArtigos()
        {
            InitializeComponent();
        }
        private void FrmArtigos_Load(object sender, EventArgs e)
        {
            gridProdutos.AutoGenerateColumns = false;
            metodo_listar();
            if (gridProdutos != null)
            {
                // ReSharper disable once PossibleNullReferenceException
                gridProdutos.Columns["referencia"].Visible = !Pbl.Param.Esconderef;
                // ReSharper disable once PossibleNullReferenceException
                gridProdutos.Columns["stock"].Visible = !Pbl.Param.Escondestock;
                cbReferenc.Visible = !Pbl.Param.Esconderef;
                Helper.UpdateGridColumns(gridProdutos);
                if (!Pbl.Param.Escondestock)
                {
                //    rdPreco1.Visible = !Pbl.Param.Escondestock;
                //    rdPreco2.Visible = !Pbl.Param.Escondestock;
                //    rdPreco3.Visible = !Pbl.Param.Escondestock;
                //    rdPreco4.Visible = !Pbl.Param.Escondestock;
                //    rdPreco5.Visible = !Pbl.Param.Escondestock;
                }
                // ReSharper disable once PossibleNullReferenceException
                gridProdutos.Columns["preco1"].Visible = false;
                // ReSharper disable once PossibleNullReferenceException
                gridProdutos.Columns["preco2"].Visible = false;
                // ReSharper disable once PossibleNullReferenceException
                gridProdutos.Columns["preco3"].Visible = false;
                // ReSharper disable once PossibleNullReferenceException
                gridProdutos.Columns["preco4"].Visible = false;
                // ReSharper disable once PossibleNullReferenceException
                gridProdutos.Columns["preco5"].Visible = false;
            }
            preco.HeaderText = Pbl.Param.Preconormal.IsNullOrEmpty() ? "PREÇO" : Pbl.Param.Preconormal.ToUpper();
            //}
        }
        public string FirstLetterToUpper(string str)
        {
            str = str.ToLower();
            if (str.Length > 1)
                return char.ToUpper(str[0]) + str.Substring(1);
            return str.ToUpper();
        }

        void CheckedChanged(RadioButton rd)
        {
            preco.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            preco.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopRight;
            descricao.Width = 550;
            preco.HeaderText = rd.Text.ToUpper();
            gridProdutos.AutoGenerateColumns = false;
            metodo_listar();
            foreach (DataRow row in _dt.Rows)
            {
                if (!rd.Checked)return;
                var nom = rd.Name.Replace("rd", "").ToLower();
                if (nom.Equals("Preco1".ToLower()))
                {
                    nom = "Preco";
                }
                if (nom.Equals("Preco2".ToLower()))
                {
                    nom = "Preco1";
                }
                if (nom.Equals("Preco3".ToLower()))
                {
                    nom = "Preco2";
                }
                if (nom.Equals("Preco4".ToLower()))
                {
                    nom = "Preco3";
                }
                if (nom.Equals("Preco5".ToLower()))
                {
                    nom = "Preco4";
                }
                if (nom.Equals("Preco6".ToLower()))
                {
                    nom = "Preco5";
                }
                nom = FirstLetterToUpper(nom);
                row["Preco"] = row[nom];
                _dt.AcceptChanges();
            }
            gridProdutos.SetDataSource(_dt);
            TextChanged();
        }

        public void metodo_listar()
        {
            string con,campo, query;
            var arm = GenBl.GetArmazem();
            if (!Pbl.Param.Vendeservico)
            {
                con = $" StPrecos.Ccustamp='{Pbl.Usr.Ccustamp}'";
                campo = $"stock=isnull((select stock from [STExtratoFicha](st.Ststamp) where Armazemstamp in ({arm})),0) ";
                query = $"select * from (select st.referenc,st.Descricao,st.CodigoBarras, StPrecos.Preco,{campo},Preco1,Preco2,Preco3,Preco4,Preco5,Preco6,Preco7,st.ststamp from st inner join  StPrecos on StPrecos.Ststamp= st.Ststamp where {con} )tmp1 where stock >0";
            }
            else
            {
                con = "where servico =1";
                campo = "stock=0";
                query = $"select st.referenc,st.Descricao,st.CodigoBarras, StPrecos.Preco,{campo},Preco1,Preco2,Preco3,Preco4,Preco5,Preco6,Preco7,st.ststamp from st inner join  StPrecos on StPrecos.Ststamp= st.Ststamp {con}";
            }
            
            _dt = SQL.GetGen2DT(query);
            gridProdutos.SetDataSource(_dt);
        }
        private void gridProdutos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridProdutos.CurrentRow == null) return;
            if (!gridProdutos.CurrentRow.Cells["stock"].Value.ToDecimal().IsZero())
            {
                var ststamp = gridProdutos.CurrentRow.Cells["ststamp"].Value.ToString().Trim();
                SendData.Invoke(ststamp, gridProdutos.CurrentRow.Cells["preco"].Value.ToDecimal(), preco.HeaderText);
                //stock
                gridProdutos.CurrentRow.Cells["stock"].Value = gridProdutos.CurrentRow.Cells["stock"].Value.ToDecimal() - 1;
            }
            else
            {
                MsBox.Show("Não pode vender acima do stock disponivel!");
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            TextChanged();
        }

        private void TextChanged()
        {
            var condicao = "";
            if (cbReferenc.cb1.Checked)
            {
                condicao = $"referenc like '%{textBox2.Text.Trim()}%'";
            }
            else if (cbCodigoBarras.cb1.Checked)
            {
                condicao = $"CodigoBarras like '%{textBox2.Text.Trim()}%'";
            }
            else
            {
                condicao = $"Descricao like '%{textBox2.Text.Trim()}%'";
            }

            try
            {
                var dtSearched = _dt.GetTable(condicao);
                gridProdutos.SetDataSource(dtSearched);
            }
            catch (Exception)
            {
                gridProdutos.SetDataSource(_dt);
            }
        }

        private void rdPreco6_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged(rdPreco6);
        }
        private void rdPreco2_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged(rdPreco2);
        }
        private void rdPreco3_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged(rdPreco3);
        }
        private void rdPreco4_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged(rdPreco4);
        }
        private void rdPreco5_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged(rdPreco5);
        }
        private void rdPreco1_CheckedChanged(object sender, EventArgs e)
        {
            CheckedChanged(rdPreco1);
        }

        private void panel15_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
    } 
}
