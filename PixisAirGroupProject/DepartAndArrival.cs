﻿using IBM.Data.DB2.iSeries;
using InsertPractice;
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
        // establishing the connection to the I
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataSet;
        public DepartAndArrival()
        {
            InitializeComponent();
        }

        private void departBtn_Click(object sender, EventArgs e)
        {
            // clears the list box everytime a new button is pressed
            listBox1.Items.Clear();

            string sql;
            // conection name from data helper
            string connName = "IBMConnectionStringDev";

            try
            {
                //create a dataSet
                conn = new iDB2Connection(DataHelper.ConnectionValue(connName));
                conn.Open();

                /* at the end of the SQL statement is how we entered the data into the text box
                  and displayed the departing and arrival cities */
                sql = "SELECT * FROM Route JOIN flight on FLIGHTNO = FlightNo WHERE FLIGHTNO = '"
                 + textBox1.Text + "'";

                adapter = new iDB2DataAdapter(sql, conn);
                dataSet = new DataSet();
                adapter.Fill(dataSet);

                // clears the list box everytime a new button is pressed
                listBox1.Items.Clear();

                //loop through the dataTable row adding data row to listbox
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    //Columns[].ColumnName is how you add the column name with the data in the table
                    //Lines 59-61 displays the column name and the data associated with its respected column when the button is clicked
                    //Data rows and columns work like arrays 
                    listBox1.Items.Add(dataSet.Tables[0].Columns[1].ColumnName + ": " + dataRow[1] + ",  " +
                                       dataSet.Tables[0].Columns[2].ColumnName + ": " + dataRow[2]); 
                conn.Close();
            }
           
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }
        private void exitBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
