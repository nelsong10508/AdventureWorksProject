using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PixisAirGroupProject
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;
        string SQL;
        //use dataAdabpter and DataSet opposed to command object and DataReader
        SqlDataAdapter adapter;
        DataSet data;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flightBtn_Click(object sender, EventArgs e)
        {
            Flights secondForm = new Flights();
            secondForm.ShowDialog();
        }

        private void airplaneBtn_Click(object sender, EventArgs e)
        {
            Airplane thirdForm = new Airplane();
            thirdForm.ShowDialog();
        }

        private void cityBtn_Click(object sender, EventArgs e)
        {
            RoutesAndCities fourthForm = new RoutesAndCities();
            fourthForm.ShowDialog();
        }

        private void citiesBtn_Click(object sender, EventArgs e)
        {
            DepartAndArrival fifthForm = new DepartAndArrival();
            fifthForm.ShowDialog();
        }

        private void airportBtn_Click(object sender, EventArgs e)
        {
            Airports sixthForm = new Airports();
            sixthForm.ShowDialog();
        }

        private void crewBtn_Click(object sender, EventArgs e)
        {
            Crew seventhForm = new Crew();
            seventhForm.ShowDialog();
        }

        private void logsBtn_Click(object sender, EventArgs e)
        {
            Maintenance eigthForm = new Maintenance();
            eigthForm.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flights secondForm = new Flights();
            secondForm.ShowDialog();
        }

        private void airplanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Airplane thirdForm = new Airplane();
            thirdForm.ShowDialog();
        }


        private void routesWithCityNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoutesAndCities fourthForm = new RoutesAndCities();
            fourthForm.ShowDialog();
        }

        private void departingAndArrivingCitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartAndArrival fifthForm = new DepartAndArrival();
            fifthForm.ShowDialog();
        }

        private void allAirportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Airports sixthForm = new Airports();
            sixthForm.ShowDialog();
        }

        private void flightCrewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crew seventhForm = new Crew();
            seventhForm.ShowDialog();
        }

        private void maintenanceLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance eigthForm = new Maintenance();
            eigthForm.ShowDialog();
        }
    }
}


