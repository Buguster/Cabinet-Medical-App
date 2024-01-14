namespace medical_app
{
    partial class RDV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RDV));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.selected_time = new System.Windows.Forms.ComboBox();
            this.RDVGrid = new System.Windows.Forms.DataGridView();
            this.ID_Ordonnance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_medi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ordonnance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.supprimer = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimepickerdateRDV = new Bunifu.Framework.UI.BunifuDatepicker();
            this.patient_ID = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Grid_Filter_RDV = new System.Windows.Forms.DataGridView();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Téléphone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.confirmer = new Bunifu.Framework.UI.BunifuThinButton2();
            this.load_RDV = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RDVGrid)).BeginInit();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Filter_RDV)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.load_RDV);
            this.panel1.Controls.Add(this.confirmer);
            this.panel1.Controls.Add(this.Grid_Filter_RDV);
            this.panel1.Controls.Add(this.bunifuCustomLabel2);
            this.panel1.Controls.Add(this.selected_time);
            this.panel1.Controls.Add(this.RDVGrid);
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 616);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.ForeColor = System.Drawing.Color.White;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(813, 63);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(130, 24);
            this.bunifuCustomLabel2.TabIndex = 64;
            this.bunifuCustomLabel2.Text = "Filtrer les RDV";
            // 
            // selected_time
            // 
            this.selected_time.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selected_time.FormattingEnabled = true;
            this.selected_time.Items.AddRange(new object[] {
            "Aujourd\'hui",
            "Hier",
            "SemaineDernière",
            "SemaineProchaine"});
            this.selected_time.Location = new System.Drawing.Point(970, 59);
            this.selected_time.Name = "selected_time";
            this.selected_time.Size = new System.Drawing.Size(121, 28);
            this.selected_time.TabIndex = 63;
            this.selected_time.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // RDVGrid
            // 
            this.RDVGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.RDVGrid.AllowUserToOrderColumns = true;
            this.RDVGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.RDVGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RDVGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.RDVGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.RDVGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RDVGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Ordonnance,
            this.type_medi,
            this.date_ordonnance});
            this.RDVGrid.Location = new System.Drawing.Point(212, 303);
            this.RDVGrid.Name = "RDVGrid";
            this.RDVGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.RDVGrid.RowHeadersWidth = 50;
            this.RDVGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.RDVGrid.Size = new System.Drawing.Size(333, 301);
            this.RDVGrid.TabIndex = 62;
            this.RDVGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.RDVGrid_CellContentClick);
            // 
            // ID_Ordonnance
            // 
            this.ID_Ordonnance.HeaderText = "ID_Ordonance";
            this.ID_Ordonnance.Name = "ID_Ordonnance";
            // 
            // type_medi
            // 
            this.type_medi.HeaderText = "Type Médicaments";
            this.type_medi.Name = "type_medi";
            // 
            // date_ordonnance
            // 
            this.date_ordonnance.HeaderText = "Date Ordonance";
            this.date_ordonnance.Name = "date_ordonnance";
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.ajouter);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.supprimer);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(12, 254);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(160, 118);
            this.bunifuGradientPanel1.TabIndex = 61;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "Opération RDV";
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.Green;
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.ForeColor = System.Drawing.Color.White;
            this.ajouter.Location = new System.Drawing.Point(21, 27);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(120, 39);
            this.ajouter.TabIndex = 53;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(0, 13);
            this.bunifuCustomLabel1.TabIndex = 59;
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.Red;
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.Color.White;
            this.supprimer.Location = new System.Drawing.Point(21, 72);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(120, 39);
            this.supprimer.TabIndex = 55;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.DateTimepickerdateRDV);
            this.panel2.Controls.Add(this.patient_ID);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(12, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 190);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(99, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(338, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Enregistrements d\'un Rendez-vous\r\n";
            // 
            // DateTimepickerdateRDV
            // 
            this.DateTimepickerdateRDV.BackColor = System.Drawing.Color.Navy;
            this.DateTimepickerdateRDV.BorderRadius = 0;
            this.DateTimepickerdateRDV.ForeColor = System.Drawing.Color.White;
            this.DateTimepickerdateRDV.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimepickerdateRDV.FormatCustom = null;
            this.DateTimepickerdateRDV.Location = new System.Drawing.Point(204, 117);
            this.DateTimepickerdateRDV.Name = "DateTimepickerdateRDV";
            this.DateTimepickerdateRDV.Size = new System.Drawing.Size(248, 36);
            this.DateTimepickerdateRDV.TabIndex = 52;
            this.DateTimepickerdateRDV.Value = new System.DateTime(2024, 1, 11, 14, 22, 38, 130);
            // 
            // patient_ID
            // 
            this.patient_ID.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.patient_ID.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.patient_ID.BorderColorFocused = System.Drawing.Color.Blue;
            this.patient_ID.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patient_ID.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.patient_ID.BorderThickness = 3;
            this.patient_ID.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.patient_ID.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_ID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.patient_ID.isPassword = false;
            this.patient_ID.Location = new System.Drawing.Point(181, 46);
            this.patient_ID.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.patient_ID.Name = "patient_ID";
            this.patient_ID.Size = new System.Drawing.Size(90, 56);
            this.patient_ID.TabIndex = 56;
            this.patient_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.patient_ID.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(49, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "ID_Patient";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(49, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Date Ordonance";
            // 
            // Grid_Filter_RDV
            // 
            this.Grid_Filter_RDV.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Grid_Filter_RDV.AllowUserToOrderColumns = true;
            this.Grid_Filter_RDV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_Filter_RDV.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Grid_Filter_RDV.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.Grid_Filter_RDV.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Grid_Filter_RDV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_Filter_RDV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nom,
            this.Prénom,
            this.Téléphone,
            this.date});
            this.Grid_Filter_RDV.Location = new System.Drawing.Point(577, 161);
            this.Grid_Filter_RDV.Name = "Grid_Filter_RDV";
            this.Grid_Filter_RDV.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.Grid_Filter_RDV.RowHeadersWidth = 50;
            this.Grid_Filter_RDV.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.Grid_Filter_RDV.Size = new System.Drawing.Size(515, 443);
            this.Grid_Filter_RDV.TabIndex = 65;
            this.Grid_Filter_RDV.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_Filter_RDV_CellContentClick);
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            // 
            // Téléphone
            // 
            this.Téléphone.HeaderText = "Téléphone";
            this.Téléphone.Name = "Téléphone";
            // 
            // date
            // 
            this.date.HeaderText = "date_rdv";
            this.date.Name = "date";
            // 
            // confirmer
            // 
            this.confirmer.ActiveBorderThickness = 1;
            this.confirmer.ActiveCornerRadius = 20;
            this.confirmer.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.confirmer.ActiveForecolor = System.Drawing.Color.White;
            this.confirmer.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.confirmer.BackColor = System.Drawing.Color.Navy;
            this.confirmer.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("confirmer.BackgroundImage")));
            this.confirmer.ButtonText = "Confirmer";
            this.confirmer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.confirmer.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmer.ForeColor = System.Drawing.Color.SeaGreen;
            this.confirmer.IdleBorderThickness = 1;
            this.confirmer.IdleCornerRadius = 20;
            this.confirmer.IdleFillColor = System.Drawing.Color.White;
            this.confirmer.IdleForecolor = System.Drawing.Color.Navy;
            this.confirmer.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.confirmer.Location = new System.Drawing.Point(986, 95);
            this.confirmer.Margin = new System.Windows.Forms.Padding(5);
            this.confirmer.Name = "confirmer";
            this.confirmer.Size = new System.Drawing.Size(106, 41);
            this.confirmer.TabIndex = 66;
            this.confirmer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.confirmer.Click += new System.EventHandler(this.confirmer_Click);
            // 
            // load_RDV
            // 
            this.load_RDV.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load_RDV.Location = new System.Drawing.Point(212, 255);
            this.load_RDV.Name = "load_RDV";
            this.load_RDV.Size = new System.Drawing.Size(204, 42);
            this.load_RDV.TabIndex = 67;
            this.load_RDV.Text = "Liste Des RDV";
            this.load_RDV.UseVisualStyleBackColor = true;
            this.load_RDV.Click += new System.EventHandler(this.load_patient_Click);
            // 
            // RDV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 616);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RDV";
            this.Text = "RDV";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.RDVGrid)).EndInit();
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_Filter_RDV)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuMetroTextbox patient_ID;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker DateTimepickerdateRDV;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ajouter;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button supprimer;
        private System.Windows.Forms.DataGridView RDVGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Ordonnance;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_medi;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_ordonnance;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.ComboBox selected_time;
        private System.Windows.Forms.DataGridView Grid_Filter_RDV;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Téléphone;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private Bunifu.Framework.UI.BunifuThinButton2 confirmer;
        private System.Windows.Forms.Button load_RDV;
    }
}