﻿namespace DoAnCNPM.LopGiaoDien
{
    partial class FormBanDieuHanh
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
            this.pnlPhanQuyen = new System.Windows.Forms.TableLayoutPanel();
            this.pnlFooter = new System.Windows.Forms.Panel();
            this.lblFooter = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.pnlTop = new System.Windows.Forms.TableLayoutPanel();
            this.pnlTextBox = new System.Windows.Forms.TableLayoutPanel();
            this.pnlMaSV = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaSV = new System.Windows.Forms.Label();
            this.txtMaSV = new System.Windows.Forms.TextBox();
            this.pnlNhiemKy = new System.Windows.Forms.TableLayoutPanel();
            this.cbxNhiemKy = new System.Windows.Forms.ComboBox();
            this.pnlManageTools = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlChucVu = new System.Windows.Forms.TableLayoutPanel();
            this.lblChucVu = new System.Windows.Forms.Label();
            this.cbxChucVu = new System.Windows.Forms.ComboBox();
            this.lblNhiemKy = new System.Windows.Forms.LinkLabel();
            this.pnlPhanQuyen.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlTextBox.SuspendLayout();
            this.pnlMaSV.SuspendLayout();
            this.pnlNhiemKy.SuspendLayout();
            this.pnlManageTools.SuspendLayout();
            this.pnlChucVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPhanQuyen
            // 
            this.pnlPhanQuyen.ColumnCount = 1;
            this.pnlPhanQuyen.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlPhanQuyen.Controls.Add(this.pnlFooter, 0, 2);
            this.pnlPhanQuyen.Controls.Add(this.dgvMain, 0, 1);
            this.pnlPhanQuyen.Controls.Add(this.pnlTop, 0, 0);
            this.pnlPhanQuyen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPhanQuyen.Location = new System.Drawing.Point(0, 0);
            this.pnlPhanQuyen.Margin = new System.Windows.Forms.Padding(0);
            this.pnlPhanQuyen.Name = "pnlPhanQuyen";
            this.pnlPhanQuyen.RowCount = 3;
            this.pnlPhanQuyen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 270F));
            this.pnlPhanQuyen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlPhanQuyen.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.pnlPhanQuyen.Size = new System.Drawing.Size(1028, 688);
            this.pnlPhanQuyen.TabIndex = 2;
            // 
            // pnlFooter
            // 
            this.pnlFooter.Controls.Add(this.lblFooter);
            this.pnlFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFooter.Location = new System.Drawing.Point(0, 658);
            this.pnlFooter.Margin = new System.Windows.Forms.Padding(0);
            this.pnlFooter.Name = "pnlFooter";
            this.pnlFooter.Size = new System.Drawing.Size(1028, 30);
            this.pnlFooter.TabIndex = 0;
            // 
            // lblFooter
            // 
            this.lblFooter.BackColor = System.Drawing.Color.Gray;
            this.lblFooter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblFooter.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblFooter.ForeColor = System.Drawing.Color.Black;
            this.lblFooter.Location = new System.Drawing.Point(0, 0);
            this.lblFooter.Name = "lblFooter";
            this.lblFooter.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.lblFooter.Size = new System.Drawing.Size(1028, 30);
            this.lblFooter.TabIndex = 0;
            this.lblFooter.Text = "Ban điều hành";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvMain
            // 
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 273);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(1022, 382);
            this.dgvMain.TabIndex = 1;
            // 
            // pnlTop
            // 
            this.pnlTop.ColumnCount = 3;
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTop.Controls.Add(this.pnlTextBox, 0, 0);
            this.pnlTop.Controls.Add(this.pnlManageTools, 2, 0);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RowCount = 1;
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTop.Size = new System.Drawing.Size(1022, 264);
            this.pnlTop.TabIndex = 4;
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.ColumnCount = 1;
            this.pnlTextBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTextBox.Controls.Add(this.pnlMaSV, 0, 0);
            this.pnlTextBox.Controls.Add(this.pnlNhiemKy, 0, 2);
            this.pnlTextBox.Controls.Add(this.pnlChucVu, 0, 1);
            this.pnlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextBox.Location = new System.Drawing.Point(3, 3);
            this.pnlTextBox.Name = "pnlTextBox";
            this.pnlTextBox.RowCount = 3;
            this.pnlTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.pnlTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.pnlTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.pnlTextBox.Size = new System.Drawing.Size(334, 258);
            this.pnlTextBox.TabIndex = 2;
            // 
            // pnlMaSV
            // 
            this.pnlMaSV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMaSV.AutoSize = true;
            this.pnlMaSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMaSV.ColumnCount = 2;
            this.pnlMaSV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140F));
            this.pnlMaSV.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMaSV.Controls.Add(this.lblMaSV, 0, 0);
            this.pnlMaSV.Controls.Add(this.txtMaSV, 1, 0);
            this.pnlMaSV.Location = new System.Drawing.Point(9, 31);
            this.pnlMaSV.Name = "pnlMaSV";
            this.pnlMaSV.RowCount = 1;
            this.pnlMaSV.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMaSV.Size = new System.Drawing.Size(316, 23);
            this.pnlMaSV.TabIndex = 2;
            // 
            // lblMaSV
            // 
            this.lblMaSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaSV.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMaSV.ForeColor = System.Drawing.Color.White;
            this.lblMaSV.Location = new System.Drawing.Point(3, 0);
            this.lblMaSV.Name = "lblMaSV";
            this.lblMaSV.Size = new System.Drawing.Size(134, 23);
            this.lblMaSV.TabIndex = 0;
            this.lblMaSV.Text = "Mã sinh viên";
            this.lblMaSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaSV
            // 
            this.txtMaSV.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaSV.Location = new System.Drawing.Point(140, 1);
            this.txtMaSV.Margin = new System.Windows.Forms.Padding(0);
            this.txtMaSV.Name = "txtMaSV";
            this.txtMaSV.Size = new System.Drawing.Size(176, 20);
            this.txtMaSV.TabIndex = 1;
            // 
            // pnlNhiemKy
            // 
            this.pnlNhiemKy.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlNhiemKy.AutoSize = true;
            this.pnlNhiemKy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlNhiemKy.ColumnCount = 2;
            this.pnlNhiemKy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.pnlNhiemKy.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlNhiemKy.Controls.Add(this.cbxNhiemKy, 1, 0);
            this.pnlNhiemKy.Controls.Add(this.lblNhiemKy, 0, 0);
            this.pnlNhiemKy.Location = new System.Drawing.Point(9, 198);
            this.pnlNhiemKy.Name = "pnlNhiemKy";
            this.pnlNhiemKy.RowCount = 1;
            this.pnlNhiemKy.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlNhiemKy.Size = new System.Drawing.Size(315, 32);
            this.pnlNhiemKy.TabIndex = 2;
            // 
            // cbxNhiemKy
            // 
            this.cbxNhiemKy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxNhiemKy.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbxNhiemKy.FormattingEnabled = true;
            this.cbxNhiemKy.Location = new System.Drawing.Point(100, 0);
            this.cbxNhiemKy.Margin = new System.Windows.Forms.Padding(0);
            this.cbxNhiemKy.Name = "cbxNhiemKy";
            this.cbxNhiemKy.Size = new System.Drawing.Size(215, 32);
            this.cbxNhiemKy.TabIndex = 1;
            // 
            // pnlManageTools
            // 
            this.pnlManageTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlManageTools.ColumnCount = 1;
            this.pnlManageTools.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlManageTools.Controls.Add(this.btnXoa, 0, 4);
            this.pnlManageTools.Controls.Add(this.btnHuy, 0, 3);
            this.pnlManageTools.Controls.Add(this.btnLuu, 0, 2);
            this.pnlManageTools.Controls.Add(this.btnCapNhat, 0, 1);
            this.pnlManageTools.Controls.Add(this.btnThem, 0, 0);
            this.pnlManageTools.Location = new System.Drawing.Point(343, 3);
            this.pnlManageTools.Name = "pnlManageTools";
            this.pnlManageTools.RowCount = 5;
            this.pnlManageTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlManageTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlManageTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlManageTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlManageTools.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.pnlManageTools.Size = new System.Drawing.Size(160, 258);
            this.pnlManageTools.TabIndex = 1;
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnXoa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnXoa.FlatAppearance.BorderSize = 0;
            this.btnXoa.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnXoa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnXoa.ForeColor = System.Drawing.Color.White;
            this.btnXoa.Image = global::DoAnCNPM.Properties.Resources.icon_xoa2;
            this.btnXoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnXoa.Location = new System.Drawing.Point(3, 207);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(154, 48);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnHuy
            // 
            this.btnHuy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnHuy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnHuy.FlatAppearance.BorderSize = 0;
            this.btnHuy.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnHuy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnHuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHuy.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = global::DoAnCNPM.Properties.Resources.icon_huy2;
            this.btnHuy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHuy.Location = new System.Drawing.Point(3, 156);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(154, 45);
            this.btnHuy.TabIndex = 3;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHuy.UseVisualStyleBackColor = false;
            // 
            // btnLuu
            // 
            this.btnLuu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnLuu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLuu.FlatAppearance.BorderSize = 0;
            this.btnLuu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnLuu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnLuu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLuu.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnLuu.ForeColor = System.Drawing.Color.White;
            this.btnLuu.Image = global::DoAnCNPM.Properties.Resources.icon_luu1;
            this.btnLuu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLuu.Location = new System.Drawing.Point(3, 105);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(154, 45);
            this.btnLuu.TabIndex = 2;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLuu.UseVisualStyleBackColor = false;
            // 
            // btnCapNhat
            // 
            this.btnCapNhat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCapNhat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCapNhat.FlatAppearance.BorderSize = 0;
            this.btnCapNhat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnCapNhat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnCapNhat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCapNhat.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnCapNhat.ForeColor = System.Drawing.Color.White;
            this.btnCapNhat.Image = global::DoAnCNPM.Properties.Resources.icon_sua2;
            this.btnCapNhat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCapNhat.Location = new System.Drawing.Point(3, 54);
            this.btnCapNhat.Name = "btnCapNhat";
            this.btnCapNhat.Size = new System.Drawing.Size(154, 45);
            this.btnCapNhat.TabIndex = 1;
            this.btnCapNhat.Text = "Cập nhật";
            this.btnCapNhat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCapNhat.UseVisualStyleBackColor = false;
            // 
            // btnThem
            // 
            this.btnThem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnThem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnThem.FlatAppearance.BorderSize = 0;
            this.btnThem.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnThem.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnThem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnThem.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnThem.ForeColor = System.Drawing.Color.White;
            this.btnThem.Image = global::DoAnCNPM.Properties.Resources.icon_them_2;
            this.btnThem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThem.Location = new System.Drawing.Point(3, 3);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(154, 45);
            this.btnThem.TabIndex = 0;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThem.UseVisualStyleBackColor = false;
            // 
            // pnlChucVu
            // 
            this.pnlChucVu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlChucVu.AutoSize = true;
            this.pnlChucVu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlChucVu.ColumnCount = 2;
            this.pnlChucVu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.pnlChucVu.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlChucVu.Controls.Add(this.lblChucVu, 0, 0);
            this.pnlChucVu.Controls.Add(this.cbxChucVu, 1, 0);
            this.pnlChucVu.Location = new System.Drawing.Point(8, 108);
            this.pnlChucVu.Name = "pnlChucVu";
            this.pnlChucVu.RowCount = 1;
            this.pnlChucVu.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlChucVu.Size = new System.Drawing.Size(317, 38);
            this.pnlChucVu.TabIndex = 2;
            // 
            // lblChucVu
            // 
            this.lblChucVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblChucVu.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblChucVu.ForeColor = System.Drawing.Color.White;
            this.lblChucVu.Location = new System.Drawing.Point(3, 0);
            this.lblChucVu.Name = "lblChucVu";
            this.lblChucVu.Size = new System.Drawing.Size(94, 38);
            this.lblChucVu.TabIndex = 0;
            this.lblChucVu.Text = "Chức vụ";
            this.lblChucVu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxChucVu
            // 
            this.cbxChucVu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxChucVu.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbxChucVu.FormattingEnabled = true;
            this.cbxChucVu.Location = new System.Drawing.Point(100, 3);
            this.cbxChucVu.Margin = new System.Windows.Forms.Padding(0);
            this.cbxChucVu.Name = "cbxChucVu";
            this.cbxChucVu.Size = new System.Drawing.Size(217, 32);
            this.cbxChucVu.TabIndex = 1;
            // 
            // lblNhiemKy
            // 
            this.lblNhiemKy.ActiveLinkColor = System.Drawing.Color.White;
            this.lblNhiemKy.AutoSize = true;
            this.lblNhiemKy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNhiemKy.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblNhiemKy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNhiemKy.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.lblNhiemKy.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lblNhiemKy.Location = new System.Drawing.Point(3, 0);
            this.lblNhiemKy.Name = "lblNhiemKy";
            this.lblNhiemKy.Size = new System.Drawing.Size(94, 32);
            this.lblNhiemKy.TabIndex = 2;
            this.lblNhiemKy.TabStop = true;
            this.lblNhiemKy.Text = "Nhiệm kỳ";
            this.lblNhiemKy.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblNhiemKy.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // FormBanDieuHanh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.pnlPhanQuyen);
            this.Name = "FormBanDieuHanh";
            this.Size = new System.Drawing.Size(1028, 688);
            this.pnlPhanQuyen.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlMaSV.ResumeLayout(false);
            this.pnlMaSV.PerformLayout();
            this.pnlNhiemKy.ResumeLayout(false);
            this.pnlNhiemKy.PerformLayout();
            this.pnlManageTools.ResumeLayout(false);
            this.pnlChucVu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlPhanQuyen;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.TableLayoutPanel pnlTop;
        private System.Windows.Forms.TableLayoutPanel pnlTextBox;
        private System.Windows.Forms.TableLayoutPanel pnlMaSV;
        private System.Windows.Forms.Label lblMaSV;
        private System.Windows.Forms.TextBox txtMaSV;
        private System.Windows.Forms.TableLayoutPanel pnlNhiemKy;
        private System.Windows.Forms.ComboBox cbxNhiemKy;
        private System.Windows.Forms.TableLayoutPanel pnlManageTools;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TableLayoutPanel pnlChucVu;
        private System.Windows.Forms.Label lblChucVu;
        private System.Windows.Forms.ComboBox cbxChucVu;
        private System.Windows.Forms.LinkLabel lblNhiemKy;
    }
}