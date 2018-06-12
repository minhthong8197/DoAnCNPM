using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using DoAnCNPM.LopNghiepVu;

namespace DoAnCNPM.LopNghiepVu
{
    class NghiepVuCongTacVien
    {
        DoiCTXHDataContext doiCTXH = new DoiCTXHDataContext(Dynamic_Connection.ConnectStr);

        public DataTable BangCongTacVien()
        {
            ConvertClass convert = new ConvertClass();
            var query = doiCTXH.fu_ds_CongTacVien();
            return convert.ToDataTable(doiCTXH, query);
        }

        public void ThemCongTacVien(string masv, string hoten, DateTime ngaysinh, string quequan, string nganh, string khoa)
        {
            string CKhoa;
            if (khoa == "") CKhoa = null;
            else CKhoa = khoa;
            doiCTXH.sp_ThemThanhVien(masv, hoten, ngaysinh, quequan, nganh, CKhoa, null);
        }

        public void XoaCongTacVien(string masv)
        {
            doiCTXH.usp_Xoa_Thanhvien(masv);
        }

        public void UpdateCongTacVien(string masv, string hoten, DateTime ngaysinh, string quequan, string nganh, string khoa)
        {
            string CKhoa;
            if (khoa == "") CKhoa = null;
            else CKhoa = khoa;
            doiCTXH.sp_UpdateThanhVien(masv, hoten, ngaysinh, quequan, nganh, CKhoa, null);
        }

        public object DsNganh()
        {
            var dsNganh = from n in doiCTXH.Thanhviens
                          group n by n.Nganh into g
                          select new
                          {
                              Nganh = g.Key,
                          };
            return dsNganh;
        }

        public object DsKhoa()
        {
            var dsKhoa = from kh in doiCTXH.Khoas
                         select new
                         {
                             MaKhoa = kh.Ma_Khoa,
                             TenKhoa = kh.Ten_Khoa
                         };
            return dsKhoa;
        }

        public object DsQueQuan()
        {
            var dsQueQuan = from tv in doiCTXH.Thanhviens
                            group tv by tv.Quequan into g
                            select new { QueQuan = g.Key };
            return dsQueQuan;
        }

        public string LayKhoaDVTheoNgay (DateTime input)
        {
            return doiCTXH.fu_LayKhoaDV(input).ToString();
        }

        public void KetNap(string MaSV,string MaKhoaDV)
        {
            doiCTXH.usp_Ketnap(MaSV,MaKhoaDV);
        }
        public void XoaToanBo(string MaSV)
        {
            doiCTXH.sp_XoaThongtin_Thanhvien(MaSV);
        }

        internal void ThemCongTacVien(string ma_SV, string hoten, DateTime? ngaysinh, string quequan, string nganh, string khoa)
        {
            throw new NotImplementedException();
        }

        public object DsNamSinh()
        {
            var dsNamSinh = from tv in doiCTXH.Thanhviens
                            group tv by tv.Ngaysinh.Value.Year into g
                            select new
                            {
                                NamSinh = g.Key.ToString()
                            };
            return dsNamSinh;
        }

        public DataTable LocCongTacVien(string Namsinh, string MaKhoa)
        {
            ConvertClass convert = new ConvertClass();
            if (Namsinh != "")
            {
                var query = doiCTXH.fu_Loc_CTV(int.Parse(Namsinh), MaKhoa);
                return convert.ToDataTable(doiCTXH, query);
            }
            else
            {
                var query = doiCTXH.fu_Loc_CTV(null, MaKhoa);
                return convert.ToDataTable(doiCTXH, query);
            }
        }

        public DataTable TimKiemCongTacVien(string hoten)
        {
            ConvertClass convert = new ConvertClass();
            var query = doiCTXH.fu_TimKiemCTV_TheoTen(hoten);
            return convert.ToDataTable(doiCTXH, query);
        }
    }
}
