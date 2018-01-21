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
    public partial class frmSearchAdmin : Form
    {

        public string connString = @"Data Source=DESKTOP-0V3BOG8\SQLEXPRESS;Initial Catalog=AddressBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlDataAdapter dataAdapter;
        DataTable table;
        SqlCommandBuilder cmdBuilder;
        SqlConnection conn;

        string selectionStatement = "select * from BizContacts";

        public frmSearchAdmin()
        {
            InitializeComponent();
        }

        private void frmLoggedIn_Load(object sender, EventArgs e)
        {
            cmbBxSrch.SelectedIndex = 0;
            dataGridView1.DataSource = bindingSource1;

            GetData(selectionStatement);    
         }

        private void GetData(string queryCmd)
        {
            try {
                dataAdapter = new SqlDataAdapter(queryCmd, connString);
                table = new DataTable();
                table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                dataAdapter.Fill(table);
                bindingSource1.DataSource = table;
                dataGridView1.Columns[0].ReadOnly = true;
            } catch (SqlException ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlCommand cmdObj;
            string insert = @"insert into BizContacts(Date_Added, Company, Website, Title, First_Name, Last_Name, Address, City, State, Postal_Code, Email, Mobile, Notes)
                            values(@Date_Added, @Company, @Website, @Title, @First_Name, @Last_Name, @Address, @City, @State, @Postal_Code, @Email, @Mobile, @Notes)";

            using (SqlConnection conn = new SqlConnection(connString))
            {

                try
                {
                    conn.Open();
                    cmdObj = new SqlCommand(insert, conn);
                    cmdObj.Parameters.AddWithValue(@"Date_Added", dateTimePicker1.Value.Date);
                    cmdObj.Parameters.AddWithValue(@"Company", txtBxComp.Text);
                    cmdObj.Parameters.AddWithValue(@"Website", txtBxWWW.Text);
                    cmdObj.Parameters.AddWithValue(@"Title", txtBxTitle.Text);
                    cmdObj.Parameters.AddWithValue(@"First_Name", txtBxFstName.Text);
                    cmdObj.Parameters.AddWithValue(@"Last_Name", txtBxLstName.Text);
                    cmdObj.Parameters.AddWithValue(@"Address", txtBxAddr.Text);
                    cmdObj.Parameters.AddWithValue(@"City", txtBxCity.Text);
                    cmdObj.Parameters.AddWithValue(@"State", txtBxState.Text);
                    cmdObj.Parameters.AddWithValue(@"Postal_Code", txtBxZipCod.Text);
                    cmdObj.Parameters.AddWithValue(@"Email", txtBxEmail.Text);
                    cmdObj.Parameters.AddWithValue(@"Mobile", txtBxMPhone.Text);
                    cmdObj.Parameters.AddWithValue(@"Notes", txtBxNot.Text);
                    cmdObj.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "\n" + ex.StackTrace);
                }
                GetData(selectionStatement);
                dataGridView1.Update();
            }

        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            cmdBuilder = new SqlCommandBuilder(dataAdapter);
            dataAdapter.UpdateCommand = cmdBuilder.GetUpdateCommand();
            try
            {
                bindingSource1.EndEdit();
                dataAdapter.Update(table);
                MessageBox.Show("Update Successful!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.CurrentCell.OwningRow;
            string value = row.Cells["ID"].Value.ToString();
            string fname = row.Cells["First_Name"].Value.ToString();
            string lname = row.Cells["Last_Name"].Value.ToString();
            DialogResult result = MessageBox.Show("Are you sure to delete it?\n" + fname + " " + lname + ", record " + value, "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string deleteState = @"Delete from BizContacts where id = '" + value + "'";

            if (result == DialogResult.Yes)
            {
                using (conn = new SqlConnection(connString))
                {
                    try
                    {
                        conn.Open();
                        SqlCommand commd = new SqlCommand(deleteState, conn);
                        commd.ExecuteNonQuery();
                        GetData(selectionStatement);
                        dataGridView1.Update();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }

        private void btnSrch_Click(object sender, EventArgs e)
        {
            switch (cmbBxSrch.SelectedItem.ToString()) {
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
    }
}
