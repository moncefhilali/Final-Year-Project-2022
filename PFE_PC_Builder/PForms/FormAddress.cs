using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace PFE_PC_Builder.PForms
{
    public partial class FormAddress : Form
    {
        // Rounded Corners :
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        public static extern IntPtr CreateRoundRectRgn(
            int nLeftRect, // x-cordinate of Upper-left corner
            int nTopRect, // y-cordinate of Upper-left corner
            int nRightRect, // x-cordinate of Lower-right corner
            int nBottomRect, // y-cordinate of Lower-right corner
            int nWidthEllipse, // Width of Ellipse
            int nHeightEllipse // Height of Ellipse
            );
        // -------------------------------------------------------------

        public FormAddress()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // Rounded Corners
        }


        private void FormAddress_Load(object sender, EventArgs e)
        {

        }
    }
}
