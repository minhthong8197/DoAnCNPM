using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCNPM.LopGiaoDien;

namespace DoAnCNPM.LopGiaoDien
{
    public partial class FormMain : Form
    {
        FormDangNhap dangNhap;

        public FormMain()
        {
            InitializeComponent();
            dangNhap = new FormDangNhap();
            dangNhap.FormClosing += new FormClosingEventHandler(Xulydangnhap);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            if (this.pnlLeft.Width == 250)
            {
                this.pnlLeft.Width = 50;
                this.btnMore.Dock = DockStyle.Left;
                this.pnlLogo_Info.Visible = false;
                this.pnlMain.Width = 1228;
            }
            else if (this.pnlLeft.Width == 50)
            {
                this.pnlLeft.Width = 250;
                this.btnMore.Dock = DockStyle.Right;
                this.pnlLogo_Info.Visible = true;
                this.pnlMain.Width = 1028;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dangNhap.ShowDialog();
            this.pnlMain.Controls.Clear();
            FormCover cover = new FormCover();
            this.pnlMain.Controls.Add(cover);
            cover.Dock = DockStyle.Fill;
        }

        private void Xulydangnhap(object sender, EventArgs e)
        {

        }

        private void btnThanhVien_Click(object sender, EventArgs e)
        {
            if (this.pnlListThanhVien.Visible == true)
                this.pnlListThanhVien.Visible = false;
            else this.pnlListThanhVien.Visible = true;
        }

        private void btnChuongTrinh_Click(object sender, EventArgs e)
        {
            if (this.pnlListChuongTrinh.Visible == true)
                this.pnlListChuongTrinh.Visible = false;
            else this.pnlListChuongTrinh.Visible = true;
        }

        private void btnQuanLyKho_Click(object sender, EventArgs e)
        {
            if (this.pnlListQuanLyKho.Visible == true)
                this.pnlListQuanLyKho.Visible = false;
            else this.pnlListQuanLyKho.Visible = true;
        }

        private void btnDoiTruong_Click(object sender, EventArgs e)
        {
            if (this.pnlListDoiTruong.Visible == true)
                this.pnlListDoiTruong.Visible = false;
            else this.pnlListDoiTruong.Visible = true;
        }

        private void btnGioiThieu_Click(object sender, EventArgs e)
        {
            if (this.pnlListGioiThieu.Visible == true)
                this.pnlListGioiThieu.Visible = false;
            else this.pnlListGioiThieu.Visible = true;
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            FormPhanQuyen phanQuyen = new FormPhanQuyen();
            this.pnlMain.Controls.Add(phanQuyen);
            phanQuyen.Dock = DockStyle.Fill;
        }

        private void btnBanDieuHanh_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            FormBanDieuHanh banDieuHanh = new FormBanDieuHanh();
            this.pnlMain.Controls.Add(banDieuHanh);
            banDieuHanh.Dock = DockStyle.Fill;
        }

        private void btnDoiVien_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            FormDoiVien doiVien = new FormDoiVien();
            this.pnlMain.Controls.Add(doiVien);
            doiVien.Dock = DockStyle.Fill;
        }

        private void btnDsChuongTrinh_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            FormChuongTrinh formChuongTrinh = new FormChuongTrinh();
            this.pnlMain.Controls.Add(formChuongTrinh);
            formChuongTrinh.Dock = DockStyle.Fill;
        }

        private void btnVatDung_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            FormQuanLyKho formQuanLyKho = new FormQuanLyKho();
            this.pnlMain.Controls.Add(formQuanLyKho);
            formQuanLyKho.Dock = DockStyle.Fill;
        }

        private void btnCongTacVien_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            FormCongTacVien formCongTacVien = new FormCongTacVien();
            this.pnlMain.Controls.Add(formCongTacVien);
            formCongTacVien.Dock = DockStyle.Fill;
        }
    }
}
