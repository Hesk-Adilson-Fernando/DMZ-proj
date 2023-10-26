using System;
using System.Drawing;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Generic;

namespace DMZ.UI.UI
{
    public partial class FrmDashboard : FrmClasse2
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        private void FrmDashboard_Load(object sender, EventArgs e)
        {

        }
        private void btnFact_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "-  " + btnFact.Text;
            tbDescricao.tb1.Text = "";
            DashboardVendas();
            tabControl1.SelectTab(tabPageFact);
        }
        private void DashboardVendas()
        {
            // Imagens
            PanelPrdVendas.Pic.BackgroundImage = Properties.Resources.Money_Bag_32px;
            PanelPrdVendas.Pic.Size = new Size(45, 45);
            PanelSrvVendas.Pic.BackgroundImage = Properties.Resources.Money_Bag_32px;
            PanelSrvVendas.Pic.Size = new Size(45, 45);
            PanelPrdQtdVendas.Pic.BackgroundImage = Properties.Resources.Data_Sheet_28px;
            PanelPrdQtdVendas.Pic.Size = new Size(45, 45);
            PanelQtdServVendas.Pic.BackgroundImage = Properties.Resources.Data_Sheet_28px;
            PanelQtdServVendas.Pic.Size = new Size(45, 45);
            tbDescricao.tb1.ReadOnly = true;
            PanelSrvVendas.Visible = true;
            PanelQtdServVendas.Visible = true;

            //Fill the label dashboard with account number
            var tvp = $@"select sum(factl.Totall) as TPrd, count(Factlstamp) as QTPrd from factl where factl.Servico=0 and sigla in ('FT', 'VD')";
            var dttotalp = SQL.GetGen2DT(tvp);
            if (dttotalp?.Rows.Count > 0)
            {
                PanelPrdVendas.label3.Text = "Vendas Produtos";
                PanelPrdQtdVendas.label3.Text = "N° de Produtos";
                PanelPrdVendas.lblNumber.Text = dttotalp.Rows[0]["TPrd"].ToString().SetMask();
                PanelPrdQtdVendas.lblNumber.Text = dttotalp.Rows[0]["QTPrd"].ToString();
            }
            var tvs = $@"	select sum(factl.Totall) as TSrv, count(Factlstamp) as QTSrv from factl where factl.Servico=1 and sigla in ('FT', 'VD')";
            var dttotals = SQL.GetGen2DT(tvs);
            if (dttotals?.Rows.Count > 0)
            {
                PanelSrvVendas.label3.Text = "Vendas Serviços";
                PanelQtdServVendas.label3.Text = "N° de Serviços";
                PanelSrvVendas.lblNumber.Text = dttotals.Rows[0]["TSrv"].ToString().SetMask();
                PanelQtdServVendas.lblNumber.Text = dttotals.Rows[0]["QTSrv"].ToString();
            }
            // produtos e servicos preferidos
            var prdTop = @"select top 5 Factl.descricao, count(Factl.oristamp) as contador
                            from Factl inner join st on st.Ststamp = factl.oristamp
                               where st.servico=0 group by Factl.descricao order by count(2) desc";

            var dtTop = SQL.GetGen2DT(prdTop);
            if (dtTop?.Rows.Count > 0)
            {
                chartPrdPref.Series[0].Points.DataBindXY(dtTop.ToArrayList("descricao"), dtTop.ToArrayList("contador"));
            }
            var ServTop = @"select top 5 Factl.descricao, count(Factl.oristamp) as contador
                            from Factl inner join st on st.Ststamp = factl.oristamp
                               where st.servico=1 group by Factl.descricao order by count(2) desc";

            var dtTopS = SQL.GetGen2DT(ServTop);
            if (dtTopS?.Rows.Count > 0)
            {
                chartServPref.Series[0].Points.DataBindXY(dtTopS.ToArrayList("descricao"), dtTopS.ToArrayList("contador"));
            }
            //------------------------------
            //Vendas por mes
            var vendMes = $@"select case month(data) when 1 then 'Jan.' when 2 then 'Fev.' when 3 then 'Mar.' when 4 then 'Abr.' 
            when 5 then 'Maio' when 6 then 'Jun.' when 7 then 'Jul.' when 8 then 'Ago.' 
			when 9 then 'Set.' when 10 then 'Out.' when 11 then 'Nov.' when 12 then 'Dez.' 
			end as mes, sum(total) as total from fact where sigla in ('FT','VD') group by MONTH (fact.data)";
            var dtvendMes = SQL.GetGen2DT(vendMes);

            if (dtvendMes?.Rows.Count > 0)
            {
                chartVendasMes.Series[0].IsValueShownAsLabel = true;
                chartVendasMes.DataSource = dtvendMes;

                chartVendasMes.Series[0].XValueMember = "mes";
                chartVendasMes.Series[0].YValueMembers = "total";
            }

            //var vendPrdMes = dtvendMes.Select().Where(x=>x.Field<decimal>("mes").Equals(tbDescricao.tb1.Text.ToDecimal())).CopyToDataTable();
            //Vendas por ano
            var vendAno = $@"select year(data) as ano, sum(total) as total from fact where sigla in ('FT','VD') group by year(fact.data) order by ano";
            var dtvendAno = SQL.GetGen2DT(vendAno);

            if (dtvendAno?.Rows.Count > 0)
            {
                chartVendaAno.Series[0].IsValueShownAsLabel = true;
                chartVendaAno.DataSource = dtvendAno;

                chartVendaAno.Series[0].XValueMember = "ano";
                chartVendaAno.Series[0].YValueMembers = "total";
            }
        }


        private void btnGeral_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab(tabPageGeral);
            DashboardCadastro();
        }

        private void btnCompras_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "-  " + btnCompras.Text;
            tbProcuraFnc.tb1.Text = "";
            DashboardCompras();
            tabControl1.SelectTab(tabPageCompras);
            //SetBackColor(Dashboard);
        }
        private void DashboardCompras()
        {
            PanelPrdCompras.Pic.BackgroundImage = Properties.Resources.Facturacao;
            PanelPrdCompras.Pic.Size = new Size(45, 45);
            PanelSrvCompras.Pic.BackgroundImage = Properties.Resources.Facturacao;
            PanelSrvCompras.Pic.Size = new Size(45, 45);
            PanelPrdQtdCompras.Pic.BackgroundImage = Properties.Resources.Data_Sheet_28px;
            PanelPrdQtdCompras.Pic.Size = new Size(45, 45);
            PanelSrvQtdCompras.Pic.BackgroundImage = Properties.Resources.Data_Sheet_28px;
            PanelSrvQtdCompras.Pic.Size = new Size(45, 45);

            tbProcuraFnc.tb1.ReadOnly = true;
            PanelSrvCompras.Visible = true;
            PanelSrvQtdCompras.Visible = true;

            //Total e Quantidade de Produtos comprados
            var tCompras = $@"select sum(faccl.Totall) as total, count(Facclstamp) as quant from faccl where Faccl.Servico=0 and (sigla='FTF')";

            var dttCompras = SQL.GetGen2DT(tCompras);
            if (dttCompras?.Rows.Count > 0)
            {
                PanelPrdCompras.lblNumber.Text = dttCompras.Rows[0]["total"].ToString().SetMask();
                PanelPrdCompras.label3.Text = "Compras de Produtos";
                PanelPrdQtdCompras.lblNumber.Text = dttCompras.Rows[0]["quant"].ToString();
                PanelPrdQtdCompras.label3.Text = "Quantidade";
            }

            //Total e Quantidade de Servicos comprados
            var tsrvCompras = $@"select sum(faccl.Totall) as total, count(Facclstamp) as quant from faccl where Faccl.Servico=1 and (sigla='FTF')";
            var dttsrvCompras = SQL.GetGen2DT(tsrvCompras);
            if (dttsrvCompras?.Rows.Count > 0)
            {
                PanelSrvCompras.lblNumber.Text = dttsrvCompras.Rows[0]["total"].ToString().SetMask();
                PanelSrvCompras.label3.Text = "Compras de Servicos";
                PanelSrvQtdCompras.lblNumber.Text = dttsrvCompras.Rows[0]["quant"].ToString();
                PanelSrvQtdCompras.label3.Text = "Quantidade";
            }

            //Total Compras por mes
            var cm = $@"select case month(data) when 1 then 'Jan.' when 2 then 'Fev.' when 3 then 'Mar.' when 4 then 'Abr.' 
                                    when 5 then 'Maio' when 6 then 'Jun.' when 7 then 'Jul.' when 8 then 'Ago.' 
			                        when 9 then 'Set.' when 10 then 'Out.' when 11 then 'Nov.' when 12 then 'Dez.' end as mes,
                                    sum(Total) as total from facc where sigla='FTF' group by MONTH(facc.data)";
            var dtcm = SQL.GetGen2DT(cm);

            if (dtcm?.Rows.Count > 0)
            {
                chartTComprasMesFnc.Series[0].IsValueShownAsLabel = true;
                chartTComprasMesFnc.DataSource = dtcm;

                chartTComprasMesFnc.Series[0].XValueMember = "mes";
                chartTComprasMesFnc.Series[0].YValueMembers = "total";
            }

            //Total Compras por ano
            var ca = $@"select year(data) as ano, sum(Total) as total from facc where sigla='FTF' group by year(facc.data) order by ano";
            var dtca = SQL.GetGen2DT(ca);

            if (dtca?.Rows.Count > 0)
            {
                chartTComprasAnoFnc.Series[0].IsValueShownAsLabel = true;
                chartTComprasAnoFnc.DataSource = dtca;

                chartTComprasAnoFnc.Series[0].XValueMember = "ano";
                chartTComprasAnoFnc.Series[0].YValueMembers = "total";
            }
            //Top 5 de prd e srv pref
            var prdTop = @"select top 5 faccl.descricao, count(faccl.oristamp) as contador
                                from faccl inner join st on st.Ststamp = faccl.oristamp
                                inner join Facc on Facc.Faccstamp=faccl.Faccstamp
                                where st.servico=0 group by faccl.descricao order by count(2) desc";
            var dtTop = SQL.GetGen2DT(prdTop);
            if (dtTop?.Rows.Count > 0)
            {
                chartPrdPrefFnc.Series[0].Points.DataBindXY(dtTop.ToArrayList("descricao"), dtTop.ToArrayList("contador"));
            }
            //var prdclMes = dtTop.Select().Where(x=>x.Field<decimal>("mes").Equals(tbDescricao.tb1.Text.ToDecimal())).CopyToDataTable();

            var ServTop = @"select top 5 faccl.descricao, count(faccl.oristamp) as contador
                                from faccl inner join st on st.Ststamp = faccl.oristamp
                                inner join Facc on Facc.Faccstamp=faccl.Faccstamp
                                where st.servico=1 group by faccl.descricao order by count(2) desc";
            var dtTopS = SQL.GetGen2DT(ServTop);
            if (dtTopS?.Rows.Count > 0)
            {
                chartSrvPrefFnc.Series[0].Points.DataBindXY(dtTopS.ToArrayList("descricao"), dtTopS.ToArrayList("contador"));
            }
        }

        private void btnTes_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "-  " + btnTes.Text;
            tbProcuraTes.tb1.Text = "";
            DashboardTes();
            tabControl1.SelectTab(tabPageTesouraria);
            //SetBackColor(Dashboard);
        }
        private void DashboardTes()
        {
            PanelTesEntrada.Pic.BackgroundImage = Properties.Resources.Currency_Exchange_32px;
            PanelTesEntrada.Pic.Size = new Size(45, 45);
            PanelTesSaida.Pic.BackgroundImage = Properties.Resources.Currency_Exchange_32px;
            PanelTesSaida.Pic.Size = new Size(45, 45);

            tbProcuraTes.tb1.ReadOnly = true;

            //Entrada
            var entrada = $@"select sum(mvt.Entrada) from mvt";
            PanelTesEntrada.lblNumber.Text = SQL.GetValue(entrada).SetMask();
            PanelTesEntrada.label3.Text = "Entrada";
            //Saida
            var saida = $@"select sum(mvt.saida) from mvt";
            PanelTesSaida.lblNumber.Text = SQL.GetValue(saida).SetMask();
            PanelTesSaida.label3.Text = "Saída";

            //Entrada e saida de valores / mes
            var ESMes = $@"select case month(mvt.Datamov) when 1 then 'Jan.' when 2 then 'Fev.' when 3 then 'Mar.' when 4 then 'Abr.' 
                        when 5 then 'Maio' when 6 then 'Jun.' when 7 then 'Jul.' when 8 then 'Ago.' 
			            when 9 then 'Set.' when 10 then 'Out.' when 11 then 'Nov.' when 12 then 'Dez.' end as mes, count (mvt.Mvtstamp) as contador, sum (Mvt.Entrada) as totale, sum (mvt.Saida) as totals
                        from mvt inner join contas on contas.Codigo=Mvt.Codlocal where contas.Codigo=Mvt.Codlocal group by MONTH (Mvt.Datamov)
                        order by mes";
            var dtMes = SQL.GetGen2DT(ESMes);
            if (dtMes?.Rows.Count > 0)
            {
                chartTesMes.Series[0].IsValueShownAsLabel = true;
                chartTesMes.Series[1].IsValueShownAsLabel = true;
                chartTesMes.DataSource = dtMes;
                chartTesMes.Series[0].XValueMember = "mes";
                chartTesMes.Series[0].YValueMembers = "totale";
                chartTesMes.Series[1].XValueMember = "mes";
                chartTesMes.Series[1].YValueMembers = "totals";
            }
            //Entrada e saida de valores / Ano
            var ESAno = $@"select year(mvt.Datamov) as ano, count (mvt.Mvtstamp) as contador, sum (Mvt.Entrada) as entrada, sum (mvt.Saida) as saida
                        from mvt inner join contas on contas.Codigo=Mvt.Codlocal where contas.Codigo=Mvt.Codlocal group by year (Mvt.Datamov)
                        order by ano";
            var dtAno = SQL.GetGen2DT(ESAno);
            if (dtAno?.Rows.Count > 0)
            {
                chartTesAno.Series[0].IsValueShownAsLabel = true;
                chartTesAno.Series[1].IsValueShownAsLabel = true;
                chartTesAno.DataSource = dtAno;
                chartTesAno.Series[0].XValueMember = "ano";
                chartTesAno.Series[0].YValueMembers = "entrada";
                chartTesAno.Series[1].XValueMember = "ano";
                chartTesAno.Series[1].YValueMembers = "saida";
            }
        }

        private void btnStoc_Click(object sender, EventArgs e)
        {
            lblTitle.Text = "-  " + btnStoc.Text;
            PanelStock.Pic.BackgroundImage = Properties.Resources.Stocks_32px;
            tbProcuraSt.tb1.Text = "";
            gridUiArm.Rows.Clear();
            PanelStock.lblNumber.Text = "";
            chartAnaliseStock.Series.Clear();
            tabControl1.SelectTab(tabPageStock);
        }

        private void tbDescricao_ProcuraTBTextChangedEvent()
        {
            if (tbDescricao.tb1.Text != "")
            {
                if (!cbVerfica.Checked)
                {
                    PanelSrvVendas.Visible = false;
                    PanelQtdServVendas.Visible = false;

                    var tvend = $@"select sum(factl.Totall) as total, count(Factlstamp) as quant  from factl where factl.descricao='{tbDescricao.tb1.Text}' and (sigla='FT' or sigla='VD')";
                    var dt = SQL.GetGen2DT(tvend);
                    if (dt?.Rows.Count > 0)
                    {
                        PanelPrdVendas.label3.Text = "Total Facturado";
                        PanelPrdVendas.lblNumber.Text = dt.Rows[0]["total"].ToString().SetMask();
                        PanelPrdQtdVendas.label3.Text = "Quantidade";
                        PanelPrdQtdVendas.lblNumber.Text = dt.Rows[0]["quant"].ToString();
                    }

                    PanelSrvVendas.lblNumber.Text = "";
                    PanelQtdServVendas.lblNumber.Text = "";

                    // Fact Produto por ano e mes
                    var prdAno = $@"select datepart(yyyy, fact.data) as ano, sum(factl.totall) as total from factl
                                    inner join fact on Factl.Factstamp = Fact.Factstamp where factl.sigla in ('FT', 'VD') and Factl.descricao = '{tbDescricao.tb1.Text}' group by year(fact.data)
                                    order by ano";
                    var dtprdAno = SQL.GetGen2DT(prdAno);
                    if (dtprdAno?.Rows.Count > 0)
                    {
                        chartVendaAno.Series[0].IsValueShownAsLabel = true;
                        chartVendaAno.DataSource = dtprdAno;
                        chartVendaAno.Series[0].XValueMember = "ano";
                        chartVendaAno.Series[0].YValueMembers = "total";
                    }
                    //Fact Produto por mes
                    var prdMes = $@"select case datepart(mm, fact.data) when 1 then 'Jan.' when 2 then 'Fev.' when 3 then 'Mar.' when 4 then 'Abr.' 
                                    when 5 then 'Maio' when 6 then 'Jun.' when 7 then 'Jul.' when 8 then 'Ago.' 
			                        when 9 then 'Set.' when 10 then 'Out.' when 11 then 'Nov.' when 12 then 'Dez.' end as mes,  sum(factl.totall) as total from factl
                                    inner join fact on Factl.Factstamp = Fact.Factstamp where factl.sigla in ('FT', 'VD') and Factl.descricao = '{tbDescricao.tb1.Text}' group by month(fact.data)";
                    var dtprdMes = SQL.GetGen2DT(prdMes);
                    if (dtprdMes?.Rows.Count > 0)
                    {
                        chartVendasMes.Series[0].IsValueShownAsLabel = true;
                        chartVendasMes.DataSource = dtprdMes;
                        chartVendasMes.Series[0].XValueMember = "mes";
                        chartVendasMes.Series[0].YValueMembers = "total";
                    }
                }
                else
                {
                    //Produtos facturados por cliente
                    var tvend = $@"select sum(factl.Totall) as total, count (fact.factstamp) as contador 
                                    from factl inner join fact on Factl.Factstamp=Fact.Factstamp 
                                    where Factl.servico=0 and fact.Nome='{tbDescricao.tb1.Text}' and (factl.sigla='FT' or factl.sigla='VD')";

                    var dt = SQL.GetGen2DT(tvend);
                    if (dt?.Rows.Count > 0)
                    {
                        PanelPrdVendas.label3.Text = "Total Facturado";
                        PanelPrdVendas.lblNumber.Text = dt.Rows[0]["total"].ToString().SetMask();
                        PanelPrdQtdVendas.label3.Text = "Quantidade";
                        PanelPrdQtdVendas.lblNumber.Text = dt.Rows[0]["contador"].ToString();
                    }


                    // servicos facturados por cliente
                    var tsrvvend = $@"select sum(factl.Totall) as total, count (fact.factstamp) as contador  
                                    from factl inner join fact on Factl.Factstamp=Fact.Factstamp 
                                    where Factl.servico=1 and fact.Nome='{tbDescricao.tb1.Text}' and (factl.sigla='FT' or factl.sigla='VD' or factl.sigla='empty')";

                    var dts = SQL.GetGen2DT(tsrvvend);
                    if (dts?.Rows.Count > 0)
                    {
                        PanelSrvVendas.label3.Text = "Total Facturado";
                        PanelSrvVendas.lblNumber.Text = dts.Rows[0]["total"].ToString().SetMask();
                        PanelQtdServVendas.label3.Text = "Quantidade";
                        PanelQtdServVendas.lblNumber.Text = dts.Rows[0]["contador"].ToString();
                    }

                    //top 3 de produtos fav do cliente graficos
                    var top3prd = $@"select top 3 Factl.descricao, count(Factl.oristamp) as contador
                                        from Factl inner join st on st.Ststamp = factl.oristamp
                                        inner join fact on fact.Factstamp=factl.Factstamp
                                        where Factl.servico=0 and fact.Nome='{tbDescricao.tb1.Text}' group by Factl.descricao order by count(2) desc";
                    var dttop3prd = SQL.GetGen2DT(top3prd);
                    if (dttop3prd?.Rows.Count > 0)
                    {
                        chartPrdPref.Titles[0].Text = "Top 3 de Produtos Preferidos";
                        chartPrdPref.Series[0].Points.DataBindXY(dttop3prd.ToArrayList("descricao"), dttop3prd.ToArrayList("contador"));
                    }
                    else
                    {
                        chartPrdPref.Titles[0].Text = "Sem Produtos Preferidos";
                        chartPrdPref.Series[0].Points.Clear();
                    }

                    //top 3 de servicos fav do cliente graficos
                    var top3srv = $@"select top 3 Factl.descricao, count(Factl.oristamp) as contador
                                        from Factl inner join st on st.Ststamp = factl.oristamp
                                        inner join fact on fact.Factstamp=factl.Factstamp
                                        where Factl.servico=1 and fact.Nome='{tbDescricao.tb1.Text}' group by Factl.descricao order by count(2) desc";
                    var dttop3srv = SQL.GetGen2DT(top3srv);
                    if (dttop3srv?.Rows.Count > 0)
                    {
                        chartServPref.Titles[0].Text = "Top 3 de Serviços Preferidos";
                        chartServPref.Series[0].Points.DataBindXY(dttop3srv.ToArrayList("descricao"), dttop3srv.ToArrayList("contador"));
                    }
                    else
                    {
                        chartServPref.Titles[0].Text = "Sem Serviços Preferidos";
                        chartServPref.Series[0].Points.Clear();
                    }
                    //Produtos facturados por mes-ano-cliente
                    var prdclMes = $@"select case datepart(mm, fact.data) when 1 then 'Jan.' when 2 then 'Fev.' when 3 then 'Mar.' when 4 then 'Abr.' 
                                    when 5 then 'Maio' when 6 then 'Jun.' when 7 then 'Jul.' when 8 then 'Ago.' 
			                        when 9 then 'Set.' when 10 then 'Out.' when 11 then 'Nov.' when 12 then 'Dez.' end as mes, sum(factl.totall) as total
                                     ,datepart (yyyy,fact.data) as ano  from factl inner join fact on Factl.Factstamp = Fact.Factstamp where factl.sigla in ('FT','VD') and Fact.nome = '{tbDescricao.tb1.Text}' group by year (fact.data), MONTH(fact.data) order by ano";
                    var dtprdclmes = SQL.GetGen2DT(prdclMes);
                    if (dtprdclmes?.Rows.Count > 0)
                    {
                        chartVendasMes.Series[0].IsValueShownAsLabel = true;
                        chartVendasMes.DataSource = dtprdclmes;
                        chartVendasMes.Series[0].XValueMember = "mes";
                        chartVendasMes.Series[0].YValueMembers = "total";

                        chartVendaAno.Series[0].IsValueShownAsLabel = true;
                        chartVendaAno.DataSource = dtprdclmes;
                        chartVendaAno.Series[0].XValueMember = "ano";
                        chartVendaAno.Series[0].YValueMembers = "total";
                    }
                    // var prdclMes = dtprdclmes.Select().Where(x=>x.Field<decimal>("mes").Equals(tbDescricao.tb1.Text.ToDecimal())).CopyToDataTable();
                }
            }
        }

        private void cbVerfica_CheckedChanged(object sender, EventArgs e)
        {
            if (cbVerfica.Checked)
            {
                PanelSrvVendas.Visible = true;
                PanelQtdServVendas.Visible = true;
                tbDescricao.SqlComandText = $@"select fact.no,fact.nome from fact 
                                            inner join factl on Factl.Factstamp=Fact.Factstamp 
                                            group by fact.nome,fact.no";
            }
            else
            {
                tbDescricao.SqlComandText = $@"select ref, descricao from factl group by Factl.descricao,factl.ref";
            }
        }

        private void cbFnc_CheckedChanged(object sender, EventArgs e)
        {
            if (cbFnc.Checked)
            {
                tbProcuraFnc.SqlComandText = $@"select facc.no,facc.nome from facc 
                                            inner join faccl on faccl.faccstamp=facc.Faccstamp group by facc.no,facc.nome";
            }
            else
            {
                tbProcuraFnc.SqlComandText = $@"select ref, descricao from faccl group by Faccl.descricao,faccl.ref";
            }
        }

        private void tbProcuraFnc_ProcuraTBTextChangedEvent()
        {
            if (tbProcuraFnc.tb1.Text != "")
            {
                if (!cbFnc.Checked)
                {
                    //Fill the label dashboard
                    var tcp = $@"select sum(faccl.Totall) as total, sum(Quant) as quant from faccl where faccl.descricao='{tbProcuraFnc.tb1.Text}' and (sigla='FTF')";
                    var dttcp = SQL.GetGen2DT(tcp);
                    if (dttcp?.Rows.Count > 0)
                    {
                        PanelPrdCompras.lblNumber.Text = dttcp.Rows[0]["total"].ToString().SetMask();
                        PanelPrdCompras.label3.Text = "Total Compra";
                        PanelPrdQtdCompras.lblNumber.Text = dttcp.Rows[0]["quant"].ToString();
                        PanelPrdQtdCompras.label3.Text = "Quantidade";
                    }

                    PanelSrvCompras.Visible = false;
                    PanelSrvQtdCompras.Visible = false;

                    PanelSrvQtdCompras.lblNumber.Text = "";
                    PanelSrvQtdCompras.lblNumber.Text = "";

                    //Produtos facturados por mes-prd
                    var prdPrdMes = $@"select case datepart(mm, facc.data) when 1 then 'Jan.' when 2 then 'Fev.' when 3 then 'Mar.' when 4 then 'Abr.' 
                                    when 5 then 'Maio' when 6 then 'Jun.' when 7 then 'Jul.' when 8 then 'Ago.' 
			                        when 9 then 'Set.' when 10 then 'Out.' when 11 then 'Nov.' when 12 then 'Dez.' end as mes, sum(faccl.totall) as total
                                        ,datepart(yyyy, facc.data) as ano from faccl inner join facc on facc.Faccstamp = Faccl.Faccstamp 
                                        inner  join st on st.Ststamp=Faccl.Oristamp where Faccl.Descricao = '{tbProcuraFnc.tb1.Text}' group by year(facc.data), month(facc.data)
                                        order by ano";
                    var dtprdPrdmes = SQL.GetGen2DT(prdPrdMes);
                    if (dtprdPrdmes?.Rows.Count > 0)
                    {
                        chartTComprasMesFnc.Series[0].IsValueShownAsLabel = true;
                        chartTComprasMesFnc.DataSource = dtprdPrdmes;
                        chartTComprasMesFnc.Series[0].XValueMember = "mes";
                        chartTComprasMesFnc.Series[0].YValueMembers = "total";

                        chartTComprasAnoFnc.Series[0].IsValueShownAsLabel = true;
                        chartTComprasAnoFnc.DataSource = dtprdPrdmes;
                        chartTComprasAnoFnc.Series[0].XValueMember = "ano";
                        chartTComprasAnoFnc.Series[0].YValueMembers = "total";
                    }
                }
                else
                {
                    PanelSrvCompras.Visible = true;
                    PanelSrvQtdCompras.Visible = true;
                    //Total compras prd-fnc
                    var tCfnc = $@"select sum(faccl.Totall) as total, sum(faccl.Quant) as quant  
                                    from faccl inner join facc on Facc.Faccstamp=faccl.Faccstamp
                                    where facc.nome='{tbProcuraFnc.tb1.Text}' and Faccl.Servico=0 and (faccl.sigla='FTF')";

                    var dt = SQL.GetGen2DT(tCfnc);
                    if (dt?.Rows.Count > 0)
                    {
                        PanelPrdCompras.label3.Text = "Compras-Produtos";
                        PanelPrdCompras.lblNumber.Text = dt.Rows[0]["total"].ToString().SetMask();
                        PanelPrdQtdCompras.label3.Text = "Quantidade";
                        PanelPrdQtdCompras.lblNumber.Text = dt.Rows[0]["quant"].ToString();
                    }

                    //Total compras srv-fnc
                    var tCfncSrv = $@"select sum(faccl.Totall) as total, sum(faccl.Quant) as quant 
                                    from faccl inner join facc on Facc.Faccstamp=faccl.Faccstamp
                                    where facc.nome='{tbProcuraFnc.tb1.Text}' and Faccl.Servico=1 and (faccl.sigla='FTF')";

                    var dts = SQL.GetGen2DT(tCfncSrv);
                    if (dts?.Rows.Count > 0)
                    {
                        PanelSrvCompras.label3.Text = "Compras-Servicos";
                        PanelSrvCompras.lblNumber.Text = dts.Rows[0]["total"].ToString().SetMask();
                        PanelSrvQtdCompras.label3.Text = "Quantidade";
                        PanelSrvQtdCompras.lblNumber.Text = dts.Rows[0]["quant"].ToString();
                    }

                    //top 3 de produtos fav do fnc graficos
                    var top3prd = $@"select top 3 faccl.descricao, count(faccl.oristamp) as contador
                                    from faccl inner join st on st.Ststamp = faccl.oristamp
                                    inner join Facc on facc.Faccstamp=faccl.Faccstamp
                                    where faccl.servico=0 and facc.Nome='{tbProcuraFnc.tb1.Text}' group by faccl.descricao order by count(2) desc";
                    var dttop3prd = SQL.GetGen2DT(top3prd);
                    if (dttop3prd?.Rows.Count > 0)
                    {
                        chartPrdPrefFnc.Titles[0].Text = "Top 3 de Produtos Preferidos";
                        chartPrdPrefFnc.Series[0].Points.DataBindXY(dttop3prd.ToArrayList("descricao"), dttop3prd.ToArrayList("contador"));
                    }
                    else
                    {
                        chartPrdPrefFnc.Titles[0].Text = "Sem Produtos Preferidos";
                        chartPrdPrefFnc.Series[0].Points.Clear();
                    }
                    //top 3 de servicos fav do fnc graficos
                    var top3srv = $@"select top 3 faccl.descricao, count(faccl.oristamp) as contador
                                    from faccl inner join st on st.Ststamp = faccl.oristamp
                                    inner join Facc on facc.Faccstamp=faccl.Faccstamp
                                    where faccl.servico=1 and facc.Nome='{tbProcuraFnc.tb1.Text}' group by faccl.descricao order by count(2) desc";
                    var dttop3srv = SQL.GetGen2DT(top3srv);
                    if (dttop3srv?.Rows.Count > 0)
                    {
                        chartSrvPrefFnc.Titles[0].Text = "Top 3 de Produtos Preferidos";
                        chartSrvPrefFnc.Series[0].Points.DataBindXY(dttop3srv.ToArrayList("descricao"), dttop3srv.ToArrayList("contador"));
                    }
                    else
                    {
                        chartSrvPrefFnc.Titles[0].Text = "Sem Produtos Preferidos";
                        chartSrvPrefFnc.Series[0].Points.Clear();
                    }
                    //Produtos facturados por mes-ano-fnc
                    var prdfncMes = $@"select case datepart(mm, facc.data) when 1 then 'Jan.' when 2 then 'Fev.' when 3 then 'Mar.' when 4 then 'Abr.' 
                                    when 5 then 'Maio' when 6 then 'Jun.' when 7 then 'Jul.' when 8 then 'Ago.' 
			                        when 9 then 'Set.' when 10 then 'Out.' when 11 then 'Nov.' when 12 then 'Dez.' end as mes, datepart(yyyy, facc.data) as ano, sum(faccl.totall) as total 
                                        from faccl inner join facc on facc.Faccstamp = Faccl.Faccstamp where Facc.nome = '{tbProcuraFnc.tb1.Text}' group by year(facc.data), month(facc.data)
                                        order by ano";
                    var dtprdfncmes = SQL.GetGen2DT(prdfncMes);
                    if (dtprdfncmes?.Rows.Count > 0)
                    {
                        chartTComprasMesFnc.Series[0].IsValueShownAsLabel = true;
                        chartTComprasMesFnc.DataSource = dtprdfncmes;
                        chartTComprasMesFnc.Series[0].XValueMember = "mes";
                        chartTComprasMesFnc.Series[0].YValueMembers = "total";
                        chartTComprasAnoFnc.DataSource = dtprdfncmes;
                        chartTComprasAnoFnc.Series[0].IsValueShownAsLabel = true;
                        chartTComprasAnoFnc.Series[0].XValueMember = "ano";
                        chartTComprasAnoFnc.Series[0].YValueMembers = "total";
                    }
                }
            }
        }
        private void tbProcuraTes_ProcuraTBTextChangedEvent()
        {
            if (tbProcuraTes.tb1.Text != "")
            {
                gridUiSaida.Rows.Clear();
                gridUiEntrance.Rows.Clear();
                //Fill the label dashboard with account number
                var te = $@"select sum(entrada) as entrada, sum(saida) as saida from mvt 
                            inner join contas on mvt.Codlocal=contas.Codigo 
                            where contas.Numero='{tbProcuraTes.Text2}' group by contas.Numero, contas.Descricao";
                var dtcontas = SQL.GetGen2DT(te);
                if (dtcontas?.Rows.Count > 0)
                {
                    PanelTesSaida.lblNumber.Text = dtcontas.Rows[0]["saida"].ToString().SetMask();
                    PanelTesSaida.label3.Text = "Saida";
                    PanelTesEntrada.lblNumber.Text = dtcontas.Rows[0]["entrada"].ToString().SetMask();
                    PanelTesEntrada.label3.Text = "Entrada";
                }


                //Entrada e saida de valores / mes
                var ESMes = $@"select case month(mvt.Datamov) when 1 then 'Jan.' when 2 then 'Fev.' when 3 then 'Mar.' when 4 then 'Abr.' 
                                when 5 then 'Maio' when 6 then 'Jun.' when 7 then 'Jul.' when 8 then 'Ago.' 
			                    when 9 then 'Set.' when 10 then 'Out.' when 11 then 'Nov.' when 12 then 'Dez.' end as mes, count (mvt.Mvtstamp) as contador, sum (Mvt.Entrada) as entrada, sum (mvt.Saida) as saida
                                from mvt inner join contas on contas.Codigo=Mvt.Codlocal where contas.Codigo=Mvt.Codlocal and contas.numero='{tbProcuraTes.Text2}' group by MONTH (Mvt.Datamov)
                                order by mes";
                var dtMes = SQL.GetGen2DT(ESMes);
                if (dtMes?.Rows.Count > 0)
                {
                    chartTesMes.Series[0].IsValueShownAsLabel = true;
                    chartTesMes.Series[1].IsValueShownAsLabel = true;
                    chartTesMes.DataSource = dtMes;
                    chartTesMes.Series[0].XValueMember = "mes";
                    chartTesMes.Series[0].YValueMembers = "entrada";
                    chartTesMes.Series[1].XValueMember = "mes";
                    chartTesMes.Series[1].YValueMembers = "saida";
                }
                //Entrada e saida de valores / Ano
                var ESAno = $@"select year(mvt.Datamov) as ano, count (mvt.Mvtstamp) as contador, sum (Mvt.Entrada) as entrada, sum (mvt.Saida) as saida
                                from mvt inner join contas on contas.Codigo=Mvt.Codlocal where contas.Codigo=Mvt.Codlocal and contas.numero='{tbProcuraTes.Text2}' group by year(Mvt.Datamov)
                                order by ano";
                var dtAno = SQL.GetGen2DT(ESAno);
                if (dtAno?.Rows.Count > 0)
                {
                    chartTesAno.Series[0].IsValueShownAsLabel = true;
                    chartTesAno.Series[1].IsValueShownAsLabel = true;
                    chartTesAno.DataSource = dtAno;
                    chartTesAno.Series[0].XValueMember = "ano";
                    chartTesAno.Series[0].YValueMembers = "entrada";
                    chartTesAno.Series[1].XValueMember = "ano";
                    chartTesAno.Series[1].YValueMembers = "saida";
                }
            }
        }
        private void DashboardCadastro()
        {
            //Set imagens 
            PanelCl.Pic.BackgroundImage = Properties.Resources.Member_321px;
            PanelCl.Pic.Size = new Size(45, 45);
            PanelPrd.Pic.BackgroundImage = Properties.Resources.Trolley_32px;
            PanelPrd.Pic.Size = new Size(45, 45);
            PanelFnc.Pic.BackgroundImage = Properties.Resources.Customer_321px;
            PanelFnc.Pic.Size = new Size(45, 45);
            PanelSrv.Pic.BackgroundImage = Properties.Resources.Maintenance_321px;
            PanelSrv.Pic.Size = new Size(45, 45);
            PanelCat.Pic.BackgroundImage = Properties.Resources.Control_Panel_32px;
            PanelCat.Pic.Size = new Size(45, 45);
            PanelSubCat.Pic.BackgroundImage = Properties.Resources.Control_Panel_32px;
            PanelSubCat.Pic.Size = new Size(45, 45);

            lblTitle.Text = @"- " + btnGeral.Text;
            tbProcuraSt.tb1.Enabled = false;
            PanelStock.lblNumber.Text = "";
            PanelStock.label3.Text = "Stock";

            var prdCat = @"select st.Familia, count (st.Codfam) as contador from st as st group by st.Familia order by count (2) desc";
            var dtprdCat = SQL.GetGen2DT(prdCat);
            if (dtprdCat?.Rows.Count > 0)
            {
                chartProdutoCat.Series[0].IsValueShownAsLabel = true;
                chartProdutoCat.DataSource = dtprdCat;
                chartProdutoCat.Series[0].XValueMember = "familia";
                chartProdutoCat.Series[0].YValueMembers = "contador";
            }

            var cl = @"select count(clstamp) as QTCl from cl";
            PanelCl.lblNumber.Text = SQL.GetValue(cl);
            PanelCl.label3.Text = "Clientes";

            var fnc = @"select count(Fncstamp) as QTRcl from fnc";
            PanelFnc.lblNumber.Text = SQL.GetValue(fnc);
            PanelFnc.label3.Text = "Fornecedores";

            var prd = @"select count(ststamp) as QTProd from st where servico=0";
            PanelPrd.lblNumber.Text = SQL.GetValue(prd);
            PanelPrd.label3.Text = "Produto";

            //var dt = SQL.GetGen2DT(prd);
            //var prdd = dt.Select().Where(x=>x.Field<decimal>("QTPrd").Equals(tbDescricao.tb1.Text.ToDecimal())).CopyToDataTable();

            var serv = @"select count(ststamp) as QTPServ from st where servico=1";
            PanelSrv.lblNumber.Text = SQL.GetValue(serv);
            PanelSrv.label3.Text = "Serviços";

            var fam = @"select count (pestamp) from pe";
            PanelCat.lblNumber.Text = SQL.GetValue(fam);
            PanelCat.label3.Text = "Pessoal";

            var subfam = @"select count(ststamp) from st where viatura=1";
            PanelSubCat.lblNumber.Text = SQL.GetValue(subfam);
            PanelSubCat.label3.Text = "Viaturas";
        }
        private void tbProcuraSt_ProcuraTBTextChangedEvent()
        {
            //if (gridUiArm.CurrentRow == null) return;
            if (tbProcuraSt.tb1.Text != "")
            {
                var gridArm = $@"select starm.Descricao,starm.Stock from Starm inner join st on st.Ststamp = Starm.Ststamp
                                where st.Descricao='{tbProcuraSt.tb1.Text}'
                                group by starm.Descricao, starm.Stock
                                order by count(2) desc ";
                var dtArm = SQL.GetGen2DT(gridArm);
                if (dtArm?.Rows.Count > 0)
                {
                    for (var i = 0; i < dtArm.Rows.Count; i++)
                    {
                        gridUiArm.Rows.Add(dtArm.Rows[i]["descricao"].ToString(), dtArm.Rows[i]["stock"].ToString());
                    }
                    //chartAnaliseStock.DataSource = dtArm;
                    //chartAnaliseStock.Series[0].Points.DataBindXY(dtArm.ToArrayList("descricao"), dtArm.ToArrayList("stock"));
                    //chartAnaliseStock.Series[0].XValueMember = "descricao";
                    //chartAnaliseStock.Series[0].YValueMembers = "stock";
                    var qtStock = $@"select Stock from st where Descricao='{tbProcuraSt.tb1.Text}'";
                    PanelStock.label3.Text = "Stock";
                    PanelStock.lblNumber.Text = SQL.GetValue(qtStock);
                }
                else
                {
                    MsBox.Show("Não tem armazém definido para este produto!..");
                    gridUiArm.Rows.Clear();
                    PanelStock.lblNumber.Text = "";
                }
            }
            else
            {
                gridUiArm.Rows.Clear();
            }
        }

        private void tabPageGeral_Click(object sender, EventArgs e)
        {

        }
    }
}
