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


namespace PFE_PC_Builder.Forms
{
    public partial class FormBuild : Form
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
        public static string LastTable;
        // -------------------------------------------------------------
        // ASSEMBLE :
        
        //
        // Reset Button
        public void ResetButtonEvent()
        {
            CPULabel.Visible = false;
            CPUAdd.Visible = true;

            GPULabel.Visible = false;
            GPUAdd.Visible = true;

            MEMLabel.Visible = false;
            MEMAdd.Visible = true;

            MBLabel.Visible = false;
            MBAdd.Visible = true;

            STGLabel.Visible = false;
            STGAdd.Visible = true;

            PSLabel.Visible = false;
            PSAdd.Visible = true;

            CPUCLabel.Visible = false;
            CPUCAdd.Visible = true;

            CASELabel.Visible = false;
            CASEAdd.Visible = true;
        }
        // Clear Labels
        public void ClearLabels()
        {
            CPULabel.Text = "";
            GPULabel.Text = "";
            MEMLabel.Text = "";
            MBLabel.Text = "";
            STGLabel.Text = "";
            PSLabel.Text = "";
            CPUCLabel.Text = "";
            CASELabel.Text = "";
            ListNameBox.Text = "";
        }


        
        public FormBuild()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20)); // Rounded Corners
        }

        private void FormBuild_Load(object sender, EventArgs e)
        {
            // Rounded Button:
            CPUAdd.cornerRadius = 30;
            CPUAdd.borderColor = Color.White;
            CPUAdd.backColor = Color.Transparent;
            GPUAdd.cornerRadius = 30;
            GPUAdd.borderColor = Color.White;
            GPUAdd.backColor = Color.Transparent;
            MEMAdd.cornerRadius = 30;
            MEMAdd.borderColor = Color.White;
            MEMAdd.backColor = Color.Transparent;
            MBAdd.cornerRadius = 30;
            MBAdd.borderColor = Color.White;
            MBAdd.backColor = Color.Transparent;
            STGAdd.cornerRadius = 30;
            STGAdd.borderColor = Color.White;
            STGAdd.backColor = Color.Transparent;
            PSAdd.cornerRadius = 30;
            PSAdd.borderColor = Color.White;
            PSAdd.backColor = Color.Transparent;
            CPUCAdd.cornerRadius = 30;
            CPUCAdd.borderColor = Color.White;
            CPUCAdd.backColor = Color.Transparent;
            CASEAdd.cornerRadius = 30;
            CASEAdd.borderColor = Color.White;
            CASEAdd.backColor = Color.Transparent;
            SaveButton.cornerRadius = 40;
            SaveButton.borderColor = Color.FromArgb(111, 95, 190);
            SaveButton.backColor = Color.Transparent;
            //
            ClearLabels();
            SearchMsg.Visible = false;
            this.ActiveControl = label18;

        }

        private void roundLabel1_Click(object sender, EventArgs e)
        {

        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelLeft_Scroll(object sender, ScrollEventArgs e)
        {
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void StorageAdd_Click(object sender, EventArgs e)
        {

        }

        private void MBoradAdd_Click(object sender, EventArgs e)
        {

        }

        private void MemAdd_Click(object sender, EventArgs e)
        {

        }

        private void GPUAdd_Click(object sender, EventArgs e)
        {

        }

        private void ProcAdd_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void PSupplyAdd_Click(object sender, EventArgs e)
        {

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ResetButton_MouseClick(object sender, MouseEventArgs e)
        {
            ResetButtonEvent();
            ClearLabels();
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            SearchBox.Text = "";
        }

        private void BackButton_MouseClick(object sender, MouseEventArgs e)
        {
            this.Close();
        }

        private void CPUAdd_MouseClick(object sender, MouseEventArgs e)
        {
            ItemsPanel.Controls.Clear();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Select * from CPU", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PUserControls.ComponentDetails CD = new PUserControls.ComponentDetails();
                CD.ID = int.Parse(dr[0].ToString());
                CD.Option1 = dr[1].ToString();
                CD.Option2 = dr[2].ToString();
                CD.Price = float.Parse(dr[3].ToString());
                CD.Qty = int.Parse(dr[4].ToString());
                CD.Picture = @"\CPU\" + dr[5].ToString();
                CD.MouseClick += ItemsPanel_MouseClick;
                ItemsPanel.Controls.Add(CD);
            }
            cnx.Close();
            InfoClass.LastTable = "CPU";
        }

        private void ItemsPanel_MouseClick(object sender, MouseEventArgs e)
        {
            if (InfoClass.LastTable == "CPU")
            {
                CPUAdd.Visible = false;
                CPULabel.Visible = true;
                CPULabel.Text = $"{InfoClass.SelectedControlOption1}\n{InfoClass.SelectedControlOption2}";
                InfoClass.CPU_ID = InfoClass.SelectedControlID;
                InfoClass.CPU_Price = InfoClass.SelectedControlPrice;

            }
            if (InfoClass.LastTable == "GPU")
            {
                GPUAdd.Visible = false;
                GPULabel.Visible = true;
                GPULabel.Text = $"{InfoClass.SelectedControlOption1}\n{InfoClass.SelectedControlOption2}";
                InfoClass.GPU_ID = InfoClass.SelectedControlID;
                InfoClass.GPU_Price = InfoClass.SelectedControlPrice;
            }
            if (InfoClass.LastTable == "MEM")
            {
                MEMAdd.Visible = false;
                MEMLabel.Visible = true;
                MEMLabel.Text = $"{InfoClass.SelectedControlOption1}\n{InfoClass.SelectedControlOption2}";
                InfoClass.MEM_ID = InfoClass.SelectedControlID;
                InfoClass.MEM_Price = InfoClass.SelectedControlPrice;
            }
            if (InfoClass.LastTable == "MB")
            {
                MBAdd.Visible = false;
                MBLabel.Visible = true;
                MBLabel.Text = $"{InfoClass.SelectedControlOption1}\n{InfoClass.SelectedControlOption2}";
                InfoClass.MB_ID = InfoClass.SelectedControlID;
                InfoClass.MB_Price = InfoClass.SelectedControlPrice;
            }
            if (InfoClass.LastTable == "STG")
            {
                STGAdd.Visible = false;
                STGLabel.Visible = true;
                STGLabel.Text = $"{InfoClass.SelectedControlOption1}\n{InfoClass.SelectedControlOption2}";
                InfoClass.STG_ID = InfoClass.SelectedControlID;
                InfoClass.STG_Price = InfoClass.SelectedControlPrice;
            }
            if (InfoClass.LastTable == "PS")
            {
                PSAdd.Visible = false;
                PSLabel.Visible = true;
                PSLabel.Text = $"{InfoClass.SelectedControlOption1}\n{InfoClass.SelectedControlOption2}";
                InfoClass.PS_ID = InfoClass.SelectedControlID;
                InfoClass.PS_Price = InfoClass.SelectedControlPrice;
            }
            if (InfoClass.LastTable == "CPUC")
            {
                CPUCAdd.Visible = false;
                CPUCLabel.Visible = true;
                CPUCLabel.Text = $"{InfoClass.SelectedControlOption1}\n{InfoClass.SelectedControlOption2}";
                InfoClass.CPUC_ID = InfoClass.SelectedControlID;
                InfoClass.CPU_Price = InfoClass.SelectedControlPrice;
            }
            if (InfoClass.LastTable == "CASES")
            {
                CASEAdd.Visible = false;
                CASELabel.Visible = true;
                CASELabel.Text = $"{InfoClass.SelectedControlOption1}\n{InfoClass.SelectedControlOption2}";
                InfoClass.CASE_ID = InfoClass.SelectedControlID;
                InfoClass.CASE_Price = InfoClass.SelectedControlPrice;
                InfoClass.CASE_Image = InfoClass.SelectedControlImage;
            }
        }

        private void FormBuild_Click(object sender, EventArgs e)
        {

        }

        private void ItemsPanel_Click(object sender, EventArgs e)
        {
        }

        private void ItemsPanel_MouseCaptureChanged(object sender, EventArgs e)
        {
        }

        private void ItemsPanel_ChangeUICues(object sender, UICuesEventArgs e)
        {
        }

        private void numberButton_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void GPUAdd_MouseClick(object sender, MouseEventArgs e)
        {
            ItemsPanel.Controls.Clear();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Select * from GPU", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PUserControls.ComponentDetails CD = new PUserControls.ComponentDetails();
                CD.ID = int.Parse(dr[0].ToString());
                CD.Option1 = dr[1].ToString();
                CD.Option2 = dr[2].ToString();
                CD.Price = float.Parse(dr[3].ToString());
                CD.Qty = int.Parse(dr[4].ToString());
                CD.Picture = @"\GPU\" + dr[5].ToString();
                CD.MouseClick += ItemsPanel_MouseClick;
                ItemsPanel.Controls.Add(CD);
            }
            cnx.Close();
            InfoClass.LastTable = "GPU";
        }

        private void MEMAdd_MouseClick(object sender, MouseEventArgs e)
        {
            ItemsPanel.Controls.Clear();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Select * from MEM", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PUserControls.ComponentDetails CD = new PUserControls.ComponentDetails();
                CD.ID = int.Parse(dr[0].ToString());
                CD.Option1 = dr[1].ToString();
                CD.Option2 = dr[2].ToString();
                CD.Price = float.Parse(dr[3].ToString());
                CD.Qty = int.Parse(dr[4].ToString());
                CD.Picture = @"\MEM\" + dr[5].ToString();
                CD.MouseClick += ItemsPanel_MouseClick;
                ItemsPanel.Controls.Add(CD);
            }
            cnx.Close();
            InfoClass.LastTable = "MEM";
        }

        private void MBAdd_MouseClick(object sender, MouseEventArgs e)
        {
            ItemsPanel.Controls.Clear();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Select * from MB", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PUserControls.ComponentDetails CD = new PUserControls.ComponentDetails();
                CD.ID = int.Parse(dr[0].ToString());
                CD.Option1 = dr[1].ToString();
                CD.Option2 = dr[2].ToString();
                CD.Price = float.Parse(dr[3].ToString());
                CD.Qty = int.Parse(dr[4].ToString());
                CD.Picture = @"\MB\" + dr[5].ToString();
                CD.MouseClick += ItemsPanel_MouseClick;
                ItemsPanel.Controls.Add(CD);
            }
            cnx.Close();
            InfoClass.LastTable = "MB";
        }

        private void STGAdd_MouseClick(object sender, MouseEventArgs e)
        {
            ItemsPanel.Controls.Clear();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Select * from STG", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PUserControls.ComponentDetails CD = new PUserControls.ComponentDetails();
                CD.ID = int.Parse(dr[0].ToString());
                CD.Option1 = dr[1].ToString();
                CD.Option2 = dr[2].ToString();
                CD.Price = float.Parse(dr[3].ToString());
                CD.Qty = int.Parse(dr[4].ToString());
                CD.Picture = @"\STG\" + dr[5].ToString();
                CD.MouseClick += ItemsPanel_MouseClick;
                ItemsPanel.Controls.Add(CD);
            }
            cnx.Close();
            InfoClass.LastTable = "STG";
        }

        private void PSAdd_MouseClick(object sender, MouseEventArgs e)
        {
            ItemsPanel.Controls.Clear();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Select * from PS", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PUserControls.ComponentDetails CD = new PUserControls.ComponentDetails();
                CD.ID = int.Parse(dr[0].ToString());
                CD.Option1 = dr[1].ToString();
                CD.Option2 = dr[2].ToString();
                CD.Price = float.Parse(dr[3].ToString());
                CD.Qty = int.Parse(dr[4].ToString());
                CD.Picture = @"\PS\" + dr[5].ToString();
                CD.MouseClick += ItemsPanel_MouseClick;
                ItemsPanel.Controls.Add(CD);
            }
            cnx.Close();
            InfoClass.LastTable = "PS";
        }

        private void CPUCAdd_MouseClick(object sender, MouseEventArgs e)
        {
            ItemsPanel.Controls.Clear();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Select * from CPUC", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PUserControls.ComponentDetails CD = new PUserControls.ComponentDetails();
                CD.ID = int.Parse(dr[0].ToString());
                CD.Option1 = dr[1].ToString();
                CD.Option2 = dr[2].ToString();
                CD.Price = float.Parse(dr[3].ToString());
                CD.Qty = int.Parse(dr[4].ToString());
                CD.Picture = @"\CPUC\" + dr[5].ToString();
                CD.MouseClick += ItemsPanel_MouseClick;
                ItemsPanel.Controls.Add(CD);
            }
            cnx.Close();
            InfoClass.LastTable = "CPUC";
        }

        private void CASEAdd_MouseClick(object sender, MouseEventArgs e)
        {
            ItemsPanel.Controls.Clear();
            cnx.Open();
            SqlCommand cmd = new SqlCommand("Select * from CASES", cnx);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                PUserControls.ComponentDetails CD = new PUserControls.ComponentDetails();
                CD.ID = int.Parse(dr[0].ToString());
                CD.Option1 = dr[1].ToString();
                CD.Option2 = dr[2].ToString();
                CD.Price = float.Parse(dr[3].ToString());
                CD.Qty = int.Parse(dr[4].ToString());
                CD.Picture = @"\CASES\" + dr[5].ToString();
                CD.MouseClick += ItemsPanel_MouseClick;
                ItemsPanel.Controls.Add(CD);
            }
            cnx.Close();
            InfoClass.LastTable = "CASES";
        }

        private void ResetButton_MouseEnter(object sender, EventArgs e)
        {
            ResetButton.ForeColor = Color.White;
        }

        private void ResetButton_MouseLeave(object sender, EventArgs e)
        {
            ResetButton.ForeColor = Color.FromArgb(95, 96, 115);
        }

        private void SearchButton_MouseClick(object sender, MouseEventArgs e)
        {
            SearchMsg.Text = $"Results for {SearchBox.Text} :";
            SearchMsg.Visible = true;

            string CompN = InfoClass.LastTable;
            string Option1="", Option2="";
            if (InfoClass.LastTable == "CPU")
            {
                Option1 = "CPU_Serie";
                Option2 ="CPU_Frequency";
            }
            if (InfoClass.LastTable == "GPU")
            {
                Option1 = "GPU_Name";
                Option2 = "GPU_Serie";
            }
            if (InfoClass.LastTable == "MEM")
            {
                Option1 = "MEM_Name";
                Option2 = "MEM_Type";
            }
            if (InfoClass.LastTable == "MB")
            {
                Option1 = "MB_Name";
                Option2 = "MB_Socket";
            }
            if (InfoClass.LastTable == "STG")
            {
                Option1 = "STG_Name";
                Option2 = "STG_Details";
            }
            if (InfoClass.LastTable == "PS")
            {
                Option1 = "PS_Name";
                Option2 = "PS_MaxPower";
            }
            if (InfoClass.LastTable == "CPUC")
            {
                Option1 = "CPUC_Name";
                Option2 = "CPUC_Type";
            }
            if (InfoClass.LastTable == "CASES")
            {
                Option1 = "CASE_Name";
                Option2 = "CASE_Type";
            }

            try
            {
                ItemsPanel.Controls.Clear();
                cnx.Open();
                SqlCommand cmd = new SqlCommand($"Select * from {CompN} where ({Option1} like '%{SearchBox.Text}%') Or ({Option2} LIKE '%{SearchBox.Text}%')", cnx);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PUserControls.ComponentDetails CD = new PUserControls.ComponentDetails();
                    CD.ID = int.Parse(dr[0].ToString());
                    CD.Option1 = dr[1].ToString();
                    CD.Option2 = dr[2].ToString();
                    CD.Price = float.Parse(dr[3].ToString());
                    CD.Qty = int.Parse(dr[4].ToString());
                    CD.Picture = $@"\{CompN}\" + dr[5].ToString();
                    CD.MouseClick += ItemsPanel_MouseClick;
                    ItemsPanel.Controls.Add(CD);
                }
                cnx.Close();
            }
            catch
            {
                cnx.Close();
            }
        }

        private void SaveButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (CPULabel.Text == "" || GPULabel.Text == "" || MEMLabel.Text == "" || MBLabel.Text == "" || STGLabel.Text == "" || PSLabel.Text == "" || CPUCLabel.Text == "" || CASELabel.Text == "" || ListNameBox.Text == "")
            {
                ErrorMsg.Visible = true;
                ErrorMsg.Text = "⚠ Be sure you chose all the parts.";
                ErrorMsg.ForeColor = Color.Red;
                ErrorMsg.TextAlign = ContentAlignment.TopCenter;
            }
            else
            {
                try
                {
                    cnx.Open();
                    SqlCommand cmd = new SqlCommand("insert into ASSEMBLE(CPU_ID,GPU_ID,MEM_ID,MB_ID,STG_ID,PS_ID,CPUC_ID,CASE_ID,ASM_TOTAL,CreatedBy,ASM_Image,ASM_Name) values (@CPU_ID,@GPU_ID,@MEM_ID,@MB_ID,@STG_ID,@PS_ID,@CPUC_ID,@CASE_ID,@ASM_TOTAL,@CreatedBy,@ASM_Image,@ASM_Name)", cnx);
                    cmd.Parameters.AddWithValue("@ASM_Name", ListNameBox.Text);
                    cmd.Parameters.AddWithValue("@CPU_ID", InfoClass.CPU_ID);
                    cmd.Parameters.AddWithValue("@GPU_ID", InfoClass.GPU_ID);
                    cmd.Parameters.AddWithValue("@MEM_ID", InfoClass.MEM_ID);
                    cmd.Parameters.AddWithValue("@MB_ID", InfoClass.MB_ID);
                    cmd.Parameters.AddWithValue("@STG_ID", InfoClass.STG_ID);
                    cmd.Parameters.AddWithValue("@PS_ID", InfoClass.PS_ID);
                    cmd.Parameters.AddWithValue("@CPUC_ID", InfoClass.CPUC_ID);
                    cmd.Parameters.AddWithValue("@CASE_ID", InfoClass.CASE_ID);
                    cmd.Parameters.AddWithValue("@ASM_Total", InfoClass.CPU_Price + InfoClass.GPU_Price + InfoClass.MEM_Price + InfoClass.MB_Price + InfoClass.STG_Price + InfoClass.PS_Price + InfoClass.CPUC_Price + InfoClass.CASE_Price);
                    cmd.Parameters.AddWithValue("@CreatedBy", InfoClass.CurrentCustomerID);
                    cmd.Parameters.AddWithValue("@ASM_Image", InfoClass.CASE_Image);
                    cmd.ExecuteNonQuery();
                    cnx.Close();
                    ErrorMsg.Visible = true;
                    ErrorMsg.Text = "✔ Added to your chart.";
                    ErrorMsg.ForeColor = Color.Green;
                    ErrorMsg.TextAlign = ContentAlignment.TopCenter;
                    ResetButtonEvent();
                    ClearLabels();
                }
                catch (Exception ex)
                {
                    ErrorMsg.Visible = true;
                    ErrorMsg.Text = "Oops! you're missing something.";
                    ErrorMsg.ForeColor = Color.Red;
                    ErrorMsg.TextAlign = ContentAlignment.TopCenter;
                    ResetButtonEvent();
                    ClearLabels();
                    cnx.Close();
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void ListNameBox_MouseClick(object sender, MouseEventArgs e)
        {
            ListNameBox.Text = "";
        }
    }
}
