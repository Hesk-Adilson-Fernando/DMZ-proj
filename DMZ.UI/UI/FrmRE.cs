using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace DMZ.UI.UI
{
    public partial class FrmRe : FrmClasse
    {
        public FrmRe()
        {
            InitializeComponent();
        }
        private Tdi TmpTdi { get; set; }
        private DataTable DtShowControl { get; set; }
        public DataRow DataRow { get; set; }
        public bool LRunStk { get; set; }
        public bool Encomenda { get; set; }

        private Di _di;
        private void FrmRE_Load(object sender, EventArgs e)
        {
            Campo1 = "Numero";
            Campo2 = "nome";
            Ctabela = "di";
            TmpTdi = SQL.GetRowToEnt<Tdi>(" reserva=1");
            RefreshControls();
            CCondicao = $"numdoc={TmpTdi.Numdoc} and year(data) = {Pbl.SqlDate.Year}";
            MultiDoc = true;
        }

        public override void DefaultValues()
        {
            _di=GenDi.SetDiDefaultValues(_di,this,TmpTdi);
            _di.Reserva = TmpTdi.Reserva;
            _di.Encomenda = TmpTdi.Encomenda;
            NewGridLine();
            base.DefaultValues();           
        }

        public void NewGridLine()
        {
            DataRow = Helper.NewGridRow(this);
        }
        public override void Save()
        {
            FillEntity(_di);
            EF.Save(_di);
        }
        public override void AfterSave()
        {
            foreach (var row in gridUIFt1.DsDt.AsEnumerable())
            {
                if (row==null) continue;
                switch (TmpTdi.Tiposigla)
                {
                    case "CL":
                        SQL.SqlCmd($@"update st set reserva= reserva +{row["quant"].ToDecimal()} where Referenc='{row["ref"].ToString().Trim()}'");
                        SQL.SqlCmd($@"update starm set reserva= reserva +{row["quant"].ToDecimal()} where ref='{row["ref"].ToString().Trim()}' and Codarm={row["Armazem"].ToDecimal()}");
                        break;
                    case "FL":
                        SQL.SqlCmd($@"update st set encomenda= encomenda +{row["quant"].ToDecimal()} where Referenc='{row["ref"].ToString().Trim()}'");
                        SQL.SqlCmd($@"update starm set encomenda= encomenda +{row["quant"].ToDecimal()} where ref='{row["ref"].ToString().Trim()}' and Codarm={row["Armazem"].ToDecimal()}");
                        break;
                }
            }
            base.AfterSave();
        }
        public override bool BeforeSave()
        {
            // var retorno = true;
            _di.Data = dtDi.dt1.Value;
            #region Verificação de Stock dos produtos a serem facturados

            if (TmpTdi.Reserva)
            {
                var values = GenBl.CheckStock(gridUIFt1.DsDt);
                if (!values.StkExiste)
                {
                    MsBox.Show(values.Messagem);
                    return values.StkExiste;
                }
            }
            #endregion

            #region Verifica o preenchimento da entidade 
            if (!TmpTdi.Noentid)
            {
                if (string.IsNullOrEmpty(tbEntidade.tb1.Text))
                {
                    MsBox.Show($"Por favor o campo {tbEntidade.label1.Text} não pode estar vazio");
                    return false;
                }
            }
            #endregion
            return true;
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _di = FillControls(_di, dt, i);
            tbDesconto.tb1.Text.SetMask();
            tbSubTotal.tb1.Text.SetMask();
            tbTotal.tb1.Text.SetMask();
            tbTotalIva.tb1.Text.SetMask();
        }
        public override void Addline(string referenc)
        {
            if (!Procurou)
            {
                var tmpFound = SQL.GetRowToEnt<St>( $" ltrim(rtrim(ststamp)) ='{referenc.Trim()}' ");
                //GenBl.SetLineValues(DataRow, tmpFound,_di,TmpTdi.Tiposigla != "CL");
                //*----------------
                GenBl.TotaisLinhas(DataRow);
                if (tmpFound.Composto)
                {
                    DataRow["composto"] = tmpFound.Composto;
                    GenBl.ArtigoCompost(tmpFound, gridUIFt1.DsDt,_di);
                }
            }
            else
            {
                if (gridUIFt1.CurrentRow != null)
                    DataRow = ((DataRowView)gridUIFt1.CurrentRow.DataBoundItem).Row;
                GenBl.TotaisLinhas(DataRow);
            }
            //*----------------
            gridUIFt1.Update();
            Helper.TotaisFt(gridUIFt1.DsDt, this);
            if (!TmpTdi.Movtz) return;
            Helper.VendaDiheiro(gridUIFt1.DsDt, this,TmpTdi.Sigla,ucMoeda.tb1.Text);
            UpdGridFormasp();
        }
        private void btnTdi_Click(object sender, EventArgs e)
        {
            if (Procurou && Lista == null)
            {
                CallBrowdoc();
            }
            else
            {
                if (!EditMode)
                {
                    CallBrowdoc();
                }
                else
                {
                    MsBox.Show("O formulário está em modo de edição. Porfavor Grave");
                }
            }


        }
        private void CallBrowdoc()
        {
            var bw = new Browdoc
            {
                Condicao = "where reserva=1 or encomenda=1",
                Descricao = @"descricao",
                Sigla = @"sigla",
                Tabela = @"tdi",
                BindTdoc = BindTdoc
            };
            bw.ShowForm(this, true);
        }

        public void BindTdoc(DataRow tdoc, bool origem = false)
        {
            if (tdoc == null) return;
            TmpTdi = tdoc.DrToEntity<Tdi>();
            RefreshControls();
            Helper.ClearControls(this);
        }
        private void RefreshControls()
        {
            GenDi.SetEntidade(TmpTdi, tbEntidade);
            label1.Text = TmpTdi.Descricao;
            CCondicao = $"numdoc={TmpTdi.Numdoc} and year(data) = {Pbl.SqlDate.Year}";
        }

        private void gridUIFt1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!EditMode) return;
            if (gridUIFt1.CurrentRow == null) return;
            Helper.CellValueChanged(gridUIFt1.CurrentCell, this);
        }

        private void gridUIFt1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("descricao") || nome.Equals("ref1"))
            {
                //DataRow = ((DataRowView)gridUIFt1.CurrentRow.DataBoundItem).Row;
                DtShowControl = Helper.EditingControlShowing(e,nome);
            }
            else
            {
                DtShowControl = null;
                var autoText = e.Control as TextBox;
                autoText.AutoCompleteCustomSource = null;
            }
        }

        private void gridUIFt1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("descricao"))
            {
                SetFactl("descricao");
            }
            if (nome.Equals("ref1"))
            {
                SetFactl("Referenc");
            }
            if (nome.Equals("arm"))
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
            var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
            var dr = DtShowControl.AsEnumerable().FirstOrDefault(s => s.Field<string>(referenc).Trim().Equals(valor));
            if (dr == null) return;
            switch (referenc)
            {
                case "descricao":
                    if (gridUIFt1.CurrentRow != null)
                        gridUIFt1.CurrentRow.Cells["Armazem"].Value = dr[0].ToString();
                    break;
                default:
                    if (gridUIFt1.CurrentRow != null)
                        gridUIFt1.CurrentRow.Cells["arm"].Value = dr[1].ToString();
                    break;
            }
            gridUIFt1.Update();
        }
        private void SetFactl(string campo)
        {
            var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
            var dr = DtShowControl?.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));
            if (dr != null)
                Addline(dr["Ststamp"].ToString().Trim());
        }

        private void gridUIFt1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUIFt1.CurrentCell.OwningColumn.Name.Trim().ToLower().Equals("tabiva")) return;
            Helper.CellEnter(sender, e);
        }

        private void gridUIFt1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!NVerificar) return;
            NVerificar = false;
            Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdi.Sigla);
        }

        private void gridUIFt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (nome.Equals("ivainc"))
            {
                gridUIFt1.CurrentCell.Value = !gridUIFt1.CurrentCell.Value.ToBool();
                gridUIFt1.Update();
                Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdi.Sigla);
            }

            //if (nome.Equals("origem"))
            //{
            //    var ccstamp = gridUIFt1.CurrentRow.Cells["ccstamp"].Value.ToString();
            //    if (string.IsNullOrEmpty(ccstamp)) return;
            //    var dt = SQLExec.GetGenDT("fact", $" where factstamp='{ccstamp}'", "*");
            //    var fact = new FrmFt();
            //    fact.UpdateObjects(dt);
            //    fact.Procurou = true;
            //    fact.ShowForm(this);
            //    fact.PreencheCampos(dt, 0);
            //}
        }

        private void gridUIFt1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            if (!nome.Equals("tabiva")) return;
            var f = new ShowItem
            {
                MdiParent = MdiParent,
                Condicao = "where tabela = 5",
                Selected = "CODIGO, Descricao",
                Tabela = "Auxiliar",
                Sender = Receive
            };
            f.ShowForm(this, new Point(624, 345));
        }
        public void Receive(DataGridViewRow dr)
        {
            if (gridUIFt1.CurrentRow == null) return;
            gridUIFt1.CurrentRow.Cells["TabIVA"].Value = dr.Cells[0].Value;
            gridUIFt1.CurrentRow.Cells["txiva"].Value = dr.Cells[1].Value;
            Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdi.Sigla);
        }

        private void gridUIFt1_MouseDown(object sender, MouseEventArgs e)
        {
            if (gridUIFt1.Rows.Count <= 0) return;
            // Load context menu on right mouse click
            DataGridView.HitTestInfo hitTestInfo;
            if (e.Button != MouseButtons.Right) return;
            hitTestInfo = gridUIFt1.HitTest(e.X, e.Y);
            gridUIFt1.Rows[hitTestInfo.RowIndex].Selected = true;
            var rowIndex = hitTestInfo.RowIndex;
            // If column is first column
            if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                DeleteRow.Show(gridUIFt1, new Point(e.X, e.Y));
        }

        private void gridUIFt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            NewGridLine();
            gridUIFt1.CurrentCell = gridUIFt1.Rows[gridUIFt1.Rows.Count - 1].Cells["Descricao"];
        }

        private void btnFacturar_Click(object sender, EventArgs e)
        {
            if (TmpTdi.Reserva)
            {
                var fact = new FrmFt();
                fact.ShowForm(this);
                fact.TmpTdoc = SQL.GetRowToEnt<Tdoc>($"Ft=1"); //EF.GetEnt<Tdoc>(p=>p.Ft.Equals(true));
                fact.OrigReserva = true;
                fact.btnNovo.PerformClick();
                fact.UpdateObject(_di,gridUIFt1.DsDt);
            }

            if (TmpTdi.Encomenda)
            {
                var cp = new FrmCp();
                cp.ShowForm(this);
                cp.TmpTdoc = SQL.GetRowToEnt<Tdocf>($"Ft=1");//EF.GetEnt<Tdocf>(p=>p.Ft.Equals(true));
                cp.OrigReserva = true;
                cp.btnNovo.PerformClick();
                cp.UpdateObjects(_di,gridUIFt1.DsDt);
            }
        }

        private void btnPrint_Click_1(object sender, EventArgs e)
        {
            if (_di==null) return;
            //var p = new FrmReport
            //{
            //    Printstamp = _di.Distamp, Origem = "DI", ReportName = TmpTdi.Nomfile.Trim(), Dt = null
            //};
            //p.ShowForm(this);

            //DS ds = new DS();
            //var ret = Imprimir.FillData(null, dt, null, ds.DMZ, null);
            //Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false, label1.Text, "", TmpTdi.Nomfile.Trim(), "RLT", this, "", false, ds, $"Cliente: {txtNome.Text} \r\n Período: {dtpData1.Value.Date.ToShortDateString()} -{dtpData2.Value.Date.ToShortDateString()}", "Extrato de produtos vendidos ao Cliente");
        }

        public void UpdateObjects(DataTable dt)
        {
            if (_di==null)
            {
                _di = new Di(); 
            }
            // var numdoc = dt.Rows[0]["Numdoc"].ToDecimal();
           TmpTdi = Encomenda ? SQL.GetRowToEnt<Tdi>($"Encomenda={Encomenda}") : SQL.GetRowToEnt<Tdi>($"Reserva=1");// EF.GetEnt<Tdi>(p=>p.Reserva.Equals(true));
            
            panel1.Visible = false;
            panel3.Visible = false;
        }
    }
}
