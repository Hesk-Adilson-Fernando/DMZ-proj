using System;
using System.Data;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI.Contabil
{
    public partial class Pcdiario : Basic.FrmClasse2
    {
        private DataTable _dt;

        public Pcdiario()
        {
            InitializeComponent();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            var qry = string.Empty;
            if (rbPgc.cb1.Checked)
            {
                qry = $"select conta as codigo,descricao,ordem=2 from pgc where ano={nContOri.Value} order by codigo";
            }
            if (rbDiario.cb1.Checked)
            {
                qry = $"select convert(varchar(3),dino) as codigo,descricao,ordem=1 from diario where diano={nContOri.Value}";
            }
            if (rbPgcDiar.cb1.Checked)
            {
                qry = $@"select * from (select convert(varchar(3),dino) as codigo,descricao,ordem=1 from diario where diano={nContOri.Value} 
                              union all
                         select conta as codigo,descricao,ordem = 2 from pgc where ano={nContOri.Value})tmp1 order by ordem, codigo";
            }
            _dt = SQL.GetGenDT(qry);

            gridUi1.DataSource = null;
            gridUi1.AutoGenerateColumns = false;
            gridUi1.DataSource = _dt;
        }

        private async void btnMudar_Click(object sender, EventArgs e)
        {
            var qry = string.Empty;
            if (rbPgc.cb1.Checked)
            {
                qry = $"select conta as codigo,descricao,ordem=2 from pgc where ano={ncontDest.Value} order by codigo";
            }
            if (rbDiario.cb1.Checked)
            {
                qry = $"select convert(varchar(3),dino) as codigo,descricao,ordem=1 from diario where diano={ncontDest.Value} order by diano,Convert(int,dino)";
            }
            if (rbPgcDiar.cb1.Checked)
            {
                qry = $@"select * from (select convert(varchar(3),dino) as codigo,descricao,ordem=1 from diario where diano={ncontDest.Value} order by diano,Convert(int,dino)
                              union all
                         select conta as codigo,descricao,ordem = 2 from pgc where ano={ncontDest.Value})tmp1 order by ordem, codigo";
            }
            var  dt = SQL.GetGenDT(qry);
            if (dt.Rows.Count>0)
            {
                MsBox.Show($"Já existem movimentos lançados \r\n para o ano: {ncontDest.Value} ");
            }
            else
            {
                await ContadorAsync(_cts.Token) ;
            }
        }
        private readonly CancellationTokenSource _cts = new CancellationTokenSource();

        private decimal _cont;

        private async Task<int> ContadorAsync(CancellationToken c) => await Task.Run(() =>
        {
            decimal i = 1;
            _cont = 0;
            foreach (var r in _dt.AsEnumerable())
            {
                if (r == null) continue;
                if (r.RowState == DataRowState.Deleted) continue;
                _cont++;
            }
            foreach (var r in _dt.AsEnumerable())
            {
                if (c.IsCancellationRequested)
                {
                    break;
                }
                if (r == null) continue;
                if (r.RowState == DataRowState.Deleted) continue;
                if (r["ordem"].ToDecimal() == 1)
                {
                    var d = SQL.GetRowToEnt<Diario>($"dino ={r["codigo"].ToString().Trim()}");
                    if (d != null)
                    {
                        d.Diano = ncontDest.Value;
                        d.Qmc = Pbl.Usr.Login;
                        d.Qma = Pbl.Usr.Login;
                        d.Qmcdathora = Pbl.SqlDate;
                        d.Qmadathora = Pbl.SqlDate;
                        d.Diariostamp = Pbl.Stamp();
                        EF.Save(d);
                    }
                }
                if (r["ordem"].ToDecimal() == 2) 
                {
                    var d = SQL.GetRowToEnt<Pgc>($"ltrim(rtrim(conta)) ='{r["codigo"].ToString().Trim()}'");
                    if (d == null) continue;
                    d.Ano = ncontDest.Value;
                    d.Pgcstamp = Pbl.Stamp();
                    EF.Save(d);
                }
                if (lblMensagem.InvokeRequired)
                {
                    lblMensagem.Invoke((MethodInvoker)delegate
                    {
                        var perc = progressBar1.Maximum / _cont;
                        lblMensagem.Text = decimal.Round(perc * i, 2) + @"%";
                        progressBar1.Value = Convert.ToInt32(perc * i);
                        if (progressBar1.Value >= 100)
                        {
                            _cts.Cancel();
                            lblMensagem.Text = decimal.Round(perc * i,0) + @"% Concluido ";
                        }

                    });
                }
                Thread.Sleep(100);
                i++;
            }
            return 0;
        }, c);

        private void btnDell_Click(object sender, EventArgs e)
        {
            if (gridUi1.CurrentRow == null) return;
            var dr =MsBox.Show($"Deseja eliminar: {gridUi1.CurrentRow.Cells[1].Value.ToString().Trim()}",
                DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            gridUi1.Rows.Remove(gridUi1.CurrentRow);
            gridUi1.Update();
        }

        private void Pcdiario_Load(object sender, EventArgs e)
        {
            nContOri.Value = Pbl.AnoContabil();
            ncontDest.Value = Pbl.AnoContabil()+1;
            lblMensagem.Text = "";
        }

        private void rbDiario_CheckedChangeds()
        {
            rbPgc.Update(false);
            rbPgcDiar.Update(false);
        }

        private void rbPgc_CheckedChangeds()
        {
            rbDiario.Update(false);
            rbPgcDiar.Update(false);
        }

        private void rbPgcDiar_CheckedChangeds()
        {
            rbDiario.Update(false);
            rbPgc.Update(false);
        }
    }
}
