using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Linq;
namespace DoAnCNPM.LopNghiepVu
{
    class NghiepVuChuongTrinh
    {
        DoiCTXHDataContext doiCTXH = new DoiCTXHDataContext(Dynamic_Connection.ConnectStr);

        public DataTable BangChuongTrinh()
        {
            ConvertClass convert = new ConvertClass();
            var query = doiCTXH.fu_Ds_Chuongtrinh();
            return convert.ToDataTable(doiCTXH, query);
        }

        public void ThemChuongTrinh(string mact, string tenct, DateTime ngaytochuc, string diadiem, string kinhphi, string diemctxh)
        {
            int CKinhPhi;
            if (kinhphi == "") CKinhPhi = 0;
            else CKinhPhi = Convert.ToInt32(kinhphi);
            int CDiemCTXH;
            if (diemctxh == "") CDiemCTXH = 0;
            else CDiemCTXH = Convert.ToInt32(diemctxh);
            doiCTXH.sp_ThemChuongTrinh(mact, tenct, ngaytochuc, diadiem, CKinhPhi, CDiemCTXH);
        }

        public void XoaChuongTrinh(string mact)
        {
            doiCTXH.sp_XoaChuongTrinh(mact);
        }

        public void UpdateChuongTrinh(string mact, string tenct, DateTime ngaytochuc, string diadiem, string kinhphi, string diemctxh)
        {
            int CKinhPhi;
            if (kinhphi == "") CKinhPhi = 0;
            else CKinhPhi = Convert.ToInt32(kinhphi);
            int CDiemCTXH;
            if (diemctxh == "") CDiemCTXH = 0;
            else CDiemCTXH = Convert.ToInt32(diemctxh);
            doiCTXH.sp_UpdateChuongTrinh(mact, tenct, ngaytochuc, diadiem, CKinhPhi, CDiemCTXH);
        }
        public DataTable LoadDsThamgiaCT(string MaCT)
        {
            ConvertClass convert = new ConvertClass();
            var query = doiCTXH.fu_DS_SVthamgiaCT(MaCT);
            return convert.ToDataTable(doiCTXH, query);
        }
        public void SinhvienThamgiaCT(string Ma_SV,string MaCT,string diemCTXH,string Danhgia)
        {
            int CDiemCTXH;
            if (diemCTXH == "") CDiemCTXH = 0;
            else
                CDiemCTXH = Convert.ToInt32(diemCTXH);
            doiCTXH.ThamgiaCT(MaCT, Ma_SV, CDiemCTXH, Danhgia);
        }
        public string LayTenCT(string MaCT)
        {
            return doiCTXH.fu_LayTenCT(MaCT);
        }
        public int LaySoluongThamgia(string MaCT)
        {
            return Convert.ToInt32( doiCTXH.fu_SL_ThamgiaCT(MaCT));
        }
        public void XoaThamgiaCT(string MaSV, string MaCT)
        {
            doiCTXH.sp_DelThamgiaCT(MaSV, MaCT);
        }
        public void CapNhatThamgia(string MaCT,string MaSV, string DiemCTXH,string Danhgia)
        {
            int CDiemCTXH;
            if (DiemCTXH == "") CDiemCTXH = 0;
            else
                CDiemCTXH = Convert.ToInt32(DiemCTXH);
            doiCTXH.sp_UpdateThamgiaCT(MaSV, MaCT, CDiemCTXH, Danhgia);
        }
    }
}
