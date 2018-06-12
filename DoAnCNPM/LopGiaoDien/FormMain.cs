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
using DoAnCNPM.LopNghiepVu;
namespace DoAnCNPM.LopGiaoDien
{
    public partial class FormMain : Form
    {
        DoiCTXHDataContext doiCTXH = new DoiCTXHDataContext(Dynamic_Connection.ConnectStr);
        FormDangNhap dangNhap;
        FormBanDieuHanh banDieuHanh;
        FormChuongTrinh chuongTrinh;
        FormCongTacVien congTacVien;
        FormCover cover;
        FormDoiVien doiVien;
        FormPhanQuyen phanQuyen;
        FormQuanLyKho quanLyKho;
        FormDsThamGiaChuongTrinh dsthamgia;
        NghiepVuMain nghiepvu = new NghiepVuMain();
        
        //các biến hỗ trợ xử lí kéo rê form
        Boolean drag = false;
        int mousex;
        int mousey;
        //các biến cho biết tài khoản đang đăng nhập
        string User = "";

        public FormMain()
        {
            InitializeComponent();
            doiCTXH.Connection.Close();
            dangNhap = new FormDangNhap();
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
            cover = new FormCover();
            this.pnlMain.Controls.Add(cover);
            cover.Dock = DockStyle.Fill;
            if (nghiepvu.QuyenAdmin(Account.User) == false) this.pnlDoiTruong.Enabled = false;
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
            MessageBox.Show("Xem tại file hướng dẫn sử dụng!!!");
        }

        private void btnPhanQuyen_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            phanQuyen = new FormPhanQuyen();
            this.pnlMain.Controls.Add(phanQuyen);
            phanQuyen.Dock = DockStyle.Fill;
            phanQuyen.NeedReload += new EventHandler(btnPhanQuyen_Click);
        }

        private void btnBanDieuHanh_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            banDieuHanh = new FormBanDieuHanh();
            this.pnlMain.Controls.Add(banDieuHanh);
            banDieuHanh.Dock = DockStyle.Fill;
            banDieuHanh.NeedReload += new EventHandler(btnBanDieuHanh_Click);
        }

        private void btnDoiVien_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            doiVien = new FormDoiVien();
            this.pnlMain.Controls.Add(doiVien);
            doiVien.Dock = DockStyle.Fill;
            doiVien.NeedReload += new EventHandler(btnDoiVien_Click);
        }

        private void btnDsChuongTrinh_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            chuongTrinh = new FormChuongTrinh();
            this.pnlMain.Controls.Add(chuongTrinh);
            chuongTrinh.Dock = DockStyle.Fill;
            chuongTrinh.NeedReload += new EventHandler(btnDsChuongTrinh_Click);
        }

        private void btnVatDung_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            quanLyKho = new FormQuanLyKho();
            this.pnlMain.Controls.Add(quanLyKho);
            quanLyKho.Dock = DockStyle.Fill;
            quanLyKho.NeedReload += new EventHandler(btnVatDung_Click);
        }

        private void btnCongTacVien_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            congTacVien = new FormCongTacVien();
            this.pnlMain.Controls.Add(congTacVien);
            congTacVien.Dock = DockStyle.Fill;
            congTacVien.NeedReload += new EventHandler(btnCongTacVien_Click);
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag==true)
            {
                this.Top = Cursor.Position.Y - mousey;
                this.Left = Cursor.Position.X - mousex;
            }
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - this.Left;
            mousey = Cursor.Position.Y -this.Top;
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void btnDsThamGia_Click(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            dsthamgia = new FormDsThamGiaChuongTrinh();
            this.pnlMain.Controls.Add(dsthamgia);
            dsthamgia.Dock = DockStyle.Fill;
            dsthamgia.NeedReload += new EventHandler(btnDsThamGia_Click);
        }
    }
}
