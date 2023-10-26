using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using DMZ.UI.UC;
using DMZ.UI.UI.Contabil;

namespace DMZ.UI.UI
{
    public partial class FrmFt : FrmClasse
    {
        private bool _panelMenuVisible;
        private readonly int _panelMenuWidth;
        public Tdoc TmpTdoc;
        private Factsegvia factsegvia;
        private DataTable DtArm { get; set; }
        //public DataTable PrintDt { get; set; }
        private DataTable DtSt { get; set; }
        private DataRow DataRow { get; set; }
        private bool LRunStk { get; set; }
        private Fact _ft;
        public Cl _cliente;
        private DataTable cl;
        private decimal TaxaCambio { get; set; }
        public string Origem { get; set; } = "";
        public decimal OldFactTotal { get; set; }
        private List<Usracessos> lista;
        public FrmFt()
        {
            InitializeComponent();
            _panelMenuVisible = false;
        }

        private void btnMovePanel_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void btnTdi_Click(object sender, EventArgs e)
        {
            if (!Inserindo)
            {
                if (Procurou && Lista == null)
                {
                    CallBrowdoc();
                }
                else
                {
                    EditMode = false;
                    Procurou = false;
                    CallBrowdoc();
                }
            }
            else
            {
                MsBox.Show("O formulário está em modo de edição. Por favor Grave ou cancela");
            }
        }
        public void CallBrowdoc(bool origem = false)
        {
            var cond = "";
            for (var i = 0; i < ListaUsracessos.Count; i++)
            {
                if (!ListaUsracessos.ToArray()[i].Ver) continue;
                if (i == 0)
                {
                    cond = $"'{ListaUsracessos.ToArray()[i].Ecran}'";
                }
                else
                {
                    if (string.IsNullOrEmpty(cond))
                    {
                        cond = $"'{ListaUsracessos.ToArray()[i].Ecran}'";
                    }
                    else
                    {
                        cond = $"{cond}" + $",'{ListaUsracessos.ToArray()[i].Ecran}'";
                    }
                }
            }

            var bw = new Browdoc
            {
                Condicao = $" where sigla in ({cond}) ",
                Descricao = @"descricao",
                Sigla = @"sigla",
                Tabela = @"tdoc",
                Origem = origem,
                BindTdoc = BindTdoc
            };
            bw.ShowForm(this, true);
        }

        public void Produtos(DataTable dt)
        {
            var bw = new FrmAddArtigos
            {
                SendData = ReceiveDt
            };
            bw.BindiGrid(dt);
            bw.ShowForm(this, true);

        }

        private void ReceiveDt(DataTable dt)
        {
            if (!ucMoeda.tb1.Text.Trim().Equals(Pbl.MoedaBase))
            {
                TaxaCambio = SQL.ExecCambio(ucMoeda.tb1.Text);
                MoedaCambio.tb1.Text = Pbl.MoedaBase;
                tbTaxaCambio.tb1.Text = TaxaCambio.ToString();
                Helper.ShowHideMoedaColumns(true, ucMoeda.tb1.Text.Trim(), gridUIFt1);
            }
            foreach (var r in dt.AsEnumerable())
            {
                if (r == null) continue;
                dmzGridButtons1.btnNovo.PerformClick();
                DataRow["ref"] = r["ref"];
                DataRow["Descricao"] = r["Descricao"];
                DataRow["quant"] = r["quant"];
                DataRow["preco"] = r["preco"];
                DataRow["oristampl"] = r["Pjescstamp"];
                DataRow["Txiva"] = r["Txiva"];
                DataRow["Tabiva"] = r["Tabiva"];
                DataRow["Perdesc"] = r["Perdesc"];
                DataRow["Descontol"] = r["Descontol"];
                DataRow["Ivainc"] = r["Ivainc"];//
                if (!ucMoeda.tb1.Text.Trim().Equals(Pbl.MoedaBase))
                {
                    DataRow["Cambiousd"] = TaxaCambio;
                    DataRow["mpreco"] = r["preco"];
                    DataRow["preco"] = r["preco"].ToDecimal() * TaxaCambio;
                }
                GenBl.TotaisLinhas(DataRow);
            }
            if (TmpTdoc.Movtz)
            {
                Helper.VendaDiheiro(gridUIFt1.DsDt, this, TmpTdoc.Sigla, ucMoeda.tb1.Text);
                UpdGridFormasp();
            }
            gridUIFt1.Update();
            Helper.TotaisFt(gridUIFt1.DsDt, this);
        }
        public void BindTdoc(DataRow tdoc, bool origem = false)
        {
            if (tdoc == null) return;
            if (!origem)
            {
                TmpTdoc = tdoc.DrToEntity<Tdoc>();
                SetValues(TmpTdoc);
            }
            else
            {
                TmpTdoc = tdoc.DrToEntity<Tdoc>();
                if (Controlacesso)
                {
                    Usracessos = ListaUsracessos.FirstOrDefault(x => x.Oristamp.Trim().Equals(TmpTdoc.Tdocstamp.Trim()));
                    var ff = TmpTdoc.Descricao;
                }
                label1.Text = TmpTdoc.Descricao;
                panelNC.Visible = TmpTdoc.Nc;
                gridFormasP1.Visible = TmpTdoc.Movtz;
                gridFormasP1.Movtz = TmpTdoc.Movtz;
                CCondicao = $"numdoc={TmpTdoc.Numdoc} and year(data) = {Pbl.SqlDate.Year} and mesa=0 and Ccusto='{Pbl.Usr.Ccusto.Trim()}'";
                CLocalStamp = Pbl.Stamp();
                var maximo = SQL.Maximo("fact", "numero", CCondicao);
                _ft.Factstamp = CLocalStamp;
                HelperFact.SetDefaultValues(_ft,TmpTdoc);
                tbObs.tb1.Text = TmpTdoc.Obs2;
                dtFact.dt1.Value = Pbl.SqlDate;
                dtVencimento.dt1.Value = Pbl.SqlDate.AddDays(30);
                tbNumero.tb1.Text = maximo.ToString();
                Helper.UpdateLinhas(CLocalStamp, gridUIFt1, gridFormasP1.Grelha, "fact", "factl");
            }
        }
        private void Checkfactura()
        {
            if (TmpTdoc.Ft || TmpTdoc.Vd || TmpTdoc.Nc || TmpTdoc.Nd)
            {
                btnAnular.Visible = true;
                btnDelete.Visible = false;
            }
            else
            {
                btnAnular.Visible = false;
                btnDelete.Visible = true;
                btnDelete.Enabled = true;
            }
        }
        private void SetValues(Tdoc tdoc)
        {
            if (Controlacesso)
            {
                Usracessos = ListaUsracessos.FirstOrDefault(x => x.Oristamp.Trim().Equals(TmpTdoc.Tdocstamp.Trim()));
                var ff = TmpTdoc.Descricao;
            }
            label1.Text = tdoc.Descricao;
            Helper.ClearControls(this);
            panelNC.Visible = tdoc.Nc;
            gridFormasP1.Visible = tdoc.Movtz;
            gridFormasP1.Movtz = tdoc.Movtz;
            CCondicao = $"numdoc={tdoc.Numdoc} and year(data) = {Pbl.SqlDate.Year} and mesa=0 and Ccusto='{Pbl.Usr.Ccusto.Trim()}'";
            Checkfactura();
            MostraMorada(tdoc);
            Helper.MostraCentroNaLinha(gridUIFt1);
        }
        private void FrmFt_Load(object sender, EventArgs e)
        {
            Campo1 = "Numero";
            Campo2 = "nome";
            Ctabela = "fact";
            OrderByCampos = "convert(decimal,Numero)";
            tbTaxaCambio.IsReadOnly = !Pbl.Usr.Alteracambio;
            TmpTdoc = SQL.GetRowToEnt<Tdoc>(Tdoccondicao);//
            panelNC.Visible = TmpTdoc.Nc;
            SetValues(TmpTdoc);
            gridFormasP1.BindGridView(EditMode);
            MultiDoc = true;
            if (gridUIFt1 == null) return;
            if (ParentForm == null) return;
            if (Pbl.Usr.Desconto)
            {
                gridUIFt1.Columns["Percdesc"].Visible = false;
                gridUIFt1.Columns["Desconto"].Visible = false;
            }
            else
            {
                gridUIFt1.Columns["Percdesc"].Visible = true;
                gridUIFt1.Columns["Desconto"].Visible = true;
            }
            gridUIFt1.Columns["MostraContrato"].Visible = TmpTdoc.MostraContrato;
            gridUIFt1.Columns["Refornec"].Visible = Pbl.Param.Mostrarefornec;
            gridUIFt1.Columns["Mostraguia"].Visible = TmpTdoc.Mostraguia;

            tbNumero.IsReadOnly = !Pbl.Usr.AlteraNumero;
        }
        public List<Usracessos> ListaUsracessos { get; set; }
        public string Tdoccondicao { get; set; } = " defa = 1 ";
        public override List<string> GetList()
        {
            return Helper.GetList(_ft);
        }
        public override void DefaultValues()
        {
            factsegvia = null;
            gridUIFt1.Enabled = true;
            _ft = DoAddline<Fact>();
            if (Origem.Equals("POSSUP"))
            {
                _ft.Factstamp = Pbl.Stamp(Origem);
                CLocalStamp = _ft.Factstamp;
            }
            Noneg = TmpTdoc.Noneg;
            _ft.Pjstamp = Pjstamp;
            HelperFact.SetDefaultValues(_ft, TmpTdoc);
            gridUIFt1.ReadOnly = false;
            Cliente.Enabled = true;
            _ft.Reserva = OrigReserva;
            Helper.SetCCustoMoeda(tbCcusto, ucMoeda);
            base.DefaultValues();
            cbMovstk.Update(TmpTdoc.Movstk);
            dtVencimento.dt1.Value = Pbl.GetDate((int)TmpTdoc.Dias);
            if (!Pbl.Param.Mascfact.IsNullOrEmpty())
            {
                var xx = $@" select isnull(max(isnull(TRY_PARSE(right(ltrim(rtrim(numero)),{Pbl.Param.Mascfact.Length - 1})AS INT),0)),0)+1 as maxvalue from fact where {CCondicao}";
                var dt2 = SQL.GetGenDT(xx);
                if (dt2?.Rows.Count > 0)
                {
                    var num = Helper.GetValueByMascara(Pbl.Param.Radicalfact, Pbl.Param.Mascfact, dt2);
                    tbNumero.tb1.Text = num;
                }
            }
            if (!OrigReserva)
            {
                if (!Origem.Equals("POSSUP"))
                {
                    // DataRow = Helper.NewGridRow(this);
                }
            }
            Helper.ShowHideMoedaColumns(false, "", gridUIFt1);
        }



