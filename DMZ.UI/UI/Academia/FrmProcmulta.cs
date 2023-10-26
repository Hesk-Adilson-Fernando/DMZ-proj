using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmProcmulta : Basic.FrmClasse2
    {
        private DataTable dtt;
        private DataTable dtPlano;
        public Tdoc TmpTdoc { get; private set; }
        public DataRowView Dtv2 { get; private set; }

        public FrmProcmulta()
        {
            InitializeComponent();
        }

        private void FrmProcmulta_Load(object sender, EventArgs e)
        {
            var dtEntidade = SQL.GetGen2DT("select Contasstamp,Entidadebanc from Contas where Entidadebanc <>''");
            BindCombo(cbEntidade, dtEntidade);
            var dtPlano = SQL.GetGen2DT("select Planomultastamp,Descricao from Planomulta");
            BindCombo(cbPlanomulta, dtPlano);
        }
        private void BindCombo(ComboBox cb, DataTable dt)
        {
            cb.DataSource = dt;
            cb.DisplayMember = dt.Columns[1].ToString();
            cb.ValueMember = dt.Columns[0].ToString();
        }

        private void btnProcurar_Click(object sender, EventArgs e)
        {
            var xxx = $@"select cc.no,cc.nome,cc.descricao,cc.Referencia,cc.Entidadebanc,data,vencim,valorpreg, DATEDIFF(day,vencim,getdate()) dias,cl.clstamp,cl.Curso,ccstamp,cast(0 as bit) as ok from clccf() cc join cl on cl.Clstamp=cc.Clstamp
                    where convert(date,vencim)<=convert(date,getdate()) and origem='FT' order by cl.Curso,cc.nome,data"; 
            dtt = SQL.GetGen2DT(xxx);
            if (dtt.HasRows())
            {
                tbTotal.Text = $"{dtt.Rows.Count + " documentos"}";
            }
            else
            {
                tbTotal.Text = "";
            }
            gridUiAlunos.SetDataSource(dtt);
        }

        private void btnProcess_Click(object sender, EventArgs e)
        {
            var dr = MsBox.Show("Deseja que o Software Crie automaticame as mensalidades de alunos segundo o plano indicado?", DResult.YesNo);
            if (dr.DialogResult != DialogResult.Yes) return;
            dtt = dtt.GetCheckedRows("ok");
            if (dtt.HasRows())
            {
                dtPlano = SQL.GetGen2DT($"select Valor,perc,Dias, Usaperc from Planomultal where Planomultastamp='{cbPlanomulta.SelectedValue.ToString().Trim()}' order by Ordem ");
                TmpTdoc = SQL.GetRowToEnt<Tdoc>("ft=1");
                Dtv2 = cbEntidade.SelectedItem as DataRowView;
                Helper.DoProgressProcess(dtt, RecebeDados);
            }
            else
            {
                MsBox.Show("O plano indicado não tem parcelas criadas, porfavor verifica!");
            }
        }
        private void RecebeDados(DataRow r, bool fim)
        {
            var cl = SQL.GetRowToEnt<Cl>($"clstamp='{r["Clstamp"].ToString().ToTrim()}'");
            var ft = SQL.GetRowToEnt<Fact>($"factstamp='{r["ccstamp"].ToString().ToTrim()}'");
            if (r != null)
            {
                if (!SQL.CheckExist($"select oristamp from fact where oristamp='{ft.Factstamp.Trim()}'"))
                {
                    var _ft = Utilities.DoAddline<Fact>();
                    HelperFact.FillFactura(_ft, cl, Pbl.SqlDate, TmpTdoc, Dtv2, null, ft.Numinterno);
                    _ft.Turmastamp = ft.Turmastamp.Trim();
                    _ft.Descturma = ft.Descturma.Trim();
                    _ft.Cursostamp = ft.Cursostamp;
                    _ft.Desccurso = ft.Desccurso;
                    _ft.Anosem = ft.Anosem;
                    _ft.Etapa = ft.Etapa;
                    _ft.Oristamp = ft.Factstamp;
                    _ft.NrFactura = ft.Numero;
                    _ft.Multa = true;
                    var ftl = SQL.Initialize("factl");
                    var dr = ftl.NewRow().Inicialize();
                    HelperFact.FillFactl(null, dr, _ft.Factstamp);
                    Executar(r, ft, dr);
                    ftl.Rows.Add(dr);
                    HelperFact.TotaisFt(_ft, ftl);
                    if (EF.Save(_ft).ret > 0)
                    {
                        SQL.Save(ftl, "factl", true, _ft.Factstamp, "fact");
                    }
                }
                else
                {
                    var ftMulta= SQL.GetRowToEnt<Fact>($"oristamp='{r["ccstamp"].ToString().ToTrim()}'");
                    var factl = SQL.GetGen2DT($"select * from factl where factstamp='{ftMulta.Factstamp.Trim()}'");
                    if (ftMulta !=null)
                    {
                        if (factl.HasRows())
                        {
                            Executar(r, ft, factl.Rows[0]);
                            HelperFact.TotaisFt(ftMulta, factl);
                            if (EF.Save(ftMulta).ret > 0)
                            {
                                SQL.Save(factl, "factl", true, ftMulta.Factstamp, "fact");
                            }
                        }
                    }
                }
            }
            if (fim)
            {
                MsBox.Show("Processo terminado com sucesso");
            }
        }

        private void Executar(DataRow r, Fact ft, DataRow dr)
        {
            dr["ref"] = $"Multa-{ft.Data.Month}/{ft.Data.Year}";
            var perc = GetRowPlano(dtPlano, r["dias"].ToInt());
            dr["descricao"] = $"Multa de {perc}% refente ao mês de:  {ft.Data.Month}";
            dr["Preco"] = (ft.Total * perc / 100).ToRound(2);
            GenBl.TotaisLinhas(dr);
        }

        private decimal GetRowPlano(DataTable dtPlano, int dias)
        {
            decimal ret=0;
            int  max = dtPlano.AsEnumerable().Max(row => row["Dias"]).ToInt();
            int min = dtPlano.AsEnumerable().Min(row => row["Dias"]).ToInt();
            if (dias>=max)
            {
                ret= dtPlano.Select($"Dias={max}")[0]["perc"].ToDecimal();
                return ret;
            }
            if (dias <=min)
            {
                ret= dtPlano.Select($"Dias={min}")[0]["perc"].ToDecimal();
                return ret;
            }
            foreach (var item in dtPlano.AsEnumerable())
            {
                if (item!=null)
                {
                    if (item["dias"].ToInt()>=dias)
                    {
                        ret = item["perc"].ToDecimal();
                        break;                        
                    }
                }
            }
            return ret;
        }
    }
}
