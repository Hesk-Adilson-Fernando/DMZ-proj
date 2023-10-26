using System;
using System.Data;
using System.Linq;
using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System.Windows.Forms;
using System.Drawing;
using DMZ.UI.UC;

namespace DMZ.UI.UI.RH
{
    public partial class FrmAltermensal : Basic.FrmClasse2
    {
        private DataTable dtPeSalbase;

        public FrmAltermensal()
        {
            InitializeComponent();
            
        }

        public DataTable QryPe { get; private set; }
        public DataTable Pedesc { get; private set; }
        public DataTable Pesub { get; private set; }

        private string BuilcCondicao(string tb1Text, string condicao,string campo)
        {
            return  string.IsNullOrEmpty(condicao) ? $" {campo} = '{tb1Text.Trim()}'" : $" {condicao} and {campo} = '{tb1Text.Trim()}'";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            //if (!IsValido()) return;
            var condicao = "";
            if (!string.IsNullOrEmpty(tbdepartamento.tb1.Text))
            {
                condicao = $" Depart ='{tbdepartamento.tb1.Text.Trim()}'";
            }

            if (!string.IsNullOrEmpty(tbSituacao.tb1.Text))
            {
                condicao = BuilcCondicao(tbSituacao.tb1.Text,condicao,"Situacao");
            }
            if (!string.IsNullOrEmpty(tbCCusto.tb1.Text))
            {
                condicao = BuilcCondicao(tbCCusto.tb1.Text, condicao, "ccusto");
            }
            if (!string.IsNullOrEmpty(condicao))
            {
                condicao =  $" where  {condicao} ";
            }
            var qry = $"Select Status=Cast( 0 as bit),* from pe {condicao}  order by no,nome";
            QryPe = SQL.GetGen2DT(qry);
            GridProcess.SetDataSource(QryPe);
            tbTotalregisto.Text= QryPe.Rows.Count.ToString();
        }

        private void cbDefault1_CheckedChangeds()
        {
            GridProcess.CheckUncheckAll("Status",cbDefault1.cb1.Checked);
            GridProcess.EndEdit();
            Somatorio();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, GridProcess, QryPe, tbProcura.Text);
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            GridProcess.Update();
            var messag = MsBox.Show(Messagem.ParteInicial()+"Deseja gravar as alterações!",DResult.YesNo);
            if (messag.DialogResult == DialogResult.Yes)
            {
                if (QryPe.HasRows())
                {
                    var dt = QryPe.HasRowsCopyToDataTable("Status");                    
                    if (dt.HasRows())
                    {
                        if (LancHoras)
                        {
                            if (!tbMes.Text2.IsNullOrEmpty())
                            {
                                Helper.DoProgressProcess(dt, RecebeDados);
                            }
                            else
                            {
                                MsBox.Show("Deve indicar o mês em que pretende lançar as horas dos professores!");
                            }
                        }
                        else
                        {
                            Helper.DoProgressProcess(dt, RecebeDados);
                        }

                    }
                }
                else
                {
                    MsBox.Show("Deve indicar o funcionário(s) que pretende executar as alterações!");
                }
            }
        }

        private void RecebeDados(DataRow pe, bool fim)
        {
            if (LancHoras)
            {
                var dt = SQL.GetGen2DT($"select * from PeSalbase where Pestamp='{pe["Pestamp"].ToTrim()}' and Mesesstamp='{tbMes.Text2.Trim()}'");
                if (!dt.HasRows())
                {
                    var l = dtPeSalbase.NewRow().Inicialize();
                    FillRow(l,pe);
                    dtPeSalbase.Rows.Add(l);
                }
                else
                {
                    var dr = MsBox.Show($"O Software encontrou um lançamento do:\r\n {pe["nome"].ToTrim()} \r\n Para o mês de: {tbMes.tb1.Text} \r\n Deseja que o software actualize os dados?",DResult.YesNo);
                    if (dr.DialogResult==DialogResult.Yes)
                    {
                        FillRow(dt.Rows[0],pe);
                        SQL.Save(dt, dt.TableName, true, "", "");
                    }
                }
                if (fim)
                {
                    if (SQL.Save(dtPeSalbase, dtPeSalbase.TableName, true, "", "").numero>0)
                    {
                        MsBox.Show("Processo Terminado com sucesso!");
                    }
                }
            }
            else
            {
                #region Processamento de faltas ......
                if (cbProcessFaltas.cb1.Checked)
                {
                    var datas = monthCalendarFaltas.BoldedDates;
                    if (datas.Length > 0)
                    {
                        if (!tbNrHoras.tb1.Text.ToDecimal().IsZero())
                        {
                            var pefalta = SQL.Initialize("Pefalta");
                            foreach (var data in datas)
                            {
                                var dr = pefalta.NewRow().Inicialize();
                                dr["DescontaRem"] = cbDescontaliment.cb1.Checked;
                                FillInfo(pe["Pestamp"].ToString(), data, dmzFalta, cbExcluiproc.cb1.Checked, tbNrHoras.tb1.Text.ToDecimal(), pefalta, dr);
                            }
                            Gravar(pefalta);
                        }
                        else
                        {
                            MsBox.Show(Messagem.ParteInicial() + "Deve indicar o número de horas faltadas por dia....");
                        }
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "Deve indicar os dias de falta(s)....");
                    }
                }
                #endregion

                #region Processamento de Horas extras 
                if (cbProcHoraExtras.cb1.Checked)
                {
                    var datas = monthCalendarHExtras.BoldedDates;
                    if (datas.Length > 0)
                    {
                        if (!tbHeHoras.tb1.Text.ToDecimal().IsZero())
                        {
                            var pehextra = SQL.Initialize("Pehextra");
                            foreach (var data in datas)
                            {
                                var dr = pehextra.NewRow().Inicialize();
                                FillInfo(pe["Pestamp"].ToString(), data, dmzHoraextra, cbHeExcluiproc.cb1.Checked, tbHeHoras.tb1.Text.ToDecimal(), pehextra, dr);
                                dr["Tipo"] = dmzHoraextra.Text3;
                                dr["valor"] = TbValorPercHextras.tb1.Text;
                            }
                            Gravar(pehextra);
                        }
                        else
                        {
                            MsBox.Show(Messagem.ParteInicial() + "Deve indicar o número de horas extras por dia....");
                        }
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "Deve indicar os dias de Horas extras....");
                    }
                }
                #endregion

