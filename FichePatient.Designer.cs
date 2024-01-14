namespace medical_app
{
    partial class FichePatient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FichePatient));
            this.PatientGrid = new System.Windows.Forms.DataGridView();
            this.load_patient = new System.Windows.Forms.Button();
            this.Id_Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom_Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_création = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Téléphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Afficher = new System.Windows.Forms.DataGridViewButtonColumn();
            this.inputsearchname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.rechercher = new Bunifu.Framework.UI.BunifuThinButton2();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientGrid
            // 
            this.PatientGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.PatientGrid.AllowUserToOrderColumns = true;
            this.PatientGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.PatientGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PatientGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PatientGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.PatientGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_Patient,
            this.Nom_patient,
            this.Prenom_Patient,
            this.Date_création,
            this.Ville,
            this.Téléphone,
            this.Date_naissance,
            this.symptomes,
            this.Etat,
            this.Sexe,
            this.Afficher});
            this.PatientGrid.Location = new System.Drawing.Point(27, 78);
            this.PatientGrid.Name = "PatientGrid";
            this.PatientGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.PatientGrid.RowHeadersWidth = 50;
            this.PatientGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PatientGrid.Size = new System.Drawing.Size(922, 505);
            this.PatientGrid.TabIndex = 6;
            this.PatientGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PatientGrid_CellContentClick);
            // 
            // load_patient
            // 
            this.load_patient.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_patient.Location = new System.Drawing.Point(27, 12);
            this.load_patient.Name = "load_patient";
            this.load_patient.Size = new System.Drawing.Size(204, 49);
            this.load_patient.TabIndex = 8;
            this.load_patient.Text = "Liste Des Patients";
            this.load_patient.UseVisualStyleBackColor = true;
            this.load_patient.Click += new System.EventHandler(this.button2_Click);
            // 
            // Id_Patient
            // 
            this.Id_Patient.HeaderText = "ID_Patient";
            this.Id_Patient.Name = "Id_Patient";
            // 
            // Nom_patient
            // 
            this.Nom_patient.HeaderText = "Nom";
            this.Nom_patient.Name = "Nom_patient";
            // 
            // Prenom_Patient
            // 
            this.Prenom_Patient.HeaderText = "Prenom";
            this.Prenom_Patient.Name = "Prenom_Patient";
            // 
            // Date_création
            // 
            this.Date_création.HeaderText = "date création dossier";
            this.Date_création.Name = "Date_création";
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            // 
            // Téléphone
            // 
            this.Téléphone.HeaderText = "Téléphone";
            this.Téléphone.Name = "Téléphone";
            // 
            // Date_naissance
            // 
            this.Date_naissance.HeaderText = "Date Naissance";
            this.Date_naissance.Name = "Date_naissance";
            // 
            // symptomes
            // 
            this.symptomes.HeaderText = "Symptômes";
            this.symptomes.Name = "symptomes";
            // 
            // Etat
            // 
            this.Etat.HeaderText = "Etat";
            this.Etat.Name = "Etat";
            // 
            // Sexe
            // 
            this.Sexe.HeaderText = "Genre";
            this.Sexe.Name = "Sexe";
            // 
            // Afficher
            // 
            this.Afficher.HeaderText = "AFFICHER";
            this.Afficher.Name = "Afficher";
            this.Afficher.Text = "afficher";
            // 
            // inputsearchname
            // 
            this.inputsearchname.BackColor = System.Drawing.Color.MintCream;
            this.inputsearchname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputsearchname.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.inputsearchname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputsearchname.HintForeColor = System.Drawing.Color.Empty;
            this.inputsearchname.HintText = "";
            this.inputsearchname.isPassword = false;
            this.inputsearchname.LineFocusedColor = System.Drawing.Color.Blue;
            this.inputsearchname.LineIdleColor = System.Drawing.Color.Gray;
            this.inputsearchname.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.inputsearchname.LineThickness = 3;
            this.inputsearchname.Location = new System.Drawing.Point(553, 17);
            this.inputsearchname.Margin = new System.Windows.Forms.Padding(4);
            this.inputsearchname.Name = "inputsearchname";
            this.inputsearchname.Size = new System.Drawing.Size(183, 44);
            this.inputsearchname.TabIndex = 12;
            this.inputsearchname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // rechercher
            // 
            this.rechercher.ActiveBorderThickness = 1;
            this.rechercher.ActiveCornerRadius = 20;
            this.rechercher.ActiveFillColor = System.Drawing.Color.Salmon;
            this.rechercher.ActiveForecolor = System.Drawing.Color.White;
            this.rechercher.ActiveLineColor = System.Drawing.Color.Navy;
            this.rechercher.BackColor = System.Drawing.Color.SteelBlue;
            this.rechercher.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("rechercher.BackgroundImage")));
            this.rechercher.ButtonText = "rechercher";
            this.rechercher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rechercher.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rechercher.ForeColor = System.Drawing.Color.SeaGreen;
            this.rechercher.IdleBorderThickness = 1;
            this.rechercher.IdleCornerRadius = 20;
            this.rechercher.IdleFillColor = System.Drawing.Color.White;
            this.rechercher.IdleForecolor = System.Drawing.Color.Navy;
            this.rechercher.IdleLineColor = System.Drawing.Color.Navy;
            this.rechercher.Location = new System.Drawing.Point(745, 17);
            this.rechercher.Margin = new System.Windows.Forms.Padding(5);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(137, 41);
            this.rechercher.TabIndex = 13;
            this.rechercher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
            // 
            // FichePatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(995, 613);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.inputsearchname);
            this.Controls.Add(this.load_patient);
            this.Controls.Add(this.PatientGrid);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FichePatient";
            this.Text = "FichePatient";
            this.Load += new System.EventHandler(this.FichePatient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.Button load_patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom_Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_création;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn Téléphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptomes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe;
        private System.Windows.Forms.DataGridViewButtonColumn Afficher;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputsearchname;
        private Bunifu.Framework.UI.BunifuThinButton2 rechercher;
    }
}