using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCNPM.LopNghiepVu;

namespace DoAnCNPM.LopGiaoDien
{
    public partial class FormTheDoiVien : Form
    {
        NghiepVuTheDoiVien nghiepvu = new NghiepVuTheDoiVien();
        //cac bien ho tro xu li keo re form
        Boolean drag = false;
        int mousex;
        int mousey;

        public FormTheDoiVien(string hoten, DateTime ngaysinh, string mssv, string khoa, string khoaDV)
        {
            try {
                InitializeComponent();
                this.lblNgayKetNap.Text = nghiepvu.stringNgayKetNap(khoaDV).ToString();
                this.lblKhoa.Text = khoa;
                this.lblMSSV.Text = mssv;
                this.lblNgaySinh.Text = nghiepvu.stringNgaySinh(ngaysinh).ToString();
                this.lblHoten.Text = hoten;
            }
            catch
            {
               
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pnlTitleBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true)
            {
                this.Top = Cursor.Position.Y - mousey;
                this.Left = Cursor.Position.X - mousex;
            }
        }

        private void pnlTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - this.Left;
            mousey = Cursor.Position.Y - this.Top;
        }

        private void pnlTitleBar_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }
    }
}
