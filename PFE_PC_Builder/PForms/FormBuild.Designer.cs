
namespace PFE_PC_Builder.Forms
{
    partial class FormBuild
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuild));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ErrorMsg = new System.Windows.Forms.Label();
            this.SaveButton = new PFE_PC_Builder.RoundLabel();
            this.ResetButton = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.CASEAdd = new PFE_PC_Builder.RoundLabel();
            this.CPUCAdd = new PFE_PC_Builder.RoundLabel();
            this.PSAdd = new PFE_PC_Builder.RoundLabel();
            this.STGAdd = new PFE_PC_Builder.RoundLabel();
            this.MBAdd = new PFE_PC_Builder.RoundLabel();
            this.MEMAdd = new PFE_PC_Builder.RoundLabel();
            this.GPUAdd = new PFE_PC_Builder.RoundLabel();
            this.CPUAdd = new PFE_PC_Builder.RoundLabel();
            this.CASELabel = new System.Windows.Forms.Label();
            this.CPUCLabel = new System.Windows.Forms.Label();
            this.PSLabel = new System.Windows.Forms.Label();
            this.STGLabel = new System.Windows.Forms.Label();
            this.MBLabel = new System.Windows.Forms.Label();
            this.MEMLabel = new System.Windows.Forms.Label();
            this.CPULabel = new System.Windows.Forms.Label();
            this.GPULabel = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Label();
            this.ItemsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.SearchMsg = new System.Windows.Forms.Label();
            this.ListNameBox = new System.Windows.Forms.TextBox();
            this.ListNameLabel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMinSize = new System.Drawing.Size(10, 10);
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.ListNameBox);
            this.panel1.Controls.Add(this.ErrorMsg);
            this.panel1.Controls.Add(this.SaveButton);
            this.panel1.Controls.Add(this.ResetButton);
            this.panel1.Controls.Add(this.ListNameLabel);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.CASEAdd);
            this.panel1.Controls.Add(this.CPUCAdd);
            this.panel1.Controls.Add(this.PSAdd);
            this.panel1.Controls.Add(this.STGAdd);
            this.panel1.Controls.Add(this.MBAdd);
            this.panel1.Controls.Add(this.MEMAdd);
            this.panel1.Controls.Add(this.GPUAdd);
            this.panel1.Controls.Add(this.CPUAdd);
            this.panel1.Controls.Add(this.CASELabel);
            this.panel1.Controls.Add(this.CPUCLabel);
            this.panel1.Controls.Add(this.PSLabel);
            this.panel1.Controls.Add(this.STGLabel);
            this.panel1.Controls.Add(this.MBLabel);
            this.panel1.Controls.Add(this.MEMLabel);
            this.panel1.Controls.Add(this.CPULabel);
            this.panel1.Controls.Add(this.GPULabel);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.label19);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.label21);
            this.panel1.Controls.Add(this.label22);
            this.panel1.Controls.Add(this.label23);
            this.panel1.Controls.Add(this.label24);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(460, 9);
            this.panel1.MaximumSize = new System.Drawing.Size(244, 413);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(244, 413);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ErrorMsg
            // 
            this.ErrorMsg.AutoSize = true;
            this.ErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.ErrorMsg.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsg.ForeColor = System.Drawing.Color.Gold;
            this.ErrorMsg.Location = new System.Drawing.Point(2, 915);
            this.ErrorMsg.MinimumSize = new System.Drawing.Size(220, 19);
            this.ErrorMsg.Name = "ErrorMsg";
            this.ErrorMsg.Size = new System.Drawing.Size(220, 19);
            this.ErrorMsg.TabIndex = 10;
            this.ErrorMsg.Text = "Be sure you choose all the parts!";
            this.ErrorMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SaveButton
            // 
            this.SaveButton.AutoSize = true;
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SaveButton.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.ForeColor = System.Drawing.Color.White;
            this.SaveButton.Location = new System.Drawing.Point(137, 870);
            this.SaveButton.MinimumSize = new System.Drawing.Size(70, 40);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(70, 40);
            this.SaveButton.TabIndex = 5;
            this.SaveButton.Text = " Save";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SaveButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SaveButton_MouseClick);
            // 
            // ResetButton
            // 
            this.ResetButton.AutoSize = true;
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(96)))), ((int)(((byte)(115)))));
            this.ResetButton.Location = new System.Drawing.Point(69, 876);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(57, 28);
            this.ResetButton.TabIndex = 0;
            this.ResetButton.Text = "Reset";
            this.ResetButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ResetButton_MouseClick);
            this.ResetButton.MouseEnter += new System.EventHandler(this.ResetButton_MouseEnter);
            this.ResetButton.MouseLeave += new System.EventHandler(this.ResetButton_MouseLeave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(23, 702);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 28);
            this.label14.TabIndex = 0;
            this.label14.Text = "Case";
            // 
            // CASEAdd
            // 
            this.CASEAdd.AutoSize = true;
            this.CASEAdd.BackColor = System.Drawing.Color.Transparent;
            this.CASEAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CASEAdd.Font = new System.Drawing.Font("Smooch Sans SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CASEAdd.ForeColor = System.Drawing.Color.White;
            this.CASEAdd.Location = new System.Drawing.Point(30, 741);
            this.CASEAdd.MinimumSize = new System.Drawing.Size(30, 30);
            this.CASEAdd.Name = "CASEAdd";
            this.CASEAdd.Size = new System.Drawing.Size(30, 31);
            this.CASEAdd.TabIndex = 3;
            this.CASEAdd.Text = " +";
            this.CASEAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CASEAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CASEAdd_MouseClick);
            // 
            // CPUCAdd
            // 
            this.CPUCAdd.AutoSize = true;
            this.CPUCAdd.BackColor = System.Drawing.Color.Transparent;
            this.CPUCAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CPUCAdd.Font = new System.Drawing.Font("Smooch Sans SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUCAdd.ForeColor = System.Drawing.Color.White;
            this.CPUCAdd.Location = new System.Drawing.Point(30, 645);
            this.CPUCAdd.MinimumSize = new System.Drawing.Size(30, 30);
            this.CPUCAdd.Name = "CPUCAdd";
            this.CPUCAdd.Size = new System.Drawing.Size(30, 31);
            this.CPUCAdd.TabIndex = 3;
            this.CPUCAdd.Text = " +";
            this.CPUCAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CPUCAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CPUCAdd_MouseClick);
            // 
            // PSAdd
            // 
            this.PSAdd.AutoSize = true;
            this.PSAdd.BackColor = System.Drawing.Color.Transparent;
            this.PSAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PSAdd.Font = new System.Drawing.Font("Smooch Sans SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSAdd.ForeColor = System.Drawing.Color.White;
            this.PSAdd.Location = new System.Drawing.Point(28, 547);
            this.PSAdd.MinimumSize = new System.Drawing.Size(30, 30);
            this.PSAdd.Name = "PSAdd";
            this.PSAdd.Size = new System.Drawing.Size(30, 31);
            this.PSAdd.TabIndex = 3;
            this.PSAdd.Text = " +";
            this.PSAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PSAdd.Click += new System.EventHandler(this.PSupplyAdd_Click);
            this.PSAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PSAdd_MouseClick);
            // 
            // STGAdd
            // 
            this.STGAdd.AutoSize = true;
            this.STGAdd.BackColor = System.Drawing.Color.Transparent;
            this.STGAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.STGAdd.Font = new System.Drawing.Font("Smooch Sans SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STGAdd.ForeColor = System.Drawing.Color.White;
            this.STGAdd.Location = new System.Drawing.Point(28, 450);
            this.STGAdd.MinimumSize = new System.Drawing.Size(30, 30);
            this.STGAdd.Name = "STGAdd";
            this.STGAdd.Size = new System.Drawing.Size(30, 31);
            this.STGAdd.TabIndex = 3;
            this.STGAdd.Text = " +";
            this.STGAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.STGAdd.Click += new System.EventHandler(this.StorageAdd_Click);
            this.STGAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.STGAdd_MouseClick);
            // 
            // MBAdd
            // 
            this.MBAdd.AutoSize = true;
            this.MBAdd.BackColor = System.Drawing.Color.Transparent;
            this.MBAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MBAdd.Font = new System.Drawing.Font("Smooch Sans SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBAdd.ForeColor = System.Drawing.Color.White;
            this.MBAdd.Location = new System.Drawing.Point(28, 354);
            this.MBAdd.MinimumSize = new System.Drawing.Size(30, 30);
            this.MBAdd.Name = "MBAdd";
            this.MBAdd.Size = new System.Drawing.Size(30, 31);
            this.MBAdd.TabIndex = 3;
            this.MBAdd.Text = " +";
            this.MBAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MBAdd.Click += new System.EventHandler(this.MBoradAdd_Click);
            this.MBAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MBAdd_MouseClick);
            // 
            // MEMAdd
            // 
            this.MEMAdd.AutoSize = true;
            this.MEMAdd.BackColor = System.Drawing.Color.Transparent;
            this.MEMAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MEMAdd.Font = new System.Drawing.Font("Smooch Sans SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEMAdd.ForeColor = System.Drawing.Color.White;
            this.MEMAdd.Location = new System.Drawing.Point(28, 257);
            this.MEMAdd.MinimumSize = new System.Drawing.Size(30, 30);
            this.MEMAdd.Name = "MEMAdd";
            this.MEMAdd.Size = new System.Drawing.Size(30, 31);
            this.MEMAdd.TabIndex = 3;
            this.MEMAdd.Text = " +";
            this.MEMAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MEMAdd.Click += new System.EventHandler(this.MemAdd_Click);
            this.MEMAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.MEMAdd_MouseClick);
            // 
            // GPUAdd
            // 
            this.GPUAdd.AutoSize = true;
            this.GPUAdd.BackColor = System.Drawing.Color.Transparent;
            this.GPUAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GPUAdd.Font = new System.Drawing.Font("Smooch Sans SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPUAdd.ForeColor = System.Drawing.Color.White;
            this.GPUAdd.Location = new System.Drawing.Point(28, 161);
            this.GPUAdd.MinimumSize = new System.Drawing.Size(30, 30);
            this.GPUAdd.Name = "GPUAdd";
            this.GPUAdd.Size = new System.Drawing.Size(30, 31);
            this.GPUAdd.TabIndex = 3;
            this.GPUAdd.Text = " +";
            this.GPUAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GPUAdd.Click += new System.EventHandler(this.GPUAdd_Click);
            this.GPUAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GPUAdd_MouseClick);
            // 
            // CPUAdd
            // 
            this.CPUAdd.AutoSize = true;
            this.CPUAdd.BackColor = System.Drawing.Color.Transparent;
            this.CPUAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CPUAdd.Font = new System.Drawing.Font("Smooch Sans SemiBold", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUAdd.ForeColor = System.Drawing.Color.White;
            this.CPUAdd.Location = new System.Drawing.Point(28, 64);
            this.CPUAdd.MinimumSize = new System.Drawing.Size(30, 30);
            this.CPUAdd.Name = "CPUAdd";
            this.CPUAdd.Size = new System.Drawing.Size(30, 31);
            this.CPUAdd.TabIndex = 3;
            this.CPUAdd.Text = " +";
            this.CPUAdd.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CPUAdd.Click += new System.EventHandler(this.ProcAdd_Click);
            this.CPUAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CPUAdd_MouseClick);
            // 
            // CASELabel
            // 
            this.CASELabel.AutoSize = true;
            this.CASELabel.BackColor = System.Drawing.Color.Transparent;
            this.CASELabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CASELabel.ForeColor = System.Drawing.Color.White;
            this.CASELabel.Location = new System.Drawing.Point(28, 730);
            this.CASELabel.Name = "CASELabel";
            this.CASELabel.Size = new System.Drawing.Size(185, 56);
            this.CASELabel.TabIndex = 0;
            this.CASELabel.Text = "Corsair iCUE 220T RGB\r\nGlass ATX Mid Tower";
            this.CASELabel.Visible = false;
            this.CASELabel.Click += new System.EventHandler(this.label29_Click);
            // 
            // CPUCLabel
            // 
            this.CPUCLabel.AutoSize = true;
            this.CPUCLabel.BackColor = System.Drawing.Color.Transparent;
            this.CPUCLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUCLabel.ForeColor = System.Drawing.Color.White;
            this.CPUCLabel.Location = new System.Drawing.Point(23, 634);
            this.CPUCLabel.Name = "CPUCLabel";
            this.CPUCLabel.Size = new System.Drawing.Size(156, 56);
            this.CPUCLabel.TabIndex = 0;
            this.CPUCLabel.Text = "32 GB Ulta-Fast\r\n3700 mhz Memory";
            this.CPUCLabel.Visible = false;
            // 
            // PSLabel
            // 
            this.PSLabel.AutoSize = true;
            this.PSLabel.BackColor = System.Drawing.Color.Transparent;
            this.PSLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PSLabel.ForeColor = System.Drawing.Color.White;
            this.PSLabel.Location = new System.Drawing.Point(21, 537);
            this.PSLabel.Name = "PSLabel";
            this.PSLabel.Size = new System.Drawing.Size(150, 56);
            this.PSLabel.TabIndex = 0;
            this.PSLabel.Text = "EVGA SuperNOVA\r\nPlus Gold 850W";
            this.PSLabel.Visible = false;
            this.PSLabel.Click += new System.EventHandler(this.label27_Click);
            // 
            // STGLabel
            // 
            this.STGLabel.AutoSize = true;
            this.STGLabel.BackColor = System.Drawing.Color.Transparent;
            this.STGLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.STGLabel.ForeColor = System.Drawing.Color.White;
            this.STGLabel.Location = new System.Drawing.Point(21, 440);
            this.STGLabel.Name = "STGLabel";
            this.STGLabel.Size = new System.Drawing.Size(187, 56);
            this.STGLabel.TabIndex = 0;
            this.STGLabel.Text = "Western Digital SN550\r\nM.2 2280 SSD 1TB PCI-E";
            this.STGLabel.Visible = false;
            this.STGLabel.Click += new System.EventHandler(this.label26_Click);
            // 
            // MBLabel
            // 
            this.MBLabel.AutoSize = true;
            this.MBLabel.BackColor = System.Drawing.Color.Transparent;
            this.MBLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MBLabel.ForeColor = System.Drawing.Color.White;
            this.MBLabel.Location = new System.Drawing.Point(21, 343);
            this.MBLabel.Name = "MBLabel";
            this.MBLabel.Size = new System.Drawing.Size(164, 56);
            this.MBLabel.TabIndex = 0;
            this.MBLabel.Text = "ASUS TUF Gaming\r\nIntel LGA 1700 DDR4";
            this.MBLabel.Visible = false;
            this.MBLabel.Click += new System.EventHandler(this.label25_Click);
            // 
            // MEMLabel
            // 
            this.MEMLabel.AutoSize = true;
            this.MEMLabel.BackColor = System.Drawing.Color.Transparent;
            this.MEMLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MEMLabel.ForeColor = System.Drawing.Color.White;
            this.MEMLabel.Location = new System.Drawing.Point(21, 246);
            this.MEMLabel.Name = "MEMLabel";
            this.MEMLabel.Size = new System.Drawing.Size(187, 56);
            this.MEMLabel.TabIndex = 0;
            this.MEMLabel.Text = "CROSSAIR Vengeance\r\n 16GB DDR4 3200";
            this.MEMLabel.Visible = false;
            this.MEMLabel.Click += new System.EventHandler(this.label15_Click);
            // 
            // CPULabel
            // 
            this.CPULabel.AutoSize = true;
            this.CPULabel.BackColor = System.Drawing.Color.Transparent;
            this.CPULabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPULabel.ForeColor = System.Drawing.Color.White;
            this.CPULabel.Location = new System.Drawing.Point(21, 52);
            this.CPULabel.Name = "CPULabel";
            this.CPULabel.Size = new System.Drawing.Size(177, 56);
            this.CPULabel.TabIndex = 0;
            this.CPULabel.Text = "Intel Core i5 10th Gen\r\nComet Lake 2.9 Ghz";
            this.CPULabel.Visible = false;
            this.CPULabel.Click += new System.EventHandler(this.label16_Click);
            // 
            // GPULabel
            // 
            this.GPULabel.AutoSize = true;
            this.GPULabel.BackColor = System.Drawing.Color.Transparent;
            this.GPULabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GPULabel.ForeColor = System.Drawing.Color.White;
            this.GPULabel.Location = new System.Drawing.Point(21, 149);
            this.GPULabel.Name = "GPULabel";
            this.GPULabel.Size = new System.Drawing.Size(167, 56);
            this.GPULabel.TabIndex = 0;
            this.GPULabel.Text = "ASUS Phoenix 8GB\r\nGeForce RTX 3080Ti";
            this.GPULabel.Visible = false;
            this.GPULabel.Click += new System.EventHandler(this.label17_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(21, 24);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 28);
            this.label18.TabIndex = 0;
            this.label18.Text = "Processor";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(23, 606);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(74, 28);
            this.label19.TabIndex = 0;
            this.label19.Text = "Cooling";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(21, 121);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(130, 28);
            this.label20.TabIndex = 0;
            this.label20.Text = "Graphics Card";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(21, 509);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(123, 28);
            this.label21.TabIndex = 0;
            this.label21.Text = "Power Supply";
            this.label21.Click += new System.EventHandler(this.label21_Click);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Transparent;
            this.label22.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(21, 218);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(79, 28);
            this.label22.TabIndex = 0;
            this.label22.Text = "Memory";
            this.label22.Click += new System.EventHandler(this.label22_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Transparent;
            this.label23.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(23, 412);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(76, 28);
            this.label23.TabIndex = 0;
            this.label23.Text = "Storage";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Transparent;
            this.label24.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(21, 315);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(121, 28);
            this.label24.TabIndex = 0;
            this.label24.Text = "Mother Board";
            this.label24.Click += new System.EventHandler(this.label24_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(47)))));
            this.label2.Location = new System.Drawing.Point(144, 909);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "FreeSpace";
            // 
            // SearchBox
            // 
            this.SearchBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(138)))), ((int)(((byte)(163)))));
            this.SearchBox.Location = new System.Drawing.Point(105, 39);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(304, 24);
            this.SearchBox.TabIndex = 7;
            this.SearchBox.Text = "Intel, ASUS, SSD...";
            this.SearchBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.textBox1_MouseClick);
            // 
            // SearchButton
            // 
            this.SearchButton.AutoSize = true;
            this.SearchButton.BackColor = System.Drawing.Color.Transparent;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.Location = new System.Drawing.Point(75, 40);
            this.SearchButton.MinimumSize = new System.Drawing.Size(22, 23);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(22, 23);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.SearchButton_MouseClick);
            // 
            // BackButton
            // 
            this.BackButton.AutoSize = true;
            this.BackButton.BackColor = System.Drawing.Color.Transparent;
            this.BackButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BackButton.Location = new System.Drawing.Point(27, 40);
            this.BackButton.MinimumSize = new System.Drawing.Size(22, 23);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(22, 23);
            this.BackButton.TabIndex = 9;
            this.BackButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BackButton_MouseClick);
            // 
            // ItemsPanel
            // 
            this.ItemsPanel.AutoScroll = true;
            this.ItemsPanel.BackColor = System.Drawing.Color.Transparent;
            this.ItemsPanel.Location = new System.Drawing.Point(21, 105);
            this.ItemsPanel.Name = "ItemsPanel";
            this.ItemsPanel.Size = new System.Drawing.Size(410, 313);
            this.ItemsPanel.TabIndex = 7;
            this.ItemsPanel.Click += new System.EventHandler(this.ItemsPanel_Click);
            this.ItemsPanel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ItemsPanel_MouseClick);
            this.ItemsPanel.MouseCaptureChanged += new System.EventHandler(this.ItemsPanel_MouseCaptureChanged);
            this.ItemsPanel.ChangeUICues += new System.Windows.Forms.UICuesEventHandler(this.ItemsPanel_ChangeUICues);
            // 
            // SearchMsg
            // 
            this.SearchMsg.AutoSize = true;
            this.SearchMsg.BackColor = System.Drawing.Color.Transparent;
            this.SearchMsg.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchMsg.ForeColor = System.Drawing.Color.White;
            this.SearchMsg.Location = new System.Drawing.Point(25, 81);
            this.SearchMsg.Name = "SearchMsg";
            this.SearchMsg.Size = new System.Drawing.Size(162, 28);
            this.SearchMsg.TabIndex = 0;
            this.SearchMsg.Text = "Results for 3080Ti :";
            this.SearchMsg.Click += new System.EventHandler(this.label18_Click);
            // 
            // ListNameBox
            // 
            this.ListNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.ListNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListNameBox.CausesValidation = false;
            this.ListNameBox.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListNameBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(138)))), ((int)(((byte)(163)))));
            this.ListNameBox.Location = new System.Drawing.Point(28, 830);
            this.ListNameBox.Name = "ListNameBox";
            this.ListNameBox.Size = new System.Drawing.Size(179, 24);
            this.ListNameBox.TabIndex = 10;
            this.ListNameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ListNameBox_MouseClick);
            // 
            // ListNameLabel
            // 
            this.ListNameLabel.AutoSize = true;
            this.ListNameLabel.BackColor = System.Drawing.Color.Transparent;
            this.ListNameLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ListNameLabel.ForeColor = System.Drawing.Color.White;
            this.ListNameLabel.Location = new System.Drawing.Point(23, 799);
            this.ListNameLabel.Name = "ListNameLabel";
            this.ListNameLabel.Size = new System.Drawing.Size(185, 28);
            this.ListNameLabel.TabIndex = 0;
            this.ListNameLabel.Text = "Enter desktop name :";
            // 
            // FormBuild
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(687, 430);
            this.Controls.Add(this.ItemsPanel);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SearchMsg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBuild";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBuild";
            this.Load += new System.EventHandler(this.FormBuild_Load);
            this.Click += new System.EventHandler(this.FormBuild_Click);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private RoundLabel MEMAdd;
        private RoundLabel GPUAdd;
        private RoundLabel CPUAdd;
        private System.Windows.Forms.Label MEMLabel;
        private System.Windows.Forms.Label CPULabel;
        private System.Windows.Forms.Label GPULabel;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label CPUCLabel;
        private System.Windows.Forms.Label PSLabel;
        private System.Windows.Forms.Label STGLabel;
        private System.Windows.Forms.Label MBLabel;
        private System.Windows.Forms.Label CASELabel;
        private RoundLabel CASEAdd;
        private RoundLabel CPUCAdd;
        private RoundLabel PSAdd;
        private RoundLabel STGAdd;
        private RoundLabel MBAdd;
        private RoundLabel SaveButton;
        private System.Windows.Forms.Label ResetButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Label SearchButton;
        private System.Windows.Forms.Label BackButton;
        private System.Windows.Forms.FlowLayoutPanel ItemsPanel;
        private System.Windows.Forms.Label ErrorMsg;
        private System.Windows.Forms.Label SearchMsg;
        private System.Windows.Forms.TextBox ListNameBox;
        private System.Windows.Forms.Label ListNameLabel;
    }
}