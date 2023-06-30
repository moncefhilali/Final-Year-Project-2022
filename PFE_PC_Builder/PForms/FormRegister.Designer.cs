
namespace PFE_PC_Builder.PForms
{
    partial class FormRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRegister));
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.FNameBox = new System.Windows.Forms.TextBox();
            this.LNameBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Label();
            this.toLoginButton = new System.Windows.Forms.Label();
            this.ErrorMsg = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailBox.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.ForeColor = System.Drawing.Color.White;
            this.EmailBox.Location = new System.Drawing.Point(59, 226);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(163, 18);
            this.EmailBox.TabIndex = 1;
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.ForeColor = System.Drawing.Color.White;
            this.PasswordBox.Location = new System.Drawing.Point(58, 278);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(163, 18);
            this.PasswordBox.TabIndex = 2;
            // 
            // FNameBox
            // 
            this.FNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.FNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FNameBox.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FNameBox.ForeColor = System.Drawing.Color.White;
            this.FNameBox.Location = new System.Drawing.Point(58, 176);
            this.FNameBox.Name = "FNameBox";
            this.FNameBox.Size = new System.Drawing.Size(79, 18);
            this.FNameBox.TabIndex = 1;
            // 
            // LNameBox
            // 
            this.LNameBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.LNameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LNameBox.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LNameBox.ForeColor = System.Drawing.Color.White;
            this.LNameBox.Location = new System.Drawing.Point(163, 176);
            this.LNameBox.Name = "LNameBox";
            this.LNameBox.Size = new System.Drawing.Size(79, 18);
            this.LNameBox.TabIndex = 1;
            // 
            // RegisterButton
            // 
            this.RegisterButton.AutoSize = true;
            this.RegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.RegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RegisterButton.Location = new System.Drawing.Point(53, 326);
            this.RegisterButton.MinimumSize = new System.Drawing.Size(190, 26);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(190, 26);
            this.RegisterButton.TabIndex = 3;
            this.RegisterButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RegisterButton_MouseClick);
            // 
            // toLoginButton
            // 
            this.toLoginButton.AutoSize = true;
            this.toLoginButton.BackColor = System.Drawing.Color.Transparent;
            this.toLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toLoginButton.Location = new System.Drawing.Point(186, 378);
            this.toLoginButton.MinimumSize = new System.Drawing.Size(50, 10);
            this.toLoginButton.Name = "toLoginButton";
            this.toLoginButton.Size = new System.Drawing.Size(50, 13);
            this.toLoginButton.TabIndex = 4;
            this.toLoginButton.Click += new System.EventHandler(this.toLoginButton_Click);
            // 
            // ErrorMsg
            // 
            this.ErrorMsg.AutoSize = true;
            this.ErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.ErrorMsg.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsg.ForeColor = System.Drawing.Color.Green;
            this.ErrorMsg.Location = new System.Drawing.Point(39, 303);
            this.ErrorMsg.MinimumSize = new System.Drawing.Size(220, 19);
            this.ErrorMsg.Name = "ErrorMsg";
            this.ErrorMsg.Size = new System.Drawing.Size(220, 19);
            this.ErrorMsg.TabIndex = 5;
            this.ErrorMsg.Text = "Account has been created.";
            this.ErrorMsg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ExitButton
            // 
            this.ExitButton.BackColor = System.Drawing.Color.Transparent;
            this.ExitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExitButton.Image = ((System.Drawing.Image)(resources.GetObject("ExitButton.Image")));
            this.ExitButton.Location = new System.Drawing.Point(252, 21);
            this.ExitButton.Name = "ExitButton";
            this.ExitButton.Size = new System.Drawing.Size(24, 24);
            this.ExitButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.ExitButton.TabIndex = 6;
            this.ExitButton.TabStop = false;
            this.ExitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseClick);
            // 
            // FormRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(297, 431);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.ErrorMsg);
            this.Controls.Add(this.toLoginButton);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(this.LNameBox);
            this.Controls.Add(this.FNameBox);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PasswordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRegister";
            this.Load += new System.EventHandler(this.FormRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox FNameBox;
        private System.Windows.Forms.TextBox LNameBox;
        private System.Windows.Forms.Label RegisterButton;
        private System.Windows.Forms.Label toLoginButton;
        private System.Windows.Forms.Label ErrorMsg;
        private System.Windows.Forms.PictureBox ExitButton;
    }
}