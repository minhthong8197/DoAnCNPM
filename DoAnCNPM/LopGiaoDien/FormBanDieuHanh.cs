using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DoAnCNPM.LopNghiepVu;
namespace DoAnCNPM.LopGiaoDien
{
    public partial class FormBanDieuHanh : UserControl
    {
        NghiepVuBanDieuHanh nghiepvu = new NghiepVuBanDieuHanh();
        DataTable dt = null;
        public event EventHandler NeedReload;

        bool dangthem = false;
        public FormBanDieuHanh()
        {
            InitializeComponent();
        }

        private void btnThay_Click(object sender, EventArgs e)
        {
            if (this.pnlThayThe.Visible == false)
            {
                this.pnlThayThe.Visible = true;
                this.pnlBoloc.Visible = false;
            }
            else this.pnlThayThe.Visible = false;
        }
        private void btnThem_Click(object sender, EventArgs e)
        {
            //hàm ở cuối
        }


        private void btnLuu_Click(object sender, EventArgs e)
        {
            //hàm ở cuối
        }
        private void btnOKThayThe_Click(object sender, EventArgs e)
        {
        }
        static void conn_InfoMessage(object sender, SqlInfoMessageEventArgs e)
        {
            MessageBox.Show("Lỗi: " +
                e.Errors[0].Class.ToString() + ":" + e.Message);
        }
        private void btnHuy_Click(object sender, EventArgs e)
        {
            //hàm ở cuối
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
                if (dgvMain.Rows[r].Cells[1].Value == null) this.cbxChucVu.Text = "";
                else this.cbxChucVu.Text = dgvMain.Rows[r].Cells[1].Value.ToString();
            }
            catch { }

            try
            {
                if (dgvMain.Rows[r].Cells[2].Value == null) this.cbxNhiemKy.Text = "";
                else this.cbxNhiemKy.Text = dgvMain.Rows[r].Cells[6].Value.ToString();
            }
            catch { }


        }
        private void cbxNhiemKy_Click(object sender, EventArgs e)
        {
            //
        }

        private void cbxNhiemKy_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }
        private void cbxNhiemKy_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        void FormLoad()
        {
            //vô hiệu hóa btn
            this.btnLuu.Enabled = false;
            this.btnHuy.Enabled = false;
            //khởi động các btn
            this.btnThem.Enabled = true;
            //điều chỉnh dữ liệu trong panel

            //vô hiệu hóa panel
            this.pnlMaSV.Enabled = false;
            this.pnlChucVu.Enabled = false;

            this.pnlNhiemKy.Enabled = true;
            //xóa các biến cờ
            this.dangthem = false;
            try {
                cbxNhiemKy.DataSource = nghiepvu.DanhsachNhiemky();
                cbxNhiemKy.DisplayMember = "NhiemKy";
                cbxNhiemKy.ValueMember = "NhiemKy";
                dgvMain.AutoResizeColumns();
            }
            catch
            {
                MessageBox.Show("Không load được dữ liệu");
            }
        }
        private void FormBanDieuHanh_Load(object sender, EventArgs e)
        {
            FormLoad();

        }

        private void cbxNhiemKy_SelectedValueChanged_1(object sender, EventArgs e)
        {
            if (cbxNhiemKy.SelectedValue.ToString() != "")
            {
                try
                {
                    string nhiemky = cbxNhiemKy.SelectedValue.ToString();
                    dgvMain.DataSource = nghiepvu.XemBDHTheoNhiemKy(Convert.ToInt32(nhiemky));
                    dgvMain.AutoResizeColumns();
                }
                catch
                {
                    //MessageBox.Show("Không load được thông tin Ban điều hành");
                }
            }
        }

        private void btnThem_Click_1(object sender, EventArgs e)
        {

            //khởi động panel
            this.pnlTextBox.Enabled = true;
            this.pnlMaSV.Enabled = true;
            this.pnlChucVu.Enabled = true;

            this.pnlMaSV.ResetText();
            this.pnlChucVu.ResetText();
            //khởi động cac btn
            this.btnLuu.Enabled = true;
            this.btnHuy.Enabled = true;
            //vô hiệu hóa cac btn
            this.btnThem.Enabled = false;
            //bật cờ hiệu đang thêm
            this.dangthem = true;
        }

        private void btnLuu_Click_1(object sender, EventArgs e)
        {

            if (this.txtMaSV.Text != "" && cbxNhiemKy.Text != "")
            {
                if (this.dangthem == true)
                {
                    try
                    {
                        nghiepvu.ThemBanDieuHanh(this.txtMaSV.Text, Convert.ToInt32(this.cbxNhiemKy.SelectedValue.ToString()), this.cbxChucVu.Text);
                        NeedReload.Invoke(this, e);
                        MessageBox.Show("Thêm thành công!");
                    }
                    catch (SqlException a)
                    {
                        MessageBox.Show(a.Message);
                        return;
                    }
                }
            }
            else if (this.txtMaSV.Text == "") MessageBox.Show("Bạn chưa điền mã sinh viên!");
            else if (this.cbxNhiemKy.Text == "") MessageBox.Show("Bạn chưa chọn khóa Đội viên!");
        }

        private void btnHuy_Click_1(object sender, EventArgs e)
        {
            NeedReload.Invoke(this, e);
        }

        private void btnOKThayThe_Click_1(object sender, EventArgs e)
        {

            if (txtMaSV1.Text.Length > 0 && txtMaSV2.Text.Length > 0)
            {
                try
                {
                    nghiepvu.ThayTheBanDieuHanh(Convert.ToInt32(cbxNhiemKy.SelectedValue.ToString()), txtMaSV1.Text, txtMaSV2.Text);
                }
                catch (SqlException a)
                {

                    MessageBox.Show(a.Message); ;
                }
            }
            else
                MessageBox.Show("Chưa điền đầy đủ thông tin");
            NeedReload.Invoke(this, e);
        }

        private void btnNhiemKyMoi_Click(object sender, EventArgs e)
        {
            nghiepvu.ThemNhiemKyMoi();
            MessageBox.Show("Đã thêm nhiệm kỳ mới!");
            NeedReload.Invoke(this, e);
        }
    }
}
