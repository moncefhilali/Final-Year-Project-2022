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
    public partial class ComponentDetails : UserControl
    {
        public ComponentDetails()
        {
            InitializeComponent();
        }

        #region Properties

        private int _ID;
        private float _Price;
        private string _Option1;
        private string _Option2;
        private string _Picture;
        private int _Qty;


        [Category("Custom Props")]
        public int Qty
        {
            get { return _Qty; }
            set { _Qty = value; }
        }

        [Category("Custom Props")]
        public int ID
        {
            get { return _ID; }
            set { _ID = value;}
        }

        [Category("Custom Props")]
        public float Price
        {
            get { return _Price; }
            set { _Price = value; PriceLabel.Text = "$"+value.ToString(); }
        }

        [Category("Custom Props")]
        public string Option1
        {
            get { return _Option1; }
            set { _Option1 = value; Option1Label.Text = value; }
        }

        [Category("Custom Props")]
        public string Option2
        {
            get { return _Option2; }
            set { _Option2 = value; Option2Label.Text = value; }
        }

        [Category("Custom Props")]
        public string Picture
        {
            get { return _Picture; }
            set
            {
                _Picture = value;
                try { ItemPicture.Load(@"Images\Components" + value); }
                catch { ItemPicture.Load(@"Images\vide.png"); }

            }
        }

        #endregion


        private void ComponentDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void ComponentDetails_MouseClick(object sender, MouseEventArgs e)
        {
            InfoClass.SelectedControlID = this.ID;
            InfoClass.SelectedControlOption1 = this.Option1;
            InfoClass.SelectedControlOption2 = this.Option2;
            InfoClass.SelectedControlPrice = this.Price;
            InfoClass.SelectedControlImage = this.Picture;
            InfoClass.ControlClicked = true;
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ComponentDetails_Click(object sender, EventArgs e)
        {

        }
    }
}
