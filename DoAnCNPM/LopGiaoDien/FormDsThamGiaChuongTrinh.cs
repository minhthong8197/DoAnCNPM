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
using System.Data.SqlClient;
using System.IO;
using OfficeOpenXml;
namespace DoAnCNPM.LopGiaoDien
{
    public partial class FormDsThamGiaChuongTrinh : UserControl
    {
       
        DataTable dsCT = null;
        DataTable dsTG = null;
        NghiepVuChuongTrinh nghiepvu = new NghiepVuChuongTrinh();
        public string MaCT = "";
        public event EventHandler NeedReload;

        //biến xử lí thao tác
        bool dangthem = false, dangcapnhat = false;

        public FormDsThamGiaChuongTrinh()
        {
            InitializeComponent();
        }
        void FormLoad(string MaCT)
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
            this.pnlInfoMember.Enabled = false;
            //xóa các biến cờ
            this.dangthem = false;
            this.dangcapnhat = false;

            //Load dữ liệu
            try
            {
                dsCT = nghiepvu.BangChuongTrinh();
                cbxMaCT.DataSource = dsCT;
                cbxMaCT.DisplayMember = "Ma_CT";
                cbxMaCT.ValueMember = "Ma_CT";
            }
            catch
            {
                MessageBox.Show("Không load được dữ liệu chương trình này");
            }
        }

        private void cbxMaCT_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void cbxMaCT_SelectedValueChanged(object sender, EventArgs e)
        {
            //Kiểm tra giá trị trong comboxbox đã là Mã CT hay chưa?
            if (cbxMaCT.SelectedValue.ToString() != "")
            {
                try
                {
                    string MaCT = cbxMaCT.SelectedValue.ToString();
                    //Cập nhật thông tin tương ứng
                    txtTenCT.Text = nghiepvu.LayTenCT(MaCT);
                    txtSoluong.Text = nghiepvu.LaySoluongThamgia(MaCT).ToString();
                    //Lấy dữ liệu lên datagridview
                    dgvMain.DataSource = nghiepvu.LoadDsThamgiaCT(MaCT);
                    dgvMain.AutoResizeColumns();
                }
                catch
                {
                    MessageBox.Show("Không load Được thông tin");
                }
            }
            else
                MessageBox.Show("Chọn chương trình muốn xem danh sách");
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            //Bật các cờ và chức năng tương ứng
            dangthem = true;
            dangcapnhat = false;
            //
            pnlInfoMember.Enabled = true;
            pnlTextBox.Enabled = false;
            btnCapNhat.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            //
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            //
            txtMaSV.Text = "";
            txtDiemCTXH.Text = "";
            txtDanhgia.Text = "";
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            //Bật các cờ và chức năng tương ứng
            dangthem = false;
            dangcapnhat = true;
            //
            pnlInfoMember.Enabled = true;
            pnlTextBox.Enabled = false;
            btnThem.Enabled = false;
            btnXoa.Enabled = false;
            txtMaSV.Enabled = false;
            btnCapNhat.Enabled = false;
            //
            btnLuu.Enabled = true;
            btnHuy.Enabled = true;
            //
        }

