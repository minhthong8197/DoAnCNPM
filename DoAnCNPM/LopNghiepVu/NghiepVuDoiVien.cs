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
    class NghiepVuDoiVien
    {
        DoiCTXHDataContext doiCTXH = new DoiCTXHDataContext(Dynamic_Connection.ConnectStr);

        public DataTable BangDoiVien()
        {
            ConvertClass convert = new ConvertClass();
            var query = doiCTXH.fu_ds_Doivien();
            return convert.ToDataTable(doiCTXH, query);
        }

        public void ThemDoiVien(string masv, string hoten, DateTime ngaysinh, string quequan, string nganh, string khoa, string khoaDV)
        {
            string CKhoa;
            if (khoa == "") CKhoa = null;
            else CKhoa = khoa;
            string CKhoaDV;
            if (khoaDV == "") CKhoaDV = null;
            else CKhoaDV = khoaDV;
            doiCTXH.sp_ThemThanhVien(masv,hoten,ngaysinh,quequan,nganh,CKhoa,CKhoaDV);
        }

        public void XoaDoiVien(string masv)
        {
            doiCTXH.usp_Xoa_Thanhvien(masv);
        }

        public void UpdateDoiVien(string masv, string hoten, DateTime ngaysinh, string quequan, string nganh, string khoa, string khoaDV)
        {
            string CKhoa;
            if (khoa == "") CKhoa = null;
            else CKhoa = khoa;
            string CKhoaDV;
            if (khoaDV == "") CKhoaDV = null;
            else CKhoaDV = khoaDV;
            doiCTXH.sp_UpdateThanhVien(masv, hoten, ngaysinh, quequan, nganh, CKhoa,CKhoaDV);
        }

        public DataTable TimKiemDoiVien(string hoten)
        {
            ConvertClass convert = new ConvertClass();
            var query = doiCTXH.fu_TimKiemDoiVien_TheoTen(hoten);
            return convert.ToDataTable(doiCTXH, query);
        }

        public object DsKhoaDV()
        {
            var dsKhoaDV = from tv in doiCTXH.Khoadoiviens
                           select new
                           {
                               KhoaDV = tv.Ma_Khoa,
                           };
            return dsKhoaDV;
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

        //public DataTable LocTheoKhoaDV(string makhoadv)
        //{
        //    ConvertClass convert = new ConvertClass();
        //    var query = doiCTXH.fu_Loc_TheoKhoaDV(makhoadv);
        //    return convert.ToDataTable(doiCTXH, query);
        //}

        //public DataTable LocTheoKhoa(string khoadaotao)
        //{
        //    ConvertClass convert = new ConvertClass();
        //    var query = doiCTXH.fu_Loc_TheoKhoahoc(khoadaotao);
        //    return convert.ToDataTable(doiCTXH, query);
        //}

        //public DataTable LocTheoNamSinh(string namsinh)
        //{
        //    int temp = int.Parse(namsinh);
        //    ConvertClass convert = new ConvertClass();
        //    var query = doiCTXH.fu_Loc_TheoNamsinh(temp);
        //    return convert.ToDataTable(doiCTXH, query);
        //}
        //Hàm dùng xóa Toàn bộ thông tin của một sinh viên, trừ BĐH

        public DataTable LocDoiVien(string Namsinh, string MaKhoa, string MaKhoaDV)
        {
            ConvertClass convert = new ConvertClass();
            if(Namsinh != "")
            {
                var query = doiCTXH.fu_Loc_DoiVien(int.Parse(Namsinh), MaKhoa, MaKhoaDV);
                return convert.ToDataTable(doiCTXH, query);
            }
            else
            {
                var query = doiCTXH.fu_Loc_DoiVien(null, MaKhoa, MaKhoaDV);
                return convert.ToDataTable(doiCTXH, query);
            }
        }

        public void XoaToanBo(string MaSV)
        {
            doiCTXH.sp_XoaThongtin_Thanhvien(MaSV);
        }
    }
}
