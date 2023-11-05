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
    public partial class DepartAndArrival : Form
    {
        SqlConnection connection;
        string connectionString;
        string SQL;
        //use dataAdabpter and DataSet opposed to command object and DataReader
        SqlDataAdapter adapter;
        DataSet data;
        public DepartAndArrival()
        {
            InitializeComponent();
        }

        private void departBtn_Click(object sender, EventArgs e)
        {
            // clears the list box everytime a new button is pressed
            listBox1.Items.Clear();

            connectionString = "Data Source=V2StudentPOC;Initial Catalog=PixisAir;" +
               "Persist Security Info=True;User ID=student;Password=ichooseGateway";
            //button click from DepartBtn entered to textbox...following the SQL statement is how to enter flight number into the
            // text box and when the button is clicked it displays in the listbox
            SQL = "SELECT Route.* FROM Route JOIN flight on flight.FLIGHTNO = Flight.FlightNo WHERE flight.FLIGHTNO = '"
                + textBox1.Text + "'";
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
                    //Columns[].ColumnName is how you add the column name with the data in the table
                    //Lines 52-53 displays the column name and the data associated with its respected column when the button is clicked
                    //Data rows and columns work like arrays 
                    listBox1.Items.Add(data.Tables[0].Columns[1].ColumnName + ": " + dataRow[1] + ",  " +
                                       data.Tables[0].Columns[2].ColumnName + ": " + dataRow[2]);

                connection.Close();//close the connection

            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
