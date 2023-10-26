using DMZ.BL.Classes;
using DMZ.UI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmNotStockMin : DMZ.UI.Basic.FrmClasse2
    {
        public FrmNotStockMin()
        {
            InitializeComponent();
        }

        private void FrmNotStockMin_Load(object sender, EventArgs e)
        {
            //var qry = $@"select Ref, descricao, Armazem, stock, Preco, Total = (stock * Preco) from(select Ref, descricao, stock = (sum(Entrada) - sum(saida)), Codarm,
            //Armazem = (select descricao from Armazem where Armazemstamp = mstk.Armazemstamp ), Ststamp,
            //Preco = isnull((select max(Preco) from StPrecos where Ststamp = Mstk.Ststamp), 0)
            //from mstk 
            //group by codarm,Ref,descricao,Armazemstamp,Ststamp,Preco)tmp1
            //where tmp1.stock > 0 order by tmp1.Codarm,tmp1.descricao";
            //var dt = SQL.GetGen2DT(qry);     
            //gridStock.SetDataSource(dt);
        }
    }
}
