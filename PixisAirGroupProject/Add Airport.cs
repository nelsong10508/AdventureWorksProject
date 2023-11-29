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
    public partial class Add_Airport : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataSet;

        public Add_Airport()
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
                sql = "Select * FROM itpa609.AIRPORT";
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
                                       dataSet.Tables[0].Columns[8].ColumnName + ":  " + wRow[8] + "    " +
                                       dataSet.Tables[0].Columns[9].ColumnName + ":  " + wRow[9] + "    " +
                                       dataSet.Tables[0].Columns[10].ColumnName + ":  " + wRow[10] + "    ");


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
            string cmdTxt = "INSERT INTO itpa609.AIRPORT (ARCD,ARNM,ARCITYNM,ARCNCD,ARFAACD,ARICAOCD,ARLATITUDE,ARLNGITUDE,ARALTITUDE,ARTIMEZNM,ARTIMEZOF)  " +
                "VALUES (@ARCD, @ARNM, @ARCITYNM,@ARCNCD,@ARFAACD,@ARICAOCD,@ARLATITUDE,@ARLNGITUDE,@ARALTITUDE,@ARTIMEZNM,@ARTIMEZOF)";

            try
            {
                conn = new iDB2Connection(DataHelper.ConnectionValue(connName));
                conn.Open();

                iDB2Command cmd = new iDB2Command(cmdTxt, conn);
                cmd.Parameters.Add("@ARCD", airportCodeTxt.Text);
                cmd.Parameters.Add("@ARNM", airportNameTxt.Text);
                cmd.Parameters.Add("@ARCITYNM", cityNameTxt.Text);
                cmd.Parameters.Add("@ARCNCD", countryCodeTxt.Text);
                cmd.Parameters.Add("@ARFAACD", faaCodeTxt.Text);
                cmd.Parameters.Add("@ARICAOCD", aviationOrgTxt.Text);
                cmd.Parameters.Add("@ARLATITUDE", latitudeTxt.Text);
                cmd.Parameters.Add("@ARLNGITUDE", longitudeTxt.Text);
                cmd.Parameters.Add("@ARALTITUDE", altitudeTxt.Text);
                cmd.Parameters.Add("@ARTIMEZNM", timeZoneTxt.Text);
                cmd.Parameters.Add("@ARTIMEZOF", timeOffsetTxt.Text);

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

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
