using DMZ.BL.Classes;
using DMZ.Model.Model;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;

namespace DMZ.UI.UI.RH
{
    public partial class FrmPlanoFerias :Basic.FrmClasse
    {
        public FrmPlanoFerias()
        {
            InitializeComponent();
        }
        public PlanoFeria planoFeria;

        public DataTable QryPe { get; private set; }

        private void FrmPlanoFerias_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "descricao";
            Ctabela = "PlanoFeria";
        }
        public override void DefaultValues()
        {
            planoFeria = DoAddline<PlanoFeria>();
            dmzNumero1.nud1.Value = Pbl.SqlDate.Year;
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(planoFeria);
            EF.Save(planoFeria);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            planoFeria = FillControls(planoFeria, dt, i);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (EditMode)
            {
                var condicao = "";
                if (!string.IsNullOrEmpty(tbdepartamento.tb1.Text))
                {
                    condicao = $" Depart ='{tbdepartamento.tb1.Text.Trim()}'";
                }

                if (!string.IsNullOrEmpty(tbSituacao.tb1.Text))
                {
                    condicao = BuilcCondicao(tbSituacao.tb1.Text, condicao, "Situacao");
                }
                if (!string.IsNullOrEmpty(tbCCusto.tb1.Text))
                {
                    condicao = BuilcCondicao(tbCCusto.tb1.Text, condicao, "ccusto");
                }
                if (!string.IsNullOrEmpty(condicao))
                {
                    condicao = $" where  {condicao} ";
                }
                var qry = $"Select Status=Cast( 0 as bit),nome,pestamp,Dataadm from pe {condicao}  order by no,nome";
                QryPe = SQL.GetGen2DT(qry);
                if (QryPe.HasRows())
                {
                    Helper.DoProgressProcess(QryPe, RecebeDados, "nome", "Processando ");
                }
            }
        }

        private void RecebeDados(DataRow pe, bool fim)
        {

            if (pe != null)
            {
                var datacontrato = pe["Dataadm"].ToDateTimeValue();
                var dias = datacontrato.TotalDays(new DateTime(dmzNumero1.nud1.Value.ToInt(), 12, 31)).ToDecimal();
                if (dias > 365)
                {
                    gridPanel25.btnNovo.Invokex(x => x.PerformClick());
                    if (dias>365 && dias< 365*2)
                    {
                        GridProcess.DataRowr["Diaslei"] = 12;
                    }
                    if (dias >= 365 * 2 && dias < 365 * 3)
                    {
                        GridProcess.DataRowr["Diaslei"] = 24;
                    }
                    else
                    {
                        GridProcess.DataRowr["Diaslei"] = 30;
                    }
                    GridProcess.DataRowr["nome"] = pe["nome"];
                    GridProcess.DataRowr["pestamp"] = pe["pestamp"];
                    GridProcess.DataRowr["datain"] = new DateTime(dmzNumero1.nud1.Value.ToInt(), 1, 1);
                    GridProcess.DataRowr["datater"] = new DateTime(dmzNumero1.nud1.Value.ToInt(), 1, 31);
                    GridProcess.DataRowr["Anoref"] = dmzNumero1.nud1.Value.ToInt();                   
                }
            }
            if (fim)
            {
                GridProcess.Invokex(x => x.Update());
            }
        }

        private string BuilcCondicao(string tb1Text, string condicao, string campo)
        {
            return string.IsNullOrEmpty(condicao) ? $" {campo} = '{tb1Text.Trim()}'" : $" {condicao} and {campo} = '{tb1Text.Trim()}'";
        }

