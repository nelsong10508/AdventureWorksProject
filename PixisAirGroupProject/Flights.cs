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
    public partial class Flights : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataSet;
        public Flights()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void flightsBtn_Click(object sender, EventArgs e)
        {
            // clears the list box everytime a new button is pressed
            listBox1.Items.Clear();

            string sql;
            string connName = "IBMConnectionStringDev";

            try
            {
                //create a dataSet
                conn = new iDB2Connection(DataHelper.ConnectionValue(connName));
                conn.Open();
                sql = "SELECT * FROM Flight";
                adapter = new iDB2DataAdapter(sql, conn);

                dataSet = new DataSet();
                adapter.Fill(dataSet);

                // clears the list box everytime a new button is pressed
                listBox1.Items.Clear();

                //loop through the dataTable row adding data row to listbox
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    //Columns[].ColumnName is how you add the column name with the data in the table
                    //Lines 62-72 displays the column name and the data associated with its respected column when the button is clicked
                    //Data rows and columns work like arrays 
                    listBox1.Items.Add(dataSet.Tables[0].Columns[0].ColumnName + ": " + dataRow[0] + ",  " +
                                       dataSet.Tables[0].Columns[1].ColumnName + ": " + dataRow[1] + ",  " +
                                       dataSet.Tables[0].Columns[2].ColumnName + ": " + dataRow[2] + ",  " +
                                       dataSet.Tables[0].Columns[3].ColumnName + ": " + dataRow[3] + ",  " +
                                       dataSet.Tables[0].Columns[4].ColumnName + ": " + dataRow[4] + ",  " +
                                       dataSet.Tables[0].Columns[5].ColumnName + ": " + dataRow[5] + ",  " +
                                       dataSet.Tables[0].Columns[6].ColumnName + ": " + dataRow[6] + ",  " +
                                       dataSet.Tables[0].Columns[7].ColumnName + ": " + dataRow[7] + ",  " +
                                       dataSet.Tables[0].Columns[8].ColumnName + ": " + dataRow[8] + ",  " +
                                       dataSet.Tables[0].Columns[9].ColumnName + ": " + dataRow[9] + ",  " +
                                       dataSet.Tables[0].Columns[10].ColumnName + ": " +dataRow[10]);
                conn.Close();
            }

            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }
    }
}
