using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class employeeSrch : Form
    {
        public string connString = @"Data Source=DESKTOP-0V3BOG8\SQLEXPRESS;Initial Catalog=AddressBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlDataAdapter dataAdapter;
        DataTable table;
        SqlCommandBuilder cmdBuilder;
        SqlConnection conn;

        string selectionStatement = "select * from BizContacts";

        public employeeSrch()
        {
            InitializeComponent();
        }

        private void GetData(string queryCmd)
        {
            try
            {
                dataAdapter = new SqlDataAdapter(queryCmd, connString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                dataGridView1.ReadOnly = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            switch (cmbBxSrch.SelectedItem.ToString())
            {
                case "First Name":
                    GetData("select * from bizcontacts where lower(first_name) like '%" + txtBxSrch.Text.ToLower() + "%'");
                    break;
                case "Last Name":
                    GetData("select * from bizcontacts where lower(last_name) like '%" + txtBxSrch.Text.ToLower() + "%'");
                    break;
                case "Company":
                    GetData("select * from bizcontacts where lower(company) like '%" + txtBxSrch.Text.ToLower() + "%'");
                    break;


            }
        }

        private void employeeSrch_Load(object sender, EventArgs e)
        {
            cmbBxSrch.SelectedIndex = 0;
            dataGridView1.DataSource = bindingSource1;

            GetData(selectionStatement);
        }
    }
}
