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

namespace DoAnCNPM.LopNghiepVu
{
    class NghiepVuKhoVatDung
    {
        DoiCTXHDataContext doiCTXH = new DoiCTXHDataContext(Dynamic_Connection.ConnectStr);

        public DataTable BangVatDung()
        {
            ConvertClass convert = new ConvertClass();
            var query = doiCTXH.fu_Ds_KhoVatDung();
            return convert.ToDataTable(doiCTXH, query);
        }

        public void ThemVatDung(string mavd, string tenvd, string donvi, string soluong)
        {
            int CSoLuong = Convert.ToInt32(soluong);
            doiCTXH.sp_ThemVatDung(mavd, tenvd, donvi, CSoLuong);
        }

        public void XoaVatDung(string mavd)
        {
            doiCTXH.sp_XoaVatdung(mavd);
        }

        public void UpdateVatDung(string mavd, string tenvd, string donvi, string soluong)
        {
            int CSoLuong = Convert.ToInt32(soluong);
            doiCTXH.sp_UpdateVatDung(mavd, tenvd, donvi, CSoLuong);
        }
    }
}
