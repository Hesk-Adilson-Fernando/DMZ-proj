using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace DMZ.UI.UI
{
    public partial class FrmImportCl : Basic.FrmClasse2
    {
        private Server _myServer;
        private DataTable dtImport;
        private DataTable DtCl;
        private DataRow Trcl;

        public DataTable tipodoc { get; set; }

        public FrmImportCl()
        {
            InitializeComponent();
        }
        public string Tabela { get; set; }
        public string TabelaFilha { get; set; }
        public string Condicao { get; set; }
        public DataTable DtFilha { get;set; }
        public SqlConnection Con { get; private set; }
        public string Origem { get; internal set; }
        public string Numero { get; private set; } = "Numero";
        public string Data { get; private set; } = "Data";
        public object Numdoc { get; private set; } = "Numdoc";

        private void button1_Click(object sender, EventArgs e)
        {
            Con = ConnHelper.Conection(comboBox1.Text.Trim(), comboBox2.Text.Trim(), tbPw.Text.Trim());
            var cond = "";
            if (!Condicao.IsNullOrEmpty())
            {
                cond = $" {Condicao} ";
            }
            if (!tbNrdoc.Text.IsNullOrEmpty())
            {
                if (!cond.IsNullOrEmpty())
                {
                    cond = $" {cond} and {Numero} ={tbNrdoc.Text.ToDecimal()} ";
                }
                else
                {
                    cond = $" {Numero} ={tbNrdoc.Text.ToDecimal()} ";
                }
            }
            if (dmzData1.checkBox1.Checked)
            {
                if (!cond.IsNullOrEmpty())
                {
                    cond = $" {cond} and {Data} = '{dmzData1.dt1.Value.ToSqlDate()}' ";
                }
                else
                {
                    cond = $" {Data} = '{dmzData1.dt1.Value.ToSqlDate()}' ";
                }
            }
            if (dmzDdN1.checkBox1.Checked)
            {
                if (!cond.IsNullOrEmpty())
                {
                    cond = $" {cond} and year({Data}) = {dmzDdN1.ano.Value} ";
                }
                else
                {
                    cond = $" year({Data}) = {dmzDdN1.ano.Value} ";
                }
            }
            if (!comboTdoc.Text.IsNullOrEmpty())
            {
                if (!cond.IsNullOrEmpty())
                {
                    cond = $" {cond} and {Numdoc} = {comboTdoc.SelectedValue.ToDecimal()} ";
                }
                else
                {
                    cond = $" {Numdoc} = {comboTdoc.SelectedValue.ToDecimal()} ";
                }
            }
            if (!cond.IsNullOrEmpty())
            {
                cond = $" where {cond}";
            }
            dtImport = SQL.GetGenDT($"select cast(0 as bit) ok, * from {Tabela} {cond}",Con);
           var lista = new List<string>();
            foreach (var item in dtImport.AsEnumerable())
            {
                if (SQL.CheckExist($"select {Tabela.Trim()}stamp from {Tabela} where {Tabela.Trim()}stamp='{item[$"{Tabela.Trim()}stamp"].ToString().Trim()}' "))
                {
                    lista.Add(item[$"{Tabela.Trim()}stamp"].ToString().Trim());
                }
            }
            foreach (var item in lista)
            {
                if (item != null)
                {
                    var ro = dtImport.AsEnumerable().First(x => x.Field<string>($"{Tabela.Trim()}stamp").Trim().Equals(item.Trim()));
                    dtImport.Rows.Remove(ro);
                }
            }
            gridUi1.DataSource = null;
            gridUi1.AutoGenerateColumns = true;
            gridUi1.DataSource=dtImport;
            if (dtImport.HasRows())
            {
                lblQuantidade.Text = dtImport.Rows.Count.ToString();
            }
        }

        private void btnInstance_Click(object sender, EventArgs e)
        {
            var dt = SmoApplication.EnumAvailableSqlServers();
            foreach (DataRow r in dt.Rows)
            {
                if (r != null)
                    comboBox1.Items.Add(r["Name"].ToString());
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _myServer = new Server(comboBox1.Text.Trim());
            foreach (Database db in _myServer.Databases)
            {
                comboBox2.Items.Add(db.Name.Trim());
            }
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            if (dtImport.HasRows())
            {
                gridUi1.Update();
                var dt = gridUi1.GetBindedTable();

                if (dt.AsEnumerable().Any(x => x.Field<bool>("ok").Equals(true)))
                {
                    dt = dt.AsEnumerable().Where(x => x.Field<bool>("ok").Equals(true)).CopyToDataTable();
                    if (dt.HasRows())
                    {
                        if (Tabela.ToLower() == "rcl")
                        {
                            Trcl = SQL.GetRow("select Numdoc,Descricao,Sigla from TRcl where Defa=1");
                        }
                        Helper.DoProgressProcess(dt, RecebeDados);
                    }
                }
            }
        }

        private void RecebeDados(DataRow dr, bool fim)
        {
            if (dr!=null)
            {
                var tab = "";
                if (Origem==null)
                {
                    tab = Tabela;
                }
                else if(Origem == "PRI")
                {
                    switch (Tabela)
                    {
                        case "clientes":
                            tab = "cl";
                            break;
                        case "Artigo":
                            tab = "st";
                            break;
                    }
                }
                DtCl = SQL.Initialize(tab);
                var r = DtCl.NewRow().Inicialize();
                if (Origem == null)
                {
                    if (Tabela !="pe")
                    {
                        foreach (DataColumn col in dr.Table.Columns)
                        {
                            if (DtCl.Columns.Contains(col.ColumnName))
                            {
                                if (!col.ColumnName.Equals("imagem"))//Foto
                                {
                                    if (!col.ColumnName.Equals("foto"))
                                    {
                                        r[col.ColumnName] = dr[col.ColumnName];
                                    }
                                }
                            }
                            //ref
                            if (col.ColumnName.Equals("ref") && Tabela.ToLower().Equals("st"))
                            {
                                r["Referenc"] = dr[col.ColumnName];
                            }
                            else if (col.ColumnName.Equals("valor") && Tabela.ToLower().Equals("pgf"))
                            {
                                r["total"] = dr[col.ColumnName];
                            }
                            else if (col.ColumnName.Equals("valor") && Tabela.ToLower().Equals("rcl"))
                            {
                                r["total"] = dr[col.ColumnName];
                            }
                            else if (col.ColumnName.Equals("rclno") && Tabela.ToLower().Equals("rcl"))
                            {
                                r["numero"] = dr[col.ColumnName];
                            }
                            else if (col.ColumnName.Equals("ccudesc"))
                            {
                                r["ccusto"] = dr[col.ColumnName];
                            }
                            else if (col.ColumnName.Equals("pgfno") && Tabela.ToLower().Equals("pgf"))
                            {
                                r["Numero"] = dr[col.ColumnName];
                            }
                        }
                    }
                    else
                    {
                          r["pestamp"] = dr["pestamp"];
                          r["no"] =dr["no"];
                          r["nome"] =dr["nome"];
                          r["Bairro"] =dr["morada"];
                          r["Nacional"] =dr["Nacional"];
                          r["datanasc"] =dr["datanasc"];
                          r["Ecivil"] =dr["ecivil"];
                          r["pai"] =dr["pai"];
                          r["mae"] =dr["mae"];
                          r["sexo"] =dr["sexo"];
                          r["codsit"] =dr["codstatus"];
                          r["Situacao"] =dr["descstatus"];
                          r["nuit"] =dr["nuit"];
                          r["CodCateg"] =dr["codcat"];
                          r["Categ"] =dr["desccat"];
                          r["Codprof"] =dr["codprof"];
                          r["Prof"] =dr["descprof"];
                          r["dataadm"] =dr["dataadm"];
                          r["Ntabelado"] =dr["ntabelado"];
                          r["RelPonto"] =dr["Ponto"];
                          r["Pontonome"] =dr["Pontonome"];
                          r["ValBasico"] =dr["salbase"];
                          r["basedia"] =dr["basedia"];
                          r["codnivel"]=dr["codhabliter"];
                          r["Nrdepend"] =dr["dep"];
                          r["nivel"] =dr["habliter"];
                          r["BalcaoInss"] =dr["descsgs"];
                          r["Nrinss"] =dr["numsgs"];
                          r["CCusto"] =dr["locatrab"];
                          r["Codep"] =dr["codDepart"];
                          r["Depart"] =dr["departamento"];
                          r["SalHora"] =dr["basehora"];
                          r["formapag"] =dr["formapag"];
                          r["codformp"] =dr["codformp"];
                          r["codccu"]=dr["codloctrab"];
                          r["ProvNasc"] =dr["descprov"];
                    }
                }
                else if(Origem=="PRI")
                {
                    switch (Tabela)
                    {
                        case "clientes":
                            r["no"] = dr["Cliente"];
                            r["nome"] = dr["nome"];
                            r["morada"] = dr["Fac_Mor"];
                            r["telefone"] = dr["Fac_Tel"];
                            r["celular"] = dr["Fac_Tel"];
                            r["fax"] = dr["Fac_Fax"];
                            r["datacl"] = dr["DataCriacao"];
                            r["email"] = dr["EnderecoWeb"];
                            r["nuit"] = dr["NumContrib"].ToDecimal();
                            r["localidade"] = dr["Fac_Local"];
                            r["datacl"] = dr["DataCriacao"];
                            break;
                        case "Artigo":
                            r["referenc"] = dr["Artigo"];
                            r["descricao"] = dr["descricao"];
                            r["unidade"] = dr["unidadevenda"];
                            r["Tabiva"] = 2;
                            r["Txiva"] = 17;
                            break;
                    }
                }
                if (Tabela.ToLower() == "rcl")
                {
                    if (Trcl!=null)
                    {
                        r["Numdoc"] = Trcl["Numdoc"];
                        r["Nomedoc"] = Trcl["Descricao"];
                        r["Sigla"] = Trcl["Sigla"];
                    }
                }
                if (Tabela.ToLower() == "facc")
                {
                    if (dr.Table.RowZero("Numdoc").ToInt()==1)
                    {
                        r["Numdoc"] = 1;
                        r["Nomedoc"] = "Factura";
                        r["Sigla"] = "FTF";
                    }
                    else
                    {
                        r["Numdoc"] = dr.Table.RowZero("Numdoc");
                        r["Nomedoc"] = dr.Table.RowZero("Nomedoc"); 
                        r["Sigla"] = dr.Table.RowZero("Sigla"); 
                    }
                }
                r["Ccusto"] = Pbl.Usr.Ccusto;
                r["Ccustamp"] = Pbl.Usr.Ccustamp;
                if (Tabela.ToLower() == "rcl" || Tabela.ToLower() == "fact")
                {
                    r["clstamp"] = SQL.GetField($"select clstamp from cl where no ='{dr["no"].ToTrim()}'").ToString(); ;
                }
                
                DtCl.Rows.Add(r);
                if (Origem==null)
                {
                    if (SQL.Save(DtCl, Tabela, true, "", "").numero > 0)
                    {
                        if (Tabela !="pe")
                        {
                            DtFilha = SQL.Initialize(TabelaFilha);
                            if (!TabelaFilha.IsNullOrEmpty() && TabelaFilha.ToLower().Equals("stprecos"))
                            {
                                if (TabelaFilha.ToLower().Equals("stprecos"))
                                {
                                    var rw = DtFilha.NewRow().Inicialize();
                                    rw["Ststamp"] = r["Ststamp"];
                                    rw["CCusto"] = Pbl.Usr.Ccusto;
                                    rw["Ccustamp"] = Pbl.Usr.Ccustamp;
                                    rw["Preco"] = dr["valor1"];
                                    rw["Ivainc"] = dr["valor1inc"]; //status
                                    rw["status"] = "Activo";
                                    DtFilha.Rows.Add(rw);
                                }
                            }
                            if (!TabelaFilha.IsNullOrEmpty())
                            {
                                var filha = "";
                                filha = TabelaFilha.Trim() == "pgfl" ? "pglf" : TabelaFilha;
                                var dt = SQL.GetGenDT($"select * from {filha} where {Tabela.Trim()}stamp ='{dr[$"{Tabela.Trim()}stamp"].ToString().Trim()}'", Con);
                                if (dt.HasRows())
                                {
                                    foreach (var row in dt.AsEnumerable())
                                    {
                                        if (row != null)
                                        {
                                            DataRow rw = DtFilha.NewRow().Inicialize();
                                            foreach (DataColumn col in row.Table.Columns)
                                            {
                                                if (DtFilha.Columns.Contains(col.ColumnName))
                                                {
                                                    rw[col.ColumnName] = row[col.ColumnName];
                                                }
                                                if (col.ColumnName.Equals("pglfstamp") && Tabela.ToLower().Equals("pgf"))
                                                {
                                                    rw["pgflstamp"] = row[col.ColumnName];
                                                }
                                            }
                                            DtFilha.Rows.Add(rw);
                                        }
                                    }
                                }

                            }
                            SQL.Save(DtFilha, TabelaFilha, true, "", "");
                        }
                        else
                        {
                            if (!dr["numdocum"].ToString().IsNullOrEmpty())
                            {
                                var pedoc = SQL.Initialize<Pedoc>();
                                var pedocr = pedoc.NewRow().Inicialize();
                                pedocr["Documento"] = dr["tipodocum"];
                                pedocr["Numero"] = dr["numdocum"];
                                pedocr["Local"] = dr["locemiss"];
                                pedocr["Emissao"] = dr["dataemiss"];
                                pedocr["Validade"] = dr["documvalid"];
                                pedocr["Pestamp"] = dr["Pestamp"];
                                pedoc.Rows.Add(pedocr);
                                SQL.Save(pedoc, "Pedoc", true, "", "");
                            }
                            if (!dr["contacto"].ToString().IsNullOrEmpty())
                            {
                                var pecont = SQL.Initialize<Pecont>();
                                var pecontr = pecont.NewRow().Inicialize();
                                pecontr["Contacto"] = dr["Contacto"];
                                pecontr["Email"] = false;
                                pecontr["padrao"] = true;
                                pecontr["Pestamp"] = dr["Pestamp"];
                                pecont.Rows.Add(pecontr);
                                SQL.Save(pecont, "Pecont", true, "", "");
                            }
                            if (!dr["email"].ToString().IsNullOrEmpty())
                            {
                                var pecont = SQL.Initialize<Pecont>();
                                var pecontr = pecont.NewRow().Inicialize();
                                pecontr["Contacto"] = dr["email"];
                                pecontr["Email"] = true;
                                pecontr["padrao"] = true;
                                pecontr["Pestamp"] = dr["Pestamp"];
                                pecont.Rows.Add(pecontr);
                                SQL.Save(pecont, "Pecont", true, "", "");
                            }
                            if (!dr["desccontr"].ToString().IsNullOrEmpty())
                            {
                                var pecontra = SQL.Initialize<Pecontra>();
                                var pecontrar = pecontra.NewRow().Inicialize();
                                pecontrar["Codigo"] = dr["codcontr"];
                                pecontrar["Descricao"] = dr["desccontr"];
                                pecontrar["Inicio"] = dr["datcontr1"]; 
                                pecontrar["Termino"] = dr["datcontr2"]; 
                                pecontrar["Pestamp"] = dr["Pestamp"];
                                pecontra.Rows.Add(pecontrar);
                                SQL.Save(pecontra, "pecontra", true, "", "");
                            }

                            if (!dr["banco"].ToString().IsNullOrEmpty())
                            {
                                var pebanc = SQL.Initialize<Pebanc>();
                                var pebancr = pebanc.NewRow().Inicialize();
                                pebancr["Nome"] = dr["banco"];
                                pebancr["Sigla"] = dr["codbanco"];
                                pebancr["Conta"] = dr["numconta"].ToDecimal(); 
                                pebancr["Nib"] = dr["Nib"];
                                pebancr["Pestamp"] = dr["Pestamp"];
                                pebanc.Rows.Add(pebancr);
                                SQL.Save(pebanc, "Pebanc", true, "", "");
                            }
                            var peferias = SQL.GetGen2DT("peferias", $"pestamp='{dr["Pestamp"].ToString().Trim()}'",Con);
                            if (peferias.HasRows())
                            {
                                var Pefer = SQL.Initialize<Pefer>();
                                foreach (var item in peferias.AsEnumerable())
                                {
                                    var pebancr = Pefer.NewRow().Inicialize();
                                    pebancr["Descricao"] = item["Descricao"];
                                    pebancr["inicio"] = item["inicio"];
                                    pebancr["Termino"] = item["Termino"];
                                    pebancr["Ano"] = item["Ano"];
                                    pebancr["Dias"] = item["Dias"];
                                    pebancr["estado"] = item["estado"];
                                    pebancr["Pestamp"] = item["Pestamp"];//
                                    pebancr["Peferstamp"] = item["peferiasstamp"];
                                    Pefer.Rows.Add(pebancr);
                                }                             
                                SQL.Save(Pefer, "Pefer", true, "", "");
                            }

                            var pesubdt = SQL.GetGen2DT("pesub", $"pestamp='{dr["Pestamp"].ToString().Trim()}'", Con);
                            if (pesubdt.HasRows())
                            {
                                var pesub = SQL.Initialize<Pesub>();
                                foreach (var item in pesubdt.AsEnumerable())
                                {
                                    var pesubr = pesub.NewRow().Inicialize();
                                    pesubr["codigo"] = item["codigo"];
                                    pesubr["Descricao"] = item["Descricao"];
                                    pesubr["Valor"] = item["Valor"];
                                    pesubr["Tipo"] = item["Tipo"];
                                    pesubr["Pestamp"] = item["Pestamp"];
                                    pesubr["Pesubstamp"] = item["Pesubstamp"];
                                    pesub.Rows.Add(pesubr);
                                }
                                SQL.Save(pesub, "pesub", true, "", "");
                            }

                            var pedescdt = SQL.GetGen2DT("pedesc", $"pestamp='{dr["Pestamp"].ToString().Trim()}'", Con);
                            if (pedescdt.HasRows())
                            {
                                var pedesc = SQL.Initialize<Pedesc>();
                                foreach (var item in pedescdt.AsEnumerable())
                                {
                                    var pedescr = pedesc.NewRow().Inicialize();
                                    pedescr["codigo"] = item["codigo"];
                                    pedescr["Descricao"] = item["Descricao"];
                                    pedescr["Valor"] = item["Valor"];
                                    pedescr["Tipo"] = item["Tipo"];
                                    pedescr["Pestamp"] = item["Pestamp"];
                                    pedescr["pedescstamp"] = item["pedescstamp"];
                                    pedesc.Rows.Add(pedesc);
                                }
                                SQL.Save(pedesc, "pedesc", true, "", "");
                            }
                        }
                    }
                }
                else if(Origem=="PRI")
                {
                    if (SQL.Save(DtCl, tab, true, "", "").numero>0)
                    {
                        DtFilha = SQL.Initialize(TabelaFilha);
                        if (!TabelaFilha.IsNullOrEmpty() && TabelaFilha.ToLower().Equals("stprecos"))
                        {
                            var xxx = $"select pvp1 from artigomoeda where Moeda='MT' and Artigo ='{dr["Artigo"].ToString().Trim()}'";
                            var stprec = SQL.GetGenDT(xxx, Con);
                            if (stprec.HasRows())
                            {
                                if (TabelaFilha.ToLower().Equals("stprecos"))
                                {
                                    var rw = DtFilha.NewRow().Inicialize();
                                    rw["Ststamp"] = r["Ststamp"];
                                    rw["CCusto"] = Pbl.Usr.Ccusto;
                                    rw["Ccustamp"] = Pbl.Usr.Ccustamp;
                                    rw["CodCCu"]=Pbl.Usr.Codccu;    
                                    rw["Preco"] = stprec.RowZero("pvp1").ToDecimal();
                                    rw["moeda"] = "MZN";
                                    rw["Ivainc"] = true;
                                    DtFilha.Rows.Add(rw);
                                }
                            }
                            SQL.Save(DtFilha, TabelaFilha, true, "", "");
                        }
                    }
                }
                if (Tabela.ToLower() == "rcl" || Tabela.ToLower() == "pgf" || Tabela.ToLower() == "fact" || Tabela.ToLower() == "facc")
                {
                    if (DtCl.HasRows())
                    {
                        var cond = $"{Tabela.ToLower().Trim()}stamp ='{DtCl.RowZero($"{Tabela.ToLower().Trim()}stamp").ToTrim()}'";
                        //if (Tabela.ToLower() == "rcl")
                        //{
                        //    cond = $"rclstamp ='{DtCl.RowZero("rclstamp").ToTrim()}'";
                        //}
                        //else if(Tabela.ToLower() == "pgf")
                        //{
                        //    cond = $"rclstamp ='{DtCl.RowZero("rclstamp").ToTrim()}'";
                        //}
                        var formasp = SQL.GetGenDT($"select * from formasp where {cond}", Con);

                        if (formasp.HasRows())
                        {
                            var fp = SQL.Initialize("formasp");
                            foreach (var item in formasp.AsEnumerable())
                            {
                                var linha = fp.NewRow().Inicialize();
                                linha["formaspstamp"] = item["formaspstamp"];
                                linha["titulo"] = item["titulo"];
                                linha["banco"] = item["banco"];
                                linha[$"{Tabela.ToLower().Trim()}stamp"] = item[$"{Tabela.ToLower().Trim()}stamp"];
                                //
                                linha["contatesoura"] = item["contatesoura"];
                                linha["numtitulo"] = item["numtitulo"];
                                linha["valor"] = item["valor"];
                                linha["codtz"] = item["codtz"];
                                if (Tabela.ToLower() == "rcl")
                                {
                                    linha["Codmovtz"] = 5;
                                    linha["Descmovtz"] = "NE/Recibo de cliente";
                                }
                                if (Tabela.ToLower() == "pgf")
                                {
                                    linha["Codmovtz"] = 56; 
                                    linha["Descmovtz"] = "NS/Recibo de fornecedor ";

                                    //linha["codmovcc"] = DtCl.RowZero("codmovcc"); 
                                    //linha["descmovcc"] = DtCl.RowZero("descmovcc");
                                }
                                linha["Ccusto"] = Pbl.Usr.Ccusto;
                                linha["Ccustamp"] = Pbl.Usr.Ccustamp;

                                linha["no"] = DtCl.RowZero("no");
                                linha["nome"] = DtCl.RowZero("nome");

                                fp.Rows.Add(linha);
                            }
                            SQL.Save(fp, "formasp", true, "", "");
                        }
                    }
                }
            }
            if (fim)
            {
                //if (SQL.Save(DtCl,Tabela, true, "", "").numero>0)
                //{
                //    SQL.Save(DtFilha, TabelaFilha, true, "", "");
                //    MsBox.Show("Dados gravados com sucesso");
                //}
            }
        }

        private void FrmImportCl_Load(object sender, EventArgs e)
        {
            DtCl = SQL.Initialize(Tabela);
            if (!TabelaFilha.IsNullOrEmpty())
            {
                if (TabelaFilha.Equals("StPrecos"))
                {
                    DtFilha = SQL.Initialize("StPrecos");
                }
                
            }
          dmzDdN1.ano.Value = Pbl.SqlDate.Year;
          comboTdoc.DataSource = null;
            if (tipodoc !=null)
            {
                comboTdoc.DataSource = tipodoc;
                comboTdoc.ValueMember = tipodoc.Columns[0].ToString();
                comboTdoc.DisplayMember = tipodoc.Columns[1].ToString();
            }
        }

        private void cbDefault1_CheckedChangeds()
        {
            gridUi1.CheckUncheckAll("ok", cbDefault1.cb1.Checked);
        }

        private void tbProcura_TextChanged(object sender, EventArgs e)
        {
            Helper.UpdateGrid(false, gridUi1, dtImport, tbProcura.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _myServer = new Server(comboBox1.Text.Trim());
            foreach (Database db in _myServer.Databases)
            {
                comboBox2.Items.Add(db.Name.Trim());
            }
        }
    }
}
