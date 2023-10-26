using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI.Contabil
{
    public partial class FrmLContab : FrmClasse
    {
        private DataTable _dtconta;
        private Moedas _m;
        public Lcont Lc;
        private Diario _di;
        private Dc _d;
        public decimal Dino { get; set; }
        public string CondMax { get; set; }

        public FrmLContab()
        {
            InitializeComponent();
        }

        private void FrmLCont_Load(object sender, EventArgs e)
        {
            Ctabela = "Lcont";
            Campo1 = "Dilno";
            Campo2 = "Dinome";
            CCondicao = "Ano=(select ano from param )";
        }

        public override void DefaultValues()
        {
            Lc = DoAddline<Lcont>();
            var cond = Dino == 0
                ? $"defeito =1 and diano ={Pbl.AnoContabil()}"
                : $"dino ={Dino} and diano ={Pbl.AnoContabil()}";
            SetDefaults(cond,true);
            dtData.dt1.Value = Pbl.DataContabil();
            numericAno.Value = Pbl.DataContabil().Year;
            numericMes.Value = Pbl.DataContabil().Month;
            numericDia.Value = Pbl.DataContabil().Day;
            _m = GenBl.GetDefaultMoeda();
            if (_m == null) return;
            ucMoeda.tb1.Text = _m.Moeda.Trim();
            ucMoeda.Text2 = _m.Descricao.Trim();
        }

        private void SetDefaults(string cond,bool origem=false)
        {
            SetNumero(cond,origem);
            if (_di == null) return;
            ucDiario.tb1.Text = _di.Descricao;
            ucDiario.Text2 = _di.Dino.ToString();
            Lc.Docno = _di.Dino;
            tbAdoc.tb1.Text = "";
            ucDoc.tb1.Text="";
            ucDoc.Text2="";
            if (_di.Docno == 0) return;
            _d = SQL.GetRowToEnt<Dc>($"Diario.diariostamp ={_di.Diariostamp} and Padrao=1", "Diariodoc join Diario on diario.Diariostamp = Diariodoc.Diariostamp");
            GetDocumento();
            ucDoc.tb1.Text = _d.Docnome;
            ucDoc.Text2 = _d.Docno.ToString();
            ucDoc.Condicao = $"Diario.diariostamp ='{ucDiario.Text3}'";

        }

        private void SetNumero(string cond, bool origem = false)
        {
            if (ucDiario.Text3.IsNullOrEmpty()) return;
            _di = SQL.GetRowToEnt<Diario>(origem ? $"{cond}" : $" diariostamp ='{ucDiario.Text3.Trim()}'") ;   //EF.QEnt<Diario>(origem ? $"{cond}" : $" diariostamp ='{ucDiario.Text3.Trim()}'");
            if (_di == null) return;
            CondMax = $"docno ={_di.Dino}";
            var str = $"SELECT dbo.func_GenNumber({_di.Dino},{numericMes.Value},{numericAno.Value})";
            var maximo = SQL.SQLExecScalar(str);
            tbNumero.tb1.Text = maximo.ToString();
            var dt = GridMovim.GetBindedTable();
            if (!dt.HasRows()) return;
            foreach (var r in dt.AsEnumerable())
            {
                r["mes"] = numericMes.Value;
                UpdateData(r);
            }
        }

        private void GetDocumento()
        {
            //GridMovim.DtDS.Rows.Clear();
            if (_d.Pedeval)
            {
                var pd = new Pedeval
                {
                    MdiParent = ParentForm,
                    PControl = InserirLinhaGrid,
                    StartPosition = FormStartPosition.Manual,
                    Location = new Point(500, 100)
                };
                pd.Show();
            }
            else
            {
                var dt = SQL.GetGen2DT($"dcstamp='{_d.Dcstamp.Trim()}'");// EF.GetAll<Dcli>(x => x.dcstamp.Equals(_d.Dcstamp.Trim()));
                var lista = dt.DtToList<Dcli>();
                if (lista == null) return;
                if (lista.ToList().Count <= 0) return;
                FillGrid(lista.ToList(),0);
                GridMovim.Update();
                ExecTotais(2);
                tbCred.InPutMask = true;
                tbDeb.InPutMask = true;
            }
        }

        private void ExecTotais(int colIndex)
        {
            if (colIndex == 2 || colIndex == 3)
            {
                Totais();
            }
        }

        public void Totais()
        {
            var cre = Math.Round(GridMovim.DtDS.Sum("cre").ToDecimal(), (int)Pbl.Param.Aredondamento).ToString();
            tbCred.tb1.Text = cre.SetMask();
            var deb = Math.Round(GridMovim.DtDS.Sum("deb").ToDecimal(), (int)Pbl.Param.Aredondamento).ToString();
            tbDeb.tb1.Text = deb.SetMask();
        }

        public string Abreviatura { get; set; }

        private void InserirLinhaGrid(decimal valor)
        {
            if (valor == 0) return;
            var lista = SQL.GetGen2DT($"select * from Dcli where dcstamp='{_d.Dcstamp.Trim()}'").DtToList<Dcli>(); //EF.GetAll<Dcli>(x => x.dcstamp.Equals(_d.Dcstamp.Trim()), null, null);
            if (lista == null) return;
            FillGrid(lista.ToList(),valor);
            Totais();
        }

        public override void Save()
        {
            base.Save();
            FillEntity(Lc);
            if (!Cancelado)
            {
                Lc.Ano = numericAno.Value;
                Lc.Dia = numericDia.Value;
                Lc.Mes = numericMes.Value;
                EF.Save(Lc);
                GenBl.ExecAudit(Lc, "Lcont", true);
            }
        }
        public override void AfterSave()
        {
            //UpdateDiario();
            if (!ContaIvaAntestamp.IsNullOrEmpty())
            {
                SQL.SqlCmd($"update ml set processado =1 where mlstamp='{ContaIvaAntestamp.Trim()}'");
            }
            //var dt = GridMovim.GetBindedTable();
            ContaIvaAntestamp = "";
        }

        private void UpdateDiario()
        {
            var drTotal = SQL.GetRow($"select  deb= sum(Debfin),cre=sum(Crefin) from Lcont where Lcont.Diariostamp='{ucDiario.Text3.Trim()}'");
            if (drTotal != null)
            {
                SQL.SqlCmd($"update Diario set deb= {drTotal["deb"].ToDecimal()},cre={drTotal["cre"].ToDecimal()} where Diariostamp='{ucDiario.Text3.Trim()}'");
            }
        }

        public override bool BeforeDelete()
        {
            if (!Lc.Apuraiva) return true;
            //var dr = SQL.GetRow("select cc2 from Apparam where Origem='IVA'");
            //if (dr.DataRowIsNull()) return true;
            var dt = GridMovim.GetBindedTable();
            foreach (var r in dt.AsEnumerable())
            {
                if (!r["Oristampl"].ToString().IsNullOrEmpty())
                {
                    SQL.SqlCmd($"update ml set processado =0 where mlstamp='{r["Oristampl"].ToString().Trim()}'");
                }
            }
            return base.BeforeDelete(); 
        }

        protected override void OnAfterDelete()
        {
            UpdateDiario();
           GridMovim.BindGridView();

        }

        public override bool BeforeSave()
        {
            if (tbCred.tb1.Text.IsNullOrEmpty() || tbDeb.tb1.Text.IsNullOrEmpty())
            {
                MsBox.Show(Messagem.ParteInicial()+"Desculpa mas não pode gravar documento com totais nulos");
                return false;
            }
            if (tbCred.tb1.Text.ToDecimal() != tbDeb.tb1.Text.ToDecimal())
            {
                MsBox.Show(Messagem.ParteInicial() + "Desculpa o valor do débito não pode ser diferente do crédito");
                return false;
            }
            if (ucDiario.tb1.Text.IsNullOrEmpty())
            {
                MsBox.Show(Messagem.ParteInicial() + "Desculpa deve indicar o diário!");
                return false;
            }
            if (ucDoc.tb1.Text.IsNullOrEmpty())
            {
                MsBox.Show(Messagem.ParteInicial() + "Desculpa deve indicar o documento!");
                return false;
            }
            var val = ValidaContas();
            if (!val.retorno)
            {
                MsBox.Show(Messagem.ParteInicial() + val.mensagem);
                return false;
            }
            return true;
        }

        private (bool retorno,string mensagem) ValidaContas()
        {
            var dt = GridMovim.GetBindedTable();
            if (dt.HasRows())
            {
                foreach (var r in dt.AsEnumerable())
                {
                    if (r == null) continue;
                    if (!SQL.CheckExist("conta","pgc",$" conta='{r["conta"].ToTrim()}' and ano =(select ano from param)"))
                    {
                        return (false, $"A Conta {r["conta"].ToTrim()}, não existe, impossivel gravar!");
                    }
                }
            }
            else
            {
                return (false,"A Grelha de lancamento não tem linhas, não é possivel gravar!");
            }

            return (true,"");
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            Lc = FillControls(Lc, dt, i);
            numericAno.Value = Lc.Ano;
            numericMes.Value = Lc.Mes;
            numericDia.Value = Lc.Dia;
        }

        private void dgvML_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (GridMovim.CurrentRow == null) return;
            var lista = new List<Ec>{new Ec{Conta=true,Nome="ClnConta"},new Ec{Conta=false,Nome="descricao"}};
               _dtconta = Ct.EditControl(GridMovim.CurrentCell, e,lista);
        }

        private void dgvML_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (GridMovim.CurrentRow == null) return;
            Ct.CellEndEdit(GridMovim, _dtconta,new List<string>{"descricao","clnconta"}, Inserindo);
            GridMovim.CurrentRow.Cells["deb"].Value.ToDecimal();
            //var nome = GridMovim.CurrentCell.OwningColumn.Name.ToLower();
            var deb = GridMovim.CurrentRow.Cells["deb"].Value.ToDecimal();
            var cre = GridMovim.CurrentRow.Cells["cre"].Value.ToDecimal();
            UpdateValue(GridMovim.CurrentRow);
            //if (!nome.Equals("deb") && !nome.Equals("cre")) return;
            if (GridMovim.CurrentRow.Cells["clnconta"].Value !=null)
            {
                var conta = GridMovim.CurrentRow.Cells["clnconta"].Value.ToString().Trim();
                if (!conta.IsNullOrEmpty())
                {
                    var dt = SQL.GetGen2DT($"select moviva,contaiva,taxaiva from pgc where ano =(select ano from param) and conta ='{conta}'");
                    if (!(dt?.Rows.Count > 0)) return;
                    var moviva = dt.Rows[0]["moviva"].ToBool();
                    var taxaiva = dt.Rows[0]["taxaiva"].ToDecimal();
                    if (moviva)
                    {
                        var pc = SQL.GetRowToEnt<Pgc>($"Conta='{dt.Rows[0]["contaiva"].ToString().Trim()}'");//EF.GetEnt<Pgc>(x => x.Conta.Trim().Equals(dt.Rows[0]["contaiva"].ToString().Trim()));
                        if (pc != null)
                        {
                            gridPanel21.btnNovo.PerformClick();
                            var index = GridMovim.Rows.Count - 1;
                            GridMovim.Rows[index].Cells["ClnConta"].Value = pc.Conta;
                            GridMovim.Rows[index].Cells["descricao"].Value = pc.Descricao;
                            GridMovim.Rows[index].Cells["deb"].Value = deb * taxaiva / 100;
                            GridMovim.Rows[index].Cells["cre"].Value = cre * taxaiva / 100;
                        }
                    }
                }
                //dgvEndEditCell = GridMovim[e.ColumnIndex, e.RowIndex];
                //if (GridMovim.Rows.Count - 1 == e.RowIndex && e.ColumnIndex != GridMovim.Columns.Count - 1)
                //{
                //    GridMovim.CurrentCell = GridMovim[e.ColumnIndex + 1, e.RowIndex];
                //}
            }
            Totais();
        }

        private void dgvML_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex != 0 && e.ColumnIndex != 1) return;
            if (GridMovim.CurrentRow == null) return;
            Ct.CallQuerryForm(this);
        }

        public override void UpdateGrid(DataRow dr)
        {
            if (GridMovim.CurrentRow != null)
            {
                GridMovim.CurrentRow.Cells["clnconta"].Value = dr[0];
                GridMovim.CurrentRow.Cells["descricao"].Value = dr[1];
            }
            GridMovim.Update();
        }

        private void ucDiario_RefreshControls()
        {
            SetDefaults($"diariostamp ={ucDiario.Text3}");
            ucDoc.Condicao = $"Diario.diariostamp ='{ucDiario.Text3}'";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            Cursor = Cursors.WaitCursor;
            if (string.IsNullOrEmpty(CLocalStamp)) return;
            DS ds = new DS();
            var ml = GridMovim.GetBindedTable();
            var ret = Imprimir.FillData(Lc.ToDataTable(), ml, null, ds.LCont,null);
            Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, Inserindo, label1.Text, "", "LancamCont", "LCont", this, "", true, ds, "", "");
            Cursor = Cursors.Default;
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            dmzContextMenuStrip1.ShowMenuStrip(btnDetails);
        }

        private void gridPanel21_AfterAddLineEvent()
        {
            if (GridMovim.Rows.Count <= 0) return;
            if (GridMovim.CurrentRow != null)
            {
                GridMovim.CurrentRow.Cells["dia"].Value = numericDia.Value;
                GridMovim.CurrentRow.Cells["mes"].Value = numericMes.Value;
                GridMovim.CurrentRow.Cells["ano"].Value = numericAno.Value;
                GridMovim.CurrentRow.Cells["paistamp"].Value = "";
                GridMovim.CurrentRow.Cells["Bastamp"].Value = "";
                GridMovim.CurrentRow.Cells["oristamp"].Value = "";
            }
            var index = GridMovim.Rows.Count - 1;
            GridMovim.CurrentCell = GridMovim.Rows[index].Cells["ClnConta"];
            GridMovim.BeginEdit(true);
        }

        private void ucDoc_RefreshControls()
        {
            if (Procurou)
            {
                var dr = MsBox.Show(Messagem.ParteInicial()+"Deseja eliminar os movimentos anteriores a esse?",DResult.YesNo);
                if (dr.DialogResult != DialogResult.Yes) return;
                SQL.SqlCmd($"delete from ml where lcontstamp='{CLocalStamp.Trim()}'");
                Processar();
            }
            else
            {
                Processar();    
            }
        }

        private void Processar()
        {
            GridMovim.DtDS.Rows.Clear();
            tbAdoc.tb1.Text = "";
            _d = SQL.GetRowToEnt<Dc>($"Docno={ucDoc.Text2.ToDecimal()}"); //EF.GetEnt<Dc>(x => x.Docno.Equals(ucDoc.Text2.ToDecimal()));
            if (_d == null) return;
            if (_d.Pedeval)
            {
                var pd = new Pedeval
                {
                    MdiParent = ParentForm,
                    PControl = InserirLinhaGrid
                };
                pd.ShowForm(this, true);
            }
            else
            {
                var dt = SQL.GetGenDT($"select * from dcli where dcstamp=(select dcstamp from dc where docno ={ucDoc.Text2})");
                if (dt?.Rows.Count > 0)
                {
                    var lista = dt.DtToList<Dcli>();
                    FillGrid(lista, 0);
                }
                Totais();
            }
        }

        private void FillGrid(List<Dcli> lista,decimal valor)
        {
            if (lista == null) return;
            //de value = valor;
            
            foreach (var c in lista)
            {
                Thread.Sleep(100);
                var dr = GridMovim.DtDS.NewRow().Inicialize();
                dr["conta"] = c.conta;
                dr["descricao"] = c.rubrica;
                dr["mes"] = numericMes.Value;
                dr["dia"] = numericDia.Value;
                dr["Ano"] = numericAno.Value;
                dr["data"] = dtData.dt1.Value;
                dr["descritivo"] = Abreviatura + " N°" + tbAdoc.tb1.Text.Trim();

                dr["Dilno"] = tbNumero.tb1.Text;
                dr["Dinome"] = ucDiario.tb1.Text;
                dr["Docnome"] = ucDoc.tb1.Text;
                dr["Docno"] = ucDoc.Text2;
                dr["Dino"] = ucDiario.Text2;

                if (c.deb)
                {
                    //                    dr["deb"] = valor==0? c.valor: valor.GetDecimalPart() == 0?(c.factor * valor).ToRound(0): (c.factor * valor).ToRound((int)Pbl.Param.Aredondamento);
                    dr["deb"] = valor==0? c.valor:(c.factor * valor).ToRound((int)Pbl.Param.Aredondamento);
                    dr["cre"] = 0;
                }
                else
                {
                   // dr["cre"] = valor == 0 ? c.valor : valor.GetDecimalPart() == 0 ? (c.factor * valor).ToRound(0) : (c.factor * valor).ToRound((int)Pbl.Param.Aredondamento);
                    dr["cre"] = valor==0? c.valor: (c.factor * valor).ToRound((int)Pbl.Param.Aredondamento);
                    dr["deb"] = 0;
                }
                dr["Lcontstamp"] = CLocalStamp;
                GridMovim.DtDS.Rows.Add(dr);
            }

        }

        private void GridMovim_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Helper.CellEnter(sender,e);
        }

        private void tbAdoc_TextChangValues()
        {
            if (GridMovim.Rows.Count <= 0) return;
            foreach (DataGridViewRow c in GridMovim.Rows)
            {
                UpdateValue(c);
            }
        }

        private void UpdateValue(DataGridViewRow c)
        {
            c.Cells["clnDescMov"].Value = "Nº" + " " + tbAdoc.tb1.Text;
            c.Cells["Dinome"].Value = ucDiario.tb1.Text;
            c.Cells["Dilno"].Value = tbNumero.tb1.Text;
            c.Cells["Docnome"].Value = ucDoc.tb1.Text;
            c.Cells["Docno"].Value = ucDoc.Text2; 
            c.Cells["Dino2"].Value = ucDiario.Text2; 
        }

        private void btnMovimentosLancados_Click(object sender, EventArgs e)
        {
            var w = new Lc();
            w.ShowForm(this, true);
        }

        private void GridMovim_MouseDown(object sender, MouseEventArgs e)
        {
            //if (EditMode) return;
            if (e.Button != MouseButtons.Right) return;
            var hittestinfo = GridMovim.HitTest(e.X, e.Y);
            if (hittestinfo == null || hittestinfo.Type != DataGridViewHitTestType.Cell) return;
            ActiveCell2 = GridMovim[hittestinfo.ColumnIndex, hittestinfo.RowIndex];
            //var nome = ActiveCell2.OwningColumn.Name;
            //if (!nome.Equals("Reservado") && !nome.Equals("Encomendado")) return;
            ActiveCell2.Selected = true;
            if (GridMovim.CurrentRow != null)
            {
                var value = GridMovim.CurrentRow.Cells["ClnConta"].Value;
                dmzMenuLinhas.Items["toolStripExtrato"].Text = $@"Extrato da conta: {value}";
                dmzMenuLinhas.Items["toolStripApagar"].Text = $@"Apagar a conta: {value}";
            }
            dmzMenuLinhas.Show(GridMovim,new Point(e.X,e.Y));
        }

        public DataGridViewCell ActiveCell2 { get; set; }
        private void toolStripExtrato_Click(object sender, EventArgs e)
        {
            var w = new PgcExtrato();
            if (GridMovim.CurrentRow != null)
            {
                w.Conta = GridMovim.CurrentRow.Cells["ClnConta"].Value.ToString();
                w.Descritivo = GridMovim.CurrentRow.Cells["descricao"].Value.ToString();
            }
            w.ShowForm(this, true);
        }
        private void toolStripApagar_Click(object sender, EventArgs e)
        {
           gridPanel21.btnDell.PerformClick();
           
        }
        private void dtData_DateChangValues()
        {
            if (GridMovim.Rows.Count <= 0) return;
            foreach (DataGridViewRow r in GridMovim.Rows)
            {
                if (r == null) continue;
                r.Cells["dia"].Value = dtData.dt1.Value.Day;
                r.Cells["mes"].Value = dtData.dt1.Value.Month;
                r.Cells["data"].Value = dtData.dt1.Value;
            }

        }

        private void ucDoc_CondicaProcura()
        {
            ucDoc.Condicao = $"Diario.diariostamp ='{ucDiario.Text3.Trim()}'";
        }

        private void GridMovim_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Enter) return;
            e.SuppressKeyPress = true;
            var iColumn = GridMovim.CurrentCell.ColumnIndex;
            var iRow = GridMovim.CurrentCell.RowIndex;
            if (iColumn == GridMovim.Columns.Count - 1 && iRow != GridMovim.Rows.Count - 1)
            {
                GridMovim.CurrentCell = GridMovim[0, iRow + 1];
            }
            else if (iColumn == GridMovim.Columns.Count - 1 && iRow == GridMovim.Rows.Count - 1)
            {
            }
            else
            {
                GridMovim.CurrentCell = GridMovim[iColumn + 1, iRow];
            }
        }
        private DataGridViewCell dgvEndEditCell;
        private bool _EnterMoveNext = true;

        [System.ComponentModel.DefaultValue(true)]
        public bool OnEnterKeyMoveNext
        {
            get => _EnterMoveNext;
            set => _EnterMoveNext = value;
        }

        public string ContaIvaAntestamp { get; set; }

        private void GridMovim_SelectionChanged(object sender, EventArgs e)
        {
            if (!_EnterMoveNext || MouseButtons != 0) return;
            if (dgvEndEditCell != null && GridMovim.CurrentCell != null)
            {
                if (GridMovim.CurrentCell.RowIndex == dgvEndEditCell.RowIndex + 1
                    && GridMovim.CurrentCell.ColumnIndex == dgvEndEditCell.ColumnIndex)
                {
                    int iColNew;
                    int iRowNew;
                    if (dgvEndEditCell.ColumnIndex >= GridMovim.ColumnCount - 1)
                    {
                        iColNew = 0;
                        iRowNew = GridMovim.CurrentCell.RowIndex;
                    }
                    else
                    {
                        iColNew = dgvEndEditCell.ColumnIndex + 1;
                        iRowNew = dgvEndEditCell.RowIndex;
                    }
                    GridMovim.CurrentCell = GridMovim[iColNew, iRowNew];
                }
            }
            dgvEndEditCell = null;
        }

        private bool gridPanel21_BeforeAddLineEvent()
        {
            if (!ucDoc.tb1.Text.IsNullOrEmpty()) return false;
            MsBox.Show(Messagem.ParteInicial()+"Deve indicar o documento!");
            return true;
        }

        private void numericMes_ValueChanged(object sender, EventArgs e)
        {
            var cond = Dino == 0
                ? $"defeito =1 and diano ={Pbl.AnoContabil()}"
                : $"dino ={Dino} and diano ={Pbl.AnoContabil()}";
            SetNumero(cond, false);
        }

        private void numericDia_ValueChanged(object sender, EventArgs e)
        {
            var dt = GridMovim.GetBindedTable();
            if (!dt.HasRows()) return;
            foreach (var r in dt.AsEnumerable())
            {
                r["dia"] = numericDia.Value;
                UpdateData(r);
            }
        }

        private void UpdateData(DataRow r)
        {
            r["data"] = new DateTime(r["ano"].ToInt()==0?1900: r["ano"].ToInt(), r["mes"].ToInt() == 0 ? 1 : r["mes"].ToInt(), r["dia"].ToInt() == 0 ? 1 : r["dia"].ToInt());
        }

        private void exportarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void importarMovimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dt = SQL.GetGen2DT("select codigo  from importar where Codigo is not null  group by codigo order by codigo ");
            if (dt.HasRows())
            {
                Helper.DoProgressProcess(dt, RecebeDados);
                Lista = "";
                Lista2 = "";
            }
        }

       string Lista;
       string Lista2;
        private void RecebeDados(DataRow row, bool fim)
        {
            var dt = SQL.GetGen2DT($@"SELECT [Codigo]
                                      ,isnull([NrDoc],0) NrDoc
                                      ,[Data]
                                      ,[Conta]
                                      ,isnull([Descricao],'') Descricao
                                      ,isnull([Documento],'Diversos') Documento
                                      ,isnull([docno],33) docno
                                      ,isnull([dino],60) dino
                                      ,isnull([Diario],'Op. Diversas') Diario
                                      ,isnull([DB],0) [DB]
                                      ,Isnull([CR],0) [CR]
                                  FROM [dbo].[IMPORTAR] where codigo={row["codigo"].ToInt()}");
            if (dt.HasRows())
            {
                var diario = SQL.GetRow($"select Diariostamp,dino,Descricao from Diario where dino ={dt.RowZero("dino")}");
                //var doc = SQL.GetRow($"select docno,docnome from dc where docno={dt.RowZero("docno")}");
                if (diario==null)
                {
                    var diar = SQL.Initialize("Diario");
                    var rw = diar.NewRow().Inicialize();
                    rw["dino"] = dt.RowZero("dino");
                    rw["Descricao"] = dt.RowZero("Diario");
                    rw["diano"] = Pbl.Param.Ano;
                    diar.Rows.Add(rw);
                    SQL.Save(diar, "diario", true, "", "");
                    diario = SQL.GetRow($"select Diariostamp,dino,Descricao from Diario where dino ={dt.RowZero("dino")}");
                }
                
                var Lc = DoAddline<Lcont>();
                var data = dt.RowZero("Data").ToDateTimeValue();
                Lc.Ano = data.Year;
                Lc.Mes = data.Month;
                Lc.Dia = data.Day;
                Lc.Data = data;
                Lc.Moeda = "MZN";
                Lc.Moeda2= row["codigo"].ToString();
                Lc.Dinome = diario["Descricao"].ToString();
                Lc.Dino = diario["dino"].ToDecimal();
                //Lc.Dinome = dt.RowZero("diario").ToString();
                //Lc.Dino = dt.RowZero("dino").ToDecimal();
                Lc.Diariostamp = diario["Diariostamp"].ToString();
                Lc.Docnome = dt.RowZero("Documento").ToString();
                Lc.Docno = dt.RowZero("Docno").ToDecimal();
                Lc.Adoc = dt.RowZero("NrDoc").ToString();
                Lc.Memissao = "IMPORT";
                var str = $"SELECT dbo.func_GenNumber({Lc.Dino},{Lc.Mes},{Lc.Ano})";
                var maximo = SQL.SQLExecScalar(str);
                Lc.Dilno = maximo.ToDecimal();
                Lc.Debfin = SomaTorio(dt, "DB"); 
                Lc.Crefin = SomaTorio(dt, "CR");
                if (Lc.Debfin != Lc.Crefin)
                {
                    Lista2 = $"{Lista2}\n\rO Codigo  {Lc.Moeda2}, debito diferente de credito ";
                }
                // Lc.Memissao = item["descricao"].ToString();
                if (EF.Save(Lc).ret>0)
                {
                    try
                    {
                        var ml = SQL.Initialize("ml");
                        foreach (var item in dt.AsEnumerable())
                        {
                            if (item != null)
                            {
                                var conta = SQL.GetRow($"select conta,Descricao,Pgcstamp from pgc where conta ='{item["Conta"].ToString().Trim()}' and ano=(select ano from param)");
                                if (conta != null)
                                {
                                    NewMethod(row, dt, Lc, ml, item, conta);
                                }
                                else
                                {
                                    var pgc = SQL.Initialize("Pgc");
                                    var rw = pgc.NewRow().Inicialize();
                                    rw["Conta"] = item["conta"].ToString();
                                    rw["Descricao"] = item["Descricao"].ToString();
                                    rw["Ano"] = Pbl.Param.Ano;
                                    pgc.Rows.Add(rw);
                                    SQL.Save(pgc, "Pgc", true, "", "");
                                    //var pgc  = DoAddline<Pgc>();
                                    //pgc.Conta = item["conta"].ToString();
                                    //pgc.Descricao = item["Descricao"].ToString();
                                    //pgc.Ano= Lc.Ano;
                                    //EF.Save(pgc);
                                    var conta2 = SQL.GetRow($"select conta,Descricao,Pgcstamp from pgc where conta ='{item["Conta"].ToString().Trim()}' and ano=(select ano from param)");

                                    NewMethod(row, dt, Lc, ml, item, conta2);
                                    Lista = $"{Lista}\n\rA conta {item["Conta"].ToString().Trim()}, não existe no PGC ";
                                }
                            }
                        }
                        SQL.Save(ml, "ml", true, "", "");
                    }
                    catch (Exception xx)
                    {
                        MsBox.Show(xx.Message);
                        //throw;
                    }
                }
            }

            if (fim)
            {
                if (!Lista.IsNullOrEmpty())
                {
                    MsBox.Show(Lista);
                }
                if (!Lista2.IsNullOrEmpty())
                {
                    MsBox.Show(Lista2);
                }
            }
        }

        private static void NewMethod(DataRow row, DataTable dt, Lcont Lc, DataTable ml, DataRow item, DataRow conta)
        {
            var dr = ml.NewRow().Inicialize();
            dr["Lcontstamp"] = Lc.Lcontstamp;
            dr["dia"] = Lc.Dia;
            dr["mes"] = Lc.Mes;
            dr["Ano"] = Lc.Ano;
            dr["Dilno"] = Lc.Dilno;
            dr["Dilno"] = Lc.Dilno;
            dr["Dilno"] = Lc.Dilno;
            dr["Data"] = Lc.Data;
            if (conta!=null)
            {
                dr["descricao"] = conta["Descricao"];
                dr["conta"] = conta["conta"];
            }
            else
            {
                dr["descricao"] = item["Descricao"];
                dr["conta"] = item["conta"];
            }
            dr["deb"] = item["DB"];
            dr["cre"] = item["CR"];
            dr["Dinome"] = Lc.Dinome;
            dr["Docnome"] = Lc.Docnome;
            dr["Descritivo"] = "Nº " + Lc.Adoc;
            dr["Pgcstamp"] = conta["Pgcstamp"];
            dr["obs"] = dt.RowZero("Descricao");
            dr["Moeda2"] = row["codigo"].ToString();
            ml.Rows.Add(dr);
        }

        private decimal SomaTorio(DataTable dt, string v)
        {
            decimal s = 0;
            foreach (var item in dt.AsEnumerable())
            {
                s = s + item[v].ToDecimal();
            }
            return s;
        }

        private void importarMovimentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var dt = SQL.GetGen2DT("select codigo  from importar group by codigo order by codigo ");
            if (dt.HasRows())
            {
                Helper.DoProgressProcess(dt, RecebeDados);
                Lista = "";
            }
        }

        private void iMPToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}

