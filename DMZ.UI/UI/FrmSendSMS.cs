using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using GsmComm.GsmCommunication;
using GsmComm.PduConverter;
using GsmComm.Server;
using System;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmSendSMS :Basic.FrmClasse2
    {
        public FrmSendSMS()
        {
            InitializeComponent();
        }
        private GsmCommMain comm;
        private delegate void SetTextCallback(string text);
        private SmsServer smsServer;
        private void FrmSendSMS_Load(object sender, EventArgs e)
        {
            cmbCOM.Items.Add("COM1");
            cmbCOM.Items.Add("COM2");
            cmbCOM.Items.Add("COM3");
            cmbCOM.Items.Add("COM4");
            cmbCOM.Items.Add("COM5");
            cmbCOM.Items.Add("COM6");
            cmbCOM.Items.Add("COM8");
            EditMode = true;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (cmbCOM.Text == "")
            {
                MessageBox.Show("Invalid Port Name");
                return;
            }
            comm = new GsmCommMain(cmbCOM.Text, 9600, 150);
            Cursor.Current = Cursors.Default;

            bool retry;
            do
            {
                retry = false;
                try
                {
                    Cursor.Current = Cursors.WaitCursor;
                    comm.Open();
                    Cursor.Current = Cursors.Default;
                    MsBox.Show("Modem Connected Sucessfully");
                }
                catch (Exception)
                {
                    Cursor.Current = Cursors.Default;
                    if (MessageBox.Show(this, "GSM Modem is not available", "Check",
                        MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                        retry = true;
                    else
                    {

                        //Close();
                        return;
                    }
                }
            }
            while (retry);
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            Operation code = new Operation();
            try
            {
                //SqlConnection con = Main.GetDBConnection();
                //DataTable consultanttable = new DataTable();
                //string sqlConsultant = @"SELECT  Don_Donor_ID,Don_Donor_Name,left(Don_Mobile_Phone,4)+ right(Don_Mobile_Phone,7) 
                //FROM  psh.dbo.Donor_Profile WHERE (Don_SMS1 IS NULL) or (Don_SMS1='notsend') and Don_Donor_ID ='CF-00001-12'";
                //SqlDataAdapter Consultantdataadapter = new SqlDataAdapter(sqlConsultant, con);
                //Consultantdataadapter.Fill(consultanttable);
                //foreach (DataRow myrow in consultanttable.Rows)
                //{
                //    txtDonorId.Text = Convert.ToString(myrow[0]);
                //    txtDonorName.Text = Convert.ToString(myrow[1]);
                //    txtNumber.Text = Convert.ToString(myrow[2]);
                //    Cursor.Current = Cursors.WaitCursor;
                //    txtMessage.Text = "Respected " + txtDonorName.Text + ", Welcome to Clapp Trust. Your donor ID is " + txtDonorId.Text + ". Our online system will send you SMS whenever your donation is received.";
                try
                {
                    SmsSubmitPdu pdu;
                    if (gridUiHorarios.Rows.Count>0)
                    {
                        foreach (DataGridViewRow item in gridUiHorarios.Rows)
                        {
                            byte dcs = (byte)DataCodingScheme.GeneralCoding.Alpha7BitDefault;
                            pdu = new SmsSubmitPdu(txtMessage.Text, Convert.ToString(item.Cells["Telefone"].Value.ToTrim()), dcs);
                            int times = 1;
                            for (int i = 0; i < times; i++)
                            {
                                comm.SendMessage(pdu);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Modem is not available");
                   // code.Execute("update psh.dbo.donor_profile set don_sms2='notsend' where don_donor_id ='" + txtDonorId.Text + "'");
                }
                //}
            }
            catch
            {
                MessageBox.Show("SMS not send");
            }
        }

        private void btnSearchAlunos_Click(object sender, EventArgs e)
        {

        }
    }
}