        private void dgvMain_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Thứ tự dòng hiện hành
            int r = dgvMain.CurrentCell.RowIndex;
            //Đưa dữ liệu vào các ô tương ứng
            try
            {
                if (dgvMain.Rows[r].Cells[1].Value == null) this.txtMaSV.Text = "";
                else this.txtMaSV.Text = dgvMain.Rows[r].Cells[1].Value.ToString();
            }
            catch { }
            try
            {
                if (dgvMain.Rows[r].Cells[2].Value == null) this.txtDiemCTXH.Text = "";
                else this.txtDiemCTXH.Text = dgvMain.Rows[r].Cells[2].Value.ToString();
            }
            catch { }
            try
            {
                if (dgvMain.Rows[r].Cells[3].Value == null) this.txtDanhgia.Text = "";
                else this.txtDanhgia.Text = dgvMain.Rows[r].Cells[3].Value.ToString();
            }
            catch { }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            //Kiểm tra
            if (txtMaSV.Text.ToString() != "")
            {
                DialogResult kq = MessageBox.Show("Chắn chắn xóa sinh viên " + txtMaSV.Text.ToString() +
                                                    " khỏi danh sách CT " + txtTenCT.Text.ToString(),
                                                    "Xóa Tham gia", MessageBoxButtons.YesNo);
                if (kq == DialogResult.Yes)
                {
                    nghiepvu.XoaThamgiaCT(txtMaSV.Text.ToString(), cbxMaCT.SelectedValue.ToString());
                    
                }
            }
            else
            {
                MessageBox.Show("Chọn Sinh viên muốn xóa khỏi danh sách trước khi ấn xóa");
            }
            NeedReload.Invoke(this, e);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if(dangthem==true)
            {
                if(txtMaSV.Text.ToString()=="")
                {
                    MessageBox.Show("Nhập Mã sinh");
                }
                else
                {
                    try {
                        nghiepvu.SinhvienThamgiaCT(this.txtMaSV.Text.ToString(),
                                                    this.cbxMaCT.SelectedValue.ToString(),
                                                     this.txtDiemCTXH.Text.ToString(),
                                                     this.txtDanhgia.Text.ToString());
                        MessageBox.Show("Thêm thành công");
                        this.NeedReload(this, e);
                    }
                    catch (SqlException a)
                    {
                        MessageBox.Show(a.Message);
                    }
                }
            }
            else
            {
                if(dangcapnhat==true)
                {
                    string MaCT = cbxMaCT.SelectedValue.ToString();
                    
                    try
                    {
                        nghiepvu.CapNhatThamgia(MaCT, txtMaSV.Text.ToString(),
                                                txtDiemCTXH.Text.ToString(), txtDanhgia.Text.ToString());
                        MessageBox.Show("Cập nhật thông tin thành công");
                        NeedReload(this, e);
                    }
                    catch
                    {
                        MessageBox.Show("Cập nhật không thành công");
                    }
                }
                else
                {
                    MessageBox.Show("Chọn thông tin sinh viên cần cập nhật");
                }
            }
            NeedReload.Invoke(this, e);
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

        private void btnImp_Click(object sender, EventArgs e)
        {
            string filename = "";
            OpenFileDialog of = new OpenFileDialog();
            if (of.ShowDialog() == DialogResult.OK)
                filename = of.FileName;
            if(filename!="")
            {
                try
                {
                    //Đọc dữ liệu từ file excel
                    var package = new ExcelPackage(new FileStream(filename, FileMode.Open, FileAccess.ReadWrite));
                    //Lấy dữ liệu từ sheet đầu tiên
                    ExcelWorksheet ws = package.Workbook.Worksheets[1];

                    //Đọc dữ liệu
                    for(int i = ws.Dimension.Start.Row+1; i<= ws.Dimension.End.Row;i++)
                    {
                        try {
                            //Lấy dữ liệu từ từng cột
                            int j = 1;
                            string MaCT = ws.Cells[i, j++].Value.ToString();
                            string MaSV = ws.Cells[i, j++].Value.ToString();
                            string DiemCTXH = ws.Cells[i, j++].Value.ToString();
                            string Danhgia = ws.Cells[i, j++].Value.ToString();

                            nghiepvu.SinhvienThamgiaCT(MaSV, MaCT, DiemCTXH, Danhgia);
                        }
                        catch
                        {
                            MessageBox.Show("Không thể thêm thông tin tại dòng thứ " + i);
                        }
                    }
                }
                catch
                {
                    MessageBox.Show("Chọn file định dạng xls hoặc xlsx để nhập danh sách!");
                }
            }
            NeedReload.Invoke(this, e);
        }

        private void FormDsThamGiaChuongTrinh_Load(object sender, EventArgs e)
        {
            FormLoad(MaCT);
        }
    }
}
