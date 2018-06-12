using System;
using System.Data;
using System.Windows.Forms;
using DoAnCNPM.LopNghiepVu;
using System.IO;
using OfficeOpenXml;

namespace DoAnCNPM.LopGiaoDien
{
    public partial class FormCongTacVien : UserControl
    {
        NghiepVuCongTacVien nghiepvu = new NghiepVuCongTacVien();
        DataTable ds = null;
        public event EventHandler NeedReload;

        //biến xử lí thao tác
        bool dangthem = false, dangcapnhat = false;

        public FormCongTacVien()
        {
            InitializeComponent();
        }

        private void FormCongTacVien_Load(object sender, EventArgs e)
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
                ds = nghiepvu.BangCongTacVien();
                dgvMain.DataSource = ds;
                dgvMain.AutoResizeColumns();

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
                MessageBox.Show("Vui lòng chọn Cộng tác viên muốn xóa!");
                return;
            }
            DialogResult xoadialog;
            xoadialog = MessageBox.Show("Bạn thật sự muốn xóa Cộng tác viên này!", ""
                , MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (xoadialog == DialogResult.Yes)
            {
                try
                {
                    nghiepvu.XoaCongTacVien(this.txtMaSV.Text);
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
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (this.txtMaSV.Text != "")
            {
                if (this.dangthem == true)
                {
                    try
                    {
                        nghiepvu.ThemCongTacVien(this.txtMaSV.Text, this.txtHoTen.Text,
                            this.dtpNgaySinh.Value, this.cbxQueQuan.Text, this.cbxNganh.Text,
                            this.cbxKhoa.SelectedValue.ToString());
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
                        nghiepvu.UpdateCongTacVien(this.txtMaSV.Text, this.txtHoTen.Text,
                            this.dtpNgaySinh.Value, this.cbxQueQuan.Text, this.cbxNganh.Text,
                            this.cbxKhoa.SelectedValue.ToString());
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
        }

        private void btnKetNap_Click(object sender, EventArgs e)
        {
            DateTime homnay = new DateTime();
            homnay = DateTime.Today;
            this.dtpNgayKetNap.Value = homnay;
            if (this.pnlKetNap.Visible == false)
            {
                this.pnlKetNap.Visible = true;
                this.pnlBoLoc.Visible = false;
                this.pnlTimKiem.Visible = false;
            }
            else this.pnlKetNap.Visible = false;
        }

        private void btnOKKetNap_Click(object sender, EventArgs e)
        {
            if (this.txtMaSV.Text == "")
            {
                MessageBox.Show("Bạn chưa nhập Mã sinh viên!");
                return;
            }
            try
            {
                nghiepvu.KetNap(txtMaSV.Text, txtMaKhoa.Text);
                NeedReload.Invoke(this, e);
                MessageBox.Show("Đã kết nạp " + this.txtHoTen.Text + "!");
            }
            catch { MessageBox.Show("Bị lỗi, không kết nạp được!"); }
        }

        private void dtpNgayKetNap_ValueChanged(object sender, EventArgs e)
        {
            string KhoaDV = nghiepvu.LayKhoaDVTheoNgay(this.dtpNgayKetNap.Value);
            this.txtMaKhoa.Text = KhoaDV;
        }

        private void btnXoaHoantoan_Click(object sender, EventArgs e)
        {
            if (this.txtMaSV.Text == "")
            {
                MessageBox.Show("Vui lòng chọn Cộng tác viên muốn xóa!");
                return;
            }
            DialogResult xoadialog = MessageBox.Show("Bạn thật sự muốn xóa Cộng tác viên này!", ""
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
                { MessageBox.Show("Xóa không thành công"); }
            }
        }

        private void btnImp_Click(object sender, EventArgs e)
        {
            //Lấy tên file
            string filename = "";
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
            {
                filename = of.FileName;
                MessageBox.Show(filename);
            }
            // Mở file
            if (filename != "")
            {
                try {
                    //Mở file excel
                    var package = new ExcelPackage(new FileStream(filename,FileMode.Open,FileAccess.ReadWrite));
                    //Lấy ra sheet để thao tác
                    ExcelWorksheet ws = package.Workbook.Worksheets[1];
                    //Duyệt từng dòng
                    for(int i = ws.Dimension.Start.Row+1; i<=ws.Dimension.End.Row; i++)
                    {
                        try
                        {
                            int j = 1; //Thứ tự cột
                            //Lấy ra các giá trị tương ứng
                            string MaSV = ws.Cells[i, j++].Value.ToString();
                            string Hoten = ws.Cells[i, j++].Value.ToString();
                            //Cột thứ 3 lưu ngày sinh
                            var birthdaytemp =ws.Cells[i, j++].Value;
                            DateTime birthday = new DateTime();
                            if (birthdaytemp != null)
                                birthday = (DateTime)birthdaytemp;
                            //Các cột tiếp theo
                            string Quequan = ws.Cells[i, j++].Value.ToString();
                            string Nganh = ws.Cells[i, j++].Value.ToString();
                            string Khoa = ws.Cells[i, j++].Value.ToString();

                           
                            //Lưu lại dữ liệu
                            nghiepvu.ThemCongTacVien(MaSV, Hoten, birthday, Quequan, Nganh, Khoa);
                        }
                        catch
                        {
                            MessageBox.Show("Xãy ra lỗi khi đọc dữ liệu từ dòng thứ "+ i.ToString());
                        }
                    }

                }
                catch
                {
                    MessageBox.Show("Lỗi trong quá trình đọc tập tin");
                }
            }
            else
            {
                MessageBox.Show("Chọn file dạng xls hoặc xlsx để nhập thông tin");
            }
            NeedReload.Invoke(this, e);
        }

        private void btnOKLoc_Click(object sender, EventArgs e)
        {
            if (this.cbxLocKhoa.Text == "")
            {
                this.dgvMain.DataSource = nghiepvu.LocCongTacVien(cbxLocNamSinh.Text.ToString(), "");
            }
            else if (this.cbxLocNamSinh.Text == "")
            {
                if (this.cbxLocKhoa.Text == "")
                    this.dgvMain.DataSource = nghiepvu.LocCongTacVien("", "");
                else this.dgvMain.DataSource = nghiepvu.LocCongTacVien("", cbxLocKhoa.SelectedValue.ToString());
            }
            else this.dgvMain.DataSource = nghiepvu.LocCongTacVien(cbxLocNamSinh.Text.ToString(), cbxLocKhoa.SelectedValue.ToString());
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            if (this.pnlTimKiem.Visible == false)
            {
                this.pnlTimKiem.Visible = true;
                this.pnlBoLoc.Visible = false;
                this.pnlKetNap.Visible = false;
            }
            else this.pnlTimKiem.Visible = false;
        }

        private void btnOKTimKiem_Click(object sender, EventArgs e)
        {
            this.dgvMain.DataSource = nghiepvu.TimKiemCongTacVien(this.txtTimKiem.Text);
        }

        private void btnBoLoc_Click(object sender, EventArgs e)
        {
            if (this.pnlBoLoc.Visible == false)
            {
                this.pnlBoLoc.Visible = true;
                this.pnlKetNap.Visible = false;
                this.pnlTimKiem.Visible = false;
                cbxLocKhoa.DataSource = nghiepvu.DsKhoa();
                cbxLocKhoa.DisplayMember = "TenKhoa";
                cbxLocKhoa.ValueMember = "MaKhoa";
                cbxLocKhoa.ResetText();
                cbxLocKhoa.SelectedText = null;

                cbxLocNamSinh.DataSource = nghiepvu.DsNamSinh();
                cbxLocNamSinh.DisplayMember = "NamSinh";
                cbxLocNamSinh.ResetText();
            }
            else this.pnlBoLoc.Visible = false;
        }
    }
}
