using IBM.Data.DB2.iSeries;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InsertPractice;

namespace PixisAirGroupProject
{
    public partial class AddResHist : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataSet;

        public AddResHist()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void dsplyBtn_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string sql;
            string connName = "IBMConnectionStringDev";

            try
            {
                conn = new iDB2Connection(DataHelper.ConnectionValue(connName));
                conn.Open();
                sql = "Select * FROM RESHIST";
                adapter = new iDB2DataAdapter(sql, conn);

                dataSet = new DataSet();
                adapter.Fill(dataSet);

                //listBox1.Items.Clear();

                foreach (DataRow wRow in dataSet.Tables[0].Rows)
                    listBox1.Items.Add(dataSet.Tables[0].Columns[0].ColumnName + ":  " + wRow[0] + "    " +
                                       dataSet.Tables[0].Columns[1].ColumnName + ":  " + wRow[1] + "    " +
                                       dataSet.Tables[0].Columns[2].ColumnName + ":  " + wRow[2] + "    " +
                                       dataSet.Tables[0].Columns[3].ColumnName + ":  " + wRow[3] + "    " +
                                       dataSet.Tables[0].Columns[4].ColumnName + ":  " + wRow[4] + "    " +
                                       dataSet.Tables[0].Columns[5].ColumnName + ":  " + wRow[5] + "    " +
                                       dataSet.Tables[0].Columns[6].ColumnName + ":  " + wRow[6]);
        
                conn.Close();
            }

            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            string connName = "IBMConnectionStringDev";
            string cmdTxt = "INSERT INTO RESHIST (RESNO,CUSTNO,FLIGHTNO,ROUTENO,FLPRICE,TCOST,SEATNO)" +
                "VALUES (@RESNO, @CUSTNO, @FLIGHTNO, @ROUTENO, @FLPRICE, @TCOST, @SEATNO)";

            try
            {
                conn = new iDB2Connection(DataHelper.ConnectionValue(connName));
                conn.Open();

                iDB2Command cmd = new iDB2Command(cmdTxt, conn);
                cmd.Parameters.Add("@RESNO", reservationTxt.Text);
                cmd.Parameters.Add("@CUSTNO", custNumTxt.Text);
                cmd.Parameters.Add("@FLIGHTNO", flightNumTxt.Text);
                cmd.Parameters.Add("@ROUTENO", routeNumTxt.Text);
                cmd.Parameters.Add("@FLPRICE", finalPriceTxt.Text);
                cmd.Parameters.Add("@TCOST", totalCostTxt.Text);
                cmd.Parameters.Add("@SEATNO", seatNumTxt.Text);

                cmd.ExecuteNonQuery();

                conn.Close();
                listBox1.Items.Add("Record added, click display data button to see the new record");
            }
            catch (iDB2Exception ex)
            {
                listBox1.Items.Add(ex);
                listBox1.Items.Add(ex.MessageDetails);
                listBox1.Items.Add(ex.Message);
                listBox1.Items.Add(ex.ToString());
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex);
                listBox1.Items.Add(ex.Message);
                listBox1.Items.Add(ex.StackTrace);
                listBox1.Items.Add(ex.ToString());
            }
        }
    }
}