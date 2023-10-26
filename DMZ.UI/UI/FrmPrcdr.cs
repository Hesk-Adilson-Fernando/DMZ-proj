using System;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.UI.RH.Classes;
using Utilities = DMZ.BL.Classes.Utilities;

namespace DMZ.UI.UI.RH
{
    public partial class FrmPrcdr : FrmClasse2
    {
        public FrmPrcdr()
        {
            InitializeComponent();
        }
        public void Alert(string msg, Form_Alert.EnmType type)
        {
            var frm = new Form_Alert();
            frm.ShowAlert(msg,type);
        }
        public DataTable QryPe { get; set; }
        public DataTable QryPrc { get; set; }
        public Action<DataTable, Proces> SendInfo { get; set; }
        public DataTable _dtSearch { get; private set; }

        private void FrmPrcdr_Load(object sender, EventArgs e)
        {
            //Ano.Value = Pbl.SqlDate.Year;
           // QryPrc = SQL.Initialize("prc");
        }

        private void cbDefault1_Load(object sender, EventArgs e)
        {

        }

        private void cbDefault1_CheckedChangeds()
        {
            GridProcess.CheckUncheckAll("Status",cbDefault1.cb1.Checked);
        }

        private void btnAddprocess_Click(object sender, EventArgs e)
        {
            //if (!Validado()) return;
            //var qryPe = QryPe.AsEnumerable().Where(x => x.Field<bool>("Status").Equals(true)).CopyToDataTable();
            //if (qryPe.Rows.Count <= 0) return;
            //var mx = SQL.Maximo("proces", "codigo", $"ano={Ano.Value}");
            //var proces = Utilities.DoAddline<Proces>();
            //proces.Codigo = mx.ToDecimal();
            //proces.Processtamp = Pbl.Stamp();
            //proces.Mes = tbMes.tb1.Text;
            //proces.Periodo = tbPeriodo.tb1.Text;
            //proces.Ano = Ano.Value;
            //proces.Nrmes = tbMes.Text2.ToDecimal();
            //proces.Data = dateTimePicker1.Value;
            //proces.Descricao = string.IsNullOrEmpty(textBox1.Text) ? "Processamento Normal" : textBox1.Text;
            //proces.Tipoproces = tbTipoProces.tb1.Text;
            //proces.CCusto = tbCCusto.tb1.Text;
            //proces.Obs = tbObs.Text;
            //Processar.Process(proces, qryPe, QryPrc);
            //SendInfo.Invoke(QryPrc, proces);
            //Close();
            //Alert("O Processamento terminou com suceso!",Form_Alert.EnmType.Success);
            //MsBox.Show(Messagem.ParteInicial() + "O Processamento terminou com suceso!");
        }

        //private bool Validado()
        //{
        //    var ret = false;
        //    if (QryPe?.Rows.Count>0)
        //    {
        //        if (QryPe.AsEnumerable().Any(x => x.Field<bool>("Status").Equals(true)))
        //        {
        //            if (!string.IsNullOrEmpty(tbMes.tb1.Text))
        //            {
        //                if (!string.IsNullOrEmpty(tbPeriodo.tb1.Text))
        //                {
        //                    ret = true;
        //                }
        //                else
        //                {
        //                    MsBox.Show(Messagem.ParteInicial() + "Deve indicar o período do Processamento");    
        //                }
        //            }
        //            else
        //            {
        //                MsBox.Show(Messagem.ParteInicial() + "Deve indicar o mês do Processamento");    
        //            }
        //        }
        //        else
        //        {
        //            MsBox.Show(Messagem.ParteInicial()+"Seleciona os funcionários para processar");
        //        }
        //    }
        //    else
        //    {
        //        MsBox.Show(Messagem.ParteInicial()+"Seleciona os funcionários para processar");
        //    }

        //    return ret;
        //}

