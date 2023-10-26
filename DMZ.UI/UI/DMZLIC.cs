using System;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class DMZLIC : Basic.FrmClasse2
    {


        public DMZLIC()
        {
            InitializeComponent();
        }

        public string FilePath { get; set; }
        private void DMZLIC_Load(object sender, EventArgs e)
        {
            FilePath = Helper.GetFile();
            var xmlFile = XmlReader.Create(FilePath, new XmlReaderSettings());
            var dataSet = new DataSet();
            dataSet.ReadXml(xmlFile);
            var licdt = dataSet.Tables[0];
            foreach (var row in licdt.AsEnumerable())
            {
                if (row == null) continue;
                Ges.Checked = Criptografia.Decrypt(row["Ges"].ToString()).ToBool();
                tec.Checked = Criptografia.Decrypt(row["Tec"].ToString()).ToBool();
                cbRHS.Checked = Criptografia.Decrypt(row["RHS"].ToString()).ToBool();
                Fullic.Checked = Criptografia.Decrypt(row["Fullic"].ToString()).ToBool();
                ct.Checked = Criptografia.Decrypt(row["ct"].ToString()).ToBool();
                POSR.Checked = Criptografia.Decrypt(row["POSR"].ToString()).ToBool();
                POSSUP.Checked = Criptografia.Decrypt(row["POSM"].ToString()).ToBool();
                LimitDemo.Text = Criptografia.Decrypt(row["LimitDemo"].ToString());             
                LimitTec.Text = Criptografia.Decrypt(row["LimitTec"].ToString());
                cbAcademia.Checked = Criptografia.Decrypt(row["AC"].ToString()).ToBool();
                Rhdata.Text = Criptografia.Decrypt(row["Rhdata"].ToString());
                Rhval.Text = Criptografia.Decrypt(row["Rhval"].ToString());
                CtData.Text = Criptografia.Decrypt(row["CtData"].ToString());
                Ctval.Text = Criptografia.Decrypt(row["Ctval"].ToString());
                DemoVal.Text = Criptografia.Decrypt(row["DemoVal"].ToString());

                Tecdata.Text = Criptografia.Decrypt(row["Tecdata"].ToString());
                Demodata.Text = Criptografia.Decrypt(row["Demodata"].ToString());

                Tecval.Text = Criptografia.Decrypt(row["Tecval"].ToString());
                Fulllicval.Text = Criptografia.Decrypt(row["Fulllicval"].ToString());
                Fulllicdata.Text = Criptografia.Decrypt(row["Fulllicdata"].ToString());
                UGes.Text = Criptografia.Decrypt(row["UGes"].ToString());
                UCt.Text = Criptografia.Decrypt(row["UCt"].ToString());
                URh.Text = Criptografia.Decrypt(row["URh"].ToString());

                cbFT.Checked = Criptografia.Decrypt(row["FT"].ToString()).ToBool();
                cbPJ.Checked = Criptografia.Decrypt(row["PJ"].ToString()).ToBool();
                cbPRC.Checked = Criptografia.Decrypt(row["PRC"].ToString()).ToBool();
                Nuit.Text = Criptografia.Decrypt(row["NUIT"].ToString());
                cbIMB.Checked = Criptografia.Decrypt(row["IMB"].ToString()).ToBool();
                Empresa.Text = Criptografia.Decrypt(row["Empresa"].ToString());
                Demo.Checked = Criptografia.Decrypt(row["Demo"].ToString()).ToBool();
                Anual.Checked = Criptografia.Decrypt(row["Anual"].ToString()).ToBool();
            } 
            xmlFile.Dispose();
        }

        private bool SaveData()
        {
            var xmlFile = new XmlDocument();
            xmlFile.Load(FilePath);
           if (xmlFile.DocumentElement == null) return false;
            var nodes = xmlFile.DocumentElement.ChildNodes;
            foreach (XmlNode xnode in nodes)
            {
                if (xnode == null) continue;
                switch (xnode.Name)
                {
                    case "Ges":
                        xnode.InnerText = Criptografia.Encrypt(Ges.Checked.ToString());
                        break;
                    case "Tec":
                        xnode.InnerText = Criptografia.Encrypt(tec.Checked.ToString());
                        break;
                    case "Fullic":
                        xnode.InnerText = Criptografia.Encrypt(Fullic.Checked.ToString());
                        break;
                    case "CT":
                        xnode.InnerText = Criptografia.Encrypt(ct.Checked.ToString());
                        break;
                    case "POSR":
                        xnode.InnerText = Criptografia.Encrypt(POSR.Checked.ToString());
                        break;
                    case "LimitDemo":
                        xnode.InnerText = Criptografia.Encrypt(LimitDemo.Text);
                        break;
                    case "Rhval":
                        xnode.InnerText = Criptografia.Encrypt(Rhval.Text);
                        break;
                   case "Rhdata":
                        xnode.InnerText = Criptografia.Encrypt(Rhdata.Text);
                        break;
                    case "Tecdata":
                        xnode.InnerText = Criptografia.Encrypt(Tecdata.Text);
                        break;
                     case "LimitTec":
                        xnode.InnerText = Criptografia.Encrypt(LimitTec.Text.ToString().Trim());
                        break;
                    case "AC":
                        xnode.InnerText = Criptografia.Encrypt(cbAcademia.Checked.ToString());
                        break;
                    case "POSM":
                        xnode.InnerText = Criptografia.Encrypt(POSSUP.Checked.ToString());
                        break;
                    case "PRC":
                        xnode.InnerText = Criptografia.Encrypt(cbPRC.Checked.ToString());
                        break;
                    case "PJ":
                        xnode.InnerText = Criptografia.Encrypt(cbPJ.Checked.ToString());
                        break;
                    case "FT":
                        xnode.InnerText = Criptografia.Encrypt(cbFT.Checked.ToString());
                        break;//NUIT
                    case "NUIT":
                        xnode.InnerText = Criptografia.Encrypt(Nuit.Text);
                        break;//
                    case "RHS":
                        xnode.InnerText = Criptografia.Encrypt(cbRHS.Checked.ToString());
                        break;
                    case "IMB":
                        xnode.InnerText = Criptografia.Encrypt(cbIMB.Checked.ToString());
                        break;
                    case "Demo":
                        xnode.InnerText = Criptografia.Encrypt(Demo.Checked.ToString());
                        break;
                    case "Empresa":
                        xnode.InnerText = Criptografia.Encrypt(Empresa.Text.Trim());
                        break;
                    case "UCt":
                        xnode.InnerText = Criptografia.Encrypt(UCt.Text.Trim());
                        break;
                    case "UGes":
                        xnode.InnerText = Criptografia.Encrypt(UGes.Text.Trim());
                        break;
                    case "URh":
                        xnode.InnerText = Criptografia.Encrypt(URh.Text.Trim());
                        break;
                        //-----------------------
                    case "Fulllicval":
                        xnode.InnerText = Criptografia.Encrypt(Fulllicval.Text.Trim());
                        break;
                    case "Anual":
                        xnode.InnerText = Criptografia.Encrypt(Anual.Checked.ToString().Trim());
                        break;
                    case "Tecval":
                        xnode.InnerText = Criptografia.Encrypt(Tecval.Text.Trim());
                        break;
                    case "DemoVal":
                        xnode.InnerText = Criptografia.Encrypt(DemoVal.Text.Trim());
                        break;
                    case "Demodata":
                        xnode.InnerText = Criptografia.Encrypt(Demodata.Text.Trim());
                        break;
                    case "CtData":
                        xnode.InnerText = Criptografia.Encrypt(CtData.Text.Trim());
                        break;
                    case "Ctval":
                        xnode.InnerText = Criptografia.Encrypt(Ctval.Text.Trim());
                        break;
                    case "Fulllicdata":
                        xnode.InnerText = Criptografia.Encrypt(Fulllicdata.Text.Trim());
                        break;
                }
            }
            xmlFile.Save(FilePath);
            return true;
        }


        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void btnValorPanelShow_Click(object sender, EventArgs e)
        {
            var dr = MsBox.Show("Deseja Gravar as alterações feitas ",DResult.YesNo);
            if (dr.DialogResult== DialogResult.Yes)
            {
                if (Demo.Checked && tec.Checked && Fullic.Checked)
                {
                    MsBox.Show(Messagem.ParteInicial()+"Deve indicar um tipo de licenca apenas!");
                }
                else if(!Demo.Checked && !tec.Checked && !Fullic.Checked)
                {
                    MsBox.Show(Messagem.ParteInicial()+"Deve indicar a licença a processar!");
                }
                else
                {
                    if (SaveData())
                    {
                        MsBox.Show(Messagem.ParteInicial()+"Dados Gravados com suscesso!");
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial()+"Erro de gravação de ficheiros!");
                    }                    
                }
            }
        }
    }
}
