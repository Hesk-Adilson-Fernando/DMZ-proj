using DMZ.BL.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMZ.Batch.Classes;

namespace DMZ.Batch
{
    public partial class DataProgressbar : Form
    {
        public DataProgressbar()
        {
            InitializeComponent();
        }
        public event Action<DataRow, bool> DadosEnviados;
        DateTime starttimme;
        private double secondsremaining;
        private Task ProgressData(DataTable list, IProgress<ProgressReport> progress)
        {
            var counter = list.Rows.Count;
            var progressReport = new ProgressReport();
            return Task.Run(() =>
            {
                for (var i = 1; i <= counter; i++)
                {
                    if (list.Rows[0] == null) continue;
                    if (DadosEnviados != null)
                    {
                        //DadosEnviados.Invoke(list.Rows[i - 1], false);
                        if (i == counter)
                        {
                            DadosEnviados.Invoke(list.Rows[i - 1], true);
                        }
                        else
                        {
                            DadosEnviados.Invoke(list.Rows[i - 1], false);
                        }
                    }
                    var valor = Convert.ToInt32(i * 100 / counter);
                    progressReport.ProcessComplete = valor;
                    progressReport.Total = counter;
                    progressReport.Actual = i;
                    var timespent = DateTime.UtcNow - starttimme;
                    secondsremaining = timespent.TotalSeconds / valor * (progressBar1.Maximum - progressBar1.Value);
                    if (!string.IsNullOrEmpty(Campo))
                    {
                        progressReport.Descricao = " - " + list.Rows[i - 1][Campo];
                    }
                    else
                    {
                        progressReport.Descricao = "";
                    }
                    progressReport.Processo = !Processo.IsNullOrEmpty() ? $"{Processo}, " : "";
                    progress.Report(progressReport);
                    Thread.Sleep(10);
                }
            });
        }

        public string Processo { get; set; }

        public string Campo { get; set; }

        private void DataProgressbar_Load(object sender, EventArgs e)
        {
            Text = Pbl.Info;
            Executar();
        }
        public DataTable Lista;
        private async void Executar()
        {
            lblStatus.Text = @"Inicializando...";
            starttimme = DateTime.UtcNow;
            var p = new Progress<ProgressReport>();
            p.ProgressChanged += (o, report) =>
            {
                lblStatus.Text = $@"{report.ProcessComplete}% Processado";
                label2.Text = $@"{Processo} Registo nº: {report.Actual} de {report.Total}{report.Descricao}";
                labelTempo.Text = "Tempo: " + (int)secondsremaining + " segundos";
                progressBar1.Value = report.ProcessComplete;
                progressBar1.Update();
            };
            await ProgressData(Lista, p);
            lblStatus.Text = "Processo Concluido!";
            Close();
        }
    }
}
