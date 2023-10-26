using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using DMZ.UI.UI.Contabil;

namespace DMZ.UI.UI.PRC
{
    public partial class FrmProcur : FrmClasse
    {
        public string Valores
        {
            get => tbCliente.tb1.Text;
            set => tbCliente.tb1.Text = value;
        }

        private Procurm _pj;
        private DataRow _dataRow;
        private DataTable _dtvt;
        private DataTable _dtpe;
        private DataTable _dataTable;
        private DataTable _dtstf;
        private DataTable _dtSt;

        public FrmProcur()
        {
            InitializeComponent();
        }
        //public override void Refress()
        //{
        //    btnRefresh.PerformClick();
        //}
        public override void DefaultValues()
        {
            _pj = DoAddline<Procurm>();
            base.DefaultValues();
            status.SetStatusValue();
            btnGrafico.Enabled = false;
            Origem = "PJ";
            // tbDefault4.tB1.Text = $@"CONJUGADO";
            using (var d1T = SQL.GetGen2DT("select upper(Descricao) Descricao from Auxiliar where Tabela=76 ORDER BY Codigo"))
            {
                if (d1T != null)
                    for (var i = 0; i < d1T.Rows.Count; i++)
                    {
                        gridUi1.AddLine();
                        gridUi1.DtDS.Rows[gridUi1.DtDS.Rows.Count - 1]["criterio"] = d1T.Rows[i]["Descricao"].ToString();
                    }
            }
            gridUi1.SetDataSource(gridUi1.DtDS);
        }

        public override bool BeforeSave()
        {
            if (string.IsNullOrEmpty(tbDescricao.tb1.Text))
            {
                MsBox.Show("A descrição/objecto do procurement é de preenchimento obrigatório!");
                Cancelado = true;
                return false;
            }

            if (dtDataAbertura.dt1.Value < dtlancamento.dt1.Value)
            {
                MsBox.Show("A data final não pode ser menor que a data inicial.");
                btnCliente.PerformClick();
                Cancelado = true;
                return false;
            }

            if (string.IsNullOrEmpty(tbCliente.tb1.Text))
            {
                MsBox.Show("Defina o nome do cliente primeiro".ToUpper());

                btnCliente.PerformClick();
                Cancelado = true;
                return false;
            }

            for (var i = 0; i < gridUIFt1.Rows.Count; i++)
            {
                if (string.IsNullOrEmpty(gridUIFt1.Rows[i].Cells["descricao"].Value.ToString())
                    || string.IsNullOrEmpty(gridUIFt1.Rows[i].Cells["Ref"].Value.ToString()))
                {
                    gridUIFt1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Red;
                    gridUIFt1.Rows[i].Selected = true;
                    MsBox.Show("Nesta Linha não foi definida a\n\n descrição\n\n ou a referência \n\n por favor defina agora para salvar!. Campos obrigatórios".ToUpper());
                    btnEscopo.PerformClick();
                    Cancelado = true;
                    return false;
                }

                gridUIFt1.Rows[i].Cells["inicioe"].Value = dtlancamento.dt1.Value;
                gridUIFt1.Rows[i].Cells["Terminor"].Value = dtDataAbertura.dt1.Value;
                var dias = dtDataAbertura.dt1.Value - dtlancamento.dt1.Value;
                gridUIFt1.Rows[i].Cells["Duracaor"].Value = dias.TotalDays;
                gridUIFt1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Empty;
            }

            if (Procurou)
            {
                if (gridUiAnalises.HasRows())
                {
                    int clon = 0;
                    if (dgvComparativo.HasRows())
                    {
                        // btnGrafico.PerformClick();
                        for (int k = 0; k < dgvComparativo.Columns.Count; k++)
                        {
                            var fd = dgvComparativo.GetBindedTable();
                            //var xx=fd.Sum("total");
                            for (int i = 0; i < fd.Columns.Count; i++)
                            {
                                if (fd.Columns[i].ColumnName.ToLower().Equals("aceitar"))
                                {
                                    clon += 1;
                                }
                            }
                        }
                    }

                    for (int i = 0; i < gridUIFt1.DtDS.Rows.Count; i++)
                    {
                        var prod = gridUIFt1.DtDS.Rows[i]["descricao"].ToString();
                        for (int j = 0; j < dgvComparativo.Rows.Count; j++)
                        {
                            var forndg = dgvComparativo.Rows[j].Cells["Nomef"].Value.ToString();
                            var fornstamp = dgvComparativo.Rows[j].Cells["Fncstamps"].Value.ToString();
                            var desc = dgvComparativo.Rows[j].Cells["Descricaod"].Value.ToString();
                            var precco = dgvComparativo.Rows[j].Cells["Precof"].Value.ToString();
                            if (clon > 0)
                            {
                                if (dgvComparativo.Rows[j].Cells["Aceitar"].Value.ToBool())
                                {
                                    if (!prod.Equals(desc)) continue;
                                    gridUIFt1.DtDS.Rows[i]["nome"] = forndg;
                                    gridUIFt1.DtDS.Rows[i]["Fncstamp"] = fornstamp;
                                    gridUIFt1.DtDS.Rows[i]["Preco"] = precco.ToDecimal();
                                    var sq = SQL.GetGen2DT($"select no,email,Fncstamp from" +
                                                           $" fnc where Fncstamp='{fornstamp}'");
                                    if (sq.Rows.Count > 0)
                                    {
                                        gridUIFt1.DtDS.Rows[i]["no"] = sq.Rows[0]["no"].ToString();
                                        gridUIFt1.DtDS.Rows[i]["email"] = sq.Rows[0]["email"].ToString();
                                        gridUIFt1.DtDS.Rows[i]["Fncstamp"] = sq.Rows[0]["Fncstamp"].ToString();
                                    }
                                }
                            }
                        }
                    }
                }
            }
            CelClick();
            return base.BeforeSave();
        }
        public override void Save()
        {
            FillEntity(_pj);
            EF.Save(_pj);
        }

