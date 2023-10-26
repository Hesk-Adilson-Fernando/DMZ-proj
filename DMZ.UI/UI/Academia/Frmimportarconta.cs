using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DMZ.UI.UI.Academia
{
    public partial class Frmimportarconta : FrmClasse2
    {
        public Frmimportarconta()
        {
            InitializeComponent();
        }

        public Tdoc TmpTdoc { get; set; }
        private void Import_Load(object sender, EventArgs e)
        {
            var dataTable = SQL.GetGenDT("select Contasstamp,Entidadebanc from Contas where Entidadebanc <>''");
            DataTbEntidade = dataTable;
            BindCombo(cbEntidade, dataTable);
            TmpTdoc = SQL.GetRowToEnt<Tdoc>("ft=1");
        }
        public DataRowView DtEntidade { get; set; }
        public string Numinterno { get; set; }
        public DataRowView Dtv { get; set; }
        string lista = "";
        private Fact _fact;
        private DataTable DataTbEntidade { get; set; }
        private void BindCombo(ComboBox cb, DataTable dt)
        {
            cb.DataSource = null;
            cb.DataSource = dt;
            cb.DisplayMember = dt.Columns[1].ToString();
            cb.ValueMember = dt.Columns[0].ToString();
        }
        private void RecebeDados(DataRow item, bool fim)
        {
            if (item != null)
            {
                var dtalunos = dataGridView1.GetBindedTable();
                var ssnome = "";
                try
                {
                    var campos = new[]
                               {
                        "Turmastamp", "Codigo","Descanoaem", "Descurso", "Cursostamp","Etapa","Clstamp"
                    };
                    if (dtalunos.HasRows())
                    {
                        dtalunos = dtalunos.DefaultView.
                            ToTable(true, campos);
                    }
                    var dtturma = dtalunos.GetTable($@"Clstamp='{item["Clstamp"]}'");
                    var cl = new Cl();
                    var valor = item["debito"].ToDecimal();
                    cl.No = item["no"].ToString();
                    ssnome = cl.Nome = item["nome"].ToString();
                    cl.Clstamp = item["Clstamp"].ToString();
                    cl.Morada = item["Morada"].ToString();
                    cl.Localidade = item["Localidade"].ToString();
                    cl.Nuit = item["Nuit"].ToDecimal();
                    var ft = Utilities.DoAddline<Fact>();
                    ft.Total = valor;
                    if (item["pago"].ToDecimal() > 0)
                    {
                        //ft.Fechada = ft.Pago = true;
                    }
                    else
                    {
                      //  ft.Fechada = ft.Pago = false;
                    }
                    ft.Obs = "Importado Conta corrente siga".ToUpper();
                    ft.Referencia = item["Referencia"].ToString();
                    DtEntidade = DataTbEntidade.DefaultView[0];
                    if (dtturma != null)
                    {
                        if (dtturma.HasRows())
                        {
                            var trm = dtturma.DtToList<Turma>();
                            var turma = trm.FirstOrDefault();
                            if (turma != null)
                            {
                                ft.Turmastamp = turma.Turmastamp.Trim();
                                ft.Descturma = turma.Codigo.Trim();
                                ft.Cursostamp = turma.Cursostamp.Trim();
                                ft.Desccurso = turma.Descurso.Trim();
                                ft.Anosem = turma.Descanoaem.Trim();
                                ft.Etapa = turma.Etapa.Trim();
                            }
                        }
                    }
                    HelperFact.FillFactura(ft, cl, DateTime.Now, TmpTdoc, DtEntidade, null, 0.ToString());
                    var ftl = SQL.Initialize("factl");
                    var dr = ftl.NewRow().Inicialize();
                    dr["descricao"] = item["tipo_emolumento"];
                    dr["ref"] = item["Referencia"].ToString();
                    dr["Preco"] = valor;
                    if (!item["data_pagamento"].ToString().IsNullOrEmpty() &&
                       !string.IsNullOrWhiteSpace(item["data_pagamento"].ToString())
                       &&
                       item["data_pagamento"]!=null
                        )
                    {
                      //  ft.Dataven = ft.Data_limite_pagamento = item["data_limite_pagamento"].ToDateTimeValue();
                    }
                    //ft.Data = ft.Datapagamento = item["data_pagamento"].ToDateTimeValue();
                    HelperFact.FillFactl(null, dr, ft.Factstamp);
                    ftl.Rows.Add(dr);
                    HelperFact.TotaisFt(ft, ftl);
                    ft.MatriculaAluno = false;
                    ft.Inscricao = false;
                    ft.Nomedoc = TmpTdoc.Descricao;
                    if (EF.Save(ft).ret > 0)
                    {
                        SQL.Save(ftl, "factl", true, ft.Factstamp, "fact");
                    }

                }
                catch (Exception ex)
                {

                }
                if (fim)
                {

                    MsBox.Show($"{Messagem.ParteInicial()}Conta corrente importada com sucesso.");
                }
            }
        }
        public string PrimaryKeyName { get; set; }
        public string Ctabela { get; set; }
        public T DoAddline<T>() where T : class, new()
        {
            var t = new T();
            var nomeClasse = typeof(T).Name;
            var lista = SQL.GetGenDT(" INFORMATION_SCHEMA.COLUMNS ",
                $" WHERE table_name = '{nomeClasse.Trim()}' and IS_NULLABLE='YES' ", " column_name ");
            var properties = typeof(T).GetProperties();
            foreach (var p in properties)
            {
                if (p.PropertyType == typeof(string))
                {
                    if (!Ctabela.IsNullOrEmpty())
                    {
                        if (p.Name.Trim().ToLower().Contains("stamp") && p.Name.Trim().ToLower().Contains(Ctabela.ToLower().Trim()))
                        {
                            CLocalStamp = Pbl.Stamp();
                            PrimaryKeyName = p.Name.Trim();
                            p.SetValue(t, CLocalStamp);
                        }
                    }
                    if (p.Name == "qmc")
                    {
                        p.SetValue(t, Pbl.Usr.Usrstamp);
                    }
                    if (lista.Rows.Count > 0)
                    {
                        var r = lista.AsEnumerable().FirstOrDefault(x => x.Field<string>("column_name").Equals(p.Name));
                        if (r != null)
                        {
                            if (p.Name != "qmc")
                            {
                                p.SetValue(t, null);
                            }
                        }
                    }
                }
                if (p.PropertyType == typeof(DateTime))
                {
                    p.SetValue(t, new DateTime(1900, 1, 1));
                }
                if (p.Name == "qmadathora")
                {
                    p.SetValue(t, new DateTime(1900, 1, 1));
                }
                if (p.Name == "qmcdathora")
                {
                    p.SetValue(t, Pbl.SqlDate);
                }
            }
            return t;
        }

        private void BtnProcura_Click(object sender, EventArgs e)
        {
            var query = $@"select debito,pago,Referencia,tipo_emolumento,convert(datetime,data_limite_pagamento) data_limite_pagamento,
convert(datetime,data_pagamento) data_pagamento,

								Clstamp=	(select distinct Clstamp  from ISEDEF..cl e where Aluno=1 and no in 
                                       (select numero from ISEDEF..Estudante e where e.id=c.estudante_id))   ,
									   	nome=	(select distinct nome  from ISEDEF..cl e where Aluno=1 and no in 
                                       (select numero from ISEDEF..Estudante e where e.id=c.estudante_id))   ,

									   	Localidade=	(select distinct Localidade  from ISEDEF..cl e where Aluno=1 and no in 
                                       (select numero from ISEDEF..Estudante e where e.id=c.estudante_id))   ,
									   
									   	Morada=	(select distinct Morada  from ISEDEF..cl e where Aluno=1 and no in 
                                       (select numero from ISEDEF..Estudante e where e.id=c.estudante_id))   ,
									   
									   	No=	(select distinct No  from ISEDEF..cl e where Aluno=1 and no in 
                                       (select numero from ISEDEF..Estudante e where e.id=c.estudante_id))   ,

									   
									   	Nuit=	(select distinct Nuit  from ISEDEF..cl e where Aluno=1 and no in 
                                       (select numero from ISEDEF..Estudante e where e.id=c.estudante_id))   ,
									   	Id=	(select e.id from ISEDEF..Estudante e where e.id=c.estudante_id)   ,
									   
									   
									   Codigo=(select top 1 codigo from 
                                       ISEDEF..Turma e where e.Cursostamp=(select distinct e.Codcurso  from ISEDEF..cl e where Aluno=1 and no in 
                                       (select numero from ISEDEF..Estudante e where e.id=c.estudante_id)))
									   ,
									   Turmastamp=(select top 1 Turmastamp from 
                                       ISEDEF..Turma e where e.Cursostamp=(select distinct e.Codcurso  from ISEDEF..cl e where Aluno=1 and no in 
                                       (select numero from ISEDEF..Estudante e where e.id=c.estudante_id)))									   
									   ,
									   Turmastamp=(select top 1 Turmastamp from 
                                       ISEDEF..Turma e where e.Cursostamp=(select distinct e.Codcurso  from ISEDEF..cl e where Aluno=1 and no in 
                                       (select numero from ISEDEF..Estudante e where e.id=c.estudante_id)))							   
									   ,
									   Descanoaem=(select top 1 Descanoaem from 
                                       ISEDEF..Turma e where e.Cursostamp=(select distinct e.Codcurso  from ISEDEF..cl e where Aluno=1 and no in 
                                       (select numero from ISEDEF..Estudante e where e.id=c.estudante_id)))				   
									   ,
									   Descurso=(select top 1 Descurso from 
                                       ISEDEF..Turma e where e.Cursostamp=(select distinct e.Codcurso  from ISEDEF..cl e where Aluno=1 and no in 
                                       (select numero from ISEDEF..Estudante e where e.id=c.estudante_id)))		   
									   ,
									   Cursostamp=(select top 1 Cursostamp from 
                                       ISEDEF..Turma e where e.Cursostamp=(select distinct e.Codcurso  from ISEDEF..cl e where Aluno=1 and no in 
                                       (select numero from ISEDEF..Estudante e where e.id=c.estudante_id)))	   
									   ,
									   Etapa=(select top 1 Etapa from 
                                       ISEDEF..Turma e where e.Cursostamp=(select distinct e.Codcurso  from ISEDEF..cl e where Aluno=1 and no in 
                                       (select numero from ISEDEF..Estudante e where e.id=c.estudante_id)))

from ContaCorre c

";
            var alunos = SQL.GetGenDT(query);
            label3.Text = $@"{alunos.Rows.Count} Dados Encontrado(s)";
            dataGridView1.SetDataSource(alunos);

        }

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            var alunos = dataGridView1.GetBindedTable();
            if (alunos.HasRows())
            {
                Helper.DoProgressProcess(alunos, RecebeDados, "nome");
            }
        }
    }
}
