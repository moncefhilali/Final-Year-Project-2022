using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE_PC_Builder.PUserControls
{
    public partial class OrderDetails : UserControl
    {
        #region Properties

        private int _ORD_ID;
        private string _ASM_Name;
        private string _BSAS;
        private float _ORD_Total;
        private string _CreatedAt;
        private string _ASM_Image;




        [Category("Custom Props")]
        public int ORD_ID
        {
            get { return _ORD_ID; }
            set { _ORD_ID = value; OrderIDLabel.Text = value.ToString(); }
        }

        [Category("Custom Props")]
        public string BSAS
        {
            get { return _BSAS; }
            set { _BSAS = value; BSASLabel.Text = value; }
        }

        [Category("Custom Props")]
        public string CreatedAt
        {
            get { return _CreatedAt; }
            set { _CreatedAt = value; CreatedAtLabel.Text = DateTime.Parse(value).ToShortDateString(); }
        }

        [Category("Custom Props")]
        public float ORD_Total
        {
            get { return _ORD_Total; }
            set { _ORD_Total = value; ORD_TotalLabel.Text = "$ " + value.ToString(); }
        }

        [Category("Custom Props")]
        public string ASM_Name
        {
            get { return _ASM_Name; }
            set { _ASM_Name = value; ASM_NameLabel.Text = value; }
        }

        [Category("Custom Props")]
        public string ASM_Image
        {
            get { return _ASM_Image; }
            set
            {
                _ASM_Image = value;
                try { ASM_ImagePB.Load(@"Images\Components" + value); }
                catch { ASM_ImagePB.Load(@"Images\vide.png"); }

            }
        }

        #endregion

        public OrderDetails()
        {
            InitializeComponent();
        }

        private void OrderDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
