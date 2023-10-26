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
    public partial class FrmAddProcess : FrmClasse2
    {
        private DataTable dtDepart;

        public FrmAddProcess()
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
        public DataTable _dtSearch { get;  set; }
        public DataTable dtCentros { get; set; }
        private void FrmAddProcess_Load(object sender, EventArgs e)
        {
            Ano.Value = Pbl.SqlDate.Year;
            QryPrc = SQL.Initialize("prc");
            var dr = SQL.GetRow("select codigo,descricao from PeAuxiliar where Tabela=19 and Padrao=1");
            if (!dr.DataRowIsNull())
            {
                tbSituacao.tb1.Text = dr["descricao"].ToString();
                tbSituacao.Text2 = dr["codigo"].ToString();
            }
            var dr2 = SQL.GetRow("select descricao from PeAuxiliar where Tabela=23 and Padrao=1");
            if (!dr2.DataRowIsNull())
            {
                tbTipoProces.tb1.Text = dr2["descricao"].ToString();
            }
            var dr3 = SQL.GetRow("select descricao from PeAuxiliar where Tabela=22 and Padrao=1");
            if (!dr3.DataRowIsNull())
            {
                tbPeriodo.tb1.Text = dr3["descricao"].ToString();
            }
            var dr4 = SQL.GetRow($"select Codigo,Descricao,Mesesstamp from Meses where codigo={Pbl.SqlDate.Month}");
            if (!dr4.DataRowIsNull())
            {
                tbMes.tb1.Text = dr4["descricao"].ToString();
                tbMes.Text2 = dr4["codigo"].ToString();
                tbMes.Text3 = dr4["Mesesstamp"].ToString();
            }
            dtCentros = SQL.GetGen2DT("select Ccustamp,Descricao,Cast(0 as bit ) ok from CCu");
            GridCentros.SetDataSource(dtCentros);
            dtDepart = SQL.GetGen2DT("select Empresadepstamp,Descricao, cast(0 as bit) ok from Empresadep order by Descricao");
            gridUiDepart.SetDataSource(dtDepart);
        }
        private void btnAddprocess_Click(object sender, EventArgs e)
        {
            if (!Validado()) return;
            var qryPe = QryPe.AsEnumerable().Where(x => x.Field<bool>("Status").Equals(true)).CopyToDataTable();
            if (qryPe.Rows.Count <= 0) return;
            var mx = SQL.Maximo("proces", "codigo", $"ano={Ano.Value}");
            var proces = Utilities.DoAddline<Proces>();
            proces.Codigo = mx.ToDecimal();
            proces.Processtamp = Pbl.Stamp();
            proces.Mes = tbMes.tb1.Text;
            proces.Periodo = tbPeriodo.tb1.Text;
            proces.Ano = Ano.Value;
            proces.Nrmes = tbMes.Text2.ToDecimal();
            proces.Mesesstamp = tbMes.Text3.Trim();
            proces.Data = dateTimePicker1.Value;
            proces.Descricao = string.IsNullOrEmpty(textBox1.Text) ? "Processamento Normal" : textBox1.Text;
            proces.Tipoproces = tbTipoProces.tb1.Text;
            //proces.CCusto = tbCCusto.tb1.Text;
            proces.Obs = tbObs.Text;
            Processar.Process(proces, qryPe, QryPrc);
            SendInfo.Invoke(QryPrc, proces);
            Close();
            Alert("O Processamento terminou com suceso!",Form_Alert.EnmType.Success);
            //MsBox.Show(Messagem.ParteInicial() + "O Processamento terminou com suceso!");
        }

        private bool Validado()
        {
            var ret = false;
            if (QryPe?.Rows.Count>0)
            {
                if (QryPe.AsEnumerable().Any(x => x.Field<bool>("Status").Equals(true)))
                {
                    if (!string.IsNullOrEmpty(tbMes.tb1.Text))
                    {
                        if (!string.IsNullOrEmpty(tbPeriodo.tb1.Text))
                        {
                            ret = true;
                        }
                        else
                        {
                            MsBox.Show(Messagem.ParteInicial() + "Deve indicar o período do Processamento");    
                        }
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "Deve indicar o mês do Processamento");    
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial()+"Seleciona os funcionários para processar");
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial()+"Seleciona os funcionários para processar");
            }

            return ret;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!IsValido()) return;
            var condicao = "";
            GridCentros.Update();
            gridUiDepart.Update();
            if (dtDepart.CheckAny("ok"))
            {
                var dt = dtDepart.GetCheckedRows("ok");
                var departamentos =Helper.BuildInCondicao(dt, "Empresadepstamp");
                if (condicao.IsNullOrEmpty())
                {
                    condicao = $" Codep in ({departamentos})";
                }
                else
                {
                    condicao = $" {condicao} and Codep in ({departamentos})";
                }
                
            }
            if (!string.IsNullOrEmpty(tbSituacao.tb1.Text))
            {
                condicao = BuilcCondicao(tbSituacao.tb1.Text,condicao,"Situacao");
            }
            if (dtCentros.CheckAny("ok"))
            {
                var dt = dtCentros.GetCheckedRows("ok");
                var centros = Helper.BuildInCondicao(dt,"Ccustamp");
                if (condicao.IsNullOrEmpty())
                {
                    condicao = $" Ccustamp in ({centros})";
                }
                else
                {
                    condicao = $" {condicao} and Ccustamp in ({centros})";
                }

            }
            if (!string.IsNullOrEmpty(condicao))
            {
                condicao =  $" where  {condicao} ";
            }
            var qry = $"Select Status=Cast( 0 as bit),processado=Cast( 0 as bit),* from pe {condicao}  order by nome";
            QryPe = SQL.GetGen2DT(qry);
            GridProcess.DataSource = null;
            if (QryPe.HasRows())
            {
                var extracondicao="";
                if (!string.IsNullOrEmpty(tbSituacao.tb1.Text))
                {
                    extracondicao = BuilcCondicao(tbSituacao.tb1.Text,extracondicao,"codsit");
                }
                //if (!string.IsNullOrEmpty(tbCCusto.tb1.Text))
                //{
                //    extracondicao = BuilcCondicao(tbCCusto.tb1.Text, extracondicao, "CCusto");
                //}
                if (!string.IsNullOrEmpty(extracondicao))
                {
                    extracondicao =  $" and  {extracondicao} ";
                }
                foreach (var r in QryPe.AsEnumerable())
                {
                    if (r!=null)
                    {
                        r["processado"] = SQL.CheckExist($"select Pestamp from prc where Pestamp='{r["Pestamp"].ToString().Trim()}' and Mesesstamp='{tbMes.Text3.Trim()}' and Tipoproces='{tbTipoProces.tb1.Text.Trim()}' and periodo='{tbPeriodo.tb1.Text.Trim()}' and ano={Ano.Value} {extracondicao}");
                    }
                }
                if (QryPe.AsEnumerable().Any(x=>x.Field<bool>("processado").Equals(false)))
                {
                    QryPe = QryPe.AsEnumerable().Where(x => x.Field<bool>("processado").Equals(false)).CopyToDataTable();
                    if (Pbl.Param.Usacademia)
                    {
                        foreach (var r in QryPe.AsEnumerable())
                        {
                            if (r != null)
                            {
                                var xxx= SQL.GetField($"select ValBasico from PeSalbase where Pestamp='{r["Pestamp"].ToString().Trim()}' and Mesesstamp='{tbMes.Text3.Trim()}'");
                                r["ValBasico"] = xxx.ToDecimal();
                            }
                        }
                        if (QryPe.AsEnumerable().Any(x => !x.Field<decimal>("ValBasico").Equals(0)))
                        {
                            QryPe = QryPe.AsEnumerable().Where(x => !x.Field<decimal>("ValBasico").Equals(0))?.CopyToDataTable();
                            GridProcess.SetDataSource(QryPe);
                            tbTotalregisto.Text = QryPe.Rows.Count.ToString();
                        }
                    }
                    else
                    {
                        QryPe = QryPe.AsEnumerable().Where(x => !x.Field<decimal>("ValBasico").Equals(0))?.CopyToDataTable();
                        GridProcess.SetDataSource(QryPe);
                        tbTotalregisto.Text = QryPe.Rows.Count.ToString();
                    }
                }
                else
                {
                    MsBox.Show("Não foi encontrado nenhum funcionário nas condições fornecidas! \r\n Conjugado com a verificação");      
                }

            }
            else
            {
                MsBox.Show("Não foi encontrado nenhum funcionário nas condições fornecidas!");    
            }
        }

        private bool IsValido()
        {
            var ret = false;
            if (Ano.Value!=0)
            {
                if (!string.IsNullOrEmpty(tbPeriodo.tb1.Text))
                {
                    if (!string.IsNullOrEmpty(tbMes.tb1.Text))
                    {

                        if (!string.IsNullOrEmpty(tbTipoProces.tb1.Text))
                        {
                            ret = true;
                        }
                        else
                        {
                            MsBox.Show(Messagem.ParteInicial()+"O tipo de processamento é obrigatório!");    
                        }
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial()+"O Mês é obrigatório!");    
                    }
                }               
                else
                {
                    MsBox.Show(Messagem.ParteInicial()+"O Período é obrigatório!");    
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial()+"O Ano não pode ser Zerro é obrigatório!");   
            }

            return ret;
        }

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
            Helper.UpdateGrid(cbPorReferencia.cb1.Checked,GridProcess,_dtSearch,tbProcura.Text);
        }

        private void cbDefault2_Load(object sender, EventArgs e)
        {

        }

        private void GridProcess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridProcess.CurrentRow == null) return;
            GridProcess.Update();
            UpdateValues();
        }
        private void UpdateValues()
        {
            try
            {
                var nome = GridProcess.CurrentCell.OwningColumn.Name;
                if (nome.Equals("Status"))
                {
                    GridProcess.EndEdit();
                    if (QryPe.HasRows())
                    {
                        GridProcess.Update();
                        if (QryPe.AsEnumerable().Any(x => x.Field<bool?>("Status").Equals(true)))
                        {
                            tbContador.Text = QryPe.AsEnumerable().Where(x => x.Field<bool?>("Status").Equals(true)).CopyToDataTable().Rows.Count.ToString();
                        }
                        else
                        {
                            tbContador.Text = "0";
                        }
                    }
                    else
                    {
                        tbContador.Text = "0";
                    }
                }
            }
            catch
            {
                //
            }
        }
        private void cbCentros_CheckedChanged(object sender, EventArgs e)
        {
            GridCentros.CheckUncheckAll("ok", cbCentros.Checked);
        }

        private void cbDepart_CheckedChanged(object sender, EventArgs e)
        {
            gridUiDepart.CheckUncheckAll("ok2", cbDepart.Checked);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            GridProcess.CheckUncheckAll("Status", checkBox1.Checked);
            UpdateValues();
        }
    }
}
