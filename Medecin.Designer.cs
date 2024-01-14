namespace medical_app
{
    partial class Medecin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Medecin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.patient = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ordonnace = new Bunifu.Framework.UI.BunifuThinButton2();
            this.stagiare = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 692);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Navy;
            this.panel3.Controls.Add(this.patient);
            this.panel3.Controls.Add(this.ordonnace);
            this.panel3.Controls.Add(this.stagiare);
            this.panel3.Location = new System.Drawing.Point(3, 102);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(170, 590);
            this.panel3.TabIndex = 31;
            // 
            // patient
            // 
            this.patient.ActiveBorderThickness = 1;
            this.patient.ActiveCornerRadius = 20;
            this.patient.ActiveFillColor = System.Drawing.Color.Salmon;
            this.patient.ActiveForecolor = System.Drawing.Color.White;
            this.patient.ActiveLineColor = System.Drawing.Color.Navy;
            this.patient.BackColor = System.Drawing.Color.Navy;
            this.patient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("patient.BackgroundImage")));
            this.patient.ButtonText = "Patients";
            this.patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.ForeColor = System.Drawing.Color.SeaGreen;
            this.patient.IdleBorderThickness = 1;
            this.patient.IdleCornerRadius = 20;
            this.patient.IdleFillColor = System.Drawing.Color.White;
            this.patient.IdleForecolor = System.Drawing.Color.Navy;
            this.patient.IdleLineColor = System.Drawing.Color.Navy;
            this.patient.Location = new System.Drawing.Point(11, 106);
            this.patient.Margin = new System.Windows.Forms.Padding(5);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(117, 44);
            this.patient.TabIndex = 27;
            this.patient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patient.Click += new System.EventHandler(this.patient_Click);
            // 
            // ordonnace
            // 
            this.ordonnace.ActiveBorderThickness = 1;
            this.ordonnace.ActiveCornerRadius = 20;
            this.ordonnace.ActiveFillColor = System.Drawing.Color.Salmon;
            this.ordonnace.ActiveForecolor = System.Drawing.Color.White;
            this.ordonnace.ActiveLineColor = System.Drawing.Color.Navy;
            this.ordonnace.BackColor = System.Drawing.Color.Navy;
            this.ordonnace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ordonnace.BackgroundImage")));
            this.ordonnace.ButtonText = "Ordonnance";
            this.ordonnace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordonnace.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordonnace.ForeColor = System.Drawing.Color.SeaGreen;
            this.ordonnace.IdleBorderThickness = 1;
            this.ordonnace.IdleCornerRadius = 20;
            this.ordonnace.IdleFillColor = System.Drawing.Color.White;
            this.ordonnace.IdleForecolor = System.Drawing.Color.Navy;
            this.ordonnace.IdleLineColor = System.Drawing.Color.Navy;
            this.ordonnace.Location = new System.Drawing.Point(11, 230);
            this.ordonnace.Margin = new System.Windows.Forms.Padding(5);
            this.ordonnace.Name = "ordonnace";
            this.ordonnace.Size = new System.Drawing.Size(117, 38);
            this.ordonnace.TabIndex = 25;
            this.ordonnace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ordonnace.Click += new System.EventHandler(this.ordonnace_Click);
            // 
            // stagiare
            // 
            this.stagiare.ActiveBorderThickness = 1;
            this.stagiare.ActiveCornerRadius = 20;
            this.stagiare.ActiveFillColor = System.Drawing.Color.Salmon;
            this.stagiare.ActiveForecolor = System.Drawing.Color.White;
            this.stagiare.ActiveLineColor = System.Drawing.Color.Navy;
            this.stagiare.BackColor = System.Drawing.Color.Navy;
            this.stagiare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stagiare.BackgroundImage")));
            this.stagiare.ButtonText = "Stagiares";
            this.stagiare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stagiare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stagiare.ForeColor = System.Drawing.Color.SeaGreen;
            this.stagiare.IdleBorderThickness = 1;
            this.stagiare.IdleCornerRadius = 20;
            this.stagiare.IdleFillColor = System.Drawing.Color.White;
            this.stagiare.IdleForecolor = System.Drawing.Color.Navy;
            this.stagiare.IdleLineColor = System.Drawing.Color.Navy;
            this.stagiare.Location = new System.Drawing.Point(11, 172);
            this.stagiare.Margin = new System.Windows.Forms.Padding(5);
            this.stagiare.Name = "stagiare";
            this.stagiare.Size = new System.Drawing.Size(117, 39);
            this.stagiare.TabIndex = 26;
            this.stagiare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Location = new System.Drawing.Point(167, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(851, 96);
            this.panel2.TabIndex = 29;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(140, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(591, 55);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Système Cabinet Médical";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(972, 633);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(46, 59);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 30;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // Medecin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 692);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Medecin";
            this.Text = "Medecin";
            this.Load += new System.EventHandler(this.Medecin_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 patient;
        private Bunifu.Framework.UI.BunifuThinButton2 stagiare;
        private Bunifu.Framework.UI.BunifuThinButton2 ordonnace;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel3;
    }
}