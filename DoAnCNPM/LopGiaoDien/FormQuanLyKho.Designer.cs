namespace DoAnCNPM.LopGiaoDien
{
    partial class FormQuanLyKho
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
            this.pnlMaVD = new System.Windows.Forms.TableLayoutPanel();
            this.lblMaVD = new System.Windows.Forms.Label();
            this.txtMaVD = new System.Windows.Forms.TextBox();
            this.pnlTenVD = new System.Windows.Forms.TableLayoutPanel();
            this.lblTenVD = new System.Windows.Forms.Label();
            this.txtTenVD = new System.Windows.Forms.TextBox();
            this.pnlSoLuong = new System.Windows.Forms.TableLayoutPanel();
            this.lblSoLuong = new System.Windows.Forms.Label();
            this.nmrSoLuong = new System.Windows.Forms.NumericUpDown();
            this.pnlDonVi = new System.Windows.Forms.TableLayoutPanel();
            this.lblDonVi = new System.Windows.Forms.Label();
            this.txtDonVi = new System.Windows.Forms.TextBox();
            this.pnlManageTools = new System.Windows.Forms.TableLayoutPanel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnCapNhat = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.pnlPhanQuyen.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlTextBox.SuspendLayout();
            this.pnlMaVD.SuspendLayout();
            this.pnlTenVD.SuspendLayout();
            this.pnlSoLuong.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).BeginInit();
            this.pnlDonVi.SuspendLayout();
            this.pnlManageTools.SuspendLayout();
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
            this.pnlPhanQuyen.TabIndex = 6;
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
            this.lblFooter.Text = "Quản lý kho";
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
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
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
            this.pnlTextBox.Controls.Add(this.pnlMaVD, 0, 0);
            this.pnlTextBox.Controls.Add(this.pnlTenVD, 0, 1);
            this.pnlTextBox.Controls.Add(this.pnlSoLuong, 0, 2);
            this.pnlTextBox.Controls.Add(this.pnlDonVi, 0, 3);
            this.pnlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextBox.Location = new System.Drawing.Point(3, 3);
            this.pnlTextBox.Name = "pnlTextBox";
            this.pnlTextBox.RowCount = 4;
            this.pnlTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.pnlTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.pnlTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.pnlTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28F));
            this.pnlTextBox.Size = new System.Drawing.Size(334, 258);
            this.pnlTextBox.TabIndex = 2;
            // 
            // pnlMaVD
            // 
            this.pnlMaVD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlMaVD.AutoSize = true;
            this.pnlMaVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMaVD.ColumnCount = 2;
            this.pnlMaVD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlMaVD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMaVD.Controls.Add(this.lblMaVD, 0, 0);
            this.pnlMaVD.Controls.Add(this.txtMaVD, 1, 0);
            this.pnlMaVD.Location = new System.Drawing.Point(9, 17);
            this.pnlMaVD.Name = "pnlMaVD";
            this.pnlMaVD.RowCount = 1;
            this.pnlMaVD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlMaVD.Size = new System.Drawing.Size(316, 30);
            this.pnlMaVD.TabIndex = 2;
            // 
            // lblMaVD
            // 
            this.lblMaVD.AutoSize = true;
            this.lblMaVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMaVD.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblMaVD.ForeColor = System.Drawing.Color.White;
            this.lblMaVD.Location = new System.Drawing.Point(3, 0);
            this.lblMaVD.Name = "lblMaVD";
            this.lblMaVD.Size = new System.Drawing.Size(117, 30);
            this.lblMaVD.TabIndex = 0;
            this.lblMaVD.Text = "Mã vật dụng";
            this.lblMaVD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaVD
            // 
            this.txtMaVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtMaVD.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtMaVD.Location = new System.Drawing.Point(123, 0);
            this.txtMaVD.Margin = new System.Windows.Forms.Padding(0);
            this.txtMaVD.Name = "txtMaVD";
            this.txtMaVD.Size = new System.Drawing.Size(193, 30);
            this.txtMaVD.TabIndex = 1;
            // 
            // pnlTenVD
            // 
            this.pnlTenVD.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlTenVD.AutoSize = true;
            this.pnlTenVD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlTenVD.ColumnCount = 2;
            this.pnlTenVD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlTenVD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTenVD.Controls.Add(this.lblTenVD, 0, 0);
            this.pnlTenVD.Controls.Add(this.txtTenVD, 1, 0);
            this.pnlTenVD.Location = new System.Drawing.Point(9, 81);
            this.pnlTenVD.Name = "pnlTenVD";
            this.pnlTenVD.RowCount = 1;
            this.pnlTenVD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTenVD.Size = new System.Drawing.Size(315, 30);
            this.pnlTenVD.TabIndex = 2;
            // 
            // lblTenVD
            // 
            this.lblTenVD.AutoSize = true;
            this.lblTenVD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTenVD.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblTenVD.ForeColor = System.Drawing.Color.White;
            this.lblTenVD.Location = new System.Drawing.Point(3, 0);
            this.lblTenVD.Name = "lblTenVD";
            this.lblTenVD.Size = new System.Drawing.Size(123, 30);
            this.lblTenVD.TabIndex = 0;
            this.lblTenVD.Text = "Tên vật dụng";
            this.lblTenVD.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTenVD
            // 
            this.txtTenVD.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTenVD.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtTenVD.Location = new System.Drawing.Point(129, 0);
            this.txtTenVD.Margin = new System.Windows.Forms.Padding(0);
            this.txtTenVD.Name = "txtTenVD";
            this.txtTenVD.Size = new System.Drawing.Size(186, 30);
            this.txtTenVD.TabIndex = 1;
            // 
            // pnlSoLuong
            // 
            this.pnlSoLuong.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlSoLuong.AutoSize = true;
            this.pnlSoLuong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlSoLuong.ColumnCount = 2;
            this.pnlSoLuong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlSoLuong.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSoLuong.Controls.Add(this.lblSoLuong, 0, 0);
            this.pnlSoLuong.Controls.Add(this.nmrSoLuong, 1, 0);
            this.pnlSoLuong.Location = new System.Drawing.Point(9, 145);
            this.pnlSoLuong.Name = "pnlSoLuong";
            this.pnlSoLuong.RowCount = 1;
            this.pnlSoLuong.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlSoLuong.Size = new System.Drawing.Size(315, 30);
            this.pnlSoLuong.TabIndex = 2;
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.AutoSize = true;
            this.lblSoLuong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSoLuong.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblSoLuong.ForeColor = System.Drawing.Color.White;
            this.lblSoLuong.Location = new System.Drawing.Point(3, 0);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(88, 30);
            this.lblSoLuong.TabIndex = 0;
            this.lblSoLuong.Text = "Số lượng";
            this.lblSoLuong.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nmrSoLuong
            // 
            this.nmrSoLuong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.nmrSoLuong.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.nmrSoLuong.Location = new System.Drawing.Point(94, 0);
            this.nmrSoLuong.Margin = new System.Windows.Forms.Padding(0);
            this.nmrSoLuong.Name = "nmrSoLuong";
            this.nmrSoLuong.Size = new System.Drawing.Size(221, 30);
            this.nmrSoLuong.TabIndex = 1;
            this.nmrSoLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnlDonVi
            // 
            this.pnlDonVi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlDonVi.AutoSize = true;
            this.pnlDonVi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlDonVi.ColumnCount = 2;
            this.pnlDonVi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlDonVi.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlDonVi.Controls.Add(this.lblDonVi, 0, 0);
            this.pnlDonVi.Controls.Add(this.txtDonVi, 1, 0);
            this.pnlDonVi.Location = new System.Drawing.Point(9, 210);
            this.pnlDonVi.Name = "pnlDonVi";
            this.pnlDonVi.RowCount = 1;
            this.pnlDonVi.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlDonVi.Size = new System.Drawing.Size(316, 30);
            this.pnlDonVi.TabIndex = 2;
            // 
            // lblDonVi
            // 
            this.lblDonVi.AutoSize = true;
            this.lblDonVi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDonVi.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblDonVi.ForeColor = System.Drawing.Color.White;
            this.lblDonVi.Location = new System.Drawing.Point(3, 0);
            this.lblDonVi.Name = "lblDonVi";
            this.lblDonVi.Size = new System.Drawing.Size(65, 30);
            this.lblDonVi.TabIndex = 0;
            this.lblDonVi.Text = "Đơn vị";
            this.lblDonVi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtDonVi
            // 
            this.txtDonVi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonVi.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtDonVi.Location = new System.Drawing.Point(71, 0);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(0);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(245, 30);
            this.txtDonVi.TabIndex = 1;
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
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
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
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
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
            this.btnCapNhat.Click += new System.EventHandler(this.btnCapNhat_Click);
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
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // FormQuanLyKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.pnlPhanQuyen);
            this.Name = "FormQuanLyKho";
            this.Size = new System.Drawing.Size(1028, 688);
            this.Load += new System.EventHandler(this.FormQuanLyKho_Load);
            this.pnlPhanQuyen.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlMaVD.ResumeLayout(false);
            this.pnlMaVD.PerformLayout();
            this.pnlTenVD.ResumeLayout(false);
            this.pnlTenVD.PerformLayout();
            this.pnlSoLuong.ResumeLayout(false);
            this.pnlSoLuong.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nmrSoLuong)).EndInit();
            this.pnlDonVi.ResumeLayout(false);
            this.pnlDonVi.PerformLayout();
            this.pnlManageTools.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlPhanQuyen;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.TableLayoutPanel pnlTop;
        private System.Windows.Forms.TableLayoutPanel pnlTextBox;
        private System.Windows.Forms.TableLayoutPanel pnlMaVD;
        private System.Windows.Forms.Label lblMaVD;
        private System.Windows.Forms.TextBox txtMaVD;
        private System.Windows.Forms.TableLayoutPanel pnlTenVD;
        private System.Windows.Forms.Label lblTenVD;
        private System.Windows.Forms.TextBox txtTenVD;
        private System.Windows.Forms.TableLayoutPanel pnlSoLuong;
        private System.Windows.Forms.Label lblSoLuong;
        private System.Windows.Forms.NumericUpDown nmrSoLuong;
        private System.Windows.Forms.TableLayoutPanel pnlDonVi;
        private System.Windows.Forms.Label lblDonVi;
        private System.Windows.Forms.TextBox txtDonVi;
        private System.Windows.Forms.TableLayoutPanel pnlManageTools;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnCapNhat;
        private System.Windows.Forms.Button btnThem;
    }
}
