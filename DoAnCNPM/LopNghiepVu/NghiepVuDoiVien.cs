using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DoAnCNPM.LopNghiepVu
{
    class NghiepVuDoiVien
    {
        DoiCTXHDataContext doiCTXH = new DoiCTXHDataContext();
        string MaSinhVien;
        string HoTen;
        DateTime NgaySinh;
        string QueQuan;
        string Nganh;
        string Khoa;
        string KhoaDV;
        int kq;

        string temp;

        public Table<Thanhvien> LoadDoiVien()
        {
            //DataSet ds = new DataSet();
            return doiCTXH.Thanhviens;
        }

        public string test()
        {
            doiCTXH.sp_test(ref temp);
            return temp;
        }
    }
}
