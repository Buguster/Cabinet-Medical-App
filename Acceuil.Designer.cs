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
            this.panel1 = new System.Windows.Forms.Panel();
            this.paiement = new Bunifu.Framework.UI.BunifuThinButton2();
            this.patient = new Bunifu.Framework.UI.BunifuThinButton2();
            this.stagiare = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ordonnace = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.Rendez_vous = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.Rendez_vous);
            this.panel1.Controls.Add(this.paiement);
            this.panel1.Controls.Add(this.patient);
            this.panel1.Controls.Add(this.stagiare);
            this.panel1.Controls.Add(this.ordonnace);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 692);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // paiement
            // 
            this.paiement.ActiveBorderThickness = 1;
            this.paiement.ActiveCornerRadius = 20;
            this.paiement.ActiveFillColor = System.Drawing.Color.Salmon;
            this.paiement.ActiveForecolor = System.Drawing.Color.White;
            this.paiement.ActiveLineColor = System.Drawing.Color.Navy;
            this.paiement.BackColor = System.Drawing.Color.Navy;
            this.paiement.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("paiement.BackgroundImage")));
            this.paiement.ButtonText = "paiement";
            this.paiement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.paiement.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paiement.ForeColor = System.Drawing.Color.SeaGreen;
            this.paiement.IdleBorderThickness = 1;
            this.paiement.IdleCornerRadius = 20;
            this.paiement.IdleFillColor = System.Drawing.Color.White;
            this.paiement.IdleForecolor = System.Drawing.Color.Navy;
            this.paiement.IdleLineColor = System.Drawing.Color.Navy;
            this.paiement.Location = new System.Drawing.Point(294, 549);
            this.paiement.Margin = new System.Windows.Forms.Padding(5);
            this.paiement.Name = "paiement";
            this.paiement.Size = new System.Drawing.Size(114, 45);
            this.paiement.TabIndex = 20;
            this.paiement.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.paiement.Click += new System.EventHandler(this.paiement_Click);
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
            this.patient.Location = new System.Drawing.Point(291, 429);
            this.patient.Margin = new System.Windows.Forms.Padding(5);
            this.patient.Name = "patient";
            this.patient.Size = new System.Drawing.Size(117, 44);
            this.patient.TabIndex = 19;
            this.patient.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patient.Click += new System.EventHandler(this.patient_Click);
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
            this.stagiare.Location = new System.Drawing.Point(286, 307);
            this.stagiare.Margin = new System.Windows.Forms.Padding(5);
            this.stagiare.Name = "stagiare";
            this.stagiare.Size = new System.Drawing.Size(122, 51);
            this.stagiare.TabIndex = 18;
            this.stagiare.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.stagiare.Click += new System.EventHandler(this.stagiare_Click);
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
            this.ordonnace.Location = new System.Drawing.Point(286, 185);
            this.ordonnace.Margin = new System.Windows.Forms.Padding(5);
            this.ordonnace.Name = "ordonnace";
            this.ordonnace.Size = new System.Drawing.Size(127, 58);
            this.ordonnace.TabIndex = 17;
            this.ordonnace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ordonnace.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.bunifuCustomLabel1);
            this.panel2.Location = new System.Drawing.Point(171, -3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(847, 130);
            this.panel2.TabIndex = 16;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(80, 30);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(591, 55);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Système Cabinet Médical";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 130);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(889, 633);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(129, 59);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 14;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Click += new System.EventHandler(this.pictureBox8_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(171, 283);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(73, 85);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 11;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(171, 520);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(73, 85);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 12;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(171, 401);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(73, 85);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(171, 170);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(73, 85);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            // 
            // Rendez_vous
            // 
            this.Rendez_vous.ActiveBorderThickness = 1;
            this.Rendez_vous.ActiveCornerRadius = 20;
            this.Rendez_vous.ActiveFillColor = System.Drawing.Color.Salmon;
            this.Rendez_vous.ActiveForecolor = System.Drawing.Color.White;
            this.Rendez_vous.ActiveLineColor = System.Drawing.Color.Navy;
            this.Rendez_vous.BackColor = System.Drawing.Color.Navy;
            this.Rendez_vous.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Rendez_vous.BackgroundImage")));
            this.Rendez_vous.ButtonText = "RDV";
            this.Rendez_vous.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Rendez_vous.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rendez_vous.ForeColor = System.Drawing.Color.SeaGreen;
            this.Rendez_vous.IdleBorderThickness = 1;
            this.Rendez_vous.IdleCornerRadius = 20;
            this.Rendez_vous.IdleFillColor = System.Drawing.Color.White;
            this.Rendez_vous.IdleForecolor = System.Drawing.Color.Navy;
            this.Rendez_vous.IdleLineColor = System.Drawing.Color.Navy;
            this.Rendez_vous.Location = new System.Drawing.Point(597, 536);
            this.Rendez_vous.Margin = new System.Windows.Forms.Padding(5);
            this.Rendez_vous.Name = "Rendez_vous";
            this.Rendez_vous.Size = new System.Drawing.Size(127, 58);
            this.Rendez_vous.TabIndex = 21;
            this.Rendez_vous.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Rendez_vous.Click += new System.EventHandler(this.Rendez_vous_Click);
            // 
            // Acceuil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 692);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Acceuil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Acceuil_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuThinButton2 paiement;
        private Bunifu.Framework.UI.BunifuThinButton2 patient;
        private Bunifu.Framework.UI.BunifuThinButton2 stagiare;
        private Bunifu.Framework.UI.BunifuThinButton2 ordonnace;
        private Bunifu.Framework.UI.BunifuThinButton2 Rendez_vous;
    }
}