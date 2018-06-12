using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnCNPM.LopNghiepVu;

namespace DoAnCNPM.LopGiaoDien
{
    public partial class FormQuanLyKho : UserControl
    {
        NghiepVuKhoVatDung nghiepvu = new NghiepVuKhoVatDung();
        DataTable ds = null;
        public event EventHandler NeedReload;

        //biến xử lí thao tác
        bool dangthem = false, dangcapnhat = false;

        public FormQuanLyKho()
        {
            InitializeComponent();
        }

        private void FormQuanLyKho_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void FormLoad()
        {
            //vô hiệu hóa btn
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            //khởi động các btn
            this.btnCapNhat.Enabled = true;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            //điều chỉnh dữ liệu trong panel

            //vô hiệu hóa panel
            this.pnlTextBox.Enabled = false;
            //xóa các biến cờ
            this.dangthem = false;
            this.dangcapnhat = false;
            try
            {
                ds = nghiepvu.BangVatDung();
                dgvMain.DataSource = ds;
                dgvMain.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Có lỗi! Không load được dữ liệu");
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //khởi động panel
            this.pnlTextBox.Enabled = true;
            //khởi động cac btn
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            //vô hiệu hóa cac btn
            this.btnThem.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnXoa.Enabled = false;
            //bật cờ hiệu đang thêm
            this.dangthem = true;
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //khoi dong panel
            this.pnlTextBox.Enabled = true;
            //khoi dong cac btn
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            //vo hieu hoa cac btn
            this.btnThem.Enabled = false;
            this.btnCapNhat.Enabled = false;
            this.btnXoa.Enabled = false;
            //bật cờ hiệu đang sửa
            this.dangcapnhat = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.txtMaVD.Text == "")
            {
                MessageBox.Show("Vui lòng chọn vật dụng muốn xóa!");
                return;
            }
            DialogResult xoadialog;
            xoadialog = MessageBox.Show("Bạn thật sự muốn xóa vật dụng này!", ""
                , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (xoadialog == DialogResult.Yes)
            {
                try
                {
                    nghiepvu.XoaVatDung(this.txtMaVD.Text);
                    NeedReload.Invoke(this, e);
                    MessageBox.Show("Đã xóa thành công!");
                }
                catch
                { MessageBox.Show("Đã xảy ra lỗi, không xóa được!"); }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            NeedReload.Invoke(this, e);
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvMain.CurrentCell.RowIndex;
            // Chuyển thông tin lên panel
            try
            {
                if (dgvMain.Rows[r].Cells[0].Value == null) this.txtMaVD.Text = "";
                else this.txtMaVD.Text = dgvMain.Rows[r].Cells[0].Value.ToString();
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[1].Value == null) this.txtTenVD.Text = "";
                else this.txtTenVD.Text = dgvMain.Rows[r].Cells[1].Value.ToString();
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[2].Value == null) this.txtDonVi.Text = "";
                else this.txtDonVi.Text = dgvMain.Rows[r].Cells[2].Value.ToString();
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[3].Value == null) this.nmrSoLuong.Value = 0;
                else this.nmrSoLuong.Value = Convert.ToInt32(dgvMain.Rows[r].Cells[3].Value);
            }
            catch { }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (this.txtMaVD.Text != "")
            {
                if (this.dangthem == true)
                {
                    try
                    {
                        nghiepvu.ThemVatDung(this.txtMaVD.Text, this.txtTenVD.Text,
                            this.txtDonVi.Text, this.nmrSoLuong.Text);
                        NeedReload.Invoke(this, e);
                        MessageBox.Show("Thêm thành công!");
                    }
                    catch
                    {
                        MessageBox.Show("Xảy ra lỗi!");
                        return;
                    }
                }
                else if (this.dangcapnhat == true)
                {
                    try
                    {
                        nghiepvu.UpdateVatDung(this.txtMaVD.Text, this.txtTenVD.Text,
                            this.txtDonVi.Text, this.nmrSoLuong.Text);
                        NeedReload.Invoke(this, e);
                        MessageBox.Show("Cập nhật thành công!");
                    }
                    catch
                    {
                        MessageBox.Show("Xảy ra lỗi!");
                        return;
                    }
                }
            }
            else if (this.txtMaVD.Text == "") MessageBox.Show("Bạn chưa điền mã vật dụng!");
        }
    }
}
