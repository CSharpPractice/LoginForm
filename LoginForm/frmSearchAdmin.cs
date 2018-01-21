using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;//NEEDED FOR FILE USE
using System.Diagnostics;
using Microsoft.Office.Interop.Excel;

namespace LoginForm
{
    public partial class frmSearchAdmin : Form
    {

        public string connString = @"Data Source=DESKTOP-0V3BOG8\SQLEXPRESS;Initial Catalog=AddressBook;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlDataAdapter dataAdapter;
        System.Data.DataTable table;
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
                table = new System.Data.DataTable();
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
            string insert = @"insert into BizContacts(Date_Added, Company, Website, Title, First_Name, Last_Name, Address, City, State, Postal_Code, Email, Mobile, Notes, Image)
                            values(@Date_Added, @Company, @Website, @Title, @First_Name, @Last_Name, @Address, @City, @State, @Postal_Code, @Email, @Mobile, @Notes, @Image)";

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
                    if (openImageFileDialog.FileName != "")
                        cmdObj.Parameters.AddWithValue(@"Image", File.ReadAllBytes(openImageFileDialog.FileName));//Converts images to bytes for saving. 
                    else
                        cmdObj.Parameters.Add(@"Image", SqlDbType.VarBinary).Value = DBNull.Value;

                    
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

        private void btnGetImage_Click(object sender, EventArgs e)
        {
            if(openImageFileDialog.ShowDialog() == DialogResult.OK)
                pictureBox1.Load(openImageFileDialog.FileName);
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Form frm = new Form();
            try
            {
                frm.BackgroundImage = pictureBox1.Image;
                frm.Size = pictureBox1.Image.Size;
                frm.Show();

            }
            catch (NullReferenceException ex)
            {
                MessageBox.Show("No image selected");
            }
            
           
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            _Application excel = new Microsoft.Office.Interop.Excel.Application();
            _Workbook workBook = excel.Workbooks.Add(Type.Missing); //Make a work book.
            _Worksheet workSheet = null;
            try
            {
                workSheet = workBook.ActiveSheet;
                workSheet.Name = "Business contacts";

                for (int rowIndex = 0; rowIndex < dataGridView1.Rows.Count - 1; rowIndex++) {
                    for (int colIndex = 0; colIndex < dataGridView1.Columns.Count; colIndex++) {
                        if (rowIndex == 0)
                        {
                            workSheet.Cells[rowIndex + 1, colIndex + 1] = dataGridView1.Columns[colIndex].HeaderText;
                        }
                        else
                        {
                            workSheet.Cells[rowIndex + 1, colIndex + 1] = dataGridView1.Rows[rowIndex-1].Cells[colIndex].Value.ToString();
                        }
                    }
                }
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    workBook.SaveAs(saveFileDialog1.FileName);
                    Process.Start("excel.exe", saveFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workSheet = null;
                workBook = null;
            }
             
        }
    }
}
