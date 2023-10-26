using System.Data;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Generic;
using DMZ.UI.UI.Contabil;

namespace DMZ.UI.Classes
{
    public static class Integracao
    {
        public static void CriaConta(DataRow r, string grupo,DataTable dtPgc,DataTable dtClct,string descgrupo,string tabela,string contacc,string ctabela)
        {
            var conta = grupo+r["no"];//Helper.GetMaxConta(grupo);
            if (!SQL.CheckExist("conta","pgc",$"conta='{conta.Trim()} and ano =(select ano from param)'"))
            {
                var dataRowr = dtPgc.NewRow().Inicialize();
                dataRowr["oristamp"] = r[$"{tabela.Trim()}stamp"];
                dataRowr["ppconta"] = ctabela;
                dataRowr["Conta"] = conta;
                dataRowr["Descricao"] = r["nome"];
                dataRowr["ano"] = Pbl.AnoContabil();
                dtPgc.Rows.Add(dataRowr);
                var dRowr = dtClct.NewRow().Inicialize();
                dRowr["Descgrupo"] = descgrupo;//;
                dRowr["Contacc"] = grupo == contacc;
                dRowr[$"{tabela.Trim()}stamp"] = r[$"{tabela.Trim()}stamp"];
                dRowr["Conta"] = conta;
                dtClct.Rows.Add(dRowr);
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial() + $"Já existe uma conta, com número: {conta}, o Software não consegue criar");
            }
        }
        public static void Gravar(DataTable dtPgc,DataTable dtClct,string cttabela)
        {
            SQL.Save(dtPgc, "pgc", true, "", "");
            SQL.Save(dtClct, cttabela,true,"","");
            MsBox.Show(Messagem.ParteInicial()+"Dados Gravados com suscesso");
        }

        internal static int UpdatePGC(string conta,string stamp)
        {
            return SQL.SqlCmd($@" update pgc set oristamp ='{stamp.Trim()}' where 
                    ano =(select ano from param) and Conta ='{conta.Trim()}'");
        }

        public static DataTable BindGrid(GridUi dataGridView1,string grupo,string tabelaName,string campos,string orderby)
        {
            var dtCl = SQL.GetGen2DT($@" select  {campos},cast(0 as bit) ok,{tabelaName}stamp   from {tabelaName} 
                                                 where not exists(select oristamp from pgc where pgc.oristamp={tabelaName}.{tabelaName}stamp 
                                                 and SUBSTRING(conta,1,{grupo.Length})='{grupo}' and  ano =(select ano from param)) order by convert(decimal,{orderby})");
            if (dtCl?.Rows.Count > 0)
            {
                dataGridView1.DataSource = null;
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = dtCl;
            }
            return dtCl;
        }
        internal static void CadastroContas(Form f,string tabela, bool MostraSubgrupo=false)
        {
            var _ctTabela =$"{tabela.Trim()}ct";
            string _condicao="",_campos="",_orderBy="",_origem="",_contacc="";
            if (tabela.Equals("cl")||tabela.Equals("pe")||tabela.Equals("fnc"))
            {
                _campos="no,nome";
                _orderBy="no";
            }
            else if(tabela.Equals("contas"))
            {
                _campos="codigo as no,descricao+' '+Convert(char,Numero) as nome";
                _orderBy="codigo";
            }
            switch (tabela)
            {
                case "pe":
                    _condicao="'4621','4622','4623','4628','4629'";
                    _origem="Pessoal";
                    _contacc="4621";
                    break;
                case "cl":
                    _condicao="'411','412','418','419'";
                    _origem="Clientes";
                    _contacc="411";
                    break;
                case "Contas":
                    _condicao="'11','121','122','123'";
                    _origem="Contas";
                    _contacc="11";
                    break;
               case "fnc":
                    _condicao="'421','422','429'";
                    _origem="Fornecedores";
                    _contacc="421";
                    break;
            }
            var w = new FrmIntegCadastro
            {
                CtTabela = _ctTabela,
                Condicao =_condicao,
                label1 = {Text = $"Integração de contas de {_origem} na Contabilidade"},
                Tabela = tabela,
                Contacc = _contacc,
                Campos = _campos,
                OrderBy=_orderBy,
                MostraSubgrupo= MostraSubgrupo
            };
            w.ShowForm(f);
        }
        internal static void Integradoc(Form f, string tabela)
        {
            string _select="", _ocampos="", _titulo="";
            switch (tabela.ToLower())
            {
                case "fact":
                    _select="select Numdoc,Descricao from tdoc where ft=1 or Vd=1 or Nc=1 or nd=1 order by numdoc";
                    _ocampos="Totaliva,Subtotal,desconto,";
                    _titulo="Facturação de clientes!";
                    break;
                 case "facc":
                    _select="select Numdoc,Descricao from tdocf where ft=1 or Vd=1 or Nc=1 or nd=1 order by numdoc";
                    _ocampos="Totaliva,Subtotal,desconto,";
                    _titulo="Facturação de Fornecedores!";
                    break;
                case "rcl":
                    _select="select Numdoc,Descricao from Trcl order by numdoc";
                    _titulo="Recibos de Clientes!";
                    break;
                case "percl":
                    _select = "select Numdoc,Descricao from Tpgf where rh=1 order by numdoc";
                    _titulo = "Recibos de ordenados!";
                    break;
                case "pgf":
                    _select="select Numdoc,Descricao from Tpgf where rh=0  order by numdoc";
                    _titulo="Pagamentos a fornecedores!";
                    break;
            }
            var b = new FrmIntegradoc();
            b.barraText1.label1.Text = _titulo;
            b.TipoDoc.SqlComandText = _select;
            b.Tabela = tabela;
            b.Ocampos = _ocampos;
            b.ShowForm(f);
        }
        public static void Apagar(string deleteconta,string tabela)
        {
            SQL.SqlCmd($"delete from {tabela} where conta ='{deleteconta.Trim()}'");
        }

        internal static string GetContaNaContabilidade(string nome,string radial)
        {
            string conta ="";
            var dr = SQL.GetRow($@"select conta from pgc where 
                        ltrim(rtrim(Descricao))='{nome.Trim()}' 
                        and ano =(select ano from param) and Conta like('{radial.Trim()}%')");
            if (dr != null)
            {
                conta=dr["conta"].ToString();
            }
            return conta;            
        }
    }
}
