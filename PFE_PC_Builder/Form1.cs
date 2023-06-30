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
using System.Drawing.Drawing2D;
using System.Data.SqlClient;



namespace PFE_PC_Builder
{
    public partial class Form1 : Form
    {

        //
        // SQL Injection (Connection):
        public static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-I3D0A3M;Initial Catalog=PFE2022_PCBUILDER;Integrated Security=True;");
        //
        public static Forms.FormBuild BuildForm;
        public static Forms.FormMain HomeForm;
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
        private Form activeForm;
        private void OpenChildForm(Form childForm)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelCenter.Controls.Add(childForm);
            this.panelCenter.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        // -------------------------------------------------------------

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // Rounded Corners

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // rounded CustomerLabel properties
            CustomerFName.Text = InfoClass.CurrentCustomerFName;
            CustomerFName.cornerRadius = 40;
            CustomerFName.borderColor = Color.White;
            CustomerFName.backColor = Color.Transparent;
            // Home Form on default
            OpenChildForm(new Forms.FormMain());
            radioButton1.Checked = true;

        }

        private void label5_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.ForeColor = Color.FromArgb(95, 96, 115);
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            label3.ForeColor = Color.White;
        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            label2.ForeColor = Color.White;
        }

        private void label2_MouseLeave(object sender, EventArgs e)
        {
            label2.ForeColor = Color.FromArgb(95, 96, 115);
        }

        private void roundLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMain());
        }

        static int ri=1;
        private void label1_Click(object sender, EventArgs e)
        {
            if (ri == 3)
            {
                ri = 0;
            }
            ri = ri + 1;
            //System.Threading.Thread.Sleep(100);
            if (ri == 1)
            {
                radioButton1.Checked = true ;
            }
            if (ri == 2)
            {
                radioButton2.Checked = true;
            }
            if (ri == 3)
            {
                radioButton3.Checked = true;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (ri == 1)
            {
                ri = 4;
            }
            ri = ri - 1;
            if (ri == 1)
            {
                radioButton1.Checked = true;
            }
            if (ri == 2)
            {
                radioButton2.Checked = true;
            }
            if (ri == 3)
            {
                radioButton3.Checked = true;
            }
        }

        private void label1_MouseEnter(object sender, EventArgs e)
        {
            label1.ForeColor = Color.White;
        }

        private void label1_MouseLeave(object sender, EventArgs e)
        {
            label1.ForeColor = Color.FromArgb(95, 96, 115);
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            label5.ForeColor = Color.White;
        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            label5.ForeColor = Color.FromArgb(95, 96, 115);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMain());
            ri = 1;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMain2());
            ri = 2;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormMain3());
            ri = 3;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            if (BuildForm != null)
            {
                BuildForm.Close();
            }
            BuildForm = new Forms.FormBuild();
            BuildForm.Show();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ExitButton_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            ExitButton.Load(@"Images\icons\exitHover.png");
        }

        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            ExitButton.Load(@"Images\icons\exit.png");
        }

        private void CustomerFName_MouseClick(object sender, MouseEventArgs e)
        {
            if (InfoClass.ProfilForm != null)
            {
                InfoClass.ProfilForm.Close();
            }
            InfoClass.ProfilForm = new PForms.FormProfil();
            InfoClass.ProfilForm.Show();
        }
    }
}
