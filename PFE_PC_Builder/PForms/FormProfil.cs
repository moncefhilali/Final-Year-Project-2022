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
    public partial class FormProfil : Form
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
        public static SqlCommand cmd;

        public FormProfil()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // Rounded Corners
        }

        private void FormProfil_Load(object sender, EventArgs e)
        {
            AttributPanel.Visible = false;
            cnx.Open();
            cmd = new SqlCommand("Select count(*) from ASSEMBLE Where CreatedBy like @CurrentUserID", cnx);
            cmd.Parameters.AddWithValue("@CurrentUserID", InfoClass.CurrentCustomerID);
            int CountCart = int.Parse((cmd.ExecuteScalar()).ToString());
            cnx.Close();
            cnx.Open();
            cmd = new SqlCommand("Select count(*) from CUSTOMER_ORDER Where CustomerID like @CurrentUserID", cnx);
            cmd.Parameters.AddWithValue("@CurrentUserID", InfoClass.CurrentCustomerID);
            int CountOrder = int.Parse((cmd.ExecuteScalar()).ToString());
            cnx.Close();

            FullNameLabel.Text = $"{InfoClass.CurrentCustomerFName} {InfoClass.CurrentCustomerLName}";
            CartCountLabel.Text = $"{CountCart} Items";
            OrderCountLabel.Text = $"{CountOrder} Orders";

        }

        private void BackButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void MyCartButton_MouseClick(object sender, MouseEventArgs e)
        {
            AttributPanel.Visible = false;
            ProfilFlowLayout.Controls.Clear();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Select * from ASSEMBLE where CreatedBy like @CurrentUserID", cnx);
            cmd.Parameters.AddWithValue("@CurrentUserID", InfoClass.CurrentCustomerID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PUserControls.CartDetails CD = new PUserControls.CartDetails();
                CD.ID = int.Parse(dr["ASM_ID"].ToString());
                CD.ASM_Name = dr["ASM_Name"].ToString();
                CD.Picture = dr["ASM_Image"].ToString();
                CD.Total = float.Parse(dr["ASM_Total"].ToString());
                CD.MouseClick += ProfilFlowLayout_MouseClick ;
                ProfilFlowLayout.Controls.Add(CD);
            }
            cnx.Close();
        }

        private void ProfilFlowLayout_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void MyOrderButton_MouseClick(object sender, MouseEventArgs e)
        {
            AttributPanel.Visible = true;
            ProfilFlowLayout.Controls.Clear();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("select co.ORDER_ID, a.ASM_Name, co.BSAS, co.ORD_Total, co.ORD_CreatedAt, ASM_Image from Assemble a inner join CUSTOMER_ORDER co ON a.ASM_ID = co.ASM_ID where co.CustomerID like @C_ID",cnx);
            cmd.Parameters.AddWithValue("@C_ID", InfoClass.CurrentCustomerID);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PUserControls.OrderDetails OD = new PUserControls.OrderDetails();
                OD.ORD_ID = int.Parse(dr[0].ToString());
                OD.ASM_Name = dr[1].ToString();
                OD.BSAS = dr[2].ToString();
                OD.ORD_Total = float.Parse(dr[3].ToString());
                OD.CreatedAt = dr[4].ToString();
                OD.ASM_Image = dr[5].ToString();
                ProfilFlowLayout.Controls.Add(OD);
            }
            cnx.Close();
        }
    }
}
