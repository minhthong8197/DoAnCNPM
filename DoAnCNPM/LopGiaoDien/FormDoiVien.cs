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
using System.Data.SqlClient;

namespace DoAnCNPM.LopGiaoDien
{
    public partial class FormDoiVien : UserControl
    {
        NghiepVuDoiVien nghiepvu = new NghiepVuDoiVien();
        DataTable ds = null;
        public event EventHandler NeedReload;
        FormTheDoiVien theDoiVien;

        //biến xử lí thao tác
        bool dangthem = false, dangcapnhat = false;

        public FormDoiVien()
        {
            InitializeComponent();
        }

        private void FormDoiVien_Load(object sender, EventArgs e)
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
            
            this.dtpNgaySinh.Value = dtpNgaySinh.MinDate;

            //vô hiệu hóa panel
            this.pnlTextBox.Enabled = false;
            //xóa các biến cờ
            this.dangthem = false;
            this.dangcapnhat = false;
            try
            {
                ds = nghiepvu.BangDoiVien();
                dgvMain.DataSource = ds;
                dgvMain.AutoResizeColumns();

                cbxKhoaDV.DataSource = nghiepvu.DsKhoaDV();
                cbxKhoaDV.DisplayMember = "KhoaDV";

                cbxNganh.DataSource = nghiepvu.DsNganh();
                cbxNganh.DisplayMember = "Nganh";

                cbxKhoa.DataSource = nghiepvu.DsKhoa();
                cbxKhoa.DisplayMember = "TenKhoa";
                cbxKhoa.ValueMember = "MaKhoa";

                cbxQueQuan.DataSource = nghiepvu.DsQueQuan();
                cbxQueQuan.DisplayMember = "QueQuan";
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
            if (this.txtMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Đội viên muốn xóa!");
                return;
            }
            DialogResult xoadialog;
            xoadialog = MessageBox.Show("Bạn thật sự muốn xóa Đội viên này!", ""
                , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (xoadialog == DialogResult.Yes)
            {
                try
                {
                    nghiepvu.XoaDoiVien(this.txtMaSV.Text);
                    NeedReload.Invoke(this, e);
                    MessageBox.Show("Đã xóa thành công!");
                }
                catch (SqlException a)
                {
                    MessageBox.Show(a.Message);
                }
             
            }
        }
        static void conn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show("Lỗi: " +
                e.Errors[0].Class.ToString() + ":" + e.Message);
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
                if (dgvMain.Rows[r].Cells[0].Value == null) this.txtMaSV.Text = "";
                else this.txtMaSV.Text = dgvMain.Rows[r].Cells[0].Value.ToString();
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[1].Value == null) this.txtHoTen.Text = "";
                else this.txtHoTen.Text = dgvMain.Rows[r].Cells[1].Value.ToString();
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[2].Value == null) this.dtpNgaySinh.Value = dtpNgaySinh.MinDate;
                else this.dtpNgaySinh.Value = System.Convert.ToDateTime(dgvMain.Rows[r].Cells[2].Value);
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[3].Value == null) this.cbxQueQuan.Text = "";
                else this.cbxQueQuan.Text = dgvMain.Rows[r].Cells[3].Value.ToString();
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[4].Value == null) this.cbxKhoa.Text = "";
                else this.cbxKhoa.Text = dgvMain.Rows[r].Cells[4].Value.ToString();
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[5].Value == null) this.cbxNganh.Text = "";
                else this.cbxNganh.Text = dgvMain.Rows[r].Cells[5].Value.ToString();
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[6].Value == null) this.cbxKhoaDV.Text = "";
                else this.cbxKhoaDV.Text = dgvMain.Rows[r].Cells[6].Value.ToString();
            }
            catch { }
        }

        private void btnTheDoiVien_Click(object sender, EventArgs e)
        {

            theDoiVien = new FormTheDoiVien(txtHoTen.Text, dtpNgaySinh.Value, txtMaSV.Text, cbxKhoa.Text, cbxKhoaDV.Text);
            theDoiVien.ShowDialog();

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (this.txtMaSV.Text != "" && cbxKhoaDV.Text != "")
            {
                if (this.dangthem == true)
                {
                    try
                    {
                        nghiepvu.ThemDoiVien(this.txtMaSV.Text, this.txtHoTen.Text,
                            this.dtpNgaySinh.Value, this.cbxQueQuan.Text, this.cbxNganh.Text,
                            this.cbxKhoa.SelectedValue.ToString(), this.cbxKhoaDV.Text);
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
                        nghiepvu.UpdateDoiVien(this.txtMaSV.Text, this.txtHoTen.Text,
                            this.dtpNgaySinh.Value, this.cbxQueQuan.Text, this.cbxNganh.Text,
                            this.cbxKhoa.SelectedValue.ToString(), this.cbxKhoaDV.Text);
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
            else if (this.txtMaSV.Text == "") MessageBox.Show("Bạn chưa điền mã sinh viên!");
            else if (this.cbxKhoaDV.Text == "") MessageBox.Show("Bạn chưa chọn khóa Đội viên!");
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            if (this.pnlBoloc.Visible == false)
            {
                this.pnlTimKiem.Visible = false;
                this.pnlBoloc.Visible = true;
                cbxLocKhoaDV.DataSource = nghiepvu.DsKhoaDV();
                cbxLocKhoaDV.DisplayMember = "KhoaDV";
                cbxLocKhoaDV.ResetText();

                cbxLocKhoa.DataSource = nghiepvu.DsKhoa();
                cbxLocKhoa.DisplayMember = "TenKhoa";
                cbxLocKhoa.ValueMember = "MaKhoa";
                cbxLocKhoa.ResetText();
                cbxLocKhoa.SelectedText = null;

                cbxLocNamSinh.DataSource = nghiepvu.DsNamSinh();
                cbxLocNamSinh.DisplayMember = "NamSinh";
                cbxLocNamSinh.ResetText();
            }
            else this.pnlBoloc.Visible = false;
        }

        private void btnOKTimKiem_Click(object sender, EventArgs e)
        {
            this.dgvMain.DataSource = nghiepvu.TimKiemDoiVien(this.txtTimKiem.Text);
        }

        private void btnOKLoc_Click(object sender, EventArgs e)
        {
            if (this.cbxLocKhoaDV.Text == "")
            {
                if(this.cbxLocKhoa.Text == "") 
                    this.dgvMain.DataSource = nghiepvu.LocDoiVien(cbxLocNamSinh.Text.ToString(), "", "");
                else this.dgvMain.DataSource = nghiepvu.LocDoiVien(cbxLocNamSinh.Text.ToString(), cbxLocKhoa.SelectedValue.ToString(), "");
            }
            else if (this.cbxLocKhoa.Text == "")
            {
                this.dgvMain.DataSource = nghiepvu.LocDoiVien(cbxLocNamSinh.Text.ToString(), "", cbxLocKhoaDV.Text.ToString());
            }
            else if (this.cbxLocNamSinh.Text == "")
            {
                if (this.cbxLocKhoa.Text == "")
                    this.dgvMain.DataSource = nghiepvu.LocDoiVien("", "", cbxLocKhoaDV.Text.ToString());
                else this.dgvMain.DataSource = nghiepvu.LocDoiVien("", cbxLocKhoa.SelectedValue.ToString(), cbxLocKhoaDV.Text.ToString());
            }
            else this.dgvMain.DataSource = nghiepvu.LocDoiVien(cbxLocNamSinh.Text.ToString(), cbxLocKhoa.SelectedValue.ToString(), cbxLocKhoaDV.Text.ToString());
        }

        //private void cbxLocKhoaDV_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.cbxLocKhoa.ResetText();
        //    this.cbxLocKhoa.SelectedText = null;
        //    this.cbxLocNamSinh.ResetText();
        //}

        //private void cbxLocKhoa_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.cbxLocNamSinh.ResetText();
        //    this.cbxLocKhoaDV.ResetText();
        //}

        //private void cbxLocNamSinh_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    this.cbxLocKhoa.ResetText();
        //    this.cbxLocKhoa.SelectedText = null;
        //    this.cbxLocKhoaDV.ResetText();
        //}

        private void btnXoaToanbo_Click(object sender, EventArgs e)
        {
            if (this.txtMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Đội viên muốn xóa!");
                return;
            }
            DialogResult xoadialog = MessageBox.Show("Bạn thật sự muốn xóa Đội viên này!", ""
                , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (xoadialog == DialogResult.Yes)
            {
                try
                {
                    nghiepvu.XoaToanBo(txtMaSV.Text.ToString());
                    NeedReload.Invoke(this, e);
                    MessageBox.Show("Đã xóa thành công!");
                }
                catch
                { MessageBox.Show("Đây là Đội viên trong Ban Điều hành, không thể xóa!"); }
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            if (this.pnlTimKiem.Visible == false)
            {
                this.pnlTimKiem.Visible = true;
                this.pnlBoloc.Visible = false;
            }
            else this.pnlTimKiem.Visible = false;
        }
    }
}
