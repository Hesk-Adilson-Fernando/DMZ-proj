using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmGuiaList : Basic.FrmClasse2
    {
        public FrmGuiaList()
        {
            InitializeComponent();
        }

        public decimal No { get; set; }
        public Action<DataTable, DataTable, string, bool> SendData;
        public string Sumcampos { get; set; }
        public string Nome { get; set; }
        private void FrmGuiaList_Load(object sender, EventArgs e)
        {
            var str = $@"select * from (select ref, descricao, quant =sum({Sumcampos.Trim()}),cast(0 as bit) ok,Preco,Codarm,
                                            Armazem=(select descricao from armazem where codigo =codarm)
                                             from mstk where no={No} and ltrim(rtrim(nome)) ='{Nome}'  group by ref, descricao,Preco,Codarm) 
                                             tmp1 where tmp1.quant>0 order by tmp1.descricao";
            var dt = SQL.GetGen2DT(str);
            GridItems.SetDataSource(dt);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            GridItems.Update();
            var dt = GridItems.DataSource as DataTable;
            if (dt?.Rows.Count>0)
            {
                var dtCopy = dt.AsEnumerable().Where(x => x.Field<bool>("ok").Equals(true));
                if (dtCopy.Count()>0)
                {
                    if (GridItems.CurrentRow != null)
                    {
                       // SendData.Invoke(dtCopy.CopyToDataTable(),null,false);
                    }
                    Close();
                }
                else
                {
                    MsBox.Show("Deve escolher as linhas na segunda tabela!..");
                }
            }
            else
            {
                MsBox.Show("Deve escolher o documento na primeira tabela, ou o documento não tem linhas!..");     
            }
        }
    }
}
