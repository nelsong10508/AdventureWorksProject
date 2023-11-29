namespace PixisAirGroupProject
{
    partial class RoutesAndCities
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
            this.routeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // routeBtn
            // 
            this.routeBtn.AutoSize = true;
            this.routeBtn.Location = new System.Drawing.Point(345, 352);
            this.routeBtn.Name = "routeBtn";
            this.routeBtn.Size = new System.Drawing.Size(127, 33);
            this.routeBtn.TabIndex = 0;
            this.routeBtn.Text = "Routes With City Name";
            this.routeBtn.UseVisualStyleBackColor = true;
            this.routeBtn.Click += new System.EventHandler(this.routeBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(713, 405);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 33);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.HorizontalScrollbar = true;
            this.listBox1.Location = new System.Drawing.Point(23, 25);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(753, 290);
            this.listBox1.TabIndex = 2;
            // 
            // RoutesAndCities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.routeBtn);
            this.Name = "RoutesAndCities";
            this.Text = "RoutesAndCities";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button routeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ListBox listBox1;
    }
}