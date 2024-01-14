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
            this.panel2 = new System.Windows.Forms.Panel();
            this.login_button = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Nom_utilisateur = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.txt_passwd = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.choice_login = new System.Windows.Forms.ComboBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.RosyBrown;
            this.panel2.Controls.Add(this.login_button);
            this.panel2.Location = new System.Drawing.Point(0, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 62);
            this.panel2.TabIndex = 6;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // login_button
            // 
            this.login_button.ActiveBorderThickness = 1;
            this.login_button.ActiveCornerRadius = 20;
            this.login_button.ActiveFillColor = System.Drawing.Color.Navy;
            this.login_button.ActiveForecolor = System.Drawing.Color.LightSteelBlue;
            this.login_button.ActiveLineColor = System.Drawing.Color.Sienna;
            this.login_button.BackColor = System.Drawing.Color.RosyBrown;
            this.login_button.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("login_button.BackgroundImage")));
            this.login_button.ButtonText = "Login";
            this.login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.login_button.Font = new System.Drawing.Font("Century Gothic", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_button.ForeColor = System.Drawing.Color.Black;
            this.login_button.IdleBorderThickness = 1;
            this.login_button.IdleCornerRadius = 20;
            this.login_button.IdleFillColor = System.Drawing.Color.White;
            this.login_button.IdleForecolor = System.Drawing.Color.Navy;
            this.login_button.IdleLineColor = System.Drawing.Color.Blue;
            this.login_button.Location = new System.Drawing.Point(115, 2);
            this.login_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(99, 55);
            this.login_button.TabIndex = 10;
            this.login_button.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.login_button.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 250);
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
            this.label1.Location = new System.Drawing.Point(12, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nom Utilisateur";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txt_Nom_utilisateur
            // 
            this.txt_Nom_utilisateur.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_Nom_utilisateur.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Nom_utilisateur.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_Nom_utilisateur.BorderThickness = 3;
            this.txt_Nom_utilisateur.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Nom_utilisateur.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_Nom_utilisateur.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_Nom_utilisateur.isPassword = false;
            this.txt_Nom_utilisateur.Location = new System.Drawing.Point(148, 166);
            this.txt_Nom_utilisateur.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nom_utilisateur.Name = "txt_Nom_utilisateur";
            this.txt_Nom_utilisateur.Size = new System.Drawing.Size(174, 44);
            this.txt_Nom_utilisateur.TabIndex = 12;
            this.txt_Nom_utilisateur.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txt_passwd
            // 
            this.txt_passwd.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt_passwd.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_passwd.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt_passwd.BorderThickness = 3;
            this.txt_passwd.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_passwd.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt_passwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt_passwd.isPassword = true;
            this.txt_passwd.Location = new System.Drawing.Point(148, 241);
            this.txt_passwd.Margin = new System.Windows.Forms.Padding(4);
            this.txt_passwd.Name = "txt_passwd";
            this.txt_passwd.Size = new System.Drawing.Size(174, 44);
            this.txt_passwd.TabIndex = 13;
            this.txt_passwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_passwd.OnValueChanged += new System.EventHandler(this.txt_passwd_OnValueChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Azure;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(330, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // choice_login
            // 
            this.choice_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice_login.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.choice_login.FormattingEnabled = true;
            this.choice_login.Items.AddRange(new object[] {
            "Médecin",
            "Sécrétaire"});
            this.choice_login.Location = new System.Drawing.Point(100, 337);
            this.choice_login.Name = "choice_login";
            this.choice_login.Size = new System.Drawing.Size(135, 32);
            this.choice_login.TabIndex = 9;
            this.choice_login.SelectedIndexChanged += new System.EventHandler(this.choice_login_SelectedIndexChanged);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(330, 458);
            this.Controls.Add(this.txt_passwd);
            this.Controls.Add(this.txt_Nom_utilisateur);
            this.Controls.Add(this.choice_login);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuThinButton2 login_button;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_Nom_utilisateur;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt_passwd;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox choice_login;
    }
}

