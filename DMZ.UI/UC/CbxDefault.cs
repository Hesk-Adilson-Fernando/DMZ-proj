using System;
using System.Windows.Forms;
using Size = System.Drawing.Size;

namespace ANEA.WF.Controls
{
    public partial class CbxDefault : UserControl
    {
       // [LookupBindingProperties("DataSource", "DisplayMember", "ValueMember", "LookupMember")]

        public CbxDefault()
        {
            InitializeComponent();
            Load += MyCombobox_Load;
            cb1.SelectedIndexChanged += cmbState_SelectedIndexChanged;
        }
        #region Public Member
        public string SlectedText
        {
            get { return cb1.Text; }

        }
        //public string Selectedvalue
        //{
        //    get { return comboBox1.SelectedValue.ToString(); }
        //    set { Selectedvalue=value; }
        //}

        /// <summary>
        /// Here i have to declare event.Like Normal combobox selected indexChanged event.
        /// you can use this event whenever you have to require some action/operation on selected index 
        /// changed of combobox.you have to fired this event and perform some action
        /// </summary>
        public event EventHandler SelectedIdexChanged;
        #endregion

        /// <summary>
        /// MyCombobox is a constructor.
        /// Inside constructor fire the load event of this usercontrol.
        /// </summary>
        /// <summary>
        /// Combobox Selected indexChanged event of Combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbState_SelectedIndexChanged(object sender, EventArgs e) => SelectedIdexChanged?.Invoke(sender, e);

        #region User Control Event

        private void MyCombobox_Load(object sender, EventArgs e) => BindComboBox();

        #endregion

        /// <summary>
        /// This method bind combobox with specified data.
        /// </summary>
        private void BindComboBox()
        {
            //var qry = $"select {Qcampos} from {Tabela} ";
            //var dt = ExecCmds.GetGenDT(qry);
            //cb1.DataSource = dt;
            //cb1.DisplayMember = DisplayMember.Trim();
            //cb1.ValueMember = ValueMember.Trim();
        }

        public string CbText
        {
            get { return label1.Text; }
            set
            {
                label1.Text = value;
            }
        }

        public Size CbSize
        {
            get { return cb1.Size; }
            set
            {
                cb1.Size = value;
               // Size = value + Convert.ToInt32(10);
            }
        }
        public Size CntSize
        {
            get { return Size; }
            set
            {
                Size = value ;
            }
        }

        public string DisplayMember { get;  set; }
        public string ValueMember { get;  set; }
        public string Qcampos { get; set; }
        public string Tabela { get;  set; }

        private void CbxDefault_Load(object sender, EventArgs e)
        {

        }
    }
}