        public override bool BeforeSave()
        {
            if (TmpTdoc.Ft || TmpTdoc.Nd || TmpTdoc.Nc || TmpTdoc.Vd)
            {
                if (Pbl.Param.Usacademia)
                {
                    if (tbCurso.tb1.Text.IsNullOrEmpty())
                    {
                        MsBox.Show("O curso não pode estar vazio, veja na página ACADEMIA");
                        return false;
                    }
                    if (tbTurma.tb1.Text.IsNullOrEmpty())
                    {
                        MsBox.Show("A Turma não pode estar vazio, veja na página ACADEMIA");
                        return false;
                    }
                }
                if (!cbMovstk.cb1.Checked)
                {
                    var dr = MsBox.Show($"{_ft.Nomedoc.Trim()}\r\nÉ um documento de movimento de Stock, Deseja continuar com essa opção desativada?!\r\nPara activar segue pela página de movimento de stock", DResult.YesNo);
                    if (dr.DialogResult == DialogResult.No)
                    {
                        return false;
                    }
                }
            }
            if (TmpTdoc.Ft || TmpTdoc.Nd || TmpTdoc.Nc)
            {
                if (_cliente.Prontopag)
                {
                    MsBox.Show($"{_cliente.Nome.ToUpper()}\r\nÉ um cliente pronto pagamento só pode emitir uma VD apenas!");
                    return false;
                }
            }
            #region Verifica se o valor da nota de credito é negativo--deve ser negativo 
            if (TmpTdoc.Nc)
            {
                if (tbTotal.tb1.Text.ToDecimal() >= 0)
                {
                    MsBox.Show("A Nota de crédito deve ter valores negativos, verifique!");
                    return false;
                }
                if (TmpTdoc.Ncobrigadoc)
                {
                    if (string.IsNullOrEmpty(_ft.Oristamp))
                    {
                        MsBox.Show("A Nota de crédito obriga a indicação do documento a regularizar!");
                        return false;
                    }
                }
                if (_ft.Campo2.ToDecimal() < (-1 * tbTotal.tb1.Text.ToDecimal()))
                {
                    MsBox.Show($"O valor da Nota de crédito não pode ser superior que o valor do documento que esta a regularizar!\r\n Valor do documento {_ft.Campo2}");
                    return false;
                }
            }
            #endregion
            #region Actualiza o Stamp do cl nas linhas 
            if (TmpTdoc.Movstk)
            {
                Helper.UpdateLinhas(gridUIFt1, _ft.Clstamp);
                var ret = Helper.CheckStstamp(gridUIFt1);
                if (!ret.ret)
                {
                    MsBox.Show(ret.ms);
                    return false;
                }
            }
            #endregion
            #region Verifica se a factura é fazia ou igual a zero ou nao
            if (TmpTdoc.Ft || TmpTdoc.Vd)
            {
                if (tbTotal.tb1.Text.ToDecimal() <= 0)
                {
                    MsBox.Show("Os Documentos: \r\nFactura\r\nVenda a Dinheiro\r\nNota de crédito\r\nNota de débito\r\nNão podem gravar com valor zero");
                    return false;
                }
            }
            #endregion

            #region Verifica alteracao da descricao do produto
            var facturado = gridUIFt1.GetBindedTable();
            if (facturado.HasRows())
            {
                foreach (var row in facturado.AsEnumerable())
                {
                    if (row == null) continue;
                    if (row.RowState == DataRowState.Deleted) continue;
                    if (row["servico"].ToBool()) continue;

                    var st = SQL.GetGen2DT($"select referenc,descricao from st where ststamp='{row["ststamp"].ToString().Trim()}'");
                    if (!(st?.Rows.Count > 0)) continue;
                    var xx = st.Rows[0]["descricao"].ToString().Trim();
                    if (xx.Equals(row["descricao"].ToString().Trim())) continue;
                    MsBox.Show(Messagem.ParteInicial() + " Não pode alterar a descrição do produto!\r\nAlteração feita:" +
                               $"\r\n{xx}\r\nPara:\r\n{row["descricao"].ToString().Trim()}");
                    return false;
                }
            }

            #endregion
            if (Procurou)
            {
                if (!TmpTdoc.Descricao.ToLower().Contains("cotação"))
                {
                    var xx = CheckMovimentos("actualizar");
                    if (xx.ret) return false;
                }
            }
            _ft.Data = dtFact.dt1.Value;
            if (!Procurou)
            {
                if (TmpTdoc.Ft || TmpTdoc.Vd)
                {
                    if (_cliente.Ctrlplanfond)
                    {
                        var valor = _cliente.Saldo + tbTotal.tb1.Text.ToDecimal();
                        if (_cliente.Plafond < valor)
                        {
                            MsBox.Show($"O Valor do documento e o saldo do cliente ({valor}) é superior que o seu Plafond ({_cliente.Plafond}).\r\nNão pode gravar atingiu o limite!");
                            return false;
                        }
                    }
                }
            }
            if (dtFact.dt1.Value.Year > Pbl.SqlDate.Year)
            {
                MsBox.Show(Messagem.ParteInicial() + $"O ano do documento não pode ser superior que: {Pbl.SqlDate.Year}!");
                return false;
            }
            #region Verificação de Stock dos produtos a serem facturados
            if (!TmpTdoc.Nc)
            {
                var values = GenBl.CheckStock(_ft, gridUIFt1.DsDt, TmpTdoc.Usalote);
                if (!values.StkExiste)
                {
                    MsBox.Show(values.Messagem);
                    return false;
                }
            }
            #endregion
            if (TmpTdoc.Ft || TmpTdoc.Vd)
            {
                if (Pbl.Param.Perlucro > 0)
                {
                    foreach (var r in gridUIFt1.DsDt.AsEnumerable())
                    {
                        if (r.RowState == DataRowState.Deleted) continue;
                        if (r["servico"].ToBool()) continue;
                        var valcompra = SQL.GetValue("PrecoCompra", "stprecos", $"ststamp=(select ststamp from st where referenc='{r["ref"].ToString().Trim()}')").ToDecimal();
                        var valorvenda = valcompra + valcompra * Pbl.Param.Perlucro / 100;
                        if (r["preco"].ToDecimal() >= valorvenda) continue;
                        MsBox.Show($"Desculpa o valor de venda esta abaixo de percentagem minima de Lucro({Pbl.Param.Perlucro}).\r\n O ideal é {valorvenda}!..");
                        return false;
                    }
                }
            }
            if (TmpTdoc.Nc)
            {
                if (string.IsNullOrEmpty(tbMotivo.tb1.Text))
                {
                    MsBox.Show(Messagem.ParteInicial() + $"Deve indicar o motivo de anulação ou Retificação da {TmpTdoc.Descricao}");
                    return false;
                }
                if (TmpTdoc.Ncobrigadoc)
                {
                    if (string.IsNullOrEmpty(_ft.Oristamp))
                    {
                        MsBox.Show(Messagem.ParteInicial() + "Deve indicar o documento que pretende de anular ou Retificar a Nota de Crédito obriga!");
                        return false;
                    }
                }
            }
            if (gridFormasP1.Formaspdt?.Rows.Count > 0)
            {
                (bool Correcto, string Messagem) vals;
                if (ucMoeda.tb1.Text.ToLower().Equals(Pbl.MoedaBase.ToLower().Trim()))
                {
                    vals = GenBl.CheckTesoura(gridFormasP1.Formaspdt, tbTotal.tb1.Text.ToDecimal(), _ft.Movtz);
                }
                else
                {
                    vals = GenBl.CheckTesoura(gridFormasP1.Formaspdt, tbtotalMoeda.tb1.Text.ToDecimal(), _ft.Movtz);
                }
                if (!vals.Correcto)
                {
                    if (vals.Messagem.Contains("tipo de movimento"))
                    {
                        MsBox.Show($"{vals.Messagem} na página de pagamentos");
                        tabControl1.SelectTab(tabPage2);
                        return false;
                    }

                    MsBox.Show(vals.Messagem);
                    return false;
                }
            }
            return base.BeforeSave();
        }
        public override void Save()
        {
            base.Save();
            FillEntity(_ft);
            if (Cancelado) return;
            var xx = EF.Save(_ft);
            if (xx.ret<=0)
            {
                MsBox.Show(xx.msg);
                return;
            }
            if (!TmpTdoc.Ft && !TmpTdoc.Nc && !TmpTdoc.Vd) return;
            GenBl.ExecAudit(_ft, Name);
        }
        public override void AfterSave()
        {
            if (TmpTdoc.Inscricao)
            {
                if (!Procurou)
                {
                    var aluno = SQL.Initialize("Turmal");
                    var dr = aluno.NewRow().Inicialize();
                    dr["Turmastamp"] = _ft.Turmastamp;
                    dr["Clstamp"] = _ft.Clstamp;
                    dr["nome"] = _ft.Nome;
                    dr["no"] = _ft.No;
                    aluno.Rows.Add(dr);
                    SQL.Save(aluno, "Turmal", true, "", "");
                }
            }
            if (UpdateOrigem)
            {
                var dt = gridUIFt1.GetBindedTable();
                if (dt.HasRows())
                {
                    foreach (var item in dt.AsEnumerable())
                    {
                        if (item != null)
                        {
                            var total = SQL.GetField($"select sum(quant) total from factl where oristampl='{item["oristampl"].ToTrim()}' and ststamp ='{item["ststamp"].ToTrim()}'");
                            SQL.SqlCmd($"update dil set quant2={total.ToDecimal()} where dilstamp='{item["oristampl"].ToTrim()}' and ststamp ='{item["ststamp"].ToTrim()}'");
                        }
                    }
                }
            }
            UpdateOrigem = false;
            if (!_ft.SegundaVia)
            {
                if (Pbl.Param.Integracaoautomatica)
                {
                    if (TmpTdoc.Integra)
                    {
                        //var lista = new List<SqlParameter>();
                        //var p = new SqlParameter
                        //    {ParameterName = "@Factstamp", SqlDbType = SqlDbType.VarChar, Value = _ft.Factstamp, Size = 30};
                        //lista.Add(p);
                        //var p1 = new SqlParameter {ParameterName = "@data", SqlDbType = SqlDbType.DateTime, Value = _ft.Data};
                        //lista.Add(p1);
                        //var p2 = new SqlParameter
                        //    {ParameterName = "@qma", SqlDbType = SqlDbType.VarChar, Value = Pbl.Login, Size = 6};
                        //lista.Add(p2);
                        //SQL.SqlSP("sp_IntegrarFt", lista);
                    }
                }
                if (!string.IsNullOrEmpty(_ft.Pjstamp))
                {
                    Helper.Updatepj(TmpTdoc.Lancacustopj, _ft.Pjstamp, "Totft", "fact", "totftiva", true);
                    SendRefresh?.Invoke(true);
                }
            }
            else
            {
                if (factsegvia != null)
                {
                    var str = $@"update fact set NrFactura='{_ft.Numero}/{_ft.Data.Year}',Oristamp ='{_ft.Factstamp}' where factstamp='{factsegvia.Factstamp.Trim()}'";
                    if (SQL.SqlCmd(str) == 1)
                    {
                        factsegvia = null;
                    }
                }
            }
            if (!Procurou)
            {
                GeraGuia();
            }
        }

