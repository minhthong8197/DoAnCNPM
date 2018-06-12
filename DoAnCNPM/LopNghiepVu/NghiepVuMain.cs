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
    class NghiepVuMain
    {
        DoiCTXHDataContext doiCTXH = new DoiCTXHDataContext(Dynamic_Connection.ConnectStr);

        public bool QuyenAdmin(string user)
        {
            if (doiCTXH.fu_LayVaiTro(user) == true) return true;
            else return false;
        }
    }
}
