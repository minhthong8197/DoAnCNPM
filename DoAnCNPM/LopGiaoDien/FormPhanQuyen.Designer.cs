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
            this.pnlMiniWindow = new System.Windows.Forms.Panel();
            this.pnlDoipass = new System.Windows.Forms.TableLayoutPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnOKDoi = new System.Windows.Forms.Button();
            this.pnlNewPass = new System.Windows.Forms.TableLayoutPanel();
            this.linkLabel5 = new System.Windows.Forms.LinkLabel();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.cbxLogin = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.pnlTextBox = new System.Windows.Forms.TableLayoutPanel();
            this.pnlUsername = new System.Windows.Forms.TableLayoutPanel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.pnlVaiTro = new System.Windows.Forms.TableLayoutPanel();
            this.lblVaiTro = new System.Windows.Forms.Label();
            this.cbxVaiTro = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDoiPass = new System.Windows.Forms.Button();
            this.pnlPhanQuyen.SuspendLayout();
            this.pnlFooter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.pnlTop.SuspendLayout();
            this.pnlMiniWindow.SuspendLayout();
            this.pnlDoipass.SuspendLayout();
            this.panel3.SuspendLayout();
            this.pnlNewPass.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.pnlTextBox.SuspendLayout();
            this.pnlUsername.SuspendLayout();
            this.pnlVaiTro.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.pnlPhanQuyen.TabIndex = 1;
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
            this.lblFooter.Text = "Quản lý tải khoản";
            this.lblFooter.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dgvMain
            // 
            this.dgvMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMain.Location = new System.Drawing.Point(3, 273);
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.Size = new System.Drawing.Size(1022, 382);
            this.dgvMain.TabIndex = 1;
            this.dgvMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellClick);
            // 
            // pnlTop
            // 
            this.pnlTop.ColumnCount = 3;
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 487F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTop.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.pnlTop.Controls.Add(this.pnlMiniWindow, 1, 0);
            this.pnlTop.Controls.Add(this.pnlTextBox, 0, 0);
            this.pnlTop.Controls.Add(this.panel1, 2, 0);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTop.Location = new System.Drawing.Point(3, 3);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.RowCount = 1;
            this.pnlTop.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTop.Size = new System.Drawing.Size(1022, 264);
            this.pnlTop.TabIndex = 4;
            // 
            // pnlMiniWindow
            // 
            this.pnlMiniWindow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlMiniWindow.Controls.Add(this.pnlDoipass);
            this.pnlMiniWindow.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlMiniWindow.Location = new System.Drawing.Point(490, 0);
            this.pnlMiniWindow.Margin = new System.Windows.Forms.Padding(0);
            this.pnlMiniWindow.Name = "pnlMiniWindow";
            this.pnlMiniWindow.Size = new System.Drawing.Size(407, 264);
            this.pnlMiniWindow.TabIndex = 8;
            this.pnlMiniWindow.Visible = false;
            // 
            // pnlDoipass
            // 
            this.pnlDoipass.ColumnCount = 1;
            this.pnlDoipass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlDoipass.Controls.Add(this.panel3, 0, 2);
            this.pnlDoipass.Controls.Add(this.pnlNewPass, 0, 1);
            this.pnlDoipass.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.pnlDoipass.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlDoipass.Location = new System.Drawing.Point(0, 0);
            this.pnlDoipass.Margin = new System.Windows.Forms.Padding(0);
            this.pnlDoipass.Name = "pnlDoipass";
            this.pnlDoipass.Padding = new System.Windows.Forms.Padding(20, 0, 20, 0);
            this.pnlDoipass.RowCount = 3;
            this.pnlDoipass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlDoipass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlDoipass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.pnlDoipass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.pnlDoipass.Size = new System.Drawing.Size(407, 264);
            this.pnlDoipass.TabIndex = 6;
            this.pnlDoipass.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnOKDoi);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(20, 198);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 15);
            this.panel3.Size = new System.Drawing.Size(367, 66);
            this.panel3.TabIndex = 14;
            // 
            // btnOKDoi
            // 
            this.btnOKDoi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOKDoi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOKDoi.FlatAppearance.BorderSize = 0;
            this.btnOKDoi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnOKDoi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnOKDoi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOKDoi.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnOKDoi.Location = new System.Drawing.Point(0, 0);
            this.btnOKDoi.Name = "btnOKDoi";
            this.btnOKDoi.Size = new System.Drawing.Size(367, 51);
            this.btnOKDoi.TabIndex = 11;
            this.btnOKDoi.Text = "OK";
            this.btnOKDoi.UseVisualStyleBackColor = false;
            this.btnOKDoi.Click += new System.EventHandler(this.btnOKDoi_Click);
            // 
            // pnlNewPass
            // 
            this.pnlNewPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlNewPass.AutoSize = true;
            this.pnlNewPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlNewPass.ColumnCount = 3;
            this.pnlNewPass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlNewPass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlNewPass.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.pnlNewPass.Controls.Add(this.linkLabel5, 0, 0);
            this.pnlNewPass.Controls.Add(this.txtNewPass, 1, 0);
            this.pnlNewPass.Controls.Add(this.btnShow, 2, 0);
            this.pnlNewPass.Location = new System.Drawing.Point(23, 117);
            this.pnlNewPass.Name = "pnlNewPass";
            this.pnlNewPass.RowCount = 1;
            this.pnlNewPass.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlNewPass.Size = new System.Drawing.Size(361, 30);
            this.pnlNewPass.TabIndex = 3;
            // 
            // linkLabel5
            // 
            this.linkLabel5.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel5.AutoSize = true;
            this.linkLabel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel5.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel5.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel5.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel5.Location = new System.Drawing.Point(3, 0);
            this.linkLabel5.Name = "linkLabel5";
            this.linkLabel5.Size = new System.Drawing.Size(136, 30);
            this.linkLabel5.TabIndex = 2;
            this.linkLabel5.TabStop = true;
            this.linkLabel5.Text = "New password";
            this.linkLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel5.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // txtNewPass
            // 
            this.txtNewPass.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNewPass.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtNewPass.Location = new System.Drawing.Point(142, 0);
            this.txtNewPass.Margin = new System.Windows.Forms.Padding(0);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.PasswordChar = '*';
            this.txtNewPass.Size = new System.Drawing.Size(169, 30);
            this.txtNewPass.TabIndex = 3;
            // 
            // btnShow
            // 
            this.btnShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnShow.FlatAppearance.BorderSize = 0;
            this.btnShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShow.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.ForeColor = System.Drawing.Color.White;
            this.btnShow.Location = new System.Drawing.Point(311, 0);
            this.btnShow.Margin = new System.Windows.Forms.Padding(0);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(50, 30);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = false;
            this.btnShow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnShow_MouseDown);
            this.btnShow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.btnShow_MouseUp);
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel5.AutoSize = true;
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.cbxLogin, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.linkLabel1, 0, 0);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(23, 28);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(361, 32);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // cbxLogin
            // 
            this.cbxLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbxLogin.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbxLogin.FormattingEnabled = true;
            this.cbxLogin.Items.AddRange(new object[] {
            "DoiTruong",
            "BanDieuHanh"});
            this.cbxLogin.Location = new System.Drawing.Point(64, 0);
            this.cbxLogin.Margin = new System.Windows.Forms.Padding(0);
            this.cbxLogin.Name = "cbxLogin";
            this.cbxLogin.Size = new System.Drawing.Size(297, 32);
            this.cbxLogin.TabIndex = 1;
            // 
            // linkLabel1
            // 
            this.linkLabel1.ActiveLinkColor = System.Drawing.Color.White;
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.linkLabel1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.linkLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.NeverUnderline;
            this.linkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.linkLabel1.Location = new System.Drawing.Point(3, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(58, 32);
            this.linkLabel1.TabIndex = 2;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Login";
            this.linkLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.linkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            // 
            // pnlTextBox
            // 
            this.pnlTextBox.ColumnCount = 1;
            this.pnlTextBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlTextBox.Controls.Add(this.pnlUsername, 0, 0);
            this.pnlTextBox.Controls.Add(this.pnlVaiTro, 0, 1);
            this.pnlTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlTextBox.Location = new System.Drawing.Point(3, 3);
            this.pnlTextBox.Name = "pnlTextBox";
            this.pnlTextBox.Padding = new System.Windows.Forms.Padding(0, 40, 0, 40);
            this.pnlTextBox.RowCount = 2;
            this.pnlTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.3F));
            this.pnlTextBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.4F));
            this.pnlTextBox.Size = new System.Drawing.Size(481, 258);
            this.pnlTextBox.TabIndex = 2;
            // 
            // pnlUsername
            // 
            this.pnlUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlUsername.AutoSize = true;
            this.pnlUsername.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlUsername.ColumnCount = 2;
            this.pnlUsername.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlUsername.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlUsername.Controls.Add(this.lblUsername, 0, 0);
            this.pnlUsername.Controls.Add(this.txtUsername, 1, 0);
            this.pnlUsername.Location = new System.Drawing.Point(46, 69);
            this.pnlUsername.Name = "pnlUsername";
            this.pnlUsername.RowCount = 1;
            this.pnlUsername.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlUsername.Size = new System.Drawing.Size(388, 30);
            this.pnlUsername.TabIndex = 2;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblUsername.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(3, 0);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(97, 30);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            this.lblUsername.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtUsername
            // 
            this.txtUsername.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUsername.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.txtUsername.Location = new System.Drawing.Point(103, 0);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(0);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(285, 30);
            this.txtUsername.TabIndex = 1;
            // 
            // pnlVaiTro
            // 
            this.pnlVaiTro.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pnlVaiTro.AutoSize = true;
            this.pnlVaiTro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.pnlVaiTro.ColumnCount = 2;
            this.pnlVaiTro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.pnlVaiTro.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlVaiTro.Controls.Add(this.lblVaiTro, 0, 0);
            this.pnlVaiTro.Controls.Add(this.cbxVaiTro, 1, 0);
            this.pnlVaiTro.Location = new System.Drawing.Point(47, 157);
            this.pnlVaiTro.Name = "pnlVaiTro";
            this.pnlVaiTro.RowCount = 1;
            this.pnlVaiTro.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.pnlVaiTro.Size = new System.Drawing.Size(387, 32);
            this.pnlVaiTro.TabIndex = 2;
            // 
            // lblVaiTro
            // 
            this.lblVaiTro.AutoSize = true;
            this.lblVaiTro.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblVaiTro.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.lblVaiTro.ForeColor = System.Drawing.Color.White;
            this.lblVaiTro.Location = new System.Drawing.Point(3, 0);
            this.lblVaiTro.Name = "lblVaiTro";
            this.lblVaiTro.Size = new System.Drawing.Size(66, 32);
            this.lblVaiTro.TabIndex = 0;
            this.lblVaiTro.Text = "Vai trò";
            this.lblVaiTro.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxVaiTro
            // 
            this.cbxVaiTro.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.cbxVaiTro.FormattingEnabled = true;
            this.cbxVaiTro.Items.AddRange(new object[] {
            "Administrator",
            "BanDieuHanh"});
            this.cbxVaiTro.Location = new System.Drawing.Point(72, 0);
            this.cbxVaiTro.Margin = new System.Windows.Forms.Padding(0);
            this.cbxVaiTro.Name = "cbxVaiTro";
            this.cbxVaiTro.Size = new System.Drawing.Size(315, 32);
            this.cbxVaiTro.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnDoiPass);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(900, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(119, 258);
            this.panel1.TabIndex = 3;
            // 
            // btnDoiPass
            // 
            this.btnDoiPass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnDoiPass.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDoiPass.FlatAppearance.BorderSize = 0;
            this.btnDoiPass.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Purple;
            this.btnDoiPass.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Purple;
            this.btnDoiPass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoiPass.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnDoiPass.ForeColor = System.Drawing.Color.White;
            this.btnDoiPass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoiPass.Location = new System.Drawing.Point(0, 0);
            this.btnDoiPass.Name = "btnDoiPass";
            this.btnDoiPass.Size = new System.Drawing.Size(119, 76);
            this.btnDoiPass.TabIndex = 6;
            this.btnDoiPass.Text = "Đổi Password";
            this.btnDoiPass.UseVisualStyleBackColor = false;
            this.btnDoiPass.Click += new System.EventHandler(this.btnDoiPass_Click);
            // 
            // FormPhanQuyen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.Controls.Add(this.pnlPhanQuyen);
            this.Name = "FormPhanQuyen";
            this.Size = new System.Drawing.Size(1028, 688);
            this.Load += new System.EventHandler(this.FormPhanQuyen_Load);
            this.pnlPhanQuyen.ResumeLayout(false);
            this.pnlFooter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.pnlTop.ResumeLayout(false);
            this.pnlMiniWindow.ResumeLayout(false);
            this.pnlDoipass.ResumeLayout(false);
            this.pnlDoipass.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.pnlNewPass.ResumeLayout(false);
            this.pnlNewPass.PerformLayout();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.pnlTextBox.ResumeLayout(false);
            this.pnlTextBox.PerformLayout();
            this.pnlUsername.ResumeLayout(false);
            this.pnlUsername.PerformLayout();
            this.pnlVaiTro.ResumeLayout(false);
            this.pnlVaiTro.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel pnlPhanQuyen;
        private System.Windows.Forms.Panel pnlFooter;
        private System.Windows.Forms.Label lblFooter;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.TableLayoutPanel pnlTop;
        private System.Windows.Forms.TableLayoutPanel pnlTextBox;
        private System.Windows.Forms.TableLayoutPanel pnlVaiTro;
        private System.Windows.Forms.Label lblVaiTro;
        private System.Windows.Forms.TableLayoutPanel pnlUsername;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.ComboBox cbxVaiTro;
        private System.Windows.Forms.Panel pnlMiniWindow;
        private System.Windows.Forms.TableLayoutPanel pnlDoipass;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnOKDoi;
        private System.Windows.Forms.TableLayoutPanel pnlNewPass;
        private System.Windows.Forms.LinkLabel linkLabel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.ComboBox cbxLogin;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnDoiPass;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Button btnShow;
    }
}
