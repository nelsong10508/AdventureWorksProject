using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IBM.Data.DB2.iSeries;
using InsertPractice;

namespace PixisAirGroupProject
{
    public partial class AddAirplane : Form
    {
        iDB2Connection conn;
        iDB2DataAdapter adapter;
        DataSet dataSet;

        public AddAirplane()
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
                sql = "Select * FROM AIRPLANE";
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
                                       dataSet.Tables[0].Columns[10].ColumnName + ":  " + wRow[10] + "    " +
                                       dataSet.Tables[0].Columns[11].ColumnName + ":  " + wRow[11] + "    " +
                                       dataSet.Tables[0].Columns[12].ColumnName + ":  " + wRow[12]);


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
            string cmdTxt = "INSERT INTO ITPA609.AIRPLANE (PlaneNo,MAXDIST,FCLASS,CCLASS,PAVAIL" +
                                                  ",MAINTMILES,PLANEMODEL,PMAKE,APARCD,APACTDT,APIACTDT,STATUS,DATEMAINT)  " +
                "VALUES (@PlaneNo, @MAXDIST, @FCLASS, @CCLASS, @PAVAIL, @MAINTMILES, @PLANEMODEL, @PMAKE, @APARCD, @APACTDT, " +
                "@APIACTDT, @STATUS, @DATEMAINT)";



            try
            {
                conn = new iDB2Connection(DataHelper.ConnectionValue(connName));
                conn.Open();

                iDB2Command cmd = new iDB2Command(cmdTxt, conn);
                cmd.Parameters.Add("@PlaneNo", planeNumTxt.Text);
                cmd.Parameters.Add("@MAXDIST", distanceTxt.Text);
                cmd.Parameters.Add("@FCLASS", firstClassTxt.Text);
                cmd.Parameters.Add("@CCLASS", coachTxt.Text);
                cmd.Parameters.Add("@PAVAIL", scheduleTxt.Text);
                cmd.Parameters.Add("@MAINTMILES", maintenanceTxt.Text);
                cmd.Parameters.Add("@PLANEMODEL", modelTxt.Text);
                cmd.Parameters.Add("@PMAKE", manufacturerTxt.Text);
                // make sure I enter a valid airport code
                cmd.Parameters.Add("@APARCD", airportCodeTxt.Text);
                cmd.Parameters.Add("@STATUS", statusTxt.Text);

                DateTime apactdt;
                if (DateTime.TryParse(activeDataTxt.Text, out apactdt))
                {
                    var aPACTDT = cmd.CreateParameter();
                    aPACTDT.ParameterName = "@APACTDT";
                    aPACTDT.Value = apactdt;
                    aPACTDT.iDB2DbType = iDB2DbType.iDB2Date;
                    cmd.Parameters.Add(aPACTDT);
                }
                else
                {
                    // Handle invalid date input, e.g., display an error message.
                    listBox1.Items.Add("Invalid date format for APACTDT");
                }

                DateTime apiactdt;
                if (DateTime.TryParse(inactiveDateTxt.Text, out apiactdt))
                {
                    var aPIACTDT = cmd.CreateParameter();
                    aPIACTDT.ParameterName = "@APIACTDT";
                    aPIACTDT.Value = apactdt;
                    aPIACTDT.iDB2DbType = iDB2DbType.iDB2Date;
                    cmd.Parameters.Add(aPIACTDT);
                }
                else
                {
                    // Handle invalid date input, e.g., display an error message.
                    listBox1.Items.Add("Invalid date format for APIACTDT");
                }

                DateTime datemaint;
                if (DateTime.TryParse(maintenanceDateTxt.Text, out datemaint))
                {
                    var dATEMAINT = cmd.CreateParameter();
                    dATEMAINT.ParameterName = "@DATEMAINT";
                    dATEMAINT.Value = apactdt;
                    dATEMAINT.iDB2DbType = iDB2DbType.iDB2Date;
                    cmd.Parameters.Add(dATEMAINT);
                }
                else
                {
                    // Handle invalid date input, e.g., display an error message.
                    listBox1.Items.Add("Invalid date format for DATEMAINT");
                }

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
