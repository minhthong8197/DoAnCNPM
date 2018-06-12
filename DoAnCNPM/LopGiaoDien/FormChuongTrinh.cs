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
using System.Data.Linq;

namespace DoAnCNPM.LopGiaoDien
{
    public partial class FormChuongTrinh : UserControl
    {
        NghiepVuChuongTrinh nghiepvu = new NghiepVuChuongTrinh();
        DataTable ds = null;
        public event EventHandler NeedReload;

        //biến xử lí thao tác
        bool dangthem = false, dangcapnhat = false;

        public FormChuongTrinh()
        {
            InitializeComponent();
        }

        private void FormChuongTrinh_Load(object sender, EventArgs e)
        {
            FormLoad();
        }

        private void FormLoad()
        {
            //vô hiệu hóa btn
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            this.txtTenCT.Enabled = false;
            //khởi động các btn
            this.btnCapNhat.Enabled = true;
            this.btnThem.Enabled = true;
            this.btnXoa.Enabled = true;
            //điều chỉnh dữ liệu trong panel

            this.dtpNgayToChuc.Value = dtpNgayToChuc.MinDate;

            //vô hiệu hóa panel
            this.pnlTextBox.Enabled = false;
            //xóa các biến cờ
            this.dangthem = false;
            this.dangcapnhat = false;
            try
            {
                ds = nghiepvu.BangChuongTrinh();
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
            if (this.txtMaCT.Text == "")
            {
                MessageBox.Show("Vui lòng chọn chương trình muốn xóa!");
                return;
            }
            DialogResult xoadialog;
            xoadialog = MessageBox.Show("Bạn thật sự muốn xóa chương trình này!", ""
                , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (xoadialog == DialogResult.Yes)
            {
                try
                {
                    nghiepvu.XoaChuongTrinh(this.txtMaCT.Text);
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
                if (dgvMain.Rows[r].Cells[0].Value == null) this.txtMaCT.Text = "";
                else this.txtMaCT.Text = dgvMain.Rows[r].Cells[0].Value.ToString();
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[1].Value == null) this.txtTenCT.Text = "";
                else this.txtTenCT.Text = dgvMain.Rows[r].Cells[1].Value.ToString();
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[2].Value == null) this.dtpNgayToChuc.Value = dtpNgayToChuc.MinDate;
                else this.dtpNgayToChuc.Value = System.Convert.ToDateTime(dgvMain.Rows[r].Cells[2].Value);
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[3].Value == null) this.txtDiaDiem.Text = "";
                else this.txtDiaDiem.Text = dgvMain.Rows[r].Cells[3].Value.ToString();
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[4].Value == null) this.txtKinhPhi.Text = "";
                else this.txtKinhPhi.Text = dgvMain.Rows[r].Cells[4].Value.ToString();
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[5].Value == null) this.txtDiemCTXH.Text = "";
                else this.txtDiemCTXH.Text = dgvMain.Rows[r].Cells[5].Value.ToString();
            }
            catch { }
        }

        private void txtMaCT_TextChanged(object sender, EventArgs e)
        {
            if(this.txtMaCT.Text != "")
                this.txtTenCT.Enabled = true;
            else this.txtTenCT.Enabled = false;
        }

        private void btnDsThamgia_Click(object sender, EventArgs e)
        {
           
                    
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (this.txtMaCT.Text != "")
            {
                if (this.dangthem == true)
                {
                    try
                    {
                        nghiepvu.ThemChuongTrinh(this.txtMaCT.Text, this.txtTenCT.Text,
                            this.dtpNgayToChuc.Value, this.txtDiaDiem.Text, this.txtKinhPhi.Text,
                            this.txtDiemCTXH.Text);
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
                        nghiepvu.UpdateChuongTrinh(this.txtMaCT.Text, this.txtTenCT.Text,
                            this.dtpNgayToChuc.Value, this.txtDiaDiem.Text, this.txtKinhPhi.Text,
                            this.txtDiemCTXH.Text);
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
            else if (this.txtMaCT.Text == "") MessageBox.Show("Bạn chưa điền mã chương trình!");
        }
    }
}
