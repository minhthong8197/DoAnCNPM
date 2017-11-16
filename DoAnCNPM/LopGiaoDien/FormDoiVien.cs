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

namespace DoAnCNPM.LopGiaoDien
{
    public partial class FormDoiVien : UserControl
    {
        NghiepVuDoiVien nghiepvu = new NghiepVuDoiVien();

        public FormDoiVien()
        {
            InitializeComponent();
        }

        private void FormDoiVien_Load(object sender, EventArgs e)
        {
            MessageBox.Show(nghiepvu.test());
        }
    }
}
