using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCNPM.LopGiaoDien
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Maximized)
                WindowState = FormWindowState.Normal;
            else if (WindowState == FormWindowState.Normal)
                WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnMore_Click(object sender, EventArgs e)
        {
            //50, 688;
            if (this.pnlLeft.Width == 250)
            {
                this.pnlLeft.Width = 50;
                this.btnMore.Dock = DockStyle.Left;
                this.pnlLogo.Visible = false;
                this.pnlMain.Width = 1228;
            }
            else if (this.pnlLeft.Width == 50)
            {
                this.pnlLeft.Width = 250;
                this.btnMore.Dock = DockStyle.Right;
                this.pnlLogo.Visible = true;
                this.pnlMain.Width = 1028;
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            this.pnlMain.Controls.Clear();
            FormCover Cover = new FormCover();
            this.pnlMain.Controls.Add(Cover);
        }
    }
}
