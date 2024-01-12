namespace medical_app
{
    partial class Ordonance
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.retour = new System.Windows.Forms.Button();
            this.OrdonnanceGrid = new System.Windows.Forms.DataGridView();
            this.ID_Ordonnance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_medi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID_Médecin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Afficher = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.DateTimepickerdateordo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.typemedicaments = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.type_medicaments = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdonnanceGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.retour);
            this.panel1.Controls.Add(this.OrdonnanceGrid);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1153, 616);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // retour
            // 
            this.retour.BackColor = System.Drawing.Color.AliceBlue;
            this.retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.Location = new System.Drawing.Point(23, 38);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(137, 37);
            this.retour.TabIndex = 10;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // OrdonnanceGrid
            // 
            this.OrdonnanceGrid.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.OrdonnanceGrid.AllowUserToOrderColumns = true;
            this.OrdonnanceGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.OrdonnanceGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.OrdonnanceGrid.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.OrdonnanceGrid.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.OrdonnanceGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OrdonnanceGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_Ordonnance,
            this.type_medi,
            this.ID_Médecin});
            this.OrdonnanceGrid.Location = new System.Drawing.Point(23, 408);
            this.OrdonnanceGrid.Name = "OrdonnanceGrid";
            this.OrdonnanceGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.OrdonnanceGrid.RowHeadersWidth = 50;
            this.OrdonnanceGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrdonnanceGrid.Size = new System.Drawing.Size(907, 182);
            this.OrdonnanceGrid.TabIndex = 6;
            this.OrdonnanceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdonnanceGrid_CellContentClick);
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
            // ID_Médecin
            // 
            this.ID_Médecin.HeaderText = "Médecin_ID";
            this.ID_Médecin.Name = "ID_Médecin";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.Afficher);
            this.panel2.Controls.Add(this.title);
            this.panel2.Controls.Add(this.ajouter);
            this.panel2.Controls.Add(this.DateTimepickerdateordo);
            this.panel2.Controls.Add(this.typemedicaments);
            this.panel2.Controls.Add(this.type_medicaments);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(210, 29);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 344);
            this.panel2.TabIndex = 3;
            // 
            // Afficher
            // 
            this.Afficher.BackColor = System.Drawing.Color.Gray;
            this.Afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Afficher.ForeColor = System.Drawing.Color.White;
            this.Afficher.Location = new System.Drawing.Point(325, 292);
            this.Afficher.Name = "Afficher";
            this.Afficher.Size = new System.Drawing.Size(99, 39);
            this.Afficher.TabIndex = 47;
            this.Afficher.Text = "Afficher";
            this.Afficher.UseVisualStyleBackColor = false;
            this.Afficher.Click += new System.EventHandler(this.button1_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.BackColor = System.Drawing.Color.Navy;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.White;
            this.title.Location = new System.Drawing.Point(97, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(353, 24);
            this.title.TabIndex = 35;
            this.title.Text = "Formulaire Informations Ordonnance";
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.Green;
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.ForeColor = System.Drawing.Color.White;
            this.ajouter.Location = new System.Drawing.Point(430, 292);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(86, 39);
            this.ajouter.TabIndex = 11;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.ajouter_Click);
            // 
            // DateTimepickerdateordo
            // 
            this.DateTimepickerdateordo.BackColor = System.Drawing.Color.Navy;
            this.DateTimepickerdateordo.BorderRadius = 0;
            this.DateTimepickerdateordo.ForeColor = System.Drawing.Color.White;
            this.DateTimepickerdateordo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimepickerdateordo.FormatCustom = null;
            this.DateTimepickerdateordo.Location = new System.Drawing.Point(238, 167);
            this.DateTimepickerdateordo.Name = "DateTimepickerdateordo";
            this.DateTimepickerdateordo.Size = new System.Drawing.Size(248, 36);
            this.DateTimepickerdateordo.TabIndex = 10;
            this.DateTimepickerdateordo.Value = new System.DateTime(2024, 1, 11, 14, 22, 38, 130);
            // 
            // typemedicaments
            // 
            this.typemedicaments.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.typemedicaments.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.typemedicaments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.typemedicaments.HintForeColor = System.Drawing.Color.Empty;
            this.typemedicaments.HintText = "";
            this.typemedicaments.isPassword = false;
            this.typemedicaments.LineFocusedColor = System.Drawing.Color.Blue;
            this.typemedicaments.LineIdleColor = System.Drawing.Color.Gray;
            this.typemedicaments.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.typemedicaments.LineThickness = 3;
            this.typemedicaments.Location = new System.Drawing.Point(238, 67);
            this.typemedicaments.Margin = new System.Windows.Forms.Padding(4);
            this.typemedicaments.Name = "typemedicaments";
            this.typemedicaments.Size = new System.Drawing.Size(248, 44);
            this.typemedicaments.TabIndex = 7;
            this.typemedicaments.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // type_medicaments
            // 
            this.type_medicaments.AutoSize = true;
            this.type_medicaments.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_medicaments.ForeColor = System.Drawing.SystemColors.ControlText;
            this.type_medicaments.Location = new System.Drawing.Point(45, 87);
            this.type_medicaments.Name = "type_medicaments";
            this.type_medicaments.Size = new System.Drawing.Size(176, 24);
            this.type_medicaments.TabIndex = 4;
            this.type_medicaments.Text = "Type_Medicaments";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(60, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Date Ordonance";
            // 
            // Ordonance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 616);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ordonance";
            this.Text = "Ordonance";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.OrdonnanceGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuDatepicker DateTimepickerdateordo;
        private Bunifu.Framework.UI.BunifuMaterialTextbox typemedicaments;
        private System.Windows.Forms.Label type_medicaments;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.DataGridView OrdonnanceGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Ordonnance;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_medi;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Médecin;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Button Afficher;
    }
}