        private void GridProcess_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            var nome = GridProcess.CurrentCell.OwningColumn.Name.Trim();
            if (nome.Equals("Datain") || nome.Equals("Datater"))
            {
                Helper.AddDateTimePicker(GridProcess, e);
            }
        }

        private void GridProcess_CellValidated(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {

            var nome = GridProcess.CurrentCell.OwningColumn.Name.ToLower().Trim();
            if (nome.Equals("datain") || nome.Equals("datater"))
            {
                var dinicio = GridProcess.CurrentRow.Cells["Datain"].Value.ToDateTimeValue();
                var dtermino = GridProcess.CurrentRow.Cells["Datater"].Value.ToDateTimeValue();
                //var dias = dinicio.TotalDays(dtermino).ToDecimal();
                //Diasuteis
                var saldodias = GridProcess.CurrentRow.Cells["Saldoferia"].Value.ToDecimal();
                var Dias = GetDias(dinicio, dtermino, cbDefault2.cb1.Checked);
                GridProcess.CurrentRow.Cells["Diasnaouteis"].Value = Dias.dinut;
                GridProcess.CurrentRow.Cells["Diasuteis"].Value = Dias.duteis;
                GridProcess.CurrentRow.Cells["Totaldiaferias"].Value = Dias.duteis + saldodias;
            }
        }

        private (decimal duteis, decimal dinut) GetDias(DateTime dinicio, DateTime dter, bool IncluiDiasInuteis=false)
        {
            (decimal duteis, decimal dinut) ret =(0,0);
            int year = dinicio.Year;
            int month = dinicio.Month;
            var dateTimes = Enumerable.Range(1, DateTime.DaysInMonth(year, month)).Select(day => new DateTime(year, month, day)).ToList();
            if (month !=dter.Month)
            {
                dateTimes.AddRange(Enumerable.Range(1, DateTime.DaysInMonth(dter.Year, dter.Month)).Select(day => new DateTime(dter.Year, dter.Month, day)).ToList());
            }           
            if (IncluiDiasInuteis)
            {
                foreach (DateTime data in dateTimes)
                {
                    if (data !=null)
                    {
                        if (data.Day >= dinicio.Day)
                        {
                            ret.duteis++;
                        }
                    }
                }
            }
            else
            {
                foreach (DateTime data in dateTimes)
                {
                    if (data != null)
                    {
                        if (data.DayOfWeek != DayOfWeek.Sunday && data.DayOfWeek != DayOfWeek.Saturday)
                        {
                            if (month != dter.Month)
                            {
                                if (data.Day >= dinicio.Day && data.Month == month)
                                {
                                    var d = SQL.GetGen2DT($"select data from Feriado where day(data)={data.Day} and month(data)={data.Month} and nacional =1");
                                    if (!d.HasRows())
                                    {
                                        ret.duteis++;
                                    }
                                }
                                else if (data.Day >= dter.Day && data.Month == dter.Month)
                                {
                                    var d = SQL.GetGen2DT($"select data from Feriado where day(data)={data.Day} and month(data)={data.Month} and nacional =1");
                                    if (!d.HasRows())
                                    {
                                        ret.duteis++;
                                    }
                                }
                            }
                            else
                            {
                                if (data.Day >= dinicio.Day && data.Day<=dter.Day)
                                {
                                    var d = SQL.GetGen2DT($"select data from Feriado where day(data)={data.Day} and month(data)={data.Month} and nacional =1");
                                    if (!d.HasRows())
                                    {
                                        ret.duteis++;
                                    }
                                }
                            }
                        }
                        else
                        {
                            if (month != dter.Month)
                            {
                                if (data.Day >= dinicio.Day && data.Month == month)
                                {
                                    if (data.DayOfWeek == DayOfWeek.Sunday || data.DayOfWeek == DayOfWeek.Saturday)
                                    {
                                        ret.dinut++;
                                    }
                                }
                                else if (data.Day >= dter.Day && data.Month == dter.Month)
                                {
                                    if (data.DayOfWeek == DayOfWeek.Sunday || data.DayOfWeek == DayOfWeek.Saturday)
                                    {
                                        ret.dinut++;
                                    }
                                }
                            }
                            else
                            {
                                if (data.Day >= dinicio.Day && data.Day <= dter.Day)
                                {
                                    if (data.DayOfWeek == DayOfWeek.Sunday || data.DayOfWeek == DayOfWeek.Saturday)
                                    {
                                        ret.dinut++;
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return ret;
        }
    }
}
