using DMZ.BL.Classes;
using DMZ.DAL.Migrations;
using DMZ.Model.Model;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Extensions;
using DMZ.UI.Generic;
using iTextSharp.text.pdf.codec.wmf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Interop;

namespace DMZ.UI.UI.Academia
{
    public partial class FrmDiarioc : Basic.FrmClasse
    {
        public FrmDiarioc()
        {
            InitializeComponent();
        }
        public bool OrigemDc { get; set; } = false;
        private void FrmDiarioc_Load(object sender, EventArgs e)
        {
            Campo1 = "Codigo";
            Campo2 = "Descricao";
            Ctabela = "Dclasse";
        }
        private Dclasse dclasse;
        private DataTable dt;


        public override void DefaultValues()
        {
            dclasse = DoAddline<Dclasse>();
            base.DefaultValues();
        }
        public override void Save()
        {
            FillEntity(dclasse);
            EF.Save(dclasse);

            // Helper.DoProgressProcess(tabnova, RecebeDados);
        }
        public override void PreencheCampos(DataTable dt, int i)
        {
            Actigovalor=string.Empty;
            dclasse = FillControls(dclasse, dt, i);
            if (dclasse.Fechado)
            {
                Actigovalor="true";
            }
            else
            {

                Actigovalor="false";
            }
        }

        private void gridUiDisciplinas_EditingControlShowing(object sender, System.Windows.Forms.DataGridViewEditingControlShowingEventArgs e)
        {
            //if (gridUiDisciplinas.CurrentRow == null) return;
            //if (!tbAnosem.tb1.Text.IsNullOrEmpty())
            //{
            //    var qry = $"select Turmastamp,Codigo,Cursostamp,Descurso from Turma where Descanoaem='{tbAnosem.tb1.Text.Trim()}'";
            //    var name = gridUiDisciplinas.CurrentCell.OwningColumn.Name;
            //    if (name.Equals("Turma"))
            //    {
            //        dt=Helper.SetBinds(e.Control, "Codigo", qry);
            //    }
            //}
            //else
            //{
            //    MsBox.Show("Deve indicar o anosem");
            //}
        }


        private void gridUiDisciplinas_CellEndEdit(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            var name = gridUiDisciplinas.CurrentCell.OwningColumn.Name;
            if (!name.Equals("Turma")) return;
            if (!(dt?.Rows.Count > 0)) return;
            if (gridUiDisciplinas.CurrentCell.Value == null) return;
            var valor = gridUiDisciplinas.CurrentCell.Value;
            var dr = dt.AsEnumerable().FirstOrDefault(x =>
                x.Field<string>("Codigo").Trim().Equals(valor.ToString().Trim()));
            if (dr == null) return;
            gridUiDisciplinas.CurrentRow.Cells["Turmastamp"].Value = dr["Turmastamp"].ToString();
            gridUiDisciplinas.CurrentRow.Cells["Curso"].Value = dr["Descurso"].ToString();
            gridUiDisciplinas.CurrentRow.Cells["Cursostamp"].Value = dr["Cursostamp"].ToString();
        }

        private void gridUiDisciplinas_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            var nome = gridUiDisciplinas.CurrentCell.OwningColumn.Name.ToLower().Trim();
            var Turmastamp = gridUiDisciplinas.CurrentRow.Cells["Turmastamp"].Value.ToString().Trim();
            if (nome.Equals("origem"))
            {
                var w = new FrmTurma();
                w.ShowForm(this);
                var tab = SQL.GetGen2DT($"select * from turma where Turmastamp='{Turmastamp}'");
                w.PreencheCampos(tab, 0);
                w.Procurou = true;
            }
        }
       

