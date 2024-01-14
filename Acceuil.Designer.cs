namespace medical_app
{
    partial class Acceuil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Acceuil));
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.stagiare = new Bunifu.Framework.UI.BunifuThinButton2();
            this.Rendez_vous = new Bunifu.Framework.UI.BunifuThinButton2();
            this.patient = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ordonnace = new Bunifu.Framework.UI.BunifuThinButton2();
            this.paiement = new Bunifu.Framework.UI.BunifuThinButton2();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.total = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.total_patient = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.total.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Location = new System.Drawing.Point(171, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 97);
            this.panel2.TabIndex = 16;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(147, 25);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(591, 55);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Système Cabinet Médical";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Lavender;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Controls.Add(this.pictureBox8);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 692);
            this.panel3.TabIndex = 22;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel4.Controls.Add(this.stagiare);
            this.panel4.Controls.Add(this.Rendez_vous);
            this.panel4.Controls.Add(this.patient);
            this.panel4.Controls.Add(this.ordonnace);
            this.panel4.Controls.Add(this.paiement);
            this.panel4.Location = new System.Drawing.Point(0, 233);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 262);
            this.panel4.TabIndex = 1;
            // 
            // stagiare
            // 
            this.stagiare.ActiveBorderThickness = 1;
            this.stagiare.ActiveCornerRadius = 20;
            this.stagiare.ActiveFillColor = System.Drawing.Color.Salmon;
            this.stagiare.ActiveForecolor = System.Drawing.Color.White;
            this.stagiare.ActiveLineColor = System.Drawing.Color.Navy;
            this.stagiare.BackColor = System.Drawing.Color.LightSteelBlue;
            this.stagiare.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("stagiare.BackgroundImage")));
            this.stagiare.ButtonText = "Stagiares";
            this.stagiare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stagiare.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stagiare.ForeColor = System.Drawing.Color.SeaGreen;
            this.stagiare.IdleBorderThickness = 1;
            this.stagiare.IdleCornerRadius = 20;
            this.stagiare.IdleFillColor = System.Drawing.Color.White;
            this.stagiare.IdleForecolor = System.Drawing.Color.Navy;
            this.stagiare.IdleLineColor = System.Drawing.Color.LightSteelBlue;
            this.stagiare.Location = new System.Drawing.Point(62, 211);
            this.stagiare.Margin = new System.Windows.Forms.Padding(5);
            this.stagiare.Name = "stagiare";
            this.stagiare.Size = new System.Drawing.Size(114, 33);
            this.stagiare.TabIndex = 18;
            this.stagiare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stagiare.Click += new System.EventHandler(this.stagiare_Click);
            // 
            // Rendez_vous
            // 
            this.Rendez_vous.ActiveBorderThickness = 1;
            this.Rendez_vous.ActiveCornerRadius = 20;
            this.Rendez_vous.ActiveFillColor = System.Drawing.Color.Salmon;
            this.Rendez_vous.ActiveForecolor = System.Drawing.Color.White;
            this.Rendez_vous.ActiveLineColor = System.Drawing.Color.Navy;
            this.Rendez_vous.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Rendez_vous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rendez_vous.BackgroundImage")));
            this.Rendez_vous.ButtonText = "RDV";
            this.Rendez_vous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rendez_vous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rendez_vous.ForeColor = System.Drawing.Color.SeaGreen;
            this.Rendez_vous.IdleBorderThickness = 1;
            this.Rendez_vous.IdleCornerRadius = 20;
            this.Rendez_vous.IdleFillColor = System.Drawing.Color.White;
            this.Rendez_vous.IdleForecolor = System.Drawing.Color.Navy;
            this.Rendez_vous.IdleLineColor = System.Drawing.Color.LightSteelBlue;
            this.Rendez_vous.Location = new System.Drawing.Point(62, 117);
            this.Rendez_vous.Margin = new System.Windows.Forms.Padding(5);
            this.Rendez_vous.Name = "Rendez_vous";
            this.Rendez_vous.Size = new System.Drawing.Size(114, 37);
            this.Rendez_vous.TabIndex = 21;
            this.Rendez_vous.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rendez_vous.Click += new System.EventHandler(this.Rendez_vous_Click);
            // 
            // patient
            // 
            this.patient.ActiveBorderThickness = 1;
            this.patient.ActiveCornerRadius = 20;
            this.patient.ActiveFillColor = System.Drawing.Color.Salmon;
            this.patient.ActiveForecolor = System.Drawing.Color.White;
            this.patient.ActiveLineColor = System.Drawing.Color.Navy;
            this.patient.BackColor = System.Drawing.Color.LightSteelBlue;
            this.patient.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("patient.BackgroundImage")));
            this.patient.ButtonText = "Patients";
            this.patient.Cursor = System.Windows.Forms.Cursors.Hand;
            this.patient.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient.ForeColor = System.Drawing.Color.SeaGreen;
            this.patient.IdleBorderThickness = 1;
            this.patient.IdleCornerRadius = 20;
            this.patient.IdleFillColor = System.Drawing.Color.White;
            this.patient.IdleForecolor = System.Drawing.Color.Navy;
            this.patient.IdleLineColor = System.Drawing.Color.LightSteelBlue;
            this.patient.Location = new System.Drawing.Point(59, 26);
            this.patient.Margin = new System.Windows.Forms.Padding(5);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(117, 32);
            this.patient.TabIndex = 19;
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
            this.ordonnace.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ordonnace.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ordonnace.BackgroundImage")));
            this.ordonnace.ButtonText = "Ordonnance";
            this.ordonnace.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ordonnace.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ordonnace.ForeColor = System.Drawing.Color.SeaGreen;
            this.ordonnace.IdleBorderThickness = 1;
            this.ordonnace.IdleCornerRadius = 20;
            this.ordonnace.IdleFillColor = System.Drawing.Color.White;
            this.ordonnace.IdleForecolor = System.Drawing.Color.Navy;
            this.ordonnace.IdleLineColor = System.Drawing.Color.LightSteelBlue;
            this.ordonnace.Location = new System.Drawing.Point(62, 68);
            this.ordonnace.Margin = new System.Windows.Forms.Padding(5);
            this.ordonnace.Name = "ordonnace";
            this.ordonnace.Size = new System.Drawing.Size(114, 39);
            this.ordonnace.TabIndex = 17;
            this.ordonnace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ordonnace.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // paiement
            // 
            this.paiement.ActiveBorderThickness = 1;
            this.paiement.ActiveCornerRadius = 20;
            this.paiement.ActiveFillColor = System.Drawing.Color.Salmon;
            this.paiement.ActiveForecolor = System.Drawing.Color.White;
            this.paiement.ActiveLineColor = System.Drawing.Color.Navy;
            this.paiement.BackColor = System.Drawing.Color.LightSteelBlue;
            this.paiement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paiement.BackgroundImage")));
            this.paiement.ButtonText = "paiement";
            this.paiement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paiement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paiement.ForeColor = System.Drawing.Color.SeaGreen;
            this.paiement.IdleBorderThickness = 1;
            this.paiement.IdleCornerRadius = 20;
            this.paiement.IdleFillColor = System.Drawing.Color.White;
            this.paiement.IdleForecolor = System.Drawing.Color.Navy;
            this.paiement.IdleLineColor = System.Drawing.Color.LightSteelBlue;
            this.paiement.Location = new System.Drawing.Point(62, 164);
            this.paiement.Margin = new System.Windows.Forms.Padding(5);
            this.paiement.Name = "paiement";
            this.paiement.Size = new System.Drawing.Size(114, 37);
            this.paiement.TabIndex = 20;
            this.paiement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paiement.Click += new System.EventHandler(this.paiement_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(0, 633);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(200, 59);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // total
            // 
            this.total.BackColor = System.Drawing.Color.Navy;
            this.total.Controls.Add(this.pictureBox2);
            this.total.Controls.Add(this.bunifuCustomLabel3);
            this.total.Controls.Add(this.textBox3);
            this.total.Controls.Add(this.bunifuCustomLabel2);
            this.total.Controls.Add(this.textBox2);
            this.total.Controls.Add(this.total_patient);
            this.total.Controls.Add(this.textBox1);
            this.total.Controls.Add(this.panel3);
            this.total.Controls.Add(this.panel2);
            this.total.Dock = System.Windows.Forms.DockStyle.Fill;
            this.total.Location = new System.Drawing.Point(0, 0);
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(1018, 692);
            this.total.TabIndex = 0;
            this.total.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(579, 113);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(427, 287);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(762, 602);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(97, 20);
            this.bunifuCustomLabel3.TabIndex = 28;
            this.bunifuCustomLabel3.Text = "Total RDV ";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(865, 588);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(76, 57);
            this.textBox3.TabIndex = 27;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(672, 514);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(187, 20);
            this.bunifuCustomLabel2.TabIndex = 26;
            this.bunifuCustomLabel2.Text = "Total RDV Aujourd\'hui";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(865, 500);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 57);
            this.textBox2.TabIndex = 25;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // total_patient
            // 
            this.total_patient.AutoSize = true;
            this.total_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_patient.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.total_patient.Location = new System.Drawing.Point(743, 440);
            this.total_patient.Name = "total_patient";
            this.total_patient.Size = new System.Drawing.Size(116, 20);
            this.total_patient.TabIndex = 24;
            this.total_patient.Text = "Patient_Total";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(865, 426);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(76, 57);
            this.textBox1.TabIndex = 23;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 692);
            this.Controls.Add(this.total);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Acceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Acceuil_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.total.ResumeLayout(false);
            this.total.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuThinButton2 stagiare;
        private Bunifu.Framework.UI.BunifuThinButton2 Rendez_vous;
        private Bunifu.Framework.UI.BunifuThinButton2 patient;
        private Bunifu.Framework.UI.BunifuThinButton2 ordonnace;
        private Bunifu.Framework.UI.BunifuThinButton2 paiement;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel total;
        private Bunifu.Framework.UI.BunifuCustomLabel total_patient;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}