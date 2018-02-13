using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LoginForm
{
    public partial class MainFrmLogin : Form
    {
        public MainFrmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=DESKTOP-0V3BOG8\SQLEXPRESS;Initial Catalog=userLogin;Integrated Security=True");
            string query = "select * from logins where userid = '" + txtBxUserID.Text.Trim()+"' and password='" + txtBxPW.Text.Trim() + "'";

            SqlDataAdapter sda = new SqlDataAdapter(query, sqlcon);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if (dtbl.Rows.Count == 1)
            {
                int privilege = Convert.ToInt16(dtbl.Rows[0]["privilege"]);

               
                this.Hide();
                if (privilege == 1)
                {
                    frmSearchAdmin admin = new frmSearchAdmin();
                    MessageBox.Show("Welcome! Administrator! You have power for CRUD!");
                    admin.Show();
                }
                else if(privilege == 2)
                {
                    employeeSrch employ = new employeeSrch();
                    MessageBox.Show("Welcome! Worker! You only have power to read data.");
                    employ.Show();
                }

                
            }
            else
            {
                MessageBox.Show("No such User ID and Password have been found!");
            }


        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBxPW_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnLogin_Click(this, new EventArgs());
            }
        }
    }
}