        private DataTable dtProf;
        private bool gridPanel22_BeforeAddLineEvent()
        {

            if (tbAnosem.tb1.Text.IsNullOrEmpty())
            {
                MsBox.Show("Deve indicar o anosem");
                return false;
            }
            var gddd = "";
            if (gridUiDisciplinas.GetBindedTable().HasRows())
            {
                string[] strSummCities = gridUiDisciplinas.GetBindedTable().AsEnumerable().
                    Select(s => s.Field<string>("Turmastamp")).ToArray();
                for (int i = 0; i < strSummCities.Length; i++)
                {
                    if (strSummCities[i].IsNullOrEmpty() || gddd.Contains(strSummCities[i]))
                    {
                        continue;
                    }
                    if (i == 0)
                    {
                        gddd = $"'{strSummCities[i]}'";
                    }
                    else
                    {
                        gddd += $",'{strSummCities[i]}'";
                    }
                }
            }

            if (!gddd.IsNullOrEmpty())
            {
                gddd = $" and tr.Turmastamp not in ({gddd})";
            }
            var qry = $@"select distinct tr.Turmastamp,codigo from turma tr inner join turmal tl on tr.Turmastamp=tl.Turmastamp
where Activo=0 and AnoSemstamp='{tbAnosem.Text2.Trim()}' {gddd}";
            dtProf = SQL.GetGen2DT(qry);
            if (dtProf.HasRows())
            {
                var f = new FrmSelect
                {
                    SelectCampos = "",
                    HideFirstColumn = true,
                    Tamanhos = new List<decimal> { 0, 150 },
                    ColFillName = "codigo",
                    Tabela = "",
                    Condicao = "",
                    SendData = ReceiveInfo,
                    _dt = dtProf
                };
                qry = $@"select codigo,Turmastamp from Turma
 where 1=0";
                f._dt2 = SQL.GetGen2DT(qry);
                f.ShowDialog();
            }
            else
            {
                MsBox.Show("Não existe turmas para o curso especificado");
            }
            return true;
        }
        private void ReceiveInfo(DataTable dt)
        {
            if (dt.HasRows())
            {
                foreach (var dr in dt.AsEnumerable())
                {
                    if (!dr.DataRowIsNull())
                    {
                        gridUiDisciplinas.AddLine();
                        var trrm = SQL.GetRowToEnt<Turma>($"turmastamp='{dr["turmastamp"].ToTrim()}'");
                        if (trrm != null)
                        {
                            gridUiDisciplinas.DataRowr["Turma"] = trrm.Descricao;
                            gridUiDisciplinas.DataRowr["turmastamp"] = trrm.Turmastamp;
                            gridUiDisciplinas.DataRowr["Cursostamp"] = trrm.Cursostamp;
                            gridUiDisciplinas.DataRowr["Curso"] = trrm.Descurso;
                        }
                    }
                }
                gridUiDisciplinas.Update();
            }
        }
        string Actigovalor=string.Empty;

        bool Gravar()
        {
            var msg = "";
            if (cbDefault1.cb1.Checked)
            {
                msg="Tem a certeza que deseja fechar o " +
                    "diario do Classe?";
                estado=1;
            }
            else
            {
                msg="Tem a certeza que deseja reabrir o " +
                                    "diario do Classe?";
                estado=0;
            }
            var motiv = tbMotivo.tb1.Text;
            var dres = MsBox.Show(msg, DResult.YesNo);
            if (dres.DialogResult != System.Windows.Forms.DialogResult.Yes) return false;
            var f = new FrmEditRlt
            {
                SendInfo = Receive2,
                tbQuerry =
                        {
                            Text =motiv
                        }
            };
            f.ShowForm(this, true);
            tbMotivo.tb1.Text=f.tbQuerry.Text;
            Motivo=f.tbQuerry.Text;
            if (Convert.ToBoolean(estado))
            {
                if (Motivo.IsNullOrEmpty())
                {
                    MsBox.Show($"{Messagem.ParteInicial()}preenche o motivo de fecho do diário.");
                    return false;
                }
                sit = "Inactivo";
            }
            else
            {
                sit = "Activo";
            }
            return true;
        }
        int estado = 0; string sit = string.Empty;
        private void cbDefault1_CheckedChangeds()
        {
          
        }
        public override void AfterSave()
        {

            if (Procurou)
            {
                if (!Actigovalor.IsNullOrEmpty())
                {
                    if (Actigovalor.ToBool()!=cbDefault1.cb1.Checked)
                    {

                        var tab = gridUiDisciplinas.GetBindedTable();
                        if (tab.HasRows())
                        {
                            DtTurmanota = SQL.Initialize("Turmanota");
                            Helper.DoProgressProcess(tab, RecebeDados);
                        }

                    }
                }
            }
            base.AfterSave();
        }
        public override bool BeforeSave()
        {
            if (Procurou)
            {
                if (!OrigemDc)
                {
                    var check = SQL.CheckExist($"select Dclassestamp from dclasse where Dclassestamp='{dclasse.Dclassestamp}' and Fechado=1");
                    if (check)
                    {
                        MsBox.Show($"{Messagem.ParteInicial()} Não se altera um diário totalmente fechado.");
                        return false;
                    }
                }
                if (!Actigovalor.IsNullOrEmpty())
                {
                    if (Actigovalor.ToBool()!=cbDefault1.cb1.Checked)
                    {

                        return Gravar();

                    }
                }
            }

            return base.BeforeSave();
        }
        string Motivo = string.Empty;

        public DataTable DtTurmanota { get; internal set; }
        private void RecebeDados(DataRow r, bool fim)
        {
            var rw = DtTurmanota.NewRow().Inicialize();
            rw["Turmastamp"] = r["turmastamp"];
            DtTurmanota.Rows.Add(rw);
            if (fim)
            {
                if (DtTurmanota.HasRows())
                {
                    foreach (DataRow item in DtTurmanota.Rows)
                    {
                        var activo = estado;
                       // SQL.SqlCmd($"update Turmal set activo={activo},motivo='{Motivo}' where turmastamp='{item["turmastamp"].ToString().Trim()}'");

                        SQL.SqlCmd($"update Turmanota set fecho={activo},motivo='{Motivo}' where turmastamp='{item["turmastamp"].ToString().Trim()}'");

                    }

                }


                //MsBox.Show("Processo terminado com sucesso");
            }
        }
        void Receive2(string str)
        {
            Motivo = str;
        }
    }
}