        private void GeraGuia()
        {
            if (cbVendaEntrega.cb1.Checked)
            {
                if (Pbl.Param.GeraGuiaAutomatica)
                {
                    var factl = gridUIFt1.GetBindedTable();
                    if (factl.HasRows())
                    {
                        if (factl.AsEnumerable().Any(x => x.Field<bool>("servico").Equals(false)))
                        {
                            var di = Utilities.DoAddline<Di>();
                            var TmpTdi = SQL.GetRowToEnt<Tdi>("vendido=1");
                            FillDiByFt(di, _ft);
                            GenDi.FillDi(di, TmpTdi);
                            di.Numero = SQL.VMax("di", TmpTdi.Numdoc, Pbl.Param.Anoref);
                            di.Oristamp = _ft.Factstamp;
                            di.Numinterno = $"{_ft.Sigla} {_ft.Numero}/{_ft.Data.Year}";
                            if (EF.Save(di).ret > 0)
                            {
                                var dil = SQL.Initialize("dil");
                                FillDillByFactl(dil, factl, di.Distamp);
                                SQL.Save(dil, "dil", true, di.Distamp, "di");
                            }
                        }
                    }
                }
            }

        }

        private void FillDillByFactl(DataTable dil, DataTable factl, string distamp)
        {
            foreach (var row in factl.AsEnumerable())
            {
                if (row != null)
                {
                    if (!row["servico"].ToBool())
                    {
                        var r = dil.NewRow().Inicialize();
                        foreach (DataColumn col in factl.Columns)
                        {
                            if (dil.Columns.Contains(col.ColumnName))
                            {
                                r[col.ColumnName] = row[col.ColumnName];
                            }
                        }
                        r["distamp"] = distamp;
                        dil.Rows.Add(r);
                    }
                }
            }
        }

        private void FillDiByFt(Di di, Fact ft)
        {
            var props = ft.GetType().GetProperties();
            foreach (var p in props)
            {
                if (p != null)
                {
                    foreach (var p2 in di.GetType().GetProperties())
                    {
                        if (p2.Name.Trim().ToLower().Equals(p.Name.ToLower().Trim()))
                        {
                            if (p2.PropertyType == p.PropertyType)
                            {
                                p2.SetValue(di, p.GetValue(ft));
                            }
                            break;
                        }
                    }
                }
            }
        }

        public Action<bool> SendRefresh { get; set; }
        public override void UpdGridFormasp()
        {
            if (gridFormasP1.Grelha?.Rows.Count > 0)
            {
                if (gridFormasP1.Movtz || TmpTdoc.Movtz)
                {
                    Helper.Codmovtz(true, TmpTdoc.Codmovtz, TmpTdoc.Descmovtz, gridFormasP1.Grelha, Origem == "POSSUP" ? "RCLPOS" : TmpTdoc.Sigla);
                }
            }
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _ft = FillControls(_ft, dt, i);
            gridFormasP1.BindGridView(EditMode);
            OldFactTotal = _ft.Total;
            _cliente = SQL.GetRowToEnt<Cl>($"Clstamp='{_ft.Clstamp.Trim()}'");
            if (!string.IsNullOrEmpty(MoedaCambio.tb1.Text))
            {
                Helper.ShowHideMoedaColumns(true,
                    MoedaCambio.tb1.Text.Trim().Equals(Pbl.MoedaBase) ? ucMoeda.tb1.Text : MoedaCambio.tb1.Text,
                    gridUIFt1);
            }
            else
            {
                Helper.ShowHideMoedaColumns(false, MoedaCambio.tb1.Text, gridUIFt1);
            }

            if (TmpTdoc.Ft || TmpTdoc.Vd)
            {
                if (!Usracessos.Altera)
                {
                    gridUIFt1.Enabled = false;
                }
            }
            else
            {
                gridUIFt1.Enabled = true;
            }
            tbDesconto.tb1.Text = _ft.Desconto.ToString().SetMask();
            tbSubTotal.tb1.Text = _ft.Subtotal.ToString().SetMask();
            tbTotal.tb1.Text = _ft.Total.ToString().SetMask();
            tbTotalIva.tb1.Text = _ft.Totaliva.ToString().SetMask();

            tbDescontoMoeda.tb1.Text = _ft.Mdesconto.ToString().SetMask();
            tbSuttotalMoeda.tb1.Text = _ft.Msubtotal.ToString().SetMask();
            tbtotalMoeda.tb1.Text = _ft.Mtotal.ToString().SetMask();
            tbIvaMoeda.tb1.Text = _ft.Mtotaliva.ToString().SetMask();
        }
        public override void Addline(string referenc)
        {
            if (!Procurou)
            {
                NovaLinha(referenc);
                //if ( Usracessos.Intro)
                //{
                //    NovaLinha(referenc); 
                //}
            }
            else
            {
                NovaLinha(referenc);
                //if (Usracessos.Altera)
                //{
                //    NovaLinha(referenc); 
                //}
            }

        }

        void NovaLinha(string referenc)
        {
            if (OrigReserva) return;
            var tmpFound = SQL.GetRowToEnt<St>($" ltrim(rtrim(ststamp)) ='{referenc.Trim()}' "); //EF.QEnt<St>($" ltrim(rtrim(ststamp)) ='{referenc.Trim()}' ");
            if (DataRow == null)
            {
                DataRow = gridUIFt1.CurrentRow.ToDataRow();
            }
            GenBl.SetLineValues(DataRow, tmpFound, _ft, false, null, TmpTdoc.Nc, ucMoeda.tb1.Text, MoedaCambio.tb1.Text.Trim(), Cliente.Text3);
            if (_cliente.Precoespecial)
            {
                var clst = SQL.GetRowToEnt<Clst>($"referenc='{tmpFound.Referenc.Trim()}'");// EF.QEnt<Clst>($"referenc='{tmpFound.Referenc.Trim()}'");
                if (clst != null)
                {
                    DataRow["Preco"] = clst.Preco;
                }
            }
            LRunStk = false;
            if (_cliente != null)
            {
                if (_cliente.Desconto)
                {
                    //Lança a percentagem de desconto definida na ficha do cliente;
                    DataRow["perdesc"] = _cliente.Percdesconto;
                }
                if (_cliente.Insencao)
                {
                    //Quando o cliente está insento do IVA...
                    DataRow["tabiva"] = 0;
                    DataRow["txiva"] = 0;
                }
                if (_cliente.Clivainc)
                {
                    DataRow["ivainc"] = true;
                }
            }
            GenBl.TotaisLinhas(DataRow);
            //*----------------
            if (tmpFound.Composto)
            {
                DataRow["composto"] = tmpFound.Composto;
                GenBl.ArtigoCompost(tmpFound, gridUIFt1.DsDt, _ft, TmpTdoc.Nc);
            }
            if (TmpTdoc.Movtz)
            {
                Helper.VendaDiheiro(gridUIFt1.DsDt, this, TmpTdoc.Sigla, ucMoeda.tb1.Text);
            }
            UpdGridFormasp();
            gridUIFt1.Update();
            Helper.TotaisFt(gridUIFt1.DsDt, this);
        }
        public bool OrigReserva { get; set; }
        public void UpdateObjects(DataTable dt)
        {
            if (_ft == null)
            {
                _ft = new Fact();
            }

            if (dt != null)
            {
                var numdoc = dt.Rows[0]["Numdoc"].ToDecimal();
                TmpTdoc = SQL.GetRowToEnt<Tdoc>($"numdoc={numdoc}"); // EF.QEnt<Tdoc>( $"numdoc={numdoc}");
            }

            label1.Text = TmpTdoc.Descricao;
            panel1.Visible = false;
            panel3.Visible = false;
        }
        public void UpdateObject(Di di, DataTable dt)
        {
            Cliente.tb1.Text = di.Nome;
            Cliente.Text2 = di.No;
            tbCcusto.tb1.Text = di.Ccusto;
            ucMoeda.tb1.Text = di.Moeda;
            _ft.Oristamp = di.Distamp;
            Distamp = di.Distamp;
            _ft.Reserva = true;
            FillGrid(dt, true);
            OrigReserva = false;
        }
        public string Distamp { get; set; }
        private void Cliente_RefreshControls()
        {
            _cliente = SQL.GetRowToEnt<Cl>($"clstamp='{Cliente.Text3}' and DeficilCobrar=0");
            if (_cliente == null) return;
            tbNuit.tb1.Text = _cliente.Nuit.ToString();
            tbMorada.tb1.Text = _cliente.Morada;
            _ft.Coment = _cliente.MotivoInsencao;
            tbLocalidade2.tb1.Text = _cliente.Localidade;
            tbEmail.tb1.Text=_cliente.Email;
            tbCelular.tb1.Text= _cliente.Celular;
            if (_cliente.Aluno)
            {
                tbCurso.tb1.Text = _cliente.Curso;
                tbCurso.Text2 = _cliente.Codcurso;
                // tbTurma.tb1.Text=_cliente.tu
            }
            if (!string.IsNullOrEmpty(_cliente.Moeda))
            {
                if (!_cliente.Moeda.Trim().Equals(Pbl.MoedaBase.Trim()))
                {
                    ucMoeda.tb1.Text = _cliente.Moeda;
                    MoedaCambio.tb1.Text = SQL.GetField("Moeda", "Moedas", "Princip=1").ToString();
                    if (!ucMoeda.tb1.Text.Equals(MoedaCambio.tb1.Text))
                    {
                        TaxaCambio = SQL.ExecCambio(_cliente.Moeda.Trim());
                        tbTaxaCambio.tb1.Text = TaxaCambio.ToString();
                        Helper.ShowHideMoedaColumns(true, _cliente.Moeda, gridUIFt1);
                    }
                    else
                    {
                        Helper.ShowHideMoedaColumns(false, "", gridUIFt1);
                    }
                }
            }
            if (_cliente.Vencimento > 0)
            {
                dtVencimento.dt1.Value = Pbl.GetDate((int)_cliente.Vencimento);
            }
            if (!_cliente.Desconto) return;
            var dt = gridUIFt1.DataSource as DataTable;
            if (dt.HasRows())
            {
                CalculaDesconto(dt);
            }
        }
        private void CalculaDesconto(DataTable dt)
        {
            foreach (var r in dt.AsEnumerable())
            {
                if (r == null) continue;
                r["perdesc"] = _cliente.Percdesconto;
                if (_cliente.Insencao)
                {
                    //Quando o cliente está insento do IVA...
                    DataRow["tabiva"] = 0;
                    DataRow["txiva"] = 0;
                }
                DataRow["ivainc"] = _cliente.Clivainc;
                GenBl.TotaisLinhas(r);
            }
            gridUIFt1.Update();
            if (gridUIFt1.DsDt?.Rows.Count > 0)
            {
                Helper.TotaisFt(gridUIFt1.DsDt, this);
            }
        }

