using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmPosDi : FrmClasse
    {
        public FrmPosDi()
        {
            InitializeComponent();
        }
        public Tdi TmpTdi { get; set; }
        public string Caixa { get; set; }

        private Di _di;
        private DataRow _dataRow;
        private DataTable _dtSt;
        private void btnTdi_Click(object sender, EventArgs e)
        {
            CallBrowdoc();
        }
        private void CallBrowdoc()
        {
            var bw = new Browdoc
            {
                Condicao = " where VisivelPOS=1",
                Descricao = @"descricao",
                Sigla = @"sigla",
                Tabela = @"tdi",
                BindTdoc = BindTdoc
            };
            bw.ShowDialog();
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
            if (TmpTdi!=null)
            {
                GenDi.SetEntidade(TmpTdi, tbEntidade);
                tbEntidade.Visible = !TmpTdi.Noentid;
                SetValues(TmpTdi);
                CCondicao = $"numdoc={TmpTdi.Numdoc} and year(data) = {Pbl.SqlDate.Year}"; 
            }
        }
        public override void UpdGridFormasp()
        {
            Helper.Codmovtz(TmpTdi.Movtz, TmpTdi.Codmovtz, TmpTdi.Descmovtz, gridFormasP1.Grelha,Name);

        }
        private void SetValues(Tdi tmpTdoc)
        {
            label1.Text = tmpTdoc.Descricao;
        }
        
        private void FrmPosDi_Load(object sender, EventArgs e)
        {
            Campo1 = "Numero";
            Campo2 = "nome";
            Ctabela = "di";
            TmpTdi = SQL.GetRowToEnt<Tdi>($"VisivelPos =1 and Defa =1");//EF.GetEnt<Tdi>(p=>p.VisivelPos.Equals(true) && p.Defa==true);

            RefreshControls();
            gridFormasP1.BindGridView(EditMode);
            CCondicao = $"numdoc={TmpTdi.Numdoc} and year(data) = {Pbl.SqlDate.Year}";
            MultiDoc = true;
        }
        public override void DefaultValues()
        {
            _di = GenDi.SetDiDefaultValues(_di, this, TmpTdi);
            tbCcusto.tb1.Text = Pbl.Usr.Ccusto;
            tbCcusto.Text2 = Pbl.Usr.Codtz.ToString();
            base.DefaultValues();
            tbNumdoc.IsReadOnly = TmpTdi.Alteranum;
            gridFormasP1.btnAdd.PerformClick();
           if (gridFormasP1.Grelha.CurrentRow != null) 
           {
               gridFormasP1.Grelha.CurrentRow.Cells["contatesoura"].Value = Caixa;
               gridFormasP1.Grelha.CurrentRow.Cells["Codtz"].Value = Pbl.Usr.Codtz;
               //gridFormasP1.Grelha.CurrentRow.Cells["titulo"].Value = "Numerário";
           }
           dmzGridButtons1.btnNovo.PerformClick();
        }

        public void NewGridLine()
        {
            _dataRow = Helper.NewGridRow(this);
        }
        public override void Save()
        {
            FillEntity(_di);
            EF.Save(_di);
        }
        public override bool BeforeSave()
        {
           // var retorno = true;
           _di.Data = dtDi.dt1.Value;
            #region Verificação de Stock dos produtos a serem facturados 
            var values = GenBl.CheckStock(_di, gridUIFt1.DsDt, false);
            if (!values.StkExiste)
            {
                MsBox.Show(values.Messagem);
                return values.StkExiste;
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

            #region Verificacao de formas de pagameto ou movimento de contas 
            (bool Correcto, string Messagem) vals;
            vals = GenBl.CheckTesoura(gridFormasP1.Formaspdt, _di.TrfConta ? _di.Total : tbTotal.tb1.Text.ToDecimal(), _di.Movtz);
            if (!vals.Correcto)
            {
                MsBox.Show(vals.Messagem);
                return vals.Correcto;
            }
            #endregion
            #region Verificacao de quantidades a transferir ....

            if (TmpTdi.Movtz && TmpTdi.Codmovtz>50)
            {
                vals=GenBl.CheckSaldo(gridFormasP1.Formaspdt);
                if (vals.Correcto) return true;
                MsBox.Show(vals.Messagem);
                return vals.Correcto;
            }
            #endregion
            return true;
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _di = FillControls(_di, dt, i);
            gridFormasP1.BindGridView(EditMode);
            //tbDesconto.tB1.Text.SetMask();
            //tbSubTotal.tB1.Text.SetMask();
            tbTotal.tb1.Text.SetMask();
            //tbTotalIva.tB1.Text.SetMask();
        }
        public override void Addline(string referenc)
        {
            if (!Procurou)
            {
                var tmpFound = SQL.GetRowToEnt<St>($" ltrim(rtrim(ststamp)) ='{referenc.Trim()}' ");
                GenBl.SetLineValues(_dataRow, tmpFound, _di,false,null,false,Pbl.MoedaBase,"","");
                //*----------------
                GenBl.TotaisLinhas(_dataRow);
                if (tmpFound.Composto)
                {
                    _dataRow["composto"] = tmpFound.Composto;
                    GenBl.ArtigoCompost(tmpFound, gridUIFt1.DsDt, _di);
                }
            }
            else
            {
                if (gridUIFt1.CurrentRow != null)
                    _dataRow = ((DataRowView)gridUIFt1.CurrentRow.DataBoundItem).Row;
                GenBl.TotaisLinhas(_dataRow);
            }
            //*----------------
            gridUIFt1.Update();
            Helper.TotaisFt(gridUIFt1.DsDt, this);
            if (!TmpTdi.Movtz) return;
            Helper.VendaDiheiro(gridUIFt1.DsDt, this, TmpTdi.Sigla,ucMoeda.tb1.Text);
            UpdGridFormasp();
        }

        private void gridUIFt1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name;
            if (nome.Equals("Descricao") || nome.Equals("ref1"))
            {
                _dataRow = ((DataRowView)gridUIFt1.CurrentRow.DataBoundItem).Row;
                _dtSt = Helper.EditingControlShowing(e, nome.ToLower()); 
            }
            else
            {
                _dtSt = null;
                var autoText = e.Control as TextBox;
                if (autoText != null) 
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
        }
        private void SetFactl(string campo)
        {
            if (gridUIFt1.CurrentCell.Value == null) return;
            var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
            var dr = _dtSt.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));
            if (dr != null)

                Addline(dr["Ststamp"].ToString().Trim());
        }

        private void gridUIFt1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            var name = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (name.Equals("quant") || name.Equals("preco"))
            {
                NVerificar = true;
            }
        }

        private void gridUIFt1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Helper.CellEnter(sender,e);
        }

        private void gridUIFt1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!NVerificar) return;
            NVerificar = false;
            if (TmpTdi.Movtz)
            {
                TmpTdi.Tipodoc = 2;
            }
            Helper.Totaislinha(true, gridUIFt1.DsDt, this,TmpTdi.Sigla);
        }
    }
}
