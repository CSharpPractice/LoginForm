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
    public partial class categoAdd : Form
    {
        public string connStringProductManagement = @"Data Source=DESKTOP-0V3BOG8\SQLEXPRESS;Initial Catalog=ProductInforManagement;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

        SqlDataAdapter myDataAdapter;
        DBConfigurationRead readDBCateg = new DBConfigurationRead();

        public categoAdd()
        {
            InitializeComponent();
            this.cmbCategoryList.Items.Clear();
            this.cmbCategoryList.Items.AddRange(readDBCateg.GetConfiguration("distinct largeCateg", @"%", connStringProductManagement, myDataAdapter));
        }

        private void cmbCategoryList_SelectionChangeCommitted(object sender, EventArgs e)
        {
            refreshView();
           
        }
        private void refreshView()
        {
            if (this.cmbCategoryList.Text == "Model")
            {
                this.lstBxCategoryDisp.Items.Clear();
                this.lstBxCategoryDisp.Items.AddRange(readDBCateg.GetConfiguration("[1stCateg]", @"Model", connStringProductManagement, myDataAdapter));
            }
            else if (this.cmbCategoryList.Text == "반조립")
            {
                this.lstBxCategoryDisp.Items.Clear();
                this.lstBxCategoryDisp.Items.AddRange(readDBCateg.GetConfiguration("[1stCateg]", @"반조립", connStringProductManagement, myDataAdapter));
            }
            else if (this.cmbCategoryList.Text == "완조립")
            {
                this.lstBxCategoryDisp.Items.Clear();
                this.lstBxCategoryDisp.Items.AddRange(readDBCateg.GetConfiguration("[1stCateg]", @"완조립", connStringProductManagement, myDataAdapter));
            }
            else if (this.cmbCategoryList.Text == "ATS1")
            {
                this.lstBxCategoryDisp.Items.Clear();
                this.lstBxCategoryDisp.Items.AddRange(readDBCateg.GetConfiguration("[1stCateg]", @"ATS1", connStringProductManagement, myDataAdapter));
            }
            else if (this.cmbCategoryList.Text == "ATS2")
            {
                this.lstBxCategoryDisp.Items.Clear();
                this.lstBxCategoryDisp.Items.AddRange(readDBCateg.GetConfiguration("[1stCateg]", @"ATS2", connStringProductManagement, myDataAdapter));
            }
            else if (this.cmbCategoryList.Text == "ICS1")
            {
                this.lstBxCategoryDisp.Items.Clear();
                this.lstBxCategoryDisp.Items.AddRange(readDBCateg.GetConfiguration("[1stCateg]", @"ICS1", connStringProductManagement, myDataAdapter));
            }
            else if (this.cmbCategoryList.Text == "ICS2")
            {
                this.lstBxCategoryDisp.Items.Clear();
                this.lstBxCategoryDisp.Items.AddRange(readDBCateg.GetConfiguration("[1stCateg]", @"ICS2", connStringProductManagement, myDataAdapter));
            }
            else if (this.cmbCategoryList.Text == "ProductionDataSelection")
            {
                this.lstBxCategoryDisp.Items.Clear();
                this.lstBxCategoryDisp.Items.AddRange(readDBCateg.GetConfiguration("[1stCateg]", @"ProductionDataSelection", connStringProductManagement, myDataAdapter));
            }
            else if (this.cmbCategoryList.Text == "table_fail")
            {
                this.lstBxCategoryDisp.Items.Clear();
                this.lstBxCategoryDisp.Items.AddRange(readDBCateg.GetConfiguration("[1stCateg]", @"table_fail", connStringProductManagement, myDataAdapter));
            }
            else if (this.cmbCategoryList.Text == "Tuning1stCol")
            {
                this.lstBxCategoryDisp.Items.Clear();
                this.lstBxCategoryDisp.Items.AddRange(readDBCateg.GetConfiguration("[1stCateg]", @"Tuning1stCol", connStringProductManagement, myDataAdapter));
            }
            else if (this.cmbCategoryList.Text == "Tuning2ndCol")
            {
                this.lstBxCategoryDisp.Items.Clear();
                this.lstBxCategoryDisp.Items.AddRange(readDBCateg.GetConfiguration("[1stCateg]", @"Tuning2ndCol", connStringProductManagement, myDataAdapter));
            }

        }

        private void btnAddCatoryData_Click(object sender, EventArgs e)
        {
            string insertSolderFail = @"insert into dbo.configuration([largeCateg], [1stCateg])
                                    values (@largeCategP, @1stCategP)";
            insertData(connStringProductManagement, insertSolderFail);
            refreshView();


        }
        private void insertData(string whereToConnect, string insertSQLCmd)
        {
            SqlCommand cmdObj;

            using (SqlConnection conn = new SqlConnection(whereToConnect))
            {

                try
                {
                    conn.Open();
                    cmdObj = new SqlCommand(insertSQLCmd, conn);
                    cmdObj.Parameters.AddWithValue(@"largeCategP", this.cmbCategoryList.Text);
                    cmdObj.Parameters.AddWithValue(@"1stCategP", this.txtBxNewCategoryAdd.Text);
                    // cmdObj.Parameters.AddWithValue(@"DetailsP", this.txtBxDetails.Text);
                    cmdObj.ExecuteNonQuery();


                }
                catch (NullReferenceException ex)
                {
                    MessageBox.Show("Null value was passed : " + ex);
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("SQL statement error " + ex);
                }
                
            }
        }

        private void btnCloseReturn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
