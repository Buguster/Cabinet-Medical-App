namespace medical_app
{
    partial class paiement
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labetype_medicament = new System.Windows.Forms.Label();
            this.labelmontant = new System.Windows.Forms.Label();
            this.labid = new System.Windows.Forms.Label();
            this.labdate_paiment = new System.Windows.Forms.Label();
            this.labelfacture = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvpaiment = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.retour = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpaiment)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Navy;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labetype_medicament);
            this.panel2.Controls.Add(this.labelmontant);
            this.panel2.Controls.Add(this.labid);
            this.panel2.Controls.Add(this.labdate_paiment);
            this.panel2.Controls.Add(this.labelfacture);
            this.panel2.Controls.Add(this.textBox7);
            this.panel2.Controls.Add(this.textBox6);
            this.panel2.Controls.Add(this.textBox3);
            this.panel2.Controls.Add(this.textBox2);
            this.panel2.Controls.Add(this.textBox1);
            this.panel2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.panel2.Location = new System.Drawing.Point(18, 61);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(799, 136);
            this.panel2.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 24);
            this.label1.TabIndex = 12;
            this.label1.Text = "Gestion De Paiment";
            // 
            // labetype_medicament
            // 
            this.labetype_medicament.AutoSize = true;
            this.labetype_medicament.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labetype_medicament.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labetype_medicament.Location = new System.Drawing.Point(484, 57);
            this.labetype_medicament.Name = "labetype_medicament";
            this.labetype_medicament.Size = new System.Drawing.Size(150, 18);
            this.labetype_medicament.TabIndex = 11;
            this.labetype_medicament.Text = "  type medicament:";
            // 
            // labelmontant
            // 
            this.labelmontant.AutoSize = true;
            this.labelmontant.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelmontant.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelmontant.Location = new System.Drawing.Point(272, 81);
            this.labelmontant.Name = "labelmontant";
            this.labelmontant.Size = new System.Drawing.Size(79, 18);
            this.labelmontant.TabIndex = 10;
            this.labelmontant.Text = " montant:";
            // 
            // labid
            // 
            this.labid.AutoSize = true;
            this.labid.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labid.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labid.Location = new System.Drawing.Point(268, 37);
            this.labid.Name = "labid";
            this.labid.Size = new System.Drawing.Size(81, 18);
            this.labid.TabIndex = 9;
            this.labid.Text = "id patient:";
            // 
            // labdate_paiment
            // 
            this.labdate_paiment.AutoSize = true;
            this.labdate_paiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labdate_paiment.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labdate_paiment.Location = new System.Drawing.Point(3, 75);
            this.labdate_paiment.Name = "labdate_paiment";
            this.labdate_paiment.Size = new System.Drawing.Size(109, 18);
            this.labdate_paiment.TabIndex = 8;
            this.labdate_paiment.Text = "date paiment:";
            // 
            // labelfacture
            // 
            this.labelfacture.AutoSize = true;
            this.labelfacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelfacture.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelfacture.Location = new System.Drawing.Point(1, 37);
            this.labelfacture.Name = "labelfacture";
            this.labelfacture.Size = new System.Drawing.Size(130, 18);
            this.labelfacture.TabIndex = 7;
            this.labelfacture.Text = "Numero facture:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(118, 75);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(125, 24);
            this.textBox7.TabIndex = 6;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(640, 31);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(125, 71);
            this.textBox6.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(357, 78);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(125, 24);
            this.textBox3.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(353, 34);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(125, 24);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(137, 34);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(125, 24);
            this.textBox1.TabIndex = 0;
            // 
            // dgvpaiment
            // 
            this.dgvpaiment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvpaiment.Location = new System.Drawing.Point(18, 233);
            this.dgvpaiment.Name = "dgvpaiment";
            this.dgvpaiment.Size = new System.Drawing.Size(795, 271);
            this.dgvpaiment.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Chartreuse;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.DimGray;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.button1.Location = new System.Drawing.Point(312, 533);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Valider";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // retour
            // 
            this.retour.BackColor = System.Drawing.Color.AliceBlue;
            this.retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.retour.Location = new System.Drawing.Point(102, 12);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(137, 37);
            this.retour.TabIndex = 10;
            this.retour.Text = "Retour";
            this.retour.UseVisualStyleBackColor = false;
            this.retour.Click += new System.EventHandler(this.retour_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.AliceBlue;
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.dgvpaiment);
            this.panel3.Location = new System.Drawing.Point(102, 58);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(833, 630);
            this.panel3.TabIndex = 11;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.DimGray;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(716, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(219, 37);
            this.button2.TabIndex = 12;
            this.button2.Text = "Liste Des Paiements";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // paiement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(1079, 700);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.retour);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "paiement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "paiement";
            this.Load += new System.EventHandler(this.paiement_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvpaiment)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labetype_medicament;
        private System.Windows.Forms.Label labelmontant;
        private System.Windows.Forms.Label labid;
        private System.Windows.Forms.Label labdate_paiment;
        private System.Windows.Forms.Label labelfacture;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dgvpaiment;
        public System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button retour;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
    }
}