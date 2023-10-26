using DMZ.BL.Classes;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmBarCodeQR : Basic.FrmClasse2
    {
        private DataTable dt;

        public FrmBarCodeQR()
        {
            InitializeComponent();
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            gridUiAlunos.Update();
            var dr = MsBox.Show("Deseja que o Software gere automaticamente o codigo de barras e QR de alunos seleçionados?", DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            Helper.DoProgressProcess(dt, RecebeDados);
        }
        private void RecebeDados(DataRow r, bool fim)
        {
            var barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            var barcodeImage = barcode.Draw(r["no"].ToString().Trim(), 50);
            var barcodeImageArray = Util.GetImagem(barcodeImage, true);
            var qrcode = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            var qrcodeImage = qrcode.Draw(r["no"].ToString().Trim(), 50);
            var qrcodeImageArray = Util.GetImagem(qrcodeImage, true);
            r["Codigobarra"] = barcodeImageArray;
            r["CodigoQr"] = qrcodeImageArray;

            if (fim)
            {
                if (dt.HasRows())
                {
                    SQL.Save(dt, "Cl", true, "", "");
                }
                MsBox.Show("Processo terminado com sucesso");
            }
        }

        private void FrmBarCodeQR_Load(object sender, EventArgs e)
        {
            dt = SQL.GetGen2DT(@"select * from cl where aluno =1");
            gridUiAlunos.SetDataSource(dt);
        }
    }
}