        public override void AfterSave()
        {
            var conta = 0;
            for (int i = 0; i < gridUi1.Rows.Count; i++)
            {
                if (!string.IsNullOrEmpty(gridUi1.Rows[i].Cells["grau"].Value.ToString()))
                {
                    conta += 1;
                }
            }
            var hr = dtDefault1.dt1.Value.ToString("HH:mm:ss");
            var hrr = dtDataAbertura.dt1.Value.ToString("MM-dd-yyyy ") + hr;
            var dd = dtlancamento.dt1.Value.ToString("MM-dd-yyyy ") + hr;
            string prod = string.Empty;
            for (int i = 0; i < gridUIFt1.DtDS.Rows.Count; i++)
            {
                SQL.SqlCmd($"update Procurml set no=" +
                           $"'{gridUIFt1.DtDS.Rows[i]["no"]}'," +
                           $"nome='{gridUIFt1.DtDS.Rows[i]["nome"]}'," +
                           $" termino='{hrr}'" +
                           $",duracao='{tbDias.tb1.Text}'" +
                           $" ,inicio='{dd}'," +
                           $"Ststamp='{gridUIFt1.DtDS.Rows[i]["Ststamp"]}',  " +
                           $"fncstamp='{gridUIFt1.DtDS.Rows[i]["fncstamp"]}',  " +
                           $"preco={gridUIFt1.DtDS.Rows[i]["Preco"]}," +
                           $" Valival={gridUIFt1.DtDS.Rows[i]["Valival"]}," +
                           $"Perdesc={gridUIFt1.DtDS.Rows[i]["Perdesc"]}," +
                           $"Descontol={gridUIFt1.DtDS.Rows[i]["Descontol"]}," +
                           $"Subtotall={gridUIFt1.DtDS.Rows[i]["subtotall"]}," +
                           $"Totall={gridUIFt1.DtDS.Rows[i]["Totall"]}," +
                           $"PrecoCompra ={gridUIFt1.DtDS.Rows[i]["PrecoCompra"]}" +
                           $",email='{gridUIFt1.DtDS.Rows[i]["email"]}'," +
                           $"Pjescstamp='{CLocalStamp}'" +
                           $" where Procurmstamp='{CLocalStamp}' and " +
                           $"Procurmlstamp='{gridUIFt1.DtDS.Rows[i]["Procurmlstamp"]}' ");
                if (!gridUIFt1.DtDS.Rows[i]["nome"].ToString().IsNullOrEmpty() && !gridUIFt1.DtDS.Rows[i]["email"].ToString().IsNullOrEmpty())
                {
                    var desc = gridUIFt1.DtDS.Rows[i]["descricao"].ToString();
                    var dr = SQL.GetGenDT($"select Ststamp from st where Referenc='{gridUIFt1.DtDS.Rows[i]["Ref"]}'");

                    if (dr.Rows.Count > 0)
                    {
                        if (SQL.GetGenDT($"select * from StPrecos where Ststamp='{dr.Rows[0]["Ststamp"]}'").HasRows())
                        {

                            var dt1 = SQL.GetGenDT($"select * from StPrecos where" +
                                                   $" ststamp=(select top 1 ststamp from st" +
                                                   $" where Referenc='{gridUIFt1.DtDS.Rows[i]["Ref"]}') ");
                            //Se não existir 
                            if (dt1.Rows.Count == 0)
                            {
                                SQL.SqlCmd($"INSERT INTO [dbo].[StPrecos] " +
                                           $"([StPrecostamp],[Ststamp] ,[CCusto]," +
                                           $"[CodCCu],[Ivainc],[padrao],[Preco]," +
                                           $"[PrecoCompra],[Perc],[Moeda])   " +
                                           $"  VALUES   ('{Pbl.Stamp()}'," +
                                           $"'{dr.Rows[0]["Ststamp"]}','{Pbl.Usr.Ccusto}'" +
                                           $",'{Pbl.Usr.Codccu}'," +
                                           $"1 ,0," +
                                           $"Preco={gridUIFt1.DtDS.Rows[i]["Preco"]} ," +
                                           $"PrecoCompra={gridUIFt1.DtDS.Rows[i]["Preco"]}," +
                                           $"0,''");
                            }
                            else
                            {
                                if (!string.IsNullOrEmpty(dt1.Rows[0]["CodCCu"].ToString()))
                                {
                                    SQL.SqlCmd($"update StPrecos set " +
                                               $"PrecoCompra={gridUIFt1.DtDS.Rows[i]["Preco"]}, Preco={gridUIFt1.DtDS.Rows[i]["Preco"]}+({gridUIFt1.DtDS.Rows[i]["Preco"]}*Perc/100)" +
                                               $" where Ststamp=(select top 1 ststamp from st " +
                                               $"where Referenc='{gridUIFt1.DtDS.Rows[i]["Ref"]}') " +
                                               $" and CodCCu='{Pbl.Usr.Codccu}'");
                                }
                                else
                                {
                                    SQL.SqlCmd($"update StPrecos set " +
                                               $"CodCCu='{Pbl.Usr.Codccu}',ccusto='{Pbl.Usr.Ccusto}', Preco={gridUIFt1.DtDS.Rows[i]["Preco"]}+({gridUIFt1.DtDS.Rows[i]["Preco"]}*Perc/100)" +
                                               $" where Ststamp=(select top 1 ststamp from st " +
                                               $"where Referenc='{gridUIFt1.DtDS.Rows[i]["Ref"]}') ");
                                }
                            }

                        }
                    }
                }
            }
            if (!string.IsNullOrEmpty(prod))
            {
                MsBox.Show(Messagem.ParteInicial() + $"O(s) produtos {prod} não tem centro de custo definidos no\r\n cadastro de produtos");
            }
            if (conta == 0)
            {
                SQL.SqlCmd($"delete from ProcCrt where Procurmstamp='{CLocalStamp}'");
            }
        }

        private void dtDataInicio_DateChangValues()
        {
            try
            {
                if (dtDataAbertura.dt1.Value > dtlancamento.dt1.Value)
                {
                    CalculateDays();
                }
                else
                {
                    tbDias.tb1.Text = 0.ToString("N1");
                    var hr = dtDefault1.dt1.Value.ToString("HH:mm:ss");
                    var hrr = dtDataAbertura.dt1.Value.ToString("dd-MM-yyyy ") + hr;
                    for (var i = 0; i < gridUIFt1.Rows.Count; i++)
                    {
                        gridUIFt1.Rows[i].Cells["terminor"].Value = Convert.ToDateTime(hrr);
                        gridUIFt1.Rows[i].Cells["duracaor"].Value = tbDias.tb1.Text;
                        gridUIFt1.Rows[i].Cells["inicioe"].Value = dtlancamento.dt1.Value.ToString("dd-MM-yyyy ") + hr;

                    }

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
            var dias = dtDataAbertura.dt1.Value - dtlancamento.dt1.Value;
            tbDias.tb1.Text = dias.TotalDays.ToString("N1");
            var hr = dtDefault1.dt1.Value.ToString("HH:mm:ss");
            var hrr = dtDataAbertura.dt1.Value.ToString("dd-MM-yyyy ") + hr;
            for (int i = 0; i < gridUIFt1.Rows.Count; i++)
            {
                gridUIFt1.Rows[i].Cells["terminor"].Value = Convert.ToDateTime(hrr);
                gridUIFt1.Rows[i].Cells["duracaor"].Value = tbDias.tb1.Text;
                gridUIFt1.Rows[i].Cells["inicioe"].Value = dtlancamento.dt1.Value.ToString("dd-MM-yyyy ") + hr;

            }
        }


        private int _ii = 0;
        public DataTable Tabela { get; set; }

        public override void PreencheCampos(DataTable dtt, int ii)
        {
            _pj = FillControls(_pj, dtt, ii);
            Tabela = SQL.GetGen2DT("select Regime,ugea,Modalidade,Criter," +
                                   "NumLote,Prov,GaranProv,Convert(date,Datini)Lancamento," +
                                   "Convert(date,Datfim)ABertura," +
                                   "Descricao, Convert(varchar,Horaabert,5) Horaabert,classe from Procurm " +
                                   $"where Procurmstamp='{CLocalStamp}'");
            Origem = gridUIFt1.Origem = "PJ";
            gridUIFt1.Update();
            gridUIFt1.Refresh();
            try
            {
                for (var j = 0; j < gridUIFt1.Rows.Count; j++)
                {
                    if (gridUIFt1.Rows[j].Cells["Total"].Value == null)
                    {
                        gridUIFt1.Rows[j].Cells["Total"].Value = 0;
                    }
                    if (gridUIFt1.Rows[j].Cells["descricao"].Value == null)
                    {
                        gridUIFt1.Rows[j].Cells["descricao"].Value = "";
                    }
                    if (gridUIFt1.Rows[j].Cells["Ref"].Value == null)
                    {
                        gridUIFt1.Rows[j].Cells["Ref"].Value = "";
                    }
                }
            }
            catch
            {
                //
            }

            if (gridUIFt1.DtDS.Rows.Count > 0)
            {
                Helper.TotaisFt(gridUIFt1.DtDS, this);
            }

            gridUIFt1.Update();
            gridUIFt1.Refresh();
            try
            {
                if (gridUi1.Rows.Count == 0)
                {
                    var dt = SQL.GetGen2DT(
                        "select upper(Descricao) Descricao from Auxiliar where Tabela=76 ORDER BY Codigo");

                    gridUi1.DataSource = null;
                    if (dt != null)
                        for (var i = 0; i < dt.Rows.Count; i++)
                        {
                            gridUi1.AddLine();
                            gridUi1.DtDS.Rows[gridUi1.DtDS.Rows.Count - 1]["criterio"] =
                                dt.Rows[i]["Descricao"].ToString();
                        }
                    gridUi1.AutoGenerateColumns = false;
                    gridUi1.DataSource = gridUi1.DtDS;
                }
            }
            catch
            {
                //
            }
            tbDescricao.tb1.Focus();
            btnGrafico.Enabled = true;
            Refrescar();
        }

        private void FrmProcur_Load(object sender, EventArgs e)
        {
            var process = System.Diagnostics.Process.GetProcessesByName("Excel");
            foreach (System.Diagnostics.Process p in process)
            {
                if (!p.ProcessName.IsNullOrEmpty())
                {
                    p.Kill();
                }
            }
            btnAdministracao.PerformClick();
            Campo1 = "codigo";
            Campo2 = "descricao";
            Ctabela = "Procurm";
            gridUIFt1.Condicao = $"Procurmstamp='{CLocalStamp}'";
            gridUiAnalises.Condicao = $"Procurmstamp='{CLocalStamp}'";
            gridUiAnalises.OrderbyCampos = " Descricao,Qual,Preco,Termino ";
            gridUi1.Condicao = $"Procurmstamp='{CLocalStamp}'";
            tabControl1.Appearance = TabAppearance.FlatButtons;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            gridUIFt1.CellEndEdit += gridUIFt1_CellEndEdit;
            dtDataFinal_DateChangValues();
            tbDescricao.Focus();
            tbDescricao.Select();
            tbDescricao.tb1.Focus();
            tbDescricao.tb1.Select();

        }

        public override void Addline(string referenc)
        {
            #region Compras
            try
            {
                var tmpFound = SQL.GetRowToEnt<St>($"Ststamp='{referenc.Trim()}'"); //EF.GetEnt<St>(p => p.Ststamp.Trim().Equals($"{referenc.Trim()}"));
                GenBl.SetLineValues(DataRow, tmpFound, _pj, true, null, false, "MZN", "", "");
                DataRow["Preco"] = 0;
                DataRow["Quant"] = 1;
                GenBl.TotaisLinhas(DataRow);
                gridUIFt1.Update();
                Helper.TotaisFt(gridUIFt1.DtDS, this);
            }
            catch
            {
                //
            }

            #endregion
        }

        private void dtDataFinal_DateChangValues()
        {
            try
            {
                if (dtDataAbertura.dt1.Value < dtlancamento.dt1.Value)
                {
                    tbDias.tb1.Text = 0.ToString("N1");

                    var hr = dtDefault1.dt1.Value.ToString("HH:mm:ss");
                    var hrr = dtDataAbertura.dt1.Value.ToString("dd-MM-yyyy ") + hr;
                    for (int i = 0; i < gridUIFt1.Rows.Count; i++)
                    {
                        gridUIFt1.Rows[i].Cells["terminor"].Value = Convert.ToDateTime(hrr);
                        gridUIFt1.Rows[i].Cells["duracaor"].Value = tbDias.tb1.Text;
                        gridUIFt1.Rows[i].Cells["inicioe"].Value = dtlancamento.dt1.Value.ToString("dd-MM-yyyy ") + hr;
                    }
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

        public void PassaDados()
        {

        }

        private void btnCliente_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageClinte);
            tbDescricao.tb1.Focus();
            ChangeMel(btnCliente);
        }

        private void btnEscopo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageEscopo);
            ChangeMel(btnEscopo);
        }

        private void ucProvincia_RefreshControls()
        {
            ucDistrito.Condicao = $" prov.Descricao='{ucProvincia.tb1.Text.Trim()}'";
            ucDistrito.tb1.Text = "";
        }

        #region COMPRAS


        public TdocPj TmpTdocf;
        public DataTable DtArm { get; set; }
        public DataRow DataRow { get; set; }
        public DataTable DtSt { get; private set; }
        private void CelClick()
        {
            gridUIFt1.Update();
            Helper.Totaislinhas(true, gridUIFt1.DtDS, this);
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
            if (gridUIFt1.Rows.Count > 0)
            {
                // Load context menu on right mouse click
                DataGridView.HitTestInfo hitTestInfo;
                if (e.Button == MouseButtons.Right)
                {
                    hitTestInfo = gridUIFt1.HitTest(e.X, e.Y);
                    gridUIFt1.Rows[hitTestInfo.RowIndex].Selected = true;
                    // If column is first column
                    if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                        DeleteRow.Show(gridUIFt1, new Point(e.X, e.Y));
                }
            }
        }
        private void gridUIFt1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (!NVerificar) return;
                NVerificar = false;
                Helper.Totaislinhas(true, gridUIFt1.DtDS, this);
            }
            catch
            {
                //
            }

        }
        public int Indicelinhaadicionar;

