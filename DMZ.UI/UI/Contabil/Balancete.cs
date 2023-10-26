using System;
using System.Data;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using DMZ.UI.Reports;

namespace DMZ.UI.UI.Contabil
{
    public partial class Balancete : FrmClasse2
    {
        public Balancete()
        {
            InitializeComponent();
        }
        #region Propriedades ...........
        public decimal Codmes1 { get; set; }
        public decimal Codmes2 { get; set; }
        private DataTable DtBalanc { get; set; }
        public static decimal AnoContabil { get;  set; }
        private string filtro;
        private string exclusao = "";
        #endregion

        private void Processar()
        {
            var condicao = "";
            filtro = "";
            exclusao = "";
            if (cbApuraIva.cb1.Checked)
            {
                exclusao = exclusao.IsNullOrEmpty() ? "and Apuraiva=0" : $"{exclusao} and Apuraiva=0";
            }
            if (ApuraRes.cb1.Checked)
            {
                exclusao = exclusao.IsNullOrEmpty() ? "and Apurares=0" : $"{exclusao} and Apurares=0";
            }
            if (DtBalanc.HasRows())
            {
                DtBalanc.Rows.Clear();
            }
            if (Entrecontas.cb1.Checked)
            {
                condicao = $" and conta>='{ContaInicio.Value}' and conta <='{ContaFim.Value}'";
                filtro = filtro.IsNullOrEmpty() ? $"Conta Início: {ContaInicio.Value} - Conta Fim: {ContaFim.Value}" : $"{filtro}\r\n Conta Início: {ContaInicio.Value} - Conta Fim: {ContaFim.Value}";
            }
            filtro = filtro.IsNullOrEmpty() ? $"Mes Início: {mesInicio.Value} - Mes Fim: {mesFim.Value}" : $"{filtro}\r\n Mes Início: {mesInicio.Value} - Mes Fim: {mesFim.Value}";
            filtro = $"{filtro}\r\nANO: {nrAno.Value}";
            var pgc = SQL.GetGen2DT($"select conta,descricao,integracao from pgc where ano =(select ano from param) {condicao} order by conta ");
           if (pgc.HasRows())
           {
               Helper.DoProgressProcess(pgc, RecebeDados, "descricao", "Calculando");
           }
           decimal totalscre = 0;
           decimal totalsdeb = 0;
            foreach (DataRow row in DtBalanc.AsEnumerable())
            {
                if (row["conta"].ToString().Length == 2 &&
                    !row["descricao"].ToString().ToLower().Equals("totais...")) 
                {
                    totalsdeb += row["sdeb"].ToDecimal();
                    totalscre += row["scre"].ToDecimal();
                }
                if (row["descricao"].ToString().ToLower().Equals("totais..."))
                {
                    if (totalscre.ToDecimal() < 0)
                    {
                        row["scre"] = -1 * totalscre.ToDecimal();
                    }
                    if (totalscre.ToDecimal() >= 0)
                    {
                        row["scre"] = totalscre.ToDecimal();
                    }
                    if (totalsdeb.ToDecimal() < 0)
                    {
                        row["sdeb"] = -1 * totalsdeb.ToDecimal();
                    }
                    if (totalsdeb.ToDecimal() >= 0)
                    {
                        row["sdeb"] = totalsdeb.ToDecimal();
                    }
                }
            }
            gridContas.SetDataSource(DtBalanc);
        }