        private void button2_Click(object sender, EventArgs e)
        {
            //if (!IsValido()) return;
            //var condicao = "";
            //if (!string.IsNullOrEmpty(tbdepartamento.tb1.Text))
            //{
            //    condicao = $" Depart ='{tbdepartamento.tb1.Text.Trim()}'";
            //}

            //if (!string.IsNullOrEmpty(tbSituacao.tb1.Text))
            //{
            //    condicao = BuilcCondicao(tbSituacao.tb1.Text,condicao,"Situacao");
            //}
            //if (!string.IsNullOrEmpty(tbCCusto.tb1.Text))
            //{
            //    condicao = BuilcCondicao(tbCCusto.tb1.Text,condicao,"CCusto");
            //}
            //if (!string.IsNullOrEmpty(condicao))
            //{
            //    condicao =  $" where  {condicao} ";
            //}
            //var qry = $"Select Status=Cast( 0 as bit),processado=Cast( 0 as bit),* from st {condicao}  order by Referenc,Descricao";
            //QryPe = SQL.GetGen2DT(qry);

            //GridProcess.DataSource = null;
            //if (QryPe?.Rows.Count>0)
            //{
            //    var extracondicao="";
            //    if (!string.IsNullOrEmpty(tbdepartamento.tb1.Text))
            //    {
            //        extracondicao = $" Departamento ='{tbdepartamento.tb1.Text.Trim()}'";
            //    }
            //    if (!string.IsNullOrEmpty(tbCCusto.tb1.Text))
            //    {
            //        extracondicao = BuilcCondicao(tbCCusto.tb1.Text,extracondicao,"CCusto");
            //    }

            //    if (!string.IsNullOrEmpty(extracondicao))
            //    {
            //        extracondicao =  $" and  {extracondicao} ";
            //    }
            //    //------------------------------------Adicinado depois------------------//
            //    //foreach (var r in QryPe.AsEnumerable())
            //    //{
            //    //    if (r!=null)
            //    //    {
            //    //        r["processado"] = SQL.CheckExist($"select no from prc where no='{r["no"].ToString().Trim()}' and mes={tbMes.Text2.ToDecimal()} and Tipoproces='{tbTipoProces.tb1.Text.Trim()}' and periodo='{tbPeriodo.tb1.Text.Trim()}' and ano={Ano.Value} {extracondicao}");
            //    //    }
            //    //}

            //    //if (QryPe.AsEnumerable().Any(x=>x.Field<bool>("processado").Equals(false)))
            //    //{
            //    //    QryPe = QryPe.AsEnumerable().Where(x => x.Field<bool>("processado").Equals(false)).CopyToDataTable();
            //    //    GridProcess.AutoGenerateColumns = false;
            //    //    GridProcess.DataSource=QryPe;
            //    //}
            //    //else
            //    //{
            //    //    MsBox.Show(Messagem.ParteInicial()+"Não foi encontrado nenhum funcionário nas condições fornecidas! \r\n Conjugado com a verificação");      
            //    //}

            //}
            //else
            //{
            //    MsBox.Show(Messagem.ParteInicial()+"Não foi encontrado nenhum funcionário nas condições fornecidas!");    
            //}
        }

        //private bool IsValido()
        //{
        //    var ret = false;
        //    if (Ano.Value!=0)
        //    {
        //        if (!string.IsNullOrEmpty(tbPeriodo.tb1.Text))
        //        {
        //            if (!string.IsNullOrEmpty(tbMes.tb1.Text))
        //            {

        //                if (!string.IsNullOrEmpty(tbTipoProces.tb1.Text))
        //                {
        //                    ret = true;
        //                }
        //                else
        //                {
        //                    MsBox.Show(Messagem.ParteInicial()+"O tipo de processamento é obrigatório!");    
        //                }
        //            }
        //            else
        //            {
        //                MsBox.Show(Messagem.ParteInicial()+"O Mês é obrigatório!");    
        //            }
        //        }               
        //        else
        //        {
        //            MsBox.Show(Messagem.ParteInicial()+"O Período é obrigatório!");    
        //        }
        //    }
        //    else
        //    {
        //        MsBox.Show(Messagem.ParteInicial()+"O Ano não pode ser Zerro é obrigatório!");   
        //    }

        //    return ret;
        //}

        private string BuilcCondicao(string tb1Text, string condicao,string campo)
        {
            return  string.IsNullOrEmpty(condicao) ? $" {campo} = '{tb1Text.Trim()}'" : $" {condicao} and {campo} = '{tb1Text.Trim()}'";
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            //Helper.UpdateGrid(cbPorReferencia.cb1.Checked,GridProcess,_dtSearch,tbProcura.Text);
        }

        private void cbDefault2_Load(object sender, EventArgs e)
        {

        }
    }
}
