using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.UI.Contabil;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DMZ.UI.UI.PJ
{
    public partial class FrmPj : FrmClasse
    {


        DateTimePicker _dtpeEscopo;
        public DateTimePicker DtpjEstProj;
        private Pj _pj;


        public FrmPj()
        {
            InitializeComponent();
        }
        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            dmzContextMenuStrip1.ShowMenuStrip(btnMenuLateral);
        }
        public override void DefaultValues()
        {
            _pj = DoAddline<Pj>();
            _pj.Numdoc = Tmptdocpj.Numdoc.ToString();
            _pj.Nomedoc = Tmptdocpj.Descricao;
            _pj.Sigla=Tmptdocpj.Sigla;
            base.DefaultValues();
            status.SetStatusValue();
            tbCcusto.SetCCustoValue();
            Origem = "PJ";

        }
        public override bool BeforeSave()
        {
            if (string.IsNullOrEmpty(tbDescricao.tb1.Text))
            {
                MsBox.Show("A descrição do projecto é de preenchimento obrigatório!");
                return false;
            }
            if (dtDataFinal.dt1.Value < dtDataInicio.dt1.Value)
            {
                MsBox.Show("A data final não pode ser menor que a data inicial.");
                btnAdministracao.PerformClick();
                return false;
            }
            if (string.IsNullOrEmpty(tbCliente.tb1.Text))
            {
                MsBox.Show("Defina o nome do cliente primeiro".ToUpper());
                return false;
            }
            if (string.IsNullOrEmpty(tbMorada.tb1.Text))
            {
                MsBox.Show("Defina o endereço primeiro!");
                return false;
            }
            if (tbPo.IsUnique)
            {
                if (!string.IsNullOrEmpty(tbPo.tb1.Text)) return base.BeforeSave();
                if (SQL.CheckExist($"select po from pj where po='{tbPo.tb1.Text.Trim()}' and pjstamp='{CLocalStamp}'"))
                {
                    MsBox.Show("Estimado(a), Já exite projecto com mesmo número de PO, Verifique!");
                    return false;
                }
            }
            //for (var i = 0; i < gridUIFt1.Rows.Count; i++)
            //{
            //    if (!string.IsNullOrEmpty(gridUIFt1.Rows[i].Cells["Sequence"].Value.ToString()) )
            //    {
            //        if (gridUIFt1.Rows[i].Cells["Sequence"].Value.ToString().Contains(","))
            //        {
            //            gridUIFt1.Rows[i].Cells["Sequence"].Value = gridUIFt1.Rows[i].Cells["Sequence"].Value.ToString().Replace(",", ".");
            //        }
            //    }

            //    if (string.IsNullOrEmpty(gridUIFt1.Rows[i].Cells["descricao"].Value.ToString())
            //        || string.IsNullOrEmpty(gridUIFt1.Rows[i].Cells["Ref"].Value.ToString()) ||
            //        string.IsNullOrEmpty(gridUIFt1.Rows[i].Cells["Sequence"].Value.ToString()) ||
            //        string.IsNullOrEmpty(gridUIFt1.Rows[i].Cells["classificador"].Value.ToString()))
            //    {
            //        gridUIFt1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Red;
            //        gridUIFt1.Rows[i].Selected = true;
            //        MsBox.Show("Nesta Linha não foi definida a\n\n descrição\n\n ou a referência\n\n ou a sequência ou\n\n o Tipo \n\n por favor defina agora para salvar!");
            //        btnEscopo.PerformClick();
            //        return false;
            //    }
            //    var str = gridUIFt1.Rows[i].Cells["Sequence"].Value.ToString();
            //    if (Regex.IsMatch(str, ".*?[a-zA-Z].*?"))
            //    {
            //        gridUIFt1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Red;
            //        gridUIFt1.Rows[i].Selected = true;
            //        MsBox.Show("No campo de sequência só é admitido o uso de números separados de .,\n\n Por favor verifique!");
            //        btnEscopo.PerformClick();
            //        return false;
            //    }
            //    gridUIFt1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Empty;
            //}
            return base.BeforeSave();
        }

        public override void Save()
        {
            FillEntity(_pj);
            EF.Save(_pj);
        }

        private void dtDataInicio_DateChangValues()
        {
            try
            {
                if (dtDataFinal.dt1.Value < dtDataInicio.dt1.Value)
                {
                    // MsBox.Show("A data final não pode ser menor que a data inicial.");
                }
                else
                {
                    CalculateDays();
                }

            }
            catch (Exception ex)
            {
                //
            }
        }

        private void CalculateDays()
        {
            tbDias.tb1.Text = string.Empty;
            var dias = dtDataFinal.dt1.Value - dtDataInicio.dt1.Value;
            tbDias.tb1.Text = dias.TotalDays.ToString("N1");
        }


        private void dtpeEscopo_ValueChanged(object sender, EventArgs e)
        {
            gridUIFt1.CurrentCell.Value = _dtpeEscopo.Text;
            _dtpeEscopo.Visible = false;
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _pj = FillControls(_pj, dt, i);
            Origem = gridUIFt1.Origem = "PJ";
            status.Enabled = !_pj.Fechado;
        }

        private void FrmPj_Load_1(object sender, EventArgs e)
        {
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Pj";
            Origem = gridUIFt1.Origem = "PJ";
            gridUIFt1.Condicao = $"pjstamp='{CLocalStamp}'";
            //gridUIFt1.OrderbyCampos = " cast('/' + replace(Sequenc, '.', '/') + '/' as hierarchyid)";
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            _dtpeEscopo = new DateTimePicker { Format = DateTimePickerFormat.Short, Visible = false, Width = 100 };
            gridUIFt1.Controls.Add(_dtpeEscopo);
            _dtpeEscopo.ValueChanged += dtpeEscopo_ValueChanged;
            gridUIFt1.CellBeginEdit += gridUIFt1_CellBeginEdit;
            gridUIFt1.CellEndEdit += gridUIFt1_CellEndEdit;
            dtDataFinal_DateChangValues();
            dtIniReal_DateChangValues();
            tbDescricao.Focus();
            tbDescricao.Select();
            Tmptdocpj = SQL.GetRowToEnt<TdocPj>("defa=1");
            var dt = SQL.GetGenDT("select Naomostradatain,Naomostradatater,Naomostraduracao,Naomostrasequencia,Ponaorepete from param");
            if (gridUIFt1 != null)
            {
                gridUIFt1.Columns["inicioe"].Visible = !dt.Rows[0]["Naomostradatain"].ToBool();
                gridUIFt1.Columns["Terminor"].Visible = !dt.Rows[0]["Naomostradatater"].ToBool();
                gridUIFt1.Columns["Duracaor"].Visible = !dt.Rows[0]["Naomostraduracao"].ToBool();
                gridUIFt1.Columns["sequence"].Visible = !dt.Rows[0]["Naomostrasequencia"].ToBool();
            }
            tbPo.IsUnique = dt.Rows[0]["Ponaorepete"].ToBool();
            SetValues(Tmptdocpj);


        }
        private List<Usracessos> lista;
        public TdocPj Tmptdocpj { get; set; }

        public override void Addline(string referenc)
        {
            #region Compras
            try
            {
                var tmpFound = SQL.GetRowToEnt<St>($"Ststamp ='{referenc.Trim()}'");// EF.GetEnt<St>(p => p.Ststamp.Trim().Equals($"{referenc.Trim()}"));
                DataRow["descricao"]=tmpFound.Descricao;
                DataRow["ref"]=tmpFound.Referenc;
                GenBl.SetLineValues(DataRow, tmpFound, _pj, false, null, false, Pbl.MoedaBase, "", "");
                GenBl.TotaisLinhas(DataRow);
                gridUIFt1.Update();
                Helper.TotaisFt(gridUIFt1.DtDS, this);
            }
            catch
            {
                MsBox.Show("Estimado(a), Algo correu mal, a linha não foi adicionada com sucesso!");
            }
            #endregion
        }
        private void dtDataFinal_DateChangValues()
        {
            try
            {
                if (dtDataFinal.dt1.Value < dtDataInicio.dt1.Value)
                {
                }
                else
                {
                    CalculateDays();
                }
            }
            catch (Exception ex)
            {
                //
            }
        }
        private void btnDi_Click(object sender, EventArgs e)
        {
            MenuDI.ShowMenuStrip(btnDi);
        }
        public void PassaDados()
        {
            using (var form = new FrmPjdi())
            {
                form.Controlacesso = false;
                form.ShowDialog(this);
            }
        }

        private void CalculateDaysInGridPeEscopo()
        {
            try
            {
                var lowername = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
                if (lowername.Equals("Inicioe".ToLower()) || lowername.Equals("Duracaor".ToLower()))
                {
                    DateTime fim;
                    if (gridUIFt1.CurrentRow != null)
                    {
                        DateTime ini;

                        #region Início diferente de null e Término null
                        if (string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["Inicioe"].Value.ToString()))
                        {
                            gridUIFt1.CurrentRow.Cells["Inicioe"].Value = DateTime.Now;
                        }
                        if (string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["Duracaor"].Value.ToString()))
                        {
                            gridUIFt1.CurrentRow.Cells["Duracaor"].Value = 0;
                        }
                        ini = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["Inicioe"].Value);
                        var today = ini;
                        var diass = gridUIFt1.CurrentRow.Cells["Duracaor"].Value.ToString().ToInt32();
                        TimeSpan duration = new TimeSpan(diass, 0, 0, 0);
                        DateTime answer = today.Add(duration);
                        gridUIFt1.CurrentRow.Cells["Terminor"].Value = answer;

                        #endregion

                    }
                }
                if (lowername.Equals("DatIniRealesco".ToLower()) || lowername.Equals("DatTerminorRealesc".ToLower()))
                {
                    if (gridUIFt1.CurrentRow != null)
                    {
                        DateTime ini;
                        DateTime fim;

                        #region Início diferente de null e Término null

                        if (lowername.Equals("DatIniRealesco".ToLower()))
                        {
                            if (!string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value.ToString())
                                && string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value
                                    .ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value.ToString())
                                && Convert.ToDecimal(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value) >= 0)
                            {
                                ini = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value);
                                var today = ini;
                                var diass = Convert.ToInt32(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value);
                                TimeSpan duration = new TimeSpan(diass, 0, 0, 0);
                                DateTime answer = today.Add(duration);
                                gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value = answer;
                            }



                            if (!string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value.ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value
                                    .ToString())
                                && string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value.ToString()))
                            {

                                ini = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value);
                                fim = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value);
                                gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value = fim.Subtract(ini).Days;
                                if (ini <= fim)
                                {

                                }
                            }


                            if (!string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value.ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value
                                    .ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value.ToString())
                                && Convert.ToDecimal(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value) >= 0)
                            {

                                ini = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value);
                                fim = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value);
                                gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value = fim.Subtract(ini).Days;
                                if (ini <= fim)
                                {

                                }
                            }

                            if (!string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value.ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value
                                    .ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value.ToString())
                                && Convert.ToDecimal(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value) < 0)
                            {
                                ini = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value);
                                fim = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value);
                                gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value = fim.Subtract(ini).Days;
                                if (ini <= fim)
                                {
                                }
                            }
                        }

                        #endregion

                        #region Término diferente de null e início null

                        if (lowername.Equals("DatTerminorRealesc".ToLower()))
                        {
                            if (string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value.ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value
                                    .ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value.ToString())
                                && Convert.ToDecimal(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value) >= 0)
                            {
                                ini = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value);
                                var today = ini;
                                var diass = Convert.ToInt32(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value);
                                TimeSpan duration = new TimeSpan(diass, 0, 0, 0);
                                DateTime answer = today.Add(-duration);
                                gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value = answer;
                            }


                            if (!string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value.ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value
                                    .ToString())
                                && string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value.ToString()))
                            {
                                ini = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value);
                                fim = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value);
                                gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value = fim.Subtract(ini).Days;
                                if (ini <= fim)
                                {
                                }
                            }


                            if (!string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value.ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value
                                    .ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value.ToString())
                                && Convert.ToDecimal(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value) >= 0)
                            {
                                ini = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value);
                                fim = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value);
                                gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value = fim.Subtract(ini).Days;
                                if (ini <= fim)
                                {
                                }
                            }



                            if (!string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value.ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value
                                    .ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value.ToString())
                                && Convert.ToDecimal(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value) < 0)
                            {
                                ini = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value);
                                fim = Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value);
                                gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value = fim.Subtract(ini).Days;
                                if (ini <= fim)
                                {
                                }
                            }
                        }

                        #endregion
                    }
                }
                if (lowername.Equals("DiasReaisesc".ToLower()))
                {

                    if (gridUIFt1.CurrentRow != null)
                    {
                        try
                        {
                            if (string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value.ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value
                                    .ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value.ToString())
                                && Convert.ToDecimal(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value) >= 0)
                            {
                                var fim =
                                    Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value);
                                var today = fim;
                                var diass = Convert.ToInt32(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value);
                                var duration = new TimeSpan(diass, 0, 0, 0);
                                var answer = today.Add(-duration);
                                gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value = answer;
                            }

                            if (!string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value.ToString())
                                && string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value
                                    .ToString())
                                && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value.ToString())
                                && Convert.ToDecimal(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value) >= 0)
                            {
                                var ini =
                                    Convert.ToDateTime(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value);
                                var today = ini;
                                var diass = Convert.ToInt32(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value);
                                var duration = new TimeSpan(diass, 0, 0, 0);
                                var answer = today.Add(duration);
                                gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value = answer;
                            }
                        }
                        catch (Exception ex)
                        {
                            //
                        }

                    }
                }
                if (lowername.Equals("Executar".ToLower()))
                {
                    if (gridUIFt1.CurrentRow == null) return;
                    try
                    {

                        if (!string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value.ToString())
                            && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value
                                .ToString())
                            && !string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value.ToString())
                            && Convert.ToDecimal(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value) >= 0)
                        {
                            var ini = Convert.ToDateTime(DateTime.Now);
                            gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value = ini.ToString("dd-MM-yyyy");
                            var diass = Convert.ToInt32(gridUIFt1.CurrentRow.Cells["DiasReaisesc"].Value);
                            var duration = new TimeSpan(diass, 0, 0, 0);
                            var today = ini;
                            var answer = today.Add(duration);
                            gridUIFt1.CurrentRow.Cells["DatTerminorRealesc"].Value =
                                answer.ToString("dd-MM-yyyy");
                        }
                    }
                    catch (Exception ex)
                    {
                        //
                    }
                }
            }
            catch (Exception ex)
            {
                // ignored
            }

        }
        private void CalculaSalario()
        {
            try
            {
                if (gridUIFt1.CurrentRow == null) return;
                var salbase = Convert.ToDecimal(gridUIFt1.CurrentRow.Cells["Preco"].Value);
                var dias = Convert.ToDecimal(gridUIFt1.CurrentRow.Cells["Duracaor"].Value);
                decimal valortotal;
                //gridUIFt1.CurrentRow.Cells["Total"].Value =
                //    Convert.ToDecimal((salbase / 30 * dias).ToString("N2"));
            }
            catch (Exception ex)
            {
                // ignored
            }
        }

        private bool ExisteVerificarPredecedoras()
        {
            var contagem = 0;
            if (gridUIFt1.CurrentRow == null) return true;
            var gr = gridUIFt1.CurrentRow.Cells["Predecedorar"].Value.ToString();
            var subs = gr.Split(',');
            var cond = string.Empty;

            for (var i = 0; i < subs.Length; i++)
            {
                if (i == 0)
                {
                    cond += $"'{subs[i]}'";
                }
                else
                {
                    cond += $",'{subs[i]}'";
                }
            }

            cond = $"in ({cond})";
            if (!cond.Equals("in ('')"))
            {
                var qry = SQL.GetGen2DT($"select Encerrado,no,Sequenc from pjesc where Sequenc {cond} and Encerrado=0");
                if (qry?.Rows.Count <= 0) return false;
                var con = string.Empty;
                for (var i = 0; i < qry.Rows.Count; i++)
                {
                    if (i == 0)
                    {
                        con += $"'{qry.Rows[i]["Sequenc"]}'";
                    }
                    else
                    {
                        con += $",'{qry.Rows[i]["Sequenc"]}'";
                    }
                }

                if (gridUIFt1.CurrentCell.OwningColumn.Name.ToLower().Equals("Encerrar".ToLower()))
                {
                    gridUIFt1.CurrentRow.Cells["Encerrar"].Value = "Aberto".ToUpper();
                    gridUIFt1.CurrentRow.Cells["Encerradoesc"].Value = false;
                    MsBox.Show("Deve concluir/encerrar as seguintes actividades:\n\n".ToUpper() + con);
                    return true;
                }

                if (gridUIFt1.CurrentCell.OwningColumn.Name.ToLower().Equals("Executar".ToLower()))
                {
                    gridUIFt1.CurrentRow.Cells["Executado"].Value = false;
                    MsBox.Show("impossíver executar esta actividade antes\n\n de concluir a(s) sua(s) predecedora(s):\n\n".ToUpper() + con);
                    return true;
                }
            }
            else
            {
                if (gridUIFt1.CurrentCell.OwningColumn.Name.ToLower().Equals("Encerrar".ToLower()))
                {
                    gridUIFt1.CurrentRow.Cells["Encerrar"].Value = "Encerrado".ToUpper();
                    gridUIFt1.CurrentRow.Cells["Encerradoesc"].Value = true;
                }

                return false;
            }

            return false;
        }
        private void btnFact_Click(object sender, EventArgs e)
        {
            MenuFact.ShowMenuStrip(btnFact);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            MenuCompra.ShowMenuStrip(btnCompras);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            MenuReceber.ShowMenuStrip(btnRCL);
        }
        private void button5_Click(object sender, EventArgs e)
        {
            MenuPgf.ShowMenuStrip(btnPagamentos);
        }
        private void btnAdministracao_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageAdministracao);
        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageClinte);
        }


        private void btnEscopo_Click(object sender, EventArgs e)
        {

            tabControl1.SelectTab(tabPageEscopo);
        }

        private void btnObjectivos_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageObjectivos);
        }

        private void btnComunicacao_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageComunicacao);
        }
        private void ucProvincia_RefreshControls()
        {
            ucDistrito.Condicao = $" prov.Descricao='{ucProvincia.tb1.Text.Trim()}'";
            ucDistrito.tb1.Text = "";
        }
        private void btnFacturacl_Click(object sender, EventArgs e)
        {
            var retorno = IsAllValido("tdoc");
            if (!retorno.valido) return;
            if (tbPo.tb1.Text!=@"PENDENTE")
            {
                lista = retorno.lista;
                var dtst = gridUIFt1.DataSource as DataTable;
                if (dtst.HasRows())
                {
                    var campos = new[]
                    {
                        "ref", "Descricao", "quant", "preco", "Pjescstamp", "Txiva", "Tabiva", "Perdesc",
                        "Descontol", "Ivainc", "Factura"
                    };
                    if (dtst.HasRows("Factura"))
                    {
                        var produtos = dtst.DefaultView.ToTable(true, campos).HasRowsCopyToDataTable("Factura");
                        var dc = new DataColumn { DataType = typeof(bool), ColumnName = "ok" };
                        produtos.Columns.Add(dc);
                        var dc2 = new DataColumn { DataType = typeof(bool), ColumnName = "facturado" };
                        produtos.Columns.Add(dc2);
                        foreach (var r in produtos.AsEnumerable())
                        {
                            r["ok"] = false;
                            r["facturado"] = SQL.CheckExist($"select top 1 ref from factl where oristampl='{r["Pjescstamp"].ToString().Trim()}'");
                        }
                        if (produtos.HasRows("facturado", false))
                        {
                            produtos = produtos.HasRowsCopyToDataTable("facturado", false);
                            var f = new FrmFt
                            {
                                ListaUsracessos = lista,
                                Usracessos = lista.FirstOrDefault(),
                                Pjstamp = CLocalStamp,
                                _cliente = SQL.GetRowToEnt<Cl>($"No ='{tbCliente.Text2.Trim()}'"), //EF.GetEnt<Cl>(x => x.No.Equals(tbCliente.Text2))
                            };
                            f.ShowForm(this);
                            f.CallBrowdoc();
                            f.btnNovo.PerformClick();
                            f.Tdoccondicao = "sigla='FT'";
                            f.Cliente.tb1.Text = tbCliente.tb1.Text;
                            f.tbCcusto.tb1.Text = tbCcusto.tb1.Text;
                            f.tbPj.tb1.Text = tbDescricao.tb1.Text;
                            f.tbPj.Text3 = CLocalStamp;
                            f.Cliente.button1.Enabled = false;
                            f.Cliente.Text2 = tbCliente.Text2;
                            f.tbPj.button1.Enabled = false;
                            f.ucMoeda.tb1.Text=ucMoeda.tb1.Text;
                            f.tbPj.Text2 =tbReferenc.tb1.Text;
                            f.Produtos(produtos);
                            f.dtVencimento.dt1.Value = f._cliente.Vencimento>0 ? Pbl.GetDate((int)f._cliente.Vencimento) : Pbl.GetDate((int)f.TmpTdoc.Dias);
                            f.SendRefresh = ReceiveRefresh;
                        }
                        else
                        {
                            MsBox.Show($"{Messagem.ParteInicial()}Não tem artigos para facturar!");
                        }
                    }
                    else
                    {
                        MsBox.Show($"{Messagem.ParteInicial()}Não tem artigos para facturar! \r\nDeve activar os artigos que pretende na coluna factura do escopo!");
                    }
                }
                else
                {
                    MsBox.Show($"{Messagem.ParteInicial()}Não é possivel facturar, a tabela do escopo esta vazia!");
                }
            }
            else
            {
                MsBox.Show($"{Messagem.ParteInicial()} Deve Indicar o Nº de PO,\r\nNão pode ser pendente!");
            }
        }

        private (bool valido, List<Usracessos> lista) IsAllValido(string tipodoc)
        {

            (bool valido, List<Usracessos> lista) ret = (false, null);
            if (!_pj.Fechado)
            {
                if (!Inserindo)
                {
                    lista = Pbl.Usracessos.Where(x => x.Origem.ToLower().Equals(tipodoc.ToLower())).ToList();
                    if (lista?.Count > 0)
                    {
                        if (!string.IsNullOrEmpty(tbCliente.Text2))
                        {
                            var lista2 = lista.Where(linha => linha.Ver).ToList();
                            if (lista2.Count > 0)
                            {
                                ret = (true, lista2);
                            }
                            else
                            {
                                MsBox.Show(
                                    $"{Messagem.ParteInicial()}Não tem acesso a factura . contacte administrator!");
                            }
                        }
                        else
                        {
                            MsBox.Show(
                                $"{Messagem.ParteInicial()}O(A) {label1.Text} não tem cliente definido. \r\nNão é possivel emitir o documento pretendido! ");
                        }
                    }
                    else
                    {
                        MsBox.Show(
                            $"{Messagem.ParteInicial()}Desculpa não tem acessos definidos para {Pbl.Usr.Nome}. contacte administrator!");
                    }
                }
                else
                {
                    MsBox.Show(
                        $"{Messagem.ParteInicial()}O(A) {label1.Text} está em criação. \r\nNão é possivel emitir o documento pretendido!");
                }
            }
            else
            {
                MsBox.Show(
                    $"{Messagem.ParteInicial()}O(A) {label1.Text} está fechado. \r\nNão é possivel emitir o documento pretendido!");
            }
            return ret;
        }

        private void btnGastoI_Click(object sender, EventArgs e)
        {
            var retorno = IsAllValido("tdi");
            if (!retorno.valido) return;
            lista = retorno.lista;
            var f = new FrmPjdi
            {
                tbProjecto =
                {
                    Text2 = tbReferenc.tb1.Text,
                    Text3 = CLocalStamp,
                    button1 = {Enabled = false}
                },
                Usracessos = lista.First()
            };
            f.ShowForm(this);
            f.CallBrowdoc();
            f.btnNovo.PerformClick();
            f.panelFolhaObra.Visible=true;
            f.tbEntidade.tb1.Text=tbCliente.tb1.Text;
            f.tbEntidade.Text2=tbCliente.Text2;
            f.tbProjecto.tb1.Text = tbDescricao.tb1.Text;
            f.SendRefresh = ReceiveRefresh;
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            var retorno = IsAllValido("tdocf");
            if (!retorno.valido) return;
            lista = retorno.lista;
            var f = new FrmCp
            {
                ListaUsracessos = lista,
                Usracessos = lista.First(),
                Pjstamp = CLocalStamp,
            };
            f.ShowForm(this);
            f.CallBrowdoc();
            f.btnNovo.PerformClick();
            f.Tdocfcondicao = "sigla='FTF'";
            f.tbPj.tb1.Text = tbDescricao.tb1.Text;
            f.tbCcusto.tb1.Text = tbCcusto.tb1.Text;
            f.tbPj.tb1.Text = tbDescricao.tb1.Text;
            f.tbPj.Text3 = CLocalStamp;
            f.tbPj.Text2 = tbReferenc.tb1.Text;
            f.tbPj.button1.Enabled = false;
            f.SendRefresh = ReceiveRefresh;
        }

        public void ReceiveRefresh(bool origem = false)
        {
            btnRefresh.PerformClick();
            if (origem)
            {
                var dtst = gridUIFt1.DataSource as DataTable;
                if (dtst != null && dtst.AsEnumerable().Any(x => x.Field<bool>("Factura").Equals(true)))
                {
                    var produtos = dtst.AsEnumerable().Where(x => x.Field<bool>("Factura").Equals(true)).CopyToDataTable();
                    var dc2 = new DataColumn { DataType = typeof(bool), ColumnName = "facturado" };
                    produtos.Columns.Add(dc2);
                    foreach (var r in produtos.AsEnumerable())
                    {
                        r["facturado"] = SQL.CheckExist($"select top 1 ref from factl where oristampl='{r["Pjescstamp"].ToString().Trim()}'");
                    }
                    if (!produtos.AsEnumerable().Any(x => x.Field<bool>("facturado").Equals(false)))
                    {
                        _pj.Fechado = true;
                        _pj.Status = "Fechado";
                        SQL.SqlCmd($"update pj set Fechado=1, Status = 'Fechado' where pjstamp ='{CLocalStamp}'");
                        GravaAudit("Fechado");
                        status.Enabled = false;
                    }
                }
            }
        }
        private void btnRecebimento_Click(object sender, EventArgs e)
        {
            var retorno = IsAllValido("trcl");
            if (!retorno.valido) return;
            lista = retorno.lista;
            var f = new FrmRcl
            {
                ListaUsracessos = lista,
                Usracessos = lista.FirstOrDefault(),
                _cl = SQL.GetRowToEnt<Cl>($"No ='{tbCliente.Text2.Trim()}'")//EF.GetEnt<Cl>(x => x.No.Equals(tbCliente.Text2))
            };
            f.ShowForm(this);
            f.CallBrowdoc();
            f.btnNovo.PerformClick();
            f.Trclcondicao = "sigla='RC'";
            f.Cliente.tb1.Text = tbCliente.tb1.Text;
            f.tbPj.tb1.Text = tbDescricao.tb1.Text;
            f.tbCcusto.tb1.Text = tbCcusto.tb1.Text;
            f.tbPj.tb1.Text = tbDescricao.tb1.Text;
            f.tbPj.Text3 = CLocalStamp;
            f.tbPj.Text2 = tbReferenc.tb1.Text;
            f.Cliente.button1.Enabled = false;
            f.Cliente.Text2 = tbCliente.Text2;
            f.tbPj.button1.Enabled = false;
            f.SendRefresh = ReceiveRefresh;
        }
        private void btnRecebidos_Click(object sender, EventArgs e)
        {
            CallFormLista("trcl", "RCL", @"Todos recebimentos emitidos".ToUpper());
        }
        private void facturasEmitidas_Click(object sender, EventArgs e)
        {
            CallFormLista("tdoc", "fact", @"Todas facturas emitidas".ToUpper());
        }

        private void CallFormLista(string tdoc, string tabela, string caption)
        {
            lista = Pbl.Usracessos.Where(x => x.Origem.ToLower().Equals($"{tdoc.Trim()}")).ToList();
            if (lista.Count <= 0) return;
            var f = new FrmDetalhes
            {
                PjStamp = CLocalStamp,
                Tabela = tabela,
                label1 = { Text = caption.ToUpper() },
                ListaUsracessos = lista
            };
            f.ShowForm(this);
        }

        private void btnTodasComprasemitidas_Click(object sender, EventArgs e)
        {
            CallFormLista("tdocf", "Facc", @"Todas compras emitidas".ToUpper());
        }
        private void btnPagarr_Click(object sender, EventArgs e)
        {
            var retorno = IsAllValido("trcl");
            if (!retorno.valido) return;
            lista = retorno.lista;
            var f = new FrmPgf
            {
                ListaUsracessos = lista,
                Usracessos = lista.FirstOrDefault(),
                Fnc = SQL.GetRowToEnt<Fnc>($"No ='{tbCliente.Text2.Trim()}'")//EF.GetEnt<Fnc>(x => x.No.Equals(tbCliente.Text2))
            };
            f.ShowForm(this);
            f.CallBrowdoc();
            f.btnNovo.PerformClick();
            f.Trclcondicao = "sigla='RC'";
            f.tbPj.tb1.Text = tbDescricao.tb1.Text;
            f.tbCcusto.tb1.Text = tbCcusto.tb1.Text;
            f.tbPj.tb1.Text = tbDescricao.tb1.Text;
            f.tbPj.Text3 = CLocalStamp;
            f.tbPj.Text2 = tbReferenc.tb1.Text;
            f.tbPj.button1.Enabled = false;
            f.SendRefresh = ReceiveRefresh;
        }
        private void btnDIEmitidos_Click(object sender, EventArgs e)
        {
            CallFormLista("tdi", "di", @"Todos os documentos internos emitidos".ToUpper());
        }

        private void btnpgfEmitidos_Click(object sender, EventArgs e)
        {
            CallFormLista("tpgf", "Pgf", @"Todos os pagamentos emitidos".ToUpper());
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            MenuRel.ShowMenuStrip(btnPrint);
        }

        #region COMPRAS
        //public TdocPj TmpTdocf;
        public DataTable DtArm { get; set; }
        public DataRow DataRow { get; set; }
        public bool LRunStk { get; set; }
        public Pjesc Facc;
        public DataTable DtIva { get; set; }
        public DataTable DtSt { get; private set; }

        public void BindTdoc(DataRow tdoc, bool origem = false)
        {
            if (tdoc == null) return;
            Tmptdocpj = tdoc.DrToEntity<TdocPj>();
            SetValues(Tmptdocpj);
        }
        private void SetValues(TdocPj tmptdocpj)
        {
            if (tmptdocpj !=null)
            {
                label1.Text = tmptdocpj.Descricao;

            }
        }
        public void CallBrowdoc()
        {
            var bw = new Browdoc
            {
                Condicao = "",
                Descricao = @"descricao",
                Sigla = @"sigla",
                Tabela = @"TdocPj",
                BindTdoc = BindTdoc
            };
            bw.ShowForm(this, true);
        }

        private void gridUIFt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            if (!gridUIFt1.CurrentCell.OwningColumn.Name.ToLower().Trim().Equals("ivainc")) return;
            gridUIFt1.CurrentCell.Value = !gridUIFt1.CurrentCell.Value.ToBool();
            gridUIFt1.Update();
            Helper.Totaislinhas(true, gridUIFt1.DtDS, this);
        }

        public void Receive(DataGridViewRow dr)
        {
            if (gridUIFt1.CurrentRow == null) return;
            gridUIFt1.CurrentRow.Cells["TabIVA"].Value = dr.Cells[0].Value;
            gridUIFt1.CurrentRow.Cells["txiva"].Value = dr.Cells[1].Value;
            Helper.Totaislinhas(true, gridUIFt1.DtDS, this);
        }
        private void gridUIFt1_MouseDown(object sender, MouseEventArgs e)
        {
            if (gridUIFt1.Rows.Count <= 0) return;
            // Load context menu on right mouse click
            DataGridView.HitTestInfo hitTestInfo;
            if (e.Button != MouseButtons.Right) return;
            hitTestInfo = gridUIFt1.HitTest(e.X, e.Y);
            gridUIFt1.Rows[hitTestInfo.RowIndex].Selected = true;
            // If column is first column
            if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                DeleteRow.Show(gridUIFt1, new Point(e.X, e.Y));
        }
        private void gridUIFt1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (gridUIFt1.CurrentRow == null) return;
                if (gridUIFt1.CurrentRow.Cells["classificador"].Value==null) return;
                if (gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString().ToLower().Equals("pessoa"))
                {
                    // CalculaSalario();
                    if (!NVerificar) return;
                    NVerificar = false;
                    Helper.Totaislinhas(true, gridUIFt1.DtDS, this);
                }
                else
                {
                    if (!NVerificar) return;
                    NVerificar = false;
                    Helper.Totaislinhas(true, gridUIFt1.DtDS, this);
                }
                //ActualizaActividade();
            }
            catch
            {
                //
            }

        }

        private void ActualizaActividade()
        {
            if (gridUIFt1.CurrentRow == null) return;
            decimal total = 0;
            var seq = gridUIFt1.CurrentRow.Cells["sequence"].Value.ToString().Substring(0, 1);
            var dt = gridUIFt1.DtDS.AsEnumerable().Where(x => x.Field<string>("Sequenc").Substring(0, 1).Equals(seq) && x.Field<string>("Sequenc").Length>1).CopyToDataTable();
            if (!(dt?.Rows.Count > 0)) return;
            {
                total = dt.AsEnumerable().Sum(x => x.Field<decimal>("Totall")).ToDecimal();
                var r = gridUIFt1.DtDS.AsEnumerable().FirstOrDefault(x => x.Field<string>("Sequenc").Equals(seq));
                r["Totall"] = total;
                gridUIFt1.Update();
            }
        }

        public int Indicelinhaadicionar;
        public string ActividadeAssociadasAqi;
        private void dtIniReal_DateChangValues()
        {
            try
            {
                //    if (dtFimReal.dt1.Value < dtIniReal.dt1.Value)
                //    {
                //    }
                //    else
                //    {
                //        CalculateRealDays();
                //    }

            }
            catch (Exception ex)
            {
                //ex.ToString();
            }
        }
        private void gridUIFt1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (EditMode)
            //{
            //    if (gridUIFt1.CurrentCell.OwningColumn.Name.Trim().ToLower().Equals("tabiva")) return;
            //    var validClick = e.RowIndex != -1 && e.ColumnIndex != -1; //Make sure the clicked row/column is valid.
            //    var datagridview = sender as DataGridView;
            //    // Check to make sure the cell clicked is the cell containing the combobox 
            //    if (!(datagridview?.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn) || !validClick) return;
            //    datagridview.BeginEdit(true);
            //    //((TextBox)datagridview.EditingControl). = true;
            //}
        }
        private void gridUIFt1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            var classificadorValue = string.Empty;
            var name = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            if (name.Equals("ref"))
            {
                classificadorValue = gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString();
                if (!string.IsNullOrEmpty(classificadorValue) && classificadorValue.ToLower().Contains("produto"))
                {
                    SetFieldValue("Referenc", classificadorValue);
                }
                if (!string.IsNullOrEmpty(classificadorValue) && classificadorValue.ToLower().Contains("pessoa"))
                {
                    SetFieldValue("no", classificadorValue);
                }
            }
            else if (name.Equals("descricao"))
            {
                classificadorValue = gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString();
                if (!string.IsNullOrEmpty(classificadorValue) && classificadorValue.ToLower().Contains("produto"))
                {
                    SetFieldValue("descricao", classificadorValue);
                }
                if (!string.IsNullOrEmpty(classificadorValue) && classificadorValue.ToLower().Contains("pessoa"))
                {
                    SetFieldValue("nome", classificadorValue);
                }
            }
            if (nome.Equals("descarm"))
            {
                SetArmazem("descricao");
            }
            if (nome.Equals("armazem"))
            {
                SetArmazem("codigo");
            }
            try
            {
                var columname = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
                if (columname.Equals("inicioe"))
                {
                    CalculateDaysInGridPeEscopo();
                }
                else
                {
                    _dtpeEscopo.Visible = false;
                }
                if (nome.Equals("tabiva"))
                {
                    SetTabIva("codigo");
                }
                if (nome.Equals("txiva"))
                {
                    SetTabIva("descricao");
                }

                //if (gridUIFt1.CurrentCell.OwningColumn.Name.ToLower().Equals("predecedorar")
                //    || columname.Equals("duracaor"))
                //{
                //    CalculateDaysInGridPeEscopo();
                //}

            }
            catch (Exception ex)
            {
                // ignored
            }
        }
        private void SetTabIva(string codigo)
        {
            if (gridUIFt1.CurrentCell?.Value == null) return;
            var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
            if (DtIva != null)
            {
                DataRow dr;
                switch (codigo)
                {
                    case "descricao":
                        dr = DtIva.AsEnumerable().FirstOrDefault(s => s.Field<string>(codigo).Equals(valor));
                        if (dr == null) return;
                        if (gridUIFt1.CurrentRow != null)
                            gridUIFt1.CurrentRow.Cells["tabiva"].Value = dr[0].ToString();
                        break;
                    case "codigo":
                        dr = DtIva.AsEnumerable().FirstOrDefault(s => s.Field<decimal>(codigo).ToDecimal().Equals(valor.ToDecimal()));
                        if (dr == null) return;
                        if (gridUIFt1.CurrentRow != null)
                            gridUIFt1.CurrentRow.Cells["txiva"].Value = dr[1].ToString();
                        break;
                }
                Helper.Totaislinha(true, gridUIFt1.DtDS, this, Tmptdocpj.Sigla);
            }

            gridUIFt1.Update();
        }

        private void SetArmazem(string referenc)
        {
            if (gridUIFt1.CurrentCell?.Value == null) return;
            var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
            var dr = DtArm.AsEnumerable().FirstOrDefault(s => s.Field<string>(referenc).Trim().Equals(valor));
            if (dr == null) return;
            switch (referenc)
            {
                case "descricao":
                    if (gridUIFt1.CurrentRow != null)
                        gridUIFt1.CurrentRow.Cells["Armazem"].Value = dr[0].ToString();
                    break;
                default:
                    if (gridUIFt1.CurrentRow != null)
                        gridUIFt1.CurrentRow.Cells["descarm"].Value = dr[1].ToString();
                    break;
            }

            gridUIFt1.Update();
        }
        private void SetFieldValue(string campo, string classificadorValue)
        {
            try
            {
                if (gridUIFt1.CurrentRow == null) return;
                if (gridUIFt1.CurrentCell?.Value == null) return;
                var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
                if (DtSt == null) return;
                if (string.IsNullOrEmpty(valor)) return;
                DataRow dr;
                if (campo.Equals("no"))
                {
                    dr = DtSt.AsEnumerable().FirstOrDefault(s => s.Field<decimal>(campo).Equals(valor.ToDecimal()));
                }
                else
                {
                    dr = DtSt.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));
                }
                if (dr == null) return;
                if (classificadorValue.ToUpper().Equals("Pessoa".ToUpper()))
                {

                    gridUIFt1.CurrentRow.Cells["ref"].Value = dr["no"];
                    gridUIFt1.CurrentRow.Cells["descricao"].Value = dr["nome"];
                }
                //Se for não for pessoal e não  actividade,  deve Procurar na base de Produtos
                if (classificadorValue.ToUpper().Equals("Produto".ToUpper()))
                {

                    Addline(dr["Ststamp"].ToString().Trim());
                }
            }
            catch
            {//
            }

        }

        private void gridUIFt1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            DtSt = null;
            if (gridUIFt1.CurrentRow == null) return;
            DataRow = ((DataRowView)gridUIFt1.CurrentRow.DataBoundItem).Row;
            var qry = string.Empty;
            var classificadorValue = string.Empty;
            var name = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            #region Bind Classificador
            if (name.Equals("classificador"))
            {
                Helper.SetBinds(e.Control, "Descricao", "select Descricao from auxiliar where tabela =66");
            }
            else if (name.Equals("ref"))
            {
                classificadorValue = gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString();
                if (!string.IsNullOrEmpty(classificadorValue) && classificadorValue.ToLower().Contains("produto"))
                {
                    DtSt=Helper.SetBinds(e.Control, "Referenc", "select Ststamp,Referenc,Descricao from st ");
                }
                if (!string.IsNullOrEmpty(classificadorValue) && classificadorValue.ToLower().Contains("pessoa"))
                {
                    DtSt=Helper.SetBinds(e.Control, "no", "select no,nome from pe");
                }
            }
            else if (name.Equals("descricao"))
            {
                classificadorValue = gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString();
                if (!string.IsNullOrEmpty(classificadorValue) && classificadorValue.ToLower().Contains("produto"))
                {
                    DtSt=Helper.SetBinds(e.Control, "Descricao", "select Ststamp,Referenc,Descricao from st ");
                }
                if (!string.IsNullOrEmpty(classificadorValue) && classificadorValue.ToLower().Contains("pessoa"))
                {
                    DtSt=Helper.SetBinds(e.Control, "nome", "select no,nome from pe");
                }
            }

            #endregion
            ////Se for pessoal e não  actividade,  deve Procurar na base de nome de pessoas
            //if (!string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString())
            //    && gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString().ToUpper().Equals("Pessoa".ToUpper()))
            //{
            //    qry = "select Depart,pestamp,no,nome,ValBasico,Depart,Codep from pe";
            //}
            ////Se for não for pessoal e não  actividade,  deve Procurar na base de Produtos
            //if (!string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString()) && gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString().ToUpper().Equals("Produto".ToUpper()))
            //{
            //    qry = "select Ststamp,Referenc,Descricao from st ";
            //}
            //if (name.Equals("classificador"))
            //{
            //    DtSt = Helper.SetBinds(e.Control, "Descricao", qry);
            //}
            //else if (!string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString()) && name.Equals("descricao"))
            //{
            //    //Se for pessoal e não  actividade,  deve Procurar na base de nome de pessoas
            //    if (gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString().ToUpper().Equals("Pessoa".ToUpper()))
            //    {
            //        DtSt = Helper.SetBinds(e.Control, "nome", qry);
            //    }
            //    //Se for não for pessoal e não  actividade,  deve Procurar na base de Produtos
            //    if (gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString().ToUpper().Equals("Produto".ToUpper()))
            //    {
            //        DtSt = Helper.SetBinds(e.Control, "Descricao", qry);
            //    }

            //}
            //else if (!string.IsNullOrEmpty(gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString()) && name.Equals("ref"))
            //{
            //    //Se for pessoal e não  actividade,  deve Procurar na base de nome de pessoas

            //    if (gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString().ToUpper().Equals("Pessoa".ToUpper()))
            //    {
            //        DtSt = Helper.SetBinds(e.Control, "Depart", qry);
            //    }
            //    //Se for não for pessoal e não  actividade,  deve Procurar na base de Produtos
            //    if (gridUIFt1.CurrentRow.Cells["classificador"].Value.ToString().ToUpper().Equals("Produto".ToUpper()))
            //    {
            //        DtSt = Helper.SetBinds(e.Control, "Referenc", qry);
            //    }

            //}
            else if (name.Equals("armazem"))
            {
                qry = "select Codigo,Descricao from Armazem";
                DtArm = Helper.SetBinds(e.Control, "codigo", qry);
            }
            else if (name.Equals("descarm"))
            {
                qry = "select Codigo,Descricao from Armazem";
                DtArm = Helper.SetBinds(e.Control, "Descricao", qry);
            }
            else if (name.Equals("tabiva"))
            {
                DtIva=Helper.IvaSetting("Codigo", e.Control);
            }
            else if (name.Equals("txiva"))
            {
                DtIva=Helper.IvaSetting("Descricao", e.Control);
            }
            else
            {
                DtSt = null;
                var autoText = e.Control as TextBox;
                if (autoText != null) autoText.AutoCompleteCustomSource = null;
            }
            var row = gridUIFt1.CurrentRow;
            var va = string.Empty;
        }

        internal void UpdateObjects(Di di, DataTable dt)
        {
            //tbCliente.tb1.Text = di.Nome;
            //tbCliente.Text2 = di.No.ToString();
            //Ccusto.tb1.Text = di.Ccusto;
            //ucMoeda.tb1.Text = di.Moeda;
            //facc.Oristamp = di.Distamp;
            //Distamp = di.Distamp;
            //facc.Reserva = true;
            //FillGrid(dt);
            //OrigReserva = false;
        }
        private void ReceiveDataFromCopyLinhas(DataTable dt)
        {
            if (!(dt?.Rows.Count > 0)) return;
            gridUIFt1.DtDS.Rows.Clear();
            foreach (var row in dt.AsEnumerable())
            {
                DataRow = Helper.NewGridRowUi(this);
                var tmpFound = SQL.GetRowToEnt<St>($"Referenc ='{row["ref"].ToString().Trim()}'");//EF.GetEnt<St>(x => x.Referenc.Trim().Equals(row["ref"].ToString().Trim()));
                GenBl.SetLineValues(DataRow, tmpFound, Facc, true, row, false, "", "", "");
                DataRow["Armazem"] = row["Codarm"];
                DataRow["Descarm"] = row["armazem"];
            }

            // di.Oristamp = dt.TableName.Equals("dil") ? dt.Rows[0]["distamp"].ToString() : dt.Rows[0]["Factstamp"].ToString();
            Helper.Totaislinhas(true, gridUIFt1.DtDS, this);
        }
        private void FillGrid(DataTable dt)
        {
            if (!(dt?.Rows.Count > 0)) return;
            for (var i = 0; i < dt.Rows.Count; i++)
            {
                DataRow = Helper.NewGridRowUi(this);
                var tmpFound = SQL.GetRowToEnt<St>($"Referenc ='{dt.Rows[i]["ref"].ToString().Trim()}'");//EF.GetEnt<St>(x => x.Referenc.Trim().Equals(dt.Rows[i]["ref"].ToString().Trim()));
                GenBl.SetLineValues(DataRow, tmpFound, Facc, true, dt.Rows[i], false, "", "", "");
            }
            Facc.Oristamp = dt.Rows[0]["distamp"].ToString();
            Helper.Totaislinhas(true, gridUIFt1.DtDS, this);
        }

        public string Distamp { get; set; }
        public string Origem { get; set; }

        private void gridUIFt1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!EditMode) return;
            if (gridUIFt1.CurrentRow == null) return;
            var name = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (name.Equals("desconto") || name.Equals("tabiva") ||
                name.Equals("txiva") ||
                name.Equals("perdesc") || name.Equals("valoriva") ||
                name.Equals("percdesc") || name.Equals("quant") || name.Equals("preco") || name.Equals("ivainc"))
            {
                NVerificar = true;
            }
        }
        private void gridUIFt1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode != Keys.Enter) return;
            //NewGridLine();
            //gridUIFt1.CurrentCell = gridUIFt1.Rows[gridUIFt1.Rows.Count - 1].Cells["Descricao"];
        }
        public void NewGridLine()
        {
            DataRow = Helper.NewGridRowUi(this);
        }

        #endregion

        private void gridUIFt1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (gridUIFt1.CurrentRow == null) return;
                gridUIFt1.BeginEdit(true);
                var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
                switch (nome)
                {
                    case "executar":
                        {
                            if (!ExisteVerificarPredecedoras())
                            {
                                if (gridUIFt1.CurrentRow == null) return;
                                gridUIFt1.CurrentRow.Cells["DatIniRealesco"].Value = Pbl.SqlDate;
                                gridUIFt1.CurrentRow.Cells["Executado"].Value = true;
                                CalculateDaysInGridPeEscopo();
                            }

                            break;
                        }
                    default:
                        {
                            if (nome.Equals("Encerrar".ToLower()))
                            {
                                ExisteVerificarPredecedoras();
                            }

                            else if (nome.Equals("select"))
                            {
                                var f = new FrmPrevis { label1 = { Text = "Mais Detalhes da Descrição".ToUpper() } };
                                if (gridUIFt1.CurrentRow != null)
                                    f.grid=gridUIFt1;
                                f.ShowForm(this, true);
                            }
                            else if (nome.Equals("inicioe"))
                            {
                                //  Helper.AddDateTimePicker(gridUIFt1, e);
                                // Helper.SetDateTimePicker(gridUIFt1);
                                //_dtpeEscopo.Location =
                                //    gridUIFt1.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location;
                                //_dtpeEscopo.Visible = true;
                            }
                            else
                            {
                                _dtpeEscopo.Visible = false;
                            }

                            break;
                        }
                }

            }
            catch (Exception ex)
            {
                // ignored
            }

        }
        private void gridUIFt1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void gridUIFt1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            if (!nome.Equals("descricao")) return;
            var f = new FrmPrevis { label1 = { Text = "Mais Detalhes da Descrição".ToUpper() } };
            if (gridUIFt1.CurrentRow != null)
                f.grid = gridUIFt1;
            f.ShowDialog();
        }
        private DataTable list;

        private void OrdenamentoGrid()
        {
            try
            {
                list = gridUIFt1.DataSource as DataTable;
                for (int i = 0; i < gridUIFt1.Rows.Count; i++)
                {
                    if (string.IsNullOrEmpty(gridUIFt1.Rows[i].Cells["Sequence"].Value.ToString()))
                    {
                        gridUIFt1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Red;
                        gridUIFt1.Rows[i].Selected = true;
                        MsBox.Show("Nesta Linha não foi definida a sequência,\n\n".ToUpper() +
                                        " por favor defina agora para reordenar".ToUpper());
                        return;
                    }
                    if (string.IsNullOrEmpty(gridUIFt1.Rows[i].Cells["descricao"].Value.ToString())
                        || string.IsNullOrEmpty(gridUIFt1.Rows[i].Cells["Ref"].Value.ToString()))
                    {
                        gridUIFt1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Red;
                        gridUIFt1.Rows[i].Selected = true;
                        MsBox.Show($"Nesta Linha não foi definida a descrição ou referência,\n\n".ToUpper() +
                                        $" por favor defina agora para reordenar".ToUpper());
                        return;
                    }
                    gridUIFt1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Empty;
                }

                if (list.HasRows())
                {
                    var sorted = list.AsEnumerable()
                        .OrderBy(x => int.Parse(x.Field<string>("Sequenc").ToString().Split('.')[0]))
                        .ThenBy(x => x.Field<string>("Sequenc").ToString().Split('.').Length > 1
                            ? int.Parse(x.Field<string>("Sequenc").ToString().Split('.')[1])
                            : 0)
                        .ThenBy(x =>
                            x.Field<string>("Sequenc").ToString().Split('.').Length > 2
                                ? int.Parse(x.Field<string>("Sequenc").ToString().Split('.')[2])
                                : 0).ThenBy(x =>
                            x.Field<string>("Sequenc").ToString().Split('.').Length > 3
                                ? int.Parse(x.Field<string>("Sequenc").ToString().Split('.')[3])
                                : 0).CopyToDataTable();
                    gridUIFt1.DataSource = null;
                    gridUIFt1.DataSource = sorted;
                    gridUIFt1.DtDS = sorted;
                    gridUIFt1.Update();
                }
            }
            catch (Exception)
            {
                //
            }
        }

        private void btnImprirTd_Click(object sender, EventArgs e)
        {
            //Imprime somente bloco
            Filtro = $"{btnImprirTd.Text}";
            Printing(string.Empty);
        }

        private void Printing(string condicao)
        {
            if (string.IsNullOrEmpty(CLocalStamp)) return;
            var qr = $"  select Sequenc,pjesc.Descricao,Inicio=CONVERT(char(12), Inicio, 104),Termino=CONVERT(char(12), Termino, 104),Duracao,Subtotall,valival,Totall,Descontol,Codigo,pj.Nome,pj.Morada,pj.Data,pj.Datfim,pj.Nomedoc from Pjesc join Pj on pj.Pjstamp=pjesc.Pjstamp  where pj.Pjstamp='{CLocalStamp}' and Sequenc<>'' {condicao} " +
                     " ORDER BY cast('/' + replace(Sequenc, '.', '/') + '/' as hierarchyid)";
            var dtt = SQL.GetGen2DT(qr);
            if (dtt.HasRows())
            {
                //var p = new FrmReport
                //{
                //    Printstamp = _pj.Pjstamp,
                //    Origem = "PJ",
                //    ReportName = "RptPJ".Trim(),
                //    Dt = dtt,
                //    CTituloRelatorio = tbDescricao.tb1.Text,
                //    Filtro = Filtro,
                //    EntidadePrint = "Exmo(a) sr(a): " + tbCliente.tb1.Text,
                //    NomeProduto = "Morada: " + tbMorada.tb1.Text
                //};
                //p.ShowForm(this);
            }
            else
            {
                MsBox.Show("Estimado(a), não temos nada para imprimir!");
            }
        }

        private string Filtro = string.Empty;
        private void btnPrintBloco_Click(object sender, EventArgs e)
        {
            //Imprime somente bloco
            Filtro = $"{btnPrintBloco.Text}";
            Printing(" and Sequenc not like  ('%.%') and Classificador='Actividade'");
        }


        private void imprimirSóAcrividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Imprime somente Materiais
            Filtro = $"{imprimirSóAcrividadesToolStripMenuItem.Text}";
            Printing(" and Classificador='Actividade'");
        }

        private void panelTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuLateral.ShowMenuStrip(button2);

        }

        private void gridUIFt1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            try
            {
                if (e.Exception.Message == "DataGridViewComboBoxCell value is not valid.")
                {
                    //object value = gridUIFt1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                    //if (!((DataGridViewclassificador)gridUIFt1.Columns[e.ColumnIndex]).Items.Contains(value))
                    //{
                    //    ((DataGridViewclassificador)gridUIFt1.Columns[e.ColumnIndex]).Items.Add(value);
                    //    e.ThrowException = false;
                    //}
                }
            }
            catch
            {
                //
            }
        }

        private void hUMANOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Imprime somente Pessoas
            Filtro = $"{imprimirSóRHToolStripMenuItem.Text} " + $" {hUMANOSToolStripMenuItem.Text}".ToUpper();
            Printing(" and tipo='Pessoa'");
        }

        private void mATERIAISToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Imprime somente Materiais
            Filtro = $"{imprimirSóRHToolStripMenuItem.Text}" + $"  {mATERIAISToolStripMenuItem.Text}".ToUpper();
            Printing(" and tipo='Produto'");
        }

        private void tbCustoTotalDoProjecto_Load(object sender, EventArgs e)
        {

        }

        private void btnDocumentos_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageDocuments);
        }

        private void tbDefault7_Load(object sender, EventArgs e)
        {

        }

        private void tbDefault10_Load(object sender, EventArgs e)
        {

        }

        private void tbCliente_RefreshControls()
        {
            tbMorada.tb1.Text =SQL.GetValue("morada", "cl", $"no='{tbCliente.Text2}'");
        }

        private void imprimirSóRHToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gridUi7_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUi7.CurrentRow == null) return;
            gridUi7.BeginEdit(true);
            gridUi7.Anexos();
        }

        private void gridPanel24_AfterAddLineEvent()
        {
            var nMaxOrdem = gridUIFt1.DtDS.Rows.Count;
            if (nMaxOrdem>1)
            {
                nMaxOrdem =nMaxOrdem + 1;
            }
            if (gridUIFt1.CurrentRow != null)
                gridUIFt1.DataRowr["ordem"]= nMaxOrdem;
        }

        private void btnSetPO_Click(object sender, EventArgs e)
        {
            tbPo.tb1.Text = @"PENDENTE";
        }

        private void gridUi3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUi3.CurrentRow == null) return;
            gridUi3.BeginEdit(true);
        }

        private void gridUi2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUi2.CurrentRow == null) return;
            gridUi2.BeginEdit(true);
        }

        private void btnAbriPj_Click(object sender, EventArgs e)
        {
            if (Inserindo) return;
            if (_pj == null) return;
            if (!EditMode)
            {
                if (_pj.Fechado)
                {
                    if (SQL.GetFieldValue("usr", "ReabrePj", $"Login='{Pbl.Usr.Login.Trim()}'").ToBool())
                    {
                        var dr = MsBox.Show(Messagem.ParteInicial() + "Dejesa abrir o projecto?", DResult.YesNo);
                        if (dr.DialogResult != DialogResult.Yes) return;
                        _pj.Fechado = false;
                        _pj.Status = "Aberto";
                        GravaAudit("Abertura");
                        status.Enabled = true;
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "Não tem permissão para abrir o projecto fechado?");
                    }
                }
                else
                {
                    var dr = MsBox.Show(Messagem.ParteInicial() + "Dejesa Fechar o projecto?", DResult.YesNo);
                    if (dr.DialogResult != DialogResult.Yes) return;
                    var dt = gridUIFt1.DataSource as DataTable;
                    if (dt?.Rows.Count>0)
                    {
                        if (!dt.TableName.Equals("Error"))
                        {
                            var produtos = dt.AsEnumerable().Where(x => x.Field<bool>("Factura").Equals(true)).CopyToDataTable();
                            var dc2 = new DataColumn { DataType = typeof(bool), ColumnName = "facturado" };
                            produtos.Columns.Add(dc2);
                            foreach (var r in produtos.AsEnumerable())
                            {
                                r["facturado"] = SQL.CheckExist($"select top 1 ref from factl where oristampl='{r["Pjescstamp"].ToString().Trim()}'");
                            }

                            if (produtos.AsEnumerable().Any(x => x.Field<bool>("facturado").Equals(false)))
                            {
                                var messagem = "";
                                foreach (var r in produtos.AsEnumerable())
                                {
                                    if (r !=null)
                                    {
                                        messagem = r["descricao"] + "\r\n";
                                    }
                                }
                                MsBox.Show(Messagem.ParteInicial() + "O artigos abaixo ainda não forma facturados:"+messagem);
                            }
                            else
                            {
                                _pj.Fechado = true;
                                _pj.Status = "Fechado";
                                GravaAudit("Fechado");
                                status.Enabled = false;
                            }
                        }
                        else
                        {
                            MsBox.Show(Messagem.ParteInicial() + "Não podemos proceder com o fecho. O escopo tem linhas não válidas!");
                        }
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + $"O Escopo do(a) {label1.Text} está vazio não pode fechar!");
                    }
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + $"O Escopo do(a) {label1.Text} deve estar em modo de edição para permitir gravar!");
            }
        }

        private void GravaAudit(string descricao)
        {
            var aud = new PjAudit
            {
                Pjauditstamp = Pbl.Stamp(),
                Pjstamp = CLocalStamp,
                Data = Pbl.SqlDate,
                Comprado = tbTotComprado.tb1.Text.ToDecimal(),
                Vendido = tbTotalFacturadoPj.tb1.Text.ToDecimal(),
                Interno = tbTotalGI.tb1.Text.ToDecimal(),
                Descricao = descricao,
                Login = Pbl.Usr.Login
            };
            EF.Save(aud);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CallBrowdoc();
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            ShowPjStatus("Activo");
        }

        private void ShowPjStatus(string status)
        {
            if (!EditMode)
            {
                var f = new FrmPjStatus(this)
                {
                    PjStatus = status,
                    label1 = { Text = @"PROCESSOS " + status.ToUpper() }
                };
                f.ShowForm(this, true);
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "O Processo está em modo de edição");
            }

        }

        private void pROCESSOSPENDENTESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPjStatus("Pendente");
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            ShowPjStatus("Fechado");
        }

        private void dtDataInicio_Load(object sender, EventArgs e)
        {

        }
    }
}

