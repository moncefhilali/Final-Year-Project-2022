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
    public partial class CartDetails : UserControl
    {
        public CartDetails()
        {
            InitializeComponent();
        }

        #region Properties

        private int _ID;
        private float _Total;
        private string _Name;
        private string _Picture;



        [Category("Custom Props")]
        public int ID
        {
            get { return _ID; }
            set { _ID = value;}
        }

        [Category("Custom Props")]
        public float Total
        {
            get { return _Total; }
            set { _Total = value; TotalLabel.Text = "$"+value.ToString(); }
        }

        [Category("Custom Props")]
        public string ASM_Name
        {
            get { return _Name; }
            set { _Name = value; NameLabel.Text = value; }
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

        
        private void CartDetails_MouseClick(object sender, MouseEventArgs e)
        {
            InfoClass.SelectedCartID = this.ID;
            InfoClass.SelectedCartName = this.ASM_Name;
            InfoClass.SelectedCartTotal = this.Total;
            if (InfoClass.CheckForm != null)
            {
                InfoClass.CheckForm.Close();
            }
            InfoClass.CheckForm = new PForms.FormCheckout();
            InfoClass.CheckForm.Show();

        }

        private void CartDetails_Load(object sender, EventArgs e)
        {

        }
    }
}
