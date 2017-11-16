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
    public partial class FormDangNhap : Form
    {
        //cac bien dieu khien thanh tieu de
        Boolean drag = false;
        int mousex;
        int mousey;

        string userName { get; set; }
        string passWord { get; set; }
        string ip { get; set; }
        string DatabaseName { get; set; }
        DoiCTXHDataContext doiCTXH = new DoiCTXHDataContext();

        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            //Kiểm tra đã nhập đũ các dữ liệu
            if (txtUsername.TextLength > 0 && txtPassword.TextLength > 0)
            {
                this.userName = this.txtUsername.Text;
                this.ip = this.txtIP.Text;
                this.passWord = this.txtPassword.Text;
                doiCTXH.Connection.ConnectionString = "Data Source=" + this.ip + ";" + "User ID=" 
                    + this.userName + ";" + "Password=" + this.passWord + ";";
                try
                {
                    doiCTXH.Connection.Open();
                }
                catch
                {
                    MessageBox.Show("KHÔNG THỂ KẾT NỐI ĐẾN SERVER NÀY!");
                }
                if (doiCTXH.Connection.State == ConnectionState.Open)
                {
                    this.pnlFirstTextBox.Visible = false;
                    this.pnlSecondTextBox.Visible = true;
                    this.AcceptButton = this.btnConnect;
                    DataTable databases = doiCTXH.Connection.GetSchema("databases");
                    if (databases != null)
                    {
                        foreach (DataRow database in databases.Rows)
                        {
                            string databaseName = database.Field<string>("Database_Name");
                            this.cbxDatabase.Items.Add(databaseName);
                        }
                    }
                    
                }
            }
            else
            {
                MessageBox.Show("Vui lòng nhập Username và Password");
            }
        }

        private void pnlTop_MouseUp(object sender, MouseEventArgs e)
        {
            drag = false;
        }

        private void pnlTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true)
            {
                this.Top = Cursor.Position.Y - mousey;
                this.Left = Cursor.Position.X - mousex;
            }
        }

        private void pnlTop_MouseDown(object sender, MouseEventArgs e)
        {
            drag = true;
            mousex = Cursor.Position.X - this.Left;
            mousey = Cursor.Position.Y - this.Top;
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            this.DatabaseName = this.cbxDatabase.Text.ToString();
            doiCTXH.Connection.Close();
            doiCTXH.Connection.ConnectionString = "Data Source=" + this.ip + ";" 
                + "Initial Catalog=" + this.DatabaseName + ";" 
                + "User ID=" + this.userName + ";" 
                + "Password=" + this.passWord + ";";
            try
            {
                doiCTXH.Connection.Open();
            }
            catch
            {
                MessageBox.Show("KHÔNG ĐỦ QUYỀN HẠN KẾT NỐI ĐẾN CƠ SỞ DỮ LIỆU NÀY!");
            }
            this.Close();
        }
    }
}
