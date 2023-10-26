using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using DMZ.UI.UI.Academia;

namespace DMZ.UI.UI.RH
{
    public partial class FrmPes : Basic.FrmClasse
    {
        private Pe _pe;
        public FrmPes()
        {
            InitializeComponent();
        }

        public string Modulo { get; set; } = "";
        private void FrmPs_Load(object sender, EventArgs e)
        {
            Campo1 = "no";
            Campo2 = "nome";
            Ctabela = "pe";
            if (Pbl.Academia)
            {
                tbControl.TabPages.Remove(tabPageAcidentes);
                tbControl.TabPages.Remove(tabPageAusencias); 
                tbControl.TabPages.Remove(tabPageContabilidade);
            }
            else
            {
                tbControl.TabPages.Remove(tabPageSecretaria);
            }

            if (Pbl.Academia)
            {
                tbPatente.label1.Text="Patente";
                ucCategoria.label1.Text="Prefixo";
                //obs,Seguradora,Locali,Pontonome

            }
        }


        public override void DefaultValues()
        {
            _pe = DoAddline<Pe>();
            base.DefaultValues();
            status.SetPeStatusValue();
        }
        public override void Save()
        {
            FillEntity(_pe);
            EF.Save(_pe);
        }
        public override bool BeforeSave()
        {
            if (Pbl.Param.ObrigaBi)
            {
                if (tbBi.tb1.Text.IsNullOrEmpty())
                {
                    MsBox.Show($"Deve preencher o Nº BI do Sr(a): {tbNome.tb1.Text}");
                    return false;
                }
                else
                {
                    if (SQL.CheckExist($"select bi from pe where bi ='{tbBi.tb1.Text.Trim()}' and pestamp<>'{CLocalStamp.Trim()}'"))
                    {
                        MsBox.Show("Já existe outro funcionário com mesmo numero de BI");
                        return false;
                    }
                }
            }
            if (cbDefault5.cb1.Checked)
            {
                if (SQL.CheckExist($"select pedagogico from pe where pedagogico=1 and pestamp<>'{_pe.Pestamp}'"))
                {
                    MsBox.Show("Já existe outro funcionário com o título de pedagógico");
                    return false;
                }
            }
            if (dgvContrato.Rows.Count>0)
            {
                foreach (DataGridViewRow item in dgvContrato.Rows)
                {
                    if (item != null)
                    {
                        if (item.Cells["Estado"].Value.ToBool())
                        {
                            if (!item.Cells["tipocontrato"].Value.Equals(1))
                            {
                                DateTime dat1 = item.Cells["datainicio"].Value.ToDateTimeValue();
                                DateTime dat2 = item.Cells["datafim"].Value.ToDateTimeValue();
                                var dias = dat1.TotalDays(dat2);
                                if (dias<=0)
                                {
                                    MsBox.Show($"O contrato {item.Cells["Tipodescricao"].Value} não pode ter data de término inferior ou igual a data de admissão");
                                    return false;
                                }
                            } 
                        }
                    }
                }
            }
            return true;
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            _pe = FillControls(_pe, dt, i);
            Turmas();

        }
        private void Turmas()
        {
            var xx = $@"Select Turma.Codigo,Disciplina,Turma.Turmastamp from (
                        select pestamp,Turmadisc.Turmastamp,Disciplina from Turmadisc join  
                        Turmadiscp on Turmadisc.Turmadiscstamp=Turmadiscp.Turmadiscstamp)tmp1 
                        join turma on Turma.Turmastamp=tmp1.Turmastamp where tmp1.Pestamp='{CLocalStamp}' 
                        and Turma.Descanoaem=(select AnoSem from param) order by Turma.codigo";
            var dt = SQL.GetGen2DT(xx);
            gridUiTurmas.SetDataSource(dt);
        }
        #region DataGridView Documento  
        private void dgvDocumento_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDocumento.CurrentRow == null) return;
            const string qry = "select descricao from PeAuxiliar where tabela =1";
            var name = dgvDocumento.CurrentCell.OwningColumn.Name;
            if (name.Equals("TipoDocumento"))
            {
               Helper.SetBinds(e.Control, "descricao", qry);
            }
            if (dgvDocumento.CurrentRow == null) return;
            const string qrypr = "select descricao from prov";
            var nameLocalEmissao = dgvDocumento.CurrentCell.OwningColumn.Name;
            if (nameLocalEmissao.Equals("localEmissao"))
            {
                Helper.SetBinds(e.Control, "descricao", qrypr);
            }
        }

        private void dgvDocumento_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        #endregion
        #region Lingua
        private void dgvLingua_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           // Helper.CellEnter(sender,e);
        }
        private void dgvLingua_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvLingua.CurrentRow == null) return;
            string qry;
            var name = dgvLingua.CurrentCell.OwningColumn.Name;
            if (name.Equals("Lingua"))
            {
                qry = "select descricao from PeAuxiliar where tabela =2 ";
                Helper.SetBinds(e.Control, "descricao", qry);
            }
            else
            {
                qry = "select descricao from PeAuxiliar where tabela =12 ";
                if (name.Equals("fala"))
                {
                    Helper.SetBinds(e.Control, "descricao", qry);
                }
                if (name.Equals("Leitura"))
                {
                    Helper.SetBinds(e.Control, "descricao", qry);
                }
                if (name.Equals("Escrita"))
                {
                    Helper.SetBinds(e.Control, "descricao", qry);
                }
                if (name.Equals("Compreensao"))
                {
                    Helper.SetBinds(e.Control, "descricao", qry);
                } 
            }
            
        }
        #endregion
        #region DataGridView Agregado Familiar
        private void dgvAgregadoFamiliar_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Helper.CellEnter(sender,e);
        }
        private void dgvAgregadoFamiliar_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvAgregadoFamiliar.CurrentRow == null) return;
            var name = dgvAgregadoFamiliar.CurrentCell.OwningColumn.Name;
            string qry;
            if (name.Equals("GrauParentesco"))
            {
                qry = "select descricao from PeAuxiliar where tabela =7";
                Helper.SetBinds(e.Control, "descricao", qry);
            }
            else if (name.Equals("ProvinciaAgregado"))
            {
                qry = "select Codprov, Descricao from prov ";
                Helper.SetBinds(e.Control, "descricao", qry);
            }
        }
        
        #endregion
        private void dgvSindicato_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
           // Helper.CellEnter(sender,e);
        }
        #region DataGrigView  Contrato

        private void dgvContrato_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            //Helper.CellEnter(sender,e);
        }
        #endregion
        #region Faltas

        private void dgvFaltas_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //if (dgvFaltas.CurrentRow == null) return;
            //const string qry = "select descricao from PeAuxiliar where tabela =13 ";
            //var names = dgvFaltas.CurrentCell.OwningColumn.Name;
            //if (names.Equals("MesFalta"))
            //{
            //    Helper.SetBinds(e.Control, "descricao", qry);
            //}
        }
        #endregion
        private DataTable dtBanco;

        private void dgvDadosBancarios_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvDadosBancarios.CurrentRow == null) return;
            var qryBanco = "select Sigla, Nome from banco ";
            var nameo = dgvDadosBancarios.CurrentCell.OwningColumn.Name;
            if (nameo.Equals("NomeBanco"))
            {
                dtBanco=Helper.SetBinds(e.Control, "Nome", qryBanco);
            }
        }

        private void dgvDocumento_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvDocumento.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("dataEmissao") || nome.Equals("DataValidade"))
            {
               Helper.AddDateTimePicker(dgvDocumento,e); 
            }
            Helper.SetPdfFile(dgvDocumento, "Anexo2", "Anexo");
            Helper.ViewPdfFile(dgvDocumento, "viewdoc", "Anexo");
            //Helper.SetPdfFile(gridUi3, "anexo", "pdf");
            //Helper.ViewPdfFile(gridUi3, "Ver", "pdf");
        }

        private void dgvContrato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvContrato.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (nome.Equals("datainicio") || nome.Equals("datafim"))
            {
                Helper.AddDateTimePicker(dgvContrato,e); 
            }
            Helper.SetPdfFile(dgvDocumento, "Anexo3", "Anexo");
            Helper.ViewPdfFile(dgvDocumento, "Ver2", "Anexo");
        }

        private void dgvFerias_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvFerias.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("InicioFerias") || nome.Equals("TerminoFeria"))
            {
                Helper.AddDateTimePicker(dgvFerias,e); 
            }
        }

        private void dgvSindicato_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            //if (dgvSindicato.CurrentRow == null) return;
            //const string qry = "select descricao from PeAuxiliar where tabela =13 ";
            //var names = dgvSindicato.CurrentCell.OwningColumn.Name;
            //if (names.Equals("sindicatoDescricao"))
            //{
            //    Helper.SetBinds(e.Control, "descricao", qry);
            //}
        }

        private void dgvDadosBancarios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDadosBancarios.CurrentCell?.Value == null) return;
            if ((bool)!dgvDadosBancarios.CurrentCell?.OwningColumn.Name.Equals("NomeBanco")) return;
            var valor = dgvDadosBancarios.CurrentCell.Value.ToString().Trim();
            if (dtBanco == null) return;
            var dr = dtBanco.AsEnumerable().FirstOrDefault(s => s.Field<string>("Nome").Equals(valor));
            if (dr == null) return;
            if (dgvDadosBancarios.CurrentRow != null) 
                dgvDadosBancarios.CurrentRow.Cells["sigla"].Value = dr[0].ToString();
        }

        private void dgvHorasExtras_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvHorasExtras.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("Datah"))
            {
                Helper.AddDateTimePicker(dgvHorasExtras,e); 
            }
        }

        private void dgvFaltas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvFaltas.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("Data"))
            {
                Helper.AddDateTimePicker(dgvFaltas,e); 
            }
        }

        private void gridUi1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUi1.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("dataincurso")|| nome.Equals("datafimcurso"))
            {
                Helper.AddDateTimePicker(gridUi1,e); 
            }
        }

        private void gridUi1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi1.CurrentRow == null) return;
             var qry = "select descricao from PeAuxiliar where tabela =";
            var names = gridUi1.CurrentCell.OwningColumn.Name;
            if (names.Equals("Curso"))
            {
                qry += "17";
                Helper.SetBinds(e.Control, "descricao", qry);
            }
            else if (names.Equals("Instituicao"))
            {
                qry += "16";
                Helper.SetBinds(e.Control, "descricao", qry);     
            }
            else if (names.Equals("Nivel"))
            {
                qry += "11";
                Helper.SetBinds(e.Control, "descricao", qry);     
            }
        }

        private void ucProvincia_RefreshControls()
        {
            ucDistrito.Condicao=$" prov.Descricao='{ucProvincia.tb1.Text.Trim()}'";;
            ucDistrito.tb1.Text = "";
            ucPad.tb1.Text = "";
        }

        private void ucProvinciaMorada_RefreshControls()
        {
            ucDistritoMorada.Condicao= $" prov.Descricao='{ucProvinciaMorada.tb1.Text.Trim()}'";
            ucDistritoMorada.tb1.Text = "";
            ucPadmor.tb1.Text = "";
        }

        private void ucDistrito_RefreshControls()
        {
            ucPad.Condicao = $" dist.Descricao='{ucDistrito.tb1.Text.Trim()}'";
            ucPad.tb1.Text = "";
        }

        private void ucDistritoMorada_RefreshControls()
        {
            ucPadmor.Condicao =$" dist.Descricao='{ucDistrito.tb1.Text.Trim()}'";
            ucPadmor.tb1.Text = "";
        }

        private void listagemDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmGenreport
            {
                Gendt = SQL.GetGen2DT("Select * from pe"), Titulo = "Listagem de Pessoal"
            };
            f.ShowForm(this);
        }

        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            dmzContextMenuStrip1.ShowMenuStrip(btnMenuLateral);
        }

        private void dgvDocumento_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSub_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvSub.CurrentRow == null) return;
            const string qry = "select * from sub";
            var name = dgvSub.CurrentCell.OwningColumn.Name;
            if (name.Equals("DescricaoSub"))
            {
                dtPesub=Helper.SetBinds(e.Control, "descricao", qry);
            }
        }

        private void dgvSub_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var name = dgvSub.CurrentCell.OwningColumn.Name;
            if (!name.Equals("DescricaoSub")) return;
            if (!(dtPesub?.Rows.Count > 0)) return;
            if (dgvSub.CurrentCell.Value == null) return;
            var valor = dgvSub.CurrentCell.Value;
            var dr = dtPesub.AsEnumerable().FirstOrDefault(x =>
                x.Field<string>("Descricao").Trim().Equals(valor.ToString().Trim()));
            if (dr == null) return;
            dgvSub.CurrentRow.Cells["Valor"].Value = dr["Valor"].ToString();
            dgvSub.CurrentRow.Cells["Tipo"].Value = dr["Tipo"].ToString();
            dgvSub.CurrentRow.Cells["codigo"].Value = dr["Codigo"].ToString();
        }

        private void dgvPeDesc_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvPeDesc.CurrentRow == null) return;
            const string qry = "select * from desconto";
            var name = dgvPeDesc.CurrentCell.OwningColumn.Name;
            if (name.Equals("DescricaoDesc"))
            {
              dtPeDesc = Helper.SetBinds(e.Control, "Descricao", qry);
            }
        }

        private void dgvPeDesc_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var name = dgvPeDesc.CurrentCell.OwningColumn.Name;
            if (!name.Equals("DescricaoDesc")) return;
            if (!(dtPeDesc?.Rows.Count > 0)) return;
            if (dgvPeDesc.CurrentCell.Value == null) return;
            var valor = dgvPeDesc.CurrentCell.Value;
            var dr = dtPeDesc.AsEnumerable().FirstOrDefault(x =>
                x.Field<string>("Descricao").Trim().Equals(valor.ToString().Trim()));
            if (dr == null) return;
            dgvPeDesc.CurrentRow.Cells["ValorDesc"].Value = dr["Valor"].ToString();
            dgvPeDesc.CurrentRow.Cells["TipoDesc"].Value = dr["Tipo"].ToString();
            dgvPeDesc.CurrentRow.Cells["TipoDesc1"].Value = dr["Tipodesc"].ToString();
            dgvPeDesc.CurrentRow.Cells["coddesc"].Value = dr["codigo"].ToString();
        }
        private DataTable dtPeDesc;
        private DataTable dtPesub;
        private DataTable dtTcontrato;

        private void dgvHorasExtras_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var name = dgvHorasExtras.CurrentCell.OwningColumn.Name;
            if (!name.Equals("TipoHoraEx")) return;
            if (!(DtHoraEx?.Rows.Count > 0)) return;
            if (dgvHorasExtras.CurrentCell.Value == null) return;
            var valor = dgvHorasExtras.CurrentCell.Value;
            var dr = DtHoraEx.AsEnumerable().FirstOrDefault(x =>
                x.Field<string>("Descricao").Trim().Equals(valor.ToString().Trim()));
            if (dr == null) return;
            dgvHorasExtras.CurrentRow.Cells["Val"].Value = dr["Valor"].ToString();
            dgvHorasExtras.CurrentRow.Cells["Tip"].Value = dr["Tipo"].ToString();
            dgvHorasExtras.CurrentRow.Cells["cod"].Value = dr["Codigo"].ToString();
        }

        public DataTable dtFalta { get; set; }
        private void dgvFaltas_EditingControlShowing_1(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvFaltas.CurrentRow == null) return;
            var name = dgvFaltas.CurrentCell.OwningColumn.Name;
            if (name.Equals("DescricaoFalta"))
            {
                dtFalta=Helper.SetBinds(e.Control, "descricao", "select * from falta");
            }
        }

        public DataTable DtHoraEx { get; set; }
        public DataTable Dt { get; private set; }

        private void dgvHorasExtras_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvHorasExtras.CurrentRow == null) return;
            var name = dgvHorasExtras.CurrentCell.OwningColumn.Name;
            if (name.Equals("TipoHoraEx"))
            {
                DtHoraEx=Helper.SetBinds(e.Control, "descricao", "select * from HoraExtra");
            }
        }

        private void dgvHorasExtras_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvHorasExtras.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("DataInicioHoraEx"))
            {
                Helper.AddDateTimePicker(dgvHorasExtras,e); 
            }
        }

        private void dgvFaltas_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvFaltas.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("Data"))
            {
                Helper.AddDateTimePicker(dgvFaltas,e); 
            }
        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void procura13_Load(object sender, EventArgs e)
        {

        }

        private void dgvSub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvSub.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("validade")|| nome.Equals("datain"))
            {
                Helper.AddDateTimePicker(dgvSub,e); 
            }
        }

        private void dgvPeDesc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = dgvPeDesc.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("Valid"))
            {
                Helper.AddDateTimePicker(dgvPeDesc,e); 
            }
        }

        private void dgvFaltas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var name = dgvFaltas.CurrentCell.OwningColumn.Name;
            if (!name.Equals("DescricaoFalta")) return;
            if (!(dtFalta?.Rows.Count > 0)) return;
            if (dgvFaltas.CurrentCell.Value == null) return;
            var valor = dgvFaltas.CurrentCell.Value;
            var dr = dtFalta.AsEnumerable().FirstOrDefault(x =>
                x.Field<string>("Descricao").Trim().Equals(valor.ToString().Trim()));
            if (dr == null) return;
            dgvFaltas.CurrentRow.Cells["DescontaSubAlimenta"].Value = dr["DescontaSubAlimenta"];
            dgvFaltas.CurrentRow.Cells["DescontaSubPorTurno"].Value = dr["DescontaSubPorTurno"];
            dgvFaltas.CurrentRow.Cells["codf"].Value = dr["Codigo"].ToString();
        }

        private void importarFubcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void iNFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ChamaformImport("pe", "", "", "Funcionarios");
        }

        private void pRIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ChamaformImport("pe", "", "", "Funcionarios","PRI");
        }

        private void tbMorada_Load(object sender, EventArgs e)
        {

        }

        private void procura27_Load(object sender, EventArgs e)
        {

        }

        private void procura3_Load(object sender, EventArgs e)
        {

        }

        private void tbDefault4_Load(object sender, EventArgs e)
        {

        }

        private void dgvContrato_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvContrato.CurrentRow == null) return;
            const string qry = "select codigo,descricao,tipo from Tcontrato";
            var name = dgvContrato.CurrentCell.OwningColumn.Name;
            if (name.Equals("Tipodescricao"))
            {
                dtTcontrato = Helper.SetBinds(e.Control, "descricao", qry);
            }
        }

        private void dgvContrato_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //tipocontrato

            var name = dgvContrato.CurrentCell.OwningColumn.Name;
            if (!name.Equals("Tipodescricao")) return;
            if (dgvContrato.CurrentCell.Value == null) return;
            var valor = dgvContrato.CurrentCell.Value;
            var dr = dtTcontrato.AsEnumerable().FirstOrDefault(x =>
                x.Field<string>("Descricao").Trim().Equals(valor.ToString().Trim()));
            if (dr == null) return;
            dgvContrato.CurrentRow.Cells["tipocontrato"].Value = dr["tipo"];
            dgvContrato.CurrentRow.Cells["tipocodigo"].Value = dr["codigo"];

        }

        private void gridUiFuncoes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUiFuncoes.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (nome.Equals("fdatain") || nome.Equals("fdatafim"))
            {
                Helper.AddDateTimePicker(gridUiFuncoes, e);
            }
        }

        private void gridUiFuncoes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUiFuncoes.CurrentRow == null) return;
            string qry;
            var name = gridUiFuncoes.CurrentCell.OwningColumn.Name;
            if (name.Equals("tipofuncao"))
            {
                qry = "select descricao from PeAuxiliar where tabela =15";
                Helper.SetBinds(e.Control, "descricao", qry);
            }
            if (name.Equals("localtrab"))
            {
                qry = "select Descricao from CCu";
                Helper.SetBinds(e.Control, "descricao", qry);
            }
        }

        private void dgvFerias_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFerias_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvFerias.CurrentRow != null)
            {
                var nome = dgvFerias.CurrentCell.OwningColumn.Name.ToLower().Trim();
                if (!dgvFerias.CurrentRow.Cells["Fechado"].Value.ToBool())//
                {
                    if (nome.Equals("inicioferias") || nome.Equals("terminoferia") || nome.Equals("diasanoanterior"))
                    {
                        var dinicio = dgvFerias.CurrentRow.Cells["inicioferias"].Value.ToDateTimeValue();
                        var dtermino = dgvFerias.CurrentRow.Cells["terminoferia"].Value.ToDateTimeValue();
                        var dias = dinicio.TotalDays(dtermino).ToDecimal();
                        var total = dias + dgvFerias.CurrentRow.Cells["diasanoanterior"].Value.ToDecimal();
                        dgvFerias.CurrentRow.Cells["Dias"].Value = dias;
                        dgvFerias.CurrentRow.Cells["TotalDias"].Value = total;
                    }
                }
                else
                {
                    //MsBox.Show("Esta linha já está fechada e não se pode fazer alteração");
                }
            }
        }

        private void dgvFerias_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dgvFerias.CurrentRow == null) return;
            string qry;
            var name = dgvFerias.CurrentCell.OwningColumn.Name;
            if (name.Equals("DescricaoFerias"))
            {
                qry = "select descricao from PeAuxiliar where tabela =18";
                Helper.SetBinds(e.Control, "descricao", qry);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void gridUi2_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi2.CurrentRow == null) return;
            Dt = Helper.ShowDisciplina(gridUi2.CurrentCell, e);
        }

        private void gridUi2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Helper.SetDisciplina(gridUi2,Dt,true);
        }

        private void gridUiTurmas_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUiTurmas.CurrentCell.OwningColumn.Name.ToLower().Trim();
            var turmastamp = gridUiTurmas.CurrentRow.Cells["turmastamp"].Value.ToString();
            if (nome.Equals("origem"))
            {
                var w = new FrmTurma();
                w.ShowForm(this);
                var tab = SQL.GetGen2DT($"select * from turma where turmastamp='{turmastamp.ToTrim()}'");
                w.PreencheCampos(tab, 0);
                w.Procurou = true;
            }
        }
    }
}
