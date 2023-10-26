
using DMZ.BL.Classes;
using DMZ.Model.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace DMZ.UI.UI
{
    public partial class FrmCl : Basic.FrmClasse
    {
        public FrmCl()
        {
            InitializeComponent();
        }

        public override List<PropertyInfo> GetListProps()
        {
           return typeof(Cl).GetProperties().ToList();
        }

        public Cl _cl;
        private void FrmCL_Load(object sender, EventArgs e)
        {           
            Campo1 = "no";
            Campo2 = "nome"; 
            Ctabela = "cl";         
            var ct = SQL.GetDT("EmpresaMod", "sigla", "Sigla='CT'", null);
            btnCriaContasCT.Enabled = !(ct?.Rows.Count<0);
        }
        public override void DefaultValues()
        {
            _cl = DoAddline<Cl>();
            tbCcusto.tb1.Text = Pbl.Usr.Ccusto;
            tbCcusto.Text2 = Pbl.Usr.Codccu;
            base.DefaultValues();
            Helper.SetMaxNumero(tbNumero,"cl");
            status.SetStatusValue();
            CriarContasContabilidade();
        }

        private void CriarContasContabilidade()
        {
            if (!string.IsNullOrEmpty(tbNumero.tb1.Text))
            {
                var ct = SQL.GetDT("EmpresaMod", "sigla", "Sigla='CT'",null);
                if (!(ct?.Rows.Count > 0)) return;
                if (!SQL.GetField("Criacl","param").ToBool()) return;
                var dt = SQL.GetGenDT("select * from Paramgct where codtipo=1");
                if (!(dt?.Rows.Count > 0)) return;
                foreach (var r in dt.AsEnumerable())
                {
                    if (r == null) continue;
                    if (!r["grupo"].Equals("411")) continue;
                    Helper.CriaConta(r,gridContasCT,tbNumero.tb1.Text);
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + "o numero do cliente não pode estar vazio!");
            }
        }

        public override void AfterSave()
        {
            Helper.GravaConta(gridContasCT.DtDS,_cl.Clstamp,_cl.Nome,"clct");
            if (!string.IsNullOrEmpty(Conta) && !string.IsNullOrEmpty(_cl.Clstamp))
            {
                Integracao.UpdatePGC(Conta,_cl.Clstamp);
            }
            base.AfterSave();
        }

        public override bool BeforeSave()
        {
            if (!Procurou)
            {
                if (!tbNuit.tb1.Text.IsNullOrEmpty())
                {
                    if (!Pbl.Param.NaoverificaNuit)
                    {
                        var dr = SQL.GetRow("nuit,nome", "cl", $"nuit={tbNuit.tb1.Text.ToDecimal()}");
                        if (dr != null)
                        {
                            MsBox.Show($"Já existe um cliente com o mesmo nuit\r\nCliente:{dr["nome"]}");
                            return false;
                        }
                    }
                    else
                    {
                        var dr = SQL.GetRow("nuit,nome", "cl", $"nuit={tbNuit.tb1.Text.ToDecimal()} AND nome ='{tbNome.tb1.Text.Trim()}'");
                        if (dr != null)
                        {
                            MsBox.Show($@"Já existe um cliente com o mesmo nuit e Nome\r\nCliente:{dr["nome"]}\r\nMuda o nome pelo menos!");
                            return false;
                        }
                    }
                } 
            }
            if (!Pbl.Param.Modeloja) return base.BeforeSave();
            if (!string.IsNullOrEmpty(tbCcusto.tb1.Text)) return base.BeforeSave();
            MsBox.Show("O Campo Centro de Custo é obrigatório para empresas multilojas!");
            return false;
        }

        public override void Save()
        {
            FillEntity(_cl);
            EF.Save(_cl);
        }
        public override bool CheckDelete()
        {
            var dt = SQL.GetGenDT($"select top 1 no from fact where no ={tbNumero.tb1.Text.ToDecimal()}");
            if (!dt.HasRows()) return base.CheckDelete();
            MsBox.Show($"Descupla mas o cliente: \r\n {tbNome.tb1.Text} tem facturas emitidas já não se pode eliminar!.. ");
            return false;
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _cl = FillControls(_cl, dt, i);
            Helper.GetCC(gridCc, CLocalStamp);
        }



        private void btnCcorrente_Click(object sender, EventArgs e)
        {
            ChamaRelatorios();
        }

        private void ChamaRelatorios()
        {
            var f = new FrmRelatorios{Modulo = "GES"};
            f.label1.Text = @"CONTA CORRENTE DO CLIENTE";
            f.CondicaoOrigem="and Mostracfe =1";
            f.ShowForm(this);
        }

        private void AbrirCc(string siglas)
        {
            var f = new FrmCcCl { Tabela = null, tbNome = { Text = tbNome.tb1.Text }, tbNumero = { Text = tbNumero.tb1.Text } };
            f.label1.Text = @"CONTA CORRENTE DO CLIENTE";
            f.Moeda.tb1.Text=tbMoeda.tb1.Text;
            f.Siglas=siglas;
            f.Filtro = $"Cliente: {tbNome.tb1.Text}";
            f.Clstamp = CLocalStamp;
            f.ShowForm(this);
        }

        private void btnMenuLateral_Click(object sender, EventArgs e)
        {
            MenuLateral.ShowMenuStrip(btnMenuLateral);
        }

        private void últimasComprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNome.tb1.Text))
            {
                var f = new FrmCc
                {
                    txtNome = {Text = tbNome.tb1.Text},
                    txtNumero = {Text = tbNumero.tb1.Text},
                    label1 = {Text = @"Extrato de vendas e regularizações"},
                    Cl = true,
                    Tipo = "Cliente"
                };
                f.Moeda.tb1.Text=tbMoeda.tb1.Text;
                f.Clstamp=CLocalStamp;
                f.ShowForm(this);
            }
            else
            {
                MsBox.Show("Deve indicar o cliente!..");
            }
        }

        private void exportarProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNome.tb1.Text))
            {
                var f = new FrmProdutosVendidos
                {
                    txtNome = { Text = tbNome.tb1.Text },
                    txtNumero = { Text = tbNumero.tb1.Text },
                    label1 = { Text = @"Extrato de prudutos vendidos" },
                };
                f.ShowForm(this);
            }
            else
            {
                MsBox.Show("Deve indicar o cliente!..");
            }
        }

        private void pedidosPedentesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void assistenteDeConbrançasAEsteClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbNome.tb1.Text))
            {
                var f = new FrmAssistenteCl
                {
                    label1 = { Text = @"Assistente de cobranças de clientes!" }
                };
                f.ShowForm(this);
            }
            else
            {
                MsBox.Show("Deve indicar o cliente!..");
            }
        }

        private void btnCriaContasCT_Click(object sender, EventArgs e)
        {
            var clctparam = SQL.GetDT("param", "Clpgc", null, null);
           if (clctparam?.Rows.Count>0)
           {
               
           }
        }
        private List<Usracessos> lista;
        private (bool valido, List<Usracessos> lista) IsAllValido(string tdoc)
        {
            (bool valido, List<Usracessos> lista) ret = (false, null);
            if (!Inserindo)
            {
                lista = Pbl.Usracessos.Where(x => x.Origem.ToLower().Equals(tdoc.ToLower())).ToList();
                if (lista?.Count > 0)
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
                    MsBox.Show($"Desculpa não tem acessos definidos para {Pbl.Usr.Nome}. contacte administrator!");
                }
            }
            else
            {
                MsBox.Show($"Estimado(a) {Pbl.Usr.Nome},o documento  está em criação. \r\nNão é possivel emitir o documento pretendido!");
            }
            return ret;
        }


        private void transformarEmFornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var retorno = IsAllValido("tpgf");
            if (!retorno.valido) return;
            lista = retorno.lista;
            {
                var ver = SQL.GetGen2DT($"select * from fnc where fncstamp='{CLocalStamp}'");
                if (!ver.HasRows())
                {
                    var fnc = new FrmFnc
                    {
                        Usracessos = lista.FirstOrDefault(),
                    };
                    fnc.ShowForm(this);
                    fnc.btnNovo.PerformClick();
                    fnc._fnc.Fncstamp = CLocalStamp;
                    fnc.CLocalStamp = CLocalStamp;
                    fnc.BindFnc(_cl);
                }
                else
                {
                    MsBox.Show("Este cliente já é fornecedor!..");
                }
               
            }
        }

        public void BindCl(Fnc fnc)
        {
            _cl.Clstamp = Pbl.Stamp();
            _cl.Nome = fnc.Nome;
            _cl.Moeda = fnc.Moeda;
            _cl.Ccusto = fnc.Ccusto;
            _cl.Morada = fnc.Morada;
            _cl.Email = fnc.Email;
            _cl.Datacl = fnc.Data;
            _cl.Celular = fnc.Celular;
            _cl.Prontopag = fnc.Prontopag;
            _cl.Imagem = fnc.Imagem;
            _cl.No = SQL.VMax("no", "cl").ToString();
            _cl.Obs = fnc.Obs;
            _cl.Pais = fnc.Pais;
            _cl.Status = fnc.Status;
            _cl.Nuit = fnc.Nuit;
            _cl.Localidade = fnc.Localidade;
            _cl.Site = fnc.Site;
            _cl.Provincia = "";
            _cl.Distrito = "";
            _cl.Fnc = "";
            _cl.Nofnc = "";
            PreencheCampos(_cl.ToDataTable(),0);
        }
        private bool gridPanel22_BeforeAddLineEvent()
        {
            CriarContasContabilidade();
            gridContasCT.Update();
            return true;
        }

        private void btnSite_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(tbSite.tb1.Text))
            {
                Process.Start(tbSite.tb1.Text.Trim()); 
            }
        }
        private void tbMorada_Load(object sender, EventArgs e)
        {

        }

        private void listagemDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var f = new FrmGenreport
            {
                Gendt = SQL.GetGen2DT("Select no,nome,Celular from cl"), Titulo = "Listagem de Clientes"
            };
            f.ShowForm(this);
        }

        private void gridUi1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi1.CurrentRow == null) return;
            const string qry = "select Referenc,Descricao from st ";
            var name = gridUi1.CurrentCell.OwningColumn.Name.ToLower();
            if (gridUi1.CurrentColumn.Name.ToLower().Equals("descricao"))
            {
                DtSt=Helper.SetBinds(e.Control, "Descricao",qry);
            }
            else if (name.Equals("referenc"))
            {
                DtSt=Helper.SetBinds(e.Control, "referenc",qry);
            }            
            else
            {
                DtSt = null;
                var autoText = e.Control as TextBox;
                if (autoText != null) 
                    autoText.AutoCompleteCustomSource = null;
            }
        }

        public DataTable DtSt { get; set; }
        public string Conta { get; private set; }
        public DataTable Dtcl { get; private set; }

        private void gridUi1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var nome = gridUi1.CurrentCell.OwningColumn.Name.ToLower();
            if (nome.Equals("descricao"))
            {
                SetFactl("descricao");
            }

            if (nome.Equals("referenc"))
            {
                SetFactl("referenc");
            }
        }
        private void SetFactl(string campo)
        {
            if (gridUi1.CurrentCell == null) return;
            var valor = gridUi1.CurrentCell.Value.ToString().Trim();
            var dr = DtSt.AsEnumerable().FirstOrDefault(s => s.Field<string>(campo).Trim().Equals(valor));
            if (dr == null) return;
            if (gridUi1.CurrentRow == null) return;
            if (campo.Equals("descricao"))
            {
                gridUi1.CurrentRow.Cells["Referenc"].Value = dr["Referenc"].ToString();
            }
            else
            {
                gridUi1.CurrentRow.Cells["Descricao"].Value = dr["Descricao"].ToString();
            }
        }

        private void procura9_RefreshControls()
        {
            tbDescPerc.tb1.Text = procura9.Text2;
        }

        private void procura1_RefreshControls()
        {
            //procura2.tb1.Text = "";
            //procura2.Text2 = "";
            //if (!string.IsNullOrEmpty(procura1.tb1.Text))
            //{
            //    procura2.Condicao = $"Prov.Descricao='{procura1.tb1.Text.Trim()}'";
            //}
        }


        private void gridUi2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            gridUi2.Anexos();
        }

        private void btnSincronizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbNome.tb1.Text)) return;
            Conta =Integracao.GetContaNaContabilidade(tbNome.tb1.Text,"411");
            if (!string.IsNullOrEmpty(Conta))
            {
                if (!SQL.CheckExist($"select conta from fncct where conta ='{Conta}'"))
                {
                    gridPanel22.btnNovo.PerformClick();
                    if (gridContasCT.CurrentRow !=null)
                    {
                        gridContasCT.DataRowr["conta"]=Conta;
                        gridContasCT.DataRowr["Descgrupo"]="CLIENTES C/C";
                        gridContasCT.DataRowr["Contacc"]=true;
                        gridContasCT.Update();
                    }
                }
                else
                {
                    MsBox.Show(Messagem.ParteInicial()+$"O Cliente: {tbNome.tb1.Text}, já tem conta criada!");
                }
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial()+$"O Cliente: {tbNome.tb1.Text}, não tem conta por sincronizar!");
            }
        }

        private void opçoõesDoClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChamaRelatorios();
             //AbrirCc("'FPC'");
        }

        private void btnRefreshCc_Click(object sender, EventArgs e)
        {
            Helper.GetCC(gridCc, CLocalStamp);
        }

        private void btnSettingTextBox_Click(object sender, EventArgs e)
        {
            TextBoxSetting.ShowMenuStrip(btnSettingTextBox);
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            tbNome.tb1.ToUpperX();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            tbNome.tb1.ToLowerX();
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            tbNome.tb1.ToTitleCaseX();
        }

        private void encontroDeContasCorrentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var w = new FrmEncontrocontas();
            w.ShowForm(this);
        }

        private void importarClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Helper.ChamaformImport("cl", "", "", "Clientes");
        }

        private void RecebeDados(DataRow dr)
        {
            BeginInvoke((Action)delegate
            {
                btnNovo.PerformClick();
                _cl.Clstamp = Pbl.Stamp("MMC");

                //Familia.tb1.Text = dr["Familia"].ToString();
                //Familia.Text2 = dr["Codfam"].ToString();
                //tbDescricao.tb1.Text = dr["Descricao"].ToString();
                //tbReferenc.tb1.Text = string.IsNullOrEmpty(dr["Referenc"].ToString()) ? dr["Descricao"].ToString() : dr["Referenc"].ToString();
                //_cl.Obs = dr["Obs"].ToString();
                ////Stockmin.tB1.Text = "100";
                //TabIVa.Text2 = dr["Tabiva"].ToString();
                //TabIVa.tb1.Text = dr["Txiva"].ToString();
                //Unidade.tb1.Text = dr["Unidade"].ToString();
                //subFamilia.tb1.Text = dr["Subfamilia"].ToString();
                //var stpreco = SQL.GetGen2DT("select * from stprecos where 1=0");
                //var dr2 = stpreco.NewRow();
                //dr2["StPrecostamp"] = Pbl.Stamp();
                //dr2["Ststamp"] = _cl.Ststamp;
                //dr2["CodCCu"] = dr["CodCcu"];
                //dr2["CCusto"] = dr["CCusto"];
                //dr2["Preco"] = dr["Preco"];
                //dr2["ivainc"] = true;
                //stpreco.Rows.Add(dr2);


                //var starm = SQL.GetGen2DT("select * from Starm where 1=0");
                //var dr3 = starm.NewRow();
                //dr3["Starmstamp"] = Pbl.Stamp();
                //dr3["Ststamp"] = _cl.Ststamp;
                //dr3["Codarm"] = dr["Codarm"];
                //dr3["Descricao"] = dr["Armazem"];
                //dr3["ref"] = tbReferenc.tb1.Text.Trim();
                //starm.Rows.Add(dr3);
                //FillEntity(_cl);
                //_cl.Stockmin = 100;
                EF.Save(_cl);
                //SQL.Save(stpreco, "StPrecos", true, CLocalStamp, "st");
                //SQL.Save(starm, "Starm", true, CLocalStamp, "st");
                EstadoDaTela(AccaoNaTela.Padrao);
            });

        }
        private void writeText(PdfContentByte cb, string Text, int X, int Y, BaseFont font, int Size)
        {
            cb.SetFontAndSize(font, Size);
            cb.ShowTextAligned(PdfContentByte.ALIGN_LEFT, Text, X, Y, 0);
        }
        PdfContentByte cb;
        private void button6_Click(object sender, EventArgs e)
        {
            var dt = SQL.GetGen2DT("select no,nome from cl");
            var fs = new FileStream("E:\\PDF" + "\\" + "First PDF document.pdf", FileMode.Create);
            // Create an instance of the document class which represents the PDF document itself.  
            Document document = new Document(PageSize.A4, 25, 25, 30, 30);
            // Create an instance to the PDF file by creating an instance of the PDF   
            // Writer class using the document and the filestrem in the constructor.  

            PdfWriter writer = PdfWriter.GetInstance(document, fs);

            // Add meta information to the document  
            document.AddAuthor("Micke Blomquist");
            document.AddCreator("Sample application using iTextSharp");
            document.AddKeywords("PDF tutorial education");
            document.AddSubject("Document subject - Describing the steps creating a PDF document");
            document.AddTitle("The document title - PDF creation using iTextSharp");
            // Open the document to enable you to write to the document  
            document.Open();
            // Add a simple and wellknown phrase to the document in a flow layout manner  
            document.Add(new Paragraph("Hello World!"));
            document.Add(new Paragraph(""));
            document.Add(new Paragraph(""));
            //foreach (DataRow drItem in dt.Rows)
            //{
            //    writeText(cb, "blah", left_margin, top_margin, f_cn, 10);
            //    top_margin -= 12;
            //    // Simpleage break function, check position  
            //    if (top_margin <= lastwriteposition)
            //    {
            //        // Okay, we need to switch page, end writing text  
            //        cb.EndText();
            //        // Make the page break  
            //        document.NewPage();
            //        // Start writing again on the new page  
            //        cb.BeginText();
            //        // Assign the new write location on page two!  
            //        // Here you might want to implement a new row header creation  
            //        top_margin = 780;
            //    }
            //}
            // Close the document  
            document.Close();
            // Close the writer instance  
            writer.Close();
            // Always close open filehandles explicity  
            fs.Close();

        }

        private void gridUi5_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (gridUi5.CurrentRow == null) return;
            const string qry = "select nome,Clstamp  from cl";
            if (gridUi5.CurrentColumn.Name.ToLower().Equals("descnome"))
            {
                Dtcl = Helper.SetBinds(e.Control, "nome", qry);
            }
            else
            {
                Dtcl = null;
                var autoText = e.Control as TextBox;
                if (autoText != null)
                    autoText.AutoCompleteCustomSource = null;
            }
        }

        private void gridUi5_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (gridUi5.CurrentCell.OwningColumn.Name.ToLower().Equals("descnome"))
            {
                if (gridUi5.CurrentCell == null) return;
                var dr = Dtcl.AsEnumerable().FirstOrDefault(s => s.Field<string>("nome").Trim().Equals(gridUi5.CurrentCell.Value.ToString().Trim()));
                if (dr == null) return;
                gridUi5.CurrentRow.Cells["Oristamp"].Value = dr["clstamp"].ToString();
            }
        }

        private void iNFOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ChamaformImport("cl", "", "", "Clientes");
        }

        private void pRMToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Helper.ChamaformImport("clientes", "", "", "Clientes","PRI");
        }

        private void actualizarOStampDoClieneteNaContaCorrenteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var dr = MsBox.Show("Deseja actualizar o stamp do cliente na conta corrente!",DResult.YesNo);
            if (dr.DialogResult==DialogResult.Yes)
            {
                try
                {
                    SQL.SqlCmd("Update cc set clstamp =(select clstamp from cl where no =cc.no) where cc.clstamp =''");
                    MsBox.Show("Processo executado com sucesso");
                }
                catch (Exception ex)
                {
                    MsBox.Show(ex.Message);
                }
               
            }
        }
    }
}
