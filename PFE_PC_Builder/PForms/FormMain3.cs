using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PFE_PC_Builder.Forms
{
    public partial class FormMain3 : Form
    {
        public FormMain3()
        {
            InitializeComponent();
        }

        private void roundLabel1_Click(object sender, EventArgs e)
        {

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            //
            roundLabel1.cornerRadius = 30;
            roundLabel1.borderColor = Color.FromArgb(111, 95, 190);
            roundLabel1.backColor = Color.Transparent;
            //
            Font fnt = new Font(label4.Font, FontStyle.Strikeout);
            label4.Font = fnt;
            //
            pictureBox1.Load(@"Images\HOME_3.PNG");
            //
        }

        static int i = 1;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {

        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
