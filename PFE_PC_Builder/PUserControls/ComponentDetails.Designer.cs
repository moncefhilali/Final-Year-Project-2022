
namespace PFE_PC_Builder.PUserControls
{
    partial class ComponentDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ComponentDetails));
            this.PriceLabel = new System.Windows.Forms.Label();
            this.Option1Label = new System.Windows.Forms.Label();
            this.ItemPicture = new System.Windows.Forms.PictureBox();
            this.Option2Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.BackColor = System.Drawing.Color.Transparent;
            this.PriceLabel.Font = new System.Drawing.Font("Poppins SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLabel.ForeColor = System.Drawing.Color.White;
            this.PriceLabel.Location = new System.Drawing.Point(18, 170);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(71, 26);
            this.PriceLabel.TabIndex = 0;
            this.PriceLabel.Text = "$104.50";
            // 
            // Option1Label
            // 
            this.Option1Label.AutoSize = true;
            this.Option1Label.BackColor = System.Drawing.Color.Transparent;
            this.Option1Label.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option1Label.ForeColor = System.Drawing.Color.White;
            this.Option1Label.Location = new System.Drawing.Point(19, 197);
            this.Option1Label.Name = "Option1Label";
            this.Option1Label.Size = new System.Drawing.Size(142, 23);
            this.Option1Label.TabIndex = 0;
            this.Option1Label.Text = "Intel Core i5 10th Gen";
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
            // Option2Label
            // 
            this.Option2Label.AutoSize = true;
            this.Option2Label.BackColor = System.Drawing.Color.Transparent;
            this.Option2Label.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Option2Label.ForeColor = System.Drawing.Color.White;
            this.Option2Label.Location = new System.Drawing.Point(19, 220);
            this.Option2Label.Name = "Option2Label";
            this.Option2Label.Size = new System.Drawing.Size(135, 23);
            this.Option2Label.TabIndex = 0;
            this.Option2Label.Text = "Comet Lake 2.9 Ghz";
            // 
            // ComponentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.Controls.Add(this.ItemPicture);
            this.Controls.Add(this.Option2Label);
            this.Controls.Add(this.Option1Label);
            this.Controls.Add(this.PriceLabel);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "ComponentDetails";
            this.Size = new System.Drawing.Size(184, 253);
            this.Load += new System.EventHandler(this.ComponentDetails_Load);
            this.Click += new System.EventHandler(this.ComponentDetails_Click);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ComponentDetails_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.ItemPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label PriceLabel;
        private System.Windows.Forms.Label Option1Label;
        private System.Windows.Forms.PictureBox ItemPicture;
        private System.Windows.Forms.Label Option2Label;
    }
}
