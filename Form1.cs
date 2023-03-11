using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Apk_Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            // create connetion
            OleDbConnection con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\LENOVO\Documents\users.accdb");

            //create dataabdter
            OleDbDataAdapter da = new OleDbDataAdapter("select count(*) from login where username = '" + txtUsername.Text + "' and password = '" + txtPassword.Text + "'", con);

            //create datable
            DataTable dt = new DataTable();

            //fill datable
            da.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                //means username dan password is correct

                Form2 F2 = new Form2();
                F2.Show();

            }
            else
            {
                // means username or password is incorret
                MessageBox.Show("username atau password salah, silahkan coba lagi");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
