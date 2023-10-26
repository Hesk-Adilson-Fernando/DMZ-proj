using System;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.UI;
using DMZ.UI.Generic;

namespace DMZ.UI.UC
{
    public partial class Sectores : UserControl
    {
        public Sectores()
        {
            InitializeComponent();
        }
        public int Origem { get; set; }
        private string _name;
        private string _codfam;

        [Category("Category Details")]
        public string Titulo
        {
            get => _name;
            set { _name = value; btnCategory.Text = value; }
        }
        public string Codigo
        {
            get => _codfam;
            set { _codfam = value; lblCodigo.Text = value; }
        }
        public string Sectorstamp { get; set;}
        private static string Qry()
        {
            var qry = $@"select Codfam no,Descricao Descricao1,Ststamp Mesasstamp,Familiastamp=(select top 1 Familiastamp from Familia f where f.Codigo=temp.Codfam),Familia=(select  top 1 upper(descricao) from Familia f where f.Codigo=temp.Codfam),Referenc,Preco,Ststamp,Imagem,Descricao=Descricao+' - '+classe,Codfam,
classe,CodCCu,Ststamp Sectorstamp,Codigo=Codfam  from(select Referenc,StPrecos.Preco1 Preco,

st.Ststamp,Imagem,Descricao,st.CodFam ,classe=(select top 1 Preco1 from Param),StPrecos.CodCCu
                            from St left join StPrecos on st.Ststamp=StPrecos.ststamp  
                            where 							
							servico =1 and pos =0  

							union all

							select Referenc,StPrecos.Preco2,

st.Ststamp,Imagem,Descricao,st.CodFam ,classe=(select top 1 Preco2 from Param) ,StPrecos.CodCCu
                            from St left join StPrecos on st.Ststamp=StPrecos.ststamp  
                            where 							
							servico =1 and pos =0  

							union all
							select Referenc,StPrecos.Preco3,

st.Ststamp,Imagem,Descricao,st.CodFam ,classe=(select top 1 Preco3 from Param) ,StPrecos.CodCCu
                            from St left join StPrecos on st.Ststamp=StPrecos.ststamp  
                            where 
							
							servico =1 and pos =0  

							union all
							select Referenc,StPrecos.Preco4,

st.Ststamp,Imagem,Descricao,st.CodFam ,classe=(select top 1 Preco4 from Param) ,StPrecos.CodCCu
                            from St left join StPrecos on st.Ststamp=StPrecos.ststamp  
                            where 
							
							servico =1 and pos =0  

							union all
							select Referenc,StPrecos.Preco5,

st.Ststamp,Imagem,Descricao,st.CodFam ,classe=(select top 1 Preco5 from Param) ,StPrecos.CodCCu
                            from St left join StPrecos on st.Ststamp=StPrecos.ststamp  
                            where 
							
							servico =1 and pos =0  
					union all

							select Referenc,StPrecos.Preco6,

st.Ststamp,Imagem,Descricao,st.CodFam,classe=(select top 1 Preconormal from Param) ,StPrecos.CodCCu
                            from St left join StPrecos on st.Ststamp=StPrecos.ststamp  
                            where 
							
							servico =1 and pos =0  		
							
							)temp where Codfam<>'' ";
            return qry;
        }

        private void BtnCategory_Click(object sender, EventArgs e)
        {
            var f = ParentForm;
            if (f == null) return;
            //DtSecFam
            if (((FrmPosRest)f).DtSecFam == null) return;
            if (((FrmPosRest)f).DtSecFam.AsEnumerable().Any(x => x.Field<string>("Sectorstamp").Equals(Sectorstamp.Trim())))
            {
                var dt = ((FrmPosRest)f).DtSecFam.AsEnumerable().Where(x => x.Field<string>("Sectorstamp").Equals(Sectorstamp.Trim())).CopyToDataTable();
                if (dt?.Rows.Count > 0)
                {
                    ((FrmPosRest)f).DtProdutos = dt;
                    ((FrmPosRest)f).Codsec = Codigo.ToDecimal();
                    ((FrmPosRest)f).Descsector = btnCategory.Text;
                    ((FrmPosRest)f).fLPSubProduct.Controls.Clear();
                    ((FrmPosRest)f).Produto = false;
                    Helper.FillMesa(dt, f);
                }
                else
                {
                    ((FrmPosRest)f).lblInform.Visible = true;
                    ((FrmPosRest)f).lblInform.Text = @"Nada adicionado ainda!";
                } 
            }

            SetBackColor(btnCategory);
        }

        private void SetBackColor(Button button)
        {
           button.BackColor= Color.DarkGoldenrod;

            foreach (var sect in button.Parent.Parent.Controls)
            {
                if (!(sect is Sectores)) continue;
                if (((Sectores)sect).btnCategory.Text.Trim() != button.Text.Trim())
                {
                    ((Sectores)sect).btnCategory.BackColor = Color.FromArgb(39, 59, 80);
                }
            }

        }
    }
}
