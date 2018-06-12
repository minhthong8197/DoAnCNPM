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
    class NghiepVuPhanQuyen
    {
        DoiCTXHDataContext doiCTXH = new DoiCTXHDataContext(Dynamic_Connection.ConnectStr);

        public DataTable BangTaiKhoan()
        {
            ConvertClass convert = new ConvertClass();
            var query = doiCTXH.fu_Ds_TaiKhoan();
            return convert.ToDataTable(doiCTXH, query);
        }

        public void DoiPass(string login, string pass)
        {
            doiCTXH.uspDoiMatKhau(login, pass);
        }
    }
}
