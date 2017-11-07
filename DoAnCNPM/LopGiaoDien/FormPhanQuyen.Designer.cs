namespace DoAnCNPM.LopGiaoDien
{
    partial class FormPhanQuyen
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
            this.tblPhanQuyen = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblCurrentPosition = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.tblPhanQuyen.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.SuspendLayout();
            // 
            // tblPhanQuyen
            // 
            this.tblPhanQuyen.ColumnCount = 2;
            this.tblPhanQuyen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.33696F));
            this.tblPhanQuyen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.66304F));
            this.tblPhanQuyen.Controls.Add(this.pnlFooter, 0, 3);
            this.tblPhanQuyen.Controls.Add(this.dgvMain, 0, 2);
            this.tblPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPhanQuyen.Location = new System.Drawing.Point(0, 0);
            this.tblPhanQuyen.Margin = new System.Windows.Forms.Padding(0);
            this.tblPhanQuyen.Name = "tblPhanQuyen";
            this.tblPhanQuyen.RowCount = 4;
            this.tblPhanQuyen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 157F));
            this.tblPhanQuyen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 136F));
            this.tblPhanQuyen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tblPhanQuyen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tblPhanQuyen.Size = new System.Drawing.Size(1028, 688);
            this.tblPhanQuyen.TabIndex = 0;
            // 
            // pnlFooter
            // 
            this.tblPhanQuyen.SetColumnSpan(this.pnlFooter, 2);
            this.pnlFooter.Controls.Add(this.lblCurrentPosition);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(0, 658);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1028, 30);
            this.pnlFooter.TabIndex = 0;
            // 
            // lblCurrentPosition
            // 
            this.lblCurrentPosition.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblCurrentPosition.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblCurrentPosition.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblCurrentPosition.ForeColor = System.Drawing.Color.White;
            this.lblCurrentPosition.Location = new System.Drawing.Point(0, 0);
            this.lblCurrentPosition.Name = "lblCurrentPosition";
            this.lblCurrentPosition.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblCurrentPosition.Size = new System.Drawing.Size(1028, 30);
            this.lblCurrentPosition.TabIndex = 0;
            this.lblCurrentPosition.Text = "Quản lý tải khoản";
            this.lblCurrentPosition.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPhanQuyen.SetColumnSpan(this.dgvMain, 2);
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 296);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(1022, 359);
            this.dgvMain.TabIndex = 1;
            // 
            // FormPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 688);
            this.Controls.Add(this.tblPhanQuyen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormPhanQuyen";
            this.Text = "Quản lý tài khoản";
            this.tblPhanQuyen.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tblPhanQuyen;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblCurrentPosition;
        private System.Windows.Forms.DataGridView dgvMain;
    }
}