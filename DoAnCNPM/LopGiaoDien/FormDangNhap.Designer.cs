namespace DoAnCNPM.LopGiaoDien
{
    partial class FormDangNhap
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
            this.pnlBottom = new System.Windows.Forms.Panel();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.btnSignIn = new System.Windows.Forms.Button();
            this.pnlPassword = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.pnlUsername = new System.Windows.Forms.Panel();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.pnlTop = new System.Windows.Forms.Panel();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.pnlBottom.SuspendLayout();
            this.pnlBody.SuspendLayout();
            this.pnlPassword.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlBottom
            // 
            this.pnlBottom.Controls.Add(this.pnlBody);
            this.pnlBottom.Controls.Add(this.pnlFooter);
            this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlBottom.Location = new System.Drawing.Point(0, 125);
            this.pnlBottom.Name = "pnlBottom";
            this.pnlBottom.Size = new System.Drawing.Size(500, 409);
            this.pnlBottom.TabIndex = 0;
            // 
            // pnlBody
            // 
            this.pnlBody.BackColor = System.Drawing.Color.Gray;
            this.pnlBody.Controls.Add(this.btnSignIn);
            this.pnlBody.Controls.Add(this.pnlPassword);
            this.pnlBody.Controls.Add(this.pnlUsername);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlBody.Location = new System.Drawing.Point(0, 0);
            this.pnlBody.Margin = new System.Windows.Forms.Padding(0);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(30, 60, 30, 60);
            this.pnlBody.Size = new System.Drawing.Size(500, 330);
            this.pnlBody.TabIndex = 1;
            // 
            // btnSignIn
            // 
            this.btnSignIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSignIn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnSignIn.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnSignIn.FlatAppearance.BorderSize = 0;
            this.btnSignIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSignIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnSignIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSignIn.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold);
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Location = new System.Drawing.Point(30, 210);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.Size = new System.Drawing.Size(440, 60);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "Sign in";
            this.btnSignIn.UseVisualStyleBackColor = false;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // pnlPassword
            // 
            this.pnlPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlPassword.Controls.Add(this.txtPassword);
            this.pnlPassword.Location = new System.Drawing.Point(30, 134);
            this.pnlPassword.Name = "pnlPassword";
            this.pnlPassword.Padding = new System.Windows.Forms.Padding(15);
            this.pnlPassword.Size = new System.Drawing.Size(440, 60);
            this.pnlPassword.TabIndex = 4;
            // 
            // txtPassword
            // 
            this.txtPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPassword.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.ForeColor = System.Drawing.Color.White;
            this.txtPassword.Location = new System.Drawing.Point(15, 15);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(410, 29);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Text = "Password";
            // 
            // pnlUsername
            // 
            this.pnlUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlUsername.Controls.Add(this.txtUsername);
            this.pnlUsername.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUsername.Location = new System.Drawing.Point(30, 60);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.Padding = new System.Windows.Forms.Padding(15);
            this.pnlUsername.Size = new System.Drawing.Size(440, 60);
            this.pnlUsername.TabIndex = 2;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtUsername.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.ForeColor = System.Drawing.Color.White;
            this.txtUsername.Location = new System.Drawing.Point(15, 15);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(410, 29);
            this.txtUsername.TabIndex = 1;
            this.txtUsername.Text = "User name";
            // 
            // pnlFooter
            // 
            this.pnlFooter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlFooter.Controls.Add(this.btnClose);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlFooter.Location = new System.Drawing.Point(0, 329);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(500, 80);
            this.pnlFooter.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(444, 42);
            this.btnClose.Margin = new System.Windows.Forms.Padding(1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(55, 37);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Exit";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.Color.White;
            this.pnlTop.Controls.Add(this.picAvatar);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(500, 125);
            this.pnlTop.TabIndex = 1;
            // 
            // picAvatar
            // 
            this.picAvatar.BackColor = System.Drawing.Color.Transparent;
            this.picAvatar.Image = global::DoAnCNPM.Properties.Resources.icon_avatar_2;
            this.picAvatar.Location = new System.Drawing.Point(12, 12);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(476, 107);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAvatar.TabIndex = 0;
            this.picAvatar.TabStop = false;
            // 
            // FormDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 534);
            this.Controls.Add(this.pnlTop);
            this.Controls.Add(this.pnlBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormDangNhap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormDangNhap";
            this.pnlBottom.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            this.pnlPassword.ResumeLayout(false);
            this.pnlPassword.PerformLayout();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlFooter.ResumeLayout(false);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlBottom;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Button btnSignIn;
        private System.Windows.Forms.Panel pnlPassword;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Panel pnlUsername;
        private System.Windows.Forms.Panel pnlTop;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnClose;
    }
}