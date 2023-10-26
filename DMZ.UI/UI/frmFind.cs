using System;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using DMZ.BL.Classes;
using DMZ.UI.Basic;
using DMZ.UI.UC;

namespace DMZ.UI.UI
{
    public partial class frmFind : FrmClasse2
    {
        int rowindex = 0;
        internal string campo1;
        internal CampoBusca.CampoAutoSizeMode campo1AutoSizeMode;
        internal string campo1Desc;
        internal int campo1Width;
        internal string campo2;
        internal CampoBusca.CampoAutoSizeMode campo2AutoSizeMode;
        internal string campo2Desc;
        internal string campo2Update;
        internal bool campo2Visible;
        internal int campo2Width;
        internal string campo3;
        internal CampoBusca.CampoAutoSizeMode campo3AutoSizeMode;
        internal string campo3Desc;
        internal string campo3Update;
        internal bool campo3Visible;
        internal int campo3Width;
        internal string campo4;
        internal CampoBusca.CampoAutoSizeMode campo4AutoSizeMode;
        internal string campo4Desc;
        internal string campo4Update;
        internal bool campo4Visible;
        internal int campo4Width;
        internal string camposOrderby;
        internal string condicao;
        public string Tabela { get; internal set; }
        public string Selecionado = string.Empty;
        public string formToCall { get; set; } = string.Empty;
        private DataTable dtBusca;

        public frmFind()
        {
            InitializeComponent();
        }

        public Action<object> PControl { get; internal set; }

        private void frmFind_Load(object sender, EventArgs e)
        {
            FormarGrid();
            Localizar();
            btnCriar.Visible = !string.IsNullOrEmpty(formToCall);
        }

        private void FormarGrid()
        {
            int pos = 0;
            string[] camposSelect = new string[4];
            string[] captions = new string[4];
            bool[] visibilidades = new bool[4];
            int[] tamanhos = new int[4];
            CampoBusca.CampoAutoSizeMode[] AutoSizeMode = new CampoBusca.CampoAutoSizeMode[4];


            if (!string.IsNullOrWhiteSpace(campo1))
            {
                camposSelect[pos] = campo1.Trim();
                captions[pos] = campo1Desc;
                visibilidades[pos] = true;
                tamanhos[pos] = campo1Width;
                AutoSizeMode[pos] = campo1AutoSizeMode;
                pos++;
            }

            if (!string.IsNullOrWhiteSpace(campo2))
            {
                camposSelect[pos] = campo2.Trim();
                captions[pos] = campo2Desc != null ? campo2Desc.Trim() : "";
                visibilidades[pos] = campo2Visible;
                tamanhos[pos] = campo2Width;
                AutoSizeMode[pos] = campo2AutoSizeMode;
                pos++;
            }

            if (!string.IsNullOrWhiteSpace(campo3))
            {
                camposSelect[pos] = campo3.Trim();
                captions[pos] = campo3Desc != null ? campo3Desc.Trim() : "";
                visibilidades[pos] = campo3Visible;
                tamanhos[pos] = campo3Width;
                AutoSizeMode[pos] = campo3AutoSizeMode;
                pos++;
            }

            if (!string.IsNullOrWhiteSpace(campo4))
            {
                camposSelect[pos] = campo4.Trim();
                visibilidades[pos] = campo4Visible;
                captions[pos] = campo4Desc != null ? campo4Desc.Trim() : "";
                tamanhos[pos] = campo4Width;
                AutoSizeMode[pos] = campo4AutoSizeMode;
            }

            Selecionado = string.Join(",", camposSelect.Where(s => !string.IsNullOrEmpty(s)));

            string[] camposSelectLimpo = Selecionado.Split(new[] { "," }, StringSplitOptions.None);

            dgvProc.ColumnCount = camposSelectLimpo.Length; //Cria colunas de campos nao vazios


            for (int i = 0; i < camposSelect.Length; i++)
            {
                #region Defenindo Tipo de Preenchimento de Coluna
                var colAutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;

                switch (AutoSizeMode[i])
                {
                    case CampoBusca.CampoAutoSizeMode.Nenhuma:
                        colAutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet;
                        break;
                    case CampoBusca.CampoAutoSizeMode.CabeçalhoDaColuna:
                        colAutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                        break;
                    case CampoBusca.CampoAutoSizeMode.CélulasExibidas:
                        colAutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        break;
                    case CampoBusca.CampoAutoSizeMode.Completar:
                        colAutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        break;

                }
                #endregion

                if (!string.IsNullOrWhiteSpace(camposSelect[i]))
                {
                    dgvProc.Columns[i].DataPropertyName = camposSelect[i].Trim();
                    dgvProc.Columns[i].HeaderText = captions[i].Trim();
                    dgvProc.Columns[i].Visible = visibilidades[i];
                    dgvProc.Columns[i].Width = tamanhos[i];
                    dgvProc.Columns[i].AutoSizeMode = colAutoSizeMode;


                }
            }

            if (dgvProc.ColumnCount == 1)
                dgvProc.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;


        }

        private void Localizar()
        {
            if (!string.IsNullOrWhiteSpace(condicao))
                condicao = $" and {condicao}";

            string orderby = string.Empty;

            if (!string.IsNullOrWhiteSpace(camposOrderby))
                orderby = " order by " + camposOrderby;
           
            dtBusca = SQL.GetGen2DT($"select {Selecionado} from {Tabela} where {campo1} like '{txtFind.Text}%' {condicao}{orderby}");
            dgvProc.AutoGenerateColumns = false;
            dgvProc.DataSource = null;
            dgvProc.DataSource = dtBusca;
        }

        private void Selecionar(DataRow dr)
        {

            PControl?.Invoke(dr);
            //LimpaVariaveis();
            Close();
        }
        public static void OpenForm(string formName, string condicao)
        {
            var _formName = (from t in Assembly.GetExecutingAssembly().GetTypes()
                             where t.Name.Equals(formName)
                             select t.FullName).Single();
            var _form = (FrmClasse)Activator.CreateInstance(Type.GetType(_formName));

            //_form.MultiDoc = condicao;
            if (_form != null)
                _form.ShowDialog();
            else
                MessageBox.Show("Formulário não definido!");
        }

        private void txtFind_TextChanged(object sender, EventArgs e)
        {
            Localizar();
        }

        private void dgvProc_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                rowindex = e.RowIndex;

            }
            catch (Exception ex)
            {

            }
        }

        private void dgvProc_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecionar(dtBusca.Rows[e.RowIndex]);
        }

        private void dgvProc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                int index = dgvProc.CurrentCell.RowIndex;
                Selecionar(dtBusca.Rows[index]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Selecionar(dtBusca.Rows[rowindex]);
        }
    }
}
