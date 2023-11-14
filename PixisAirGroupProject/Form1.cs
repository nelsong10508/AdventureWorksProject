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
using IBM.Data.DB2.iSeries;

namespace PixisAirGroupProject
{
    public partial class Form1 : Form
    {

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
            secondForm.Show();
            this.Hide();

        }

        private void airplaneBtn_Click(object sender, EventArgs e)
        {
            Airplane thirdForm = new Airplane();
            thirdForm.Show();
            this.Hide();
        }

        private void cityBtn_Click(object sender, EventArgs e)
        {
            RoutesAndCities fourthForm = new RoutesAndCities();
            fourthForm.Show();
            this.Hide();
        }

        private void citiesBtn_Click(object sender, EventArgs e)
        {
            DepartAndArrival fifthForm = new DepartAndArrival();
            fifthForm.Show();
            this.Hide();
        }

        private void airportBtn_Click(object sender, EventArgs e)
        {
            Airports sixthForm = new Airports();
            sixthForm.Show();
            this.Hide();
        }

        private void crewBtn_Click(object sender, EventArgs e)
        {
            Crew seventhForm = new Crew();
            seventhForm.Show();
            this.Hide();
        }

        private void logsBtn_Click(object sender, EventArgs e)
        {
            Maintenance eigthForm = new Maintenance();
            eigthForm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void flightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Flights secondForm = new Flights();
            secondForm.Show();
            this.Hide();
        }

        private void airplanesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Airplane thirdForm = new Airplane();
            thirdForm.Show();
            this.Hide();
        }


        private void routesWithCityNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RoutesAndCities fourthForm = new RoutesAndCities();
            fourthForm.Show();
            this.Hide();
        }

        private void departingAndArrivingCitiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DepartAndArrival fifthForm = new DepartAndArrival();
            fifthForm.Show();
            this.Hide();
        }

        private void allAirportsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Airports sixthForm = new Airports();
            sixthForm.Show();
            this.Hide();
        }

        private void flightCrewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Crew seventhForm = new Crew();
            seventhForm.Show();
            this.Hide();
        }

        private void maintenanceLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Maintenance eigthForm = new Maintenance();
            eigthForm.Show();
            this.Hide();
        }

        private void addAirplane_Click(object sender, EventArgs e)
        {
            AddAirplane ninthForm = new AddAirplane();
            ninthForm.Show();
            this.Hide();
        }

        private void addResHistBtn_Click(object sender, EventArgs e)
        {
            AddResHist tenthForm = new AddResHist();
            tenthForm.Show();
            this.Hide();
        }

        private void addAirplaneToAirplaneTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAirplane ninthForm = new AddAirplane();
            ninthForm.Show();
            this.Hide();
        }

        private void addRecordToResHistTableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddResHist tenthForm = new AddResHist();
            tenthForm.Show();
            this.Hide();
        }
    }
}


