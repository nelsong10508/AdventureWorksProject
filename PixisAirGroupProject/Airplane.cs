using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixisAirGroupProject
{

    public partial class Airplane : Form
    {
        SqlConnection connection;
        string connectionString;
        string SQL;
        //use dataAdabpter and DataSet opposed to command object and DataReader
        SqlDataAdapter adapter;
        DataSet data;

        public Airplane()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void airPlaneBtn_Click(object sender, EventArgs e)
        {
            // clears the list box everytime a new button is pressed
            listBox1.Items.Clear();

            connectionString = "Data Source=V2StudentPOC;Initial Catalog=PixisAir;" +
               "Persist Security Info=True;User ID=student;Password=ichooseGateway";
            SQL = "SELECT * FROM dbo.Airplane";
            try
            {
                //create connection string object using the connection string parameter
                connection = new SqlConnection(connectionString);
                //create SqlDataAdapter passing in the SQL string and the connection string 
                adapter = new SqlDataAdapter(SQL, connection);
                //create a dataSet
                data = new DataSet();
                adapter.Fill(data);
                //loop through the dataTable row adding data row to listbox
                foreach (DataRow dataRow in data.Tables[0].Rows)
                    listBox1.Items.Add(data.Tables[0].Columns[0].ColumnName + ": " + dataRow[0] + ",  " +
                                      data.Tables[0].Columns[6].ColumnName + ": " + dataRow[6] + ",  " +
                                      data.Tables[0].Columns[7].ColumnName + ": " + dataRow[7]);
                connection.Close();//close the connection

            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }
    }
}
