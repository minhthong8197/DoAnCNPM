namespace DoAnCNPM.LopGiaoDien
{
    partial class frmDangNhap
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
            this.btnOK = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.pnlDienThongTin = new System.Windows.Forms.Panel();
            this.pnlDienThongTin.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(170, 124);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(78, 39);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.txtPassword.Location = new System.Drawing.Point(124, 53);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(239, 26);
            this.txtPassword.TabIndex = 17;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.txtUsername.Location = new System.Drawing.Point(124, 21);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(239, 26);
            this.txtUsername.TabIndex = 15;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblPassword.Location = new System.Drawing.Point(35, 56);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(69, 20);
            this.lblPassword.TabIndex = 16;
            this.lblPassword.Text = "Password";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(35, 24);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(75, 20);
            this.lblUsername.TabIndex = 14;
            this.lblUsername.Text = "User name";
            // 
            // pnlDienThongTin
            // 
            this.pnlDienThongTin.Controls.Add(this.txtUsername);
            this.pnlDienThongTin.Controls.Add(this.lblUsername);
            this.pnlDienThongTin.Controls.Add(this.txtPassword);
            this.pnlDienThongTin.Controls.Add(this.lblPassword);
            this.pnlDienThongTin.Location = new System.Drawing.Point(12, 12);
            this.pnlDienThongTin.Name = "pnlDienThongTin";
            this.pnlDienThongTin.Size = new System.Drawing.Size(399, 100);
            this.pnlDienThongTin.TabIndex = 20;
            // 
            // frmDangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 172);
            this.Controls.Add(this.pnlDienThongTin);
            this.Controls.Add(this.btnOK);
            this.Name = "frmDangNhap";
            this.Text = "Dang Nhap";
            this.pnlDienThongTin.ResumeLayout(false);
            this.pnlDienThongTin.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Panel pnlDienThongTin;
    }
}