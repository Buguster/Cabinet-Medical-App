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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ordonance));
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.ajouter = new System.Windows.Forms.Button();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.afficher = new System.Windows.Forms.Button();
            this.supprimer = new System.Windows.Forms.Button();
            this.Modifier = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.Button();
            this.OrdonnanceGrid = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button3 = new System.Windows.Forms.Button();
            this.type_medicaments = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.DateTimepickerdateordo = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ID_Ordonnance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type_medi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_ordonnance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Print = new System.Windows.Forms.DataGridViewButtonColumn();
            this.panel1.SuspendLayout();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdonnanceGrid)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Navy;
            this.panel1.Controls.Add(this.bunifuGradientPanel1);
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
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.label2);
            this.bunifuGradientPanel1.Controls.Add(this.ajouter);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.afficher);
            this.bunifuGradientPanel1.Controls.Add(this.supprimer);
            this.bunifuGradientPanel1.Controls.Add(this.Modifier);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(653, 339);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(215, 249);
            this.bunifuGradientPanel1.TabIndex = 60;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Navy;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(213, 24);
            this.label2.TabIndex = 60;
            this.label2.Text = "Opération Ordonance";
            // 
            // ajouter
            // 
            this.ajouter.BackColor = System.Drawing.Color.Green;
            this.ajouter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ajouter.ForeColor = System.Drawing.Color.White;
            this.ajouter.Location = new System.Drawing.Point(43, 37);
            this.ajouter.Name = "ajouter";
            this.ajouter.Size = new System.Drawing.Size(120, 39);
            this.ajouter.TabIndex = 53;
            this.ajouter.Text = "Ajouter";
            this.ajouter.UseVisualStyleBackColor = false;
            this.ajouter.Click += new System.EventHandler(this.button2_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(3, 9);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(0, 13);
            this.bunifuCustomLabel1.TabIndex = 59;
            // 
            // afficher
            // 
            this.afficher.BackColor = System.Drawing.Color.Gray;
            this.afficher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.afficher.ForeColor = System.Drawing.Color.White;
            this.afficher.Location = new System.Drawing.Point(43, 83);
            this.afficher.Name = "afficher";
            this.afficher.Size = new System.Drawing.Size(120, 39);
            this.afficher.TabIndex = 58;
            this.afficher.Text = "Afficher";
            this.afficher.UseVisualStyleBackColor = false;
            this.afficher.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // supprimer
            // 
            this.supprimer.BackColor = System.Drawing.Color.Red;
            this.supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.supprimer.ForeColor = System.Drawing.Color.White;
            this.supprimer.Location = new System.Drawing.Point(43, 127);
            this.supprimer.Name = "supprimer";
            this.supprimer.Size = new System.Drawing.Size(120, 39);
            this.supprimer.TabIndex = 55;
            this.supprimer.Text = "Supprimer";
            this.supprimer.UseVisualStyleBackColor = false;
            // 
            // Modifier
            // 
            this.Modifier.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.Modifier.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Modifier.ForeColor = System.Drawing.Color.White;
            this.Modifier.Location = new System.Drawing.Point(43, 172);
            this.Modifier.Name = "Modifier";
            this.Modifier.Size = new System.Drawing.Size(120, 39);
            this.Modifier.TabIndex = 57;
            this.Modifier.Text = "Modifier";
            this.Modifier.UseVisualStyleBackColor = false;
            // 
            // retour
            // 
            this.retour.BackColor = System.Drawing.Color.AliceBlue;
            this.retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.Location = new System.Drawing.Point(1004, 12);
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
            this.date_ordonnance,
            this.Print});
            this.OrdonnanceGrid.Location = new System.Drawing.Point(37, 14);
            this.OrdonnanceGrid.Name = "OrdonnanceGrid";
            this.OrdonnanceGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.OrdonnanceGrid.RowHeadersWidth = 50;
            this.OrdonnanceGrid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.OrdonnanceGrid.Size = new System.Drawing.Size(861, 164);
            this.OrdonnanceGrid.TabIndex = 6;
            this.OrdonnanceGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.OrdonnanceGrid_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Azure;
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.type_medicaments);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.DateTimepickerdateordo);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(37, 184);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(533, 407);
            this.panel2.TabIndex = 3;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Gray;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(398, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 39);
            this.button3.TabIndex = 58;
            this.button3.Text = "Afficher";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // type_medicaments
            // 
            this.type_medicaments.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.type_medicaments.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.type_medicaments.BorderColorFocused = System.Drawing.Color.Blue;
            this.type_medicaments.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.type_medicaments.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.type_medicaments.BorderThickness = 3;
            this.type_medicaments.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.type_medicaments.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.type_medicaments.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.type_medicaments.isPassword = false;
            this.type_medicaments.Location = new System.Drawing.Point(75, 105);
            this.type_medicaments.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.type_medicaments.Name = "type_medicaments";
            this.type_medicaments.Size = new System.Drawing.Size(422, 189);
            this.type_medicaments.TabIndex = 56;
            this.type_medicaments.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.type_medicaments.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Navy;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(100, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(353, 24);
            this.label1.TabIndex = 54;
            this.label1.Text = "Formulaire Informations Ordonnance";
            // 
            // DateTimepickerdateordo
            // 
            this.DateTimepickerdateordo.BackColor = System.Drawing.Color.Navy;
            this.DateTimepickerdateordo.BorderRadius = 0;
            this.DateTimepickerdateordo.ForeColor = System.Drawing.Color.White;
            this.DateTimepickerdateordo.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.DateTimepickerdateordo.FormatCustom = null;
            this.DateTimepickerdateordo.Location = new System.Drawing.Point(249, 303);
            this.DateTimepickerdateordo.Name = "DateTimepickerdateordo";
            this.DateTimepickerdateordo.Size = new System.Drawing.Size(248, 36);
            this.DateTimepickerdateordo.TabIndex = 52;
            this.DateTimepickerdateordo.Value = new System.DateTime(2024, 1, 11, 14, 22, 38, 130);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(40, 315);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 24);
            this.label3.TabIndex = 51;
            this.label3.Text = "Date Ordonance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label4.Location = new System.Drawing.Point(80, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Médicaments";
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
            // Print
            // 
            this.Print.HeaderText = "PRINT";
            this.Print.Name = "Print";
            this.Print.Text = "Print_Ordonnance";
            // 
            // Ordonance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1153, 616);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Ordonance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ordonance";
            this.panel1.ResumeLayout(false);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdonnanceGrid)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView OrdonnanceGrid;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Button supprimer;
        private Bunifu.Framework.UI.BunifuMetroTextbox type_medicaments;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuDatepicker DateTimepickerdateordo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ajouter;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button Modifier;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private System.Windows.Forms.Button afficher;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID_Ordonnance;
        private System.Windows.Forms.DataGridViewTextBoxColumn type_medi;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_ordonnance;
        private System.Windows.Forms.DataGridViewButtonColumn Print;
    }
}