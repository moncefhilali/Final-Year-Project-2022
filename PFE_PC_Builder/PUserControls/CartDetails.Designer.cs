
namespace PFE_PC_Builder.PUserControls
{
    partial class CartDetails
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CartDetails));
            this.TotalLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.ItemPicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.Color.White;
            this.TotalLabel.Location = new System.Drawing.Point(18, 170);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(71, 26);
            this.TotalLabel.TabIndex = 0;
            this.TotalLabel.Text = "$104.50";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.BackColor = System.Drawing.Color.Transparent;
            this.NameLabel.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(19, 197);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(142, 23);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Intel Core i5 10th Gen";
            // 
            // ItemPicture
            // 
            this.ItemPicture.BackColor = System.Drawing.Color.Transparent;
            this.ItemPicture.Location = new System.Drawing.Point(41, 34);
            this.ItemPicture.Name = "ItemPicture";
            this.ItemPicture.Size = new System.Drawing.Size(106, 106);
            this.ItemPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ItemPicture.TabIndex = 1;
            this.ItemPicture.TabStop = false;
            // 
            // CartDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.ItemPicture);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.TotalLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "CartDetails";
            this.Size = new System.Drawing.Size(184, 229);
            this.Load += new System.EventHandler(this.CartDetails_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CartDetails_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox ItemPicture;
    }
}