        private void gridUIFt1_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (NVerificar)
            {
                NVerificar = false;
                if (!ucMoeda.tb1.Text.ToLower().Equals(Pbl.MoedaBase.ToLower()))
                {
                    var dt = gridUIFt1.GetBindedTable();
                    if (dt?.Rows.Count > 0)
                    {
                        foreach (var dr in dt.AsEnumerable())
                        {
                            if (dr != null)
                            {
                                dr["cambiousd"] = tbTaxaCambio.tb1.Text.ToDecimal();
                            }
                        }
                    }
                }
                Helper.CellValidated(gridUIFt1, this, TmpTdoc.Sigla);
            }
        }
        private void gridUIFt1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            Helper.CellValueChanged(gridUIFt1.CurrentCell, this);
        }

        private void gridUIFt1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
             if (gridUIFt1.CurrentRow == null) return;
            if (Cliente.tb1.Text.IsNullOrEmpty()) return;
            string qry;
            var name = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
                DataRow = gridUIFt1.CurrentRow.ToDataRow();
                switch (name)
                {
                    case "descricao":
                        if (Pbl.Param.Modeloja)
                        {
                            var arm = GenBl.GetArmazem().Replace("'", "");
                            if (!string.IsNullOrEmpty(arm))
                            {
                                qry = GetString(arm);
                                DtSt = Helper.SetBinds(e.Control, "Descricao", qry);
                            }
                            else
                            {
                                MsBox.Show($"Deve indicar os armazens a loja: {Pbl.Usr.Ccusto}");
                            }
                        }
                        else
                        {
                            qry = "select Referenc,Descricao,Ststamp from st where Naovisisvel=0";
                            DtSt = Helper.SetBinds(e.Control, "Descricao", qry);
                        }
                        break;
                    case "ref1":
                        qry = "select Referenc,Descricao,Ststamp from st where Naovisisvel=0";
                        DtSt = Helper.SetBinds(e.Control, "Referenc", qry);
                        break;
                    case "refornec":
                        qry = "select Refornec,Descricao,Ststamp from st where Naovisisvel=0";
                        DtSt = Helper.SetBinds(e.Control, "Refornec", qry);
                        break;
                    case "armazem":
                        DtArm = Helper.SetBinds(e.Control, "codigo", Helper.GetArmazemQry());
                        break;
                    case "descarm":
                        DtArm = Helper.SetBinds(e.Control, "Descricao", Helper.GetArmazemQry());
                        break;
                    case "tabiva":
                        qry = "select Codigo,Descricao from Auxiliar where tabela = 5 order by Codigo";
                        DtIva = Helper.SetBinds(e.Control, "Codigo", qry);
                        break;
                    case "txiva":
                        qry = "select Codigo,Descricao from Auxiliar where tabela = 5 order by Codigo";
                        DtIva = Helper.SetBinds(e.Control, "Descricao", qry);
                        break;
                    default:
                        {
                            DtSt = null;
                            var autoText = e.Control as TextBox;
                            autoText.AutoCompleteCustomSource = null;
                            break;
                        }
                }
        }

        private string GetString(string arm)
        {
            string qry;
            if (TmpTdoc.Movstk)
            {
                qry = $@"select tmp1.Ref as Referenc,tmp1.descricao,tmp1.Ststamp,tmp1.stock from (
                        select ref,descricao, stock =sum(Entrada-Saida),Ststamp from Mstk 
                        where Codarm in ({arm}) group by Ststamp,Ref,descricao)tmp1 join st on st.Ststamp=tmp1.Ststamp
                        where  tmp1.stock>0 and Naovisisvel=0
                        union all 
                        select Referenc,Descricao,st.ststamp,stock=0 from st where Servico = 1";
            }
            else
            {
                qry = "select Referenc,Descricao,st.ststamp,stock=0 from st ";
            }
            return qry;
        }

        private void gridUIFt1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUIFt1.CurrentRow != null)
            {
                var preco = gridUIFt1.CurrentRow.Cells["Preco"].Value.ToDecimal();
                if (preco < 0) return;
            }
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            switch (nome)
            {
                case "descricao":
                    CallUpdRow(nome);
                    break;
                case "ref1":
                    CallUpdRow(nome);
                    break;
                case "descarm":
                    SetArmazem("descricao");
                    break;
                case "refornec":
                    CallUpdRow(nome);
                    break;
                case "armazem":
                    SetArmazem("codigo");
                    break;
                case "tabiva":
                    SetTabIva("codigo");
                    break;
                case "txiva":
                    SetTabIva("descricao");
                    break;
            }
        }

        private void CallUpdRow(string nome)
        {
            if (Pbl.Param.Modeloja)
            {
                var arm = GenBl.GetArmazem();
                if (!string.IsNullOrEmpty(arm))
                {
                    if (nome.Equals("descricao"))
                    {
                        SetFactl("descricao");
                    }
                    if (nome.Equals("ref1"))
                    {
                        SetFactl("Referenc");
                    }
                    if (nome.Equals("refornec"))
                    {
                        SetFactl("refornec");
                    }
                }
            }
            else
            {
                if (nome.Equals("descricao"))
                {
                    SetFactl("descricao");
                }
                if (nome.Equals("ref1"))
                {
                    SetFactl("Referenc");
                }
                if (nome.Equals("refornec"))
                {
                    SetFactl("refornec");
                }
            }
        }

        internal void CallBrowdoc1()
        {
            var bw = new Browdoc
            {
                Condicao = "where sigla ='FT'",
                Descricao = @"descricao",
                Sigla = @"sigla",
                Tabela = @"tdoc",
                BindTdoc = BindTdoc
            };
            //bw.ShowDialog(this);
        }

        private void SetTabIva(string codigo)
        {
            if (gridUIFt1.CurrentCell?.Value == null) return;
            if (gridUIFt1.CurrentRow != null)
            {
                var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
                if (DtIva != null)
                {
                    DataRow dr;
                    switch (codigo)
                    {
                        case "descricao":
                            dr = DtIva.AsEnumerable().FirstOrDefault(s => s.Field<string>(codigo).Equals(valor));
                            if (dr == null) return;
                            gridUIFt1.CurrentRow.Cells["tabiva"].Value = dr[0];
                            break;
                        case "codigo":
                            dr = DtIva.AsEnumerable().FirstOrDefault(s => s.Field<decimal>(codigo).Equals(valor.ToDecimal()));
                            if (dr == null) return;
                            gridUIFt1.CurrentRow.Cells["txiva"].Value = dr[1];
                            break;
                    }
                    gridUIFt1.Update();
                    Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdoc.Sigla);
                }
            }
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
                    {
                        gridUIFt1.CurrentRow.Cells["Armazem"].Value = dr[0].ToString();//Armazemstamp
                        gridUIFt1.CurrentRow.Cells["Armazemstamp"].Value = dr["Armazemstamp"].ToString();//Armazemstamp
                    }
                    break;
                default:
                    if (gridUIFt1.CurrentRow != null)
                    {
                        gridUIFt1.CurrentRow.Cells["descarm"].Value = dr[1].ToString();
                        gridUIFt1.CurrentRow.Cells["Armazemstamp"].Value = dr["Armazemstamp"].ToString();
                    }
                    break;
            }

            gridUIFt1.Update();
        }
        private void SetFactl(string campo)
        {
            if (gridUIFt1.CurrentCell == null) return;
            if (gridUIFt1.CurrentCell.Value == null) return;
            var valor = gridUIFt1.CurrentCell.Value.ToString().Trim();
            if (DtSt.HasRows())
            {
                var dr = DtSt.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));
                if (dr != null)
                    Addline(dr["Ststamp"].ToString().Trim());
            }
        }
        public void Receive(DataGridViewRow dr)
        {
            if (gridUIFt1.CurrentRow == null) return;
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("armazem"))
            {

            }
            gridUIFt1.CurrentRow.Cells["TabIVA"].Value = dr.Cells[0].Value;
            gridUIFt1.CurrentRow.Cells["txiva"].Value = dr.Cells[1].Value;
            Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdoc.Sigla);
        }
        public DataTable DtIva { get; set; }
        public string Pjstamp { get; set; } = "";
        public string FactstampPrimeiravia { get; private set; }
        public string FactNumeroPrimeiravia { get; private set; }
        public bool UpdateOrigem { get; private set; }

        private int rowIndex;
        private void btnMenuDelLinha_Click(object sender, EventArgs e)
        {

            if (gridUIFt1.CurrentRow == null) return;

            var dr = MsBox.Show($"Deseja eliminar o artigo: {gridUIFt1.Rows[rowIndex].Cells["descricao"].Value}", DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            gridUIFt1.Rows.RemoveAt(gridUIFt1.CurrentRow.Index);
            gridUIFt1.Update();
        }
        private void btnMenuRefresh_Click(object sender, EventArgs e)
        {
            Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdoc.Sigla);
        }
        private void btnMenuContas_Click(object sender, EventArgs e)
        {

        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            //MenuPrint.ShowMenuStrip(btnPrint);
            var retorno = Imprimir.Valido(Usracessos, Cliente.tb1.Text);
            if (retorno.Imprimir)
            {
                if (Inserindo)
                {
                    FillEntity(_ft);
                    gridUIFt1.Update();
                    gridFormasP1.Grelha.Update();
                }
                DS ds = new DS();
                var factl = gridUIFt1.GetBindedTable();
                var formasp = gridFormasP1.Grelha.DataSource as DataTable;
                Utilities.AllTrim(_ft);
                var ret = Imprimir.FillData(_ft.ToDataTable(), factl, formasp, ds.Fact, ds.Formasp);
                Imprimir.RepreencherCl(ret, _cliente);
                Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, Inserindo, label1.Text, Cliente.Text2, TmpTdoc.Nomfile, "FT", this, TmpTdoc.XmlString, true, ds, "", "");
            }
            else
            {
                MsBox.Show(retorno.Messagem);
            }
        }
        private void gridUIFt1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            var nome = gridUIFt1.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("ivainc"))
            {
                gridUIFt1.CurrentCell.Value = !gridUIFt1.CurrentCell.Value.ToBool();
                gridUIFt1.Update();
                Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdoc.Sigla);
            }
            if (nome.Equals("select"))
            {
                if (_cliente == null) return;
                var m = new FrmMoradas { Enviar = Receber2, Clstamp = _cliente.Clstamp };
                m.ShowForm(this);
            }

            if (nome.Equals("endereco"))
            {
                if (gridUIFt1.CurrentRow == null) return;
                var servico = gridUIFt1.CurrentRow.Cells["servico"].Value.ToBool();
                if (servico) return;
                var referenc = gridUIFt1.CurrentRow.Cells["ref1"].Value.ToString().Trim();
                var armazem = gridUIFt1.CurrentRow.Cells["Armazem"].Value.ToDecimal();
                var endereco = SQL.GetValue("endereco", "starm", $"ref='{referenc}' and Codarm ={armazem}");
                var m = new FrmEndereco { textBox1 = { Text = endereco.ToUpper() } };
                m.ShowForm(this, true);
            }
        }

        private void Receber2(ClMorada obj)
        {
            if (gridUIFt1.CurrentRow == null) return;
            gridUIFt1.CurrentRow.Cells["Morada"].Value = obj.Morada;
            gridUIFt1.CurrentRow.Cells["Telefone"].Value = obj.Telefone;
            gridUIFt1.CurrentRow.Cells["Email"].Value = obj.Email;
            gridUIFt1.CurrentRow.Cells["Pcontacto"].Value = obj.Pessoa;

        }
        private void MostraMorada(Tdoc tdoc)
        {
            if (gridUIFt1 == null) return;
            gridUIFt1.Columns["Morada"].Visible = tdoc.Lancaend;
            gridUIFt1.Columns["Telefone"].Visible = tdoc.Lancaend;
            gridUIFt1.Columns["Email"].Visible = tdoc.Lancaend;
            gridUIFt1.Columns["Pcontacto"].Visible = tdoc.Lancaend;
            gridUIFt1.Columns["Pais"].Visible = tdoc.Lancaend;
            gridUIFt1.Columns["Entrega"].Visible = tdoc.Lancaend;
            gridUIFt1.Columns["select"].Visible = tdoc.Lancaend;//Dataentrega
            gridUIFt1.Columns["Dataentrega"].Visible = tdoc.Lancaend;//
        }
        private void gridUIFt1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //if (gridUIFt1.CurrentCell.OwningColumn.Name.Trim().ToLower().Equals("tabiva")) return;
            //var validClick = e.RowIndex != -1 && e.ColumnIndex != -1; //Make sure the clicked row/column is valid.
            //var datagridview = sender as DataGridView;
            //// Check to make sure the cell clicked is the cell containing the combobox 
            //if (!(datagridview?.Columns[e.ColumnIndex] is DataGridViewTextBoxColumn) || !validClick) return;
            //datagridview.BeginEdit(true);
            //// ((TextBox)datagridview.EditingControl). = true;
            ////Helper.CellEnter(sender,e);
        }
        private void btnAnular_Click(object sender, EventArgs e)
        {
            if (TmpTdoc.Ft || TmpTdoc.Nd || TmpTdoc.Nc || TmpTdoc.Vd)
            {
                if (!string.IsNullOrEmpty(Cliente.tb1.Text))
                {
                    if (!_ft.Anulado)
                    {
                        var drl = MsBox.Show($"Deseja anular: {TmpTdoc.Descricao} nº: {tbNumero.tb1.Text}?", DResult.YesNo);
                        if (drl.DialogResult != DialogResult.Yes) return;
                        var xx = CheckMovimentos("cancelar");
                        if (!xx.ret) return;
                        _ft.Anulado = true;
                        cbAnulado.Update(true);
                        if (EF.Save(_ft).ret > 0)
                        {
                            var factl = gridUIFt1.GetBindedTable();
                            if (factl.HasRows())
                            {
                                foreach (var dr in factl.AsEnumerable())
                                {
                                    if (dr == null) continue;
                                    dr["LineAnulado"] = true;
                                }
                                SQL.Save(factl, "factl", !Procurou, CLocalStamp, Ctabela);
                                if (Pbl.Param.ObrigaNc)
                                {
                                    if (CriarNC("Anular o documento", xx.valorpreg, factl))
                                    {
                                        Helper.Alert("Nota de Crédito criada com sucesso", Form_Alert.EnmType.Success);
                                    }
                                    else
                                    {
                                        MsBox.Show(Messagem.ParteInicial() + "O Software não consiguiu gerar Nota de Crédito, o Processo será cancelado!\r\n Informe o administrator ");
                                        CancelarMovimento(factl);
                                    }
                                }
                                else
                                {
                                    SQL.SqlCmd($"delete from cc where ltrim(rtrim(Factstamp)) ='{_ft.Factstamp.Trim()}'");
                                }
                            }
                            else
                            {
                                MsBox.Show(Messagem.ParteInicial() + "O Software não encontrou as linhas do documento, o Processo não será finalizado com sucesso!");
                                CancelarMovimento(factl);
                            }
                        }
                        else
                        {
                            MsBox.Show(Messagem.ParteInicial() + "O Software não consiguiu actualizar o documento, o Processo não será finalizado com sucesso!");
                        }
                        //var pergunta=MsBox.Show(Messagem.ParteInicial()+$"O Software vai criar a Nota de crédito, correspondente a {TmpTdoc.Descricao} a anular!, Deseja avançar?", DResult.YesNo);
                        //if (pergunta.DialogResult == DialogResult.Yes)
                        //{


                        //}
                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "O documento já está cancelado!");
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + $"Deve indicar a {TmpTdoc.Descricao}! que pretende cancelar");
                }
            }
        }

        private void CancelarMovimento(DataTable factl)
        {
            _ft.Anulado = false;
            cbAnulado.Update(false);
            EF.Save(_ft);
            if (factl.HasRows())
            {
                foreach (var dr in factl.AsEnumerable())
                {
                    if (dr == null) continue;
                    dr["LineAnulado"] = false;
                }
                SQL.Save(factl, "factl", !Procurou, CLocalStamp, Ctabela);
            }
        }

        private bool CriarNC(string text, decimal valorpreg, DataTable factl)
        {
            var tdoc = SQL.GetRowToEnt<Tdoc>("nc=1");
            var ft = Utilities.DoAddline<Fact>();
            ft.Factstamp = Pbl.Stamp();
            ft.Sigla = tdoc.Sigla;
            ft.Data = Pbl.SqlDate;
            ft.Datcaixa = Pbl.SqlDate;
            ft.Numdoc = tdoc.Numdoc;
            ft.Nomedoc = tdoc.Descricao;
            ft.Movtz = false;
            ft.Movstk = true;
            ft.Descmovstk = tdoc.Descmovstk;
            ft.Codmovstk = tdoc.Codmovstk;
            ft.Movcc = false;
            ft.Origem = tdoc.Sigla;
            ft.Descmovcc = tdoc.Descmovcc;
            ft.Codmovcc = tdoc.Codmovcc;
            ft.Moeda = _ft.Moeda.Trim();
            ft.Ccusto = _ft.Ccusto;
            ft.Clstamp = _ft.Clstamp;
            if (_ft.Total == valorpreg)
            {
                ft.Total = -1 * _ft.Total;
                ft.Totaliva = -1 * _ft.Totaliva;
                ft.Subtotal = -1 * _ft.Subtotal;
                ft.Desconto = -1 * _ft.Desconto;
            }
            else
            {
                ft.Total = -1 * valorpreg;
                ft.Totaliva = -1 * (valorpreg * (decimal)0.17);
                ft.Subtotal = -1 * (valorpreg - (ft.Totaliva));
                ft.Desconto = 0;
            }
            ft.No = _ft.No;
            ft.Nome = _ft.Nome;
            ft.Oristamp = _ft.Factstamp;
            ft.Nrdocanuala = _ft.Numero;
            ft.Morada = _ft.Morada;
            ft.Morada2 = _ft.Morada2;
            ft.Nuit = _ft.Nuit;
            ft.Email = _ft.Email;
            ft.Telefone = _ft.Telefone;
            ft.Motivoanula = text;
            var cond = $"numdoc={tdoc.Numdoc} and year(data) = {Pbl.SqlDate.Year} and mesa=0 and Ccusto='{Pbl.Usr.Ccusto.Trim()}'";
            var max = SQL.Maximo(Ctabela, "numero", cond);
            ft.Numero = max.ToString();
            ft.Obs = $"Foi emitida uma nota de crédito nº:{max} \r\nPor seguinte(s) motivo(s):\r\n{text} ";
            var factl2 = new DataTable("factl");
            if (factl2.CopyColumnsFrom(factl))
            {
                foreach (var dr in factl.AsEnumerable())
                {
                    if (dr == null) continue;
                    var row = factl2.NewRow();
                    foreach (DataColumn col in factl.Columns)
                    {
                        switch (col.ColumnName.ToLower().Trim())
                        {
                            case "factlstamp":
                                row["factlstamp"] = Pbl.Stamp();
                                break;
                            case "factstamp":
                                row["factstamp"] = ft.Factstamp;
                                break;
                            case "oristampl":
                                row["oristampl"] = dr["factlstamp"];
                                break;
                            case "quant":
                                row["quant"] = -1 * dr["quant"].ToDecimal();
                                break;
                            case "valival":
                                row["valival"] = -1 * dr["valival"].ToDecimal();
                                break;
                            case "subtotall":
                                row["subtotall"] = -1 * dr["subtotall"].ToDecimal();
                                break;
                            case "totall":
                                row["totall"] = -1 * dr["totall"].ToDecimal();
                                break;
                            case "mvalival":
                                row["mvalival"] = -1 * dr["mvalival"].ToDecimal();
                                break;
                            case "msubtotall":
                                row["msubtotall"] = -1 * dr["msubtotall"].ToDecimal();
                                break;
                            default:
                                {
                                    if (col.ColumnName.ToLower().Trim().Equals("totall"))
                                    {
                                        row["mtotall"] = -1 * dr["mtotall"].ToDecimal();
                                    }
                                    else
                                    {
                                        row[col.ColumnName] = dr[col.ColumnName];
                                    }

                                    break;
                                }
                        }
                    }
                    factl2.Rows.Add(row);
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "O Software não consiguiu copiar colunas do Factl, Operção não pode continuar");
                CancelarMovimento(factl);
                return false;
            }
            EF.Save(ft);
            SQL.Save(factl2, "factl", true, ft.Factstamp, Ctabela);
            SQL.SqlCmd($"update cc set debitof =debitof+{valorpreg} where ltrim(rtrim(Factstamp)) ='{_ft.Factstamp.Trim()}'");
            //SQL.SqlCmd($"update cc set debitof =-1*(debitof+{valorpreg}) where ltrim(rtrim(Factstamp)) ='{ft.Factstamp.Trim()}'");
            //SQL.SqlCmd($"update cc set debitof =-1*(debitof+{valorpreg}) where ltrim(rtrim(Factstamp)) ='{ft.Factstamp.Trim()}'");
            SQL.SqlCmd($"delete from cc where ltrim(rtrim(Factstamp)) ='{ft.Factstamp.Trim()}'");
            return true;
        }

        private (bool ret, decimal valorpreg) CheckMovimentos(string mensagem)
        {
            mensagem += $" a {TmpTdoc.Descricao}!";
            if (TmpTdoc.Ft || TmpTdoc.Nd || TmpTdoc.Nc)
            {
                //var dt =GetCC();
                //if (dt.HasRows())
                //{
                //    var valorpreg =dt.Rows[0]["valorpreg"].ToDecimal();
                //    MsBox.Show(Messagem.ParteInicial()+$"A {TmpTdoc.Descricao} tem: {valorpreg.ToString().SetMask()}{_ft.Moeda}! não regularizados! \r\nO Software vai criar uma nota de crédito no valor correspondente");
                //    return (true,valorpreg);
                //}
                var dt2 = SQL.GetGen2DT($"select Ccstamp from rcll where Ccstamp='{_ft.Factstamp.Trim()}'and Anulado=0");
                if (dt2.HasRows())
                {
                    MsBox.Show(Messagem.ParteInicial() + $"Não se pode {mensagem} a {TmpTdoc.Descricao}!. Existe(m) documento(s) de regularização (Recibo ou Nota de crédito) emitido(s)!");
                    return (true, 0);
                }
            }
            return (false, 0);
        }
        private void gridUIFt1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            //if (gridUIFt1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value == DBNull.Value)
            //{
            //    e.Cancel = true;
            //}
        }
        private void tbCcusto_RefreshControls()
        {
            _ft.Ccusto = tbCcusto.tb1.Text;
        }
        private void gridUIFt1_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode != Keys.Enter) return;
            //NewGridLine();
            //gridUIFt1.CurrentCell = gridUIFt1.Rows[gridUIFt1.Rows.Count - 1].Cells["Descricao"];
        }
        public void NewGridLine()
        {
            DataRow = Helper.NewGridRow(this, TmpTdoc.Nc);
        }
        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        private void btnCopylinhas_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            var form = new FrmCopylinhas { SendData = ReceiveDataFromCopyLinhas };
            form.ShowForm(this, true);
        }
        public void ReceiveDataFromCopyLinhas(DataTable dt, DataTable dt2, string tabela, bool linhaResumo)
        {
            if (dt2.HasRows())
            {
                if (linhaResumo)
                {
                    var dr = CriarLinha();
                    var descricao = $@"{dt2.Rows[0]["Nomedoc"].ToString().Trim()} Nº: {dt2.Rows[0]["numero"].ToString().Trim()} de {dt2.Rows[0]["data"].ToDateTimeValue().ToShortDateString().Trim()}";
                    dr["descricao"] = descricao;
                    dr["servico"] = true;
                    dr["Factstamp"] = CLocalStamp;
                    dr["Factlstamp"] = Pbl.Stamp();
                    gridUIFt1.DsDt.Rows.Add(dr);
                }
                if (dt.HasRows())
                {
                    foreach (var row in dt.AsEnumerable())
                    {
                        if (row != null)
                        {
                            var dr = CriarLinha();
                            foreach (DataColumn col in dt.Columns)
                            {
                                if (dr.Table.Columns.Contains(col.ColumnName))
                                {
                                    dr[col.ColumnName.ToLower().Trim()] = row[col.ColumnName.ToLower().Trim()];
                                }
                            }
                            if (TmpTdoc.Nc)
                            {
                                dr["Quant"] = -1 * dr["Quant"].ToDecimal();

                            }
                            dr["Factstamp"] = CLocalStamp;
                            if (!tabela.IsNullOrEmpty())
                            {
                                dr["oristampl"] = row[$"{tabela.Trim()}lstamp"];
                                dr["Ststamp"] = row["Ststamp"];
                            }
                            dr["Factlstamp"] = Pbl.Stamp();
                            if (!row["servico"].ToBool())
                            {
                                if (row["Armazemstamp"].ToString().IsNullOrEmpty())
                                {
                                    dr["Armazemstamp"] = Pbl.Usr.Armazemstamp;
                                }
                            }
                            gridUIFt1.DsDt.Rows.Add(dr);
                        }
                        linhaResumo = false;
                    }
                    Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdoc.Sigla);
                    //if (TmpTdoc.Nc)
                    //{
                    //    gridUIFt1.ReadOnly = true;
                    //    Cliente.Enabled = false;
                    //}
                }
                if (dt2.HasRows())
                {
                    _ft.Oristamp = dt2.Rows[0]["stamp"].ToString();
                    tbNumdocanulado.tb1.Text = dt2.Rows[0]["numero"].ToString();
                    _ft.Campo1 = tabela;
                    _ft.Campo2 = dt2.Rows[0]["Total"].ToString();
                }
            }
        }

        private DataRow CriarLinha()
        {
            var dr = gridUIFt1.DsDt.NewRow().Inicialize();
            var nMaxOrdem = gridUIFt1.DsDt.Rows.Count;
            nMaxOrdem = nMaxOrdem + 1;
            dr["ordem"] = nMaxOrdem;
            return dr;
        }

        private void FillGrid(DataTable dt, bool tabela)
        {
            if (!(dt?.Rows.Count > 0)) return;
            foreach (var row in dt.AsEnumerable())
            {
                if (row != null)
                {
                    DataRow = Helper.NewGridRow(this);
                    var tmpFound = SQL.GetRowToEnt<St>($"Ststamp ='{row["ststamp"].ToString().Trim()}'");// EF.GetEnt<St>(x=>x.Ststamp.Trim().Equals(row["ststamp"].ToString().Trim()));
                    GenBl.SetLineValues(DataRow, tmpFound, _ft, true, row, TmpTdoc.Nc, ucMoeda.tb1.Text, MoedaCambio.tb1.Text.Trim(), Cliente.Text3);
                }
            }
            _ft.Oristamp = dt.Rows[0][$"{dt.TableName.Replace("l", "stamp").Trim()}"].ToString();
            Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdoc.Sigla);
        }
        private void btnValorPanelShow_Click(object sender, EventArgs e)
        {
            panelContravalor.Visible = !panelContravalor.Visible;
            btnValorPanelShow.Image = panelContravalor.Visible ? Properties.Resources.Show_Sidepanel_25px : Properties.Resources.Hide_Sidepanel_25px;
        }
        private void MoedaCambio_RefreshControls()
        {
            if (!MoedaCambio.tb1.Text.ToLower().Equals(Pbl.MoedaBase.ToLower()))
            {
                TaxaCambio = SQL.ExecCambio(MoedaCambio.tb1.Text.Trim());
                tbTaxaCambio.tb1.Text = TaxaCambio.ToString();
                ucMoeda.tb1.Text = Pbl.MoedaBase;
                Helper.ShowHideMoedaColumns(true, MoedaCambio.tb1.Text, gridUIFt1);
                if (gridUIFt1.Rows.Count > 0)
                {
                    var dt = gridUIFt1.DataSource as DataTable;
                    if (dt?.Rows.Count > 0)
                    {
                        dt = GenBl.CambiaLinhas(dt, tbTaxaCambio.tb1.Text.ToDecimal(), MoedaCambio.tb1.Text, ucMoeda.tb1.Text);
                        gridUIFt1.DataSource = null;
                        gridUIFt1.DataSource = dt;
                        Helper.TotaisFt(dt, this);
                    }
                }
            }
            else
            {
                MoedaCambio.tb1.Text = "";
                TaxaCambio = 0;
                tbTaxaCambio.tb1.Text = "";
                ucMoeda.tb1.Text = Pbl.MoedaBase;
                Helper.ShowHideMoedaColumns(false, "", gridUIFt1);
                Helper.UpDateCambioLinhas(0, gridUIFt1, tbSuttotalMoeda, tbIvaMoeda, tbtotalMoeda, tbDescontoMoeda);
            }
        }



        private void Cambiar()
        {
            if (TaxaCambio <= 0) return;
            if (!string.IsNullOrEmpty(tbTotal.tb1.Text))
            {
                tbtotalMoeda.tb1.Text = GetValor(tbTotal);
            }
            if (!string.IsNullOrEmpty(tbTotalIva.tb1.Text))
            {
                tbIvaMoeda.tb1.Text = GetValor(tbTotalIva);
            }
            if (!string.IsNullOrEmpty(tbDesconto.tb1.Text))
            {
                tbDescontoMoeda.tb1.Text = GetValor(tbDesconto);
            }
            if (!string.IsNullOrEmpty(tbSubTotal.tb1.Text))
            {
                tbSuttotalMoeda.tb1.Text = GetValor(tbSubTotal);
            }
        }

        private string GetValor(TbDefault tbDefault)
        {
            var ret = "0";
            if (!string.IsNullOrEmpty(ucMoeda.tb1.Text))
            {
                if (ucMoeda.tb1.Text.Equals("MZN"))
                {
                    ret = Math.Round(tbDefault.tb1.Text.ToDecimal() / TaxaCambio, 0).ToString();
                }
                else
                {
                    ret = Math.Round(tbDefault.tb1.Text.ToDecimal() * TaxaCambio, 0).ToString();
                }
            }
            else
            {
                Messagem.DoEmptyMoedaVenda();
            }
            // return Math.Round(tbDefault.tB1.Text.ToDecimal() / TaxaCambio,0).ToString();
            return ret;
        }

        private void gridUIFt1_CellLeave(object sender, DataGridViewCellEventArgs e)
        {
            //gridUIFt1.EndEdit();
        }

        private bool dmzGridButtons1_BeforeAddLineEvent()
        {
            if (string.IsNullOrEmpty(Cliente.tb1.Text))
            {
                MsBox.Show(Messagem.ParteInicial() + "Deve indicar o cliente!");
                return true;
            }
            //if (TmpTdoc.Nc)
            //{
            //    if (!cbNcMovcc.cb1.Checked && !cbNcMovtz.cb1.Checked)
            //    {
            //        MsBox.Show(Messagem.ParteInicial()+"Deve indicar o tipo de nota de crédito!");
            //        return true;
            //    }
            //}
            if (!OrigReserva) return false;
            var f = new FrmGuiaList
            {
                No = Cliente.Text2.ToDecimal(),
                SendData = ReceiveDataFromCopyLinhas,
                Sumcampos = "Reserva-Reservasaida",
                Nome = Cliente.tb1.Text.Trim()
            };
            f.ShowForm(this);
            return true;
        }
        private void ReceiveDataFromCopyLinhas(DataTable dt)
        {
            if (!(dt?.Rows.Count > 0)) return;
            gridUIFt1.DsDt.Rows.Clear();
            foreach (var row in dt.AsEnumerable())
            {
                DataRow = Helper.NewGridRow(this);
                var tmpFound = SQL.GetRowToEnt<St>($"Referenc ='{row["ref"].ToString().Trim()}'");// EF.GetEnt<St>(x=>x.Referenc.Trim().Equals(row["ref"].ToString().Trim()));
                GenBl.SetLineValues(DataRow, tmpFound, _ft, true, row, false, ucMoeda.tb1.Text, MoedaCambio.tb1.Text.Trim(), Cliente.Text3);
                DataRow["Armazem"] = row["Codarm"];
                DataRow["Descarm"] = row["armazem"];
            }

            // di.Oristamp = dt.TableName.Equals("dil") ? dt.Rows[0]["distamp"].ToString() : dt.Rows[0]["Factstamp"].ToString();
            Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdoc.Sigla);
        }

        private void procura1_Load(object sender, EventArgs e)
        {

        }

        private void btnMoradaactual_Click(object sender, EventArgs e)
        {

        }

        private void tbnMoradas_Click(object sender, EventArgs e)
        {

        }

        void Receber(ClMorada m)
        {
            tbLocalEntrega.tb1.Text = m.Departamento + 2 + @" - " + m.Morada;
            tbTelefoneentrega.tb1.Text = m.Telefone;
            Emailentrega.tb1.Text = m.Email;
            tbPessoaContacto.tb1.Text = m.Pessoa;
            tbDepartamento.tb1.Text = m.Departamento;
        }

        private void btnMenuMoradas_Click(object sender, EventArgs e)
        {
            dmzMenuMoradas.ShowMenuStrip(btnMenuMoradas);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            if (_cliente == null) return;
            tbLocalEntrega.tb1.Text = _cliente.Morada;
            tbTelefoneentrega.tb1.Text = _cliente.Telefone;
            Emailentrega.tb1.Text = _cliente.Email;
            tbPessoaContacto.tb1.Text = SQL.GetValue("Nome", "ClContact", $"Clstamp='{_cliente.Clstamp.Trim()}' and rep=1");
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            if (_cliente == null) return;
            var m = new FrmMoradas { Enviar = Receber, Clstamp = _cliente.Clstamp };
            m.ShowForm(this);
        }

        private void btnDocsfact_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void emitirReciboToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            // Imprimir.DoPrint(CLocalStamp, Inserindo, label1.Text, Cliente.Text2, TmpTdoc.Nomfile, "FT", this, Linguas.PT, TmpTdoc.XmlString);
            if (Pbl.Param.Segundavia)
            {
                if (!_ft.SegundaVia)
                {
                    SQL.SqlCmd($"update fact set SegundaVia=1 where factstamp='{CLocalStamp.Trim()}' ");
                    _ft.SegundaVia = true;
                }
            }
        }

        private void nORMALDIRECTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dt = gridUIFt1.DataSource as DataTable;
            if (dt?.Rows.Count > 0)
            {
                //PrintDt=Helper.FillPrintDt(_ft.Factstamp);
                //ReportHelper.PrintReport(_ft.Factstamp,true,TmpTdoc.Nomfile,"fact",1);
            }
            else
            {
                Helper.Alert("O documento não tem linhas para impressão!", Form_Alert.EnmType.Warning);
            }
        }

        private void gridPreco_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridPreco.Anexos();
        }

        private void nToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Imprimir.DoPrint(CLocalStamp,Inserindo,label1.Text,Cliente.Text2,TmpTdoc.Nomfile,"FT",this,Linguas.EN, TmpTdoc.XmlString);
        }


        private void btnRecEmitidos_Click(object sender, EventArgs e)
        {
            VerRecibos();
        }

        private DataTable GetCC()
        {
            var str = $@"select * from rcl join rcll on rcl.Rclstamp = rcll.Rclstamp
                where ltrim(rtrim(ccstamp))='{_ft.Factstamp.Trim()}' ";
            return SQL.GetGen2DT(str);
        }

        private void btnRCL_Click(object sender, EventArgs e)
        {
            GeraRecibo();
        }
        private (bool valido, List<Usracessos> lista) IsAllValido(string tdoc)
        {
            (bool valido, List<Usracessos> lista) ret = (false, null);
            if (!Inserindo)
            {
                lista = Pbl.Usracessos.Where(x => x.Origem.ToLower().Equals(tdoc.ToLower())).ToList();
                if (lista?.Count > 0)
                {
                    if (!string.IsNullOrEmpty(Cliente.Text2))
                    {
                        var lista2 = lista.Where(linha => linha.Ver).ToList();
                        if (lista2.Count > 0)
                        {
                            ret = (true, lista2);
                        }
                        else
                        {
                            MsBox.Show($"Estimado(a) {Pbl.Usr.Nome} não tem acesso a factura . contacte administrator!");
                        }
                    }
                    else
                    {
                        MsBox.Show($"Estimado(a) {Pbl.Usr.Nome} o documento não tem cliente definido. \r\nNão é possivel emitir o documento pretendido! ");
                    }
                }
                else
                {
                    MsBox.Show($"Desculpa não tem acessos definidos para {Pbl.Usr.Nome}. contacte administrator!");
                }
            }
            else
            {
                MsBox.Show($"Estimado(a) {Pbl.Usr.Nome},o documento  está em criação. \r\nNão é possivel emitir o documento pretendido!");
            }
            return ret;
        }
        private void btnRecebimento_Click(object sender, EventArgs e)
        {

        }

        private void btnRecebidos_Click(object sender, EventArgs e)
        {
            if (_ft == null)
            {
                MsBox.Show("Deve indicar o documento pretendido!");
            }
            else
            {
                var str = $@" select Documento ='RECIBO'+' - '+Convert(char,Numero),nome as Cliente,Convert(DATE,rcl.Data) Data, Valorreg as Valor 
                    from rcl join rcll on rcl.Rclstamp= rcll.Rclstamp where Ccstamp ='{_ft.Factstamp.Trim()}' order by Numero";
                var dt = SQL.GetGen2DT(str);
                if (dt?.Rows.Count > 0)
                {
                    var f = new FrmShowData
                    {
                        gridUi1 = { DataSource = null },
                        label1 = { Text = $"Recibos emitidos da factura - {_ft.Numero}/{_ft.Data.Year}" }
                    };
                    f.gridUi1.DataSource = dt;
                    f.CamposToFill = "Documento,Cliente";
                    f.ShowForm(this, true);
                }
                else
                {
                    MsBox.Show("Não foi encontrado nenhum recibo para este documento");
                }
            }
            //CallFormLista("trcl","RCL",@"Todos recebimentos emitidos".ToUpper(),"");
        }

        private void CallFormLista(string tdoc, string tabela, string caption, string origem = "PJ")
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
            f.Origem = origem;
            f.Condicao = $"";
            f.ShowForm(this);
        }

        private void ucMoeda_RefreshControls()
        {
            if (!ucMoeda.tb1.Text.ToLower().Equals(Pbl.MoedaBase.ToLower()))
            {
                TaxaCambio = SQL.ExecCambio(ucMoeda.tb1.Text.Trim());
                tbTaxaCambio.tb1.Text = TaxaCambio.ToString();
                MoedaCambio.tb1.Text = Pbl.MoedaBase;
                Helper.ShowHideMoedaColumns(true, ucMoeda.tb1.Text.Trim(), gridUIFt1);
                Helper.UpDateCambioLinhas(tbTaxaCambio.tb1.Text.ToDecimal(), gridUIFt1, tbSuttotalMoeda, tbIvaMoeda, tbtotalMoeda, tbDescontoMoeda);
            }
            else
            {
                MoedaCambio.tb1.Text = "";
                tbTaxaCambio.tb1.Text = "";
                TaxaCambio = 0;
                Helper.ShowHideMoedaColumns(false, "", gridUIFt1);
                Helper.UpDateCambioLinhas(0, gridUIFt1, tbSuttotalMoeda, tbIvaMoeda, tbtotalMoeda, tbDescontoMoeda);
            }

            if (!string.IsNullOrEmpty(ucMoeda.tb1.Text))
            {

                Helper.UpdateFormaspMoeda(gridFormasP1, ucMoeda.tb1.Text);
            }
        }

        private void SaveCl()
        {
            cl.Rows[0]["morada"] = tbMorada.tb1.Text;
            cl.Rows[0]["nuit"] = tbNuit.tb1.Text;
            cl.Rows[0]["email"] = tbEmail.tb1.Text;
            cl.Rows[0]["Celular"] = tbCelular.tb1.Text;
            if (SQL.Save(cl, "cl", true, "", "").numero == 1)
            {
                Helper.Alert("Cliente actualizado com sucesso!", Form_Alert.EnmType.Success);
                _cliente = SQL.GetRowToEnt<Cl>($"no='{Cliente.Text2}' and DeficilCobrar=0");
            }
        }
        private void btnUpdateFnc_Click(object sender, EventArgs e)
        {
            if (!Cliente.OpenInfo)
            {
                SaveCl();
            }
            else
            {
                cl = SQL.Initialize("cl");
                var r = cl.NewRow().Inicialize();
                r["no"] = SQL.Maximo("cl", "no", "");
                Cliente.Text2 = r["no"].ToString();
                Cliente.Text3 = r["clstamp"].ToString();
                r["nome"] = Cliente.tb1.Text;
                r["morada"] = tbMorada.tb1.Text;
                r["nuit"] = tbNuit.tb1.Text;
                r["email"] = tbEmail.tb1.Text;
                r["Celular"] = tbCelular.tb1.Text;
                r["moeda"] = Pbl.MoedaBase;
                cl.Rows.Add(r);
                if (SQL.Save(cl, "cl", true, "", "").numero == 1)
                {
                    Helper.Alert(@"Cliente Gravado com sucesso!", Form_Alert.EnmType.Success);
                    _cliente = SQL.GetRowToEnt<Cl>($"clstamp='{Cliente.Text3}' and DeficilCobrar=0");
                    Cliente.OpenInfo = false;
                }
                else
                {
                    MsBox.Show("Ocorreu um erro, cliente não gravado! Não pode proceguir com a facturação!");
                }

            }
        }

        private void gridUIFt1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUIFt1.CurrentRow == null) return;
            gridUIFt1.BeginEdit(true);
        }

        private void btnDuplicar_Click(object sender, EventArgs e)
        {
            dmzOptions.ShowMenuStrip(btnDuplicar);
        }

        private void tbDefault4_Load(object sender, EventArgs e)
        {

        }

        private void btnLimparcambio_Click(object sender, EventArgs e)
        {
            var dr = MsBox.Show(Messagem.ParteInicial() + "Deseja Limpar os valores totais de cambio?", DResult.YesNo);
            if (dr.DialogResult == DialogResult.Yes)
            {
                tbSuttotalMoeda.tb1.Text = "";
                tbDescontoMoeda.tb1.Text = "";
                tbIvaMoeda.tb1.Text = "";
                tbtotalMoeda.tb1.Text = "";
            }
        }

        private void btnSegundavia_Click(object sender, EventArgs e)
        {

        }

        private void dmzGridButtons1_AfterAddLineEvent()
        {
            //if (TmpTdoc.Nc)
            //{
            //    if (gridUIFt1.CurrentRow != null)
            //    {
            //        gridUIFt1.CurrentRow.Cells["Quant"].Value =-1;
            //    }
            //}
        }

        private void tbPj_RefreshControls()
        {

        }

        //private void cbNcMovtz_CheckedChangeds()
        //{
        //    if (TmpTdoc.Movtz)
        //    {
        //        gridFormasP1.Visible = true;
        //        gridFormasP1.Movtz = true;
        //    }
        //    cbNcMovcc.Update(false);

        //}

        //private void cbNcMovcc_CheckedChangeds()
        //{
        //    if (!TmpTdoc.Movtz)
        //    {
        //        gridFormasP1.Visible = false;
        //        gridFormasP1.Movtz = false;
        //    }
        //    cbNcMovtz.Update(false);
        //}

        private void tbDefault5_Load(object sender, EventArgs e)
        {

        }

        private void gridUIFt1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!gridUIFt1.CurrentCell.OwningColumn.Name.Equals("Descricao")) return;
            var f = new FrmEditRlt { SendInfo = Receive, tbQuerry = { Text = gridUIFt1.CurrentCell.Value.ToString() } };
            f.ShowForm(this, true);
        }
        void Receive(string str)
        {
            gridUIFt1.CurrentCell.Value = str;
        }

        private void nOTADEENTREGAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Imprimir.DoPrint(CLocalStamp, Inserindo, label1.Text, Cliente.Text2, "RptFactERNota", "FT", this, Linguas.PT);
            if (!Cliente.tb1.Text.IsNullOrEmpty())
            {
                //var frmset = new FrmPrintset();
                //frmset.DadosEnviados += PrintFile;
                //frmset.Ps.CLocalStamp = CLocalStamp;
                //frmset.Ps.Inserindo = Inserindo;
                //frmset.Ps.OrigemlabelText = label1.Text;
                //frmset.Ps.No = Cliente.Text2;
                //frmset.Ps.Nomfile=TmpTdoc.Nomfile;
                //frmset.Ps.Origem = "FT";
                //frmset.Ps.MdiForm = this;
                //frmset.Ps.XmlString = TmpTdoc.XmlString;

                //DS d = new DS();
                //var dtft = d.Fact;
                //var dtfp = d.Formasp;
                //var factl = gridUIFt1.GetBindedTable();
                //var formasp = gridFormasP1.Grelha.DataSource as DataTable;
                //var ret = FillData(_ft, factl, formasp, dtft, dtfp);
                //ret.dtPrint.TableName = "fact";
                //frmset.Ps.DtPrint = ret.dtPrint;
                //frmset.Ps.Formasp = ret.fp;
                //frmset.ShowForm(this);
            }
            else
            {
                MsBox.Show("Deve indicar o documento!..");
            }
        }

        private void PrintFile(string impressoara, decimal numImpresoes, List<string> lista, string lingua)
        {
            //if (EditMode)
            //{
            //    DS d = new DS();
            //    var dtft = d.Fact;
            //    var dtfp = d.Formasp;
            //    var factl = gridUIFt1.GetBindedTable();
            //    var formasp=gridFormasP1.Grelha.DataSource as DataTable;
            //    var ret= FillData(_ft, factl, formasp,dtft, dtfp);
            //    ret.dtPrint.TableName = "fact";
            //    ReportHelper.PrintReport(ret.dtPrint,impressoara, TmpTdoc.XmlString, numImpresoes,lista, lingua, ret.fp);
            //}
        }


        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            if (Procurou)
            {
                var drs = MsBox.Show("Deseja duplicar o presente documento?", DResult.YesNo);
                if (drs.DialogResult == DialogResult.Yes)
                {
                    CLocalStamp = Pbl.Stamp();
                    var maximo = SQL.Maximo("fact", "numero", CCondicao);
                    _ft.Factstamp = CLocalStamp;
                    dtFact.dt1.Value = Pbl.SqlDate;
                    dtVencimento.dt1.Value = Pbl.SqlDate.AddDays(30);
                    tbNumero.tb1.Text = maximo.ToString();
                    Helper.UpdateLinhas(CLocalStamp, gridUIFt1, gridFormasP1.Grelha, "fact", "factl");
                }
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (Procurou)
            {
                if (!TmpTdoc.Nd)
                {
                    CallBrowdoc(true);
                }
                else
                {
                    MsBox.Show("Não pode transformar a Nota crédito, este documento de regras próprias!");
                }
            }
            else
            {
                MsBox.Show("Deve estar em modo de edição!");
            }
        }

        private void emitirReciboToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            GeraRecibo();
        }

        private void GeraRecibo()
        {
            if (!TmpTdoc.Ft && !TmpTdoc.Nc && !TmpTdoc.Nc) return;
            if (!Inserindo)
            {
                if (!string.IsNullOrEmpty(Cliente.tb1.Text))
                {
                    var dt = GenBl.GetCc(Cliente.Text3.Trim(), "clccf", "cl");
                    if (!(dt?.Rows.Count > 0)) return;
                    if (dt.AsEnumerable().Any(x => x.Field<string>("oristamp").Trim().Equals(CLocalStamp.Trim())))
                    {
                        var dtft = dt.AsEnumerable().Where(x => x.Field<string>("oristamp").Trim().Equals(CLocalStamp.Trim())).CopyToDataTable();
                        var retorno = IsAllValido("trcl");
                        if (!retorno.valido) return;
                        lista = retorno.lista;
                        var f = new FrmRcl
                        {
                            ListaUsracessos = lista,
                            Usracessos = lista.FirstOrDefault(),
                            _cl = SQL.GetRowToEnt<Cl>($"No ='{Cliente.Text2}'"), //EF.GetEnt<Cl>(x => x.No.Equals(Cliente.Text2))
                        };
                        f.Trclcondicao = "sigla ='RC'";
                        f.ShowForm(this);
                        f.btnNovo.PerformClick();
                        f.Cliente.tb1.Text = Cliente.tb1.Text;
                        f.tbCcusto.tb1.Text = tbCcusto.tb1.Text;
                        f.Cliente.button1.Enabled = false;
                        f.Cliente.Text2 = Cliente.Text2;
                        f.ReceiveData(dtft);

                    }
                    else
                    {
                        MsBox.Show(Messagem.ParteInicial() + "Não encontramos nenhuma conta corrente para este documento!");
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial() + "Deve indicar o cliente ou documento a emitir o recibo");
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "Não podemos emitir o recibo, a factura está em criação!");
            }
        }

        private void recibosEmitidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            VerRecibos();
        }

        private void VerRecibos()
        {
            if (TmpTdoc.Ft || TmpTdoc.Nd || TmpTdoc.Nc)
            {
                if (string.IsNullOrEmpty(Cliente.tb1.Text))
                {
                    MsBox.Show("Deve indicar o documento pretendido!");
                }
                else
                {
                    var dt = GetCC();
                    if (dt?.Rows.Count > 0)
                    {
                        var f = new FrmShowData
                        {
                            gridUi1 = { DataSource = null },
                            label1 = { Text = $"Recibos emitidos da factura - {_ft.Numero}/{_ft.Data.Year}" }
                        };
                        f.gridUi1.DataSource = dt;
                        f.CamposToFill = "Documento,Cliente";
                        f.ShowForm(this, true);
                    }
                    else
                    {
                        MsBox.Show("Não foi encontrado nenhum recibo para este documento");
                    }
                }
            }
        }

        private void segundaViaDoDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Procurou)
            {
                var drs = MsBox.Show("Deseja emitir segunda via do presente documento?", DResult.YesNo);
                if (drs.DialogResult == DialogResult.Yes)
                {
                    var xx = Pbl.Stamp();
                    CLocalStamp = xx;
                    var maximo = SQL.Maximo("fact", "numero", CCondicao);
                    factsegvia = new Factsegvia();
                    factsegvia.Factstamp = _ft.Factstamp;
                    factsegvia.Numero = _ft.Numero;
                    factsegvia.Data = _ft.Data;
                    factsegvia.Numerosegvia = maximo.ToString();
                    _ft.Factstamp = xx;
                    _ft.Oristamp = factsegvia.Factstamp;
                    tbNumeroSegvia.tb1.Text = _ft.Numero + "/" + _ft.Data.Year;
                    dtFact.dt1.Value = Pbl.SqlDate;
                    dtVencimento.dt1.Value = Pbl.SqlDate.AddDays(30);
                    tbNumero.tb1.Text = maximo.ToString();
                    _ft.SegundaVia = true;
                    _ft.Movcc = false;
                    _ft.Movtz = false;
                    _ft.Movstk = false;
                    _ft.Codmovstk = 0;
                    Helper.UpdateLinhas(CLocalStamp, gridUIFt1, gridFormasP1.Grelha, "fact", "factl");
                }
            }
        }

        private void copiarLinhasEmOutroDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            var form = new FrmCopylinhas { SendData = ReceiveDataFromCopyLinhas };
            form.ShowForm(this, true);
        }

        private void actualizarDeCódigoDeIntegraçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                var dr = MsBox.Show("Deseja actualizar o código CPOC, nas linhas do documento?", DResult.YesNo);
                if (dr.DialogResult == DialogResult.Yes)
                {
                    var dt = gridUIFt1.GetBindedTable();
                    if (dt.HasRows())
                    {
                        foreach (DataRow r in dt.AsEnumerable())
                        {
                            if (r != null)
                            {
                                string cpoc = SQL.GetFieldValue("st", "cpoc", $"referenc ='{r["ref"].ToString().Trim()}'").ToString();
                                if (!string.IsNullOrEmpty(cpoc))
                                {
                                    r["cpoc"] = cpoc;
                                }
                            }
                        }
                        gridUIFt1.SetDataSource(dt);
                    }
                }
            }
        }

        private void actualizarOCódigoDeGasóleoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                var dr = MsBox.Show("Deseja actualizar o código CPOC, nas linhas do documento?", DResult.YesNo);
                if (dr.DialogResult == DialogResult.Yes)
                {
                    var dt = gridUIFt1.GetBindedTable();
                    if (dt.HasRows())
                    {
                        foreach (DataRow r in dt.AsEnumerable())
                        {
                            if (r != null)
                            {
                                string cpoc = SQL.GetFieldValue("st", "cpoc", $"referenc ='{r["ref"].ToString().Trim()}'").ToString();
                                if (!string.IsNullOrEmpty(cpoc))
                                {
                                    r["cpoc"] = cpoc;
                                }
                            }
                        }
                        gridUIFt1.SetDataSource(dt);
                    }
                }
            }
        }

        private void importarFacturaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dt = SQL.GetGen2DT("select Numdoc,Descricao from tdoc order by Numdoc");
            Helper.ChamaformImport("fact", "factl", "", "Facturacao", null, dt);
        }

        private void importarGuiaDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!EditMode) return;
            if (!Cliente.tb1.Text.IsNullOrEmpty())
            {
                var form = new FrmCopylinhas { SendData = ReceiveDataFromCopyLinhas };
                var tab = SQL.GetGen2DT($"select numdoc,Descricao from tdi where vendido =1");
                var campos = Helper.GetCampos<Dil>();
                campos = campos.Replace("Quant2", "xxxx");
                campos = campos.Replace("Quant", "Quant=(quant-quant2)");
                campos = campos.Replace("xxxx", "Quant2");
                if (tab.HasRows())
                {
                    form.documento.Text2 = tab.RowZero("numdoc").ToString();
                    form.documento.tb1.Text = tab.RowZero("Descricao").ToString();
                    form.cliente.Text2 = Cliente.Text2;
                    form.cliente.tb1.Text = Cliente.tb1.Text;
                    form.cbDossierInterno.Update(true);
                    form.Campos = campos;
                }
                form.ShowForm(this, true);
                UpdateOrigem = true;
                cbMovstk.Update(false);
                cbVendaSemSaida.Update(true);
            }
            else
            {
                MsBox.Show("Deve indicar o cliente!");
            }
        }

        private void gerarGuiaDeEntregaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GerarGuiaDeEntrega();
        }

        private void GerarGuiaDeEntrega()
        {
            var dr = MsBox.Show("Deseja gerar a guia de entrega apartir deste documento?", DResult.YesNo);
            if (dr.DialogResult == DialogResult.Yes)
            {
                if (Procurou)
                {
                    if (_ft.Ft || _ft.Vd)
                    {
                        GeraGuia();
                        SQL.SqlCmd($"update fact set entrega=1 where  factstamp ='{_ft.Factstamp.Trim()}'");
                    }
                }
                else
                {
                    MsBox.Show("Só pode gerar guia de entrega para um documento gravado!");
                }
            }
        }

        private void btnGuia_Click(object sender, EventArgs e)
        {
            GerarGuiaDeEntrega();
        }

        private void emitirNotaDeCréditoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Procurou)
            {
                if (TmpTdoc.Ft || TmpTdoc.Vd || TmpTdoc.Nd)
                {
                    var tdoc = SQL.GetRow("select * from tdoc where sigla in ('NC')");
                    var docnumero = tbNumero.tb1.Text;
                    var docstamp = CLocalStamp;
                    var valordoc =tbTotal.tb1.Text.Trim();
                    BindTdoc(tdoc, true);
                    var dt = gridUIFt1.GetBindedTable();
                    foreach (var r in dt.AsEnumerable())
                    {
                        if (r != null)
                        {
                            r["quant"] = -1* r["quant"].ToDecimal();
                        }
                    }
                    gridUIFt1.Update();
                    Helper.Totaislinha(true, gridUIFt1.DsDt, this, TmpTdoc.Sigla);
                    tbNumdocanulado.tb1.Text = docnumero;
                    tbMotivo.tb1.Text = "Retificação do valor do documento!";
                    _ft.Oristamp = docstamp;
                    _ft.Campo2 = valordoc;
                }

                else
                {
                    MsBox.Show("Deve estar em modo de edição!");
                }
            }
        }

        private void tbTurma_RefreshControls()
        {
            tbAnosem.tb1.Text = tbTurma.Text3;
            tbEtapa.tb1.Text = tbTurma.Text4;
        }
    }
}