        private void RecebeDados(DataRow r, bool fim)
        {
            if (r != null)
            {
                string condconta;
                if (!r["integracao"].ToBool())
                {
                    condconta = $" ltrim(rtrim(conta)) ='{r["conta"].ToTrim()}' ";
                }
                else
                {
                    condconta= $" conta like('{r["conta"].ToTrim()}%') ";
                }
                var tab = SQL.GetGen2DT($"select isnull(sum(Deb),0) as deb, Isnull(sum(cre),0) as cre from ml where {condconta} and mes between {mesInicio.Value} and {mesFim.Value} and ano =(select ano from param) {exclusao}");
                if (tab.HasRows())
                {
                    if (ContasMov.cb1.Checked)
                    {
                        if (tab.RowZero("deb").ToDecimal() + tab.RowZero("cre").ToDecimal() > 0)
                        {
                            AddLinha(r, tab);
                        }
                    }
                    else
                    {
                        AddLinha(r, tab);
                    }
                }
            }
            if (fim)
            {
                DtBalanc.AddRow(DtBalanc.NewRow().Inicialize());
                var dr = DtBalanc.NewRow().Inicialize();
                decimal debteste = 0;
                decimal credteste = 0;
                foreach (DataRow row in DtBalanc.AsEnumerable())
                {
                    if (row["conta"].ToString().Length == 2)
                    {
                        debteste += row["deb"].ToDecimal();
                        credteste += row["cre"].ToDecimal();
                    }
                }
                dr["conta"] = "";
                dr["descricao"] = "TOTAIS...";
                var deb = debteste;
                dr["deb"] = deb;
               var cre = credteste;
                dr["cre"] = cre;
                var saldo = deb - cre;
                if (saldo != 0)
                {
                    dr["sdeb"] = saldo > 0 ? -1 * saldo : 0;
                    dr["scre"] = saldo > 0 ? 0 : saldo;
                }
                else
                {
                    dr["sdeb"] = 0;
                    dr["scre"] = 0;
                }
                foreach (DataRow row in DtBalanc.AsEnumerable())
                {
                    if (row["deb"].ToDecimal() > row["cre"].ToDecimal())
                    {
                        if (row["cre"].ToDecimal() > 0)
                        {
                            row["scre"] = 0;
                            row["sdeb"] = row["deb"].ToDecimal() - row["cre"].ToDecimal();
                        }
                        if (row["cre"].ToDecimal() == 0)
                        {

                            row["scre"] = row["cre"].ToDecimal();
                            row["sdeb"] = row["deb"];
                        }
                        if (row["cre"].ToDecimal() < 0)
                        {

                            row["scre"] = 0;// -1 * row["cre"].ToDecimal();
                            row["sdeb"] = row["deb"].ToDecimal() + row["cre"].ToDecimal();
                        }
                    }
                    if (row["deb"].ToDecimal() < row["cre"].ToDecimal())
                    {
                        if (row["deb"].ToDecimal() > 0)
                        {

                            row["sdeb"] = 0;//row["deb"].ToDecimal();
                            row["scre"] = row["cre"].ToDecimal() - row["deb"].ToDecimal();
                        }
                        if (row["deb"].ToDecimal() == 0)
                        {
                            row["sdeb"] = row["deb"].ToDecimal();
                            row["scre"] = row["cre"];
                        }
                        if (row["deb"].ToDecimal() < 0)
                        {

                            row["sdeb"] = 0;// -1 * row["deb"].ToDecimal();
                            row["scre"] = row["cre"].ToDecimal() + row["deb"].ToDecimal();
                        }
                    }
                    if (row["deb"].ToDecimal() == row["cre"].ToDecimal())
                    {
                        if (row["deb"].ToDecimal() > 0)
                        {
                            row["scre"] = row["cre"].ToDecimal() - row["deb"].ToDecimal();
                            row["sdeb"] = row["deb"].ToDecimal() - row["cre"].ToDecimal();
                        }
                    }
                    if (!row["descricao"].ToString().ToLower().Equals("totais..."))
                    {
                        continue;
                    }
                    if (row["scre"].ToDecimal() < 0)
                    {
                        row["scre"] = -1 * row["scre"].ToDecimal();
                    }
                    if (row["sdeb"].ToDecimal() < 0)
                    {
                        row["sdeb"] = -1 * row["sdeb"].ToDecimal();
                    }
                }
                DtBalanc.AddRow(dr);
                gridContas.SetDataSource(DtBalanc);
            }
        }

        private void AddLinha(DataRow r, DataTable tab)
        {
            if (tbDoisDigitos.cb1.Checked)
            {
                if (r["conta"].ToString().Length==2)// && r["integracao"].ToBool() )
                { 
                    Linha(r,tab);
                }
            }
            else
            {

                Linha(r, tab);
                //if (r["integracao"].ToBool())
                //{
                //    Linha(r, tab);
                //}
            }
        }

