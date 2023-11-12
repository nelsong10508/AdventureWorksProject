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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PixisAirGroupProject
{
    public partial class Airports : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataSet;

        public Airports()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void airportBtn_Click(object sender, EventArgs e)
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
                sql = "SELECT * FROM Airport";
                 
                adapter = new iDB2DataAdapter(sql, conn);
                dataSet = new DataSet();
                adapter.Fill(dataSet);

                // clears the list box everytime a new button is pressed
                listBox1.Items.Clear();

                //loop through the dataTable row adding data row to listbox
                foreach (DataRow dataRow in dataSet.Tables[0].Rows)
                    //Columns[].ColumnName is how you add the column name with the data in the table
                    //Lines 62-64 displays the column name and the data associated with its respected column when the button is clicked
                    //Data rows and columns work like arrays 
                    listBox1.Items.Add(dataSet.Tables[0].Columns[0].ColumnName + ": " + dataRow[0] + ",  " +
                                       dataSet.Tables[0].Columns[1].ColumnName + ": " + dataRow[1] + ",  " +
                                       dataSet.Tables[0].Columns[2].ColumnName + ": " + dataRow[2]);
                conn.Close();
            }
            /*// clears the list box everytime a new button is pressed
            listBox1.Items.Clear();

            connectionString = "Data Source=V2StudentPOC;Initial Catalog=PixisAir;" +
               "Persist Security Info=True;User ID=student;Password=ichooseGateway";
            SQL = "SELECT * FROM Airport";
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
                    //Lines 55-57 displays the column name and the data associated with its respected column when the button is clicked
                    //Data rows and columns work like arrays 
                    listBox1.Items.Add(data.Tables[0].Columns[0].ColumnName + ": " + dataRow[0] + ",  " +
                                       data.Tables[0].Columns[1].ColumnName + ": " + dataRow[1] + ",  " +
                                       data.Tables[0].Columns[2].ColumnName + ": " + dataRow[2]);

                connection.Close();//close the connection

            }*/
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }
    }
    }

