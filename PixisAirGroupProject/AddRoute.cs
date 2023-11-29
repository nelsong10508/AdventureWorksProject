using IBM.Data.DB2.iSeries;
using InsertPractice;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PixisAirGroupProject
{
    public partial class AddRoute : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataSet;
        public AddRoute()
        {
            InitializeComponent();
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
                sql = "Select * FROM Flight2023.ROUTE";
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
                                       dataSet.Tables[0].Columns[6].ColumnName + ":  " + wRow[6] + "    " +
                                       dataSet.Tables[0].Columns[7].ColumnName + ":  " + wRow[7] + "    " +
                                       dataSet.Tables[0].Columns[8].ColumnName + ":  " + wRow[8]);


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
            string cmdTxt = "INSERT INTO FLIGHT2023.ROUTE (RTARDEPART, RTARARRIVL, RTDISTANCE, RTESTTM, RTBASECOST, " +
                "RTACTDT, RTIACTDT, RTNO) VALUES (@RTARDEPART, @RTARARRIVL, @RTDISTANCE, @RTESTTM, @RTBASECOST, " +
                "@RTACTDT, @RTIACTDT, @RTNO)";


            try
            {
                using (conn = new iDB2Connection(DataHelper.ConnectionValue(connName)))
                {
                    conn.Open();
                    using (iDB2Command cmd = new iDB2Command(cmdTxt, conn))
                    {
                        cmd.Parameters.Add("@RTARDEPART", iDB2DbType.iDB2Char).Value = departTxt.Text.ToUpper();
                        cmd.Parameters.Add("@RTARARRIVL", iDB2DbType.iDB2Char).Value = ararrivlTxt.Text.ToUpper();
                        cmd.Parameters.Add("@RTDISTANCE", iDB2DbType.iDB2Decimal).Value = Decimal.Parse(rtdistanceTxt.Text);
                        cmd.Parameters.Add("@RTESTTM", iDB2DbType.iDB2Integer).Value = Int32.Parse(rtesttmTxt.Text);
                        cmd.Parameters.Add("@RTBASECOST", iDB2DbType.iDB2Decimal).Value = Decimal.Parse(rtbasecostTxt.Text);
                        cmd.Parameters.Add("@RTACTDT", iDB2DbType.iDB2Date).Value = DateTime.Parse(rtactdtTxt.Text);
                        cmd.Parameters.Add("@RTIACTDT", iDB2DbType.iDB2Date).Value = DateTime.Parse(rtiactdtTxt.Text);
                        cmd.Parameters.Add("@RTNO", iDB2DbType.iDB2Char).Value = rtnoTxt.Text;

                        cmd.CommandText = cmdTxt;
                        cmd.ExecuteNonQuery();

                        listBox1.Items.Add("Record added, click display data button to see the new record");
                    }
                }
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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