                #region Processamento de Descontos 
                if (cbProcDescontos.cb1.Checked)
                {
                    var dt = dgvPeDesc.GetBindedTable();

                    if (dt.HasRows())
                    {
                        foreach (var r in dt.AsEnumerable())
                        {
                            var pedesc = SQL.Initialize("Pedesc");
                            var dr = pedesc.NewRow().Inicialize();
                            dr["Pestamp"] = pe["Pestamp"];
                            dr["Datain"] = r["Datain"];
                            dr["Datafim"] = r["Datafim"];
                            dr["Codigo"] = r["Codigo"];
                            dr["Tipo"] = r["Tipo"];
                            dr["Descricao"] = r["Descricao"];
                            dr["ExcluiProc"] = r["ExcluiProc"];
                            dr["valor"] = r["valor"];
                            dr["Tipodesc"] = r["Tipodesc"];
                            pedesc.Rows.Add(dr);
                            Gravar(pedesc);
                        }
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "Deve indicar o tipo de desconto a processar....");
                    }
                }
                #endregion

                #region Processamento de subsidios 
                if (cbProcessaRemun.cb1.Checked)
                {
                    var dt = dgvSub.GetBindedTable();

                    if (dt.HasRows())
                    {
                        foreach (var r in dt.AsEnumerable())
                        {
                            var pesub = SQL.Initialize("Pesub");
                            var dr = pesub.NewRow().Inicialize();
                            dr["Pestamp"] = pe["Pestamp"];
                            dr["Codigo"] = r["Codigo"];
                            dr["Descricao"] = r["Descricao"];
                            dr["ExcluiProc"] = r["ExcluiProc"];
                            dr["valor"] = r["valor"];
                            dr["Tiposub"] = r["Tiposub"];
                            dr["Tipo"] = r["Tipo"];
                            dr["Datain"] = r["Datain"];
                            dr["Datafim"] = r["Datafim"];
                            pesub.Rows.Add(dr);
                            Gravar(pesub);
                        }
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "Deve indicar o Valor/Percentagem do subsídio a processar....");
                    }
                }
                #endregion

                #region Processamento de IRPS 
                if (cbIRPS.cb1.Checked)
                {
                    if (!tbTabela.tb1.Text.IsNullOrEmpty())
                    {
                        SQL.SqlCmd($"update pe set Tirpsstamp='{tbTabela.Text2.Trim()}',TabIrps='{tbTabela.tb1.Text}' where pestamp ='{pe["Pestamp"].ToString().Trim()}'");
                    }
                }
                #endregion
                if (fim)
                {
                    MsBox.Show(Messagem.ParteInicial() + "Processo Terminado com sucesso!");
                }
            }

        }

        private void FillRow(DataRow dataRow, DataRow pe)
        {
            dataRow["Pestamp"] = pe["Pestamp"];
            dataRow["SalHora"] = pe["SalHora"];
            dataRow["ValBasico"] = pe["ValBasico"];
            dataRow["Nrhoras"] = pe["HorasSemana"];
            dataRow["Datalanc"] = dtLanhoras.Value;
            dataRow["Mesesstamp"] = tbMes.Text2;
            dataRow["Mes"] = tbMes.tb1.Text;
            dataRow["Usrstamp"] = Pbl.Usr.Usrstamp;
        }

        private void FillInfo(string Pestamp, DateTime data, DmzProcura dmzObj, bool ExcluiProc, decimal Horas, DataTable dt, DataRow dr)
        {
            dr["Pestamp"] = Pestamp;
            dr["Data"] = data;
            dr["Codigo"] = dmzObj.Text2;
            dr["Descricao"] = dmzObj.tb1.Text;
            dr["ExcluiProc"] = ExcluiProc;
            dr["Horas"] = Horas;
            dt.Rows.Add(dr);
        }

        private void Gravar(DataTable tabela)
        {
            SQL.Save(tabela,tabela.TableName, true, "", "pe");
        }

        private void tbNrHoras_Load(object sender, EventArgs e)
        {

        }

        private void dmzMonth1_RefreshControls()
        {
            //tbNrDias.tB1.Text= dmzMonthFaltas.Lista.Count.ToString();    
        }

        private void tbDefault2_Load(object sender, EventArgs e)
        {

        }

        private void FrmAltermensal_Load(object sender, EventArgs e)
        {
            monthCalendarFaltas.TitleBackColor = Color.FromArgb(192, 0, 0);
            Pedesc = SQL.Initialize("Pedesc");
            Pesub = SQL.Initialize("Pesub");
            dgvPeDesc.SetDataSource(Pedesc);
            dgvPeDesc.DtDS = Pedesc;
            dgvSub.SetDataSource(Pesub);
            dgvSub.DtDS = Pesub;
            EditMode = true;
            GridProcess.Columns["Nrhoras"].Visible = LancHoras;
            GridProcess.Columns["Salhora"].Visible = LancHoras;
            GridProcess.Columns["ValBasico"].Visible = LancHoras;
            if (LancHoras)
            {
                tabControl2.TabPages.Remove(tabPageDescontos);
                tabControl2.TabPages.Remove(tabPageFaltas);
                tabControl2.TabPages.Remove(tabPageHorasext);
                tabControl2.TabPages.Remove(tabPageIRPS);
                tabControl2.TabPages.Remove(tabPageRemuneracoes);
                dtPeSalbase = SQL.Initialize("PeSalbase");
            }
            else
            {
                tabControl2.TabPages.Remove(tabPageLanchoras);
            }
        }

        private void GridProcess_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (GridProcess.CurrentRow == null) return;
            GridProcess.Update();
            UpdateValues();
        }
        private void UpdateValues()
        {
            var nome = GridProcess.CurrentCell.OwningColumn.Name;
            if (nome.Equals("Status"))
            {
                GridProcess.EndEdit();
                Somatorio();
            }
        }

        private void Somatorio()
        {
            if (QryPe.HasRows())
            {
                GridProcess.Update();
                if (QryPe.AsEnumerable().Any(x => x.Field<bool?>("Status").Equals(true)))
                {
                    tbContador.Text = QryPe.AsEnumerable().Where(x => x.Field<bool?>("Status").Equals(true)).CopyToDataTable().Rows.Count.ToString();
                    //var valor = QryPe.AsEnumerable().Where(x => x.Field<bool?>("ok").Equals(true)).Sum(x => x.Field<decimal>("valorreg"));
                    //tbValorReg.Text = valor.ToString().SetMask();
                }
                else
                {
                    tbContador.Text = "0";
                   // tbValorReg.Text = "0";
                }
            }
            else
            {
                tbContador.Text = "0";
               // tbValorReg.Text = "0";
            }
        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (!Maximizado)
            {
                Maximizar();
            }
            else
            {
                Minimizar();
            }
        }

        private void monthCalendar1_MouseDown(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo info = monthCalendarFaltas.HitTest(e.Location);
            if (info.HitArea == MonthCalendar.HitArea.Date)
            {
                if (monthCalendarFaltas.BoldedDates.Contains(info.Time))
                    monthCalendarFaltas.RemoveBoldedDate(info.Time);
                else
                    monthCalendarFaltas.AddBoldedDate(info.Time);
                monthCalendarFaltas.UpdateBoldedDates();
                tbFaltasDias.tb1.Text= monthCalendarFaltas.BoldedDates.Length.ToString();   
            }
        }

        private void monthCalendarHExtras_MouseDown(object sender, MouseEventArgs e)
        {
            MonthCalendar.HitTestInfo info = monthCalendarHExtras.HitTest(e.Location);
            if (info.HitArea == MonthCalendar.HitArea.Date)
            {
                if (monthCalendarHExtras.BoldedDates.Contains(info.Time))
                    monthCalendarHExtras.RemoveBoldedDate(info.Time);
                else
                    monthCalendarHExtras.AddBoldedDate(info.Time);
                monthCalendarHExtras.UpdateBoldedDates();
                tbHedias.tb1.Text = monthCalendarHExtras.BoldedDates.Length.ToString();
            }
        }

        private void btnFaltasRefresh_Click(object sender, EventArgs e)
        {
            monthCalendarFaltas.RemoveAllBoldedDates();
            tbFaltasDias.tb1.Text = monthCalendarFaltas.BoldedDates.Length.ToString();
        }

        private void btnHERefresh_Click(object sender, EventArgs e)
        {
            monthCalendarHExtras.RemoveAllBoldedDates();
            tbHedias.tb1.Text = monthCalendarHExtras.BoldedDates.Length.ToString();
        }

        private void dmzHoraextra_RefreshControls()
        {
            TbValorPercHextras.tb1.Text = dmzHoraextra.Text4;

        }

        private void btnAddRem_Click(object sender, EventArgs e)
        {
            dgvSub.AddLine();
        }

        private void btnDelRem_Click(object sender, EventArgs e)
        {
            dgvSub.DellLine();
        }

        private void dgvPeDesc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvPeDesc.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("Valid")|| nome.Equals("Dataindesc"))
            {
                Helper.AddDateTimePicker(dgvPeDesc, e);
            }
        }
        public DataTable dtPesub { get; set; }
        public DataTable dtPeDesc { get; set; }
        public bool LancHoras { get; internal set; }

        private void dgvPeDesc_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var name = dgvPeDesc.CurrentCell.OwningColumn.Name;
            if (!name.Equals("DescricaoDesc")) return;
            if (!(dtPeDesc?.Rows.Count > 0)) return;
            if (dgvPeDesc.CurrentCell.Value == null) return;
            var valor = dgvPeDesc.CurrentCell.Value;
            var dr = dtPeDesc.AsEnumerable().FirstOrDefault(x =>
                x.Field<string>("Descricao").Trim().Equals(valor.ToString().Trim()));
            if (dr == null) return;
            dgvPeDesc.CurrentRow.Cells["ValorDesc"].Value = dr["Valor"].ToString();
            dgvPeDesc.CurrentRow.Cells["TipoDesc"].Value = dr["Tipo"].ToString();
            dgvPeDesc.CurrentRow.Cells["TipoDesc1"].Value = dr["Tipodesc"].ToString();
            dgvPeDesc.CurrentRow.Cells["coddesc"].Value = dr["codigo"].ToString();
        }

        private void dgvPeDesc_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {

            if (dgvPeDesc.CurrentRow == null) return;
            const string qry = "select * from desconto";
            var name = dgvPeDesc.CurrentCell.OwningColumn.Name;
            if (name.Equals("DescricaoDesc"))
            {
                dtPeDesc = Helper.SetBinds(e.Control, "Descricao", qry);
            }
        }

        private void dgvSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvSub.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("validade") || nome.Equals("datain"))
            {
                Helper.AddDateTimePicker(dgvSub, e);
            }
        }

        private void dgvSub_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var name = dgvSub.CurrentCell.OwningColumn.Name;
            if (!name.Equals("DescricaoSub")) return;
            if (!(dtPesub?.Rows.Count > 0)) return;
            if (dgvSub.CurrentCell.Value == null) return;
            var valor = dgvSub.CurrentCell.Value;
            var dr = dtPesub.AsEnumerable().FirstOrDefault(x =>
                x.Field<string>("Descricao").Trim().Equals(valor.ToString().Trim()));
            if (dr == null) return;
            dgvSub.CurrentRow.Cells["Valor"].Value = dr["Valor"].ToString();
            dgvSub.CurrentRow.Cells["Tipo"].Value = dr["Tipo"].ToString();
            dgvSub.CurrentRow.Cells["codigo"].Value = dr["Codigo"].ToString();
        }

        private void dgvSub_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvSub.CurrentRow == null) return;
            const string qry = "select * from sub";
            var name = dgvSub.CurrentCell.OwningColumn.Name;
            if (name.Equals("DescricaoSub"))
            {
                dtPesub = Helper.SetBinds(e.Control, "descricao", qry);
            }
        }

        private void btnAdddes_Click(object sender, EventArgs e)
        {
            dgvPeDesc.AddLine();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            dgvPeDesc.DellLine();
        }

        private void GridProcess_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (LancHoras)
            {
                if (GridProcess.CurrentRow !=null)
                {
                    var horas = GridProcess.CurrentRow.Cells["Salhora"].Value.ToDecimal();
                    var Lanchoras = GridProcess.CurrentRow.Cells["Nrhoras"].Value.ToDecimal();
                    GridProcess.CurrentRow.Cells["ValBasico"].Value = horas * Lanchoras;
                    GridProcess.CurrentRow.Cells["Status"].Value = true;
                    GridProcess.Update();
                }
            }
        }
    }
}
