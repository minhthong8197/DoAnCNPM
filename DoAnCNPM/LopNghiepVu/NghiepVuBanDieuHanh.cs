using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Linq;
namespace DoAnCNPM.LopNghiepVu
{
    class NghiepVuBanDieuHanh
    {
        DoiCTXHDataContext doiCTXH = new DoiCTXHDataContext(Dynamic_Connection.ConnectStr);

        //public DataTable BangBanDieuHanh()
        //{
        //    ConvertClass convert = new ConvertClass();
        //    var query = doiCTXH.fu_ds_BanDieuHanh();
        //    return convert.ToDataTable(doiCTXH, query);
        //}

        public void ThemBanDieuHanh(string masv, int nhiemky, string chucvu)
        {
            doiCTXH.sp_ThamgiaBDH(masv, nhiemky, chucvu);
        }

        public DataTable DsNhiemKy()
        {
            ConvertClass convert = new ConvertClass();
            var query = doiCTXH.fu_Ds_Nhiemki();
            return convert.ToDataTable(doiCTXH, query);
        }

        public void ThemNhiemKyMoi()
        {
            doiCTXH.sp_ThemNhiemKy();
        }



        public void ThayTheBanDieuHanh(int nhiemky, string maSV1, string maSV2)
        {
            doiCTXH.ThaytheBDH(nhiemky, maSV1, maSV2);
        }

        public DataTable XemBDHTheoNhiemKy(int nhiemki)
        {
            ConvertClass convert = new ConvertClass();
            var query = doiCTXH.fu_ds_BDH_Nhiemky(nhiemki);
            return convert.ToDataTable(doiCTXH, query);
        }
        public DataTable DanhsachNhiemky()
        {
            ConvertClass convert = new ConvertClass();
            var query = doiCTXH.fu_Ds_Nhiemki();
            return convert.ToDataTable(doiCTXH, query);
        }
    }
}
