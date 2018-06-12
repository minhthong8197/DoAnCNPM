using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoAnCNPM.LopNghiepVu
{
    class NghiepVuTheDoiVien
    {
        DoiCTXHDataContext doiCTXH = new DoiCTXHDataContext(Dynamic_Connection.ConnectStr);

        public string dateNgayKetNap(string ipkhoaDV)
        {
            var query = from k in doiCTXH.Khoadoiviens
                        where k.Ma_Khoa.ToString() == ipkhoaDV
                        select new { Ngay = k.Ngayketnap };
            return query.ToString();
        }

        public string stringNgaySinh(DateTime input)
        {
            string ngaySinh = input.Day.ToString() + "/" + input.Month.ToString()
                + "/" + input.Year.ToString();
            return ngaySinh;
        }

        public string stringNgayKetNap(string ipkhoaDV)
        {
            return doiCTXH.fu_ngayKetnap(ipkhoaDV);
        }
    }
}
