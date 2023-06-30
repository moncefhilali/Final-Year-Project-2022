
namespace PFE_PC_Builder.PForms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.PasswordBox = new System.Windows.Forms.TextBox();
            this.EmailBox = new System.Windows.Forms.TextBox();
            this.LoginButton = new System.Windows.Forms.Label();
            this.ErrorMsg = new System.Windows.Forms.Label();
            this.ForgotPWButton = new System.Windows.Forms.Label();
            this.toRegisterButton = new System.Windows.Forms.Label();
            this.ExitButton = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).BeginInit();
            this.SuspendLayout();
            // 
            // PasswordBox
            // 
            this.PasswordBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.PasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordBox.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordBox.ForeColor = System.Drawing.Color.White;
            this.PasswordBox.Location = new System.Drawing.Point(60, 278);
            this.PasswordBox.Name = "PasswordBox";
            this.PasswordBox.PasswordChar = '*';
            this.PasswordBox.Size = new System.Drawing.Size(163, 18);
            this.PasswordBox.TabIndex = 0;
            this.PasswordBox.TextChanged += new System.EventHandler(this.EmailBox_TextChanged);
            // 
            // EmailBox
            // 
            this.EmailBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(56)))), ((int)(((byte)(73)))));
            this.EmailBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.EmailBox.Font = new System.Drawing.Font("Poppins SemiBold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmailBox.ForeColor = System.Drawing.Color.White;
            this.EmailBox.Location = new System.Drawing.Point(61, 226);
            this.EmailBox.Name = "EmailBox";
            this.EmailBox.Size = new System.Drawing.Size(163, 18);
            this.EmailBox.TabIndex = 0;
            // 
            // LoginButton
            // 
            this.LoginButton.AutoSize = true;
            this.LoginButton.BackColor = System.Drawing.Color.Transparent;
            this.LoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LoginButton.Location = new System.Drawing.Point(54, 326);
            this.LoginButton.MinimumSize = new System.Drawing.Size(190, 26);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(190, 26);
            this.LoginButton.TabIndex = 1;
            this.LoginButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.label1_MouseClick);
            // 
            // ErrorMsg
            // 
            this.ErrorMsg.AutoSize = true;
            this.ErrorMsg.BackColor = System.Drawing.Color.Transparent;
            this.ErrorMsg.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.ErrorMsg.Location = new System.Drawing.Point(67, 304);
            this.ErrorMsg.Name = "ErrorMsg";
            this.ErrorMsg.Size = new System.Drawing.Size(165, 19);
            this.ErrorMsg.TabIndex = 2;
            this.ErrorMsg.Text = "Incorrect email or password.";
            // 
            // ForgotPWButton
            // 
            this.ForgotPWButton.AutoSize = true;
            this.ForgotPWButton.BackColor = System.Drawing.Color.Transparent;
            this.ForgotPWButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ForgotPWButton.Location = new System.Drawing.Point(109, 375);
            this.ForgotPWButton.MinimumSize = new System.Drawing.Size(80, 10);
            this.ForgotPWButton.Name = "ForgotPWButton";
            this.ForgotPWButton.Size = new System.Drawing.Size(80, 13);
            this.ForgotPWButton.TabIndex = 3;
            // 
            // toRegisterButton
            // 
            this.toRegisterButton.AutoSize = true;
            this.toRegisterButton.BackColor = System.Drawing.Color.Transparent;
            this.toRegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.toRegisterButton.Location = new System.Drawing.Point(138, 171);
            this.toRegisterButton.MinimumSize = new System.Drawing.Size(120, 10);
            this.toRegisterButton.Name = "toRegisterButton";
            this.toRegisterButton.Size = new System.Drawing.Size(120, 13);
            this.toRegisterButton.TabIndex = 4;
            this.toRegisterButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.CreateButton_MouseClick);
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
            this.ExitButton.TabIndex = 5;
            this.ExitButton.TabStop = false;
            this.ExitButton.Click += new System.EventHandler(this.ExitButton_Click);
            this.ExitButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ExitButton_MouseClick);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(297, 431);
            this.Controls.Add(this.ExitButton);
            this.Controls.Add(this.toRegisterButton);
            this.Controls.Add(this.ForgotPWButton);
            this.Controls.Add(this.ErrorMsg);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.EmailBox);
            this.Controls.Add(this.PasswordBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLogin";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ExitButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PasswordBox;
        private System.Windows.Forms.TextBox EmailBox;
        private System.Windows.Forms.Label LoginButton;
        private System.Windows.Forms.Label ErrorMsg;
        private System.Windows.Forms.Label ForgotPWButton;
        private System.Windows.Forms.Label toRegisterButton;
        private System.Windows.Forms.PictureBox ExitButton;
    }
}