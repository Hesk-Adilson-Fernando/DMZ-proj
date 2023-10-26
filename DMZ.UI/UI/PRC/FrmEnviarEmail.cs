using System;
using System.Collections;
using System.Data;
using System.IO;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;

namespace DMZ.UI.UI.PRC
{
    public partial class FrmEnviarEmail : FrmClasse2
    {
        ArrayList _aAnexosEmail;
        public DataTable Dt { get; set; }
        public DataTable Proctbla { get; set; }

        private void FrmEnviarEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
            else if (e.KeyCode == Keys.F9)
            {
                btnAnexar_Click(sender, e);
            }
            else if (e.KeyCode == Keys.F5)
            {
                btnEnviar_Click(sender, e);
            }
        }

        private void btnAnexar_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    string[] arr = openFileDialog.FileNames;
                    _aAnexosEmail = new ArrayList();
                    _aAnexosEmail.AddRange(arr);
                    foreach (string s in _aAnexosEmail)
                    {
                        txtAnexo.Text += s + @"; ";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Error");
                }
            }
        }


         private void btnEnviar_Click(object sender, EventArgs e)
        {
            DataTable a=null;
            try
            {
                var ret = string.Empty;
                var retev = string.Empty;
                for (int i = 0; i < dataGridViewFnc.Rows.Count; i++)
                {
                    var path = Application.StartupPath;
                    System.Diagnostics.Process[] process = System.Diagnostics.Process.GetProcessesByName("Excel");
                    foreach (System.Diagnostics.Process p in process)
                    {
                        if (!string.IsNullOrEmpty(p.ProcessName))
                        {
                            try
                            {
                                p.Kill();
                            }
                            catch
                            {
                                //
                            }
                        }
                    }

                    int uge = 0;
                    try
                    {
                        foreach (var fileName in Directory.GetFiles(path))
                        {
                            if (fileName.Contains("PLanoDeAquisicao"))
                            {
                                //fileName is the file name
                                File.Delete(fileName);
                            }
                            if (fileName.Contains("DadosdaUGEAdtExcel.xlsx"))
                            {
                                uge += 1;
                            }
                        }
                    }
                    catch
                    {
                        //
                    }

                    if (uge==0)
                    {
                        var pft = Application.StartupPath;
                        pft += $"\\DadosdaUGEAdtExcel.xlsx";
                        Helper.ExportToExcel(Proctbla, pft);
                    }
                    var da = DateTime.Now;
                    var min = da.Year + da.Month + da.Day + da.Hour + da.Minute + da.Second + da.Millisecond;
                    path += $"\\PLanoDeAquisicao{i+ min}dtExcel.xlsx";
                    var nam = dataGridViewFnc.Rows[i].Cells["Nome"].Value.ToString();
                    var num = dataGridViewFnc.Rows[i].Cells["No"].Value.ToString();
                    if (dataGridViewFnc.Rows[i].Cells["select"].Value.ToBool())
                    {
                        if (i == 0)
                        {
                            ret = dataGridViewFnc.Rows[i].Cells["Email"].Value.ToString();
                        }
                        else
                        {
                            ret += $",\n\n {dataGridViewFnc.Rows[i].Cells["Email"].Value}";
                        }
                        var ft = new DataTable(Dt.TableName);
                        for (int j = 0; j < Dt.Columns.Count; j++)
                        {
                            if (!Dt.Columns[j].ColumnName.ToLower().Equals("select"))
                            {
                                ft.Columns.Add(Dt.Columns[j].ColumnName);
                            }
                        }
                        for (int j = 0; j < gridUIFt1.Rows.Count; j++)
                        {
                            if (gridUIFt1.Rows[j].Cells["selects"].Value.ToBool())
                            {
                                DataRow dr = ft.NewRow();
                                for (int k = 0; k < ft.Columns.Count; k++)
                                {
                                    if (!ft.Columns[k].ColumnName.ToLower().Equals("select"))
                                    {
                                        if (ft.Columns[k].ColumnName.ToLower().Equals("nome"))
                                        {
                                            dr[ft.Columns[k].ColumnName] = nam;
                                        }
                                        else if (ft.Columns[k].ColumnName.ToLower().Equals("no"))
                                        {
                                            dr[ft.Columns[k].ColumnName] = num;
                                        }
                                        else
                                        {
                                            try
                                            {
                                                if (ft.Columns[k].ColumnName.ToLower().Equals("email"))
                                                {
                                                    if (string.IsNullOrEmpty(gridUIFt1.Rows[j].Cells[ft.Columns[k].ColumnName + "1"].Value.ToString()))
                                                    {
                                                        gridUIFt1.Rows[j].Cells[ft.Columns[k].ColumnName + "1"].Value =
                                                            dataGridViewFnc.Rows[i].Cells["Email"].Value.ToString();
                                                    }
                                                    dr[ft.Columns[k].ColumnName] =
                                                        gridUIFt1.Rows[j].Cells[ft.Columns[k].ColumnName+"1"].Value.ToString();

                                                }
                                                else
                                                {
                                                    if (ft.Columns[k].ColumnName.ToLower().Equals("fncstamp"))
                                                    {
                                                        if (string.IsNullOrEmpty(gridUIFt1.Rows[j].Cells[ft.Columns[k].ColumnName].Value.ToString()))
                                                        {
                                                            gridUIFt1.Rows[j].Cells[ft.Columns[k].ColumnName].Value =
                                                                dataGridViewFnc.Rows[i].Cells["fncstamp1"].Value.ToString();
                                                        }
                                                    }
                                                    dr[ft.Columns[k].ColumnName] =
                                                        gridUIFt1.Rows[j].Cells[ft.Columns[k].ColumnName].Value.ToString();
                                                }
                                            }
                                            catch (Exception ex)
                                            {

                                                throw;
                                            }
                                        }
                                    }
                                }
                                ft.Rows.Add(dr);
                            }
                        }
                        for (int j = 0; j < ft.Rows.Count; j++)
                        {
                            ft.Rows[j]["Email"] = dataGridViewFnc.Rows[i].Cells["Email"].Value.ToString();
                            ft.Rows[j]["no"] = dataGridViewFnc.Rows[i].Cells["no"].Value.ToString();
                            ft.Rows[j]["nome"] = dataGridViewFnc.Rows[i].Cells["nome"].Value.ToString();
                        }
                        Helper.ExportToExcel(ft, path);
                        var pt = Application.StartupPath;
                        pt += $"\\DadosdaUGEAdtExcel.xlsx";
                        path += $";{pt}";
                        if (!string.IsNullOrEmpty(txtAnexo.Text))
                        {
                            path += $";{txtAnexo.Text}";
                        }
                        var arr = path.Split(';');

                        //cria um novo arraylist
                        _aAnexosEmail = new ArrayList();
                        //percorre o array de string e inclui os anexos
                        for (int k = 0; k < arr.Length; k++)
                        {
                            
                            if (!string.IsNullOrEmpty(arr[k].Trim()))
                            {
                                _aAnexosEmail.Add(arr[k].Trim());
                            }
                        }
                        
                        if (_aAnexosEmail.Count > 0)
                        {
                            var email = dataGridViewFnc.Rows[i].Cells["Email"].Value.ToString();
                            retev = EnviarEmail.EnviaEmail.EnviaMensagemComAnexos("destina",email,
                                txtAssunto.Text, txtMensagem.Text,
                                _aAnexosEmail);
                            if (retev.Contains("Email do destinatário inválido"))
                            {
                                ret = retev.ToUpper();
                            }
                            else if (retev.Contains("The specified string is not in the form required for an e-mail address"))
                            {
                                ret = "Endereço electrónico não válido".ToUpper();
                            }
                            else if(retev.Contains("Mensagem enviada para"))
                            {
                                ret = ret.ToUpper();
                            }
                            else if (retev.Contains($"The SMTP server requires a secure" +
                                                    $" connection or the client was not " +
                                                    $"authenticated. The server response " ))
                            {

                                ret = $"Verifique a senha ou endereço electrónico ou\r\nActive a opção Acesso a app menos seguro da".ToUpper() +
                                                $" sua Conta do Google!".ToUpper()+ 
                                                $"\r\n Erro 01".ToUpper();
                                     // ret = $"Verifique a senha e o endereço electrónico\r\n Erro 01".ToUpper();

                                //ret = "Verifique a senha e o endereço electrónico".ToUpper();
                            }
                            //else if (retev.Contains($"The SMTP server requires a secure" +
                            //                        $" connection or the client was not " +
                            //                        $"authenticated"))
                            //{
                            //    ret = $"Active a opção Acesso a app menos seguro da".ToUpper() +
                            //          $" sua Conta do Google!".ToUpper(); // +
                            //    //$" através do seguinte link ".ToUpper() +
                            //    //$" https://support.google.com/accounts/answer/6010255?hl=pt#zippy=%2Cse-a-op%C3%A7%C3%A3o-acesso-a-app-menos-seguro-estiver-ativada-para-sua-conta";
                            //}
                            else
                            {
                                ret = retev.ToUpper();
                            }
                        }
                        else
                        {
                            var email = dataGridViewFnc.Rows[i].Cells["Email"].Value.ToString();
                            retev =  EnviarEmail.EnviaEmail.EnviaMensagemEmail("",email,
                                txtAssunto.Text, txtMensagem.Text);
                            if (retev.Contains("Email do destinatário inválido"))
                            {
                                ret = retev.ToUpper();
                            }
                            else if (retev.Contains("The specified string is not in the form required for an e-mail address"))
                            {
                                ret = "Endereço electrónico não válido".ToUpper();
                            }
                            else if (retev.Contains("Mensagem enviada para"))
                            {
                                ret = ret.ToUpper();
                            }
                            else if (retev.Contains("The SMTP server requires a secure connection or the client was not authenticated"))
                            {
                                ret = $"Verifique a senha ou endereço electrónico ou\r\nActive a opção Acesso a app menos seguro da".ToUpper() +
                                      $" sua Conta do Google!".ToUpper() +
                                      $"\r\n Erro 01".ToUpper();
                            }
                            //else if (retev.Contains($"The SMTP server requires a secure" +
                            //                        $" connection or the client was not " +
                            //                        $"authenticated"))
                            //{
                            //    ret = $"Active a opção Acesso a app menos seguro da".ToUpper() +
                            //          $" sua Conta do Google!".ToUpper();
                            //          //$" através do seguinte link ".ToUpper() +
                            //          //$" https://support.google.com/accounts/answer/6010255?hl=pt#zippy=%2Cse-a-op%C3%A7%C3%A3o-acesso-a-app-menos-seguro-estiver-ativada-para-sua-conta" ;
                            //}
                            else
                            {
                                ret = retev.ToUpper();
                            }
                        }
                    }
                }

                if (retev.Contains("Mensagem enviada para"))
                {
                    ret = "Mensagem enviada para ".ToUpper() + ret.ToUpper() + " às ".ToUpper() +
                          DateTime.Now.ToString("HH:mm:ss") + " do dia ".ToUpper() + DateTime.Now.ToString("dd-MM-yyyy") + ".";
                    MessageBox.Show(ret, @"Informação".ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ret = "Mensagem não enviada ".ToUpper() + ret.ToUpper() +  ".";
                    MessageBox.Show(ret, @"Aviso do sistema".ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($@"Erro ao tentar enviar o e-mail!" 
                                + ex.Message, $@"Aviso do Sistema", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #region Quebrar todos ficheiros de Excel Criados ao enviar as mensages
            try
            {

                var path = Application.StartupPath;
                foreach (var fileName in Directory.GetFiles(path))
                {
                    if (fileName.Contains("dtExcel.xlsx"))
                    {
                        //fileName is the file name
                        File.Delete(fileName);
                    }
                }
            }
            catch
            {
                //
            }

            #endregion
        }
        int _cnt;
        public FrmEnviarEmail()
        {
            InitializeComponent();
        }
        private void FrmEnviarEmail_Load(object sender, EventArgs e)
        {
            try
            {
                EditMode = true;
                var dt = SQL.GetGenDT("select distinct Email,Nome,no,Fnc.fncstamp from Fnc inner join fncProc on FncProc.Fncstamp=fnc.Fncstamp where Email<>''");
                dt.Columns.Add("select", typeof(bool));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["select"] = false;
                }

                dataGridViewFnc.DataSource = dt;
                var table = Dt;
                table.Columns.Add("select", typeof(bool));
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    table.Rows[i]["select"] = false;
                }
                gridUIFt1.DataSource = table;
                var pft = Application.StartupPath;
                pft += $"\\DadosdaUGEAdtExcel.xlsx";
                Helper.ExportToExcel(Proctbla, pft);
            }
            catch (Exception)
            {
                //
            }
        }

       private void UpdCln(bool cb1Checked, string s, DataGridView dgv)
        {
            foreach (DataGridViewRow r in dgv.Rows)
            {
                r.Cells[s].Value = cb1Checked;
            }
        }

        private void chkbxTodosFnc_CheckedChangeds()
        {
            UpdCln(chkbxTodosFnc.cb1.Checked, "select",dataGridViewFnc);
        }
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtAnexo.Text))
            {
                txtAnexo.Clear();
            }
        }

        private void cbkxTodosProdutos_CheckedChangeds()
        {
            UpdCln(cbkxTodosProdutos.cb1.Checked, "selects", gridUIFt1);
        }

    }
}
