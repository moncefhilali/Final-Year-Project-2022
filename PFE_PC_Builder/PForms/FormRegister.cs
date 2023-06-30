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
    public partial class FormRegister : Form
    {
        PForms.FormLogin LoginForm;
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

        public FormRegister()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // Rounded Corners
        }

        private void toLoginButton_Click(object sender, EventArgs e)
        {
            if (LoginForm != null)
            {
                LoginForm.Close();
            }
            LoginForm = new FormLogin();
            LoginForm.Show();
            this.Hide();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            ErrorMsg.Visible = false;
        }

        private void RegisterButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (FNameBox.Text == "" || LNameBox.Text == "" || EmailBox.Text == "" || PasswordBox.Text =="")
            {
                ErrorMsg.Visible = true;
                ErrorMsg.Text = "Oops! you're missing something.";
                ErrorMsg.ForeColor = Color.Red;
                ErrorMsg.TextAlign = ContentAlignment.TopCenter;
                FNameBox.Text = "";
                LNameBox.Text = "";
                EmailBox.Text = "";
                PasswordBox.Text = "";
            }
            else
            {
                try
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("Insert into CUSTOMER(FirstName,LastName,CEmail,CPassword,CreatedAt) values(@FName,@LName,@CEmail,@CPassword,getdate())", cnx);
                    cmd.Parameters.AddWithValue("@FName", FNameBox.Text);
                    cmd.Parameters.AddWithValue("@LName", LNameBox.Text);
                    cmd.Parameters.AddWithValue("@CEmail", EmailBox.Text);
                    cmd.Parameters.AddWithValue("@CPassword", PasswordBox.Text);
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    FNameBox.Text = "";
                    LNameBox.Text = "";
                    EmailBox.Text = "";
                    PasswordBox.Text = "";
                    ErrorMsg.Visible = true;
                    ErrorMsg.Text = "Account has been created.";
                    ErrorMsg.ForeColor = Color.Green;
                    ErrorMsg.TextAlign = ContentAlignment.TopCenter;
                }
                catch
                {
                    ErrorMsg.Visible = true;
                    ErrorMsg.Text = "Oops! you're missing something.";
                    ErrorMsg.ForeColor = Color.Red;
                    ErrorMsg.TextAlign = ContentAlignment.TopCenter;
                    FNameBox.Text = "";
                    LNameBox.Text = "";
                    EmailBox.Text = "";
                    PasswordBox.Text = "";
                }
            }

        }

        private void ExitButton_MouseClick(object sender, MouseEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