        private void Linha(DataRow r, DataTable tab)
        {
            var dr = DtBalanc.NewRow().Inicialize();
            dr["conta"] = r["conta"];
            dr["descricao"] = r["descricao"];
            dr["deb"] = tab.RowZero("deb");
            dr["cre"] = tab.RowZero("cre");
            dr["integracao"] = r["integracao"];
            var saldo = tab.RowZero("deb").ToDecimal() - tab.RowZero("cre").ToDecimal();
            if (saldo != 0)
            {
                var ss= saldo > 0 ? 0 : -1 * saldo;
                if (saldo > 0)
                {
                    ss= tab.RowZero("deb").ToDecimal();
                    var sscred = tab.RowZero("cre").ToDecimal();
                }
                else
                {
                    ss = -1 * saldo;
                }
                dr["sdeb"] = saldo > 0 ? 0 : -1*saldo;
                dr["scre"] = saldo > 0 ? saldo : 0;
            }
            else
            {
                dr["sdeb"] = 0;
                dr["scre"] = 0;
            }
            DtBalanc.AddRow(dr);
        }

        private void Balancete_Load(object sender, EventArgs e)
        {
            AnoContabil = Pbl.AnoContabil();
            nrAno.Value=AnoContabil;
            mesInicio.Value=1;
            mesFim.Value=12;
            ContasMov.Update(true);
            rbSsaldosAc.Update(true);
            EditMode = true;
            DtBalanc = new DataTable();//ordem
            DtBalanc.Columns.Add(new DataColumn("ordem", typeof(decimal)));
            DtBalanc.Columns.Add(new DataColumn("conta",typeof(string)));
            DtBalanc.Columns.Add(new DataColumn("descricao",typeof(string)));
            DtBalanc.Columns.Add(new DataColumn("cre",typeof(decimal)));
            DtBalanc.Columns.Add(new DataColumn("deb",typeof(decimal)));
            DtBalanc.Columns.Add(new DataColumn("debAcum", typeof(decimal)));
            DtBalanc.Columns.Add(new DataColumn("creAcum", typeof(decimal)));
            DtBalanc.Columns.Add(new DataColumn("scre",typeof(decimal)));
            DtBalanc.Columns.Add(new DataColumn("sdeb",typeof(decimal)));
            DtBalanc.Columns.Add(new DataColumn("integracao", typeof(bool)));
        }
        private void rbSsaldosAc_CheckedChangeds() => SaldAcumPer.Update(false);
        private void rbSaldAcumPer_CheckedChangeds() => rbSsaldosAc.Update(false);

        private void btnProcessar_Click(object sender, EventArgs e)
        {
            Processar();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (DtBalanc.HasRows())
            {
                //var p = new FrmReport
                //{
                //    Printstamp ="", 
                //    Origem = "CT", 
                //    ReportName = !SaldAcumPer.cb1.Checked?"Balancete_ps":"Balancete_pa",
                //    Dt=DtBalanc,
                //    Filtro=filtro,
                //    CTituloRelatorio= $@"BALANCETE ANALÍTICO: {AnoContabil}",
                //};
                //p.ShowForm(this);
                DS ds = new DS();
                var ret = Imprimir.FillData(null, DtBalanc, null, ds.DMZ, null);
                Imprimir.CallForm(ret.dtPrint, ret.fp, "", false, label1.Text, "", !SaldAcumPer.cb1.Checked ? "Balancete_ps" : "Balancete_pa", "CT", this, "", true, ds, filtro, $@"BALANCETE ANALÍTICO: {AnoContabil}");
            }
            else
            {
                MsBox.Show(Messagem.ParteInicial()+"A sua pesquisa não tem informação a visualizar...!");
            }
        }

        private void ContasMov_CheckedChangeds()
        {

        }

        private void btnMaxMin_Click(object sender, EventArgs e)
        {
            if (!Maximizado)
            {
                Maximizar();
            }
            else
            {
                Minimizar();
            }
        }

        private void cbDefault1_Load(object sender, EventArgs e)
        {

        }
    }
}