        public string ActividadeAssociadasAqi;



        private void gridUIFt1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        public string Cellsss { get; private set; } = string.Empty;

        private void gridUIFt1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Cellsss = string.Empty;
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            var hr = dtDefault1.dt1.Value.ToString("HH:mm:ss");
            var hrr = dtDataAbertura.dt1.Value.ToString("dd-MM-yyyy ") + hr;
            if (gridUIFt1.CurrentRow != null)
            {
                Cellsss = gridUIFt1.CurrentCell.Value.ToString();
                gridUIFt1.CurrentRow.Cells["terminor"].Value = hrr;
                gridUIFt1.CurrentRow.Cells["duracaor"].Value = tbDias.tb1.Text;
                gridUIFt1.CurrentRow.Cells["inicioe"].Value = dtlancamento.dt1.Value.ToString("dd-MM-yyyy ") + hr;
            }
            if (nome.Equals("descricao".ToLower()) || nome.Equals("ref".ToLower()) || nome.Equals("descarm") || nome.Equals("armazem"))
            {
                gridUIFt1.CurrentCell.Value = Cellsss;
            }
            if (nome.Equals("descricao"))
            {
                SetFaccl("descricao");
            }
            if (nome.Equals("ref"))
            {
                SetFaccl("Referenc");
            }
            if (nome.Equals("descarm"))
            {
                SetArmazem("descricao");
            }
            if (nome.Equals("armazem"))
            {
                SetArmazem("codigo");
            }


        }
        private void SetArmazem(string referenc)
        {
            if (gridUIFt1.CurrentCell?.Value == null) return;
            gridUIFt1.CurrentCell.Value = gridUIFt1.CurrentCell.Value.ToString().ToUpper();
            var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
            var dr = DtArm.AsEnumerable().FirstOrDefault(s => s.Field<string>(referenc).Trim().ToLower().Equals(valor.ToLower()));
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
        private void SetFaccl(string campo)
        {
            try
            {
                if (gridUIFt1.CurrentCell?.Value == null) return;
                gridUIFt1.CurrentCell.Value = gridUIFt1.CurrentCell.Value.ToString().ToUpper();
                var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
                if (DtSt == null) return;
                if (!valor.IsNullOrEmpty())
                {
                    DataRow dr;
                    if (campo.Equals("no"))
                    {
                        dr = DtSt.AsEnumerable().FirstOrDefault(s => s.Field<decimal>(campo).Equals(valor));
                    }
                    else
                    {
                        dr = DtSt.AsEnumerable().FirstOrDefault(s =>
                            s.Field<string>(campo).Trim().ToLower().Equals(valor.ToLower()));
                    }
                    if (dr != null)
                    {
                        Addline(dr["Ststamp"].ToString().Trim());
                        StPrecos tmpValor;
                        tmpValor = SQL.GetRowToEnt<StPrecos>($" ltrim(rtrim(ststamp)) ='{dr["Ststamp"].ToString().Trim()}' and CodCCu='{Pbl.Usr.Codccu}'");
                        if (tmpValor != null)
                        {
                            if (gridUIFt1.CurrentRow != null)
                            {
                                gridUIFt1.CurrentRow.Cells["PrecoCompra"].Value = tmpValor.Preco;
                                gridUIFt1.CurrentRow.Cells["Perc"].Value = tmpValor.Perc;
                                gridUIFt1.CurrentRow.Cells["Ststamp"].Value = tmpValor.Ststamp;
                            }
                        }
                    }
                }
            }
            catch
            {//
            }

        }


        private void gridUIFt1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            try
            {
                DtSt = null;
                if (gridUIFt1.CurrentRow == null) return;
                DataRow = ((DataRowView)gridUIFt1.CurrentRow.DataBoundItem).Row;
                string qry;
                var name = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
                if (name.Equals("descricao"))
                {
                    qry = "select Ststamp,Referenc,Descricao from st ";
                    DtSt = Helper.SetBinds(e.Control, "Descricao", qry);
                }
                else if (name.Equals("ref"))
                {
                    qry = "select Ststamp,Referenc,Descricao from st ";
                    DtSt = Helper.SetBinds(e.Control, "Referenc", qry);

                }
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
                else
                {
                    DtSt = null;
                    var autoText = e.Control as TextBox;
                    if (autoText != null) autoText.AutoCompleteCustomSource = null;
                }
            }
            catch
            {
                //
            }
        }

        public string Distamp { get; set; }
        public string Origem { get; private set; }
        public string Nomecoluna { get; private set; }

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
            if (e.KeyCode != Keys.Enter) return;
            NewGridLine();
            gridUIFt1.CurrentCell = gridUIFt1.Rows[gridUIFt1.Rows.Count - 1].Cells["Descricao"];
        }
        public void NewGridLine()
        {
            DataRow = Helper.NewGridRowUi(this);
        }

        #endregion

        private void gridUIFt1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            if (!nome.Equals("descricao")) return;
            var f = new FrmPrevis();
            f.label1.Text = @"Mais Detalhes da Descrição".ToUpper();
            if (gridUIFt1.CurrentRow != null)
                f.grid = gridUIFt1;
            f.ShowDialog();
        }
        private DataTable _list;


        private bool dmzGridButtons1_BeforeAddLineEvent()
        {
            try
            {
                if (Inserindo && gridUIFt1.Rows.Count == 0)
                {
                    gridUIFt1.BindGridView();
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        void LancarConcurso()
        {
            MenuPgf.ShowMenuStrip(btnPagamentos);
        }
        private void btnEnviarEmail_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                MsBox.Show(Messagem.ParteInicial() + "Desculpa, Tem de estar no modo de edição.");
                return;
            }
            var table = new DataTable(gridUIFt1.DtDS.TableName);
            try
            {

                if (string.IsNullOrEmpty(CLocalStamp)) return;
                if (!Procurou) return;
                if (Tabela.Rows.Count == 0) return;
                var b = new FrmEnviarEmail();
                var dtst = gridUIFt1.DataSource as DataTable;
                if (dtst?.Rows.Count > 0)
                {
                    var campos = new[]
                    {
                            "ref","descricao","inicio","termino",
                            "duracao","txiva","quant","preco","totall",
                            "subtotall","descontol","perdesc","tabiva","ivainc","valival","nome",
                            "no","ststamp","fncstamp","email"
                    };
                    table = dtst.DefaultView.ToTable(true, campos).AsEnumerable()
                        .CopyToDataTable();
                }
                table.TableName = gridUIFt1.DtDS.TableName;
                b.Dt = table;
                b.txtMensagem.Text = $@"{tbDescricao.tb1.Text.ToUpper()}";
                b.Proctbla = Tabela;
                b.ShowForm(this, true);
            }
            catch
            {
                //
            }
        }
        private void btnAnaliseProp_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageAnalisepropos);
            ChangeMel(btnAnaliseProp);

        }

        private bool gridPanel22_BeforeAddLineEvent()
        {
            return true;
        }

        private void btnAprovado_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageAprovado);
            tbDescricao.tb1.Focus();
            ChangeMel(btnAprovado);
        }
        private void gridUi1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi1.CurrentRow == null) return;
            var name = gridUi1.CurrentCell.OwningColumn.Name.ToLower();
            DataRow = gridUi1.CurrentRow.ToDataRow();
            if (name.Equals("grau"))
            {
                //Muito Importante, Importante,pouco importante,irrelevante
                var qry = "select upper(Descricao) Descricao,Auxiliarstamp from Auxiliar where Tabela=69 ORDER BY Codigo";
                DtSt = Helper.SetBinds(e.Control, "Descricao", qry);
            }
            else
            {
                DtSt = null;
                var autoText = e.Control as TextBox;
                if (autoText != null) autoText.AutoCompleteCustomSource = null;
            }
        }

        private void gridUi1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nomer = gridUi1.CurrentCell.OwningColumn.Name.ToLower();
            if (nomer.Equals("grau"))
            {
                SetFacclr("Descricao");
            }
        }
        private void SetFacclr(string campo)
        {
            try
            {
                if (gridUi1.CurrentCell?.Value == null) return;
                gridUi1.CurrentCell.Value = gridUi1.CurrentCell.Value.ToString().ToUpper();
                var valor = gridUi1.CurrentCell.Value.ToString().Trim();
                if (DtSt == null) return;
                if (!valor.IsNullOrEmpty())
                {
                    DataRow dr;
                    dr = DtSt.AsEnumerable().FirstOrDefault(s =>
                        s.Field<string>(campo).Trim().ToLower().Equals(valor.ToLower()));
                    if (dr == null) return;
                    #region Auxiliar
                    try
                    {
                        var tmpFound = SQL.GetRowToEnt<Auxiliar>($"Auxiliarstamp  ='{dr["Auxiliarstamp"].ToString().Trim()}'");// EF.GetEnt<Auxiliar>(p =>
                           // p.Auxiliarstamp.Trim().ToLower().Equals($"{dr["Auxiliarstamp"].ToString().Trim().ToLower()}"));
                        if (gridUi1.CurrentRow != null)
                            gridUi1.CurrentRow.Cells["avaliacao"].Value = tmpFound.Obs;
                    }
                    catch
                    {
                        //
                    }
                    #endregion
                }
            }
            catch
            {//
            }

        }

        private void btnAdministracao_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageHome);
            tbDescricao.Focus();
            tbDescricao.Select();
            tbDescricao.tb1.Focus();
            tbDescricao.tb1.Select();
            ChangeMel(btnAdministracao); 
        }

        private void btnComparativo_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageComparativo);
            Refrescar();
            ChangeMel(btnComparativo);
        }

        void Refrescar()
        {
            if (gridUiAnalises.Rows.Count > 0)
            {
                var dt = SQL.GetGenDT(
                    $"select * from( select  Nota=(select " +
                    $"(sum(CONVERT(decimal,FncProc.Grau,1))/" +
                    $"count(CONVERT(decimal,FncProc.Grau,1)) )*" +
                    $"(sum(convert(decimal,p.Avaliacao,1))/100) " +
                    $"from FncProc inner join fnc on FncProc.Fncstamp=fnc.Fncstamp  where" +
                    $" Fnc.Fncstamp=ProcAnalFnc.Fncstamp )," +
                    $"UPPER(ProcAnalFnc.Descricao)Descricao,UPPER(Nome)Nome,ProcAnalFnc.Fncstamp," +
                    $"min(Preco) Preco " +
                    $"from ProcAnalFnc inner join ProcCrt p on " +
                    $" p.Procurmstamp=ProcAnalFnc.Procurmstamp where" +
                    $" ProcAnalFnc.Procurmstamp='{CLocalStamp}'" +
                    $"group" +
                    $" by ProcAnalFnc.Descricao,ProcAnalFnc.Nome,ProcAnalFnc.Fncstamp  ) tab " +
                    $" group by Descricao,Nota,Preco,Nome,Fncstamp order by" +
                    $" Descricao,Nota,Preco desc");
                dt.Columns.Add("Aceitar", typeof(bool));
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["Aceitar"] = false;
                }
                dgvComparativo.DataSource = null;
                dgvComparativo.DataSource = dt;
                for (int i = 0; i < dgvComparativo.Columns.Count; i++)
                {
                    dgvComparativo.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
        }
        private void btnGrafico_Click(object sender, EventArgs e)
        {
            if (!Procurou) return;
            var dt = SQL.GetGenDT(
                   $"select * from( select  Nota=(select " +
                   $"(sum(CONVERT(decimal,FncProc.Grau,1))/" +
                   $"count(CONVERT(decimal,FncProc.Grau,1)) )*" +
                   $"(sum(convert(decimal,p.Avaliacao,1))/100)" +
                   $" from FncProc inner join fnc on FncProc.Fncstamp=fnc.Fncstamp" +
                   $"  where Fnc.Fncstamp=ProcAnalFnc.Fncstamp ),UPPER(ProcAnalFnc.Descricao) Descricao," +
                   $"UPPER(ProcAnalFnc.Nome) Nome,ProcAnalFnc.Fncstamp,min(Preco) Preco from ProcAnalFnc inner " +
                   $"join ProcCrt p on  p.Procurmstamp=ProcAnalFnc.Procurmstamp " +
                   $" WHERE ProcAnalFnc.Procurmstamp='{CLocalStamp}'" +
                   $"group by ProcAnalFnc.Descricao,ProcAnalFnc.Nome,ProcAnalFnc.Fncstamp  ) tab  group" +
                   $" by Descricao,Nota,Preco,Nome,Fncstamp order by Descricao,Nota,Preco desc");
            decimal gggg = 0;
            var qrty = $"select  top 1  * from ( select Nota=(select " +
                       $"(sum(CONVERT(decimal,FncProc.Grau,1))/count(CONVERT(decimal,FncProc.Grau,1)) )*" +
                       $"(sum(convert(decimal,p.Avaliacao,1))/100) from" +
                       $" FncProc inner join fnc on FncProc.Fncstamp=fnc.Fncstamp " +
                       $"where Fnc.Fncstamp=ProcAnalFnc.Fncstamp )," +
                       $"UPPER(ProcAnalFnc.Descricao) Descricao," +
                       $"UPPER(Nome) Nome,ProcAnalFnc.Fncstamp" +
                       $" from ProcAnalFnc inner join ProcCrt p on " +
                       $" p.Procurmstamp=ProcAnalFnc.Procurmstamp " +
                       $"  WHERE ProcAnalFnc.Procurmstamp='{CLocalStamp}'" +
                       $"group " +
                       $"by ProcAnalFnc.Descricao,ProcAnalFnc.Nome,ProcAnalFnc.Fncstamp   ) tab " +
                       $"where 1=8 group by Descricao,Nota,Nome,Fncstamp" +
                       $" order by Descricao,Nota desc";
            var ft = SQL.GetGen2DT(qrty);

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                var nom = dt.Rows[i]["Descricao"].ToString();
                var qry = $"select  top 1  * from ( select Nota=(select " +
                          $"(sum(CONVERT(decimal,FncProc.Grau,1))/" +
                          $"count(CONVERT(decimal,FncProc.Grau,1)) )*" +
                          $"(sum(convert(decimal,p.Avaliacao,1))/100) from" +
                          $" FncProc inner join fnc on FncProc.Fncstamp=fnc.Fncstamp " +
                          $"where Fnc.Fncstamp=ProcAnalFnc.Fncstamp ),upper(ProcAnalFnc.Descricao) Descricao,upper(Nome)Nome,ProcAnalFnc.Fncstamp" +
                          $" from ProcAnalFnc inner join ProcCrt p on " +
                          $" p.Procurmstamp=ProcAnalFnc.Procurmstamp" +
                          $"  WHERE ProcAnalFnc.Procurmstamp='{CLocalStamp}'" +
                          $" group " +
                          $"by ProcAnalFnc.Descricao,ProcAnalFnc.Nome,ProcAnalFnc.Fncstamp  ) tab " +
                          $"where Descricao='{nom}'group by Descricao,Nota,Nome,Fncstamp" +
                          $" order by Descricao,Nota desc";
                var df = SQL.GetGen2DT(qry);
                DataRow dr = ft.NewRow();
                int g = 0;
                for (int j = 0; j < ft.Rows.Count; j++)
                {
                    var ggf = ft.Rows[j]["Descricao"].ToString();
                    if (nom.Equals(ggf))
                    {
                        g += 1;
                    }
                }
                if (g == 0)
                {
                    dr["nota"] = df.Rows[0]["nota"];
                    dr["Descricao"] = df.Rows[0]["Descricao"].ToString().Trim();
                    dr["Nome"] = df.Rows[0]["Nome"].ToString().Trim();
                    dr["Fncstamp"] = df.Rows[0]["Fncstamp"].ToString().Trim();
                    ft.Rows.Add(dr);
                }
            }
            ft.Columns.Add("Preco", typeof(decimal));
            ft.Columns.Add("Aceitar", typeof(bool));
            for (int i = 0; i < ft.Rows.Count; i++)
            {
                var nom = ft.Rows[i]["Descricao"].ToString();
                var nomf = ft.Rows[i]["nome"].ToString();
                var nomfst = ft.Rows[i]["Fncstamp"].ToString();
                var qryt = $" select  preco from(select Nota=(select " +
                           $"(sum(CONVERT(decimal,Grau,1))/count(CONVERT(decimal,Grau,1)) )*" +
                           $"(sum(convert(decimal,p.Avaliacao,1))/100) from FncProc inner" +
                           $" join fnc on FncProc.Fncstamp=fnc.Fncstamp where" +
                           $" Fnc.Fncstamp=ProcAnalFnc.Fncstamp ), UPPER(ProcAnalFnc.Descricao)Descricao," +
                           $"UPPER(ProcAnalFnc.Nome)Nome,ProcAnalFnc.Fncstamp,min(Preco) Preco from ProcAnalFnc " +
                           $"inner join ProcCrt p on  p.Procurmstamp=" +
                           $"ProcAnalFnc.Procurmstamp group by ProcAnalFnc.Descricao," +
                           $"ProcAnalFnc.Nome,ProcAnalFnc.Fncstamp  ) tab where" +
                           $" Descricao='{nom}'" +
                           $" and Fncstamp='{nomfst}' " +
                           $"group by Descricao,Nota,Preco,Nome,Fncstamp " +
                           $"order by Descricao,Nota,Preco desc";
                var dqt = SQL.GetGenDT(qryt);
                if (dqt.Rows.Count > 0)
                {
                    ft.Rows[i]["preco"] = dqt.Rows[0]["preco"].ToString();
                }
                else
                {
                    ft.Rows[i]["preco"] = 0.ToString();
                }
                ft.Rows[i]["Aceitar"] = true;
            }
            dgvComparativo.DataSource = null;
            dgvComparativo.DataSource = ft;
            for (int i = 0; i < dgvComparativo.Columns.Count; i++)
            {
                dgvComparativo.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }
            for (int i = 0; i < dgvComparativo.Rows.Count; i++)
            {
                dgvComparativo.Rows[i].Cells["Aceitar"].ReadOnly = false;
            }
            CelClick();
        }

        private void dtDefault1_DateChangValues()
        {
            var hr = dtDefault1.dt1.Value.ToString("HH:mm:ss");
            var hrr = dtDataAbertura.dt1.Value.ToString("yyyy-MM-dd ") + hr;
            for (int i = 0; i < gridUIFt1.Rows.Count; i++)
            {
                gridUIFt1.Rows[i].Cells["terminor"].Value = Convert.ToDateTime(hrr);
                gridUIFt1.Rows[i].Cells["inicioe"].Value = dtlancamento.dt1.Value.ToString("dd-MM-yyyy ") + hr;
            }
        }

        private void btnFacturacl_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                MsBox.Show(Messagem.ParteInicial() + "Desculpa, Tem de estar no modo de edição.");
                return;
            }
            var retorno = IsAllValido("tdoc");
            if (!retorno.valido) return;
            _lista = retorno.lista;
            var dtst = gridUIFt1.DataSource as DataTable;
            if (dtst?.Rows.Count > 0)
            {
                var campos = new[]
                {
                    "ref", "Descricao", "quant", "preco", "Procurmlstamp", "Txiva", "Tabiva", "Perdesc",
                    "Descontol", "Ivainc", "Factura","Pjescstamp","ststamp"
                };
                if (dtst.AsEnumerable().Any(x => x.Field<bool>("Factura").Equals(false)))
                {
                    var produtos = dtst.DefaultView.ToTable(true, campos).AsEnumerable().Where(x => x.Field<bool>("Factura").Equals(false)).CopyToDataTable();
                    var dc = new DataColumn { DataType = typeof(bool), ColumnName = "ok" };
                    produtos.Columns.Add(dc);
                    var dc2 = new DataColumn { DataType = typeof(bool), ColumnName = "facturado" };
                    produtos.Columns.Add(dc2);
                    foreach (var r in produtos.AsEnumerable())
                    {
                        r["ok"] = false;
                        r["facturado"] = SQL.CheckExist($"select top 1 ref from factl where oristampl='{r["Procurmlstamp"].ToString().Trim()}'");
                    }
                    var f = new FrmFt
                    {
                        ListaUsracessos = _lista,
                        Usracessos = _lista.FirstOrDefault(),
                        Pjstamp = CLocalStamp,
                        _cliente = SQL.GetRowToEnt<Cl>($"Fncstamp ='{tbCliente.Text3}'"),//EF.GetEnt<Cl>(x => x.Clstamp.Equals(tbCliente.Text3))
                    };
                    f.ShowForm(this);
                    f.CallBrowdoc();
                    f.btnNovo.PerformClick();
                    f.Tdoccondicao = "sigla='FT'";
                    f.Cliente.tb1.Text = tbCliente.tb1.Text;
                    f.tbPj.tb1.Text = tbDescricao.tb1.Text;
                    f.tbCcusto.tb1.Text = tbCcusto.tb1.Text;
                    f.tbPj.tb1.Text = tbDescricao.tb1.Text;
                    f.tbPj.Text3 = CLocalStamp;
                    f.tbPj.Text2 = tbReferenc.tb1.Text;
                    f.Cliente.button1.Enabled = false;
                    f.Cliente.Text2 = tbCliente.Text2;
                    f.Cliente.Text3 = tbCliente.Text3;
                    f.tbPj.button1.Enabled = false;
                    produtos.TableName = "Procurml";
                    f.Produtos(produtos);
                    f.SendRefresh = ReceiveRefresh;
                }
                else
                {
                    MsBox.Show($" {Messagem.ParteInicial()} Não tem artigos para facturar! \r\nDeve activar os artigos que pretende na coluna factura do escopo!");
                }
            }
            else
            {
                MsBox.Show($" {Messagem.ParteInicial()} Não é possivel facturar, a tabela do escopo esta vazia!");
            }
        }

        private (bool valido, List<Usracessos> lista) IsAllValido(string tdoc)
        {
            (bool valido, List<Usracessos> lista) ret = (false, null);
            if (!Inserindo)
            {
                _lista = Pbl.Usracessos.Where(x => x.Origem.ToLower().Equals(tdoc.ToLower())).ToList();
                if (_lista?.Count > 0)
                {
                    if (!string.IsNullOrEmpty(tbCliente.tb1.Text))
                    {
                        var lista2 = _lista.Where(linha => linha.Ver).ToList();
                        if (lista2.Count > 0)
                        {
                            ret = (true, lista2);
                        }
                        else
                        {
                            MsBox.Show($" {Messagem.ParteInicial()} não tem acesso a factura . contacte administrator!");
                        }
                    }
                    else
                    {
                        MsBox.Show($" {Messagem.ParteInicial()} no projecto não tem cliente definido. \r\nNão é possivel emitir o documento pretendido! ");
                    }
                }
                else
                {
                    MsBox.Show($"Desculpa não tem acessos definidos para {Pbl.Usr.Nome}. contacte administrator!");
                }
            }
            else
            {
                MsBox.Show($" {Messagem.ParteInicial()},O projecto está em criação. \r\nNão é possivel emitir o documento pretendido!");
            }
            return ret;
        }

        public void ReceiveRefresh(bool origem = false)
        {
            btnRefresh.PerformClick();
        }
        private void btnRecebimento_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                MsBox.Show(Messagem.ParteInicial() + "Desculpa, Tem de estar no modo de edição.");
                return;
            }
            var retorno = IsAllValido("trcl");
            if (!retorno.valido) return;
            _lista = retorno.lista;
            var f = new FrmRcl
            {
                ListaUsracessos = _lista,
                Usracessos = _lista.FirstOrDefault(),
                _cl = SQL.GetRowToEnt<Cl>($"No ='{tbCliente.Text2}'"),//EF.GetEnt<Cl>(x => x.No.Equals(tbCliente.Text2))
        };
            f.Usracessos = _lista.FirstOrDefault();
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
            f.Cliente.Text3 = tbCliente.Text3;
            f.Cliente.button1.Enabled = false;
            f.Cliente.Text2 = tbCliente.Text2;
            f.Cliente.tb1.Text = tbCliente.tb1.Text;
            f.SendRefresh = ReceiveRefresh;
            //f.MetododeMovimentos();
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
            if (!EditMode)
            {
                MsBox.Show(Messagem.ParteInicial() + "Desculpa, Tem de estar no modo de edição.");
                return;
            }
            _lista = Pbl.Usracessos.Where(x => x.Origem.ToLower().Equals($"{tdoc.Trim()}")).ToList();
            if (_lista.Count <= 0) return;
            var f = new FrmDetalhes
            {
                PjStamp = CLocalStamp,
                Tabela = tabela,
                label1 = { Text = caption.ToUpper() }
            };
            f.ListaUsracessos = _lista;
            f.ShowForm(this);
        }

        private void btnTodasComprasemitidas_Click(object sender, EventArgs e)
        {
            CallFormLista("tdocf", "Facc", @"Todas compras emitidas".ToUpper());
        }
        private void btnComprar_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                MsBox.Show(Messagem.ParteInicial() + "Desculpa, Tem de estar no modo de edição.");
                return;
            }
            var retorno = IsAllValido("tdocf");
            if (!retorno.valido) return;
            _lista = retorno.lista;
            var dtst = gridUIFt1.DataSource as DataTable;
            var dxtst = dtst?.AsEnumerable().
                Where(x => x.Field<string>("Email") != "");
            if (dxtst.Count()>0)
            {


                dtst= dxtst.CopyToDataTable();

                if (dtst?.Rows.Count > 0)
            {
                var campos = new[]
                {
                    "ref", "Descricao", "quant", "preco", "Procurmlstamp", "Txiva", "Tabiva", "Perdesc",
                    "Descontol", "Ivainc", "Factura","no","Nome","Fncstamp","Ststamp"
                };
                if (dtst.AsEnumerable().Any(x => x.Field<bool>("Factura").Equals(false)))
                {
                    var produtos = dtst.DefaultView.ToTable(true, campos).AsEnumerable().Where(x => x.Field<bool>("Factura").Equals(false)).CopyToDataTable();
                    var dc = new DataColumn { DataType = typeof(bool), ColumnName = "ok" };
                    produtos.Columns.Add(dc);
                    var dc2 = new DataColumn { DataType = typeof(bool), ColumnName = "facturado" };
                    produtos.Columns.Add(dc2);
                    var dc3 = new DataColumn { DataType = typeof(string), ColumnName = "familia" };
                    produtos.Columns.Add(dc3);
                    foreach (var r in produtos.AsEnumerable())
                    {
                        r["ok"] = false;
                        r["facturado"] = SQL.CheckExist($"select  top 1 quant " +
                                                        $"from(select quant = " +
                                                        $"isnull((select top 1 pl.Quant " +
                                                        $"from faccl fl join facc fc on " +
                                                        $"fl.Faccstamp = fc.Faccstamp where " +
                                                        $"fl.Ref = pl.Ref    and" +
                                                        $" Pjstamp = '{CLocalStamp.Trim()}'" +
                                                        $" and pl.no = '{r["no"].ToString().Trim()}'), pl.Quant)," +
                                                        $" Descricao, pl.Ref, pl.Nome, " +
                                                        $"pl.Preco, pl.Procurmlstamp," +
                                                        $" pl.Txiva, pl.Tabiva, pl.Perdesc," +
                                                        $" pl.Descontol, pl.Ivainc, pl.Factura," +
                                                        $" pl.No from Procurml pl where" +
                                                        $" Procurmstamp = '{CLocalStamp.Trim()}'" +
                                                        $" and pl.no = '{r["no"].ToString().Trim()}') temp " +
                                                        $" ");
                        var _qrt = $"select top 1 isnull(iif(Familia='','Não definida',Familia),'Não definida') Familia from fnc where no='{r["no"].ToString().Trim()}'";
                        var dtfam = SQL.GetGenDT(_qrt);
                        if (dtfam.Rows.Count > 0)
                        {
                            r["familia"] = dtfam.Rows[0][0].ToString();
                        }
                        else
                        {
                            r["familia"] = "Não definida";
                        }

                    }
                    if (produtos.AsEnumerable().Any(x => x.Field<bool>("facturado").Equals(true)))
                    {
                        produtos = produtos.AsEnumerable().
                            Where(x => x.Field<bool>("facturado").Equals(true)).CopyToDataTable();
                            var f = new FrmCp
                            {
                                ListaUsracessos = _lista,
                                Usracessos = _lista.First(),
                                Pjstamp = CLocalStamp,
                            };
                            f.ShowForm(this);
                            f.Origemsss = "teste";
                            f.EditMode = true;
                            f.CallBrowdoc();
                            f.btnPrdtProcurment.Visible = true;
                            f.btnNovo.PerformClick();
                            f.Tdocfcondicao = "sigla='FTF'";
                            f.tbPj.tb1.Text = tbDescricao.tb1.Text;
                            f.tbCcusto.tb1.Text = tbCcusto.tb1.Text;
                            f.tbPj.tb1.Text = tbDescricao.tb1.Text;
                            f.tbPj.Text3 = CLocalStamp;
                            f.tbPj.Text2 = tbReferenc.tb1.Text;
                            f.tbPj.button1.Enabled = false;
                            f.tbFornec.button1.Enabled = false;
                            f.Produtos(produtos);
                            f.SendRefresh = ReceiveRefresh;
                    }
                    else
                    {
                        MsBox.Show($" {Messagem.ParteInicial()} Não tem artigos para comprar!");
                    }
                }
                else
                {
                    MsBox.Show($" {Messagem.ParteInicial()} Não tem artigos para comprar! ");
                }
            }
            else
            {
                MsBox.Show($" {Messagem.ParteInicial()} Não é possivel facturar, a tabela do escopo esta vazia!");
            }
            }
            else
            {
                MsBox.Show($" {Messagem.ParteInicial()} Não é possivel facturar, Sem email dos fornecedores!");
            }
        }

        private void btnpgfEmitidos_Click(object sender, EventArgs e)
        {
            CallFormLista("tpgf", "Pgf", @"Todos os pagamentos emitidos".ToUpper());
        }
        private List<Usracessos> _lista;
        private void btnPrint_Click(object sender, EventArgs e)
        {
            MenuLateral.ShowMenuStrip(btnPrint);
        }

       
        private void btnPagarr_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                MsBox.Show(Messagem.ParteInicial() + "Desculpa, Tem de estar no modo de edição.");
                return;
            }
            var retorno = IsAllValido("trcl");
            if (!retorno.valido) return;
            _lista = retorno.lista;
            string cond = string.Empty;
            for (int i = 0; i < gridUIFt1.DtDS.Rows.Count; i++)
            {
                if (i == 0)
                {
                    if (!string.IsNullOrEmpty(gridUIFt1.DtDS.Rows[i]["no"].ToString()))
                    {
                        cond = $"'{gridUIFt1.DtDS.Rows[i]["no"]}'";
                    }
                }
                else
                {
                    if (!string.IsNullOrEmpty(gridUIFt1.DtDS.Rows[i]["no"].ToString()))
                    {
                        cond += $",'{gridUIFt1.DtDS.Rows[i]["no"]}'";
                    }
                }
            }
            var f = new FrmPgf2
            {
                ListaUsracessos = _lista,
                Usracessos = _lista.FirstOrDefault(),
                Fnc = SQL.GetRowToEnt<Fnc>($"Fncstamp ='{tbCliente.Text3}'"),//EF.GetEnt<Fnc>(x => x.Fncstamp.Equals(tbCliente.Text3))
            };
            f.ShowForm(this);
            f.btnNovo.PerformClick();
            f.Trclcondicao = "sigla='RC'";
            f.tbPj.tb1.Text = tbDescricao.tb1.Text;
            f.tbCcusto.tb1.Text = tbCcusto.tb1.Text;
            f.tbPj.tb1.Text = tbDescricao.tb1.Text;
            f.tbPj.Text3 = CLocalStamp;
            f.brrtextCliente.Visible = f.gridFormasCliente.Visible = false;
            f.tbPj.Text2 = tbReferenc.tb1.Text;
            if (!string.IsNullOrEmpty(cond))
            {
                f.tbFornec.Condicao = $"no in ({cond})";
            }
            f.tbPj.button1.Enabled = false;
            f.SendRefresh = ReceiveRefresh;
        }
        private void btnFact_Click(object sender, EventArgs e)
        {
            MenuFact.ShowMenuStrip(btnFact);
        }
        private void btnCompras_Click(object sender, EventArgs e)
        {
            MenuCompra.ShowMenuStrip(btnCompras);
        }
        private void btnRCL_Click(object sender, EventArgs e)
        {
            MenuReceber.ShowMenuStrip(btnRCL);
        }
        private void btnPagamentos_Click(object sender, EventArgs e)
        {
            MenuPgf.ShowMenuStrip(btnPagamentos);
        }

        ArrayList _aAnexosEmail;
        private void btnNotificarFrn_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                MsBox.Show(Messagem.ParteInicial() + "Desculpa, Tem de estar no modo de edição.");
                return;
            }
            var dtst = (DataTable)gridUIFt1.DataSource;
            dtst = dtst.AsEnumerable().
                Where(x => x.Field<string>("Email") != "")
                .CopyToDataTable();

            string datatable = string.Empty;
            var ret = string.Empty;
            var retev = string.Empty;
            try
            {
                var path = Application.StartupPath;
                foreach (var fileName in Directory.GetFiles(path))
                {
                    if (fileName.Contains("EmpresaSeleccionada"))
                    {
                        File.Delete(fileName);
                    }
                }
            }
            catch
            {
                //
            }
            for (int i = 0; i < dtst.Rows.Count; i++)
            {
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
                var campos = new[]
                {
                    "ref", "Descricao", "quant", "preco", "Procurmlstamp", "Txiva", "Tabiva", "Perdesc",
                    "Descontol", "Ivainc", "Factura","Nome","No","Email","Ststamp"
                };
                var i1 = i;
                if (i1 == 0)
                {
                    datatable += $"{dtst.Rows[i1]["No"]}";
                    var produtos = dtst.DefaultView.ToTable(true, campos).AsEnumerable()
                        .Where(x => x.Field<string>("No").Equals(dtst.Rows[i1]["No"].ToString())).CopyToDataTable();

                    produtos = produtos.AsEnumerable().Where(x => x.Field<string>("No").Equals(dtst.Rows[i1]["No"].ToString()))?.CopyToDataTable();

                    var pft = Application.StartupPath;
                    pft += $"\\EmpresaSeleccionada{dtst.Rows[i1]["No"]}.xlsx";
                    Helper.ExportToExcel(produtos, pft);
                    var email = dtst.Rows[i1]["email"].ToString();
                    ret = email;
                    var arr = pft.Split(';');
                    _aAnexosEmail = new ArrayList();
                    for (int k = 0; k < arr.Length; k++)
                    {
                        if (!string.IsNullOrEmpty(arr[k].Trim()))
                        {
                            _aAnexosEmail.Add(arr[k].Trim());
                        }
                    }

                    retev = EnviarEmail.EnviaEmail.EnviaMensagemComAnexos("",email, "Saudações!",
                        "A vossa empresa foi seleccionada para o fornecimento do(s) produto(s) em anexo",
                        _aAnexosEmail);
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
                    else if (retev.Contains($"The SMTP server requires a secure" +
                                            $" connection or the client was not " +
                                            $"authenticated"))
                    {
                        ret = $"Active a opção Acesso a app menos seguro da".ToUpper() +
                              $" sua Conta do Google!".ToUpper();// +
                                                                 //$" através do seguinte link ".ToUpper() +
                                                                 // $" https://support.google.com/accounts/answer/6010255?hl=pt#zippy=%2Cse-a-op%C3%A7%C3%A3o-acesso-a-app-menos-seguro-estiver-ativada-para-sua-conta";
                    }
                    else
                    {
                        ret = retev.ToUpper();
                    }
                }
                else
                {
                    var subs = datatable.Split(',');
                    bool existe = false;
                    for (var k = 0; k < subs.Length; k++)
                    {
                        if (subs[k].Equals(dtst.Rows[i1]["No"].ToString()))
                        {
                            existe = true;
                        }
                    }
                    if (!existe)
                    {
                        datatable += $",{dtst.Rows[i1]["No"]}";
                        var produtos = dtst.DefaultView.ToTable(true, campos).AsEnumerable()
                            .Where(x => x.Field<string>("No").Equals(dtst.Rows[i1]["No"].ToString())).CopyToDataTable();

                        produtos = produtos.AsEnumerable().Where(x => x.Field<string>("No").Equals(dtst.Rows[i1]["No"].ToString())).CopyToDataTable();

                        var pft = Application.StartupPath;
                        pft += $"\\EmpresaSeleccionada{dtst.Rows[i1]["No"]}.xlsx";
                        Helper.ExportToExcel(produtos, pft);
                        var email = dtst.Rows[i1]["email"].ToString();
                        ret += $"\r\n" + email;
                        var arr = pft.Split(';');
                        _aAnexosEmail = new ArrayList();
                        for (int k = 0; k < arr.Length; k++)
                        {
                            if (!string.IsNullOrEmpty(arr[k].Trim()))
                            {
                                _aAnexosEmail.Add(arr[k].Trim());
                            }
                        }
                        retev = EnviarEmail.EnviaEmail.EnviaMensagemComAnexos("",email, "Saudações!",
                            "A vossa empresa foi seleccionada para o fornecimento do(s) produto(s) em anexo",
                            _aAnexosEmail);
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
                        else if (retev.Contains($"The SMTP server requires a secure" +
                                                $" connection or the client was not " +
                                                $"authenticated"))
                        {
                            ret = $"Active a opção Acesso a app menos seguro da".ToUpper() +
                                  $" sua Conta do Google!".ToUpper();//+
                                                                     //  $" através do seguinte link ".ToUpper() +
                                                                     //  $" https://support.google.com/accounts/answer/6010255?hl=pt#zippy=%2Cse-a-op%C3%A7%C3%A3o-acesso-a-app-menos-seguro-estiver-ativada-para-sua-conta";
                        }
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
                ret = "Mensagem não enviada ".ToUpper() + ret.ToUpper() + ".";
                MessageBox.Show(ret, @"Aviso do sistema".ToUpper(), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            #region Quebrar todos ficheiros de Excel Criados ao enviar as mensages
            try
            {
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
                var path = Application.StartupPath;
                foreach (var fileName in Directory.GetFiles(path))
                {
                    if (fileName.Contains("EmpresaSeleccionada"))
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

        private void btnEnviarEmail_Click_1(object sender, EventArgs e)
        {
            MenuEmail.ShowMenuStrip(btnEnviarEmail);
            ChangeMel(btnEnviarEmail);
        }



        private void dgvComparativo_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            CelClick();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MenuLateral.ShowMenuStrip(button2);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                MsBox.Show(Messagem.ParteInicial() + "Desculpa, Tem de estar no modo de edição.");
                return;
            }
            var dt = SQL.GetGenDT($"select  Nome,No  from(select quant = isnull((select top 1 iif(pl.Quant>=fl.quant," +
                                  $"pl.Quant-fl.quant,pl.quant) from faccl fl join facc " +
                                  $"fc on fl.Faccstamp = fc.Faccstamp where fl.Ref " +
                                  $"= pl.Ref and Pjstamp = '{CLocalStamp}'), pl.Quant)," +
                                  $" Descricao, pl.Ref, pl.Nome, pl.Preco, pl.Procurmlstamp," +
                                  $" pl.Txiva, pl.Tabiva, pl.Perdesc, pl.Descontol, pl.Ivainc," +
                                  $" pl.Factura,pl.No,pl.PrazoEntrega from Procurml" +
                                  $" pl where Procurmstamp = '{CLocalStamp}' ) " +
                                  $"temp  WHERE quant>0 and PrazoEntrega<GETDATE() " +
                                  $"group by Nome,No");
            if (dt.Rows.Count > 0)
            {
                var bw = new FrmFncPrazo
                {
                     //SendData = dt
                };
                bw.Pjstamp = CLocalStamp;
                bw.BindiGrid(dt);
                bw.ShowForm(this, true);
            }
        }

        private void gridPanel24_AfterAddLineEvent()
        {
            if (gridUIFt1.CurrentRow != null)
            {
                gridUIFt1.CurrentRow.Cells["PrecoCompra"].Value = 0;
                gridUIFt1.CurrentRow.Cells["Perc"].Value = 0;
            }
        }

        private void status_Load(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {

        }

        private void btnImprirTd_Click(object sender, EventArgs e)
        {
           
        }

        private DataTable list;

        private string Filtro = string.Empty;
        private void Printing(string condicao="")
        {
            if (string.IsNullOrEmpty(CLocalStamp)) return;
            string rptnam = "RptPrc";
            var qr = $"  select ref Referenc,pjesc.Descricao,Inicio=CONVERT(char(12), Inicio, 104),Termino=CONVERT(char(12), Termino, 104),Duracao," +
                     "Subtotall,valival,Totall,Descontol,Codigo,pj.Nome,pj.Prov Morada, pj.Datini,pj.Datfim,pj.No Nomedoc from Procurml pjesc join Procurm Pj on " +
                     $" pj.Procurmstamp = pjesc.Procurmstamp  where pj.Procurmstamp='{CLocalStamp}' {condicao}";
            Filtro = "Lista de todos produtos".ToUpper();
            if (!string.IsNullOrEmpty(condicao))
            {
                Filtro = "FORNECEDORES QUE JÁ CUMPRIRAM COM A ENTREGA".ToUpper();
                qr = $"select  distinct Nome,email  " +
                     $"from(select quant = isnull((select top 1 iif(pl.Quant>=fl.quant,pl.Quant - fl.quant,pl.quant) from faccl fl join facc " +
                     $" fc on fl.Faccstamp = fc.Faccstamp where fl.Ref = pl.Ref and Pjstamp = '{CLocalStamp}'), pl.Quant)," +
                     $"Pj.Descricao, pl.Ref,  pl.Preco, pl.Procurmlstamp,pl.Txiva, pl.Tabiva, pl.Perdesc, pl.Descontol, pl.Ivainc," +
                     $"pl.Factura,pl.No,Inicio = CONVERT(char(12), Inicio, 104),Termino = CONVERT(char(12), Termino, 104),Duracao," +
                     $"pl.PrazoEntrega,Subtotall,valival,Totall,Codigo,pj.Nome,pj.Prov Morada, pj.Datini,pj.Datfim,pj.No Nomedoc,pl.Email from Procurml " +
                     $"pl join Procurm Pj on pj.Procurmstamp = pl.Procurmstamp where pl.Procurmstamp = '{CLocalStamp}' ) " +
                     $"temp WHERE quant =0 " +
                     $" group by Nome,email";
                rptnam = "RptPrcfnc";
            }
            var dtt = SQL.GetGen2DT(qr);
            if (dtt?.Rows.Count > 0)
            {
                try
                {
                    list = null;
                    list = dtt;
                }
                catch (Exception er)
                {
                    var err = er.Message;
                    //
                }
                if (list != null && list.Rows.Count > 0)
                {
                    //var p = new FrmReport
                    //{
                    //    Printstamp = _pj.Procurmstamp,
                    //    Origem = "PJ",
                    //    ReportName = rptnam.Trim(),
                    //    Dt = list,
                    //    CTituloRelatorio = tbDescricao.tb1.Text,
                    //    Filtro = Filtro,
                    //    EntidadePrint = "Exmo(a) sr(a): " + tbCliente.tb1.Text,
                    //    NomeProduto = "Morada: " + ucProvincia.tb1.Text
                    //};
                    //p.ShowForm(this);
                }
            }
            else
            {
                MsBox.Show("Estimado(a), não temos nada para imprimir!");
            }
        }
        private void toolStripMenuItem3_Click_1(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                MsBox.Show(Messagem.ParteInicial() + "Desculpa, Tem de estar no modo de edição.");
                return;
            }
            //cUMPRIRAM COM A ENTREGA
            Printing(" AND  quant=0");
            //"CONVERT(DATE,Termino)<GETDATE()";
        }

        private void btnAprovado_BackColorChanged(object sender, EventArgs e)
        {

            btnAprovado.Image = Properties.Resources.Stocks_32px;
        }

        private void btnAdministracao_BackColorChanged(object sender, EventArgs e)
        {
            btnAdministracao.Image = Properties.Resources.Home_25px;
        }

        void ChangeMel(Button button)
        {
            foreach (Control ctr in panel4.Controls)
            {
                var nome = ctr.Name;
                if (button.Name.Trim().Equals(nome.Trim()))
                {
                    button.BackColor = Color.DarkGoldenrod;
                }
                else
                {
                    ((Button)Controls.Find(nome.Trim(), true).FirstOrDefault()).BackColor = Color.FromArgb(34, 39, 49);
                }

            }
        }
      
        
        private void btnCliente_BackColorChanged(object sender, EventArgs e)
        {

            btnCliente.Image = Properties.Resources.person_32px;
        }

        private void btnEscopo_BackColorChanged(object sender, EventArgs e)
        {

            btnEscopo.Image = Properties.Resources.product_21px;
        }

        private void btnAnaliseProp_BackColorChanged(object sender, EventArgs e)
        {

            btnAnaliseProp.Image = Properties.Resources.account_21px;
        }

        private void btnComparativo_BackColorChanged(object sender, EventArgs e)
        {
            btnComparativo.Image = Properties.Resources.checkout_28px;
        }

        private void btnEnviarEmail_BackColorChanged(object sender, EventArgs e)
        {
            //btnEnviarEmail.Image = Properties.Resources.Squared_32px;
        }

        private void lISTAGEMSTANDARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EditMode)
            {
                MsBox.Show(Messagem.ParteInicial() + "Desculpa, Tem de estar no modo de edição.");
                return;
            }
            Printing();
        }
    }
}
