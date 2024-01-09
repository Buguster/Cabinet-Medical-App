namespace medical_app
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.txt_Nom_utilisateur = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_passwd = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_Nom_utilisateur
            // 
            this.txt_Nom_utilisateur.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom_utilisateur.Location = new System.Drawing.Point(173, 214);
            this.txt_Nom_utilisateur.Multiline = true;
            this.txt_Nom_utilisateur.Name = "txt_Nom_utilisateur";
            this.txt_Nom_utilisateur.Size = new System.Drawing.Size(145, 34);
            this.txt_Nom_utilisateur.TabIndex = 2;
            this.txt_Nom_utilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // login_button
            // 
            this.login_button.BackColor = System.Drawing.SystemColors.Info;
            this.login_button.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.Location = new System.Drawing.Point(113, 365);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(116, 52);
            this.login_button.TabIndex = 5;
            this.login_button.Text = "Login";
            this.login_button.UseVisualStyleBackColor = false;
            this.login_button.Click += new System.EventHandler(this.login_button_Click_1);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel2.Location = new System.Drawing.Point(0, 437);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 23);
            this.panel2.TabIndex = 6;
            // 
            // txt_passwd
            // 
            this.txt_passwd.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_passwd.Location = new System.Drawing.Point(173, 284);
            this.txt_passwd.Multiline = true;
            this.txt_passwd.Name = "txt_passwd";
            this.txt_passwd.Size = new System.Drawing.Size(145, 34);
            this.txt_passwd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 285);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mot de passe ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Utilisateur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.RosyBrown;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 110);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(330, 458);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txt_passwd);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.txt_Nom_utilisateur);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txt_Nom_utilisateur;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_passwd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

