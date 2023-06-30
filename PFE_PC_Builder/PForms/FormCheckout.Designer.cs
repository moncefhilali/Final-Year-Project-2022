
namespace PFE_PC_Builder.PForms
{
    partial class FormCheckout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCheckout));
            this.CheckoutButton = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Label();
            this.FullnameLabel = new System.Windows.Forms.Label();
            this.ItemLabel = new System.Windows.Forms.Label();
            this.TotalLabel = new System.Windows.Forms.Label();
            this.SubtotalLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CheckoutButton
            // 
            this.CheckoutButton.AutoSize = true;
            this.CheckoutButton.BackColor = System.Drawing.Color.Transparent;
            this.CheckoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckoutButton.Location = new System.Drawing.Point(29, 245);
            this.CheckoutButton.MinimumSize = new System.Drawing.Size(292, 30);
            this.CheckoutButton.Name = "CheckoutButton";
            this.CheckoutButton.Size = new System.Drawing.Size(292, 30);
            this.CheckoutButton.TabIndex = 0;
            this.CheckoutButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CheckoutButton_MouseClick);
            // 
            // CancelButton
            // 
            this.CancelButton.AutoSize = true;
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.Location = new System.Drawing.Point(29, 289);
            this.CancelButton.MinimumSize = new System.Drawing.Size(292, 30);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(292, 30);
            this.CancelButton.TabIndex = 1;
            this.CancelButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CancelButton_MouseClick);
            // 
            // FullnameLabel
            // 
            this.FullnameLabel.AutoSize = true;
            this.FullnameLabel.BackColor = System.Drawing.Color.Transparent;
            this.FullnameLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullnameLabel.ForeColor = System.Drawing.Color.White;
            this.FullnameLabel.Location = new System.Drawing.Point(177, 55);
            this.FullnameLabel.MinimumSize = new System.Drawing.Size(150, 0);
            this.FullnameLabel.Name = "FullnameLabel";
            this.FullnameLabel.Size = new System.Drawing.Size(150, 26);
            this.FullnameLabel.TabIndex = 2;
            this.FullnameLabel.Text = "Moncef EL HILALI";
            this.FullnameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ItemLabel
            // 
            this.ItemLabel.AutoSize = true;
            this.ItemLabel.BackColor = System.Drawing.Color.Transparent;
            this.ItemLabel.Font = new System.Drawing.Font("Poppins", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemLabel.ForeColor = System.Drawing.Color.White;
            this.ItemLabel.Location = new System.Drawing.Point(177, 73);
            this.ItemLabel.MinimumSize = new System.Drawing.Size(150, 0);
            this.ItemLabel.Name = "ItemLabel";
            this.ItemLabel.Size = new System.Drawing.Size(150, 26);
            this.ItemLabel.TabIndex = 3;
            this.ItemLabel.Text = "DESKTOP Intel I5";
            this.ItemLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TotalLabel
            // 
            this.TotalLabel.AutoSize = true;
            this.TotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalLabel.Font = new System.Drawing.Font("Poppins SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalLabel.ForeColor = System.Drawing.Color.White;
            this.TotalLabel.Location = new System.Drawing.Point(189, 188);
            this.TotalLabel.MinimumSize = new System.Drawing.Size(150, 48);
            this.TotalLabel.Name = "TotalLabel";
            this.TotalLabel.Size = new System.Drawing.Size(150, 48);
            this.TotalLabel.TabIndex = 5;
            this.TotalLabel.Text = "$ 1100.00";
            this.TotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // SubtotalLabel
            // 
            this.SubtotalLabel.AutoSize = true;
            this.SubtotalLabel.BackColor = System.Drawing.Color.Transparent;
            this.SubtotalLabel.Font = new System.Drawing.Font("Poppins", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubtotalLabel.ForeColor = System.Drawing.Color.White;
            this.SubtotalLabel.Location = new System.Drawing.Point(189, 92);
            this.SubtotalLabel.MinimumSize = new System.Drawing.Size(150, 48);
            this.SubtotalLabel.Name = "SubtotalLabel";
            this.SubtotalLabel.Size = new System.Drawing.Size(150, 48);
            this.SubtotalLabel.TabIndex = 6;
            this.SubtotalLabel.Text = "$ 1100.00";
            this.SubtotalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormCheckout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(350, 350);
            this.Controls.Add(this.SubtotalLabel);
            this.Controls.Add(this.TotalLabel);
            this.Controls.Add(this.ItemLabel);
            this.Controls.Add(this.FullnameLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.CheckoutButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCheckout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormCheckout";
            this.Load += new System.EventHandler(this.FormCheckout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label CheckoutButton;
        private System.Windows.Forms.Label CancelButton;
        private System.Windows.Forms.Label FullnameLabel;
        private System.Windows.Forms.Label ItemLabel;
        private System.Windows.Forms.Label TotalLabel;
        private System.Windows.Forms.Label SubtotalLabel;
    }
}