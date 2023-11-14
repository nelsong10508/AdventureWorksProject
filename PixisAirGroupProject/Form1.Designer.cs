namespace PixisAirGroupProject
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flightBtn = new System.Windows.Forms.Button();
            this.airplaneBtn = new System.Windows.Forms.Button();
            this.cityBtn = new System.Windows.Forms.Button();
            this.airportBtn = new System.Windows.Forms.Button();
            this.crewBtn = new System.Windows.Forms.Button();
            this.logsBtn = new System.Windows.Forms.Button();
            this.citiesBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.airplanesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.routesWithCityNameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departingAndArrivingCitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allAirportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flightCrewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maintenanceLogsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToAirportTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addRecordToResHistTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addAirplaneToAirplaneTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addAirplane = new System.Windows.Forms.Button();
            this.addResHistBtn = new System.Windows.Forms.Button();
            this.addRouteBtn = new System.Windows.Forms.Button();
            this.addAirportBtn = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flightBtn
            // 
            this.flightBtn.Location = new System.Drawing.Point(71, 96);
            this.flightBtn.Name = "flightBtn";
            this.flightBtn.Size = new System.Drawing.Size(89, 38);
            this.flightBtn.TabIndex = 0;
            this.flightBtn.Text = "Flights";
            this.flightBtn.UseVisualStyleBackColor = true;
            this.flightBtn.Click += new System.EventHandler(this.flightBtn_Click);
            // 
            // airplaneBtn
            // 
            this.airplaneBtn.Location = new System.Drawing.Point(237, 96);
            this.airplaneBtn.Name = "airplaneBtn";
            this.airplaneBtn.Size = new System.Drawing.Size(89, 38);
            this.airplaneBtn.TabIndex = 1;
            this.airplaneBtn.Text = "Airplane";
            this.airplaneBtn.UseVisualStyleBackColor = true;
            this.airplaneBtn.Click += new System.EventHandler(this.airplaneBtn_Click);
            // 
            // cityBtn
            // 
            this.cityBtn.Location = new System.Drawing.Point(156, 288);
            this.cityBtn.Name = "cityBtn";
            this.cityBtn.Size = new System.Drawing.Size(89, 38);
            this.cityBtn.TabIndex = 2;
            this.cityBtn.Text = "Routes with City Name";
            this.cityBtn.UseVisualStyleBackColor = true;
            this.cityBtn.Click += new System.EventHandler(this.cityBtn_Click);
            // 
            // airportBtn
            // 
            this.airportBtn.Location = new System.Drawing.Point(237, 161);
            this.airportBtn.Name = "airportBtn";
            this.airportBtn.Size = new System.Drawing.Size(89, 38);
            this.airportBtn.TabIndex = 3;
            this.airportBtn.Text = "All Airports";
            this.airportBtn.UseVisualStyleBackColor = true;
            this.airportBtn.Click += new System.EventHandler(this.airportBtn_Click);
            // 
            // crewBtn
            // 
            this.crewBtn.Location = new System.Drawing.Point(237, 229);
            this.crewBtn.Name = "crewBtn";
            this.crewBtn.Size = new System.Drawing.Size(89, 38);
            this.crewBtn.TabIndex = 4;
            this.crewBtn.Text = "Flight Crew";
            this.crewBtn.UseVisualStyleBackColor = true;
            this.crewBtn.Click += new System.EventHandler(this.crewBtn_Click);
            // 
            // logsBtn
            // 
            this.logsBtn.Location = new System.Drawing.Point(71, 229);
            this.logsBtn.Name = "logsBtn";
            this.logsBtn.Size = new System.Drawing.Size(89, 38);
            this.logsBtn.TabIndex = 5;
            this.logsBtn.Text = "Maintenance Logs";
            this.logsBtn.UseVisualStyleBackColor = true;
            this.logsBtn.Click += new System.EventHandler(this.logsBtn_Click);
            // 
            // citiesBtn
            // 
            this.citiesBtn.Location = new System.Drawing.Point(71, 161);
            this.citiesBtn.Name = "citiesBtn";
            this.citiesBtn.Size = new System.Drawing.Size(89, 38);
            this.citiesBtn.TabIndex = 6;
            this.citiesBtn.Text = "Departing and Arriving Cities";
            this.citiesBtn.UseVisualStyleBackColor = true;
            this.citiesBtn.Click += new System.EventHandler(this.citiesBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(756, 400);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(89, 38);
            this.exitBtn.TabIndex = 7;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.flightsToolStripMenuItem,
            this.airplanesToolStripMenuItem,
            this.routesWithCityNameToolStripMenuItem,
            this.departingAndArrivingCitiesToolStripMenuItem,
            this.allAirportsToolStripMenuItem,
            this.flightCrewToolStripMenuItem,
            this.maintenanceLogsToolStripMenuItem,
            this.addRecordsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(857, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // flightsToolStripMenuItem
            // 
            this.flightsToolStripMenuItem.Name = "flightsToolStripMenuItem";
            this.flightsToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.flightsToolStripMenuItem.Text = "Flights";
            this.flightsToolStripMenuItem.Click += new System.EventHandler(this.flightsToolStripMenuItem_Click);
            // 
            // airplanesToolStripMenuItem
            // 
            this.airplanesToolStripMenuItem.Name = "airplanesToolStripMenuItem";
            this.airplanesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.airplanesToolStripMenuItem.Text = "Airplanes";
            this.airplanesToolStripMenuItem.Click += new System.EventHandler(this.airplanesToolStripMenuItem_Click);
            // 
            // routesWithCityNameToolStripMenuItem
            // 
            this.routesWithCityNameToolStripMenuItem.Name = "routesWithCityNameToolStripMenuItem";
            this.routesWithCityNameToolStripMenuItem.Size = new System.Drawing.Size(140, 20);
            this.routesWithCityNameToolStripMenuItem.Text = "Routes with City Name";
            this.routesWithCityNameToolStripMenuItem.Click += new System.EventHandler(this.routesWithCityNameToolStripMenuItem_Click);
            // 
            // departingAndArrivingCitiesToolStripMenuItem
            // 
            this.departingAndArrivingCitiesToolStripMenuItem.Name = "departingAndArrivingCitiesToolStripMenuItem";
            this.departingAndArrivingCitiesToolStripMenuItem.Size = new System.Drawing.Size(171, 20);
            this.departingAndArrivingCitiesToolStripMenuItem.Text = "Departing and Arriving Cities";
            this.departingAndArrivingCitiesToolStripMenuItem.Click += new System.EventHandler(this.departingAndArrivingCitiesToolStripMenuItem_Click);
            // 
            // allAirportsToolStripMenuItem
            // 
            this.allAirportsToolStripMenuItem.Name = "allAirportsToolStripMenuItem";
            this.allAirportsToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.allAirportsToolStripMenuItem.Text = "All Airports";
            this.allAirportsToolStripMenuItem.Click += new System.EventHandler(this.allAirportsToolStripMenuItem_Click);
            // 
            // flightCrewToolStripMenuItem
            // 
            this.flightCrewToolStripMenuItem.Name = "flightCrewToolStripMenuItem";
            this.flightCrewToolStripMenuItem.Size = new System.Drawing.Size(79, 20);
            this.flightCrewToolStripMenuItem.Text = "Flight Crew";
            this.flightCrewToolStripMenuItem.Click += new System.EventHandler(this.flightCrewToolStripMenuItem_Click);
            // 
            // maintenanceLogsToolStripMenuItem
            // 
            this.maintenanceLogsToolStripMenuItem.Name = "maintenanceLogsToolStripMenuItem";
            this.maintenanceLogsToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.maintenanceLogsToolStripMenuItem.Text = "Maintenance Logs";
            this.maintenanceLogsToolStripMenuItem.Click += new System.EventHandler(this.maintenanceLogsToolStripMenuItem_Click);
            // 
            // addRecordsToolStripMenuItem
            // 
            this.addRecordsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToAirportTableToolStripMenuItem,
            this.addToolStripMenuItem,
            this.addRecordToResHistTableToolStripMenuItem,
            this.addAirplaneToAirplaneTableToolStripMenuItem});
            this.addRecordsToolStripMenuItem.Name = "addRecordsToolStripMenuItem";
            this.addRecordsToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.addRecordsToolStripMenuItem.Text = "Add Records";
            // 
            // addToAirportTableToolStripMenuItem
            // 
            this.addToAirportTableToolStripMenuItem.Name = "addToAirportTableToolStripMenuItem";
            this.addToAirportTableToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.addToAirportTableToolStripMenuItem.Text = "Add to Airport to Airport Table";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.addToolStripMenuItem.Text = "Add Route to Route Table";
            // 
            // addRecordToResHistTableToolStripMenuItem
            // 
            this.addRecordToResHistTableToolStripMenuItem.Name = "addRecordToResHistTableToolStripMenuItem";
            this.addRecordToResHistTableToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.addRecordToResHistTableToolStripMenuItem.Text = "Add Record to ResHist Table";
            this.addRecordToResHistTableToolStripMenuItem.Click += new System.EventHandler(this.addRecordToResHistTableToolStripMenuItem_Click);
            // 
            // addAirplaneToAirplaneTableToolStripMenuItem
            // 
            this.addAirplaneToAirplaneTableToolStripMenuItem.Name = "addAirplaneToAirplaneTableToolStripMenuItem";
            this.addAirplaneToAirplaneTableToolStripMenuItem.Size = new System.Drawing.Size(235, 22);
            this.addAirplaneToAirplaneTableToolStripMenuItem.Text = "Add Airplane to Airplane Table";
            this.addAirplaneToAirplaneTableToolStripMenuItem.Click += new System.EventHandler(this.addAirplaneToAirplaneTableToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Buttons to Display Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(460, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(366, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Buttons to Add Records to Tables";
            // 
            // addAirplane
            // 
            this.addAirplane.Location = new System.Drawing.Point(756, 105);
            this.addAirplane.Name = "addAirplane";
            this.addAirplane.Size = new System.Drawing.Size(89, 38);
            this.addAirplane.TabIndex = 11;
            this.addAirplane.Text = "Add to Airplane Table";
            this.addAirplane.UseVisualStyleBackColor = true;
            this.addAirplane.Click += new System.EventHandler(this.addAirplane_Click);
            // 
            // addResHistBtn
            // 
            this.addResHistBtn.Location = new System.Drawing.Point(659, 105);
            this.addResHistBtn.Name = "addResHistBtn";
            this.addResHistBtn.Size = new System.Drawing.Size(89, 38);
            this.addResHistBtn.TabIndex = 12;
            this.addResHistBtn.Text = "Add to ResHist Table";
            this.addResHistBtn.UseVisualStyleBackColor = true;
            this.addResHistBtn.Click += new System.EventHandler(this.addResHistBtn_Click);
            // 
            // addRouteBtn
            // 
            this.addRouteBtn.Location = new System.Drawing.Point(562, 105);
            this.addRouteBtn.Name = "addRouteBtn";
            this.addRouteBtn.Size = new System.Drawing.Size(89, 38);
            this.addRouteBtn.TabIndex = 13;
            this.addRouteBtn.Text = "Add to Route Table";
            this.addRouteBtn.UseVisualStyleBackColor = true;
            // 
            // addAirportBtn
            // 
            this.addAirportBtn.Location = new System.Drawing.Point(465, 105);
            this.addAirportBtn.Name = "addAirportBtn";
            this.addAirportBtn.Size = new System.Drawing.Size(89, 38);
            this.addAirportBtn.TabIndex = 14;
            this.addAirportBtn.Text = "Add to Airport Table";
            this.addAirportBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 450);
            this.Controls.Add(this.addAirportBtn);
            this.Controls.Add(this.addRouteBtn);
            this.Controls.Add(this.addResHistBtn);
            this.Controls.Add(this.addAirplane);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.citiesBtn);
            this.Controls.Add(this.logsBtn);
            this.Controls.Add(this.crewBtn);
            this.Controls.Add(this.airportBtn);
            this.Controls.Add(this.cityBtn);
            this.Controls.Add(this.airplaneBtn);
            this.Controls.Add(this.flightBtn);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Caden, Mason and Greg\'s Group Project";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button flightBtn;
        private System.Windows.Forms.Button airplaneBtn;
        private System.Windows.Forms.Button cityBtn;
        private System.Windows.Forms.Button airportBtn;
        private System.Windows.Forms.Button crewBtn;
        private System.Windows.Forms.Button logsBtn;
        private System.Windows.Forms.Button citiesBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem airplanesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem routesWithCityNameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departingAndArrivingCitiesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allAirportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flightCrewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maintenanceLogsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecordsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToAirportTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addRecordToResHistTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addAirplaneToAirplaneTableToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addAirplane;
        private System.Windows.Forms.Button addResHistBtn;
        private System.Windows.Forms.Button addRouteBtn;
        private System.Windows.Forms.Button addAirportBtn;
    }
}

