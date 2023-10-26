using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DMZ.UI.TM
{
    public partial class FrmBilhete : FrmClasse 
    {
        public FrmBilhete()
        {
            InitializeComponent();
        }
        private St _st;
        private DataTable dtPrecos;

        private void FrmBilhete_Load(object sender, EventArgs e)
        {
            Campo1 = "Referenc";
            Campo2 = "descricao";
            Ctabela = "st";
            CCondicao = "Bilhete = 1";
        }
        public override void DefaultValues()
        {
            _st = DoAddline<St>();
            _st.Bilhete = true;
            tbReferenc.tb1.Text = "..";
            //if (Pbl.Param.Prodenum)
            //{
            //    var xx = $@"Select Max(convert(int,dbo.UDF_ExtractNumbers(referenc)))+1 as maxvalue  from st";
            //    //$@" select isnull(max(isnull(TRY_PARSE(right(ltrim(rtrim(Referenc)),{Pbl.Param.CodprodMascra.Length - 1})AS INT),0)),0)+1 as maxvalue from st where {CCondicao}";
            //    var dt = SQL.GetGenDT(xx);
            //    if (dt.HasRows())
            //    {
            //        tbReferenc.tb1.Text = Helper.GetValueByMascara(Codigo, Pbl.Param.CodprodMascra, dt);
            //    }
            //}

            status.SetStatusValue();
            var tabiva = SQL.GetGen2DT("select codigo,descricao from Auxiliar where Tabela=5 and Padrao=1 ");
            if (tabiva.HasRows())
            {
                TabIVa.tb1.Text = tabiva.Rows[0]["descricao"].ToString();
                TabIVa.Text2 = tabiva.Rows[0]["codigo"].ToString();
            }
            base.DefaultValues();
        }
        public override bool BeforeSave()
        {
            if (!Procurou)
            {
                var xx = $@"Select Max(convert(int,dbo.UDF_ExtractNumbers(Referenc)))+1 as maxvalue  from st where Bilhete =1";
                var dt = SQL.GetGenDT(xx);
                if (dt.HasRows())
                {
                    tbReferenc.tb1.Text = GetValueByMascara($"{Familia.Text3.Trim()}{subFamilia.tb1.Text.ToCharArray()[0].ToTrim()}", Pbl.Param.CodprodMascra, dt);
                }
            }
            return base.BeforeSave();
        }
        internal string GetValueByMascara(string sigla, string mascara, DataTable dt)
        {
            var refec = "";
            decimal numero = 0;
            if (dt.HasRows())
            {
                numero=dt.Rows[0][0].ToDecimal();
                numero = numero == 0 ? 1 : numero;
            }
            else
            {
                numero= 1;
            }

            if (numero > Pbl.Param.Anolectivo.ToDecimal())
            {
                numero = numero.ToString().Substring(4, Pbl.Param.Mascaracl.Length).ToDecimal();
            }
            switch (numero.ToString().Length)
            {
                case 1:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 1) + numero;
                    break;

                case 2:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 2) + numero;
                    break;
                case 3:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 3) + numero;
                    break;
                case 4:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 4) + numero;
                    break;
                case 5:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 5) + numero;
                    break;
                case 6:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 6) + numero;
                    break;
                case 7:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 7) + numero;
                    break;
                case 8:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 8) + numero;
                    break;
                case 9:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 9) + numero;
                    break;
                case 10:
                    refec = sigla.Trim() + mascara.Substring(0, mascara.Length - 10) + numero;
                    break;
            }
            return refec;
        }
        public override void Save()
        {

            FillEntity(_st);
            var xx = EF.Save(_st);
            if (xx.ret < 0)
            {
                MsBox.Show(xx.msg, ScrollBars.Both);
            }
        }

        public override void PreencheCampos(DataTable dt, int i)
        {
            _st = FillControls(_st, dt, i);
        }
        private void Familia_Load(object sender, EventArgs e)
        {

        }

        private bool gridPanelPreco_BeforeAddLineEvent()
        {
            var qry = $"select Codigo,Descricao,Auxiliarstamp from auxiliar where tabela =101 order by Codigo";
            dtPrecos = SQL.GetGen2DT(qry);
            if (dtPrecos.HasRows())
            {
                var f = new FrmSelect
                {
                    SelectCampos = "",
                    HideFirstColumn = true,
                    Tamanhos = new List<decimal>() {50, 150, 0 },
                    ColFillName = "Descricao",
                    Tabela = "",
                    Condicao = "",
                    SendData = ReceiveInfo,
                    _dt = dtPrecos
                };
                var xx = $"select Codigo,Descricao,Auxiliarstamp from auxiliar where 1=0";
                f._dt2 = SQL.GetGen2DT(xx);
                f.ShowDialog();
            }
            else
            {
                MsBox.Show("Não existe professor indicado para esta disciplina, porfavor consulte o RH");
            }
            return true;
        }

        private void ReceiveInfo(DataTable dt)
        {
            if (dt.HasRows())
            {
                foreach (var row in dt.AsEnumerable())
                {
                    if (row != null)
                    {
                        if (!SQL.CheckExist($"select Ccustamp from StPrecos where Ccustamp='{row["Auxiliarstamp"].ToTrim()}' and ststamp='{CLocalStamp.Trim()}'"))
                        {
                            gridPreco.AddLine();
                            //gridPreco.DataRowr["Ststamp"] = CLocalStamp;
                            gridPreco.DataRowr["CodCCu"] = row["Codigo"];
                            gridPreco.DataRowr["CCusto"] = row["Descricao"];
                            gridPreco.DataRowr["Ccustamp"] = row["Auxiliarstamp"];
                        }
                    }
                }
                gridPreco.Update();
            }
        }
    }
}
