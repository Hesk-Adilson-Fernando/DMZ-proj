using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DataTable = System.Data.DataTable;

namespace DMZ.UI.UI
{
    public partial class FrmIv : Basic.FrmClasse
    {
        private IV _iv;
        private DataTable DtSt { get; set; }
        public FrmIv()
        {
            InitializeComponent();
        }

        private void FrmIV_Load(object sender, EventArgs e)
        {
            Campo1 = "Numero";
            Campo2 = "Descricao";
            Ctabela = "IV";

        }
        public override void DefaultValues()
        {
            _iv = DoAddline<IV>();
            _iv.Sigla = "IV";
            _iv.Ccusto = Pbl.Usr.Ccusto;
            _iv.Codccu = Pbl.Usr.Codccu;
            _iv.Data = Pbl.SqlDate;
            _iv.Numdoc = 1;
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(_iv);
            EF.Save(_iv);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _iv = FillControls(_iv, dt, i);
            btnLancar.Text = _iv.Lancado ? "Anular Lançamento" : "Lançar Inventário";          
        }

        private void gridPreco_EditingControlShowing(object sender, System.Windows.Forms.DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridPreco.CurrentRow == null) return;
            var qry = "select Ststamp,Referenc,Descricao from st ";
            var name = gridPreco.CurrentCell.OwningColumn.Name.ToLower();
            if (name.Equals("descricao"))
            {
                DtSt = Helper.SetBinds(e.Control, "Descricao", qry);
            }
            if (name.Equals("Referenc"))
            {
                DtSt = Helper.SetBinds(e.Control, "Referenc", qry);
            }
        }
        private void gridPreco_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridPreco.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("descricao"))
            {
                SetIVL("descricao");
            }
            if (nome.Equals("referenc"))
            {
                SetIVL("Referenc");
            }
        }
        private void SetIVL(string campo)
        {
            if (DtSt == null) return;
            var valor = gridPreco.CurrentCell.Value.ToString().Trim();
            var dr = DtSt.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));
            if (dr != null)
                Addline(dr["Ststamp"].ToString().Trim());
        }
        public override void Addline(string referenc)
        {
            if (!Procurou)
            {
                var st = SQL.GetRowToEnt<St>( $" ltrim(rtrim(ststamp)) ='{referenc.Trim()}' ");
                var tmpValor = SQL.GetRowToEnt<StPrecos>( $" ltrim(rtrim(ststamp)) ='{st.Ststamp.Trim()}' and CodCCu='{Pbl.Usr.Codccu}'");
                var tmpArm = SQL.GetGen2DT($"select codarm,descricao from Starm where Ststamp='{st.Ststamp.Trim()}' and Padrao=1");
                gridPreco.DataRowr["ivlstamp"] = Pbl.Stamp();
                gridPreco.DataRowr["Quant"] = 1;
                gridPreco.DataRowr["Numdoc"] = _iv.Numdoc;
                gridPreco.DataRowr["ivstamp"] = _iv.Ivstamp;
                gridPreco.DataRowr["Descricao"] = st.Descricao.Trim();
                gridPreco.DataRowr["Referenc"] = st.Referenc.Trim();
                gridPreco.DataRowr["Sigla"] = _iv.Sigla;
                if (tmpArm?.Rows.Count > 0)
                {
                    gridPreco.DataRowr["Armazem"] = tmpArm.Rows[0][0].ToDecimal();
                }
                if (tmpValor != null)
                {
                    gridPreco.DataRowr["Preco"] = tmpValor.Preco;
                }
                gridPreco.DataRowr["Unidade"] = st.Unidade;
                gridPreco.DataRowr["Status"] = false;
                gridPreco.DataRowr["Difer"] = 0;
                gridPreco.DataRowr["Nmovstk"] = true;
                TotaisLinhas(gridPreco.DataRowr);
            }
            gridPreco.Update();
        }
        private void TotaisFt(DataTable dsDt)
        {
            tbTotalIV.tb1.Text= dsDt.AsEnumerable().Sum(x => x.Field<decimal?>("Totall")).ToString().SetMask();
        }
        private void TotaisLinhas(DataRow dr)
        {
            dr["Totall"] = dr["Preco"].ToDecimal() * dr["Quant"].ToDecimal();
            TotaisFt(gridPreco.DtDS);
        }
        private void btnLancar_Click(object sender, EventArgs e)
        {
            var gravado = SQL.CheckExist($"select ivstamp from iv where ivstamp='{_iv.Ivstamp.Trim()}'");
            if (gravado)
            {
                if (_iv.Lancado)
                {
                    var dr= MsBox.Show("ATENÇÃO: Tem a certeza se deseja anular Inventário ?", DResult.YesNo);
                    if (DialogResult.Yes != dr.DialogResult) return;
                    SQL.SqlCmd($"update IV set Lancado = 0, datalanc = 0 where ivstamp = '{_iv.Ivstamp.Trim()}'");
                    SQL.SqlCmd($"update IVL set Difer = 0 where ivstamp = '{_iv.Ivstamp.Trim()}'");
                    _iv.Lancado = false;
                    _iv.Datalanc = Pbl.SqlDate;
                    foreach (var r in gridPreco.DtDS.AsEnumerable())
                    {
                        if (r == null) continue;
                        var ivl = r.DrToEntity<IVL>();
                        SQL.SqlCmd($"delete from mstk where Ivlstamp= '{ivl.Ivlstamp.Trim()}'");
                        r["Difer"] = 0;
                    }
                    StockCalcula();
                    EF.Save(_iv);
                    gridPreco.Update();
                    SQL.SqlCmd($"update IVL set difer =0 where ivstamp='{_iv.Ivstamp.Trim()}'");
                    cbLancado.cb1.Checked = false;
                    btnLancar.Text = @"Lançar Inventário";
                    MsBox.Show("Inventário cancelado com sucesso!");
                }
                else
                {
                    var dialogr = MsBox.Show("Deseja lançar o inventario?.. ", DResult.YesNo);
                    if (DialogResult.Yes != dialogr.DialogResult) return;
                    SQL.SqlCmd($"Delete mstk where oristamp in (select mstk.oristamp from mstk left join IVL on IVL.IVLstamp = mstk.oristamp where stampcab = '{_iv.Ivstamp.Trim()}' and mstk.IVLstamp is null)");
                    var dtmstk = SQL.GetGen2DT("select * from mstk where 1=0");
                    var param =Pbl.Param;
                    var dt = gridPreco.DataSource as DataTable;
                    if (dt ==null) return;
                    foreach (var r in dt.AsEnumerable())
                    {
                        if (r==null) continue;
                        var ivl = r.DrToEntity<IVL>();
                        decimal stk = 0;
                        var dtstok=SQL.GetGen2DT($@"Select SUM(entrada - saida) stock FROM mstk(nolock) where LTRIM(RTRIM(mstk.Ref)) = '{ivl.Referenc.Trim()}' 
                                                     and mstk.codarm ={ivl.Armazem} and data <= '{_iv.Data.ToSqlDate()}' group by ref, codarm");
                        var dr2 = dtmstk.NewRow();
                        dr2["mstkstamp"] = Pbl.Stamp();
                        dr2["oristamp"] = _iv.Ivstamp;
                        dr2["stampcab"] = _iv.Ivstamp;
                        dr2["Origem"] = "IV";
                        dr2["IVLstamp"] = ivl.Ivlstamp;
                        dr2["factlstamp"] = null;
                        dr2["dilstamp"] = null;
                        dr2["facclstamp"] = null;
                        dr2["Data"] = _iv.Data;
                        dr2["nrdoc"] = _iv.Numero;
                        dr2["tipodoc"] = _iv.Sigla;
                        dr2["documento"] = "Inventário";
                        dr2["numdoc"] = _iv.Numdoc;
                        dr2["entidade"] = 1;
                        dr2["ref"] = ivl.Referenc;
                        dr2["descricao"] = ivl.Descricao;
                        if (dtstok?.Rows.Count>0)
                        {
                            stk = dtstok.Rows[0]["stock"].ToDecimal();
                            if (stk < ivl.Quant)
                            {
                                var xx= ivl.Quant - stk;
                                dr2["entrada"] = xx;
                                dr2["codmovstk"] = param.Ivcodentr;
                                dr2["descmovstk"] = param.Ivdescentr;
                                r["Difer"] = xx;
                            }
                            else
                            {
                                var kk = stk - ivl.Quant;
                                dr2["saida"] = kk;
                                dr2["codmovstk"] = param.Ivcodsai;
                                dr2["descmovstk"] = param.Ivdescsai;
                                r["Difer"] = kk;
                            }
                        }
                        dr2["codarm"] = ivl.Armazem;
                        dr2["preco"] = ivl.Preco;
                        dtmstk.Rows.Add(dr2);
                        
                       // dtstok.Dispose();
                        // }
                    }
                    gridPreco.Update();
                    SQL.Save(dtmstk, "mstk",false,"","");
                    _iv.Lancado = true;
                    cbLancado.cb1.Checked = true;
                    _iv.Datalanc = Pbl.SqlDate;
                    EF.Save(_iv);
                    SQL.Save(dt, "ivl",false,"","");
                    StockCalcula();
                    btnLancar.Text = @"Anular Lançamento";
                    MsBox.Show("Inventário lançado com sucesso!");
                }

            }
            else
            {
                MsBox.Show("O Inventário está em edicão porfavor grave primeiro");
            }
        }

        private void StockCalcula()
        {
            foreach (var r in gridPreco.DtDS.AsEnumerable())
            {
                if (r == null) continue;
                var ivl = r.DrToEntity<IVL>();
                var lista = new List<SqlParameter>
                {
                    new SqlParameter("@ref", SqlDbType.VarChar) {Value = ivl.Referenc},
                    new SqlParameter("@codarm", SqlDbType.Decimal) {Value = ivl.Armazem},
                    new SqlParameter("@descricao", SqlDbType.VarChar) {Value = ""},
                    new SqlParameter("@stock", SqlDbType.Decimal) {Value = 0},
                    new SqlParameter("@starmstamp", SqlDbType.VarChar) {Value = ""},
                    new SqlParameter("@status", SqlDbType.Bit) {Value = 0},
                    new SqlParameter("@MaxRownum", SqlDbType.Int) {Value = 0},
                    new SqlParameter("@Iter", SqlDbType.Int) {Value = 0}
                };
                SQL.SqlExec("stkcalc", lista);
            }
        }

        private void gridPreco_CellEnter(object sender, DataGridViewCellEventArgs e) => Helper.CellEnter(sender, e);

        private void gridPreco_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (!EditMode) return;
            if (gridPreco.CurrentRow == null) return;
            var name = gridPreco.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (name.Equals("quant"))
            {
                NVerificar = true;
            }
        }

        private void gridPreco_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (!NVerificar) return;
            NVerificar = false;
            TotaisLinhas(gridPreco.DataRowr);
        }
    }
}
