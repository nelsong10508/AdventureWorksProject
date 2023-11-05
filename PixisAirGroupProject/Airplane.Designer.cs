namespace PixisAirGroupProject
{
    partial class Airplane
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
            this.airPlaneBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // airPlaneBtn
            // 
            this.airPlaneBtn.Location = new System.Drawing.Point(326, 367);
            this.airPlaneBtn.Name = "airPlaneBtn";
            this.airPlaneBtn.Size = new System.Drawing.Size(88, 41);
            this.airPlaneBtn.TabIndex = 0;
            this.airPlaneBtn.Text = "All Airplanes";
            this.airPlaneBtn.UseVisualStyleBackColor = true;
            this.airPlaneBtn.Click += new System.EventHandler(this.airPlaneBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(700, 397);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(88, 41);
            this.exitBtn.TabIndex = 1;
            this.exitBtn.Text = "EXIT";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(13, 24);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(765, 290);
            this.listBox1.TabIndex = 2;
            // 
            // Airplane
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.airPlaneBtn);
            this.Name = "Airplane";
            this.Text = "Airplane";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button airPlaneBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ListBox listBox1;
    }
}