using DMZ.BL.Classes;
using DMZ.UI.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DMZ.UI.UI.Contabil
{
    public partial class FrmExtDiario : DMZ.UI.Basic.FrmClasse2
    {
        public FrmExtDiario()
        {
            InitializeComponent();
        }

        public string Condicao { get; internal set; }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            var  condicao ="";
            if (!string.IsNullOrEmpty(cbDiario.Text2))
            {
                if (string.IsNullOrEmpty(condicao))
                {
                    condicao=$"l.Dino ={cbDiario.Text2.ToDecimal()}";
                }
                else
                {
                    condicao=$"{condicao} and l.Dino ={cbDiario.Text2.ToDecimal()}";
                }
            }
            if (cbPeriodo.cb1.Checked)
            {
                if (string.IsNullOrEmpty(condicao))
                {
                    condicao=$"convert(date,l.data)>='{dmzEntreDatas1.dt1.Value.ToSqlDate()}' and convert(date,l.data)<='{dmzEntreDatas1.dt1.Value.ToSqlDate()}'";
                }
                else
                {
                    condicao=$"{condicao} and convert(date,l.data)>='{dmzEntreDatas1.dt1.Value.ToSqlDate()}' and convert(date,l.data)<='{dmzEntreDatas1.dt1.Value.ToSqlDate()}'";
                }
            }
            if (!string.IsNullOrEmpty(condicao))
            {
                condicao=$" where {condicao}";
            }
            var str=$@"select Data=iif(GROUPING(l.dino)=1,'TOTAL GERAL',isnull(convert(varchar,convert(char,l.data,104)),'TOTAL')), 
                        Diario=ISNULL(rtrim(convert(char,l.Dino))+' - '+l.Dinome,''),
                        ISNULL(rtrim(Convert(char,l.Docno))+' - '+l.Docnome,'') as Documento,Dilno=ISNULL(Convert(varchar,l.Dilno),''),
                        isnull(l.Adoc,'')as Adoc,isnull(ml.Conta,'') as Conta,sum(ml.Deb) as deb,sum(ml.Cre) as cre,l.Dino,ordem =1,GROUPING(l.dino) AS SalesQuarterGrp from lcont l 
                        join ml on l.Lcontstamp=ml.Lcontstamp {condicao} 
                        group by rollup (l.dino,(l.data,l.Dinome,l.Docno,l.Docnome,l.Adoc,ml.Conta,
                        ml.Deb,ml.Cre,l.Dilno)) ";
            var dt = SQL.GetGen2DT(str);
            gridDiarios.SetDataSource(dt);
        }

        private void FrmExtDiario_Load(object sender, EventArgs e)
        {

        }
    }
}
