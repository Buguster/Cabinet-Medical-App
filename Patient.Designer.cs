namespace medical_app
{
    partial class Patient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Patient));
            this.label1 = new System.Windows.Forms.Label();
            this.PatientGrid = new System.Windows.Forms.DataGridView();
            this.Id_Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom_patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom_Patient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_création = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Téléphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date_naissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.symptomes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Etat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rénitialiser = new System.Windows.Forms.Button();
            this.modifier = new System.Windows.Forms.Button();
            this.dateTimePickerDateCreated = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dateTimePickerDateNaiss = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label11 = new System.Windows.Forms.Label();
            this.inputTel = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.afficher = new System.Windows.Forms.Button();
            this.ajouter = new System.Windows.Forms.Button();
            this.btn_supprimer = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.bunifuMaterialTextbox8 = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.inputSymptome = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputEtat = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.inputSexe = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.inputVille = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.inputNom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.inputPrenom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.retour = new System.Windows.Forms.Button();
            this.rechercher = new Bunifu.Framework.UI.BunifuThinButton2();
            this.inputsearchname = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            ((System.ComponentModel.ISupportInitialize)(this.PatientGrid)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Salmon;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(21, 518);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Liste Des Patients";
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
            this.Age,
            this.Téléphone,
            this.Date_naissance,
            this.symptomes,
            this.Etat,
            this.Sexe});
            this.PatientGrid.Location = new System.Drawing.Point(17, 546);
            this.PatientGrid.Name = "PatientGrid";
            this.PatientGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.PatientGrid.RowHeadersWidth = 50;
            this.PatientGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.PatientGrid.Size = new System.Drawing.Size(1101, 182);
            this.PatientGrid.TabIndex = 5;
            this.PatientGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            // Age
            // 
            this.Age.HeaderText = "Ville";
            this.Age.Name = "Age";
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
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.rénitialiser);
            this.panel1.Controls.Add(this.modifier);
            this.panel1.Controls.Add(this.dateTimePickerDateCreated);
            this.panel1.Controls.Add(this.dateTimePickerDateNaiss);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.inputTel);
            this.panel1.Controls.Add(this.afficher);
            this.panel1.Controls.Add(this.ajouter);
            this.panel1.Controls.Add(this.btn_supprimer);
            this.panel1.Controls.Add(this.title);
            this.panel1.Controls.Add(this.bunifuMaterialTextbox8);
            this.panel1.Controls.Add(this.inputSymptome);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.inputEtat);
            this.panel1.Controls.Add(this.inputSexe);
            this.panel1.Controls.Add(this.inputVille);
            this.panel1.Controls.Add(this.inputNom);
            this.panel1.Controls.Add(this.inputPrenom);
            this.panel1.Location = new System.Drawing.Point(241, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(877, 484);
            this.panel1.TabIndex = 1;
            // 
            // rénitialiser
            // 
            this.rénitialiser.BackColor = System.Drawing.Color.OrangeRed;
            this.rénitialiser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rénitialiser.ForeColor = System.Drawing.Color.White;
            this.rénitialiser.Location = new System.Drawing.Point(579, 439);
            this.rénitialiser.Name = "rénitialiser";
            this.rénitialiser.Size = new System.Drawing.Size(134, 39);
            this.rénitialiser.TabIndex = 46;
            this.rénitialiser.Text = "Rénisialiser";
            this.rénitialiser.UseVisualStyleBackColor = false;
            this.rénitialiser.Click += new System.EventHandler(this.rénitialiser_Click);
            // 
            // modifier
            // 
            this.modifier.BackColor = System.Drawing.Color.Black;
            this.modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifier.ForeColor = System.Drawing.Color.White;
            this.modifier.Location = new System.Drawing.Point(249, 439);
            this.modifier.Name = "modifier";
            this.modifier.Size = new System.Drawing.Size(98, 39);
            this.modifier.TabIndex = 9;
            this.modifier.Text = "modifier";
            this.modifier.UseVisualStyleBackColor = false;
            this.modifier.Click += new System.EventHandler(this.modifier_Click);
            // 
            // dateTimePickerDateCreated
            // 
            this.dateTimePickerDateCreated.BackColor = System.Drawing.Color.Navy;
            this.dateTimePickerDateCreated.BorderRadius = 0;
            this.dateTimePickerDateCreated.ForeColor = System.Drawing.Color.White;
            this.dateTimePickerDateCreated.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerDateCreated.FormatCustom = null;
            this.dateTimePickerDateCreated.Location = new System.Drawing.Point(220, 195);
            this.dateTimePickerDateCreated.Name = "dateTimePickerDateCreated";
            this.dateTimePickerDateCreated.Size = new System.Drawing.Size(127, 24);
            this.dateTimePickerDateCreated.TabIndex = 45;
            this.dateTimePickerDateCreated.Value = new System.DateTime(2024, 1, 10, 19, 7, 42, 144);
            // 
            // dateTimePickerDateNaiss
            // 
            this.dateTimePickerDateNaiss.BackColor = System.Drawing.Color.Navy;
            this.dateTimePickerDateNaiss.BorderRadius = 0;
            this.dateTimePickerDateNaiss.ForeColor = System.Drawing.Color.White;
            this.dateTimePickerDateNaiss.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dateTimePickerDateNaiss.FormatCustom = null;
            this.dateTimePickerDateNaiss.Location = new System.Drawing.Point(574, 47);
            this.dateTimePickerDateNaiss.Name = "dateTimePickerDateNaiss";
            this.dateTimePickerDateNaiss.Size = new System.Drawing.Size(177, 24);
            this.dateTimePickerDateNaiss.TabIndex = 44;
            this.dateTimePickerDateNaiss.Value = new System.DateTime(2024, 1, 10, 19, 7, 42, 144);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(15, 360);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 24);
            this.label11.TabIndex = 41;
            this.label11.Text = "N° Téléphone";
            // 
            // inputTel
            // 
            this.inputTel.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputTel.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.inputTel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputTel.HintForeColor = System.Drawing.Color.Empty;
            this.inputTel.HintText = "";
            this.inputTel.isPassword = false;
            this.inputTel.LineFocusedColor = System.Drawing.Color.Blue;
            this.inputTel.LineIdleColor = System.Drawing.Color.Gray;
            this.inputTel.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.inputTel.LineThickness = 3;
            this.inputTel.Location = new System.Drawing.Point(170, 340);
            this.inputTel.Margin = new System.Windows.Forms.Padding(4);
            this.inputTel.Name = "inputTel";
            this.inputTel.Size = new System.Drawing.Size(177, 44);
            this.inputTel.TabIndex = 5;
            this.inputTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // afficher
            // 
            this.afficher.BackColor = System.Drawing.Color.Gray;
            this.afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficher.ForeColor = System.Drawing.Color.White;
            this.afficher.Location = new System.Drawing.Point(474, 439);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(99, 39);
            this.afficher.TabIndex = 11;
            this.afficher.Text = "Afficher";
            this.afficher.UseVisualStyleBackColor = false;
            this.afficher.Click += new System.EventHandler(this.afficher_Click);
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.Green;
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.ForeColor = System.Drawing.Color.White;
            this.ajouter.Location = new System.Drawing.Point(153, 439);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(86, 39);
            this.ajouter.TabIndex = 8;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // btn_supprimer
            // 
            this.btn_supprimer.AccessibleRole = System.Windows.Forms.AccessibleRole.ScrollBar;
            this.btn_supprimer.BackColor = System.Drawing.Color.Red;
            this.btn_supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_supprimer.ForeColor = System.Drawing.Color.White;
            this.btn_supprimer.Location = new System.Drawing.Point(353, 439);
            this.btn_supprimer.Name = "btn_supprimer";
            this.btn_supprimer.Size = new System.Drawing.Size(115, 39);
            this.btn_supprimer.TabIndex = 10;
            this.btn_supprimer.Text = "Supprimer";
            this.btn_supprimer.UseVisualStyleBackColor = false;
            this.btn_supprimer.Click += new System.EventHandler(this.btn_supprimer_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Navy;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(245, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(299, 24);
            this.title.TabIndex = 34;
            this.title.Text = "Formulaire Informations Patient";
            // 
            // bunifuMaterialTextbox8
            // 
            this.bunifuMaterialTextbox8.AccessibleName = "inputtype_assurance";
            this.bunifuMaterialTextbox8.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.bunifuMaterialTextbox8.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.bunifuMaterialTextbox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.bunifuMaterialTextbox8.HintForeColor = System.Drawing.Color.Empty;
            this.bunifuMaterialTextbox8.HintText = "";
            this.bunifuMaterialTextbox8.isPassword = false;
            this.bunifuMaterialTextbox8.LineFocusedColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox8.LineIdleColor = System.Drawing.Color.Gray;
            this.bunifuMaterialTextbox8.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.bunifuMaterialTextbox8.LineThickness = 3;
            this.bunifuMaterialTextbox8.Location = new System.Drawing.Point(574, 93);
            this.bunifuMaterialTextbox8.Margin = new System.Windows.Forms.Padding(4);
            this.bunifuMaterialTextbox8.Name = "bunifuMaterialTextbox8";
            this.bunifuMaterialTextbox8.Size = new System.Drawing.Size(177, 42);
            this.bunifuMaterialTextbox8.TabIndex = 6;
            this.bunifuMaterialTextbox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputSymptome
            // 
            this.inputSymptome.AccessibleName = "inputSymptomes";
            this.inputSymptome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputSymptome.Location = new System.Drawing.Point(415, 238);
            this.inputSymptome.Multiline = true;
            this.inputSymptome.Name = "inputSymptome";
            this.inputSymptome.Size = new System.Drawing.Size(336, 129);
            this.inputSymptome.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 247);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 24);
            this.label10.TabIndex = 30;
            this.label10.Text = "Genre";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 24);
            this.label9.TabIndex = 29;
            this.label9.Text = "Etat";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 111);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 24);
            this.label8.TabIndex = 28;
            this.label8.Text = "Type Assurance";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(383, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(118, 24);
            this.label7.TabIndex = 27;
            this.label7.Text = "Symptômes";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(376, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 24);
            this.label6.TabIndex = 26;
            this.label6.Text = "date naissance";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(9, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 24);
            this.label5.TabIndex = 25;
            this.label5.Text = "Ville";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 24);
            this.label4.TabIndex = 24;
            this.label4.Text = "Date Création dossier";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Prenom";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 24);
            this.label2.TabIndex = 22;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // inputEtat
            // 
            this.inputEtat.AccessibleName = "inputEtat";
            this.inputEtat.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputEtat.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.inputEtat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputEtat.HintForeColor = System.Drawing.Color.Empty;
            this.inputEtat.HintText = "";
            this.inputEtat.isPassword = false;
            this.inputEtat.LineFocusedColor = System.Drawing.Color.Blue;
            this.inputEtat.LineIdleColor = System.Drawing.Color.Gray;
            this.inputEtat.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.inputEtat.LineThickness = 3;
            this.inputEtat.Location = new System.Drawing.Point(87, 289);
            this.inputEtat.Margin = new System.Windows.Forms.Padding(4);
            this.inputEtat.Name = "inputEtat";
            this.inputEtat.Size = new System.Drawing.Size(177, 42);
            this.inputEtat.TabIndex = 4;
            this.inputEtat.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputSexe
            // 
            this.inputSexe.AccessibleName = "inputGenre";
            this.inputSexe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputSexe.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.inputSexe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputSexe.HintForeColor = System.Drawing.Color.Empty;
            this.inputSexe.HintText = "";
            this.inputSexe.isPassword = false;
            this.inputSexe.LineFocusedColor = System.Drawing.Color.Blue;
            this.inputSexe.LineIdleColor = System.Drawing.Color.Gray;
            this.inputSexe.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.inputSexe.LineThickness = 3;
            this.inputSexe.Location = new System.Drawing.Point(87, 229);
            this.inputSexe.Margin = new System.Windows.Forms.Padding(4);
            this.inputSexe.Name = "inputSexe";
            this.inputSexe.Size = new System.Drawing.Size(177, 42);
            this.inputSexe.TabIndex = 3;
            this.inputSexe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputVille
            // 
            this.inputVille.AccessibleName = "inputVille";
            this.inputVille.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputVille.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.inputVille.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputVille.HintForeColor = System.Drawing.Color.Empty;
            this.inputVille.HintText = "";
            this.inputVille.isPassword = false;
            this.inputVille.LineFocusedColor = System.Drawing.Color.Blue;
            this.inputVille.LineIdleColor = System.Drawing.Color.Gray;
            this.inputVille.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.inputVille.LineThickness = 3;
            this.inputVille.Location = new System.Drawing.Point(71, 127);
            this.inputVille.Margin = new System.Windows.Forms.Padding(4);
            this.inputVille.Name = "inputVille";
            this.inputVille.Size = new System.Drawing.Size(177, 42);
            this.inputVille.TabIndex = 2;
            this.inputVille.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputNom
            // 
            this.inputNom.AccessibleName = "inputNom";
            this.inputNom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputNom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.inputNom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputNom.HintForeColor = System.Drawing.Color.Empty;
            this.inputNom.HintText = "";
            this.inputNom.isPassword = false;
            this.inputNom.LineFocusedColor = System.Drawing.Color.Blue;
            this.inputNom.LineIdleColor = System.Drawing.Color.Gray;
            this.inputNom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.inputNom.LineThickness = 3;
            this.inputNom.Location = new System.Drawing.Point(71, 81);
            this.inputNom.Margin = new System.Windows.Forms.Padding(5);
            this.inputNom.Name = "inputNom";
            this.inputNom.Size = new System.Drawing.Size(193, 40);
            this.inputNom.TabIndex = 1;
            this.inputNom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // inputPrenom
            // 
            this.inputPrenom.AccessibleName = "inputprenom";
            this.inputPrenom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.inputPrenom.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inputPrenom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.inputPrenom.HintForeColor = System.Drawing.Color.Empty;
            this.inputPrenom.HintText = "";
            this.inputPrenom.isPassword = false;
            this.inputPrenom.LineFocusedColor = System.Drawing.Color.Blue;
            this.inputPrenom.LineIdleColor = System.Drawing.Color.Gray;
            this.inputPrenom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.inputPrenom.LineThickness = 3;
            this.inputPrenom.Location = new System.Drawing.Point(87, 19);
            this.inputPrenom.Margin = new System.Windows.Forms.Padding(5);
            this.inputPrenom.Name = "inputPrenom";
            this.inputPrenom.Size = new System.Drawing.Size(221, 52);
            this.inputPrenom.TabIndex = 0;
            this.inputPrenom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // retour
            // 
            this.retour.BackColor = System.Drawing.Color.AliceBlue;
            this.retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.Location = new System.Drawing.Point(26, 12);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(137, 37);
            this.retour.TabIndex = 9;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            this.retour.Click += new System.EventHandler(this.button1_Click);
            // 
            // rechercher
            // 
            this.rechercher.ActiveBorderThickness = 1;
            this.rechercher.ActiveCornerRadius = 20;
            this.rechercher.ActiveFillColor = System.Drawing.Color.Salmon;
            this.rechercher.ActiveForecolor = System.Drawing.Color.White;
            this.rechercher.ActiveLineColor = System.Drawing.Color.Navy;
            this.rechercher.BackColor = System.Drawing.Color.Navy;
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
            this.rechercher.Location = new System.Drawing.Point(48, 240);
            this.rechercher.Margin = new System.Windows.Forms.Padding(5);
            this.rechercher.Name = "rechercher";
            this.rechercher.Size = new System.Drawing.Size(137, 41);
            this.rechercher.TabIndex = 10;
            this.rechercher.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rechercher.Click += new System.EventHandler(this.rechercher_Click);
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
            this.inputsearchname.Location = new System.Drawing.Point(26, 138);
            this.inputsearchname.Margin = new System.Windows.Forms.Padding(4);
            this.inputsearchname.Name = "inputsearchname";
            this.inputsearchname.Size = new System.Drawing.Size(183, 44);
            this.inputsearchname.TabIndex = 11;
            this.inputsearchname.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.inputsearchname.OnValueChanged += new System.EventHandler(this.inputsearchname_OnValueChanged);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(22, 107);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(197, 20);
            this.bunifuCustomLabel1.TabIndex = 12;
            this.bunifuCustomLabel1.Text = "tapez le nom recherché";
            // 
            // Patient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1130, 740);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.inputsearchname);
            this.Controls.Add(this.rechercher);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PatientGrid);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Patient";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patient";
            this.Load += new System.EventHandler(this.Patient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PatientGrid)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView PatientGrid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button btn_supprimer;
        private System.Windows.Forms.Button afficher;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom_patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom_Patient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_création;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn Téléphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date_naissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn symptomes;
        private System.Windows.Forms.DataGridViewTextBoxColumn Etat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexe;
        private System.Windows.Forms.Button modifier;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePickerDateCreated;
        private Bunifu.Framework.UI.BunifuDatepicker dateTimePickerDateNaiss;
        private System.Windows.Forms.Label label11;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputTel;
        private Bunifu.Framework.UI.BunifuMaterialTextbox bunifuMaterialTextbox8;
        private System.Windows.Forms.TextBox inputSymptome;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputEtat;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputSexe;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputVille;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputNom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputPrenom;
        private System.Windows.Forms.Button rénitialiser;
        private System.Windows.Forms.Button retour;
        private Bunifu.Framework.UI.BunifuThinButton2 rechercher;
        private Bunifu.Framework.UI.BunifuMaterialTextbox inputsearchname;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
    }
}