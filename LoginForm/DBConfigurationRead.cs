using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LoginForm
{
    class DBConfigurationRead
    {
        private string[] GetConfiguration(string selectionCol, string whatConfigData, string connecSelecStr, SqlDataAdapter dataAdapter)
        {
            string queryCmd = "select " + selectionCol + " from configuration where largeCateg = \'" + whatConfigData + "\';";
            DataSet ds = new DataSet();
            try
            {
                dataAdapter = new SqlDataAdapter(queryCmd, connecSelecStr);
                //table = new System.Data.DataTable();
                //table.Locale = System.Globalization.CultureInfo.InvariantCulture;
                //dataAdapter.Fill(table);
                dataAdapter.Fill(ds);
                //bindingSource1.DataSource = table;
                //dataGridView1.Columns[0].ReadOnly = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }

            string[] StringArray(DataSet dss)
            {
                string[] stringArray = new string[dss.Tables[0].Rows.Count];


                for (int col = 0; col < dss.Tables[0].Rows.Count; ++col)
                {
                    stringArray[col] = dss.Tables[0].Rows[col][0].ToString();
                }


                return stringArray;
            }

            return StringArray(ds);
        }
    }
}
