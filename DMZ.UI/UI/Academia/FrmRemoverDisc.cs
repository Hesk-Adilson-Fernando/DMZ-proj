using DMZ.BL.Classes;
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
    public partial class FrmRemoverDisc : FrmClasse2
    {
        public bool OrigemDc { get; internal set; }

        public FrmRemoverDisc()
        {
            InitializeComponent();
        }

        private void FrmRemoverDisc_Load(object sender, EventArgs e)
        {

        }
        private void btnProcurar_Click(object sender, EventArgs e)
        {
            var quer = $@"SELECT 
    Turmastamp,AlunoNome,Alunostamp,Cursostamp,Turmastamp,Anosem,Coddis,activo, Turma=(select t.Codigo from Turma  t where t.Turmastamp=Turmanota.Turmastamp),
	 Sems=(select t.Descanoaem from Turma  t where t.Turmastamp=Turmanota.Turmastamp),
	 Nivel=(select c.Nivel from Turma t inner join Curso c on 
t.Cursostamp=c.Cursostamp  where t.Turmastamp=Turmanota.Turmastamp),
    convert(decimal, COUNT(*)) NurmeroRepeticoes
FROM Turmanota  
GROUP BY

    Turmastamp,AlunoNome,Alunostamp,Cursostamp,Anosem,Coddis,activo
 HAVING 
    COUNT(*) > 1;";
            var dt = SQL.GetGen2DT(quer);
            tbTotal.Text="0";
            try
            {
                if (dt.HasRows())
                {
                    tbTotal.Text=dt.Sum("NurmeroRepeticoes").ToDecimal().ToString();
                }
            }
            catch (Exception ex)
            {
//
            }
            gridUiAlunos.SetDataSource(dt);
        }

        private void btnRemoveFact_Click(object sender, EventArgs e)
        {
            var dt = gridUiAlunos.GetBindedTable();
            if (dt.HasRows())
            {
                try
                {
                    foreach (DataRow item in dt.Rows)
                    {

                        try
                        {
                            var cursostamp = item["cursostamp"].ToString();
                            var Turmastamp = item["Turmastamp"].ToString();
                            var Alunostamp = item["Alunostamp"].ToString();
                            var Anosem = item["Anosem"].ToString();
                            var Coddis = item["Coddis"].ToString();
                            var activo = item["activo"].ToInt();

                            var quer1 = $@"select Turmanotastamp from  Turmanota where
  Turmastamp ='{Turmastamp}' and 
  Cursostamp='{cursostamp}' and Anosem='{Anosem}' 
  and Coddis='{Coddis} ' and activo={activo}
  and Alunostamp='{Alunostamp}'";
                            var dt2 = SQL.GetGen2DT(quer1);
                            if (dt2.HasRows())
                            {
                                foreach (DataRow item2 in dt2.Rows)
                                {
                                    try
                                    {
                                        var Turmanotastamp = item2["Turmanotastamp"].ToString();
                                        var quer = $@"delete  Turmanota where Turmastamp ='{Turmastamp}' 
and  Cursostamp='{cursostamp}' and Anosem='{Anosem}'  and Coddis='{Coddis}' and activo=0 
and Alunostamp='{Alunostamp}'  and Turmanotastamp ='{Turmanotastamp}'";
                                        SQL.SqlCmd(quer);
                                    }
                                    catch (Exception ex)
                                    {
                                        continue;
                                    }
                                }
                            }
                            else
                            {
                                continue;
                            }
                        }
                        catch (Exception ex)
                        {
                            continue;
                        }

                    }
                    MsBox.Show($"{Messagem.ParteInicial()}Todas linhas duplicadas foram removidas do sistema.");
                    btnProcurar_Click(sender, e);
                }
                catch (Exception ex)
                {

                    //throw;
                }
            }
            else
            {

                MsBox.Show($"{Messagem.ParteInicial()}Todas linhas duplicadas ja foram removidas do sistema.");
            }
        }
    }
}
