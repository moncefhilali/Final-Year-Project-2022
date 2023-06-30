using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;


namespace PFE_PC_Builder.PForms
{
    public partial class FormLogin : Form
    {
        public static Form1 HomeForm;
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
        // SQL Injection (Connection):
        public static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-I3D0A3M;Initial Catalog=PFE2022_PCBUILDER;Integrated Security=True;");
        PForms.FormRegister RegisterForm;
        //
        public FormLogin()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // Rounded Corners
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            ErrorMsg.Visible = false;
        }

        private void label1_MouseClick(object sender, MouseEventArgs e)
        {
            if (HomeForm != null)
            { HomeForm.Close(); }
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Select * from CUSTOMER where CEmail like @C_Email and CPassword like @C_Password", cnx);
            cmd.Parameters.AddWithValue("@C_Email", EmailBox.Text);
            cmd.Parameters.AddWithValue("@C_Password", PasswordBox.Text);
            SqlDataReader dr;
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                dr.Read();
                InfoClass.CurrentCustomerID = int.Parse(dr[0].ToString());
                InfoClass.CurrentCustomerFName = dr[1].ToString();
                InfoClass.CurrentCustomerLName = dr[2].ToString();
                ErrorMsg.Visible = false;
                HomeForm = new Form1();
                HomeForm.Show();
                this.Hide();
            }
            else
            { ErrorMsg.Visible = true; }

            PasswordBox.Text = "";
            EmailBox.Text = "";
            dr.Close();
            dr = null;
            cmd = null;
            cnx.Close();
        }

        private void EmailBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CreateButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (RegisterForm != null)
            {
                RegisterForm.Close();
            }
            RegisterForm = new PForms.FormRegister();
            RegisterForm.Show();
            this.Hide();
        }

        private void ExitButton_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {

        }
    }
}
