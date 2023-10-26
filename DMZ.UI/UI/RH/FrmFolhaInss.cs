using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.Classes;
using DMZ.UI.Generic;
using DMZ.UI.Reports;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DMZ.UI.UI.RH
{
    public partial class FrmFolhaInss : Basic.FrmClasse2
    {
        private string linha;

        public FrmFolhaInss()
        {
            InitializeComponent();
        }

        private void btnFicheiro_Click(object sender, EventArgs e)
        {
            //"prof",
            var dt =gridProcessdetails.DataSource as DataTable;
            if (dt?.Rows.Count<=0) return;

            dt = dt.DefaultView.ToTable(true,"SegSocial","DiasPrc","BaseVencimento","comissao","TotalAbonus","Incapacidade","data","Obsinss");           
            List<string> lista = new List<string>();
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                linha = "";
                for (int j = 0; j < dt.Columns.Count; j++)
                {                 
                        string cel="".Trim();
                        if (dt.Columns[j].ColumnName.Equals("data"))
                        {
                            var data=Convert.ToDateTime(dt.Rows[i][j]);
                            var dia =data.Day.ToString().Length==1?"0"+data.Day.ToString():data.Day.ToString();
                            var mes2 =data.Month.ToString().Length==1?"0"+data.Month.ToString():data.Month.ToString();
                            cel=$"{dia}{mes2}{data.Year}".Trim();    
                        }
                        else if(dt.Columns[j].ColumnName.Equals("BaseVencimento"))
                        {

                            cel=Montanumero(dt.Rows[i][j].ToDecimal()).Trim();    
                        } 
                        else if(dt.Columns[j].ColumnName.Equals("TotalAbonus"))
                        {
                            cel=Montanumero(dt.Rows[i][j].ToDecimal()).Trim();       
                        }
                         else if(dt.Columns[j].ColumnName.Equals("comissao"))
                        {
                            cel="".Trim();       
                        }
                        else if(dt.Columns[j].ColumnName.Equals("Incapacidade"))
                        {
                            cel="".Trim();       
                        }
                         else
                        {
                            cel=dt.Rows[i][j].ToString().Trim();    
                        }  
                        if (j==0)
                        {
                            linha=cel.Trim();
                        }
                        else
                        {
                            linha=$"{linha.Trim()};{cel.Trim()}";
                        }
                }
                lista.Add(linha.Trim());
            }
            var fileName = "";
            //define o titulo
            saveFileDialog1.Title = "Salvar Arquivo Texto - "+Pbl.Info;
            //Define as extensões permitidas
            saveFileDialog1.Filter = "Text File|.txt";
            //define o indice do filtro
            saveFileDialog1.FilterIndex = 0 ;
            //Atribui um valor vazio ao nome do arquivo
           // saveFileDialog1.FileName = $"INSS{Pbl.Stamp()}";10121850001
           var dt2 =gridProcessdetails.DataSource as DataTable;
            var mes =dt2.Rows[0]["mes"].ToString().Trim();
            if (mes.Length==1)
            {
                mes=$"0{mes}";
            }
            var ano=dt2.Rows[0]["ano"].ToString().Trim();
            var param =mes+ano;
            var CodigoINSS=SQL.GetField("CodigoINSS","empresa");
           saveFileDialog1.FileName = $"{CodigoINSS}{param.Trim()}";
            //Define a extensão padrão como .txt
            saveFileDialog1.DefaultExt = ".txt";
            //define o diretório padrão
            saveFileDialog1.InitialDirectory = @"c:\";
            //restaura o diretorio atual antes de fechar a janela
            saveFileDialog1.RestoreDirectory = true;
            //Abre a caixa de dialogo e determina qual botão foi pressionado
            DialogResult resultado = saveFileDialog1.ShowDialog();
            //Se o ousuário pressionar o botão Salvar
            if (resultado == DialogResult.OK)
            {
                fileName=saveFileDialog1.FileName;
                foreach (var value in lista)
                {
                    File.AppendAllText(fileName, value.Trim() + Environment.NewLine);
                }
                try    
                {
                    if (File.Exists(fileName))
                    {
                        File.Delete(fileName);
                    }
                    File.WriteAllLines(fileName, lista);
                    MsBox.Show("Ficheiro exportado com sucesso!");
                }
                catch (Exception ex)    
                {
                    MsBox.Show(ex.ToString());
                }
            }
        }

        private string Montanumero(decimal v)
        {
            var lista =v.ToString().Split('.');
            var parteinteira=v.ToString();
            var partedecimal="00";
            if (lista.Length>0)
            {
                parteinteira=v.ToString().Split('.')[0];
                if (lista.Length>1)
                {
                    partedecimal=v.ToString().Split('.')[1];
                }            
            }
            return parteinteira+partedecimal;
        }

        public DataTable Dt { get; set; }
        private void btnAddprocess_Click(object sender, EventArgs e)
        {
            var Condicao ="";
            if (!string.IsNullOrEmpty(Mes.tb1.Text))
            {
                Condicao=$"and Proces.mes ='{Mes.tb1.Text.Trim()}'" ;
            }
            var str=$@"select  ROW_NUMBER() OVER(ORDER BY Nome ASC) AS Numero, SegSocial,
                    Nome,Convert(date,prc.data) as data,
                    DiasPrc,BaseVencimento,comissao=0,TotalAbonus,
                    prof=(select prof from pe where pe.no = prc.no),Incapacidade='',Obsinss,prc.mes,prc.ano from prc join 
                    Proces on prc.Processtamp=Proces.Processtamp 
                    where Linhatotal=1 and Proces.Codigo ={tbNumero.Text.ToDecimal()} and prc.ano={numericUpDown1.Value} {Condicao} order by nome ";

            Dt=SQL.GetGen2DT(str);
            gridProcessdetails.DataSource=null;
            gridProcessdetails.AutoGenerateColumns=false;
            gridProcessdetails.DataSource=Dt;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DS ds = new DS();
            var ret = Imprimir.FillData(null, Dt, null, ds.DMZ, null);
            Imprimir.CallForm(ret.dtPrint, ret.fp, CLocalStamp, false, label1.Text, "", "FolhaINSS", "SAL", this,"", true, ds, "", $"FOLHA DE INSS");
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
                public bool Maximizado { get; set; }
        private void Maximizar()
        {
            NSize = Size;
            NLocation = Location;
            if (MdiParent != null)
            {
                var height = MdiParent.Size.Height;
                var width = MdiParent.Size.Width;
                Size = new Size(width - 190, height - 165);
                var x = MdiParent.Location.X;
                var y = MdiParent.Location.Y;
                Location = new Point(x + 175, y + 110);
                Maximizado = true;
                var lista = Application.OpenForms;
                foreach (Form frm in lista)
                {
                    if (frm == null) continue;
                    if (frm.IsMdiContainer)
                    {
                        if (frm is DemoMdi)
                        {
                            if (((DemoMdi) frm).Ocultado)
                            {
                                MoveUp();
                            }
                        }
                        else
                        {
                            MoveUp();
                        }
                    }
                }
            }
            else
            {
                var height = Screen.PrimaryScreen.WorkingArea.Size.Height;
                var width = Screen.PrimaryScreen.WorkingArea.Size.Width;
                Size = new Size(width - 190, height - 165);
                var x = Screen.PrimaryScreen.WorkingArea.Location.X;
                var y = Screen.PrimaryScreen.WorkingArea.Location.Y;
                Location = new Point(x + 175, y + 110);    
            }
        }
        public void MoveUp()
        {
            NSize = Size;
            NLocation = Location;
            var height = MdiParent.Size.Height;
            var width = MdiParent.Size.Width;
            Size = new Size(width - 70, height - 165);
            var x = MdiParent.Location.X;
            var y = MdiParent.Location.Y;
            Location = new Point(48, y + 110);
        }
        public void MoveDow()
        {
            Size = NSize;
            Location = NLocation;
        }
        public void Minimizar()
        {
            Size = NSize;
            Location = NLocation;
            Maximizado = false;
        }
        public Size NSize { get; set; }
        public Point NLocation { get; set; }

        private void FrmFolhaInss_Load(object sender, EventArgs e)
        {
            numericUpDown1.Value = Pbl.SqlDate.Year;
        }
    }
}
