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
using System.Data.SqlClient;




namespace PFE_PC_Builder.PForms
{
    public partial class FormCheckout : Form
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
        // SQL Injection (Connection):
        public static SqlConnection cnx = new SqlConnection(@"Data Source=DESKTOP-I3D0A3M;Initial Catalog=PFE2022_PCBUILDER;Integrated Security=True;");

        public FormCheckout()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // Rounded Corners
        }

        private void FormCheckout_Load(object sender, EventArgs e)
        {
            FullnameLabel.Text = $"{InfoClass.CurrentCustomerFName} {InfoClass.CurrentCustomerLName}";
            ItemLabel.Text = InfoClass.SelectedCartName;
            SubtotalLabel.Text = $"$ {InfoClass.SelectedCartTotal}";
            TotalLabel.Text = $"{(InfoClass.SelectedCartTotal + 99.99):0.00}";
        }

        private void CancelButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void CheckoutButton_MouseClick(object sender, MouseEventArgs e)
        {
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Insert into CUSTOMER_ORDER(CustomerID,BSAS,ORD_Total,ORD_CreatedAt,ASM_ID) values (@C_ID,@BSAS,@ORD_Total,getdate(),@ASM_ID)", cnx);
            cmd.Parameters.AddWithValue("@C_ID", InfoClass.CurrentCustomerID);
            cmd.Parameters.AddWithValue("@BSAS", "Yes");
            cmd.Parameters.AddWithValue("@ORD_Total", (InfoClass.SelectedCartTotal + 99.99));
            cmd.Parameters.AddWithValue("@ASM_ID", InfoClass.SelectedCartID);
            cmd.ExecuteNonQuery();
            cnx.Close();
            if (InfoClass.ProfilForm != null)
            {
                InfoClass.ProfilForm.Close();
            }
            InfoClass.ProfilForm = new FormProfil();
            InfoClass.ProfilForm.Show();
            this.Hide();
        }
    }
}
