namespace projekat_2026_Ognjen_Brkic
{
    partial class signup
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
            this.txt_ime = new System.Windows.Forms.TextBox();
            this.txt_prezime = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_password2 = new System.Windows.Forms.TextBox();
            this.txt_broj_telefona = new System.Windows.Forms.TextBox();
            this.lbl_ime = new System.Windows.Forms.Label();
            this.lbl_prezime = new System.Windows.Forms.Label();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.lbl_password_opet = new System.Windows.Forms.Label();
            this.lbl_broj_telefona = new System.Windows.Forms.Label();
            this.btn_signup = new System.Windows.Forms.Button();
            this.btn_nazad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_ime
            // 
            this.txt_ime.Location = new System.Drawing.Point(137, 65);
            this.txt_ime.Name = "txt_ime";
            this.txt_ime.Size = new System.Drawing.Size(100, 20);
            this.txt_ime.TabIndex = 0;
            // 
            // txt_prezime
            // 
            this.txt_prezime.Location = new System.Drawing.Point(137, 98);
            this.txt_prezime.Name = "txt_prezime";
            this.txt_prezime.Size = new System.Drawing.Size(100, 20);
            this.txt_prezime.TabIndex = 1;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(137, 136);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(100, 20);
            this.txt_email.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(137, 179);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(100, 20);
            this.txt_password.TabIndex = 3;
            this.txt_password.UseSystemPasswordChar = true;
            // 
            // txt_password2
            // 
            this.txt_password2.Location = new System.Drawing.Point(137, 216);
            this.txt_password2.Name = "txt_password2";
            this.txt_password2.Size = new System.Drawing.Size(100, 20);
            this.txt_password2.TabIndex = 4;
            this.txt_password2.UseSystemPasswordChar = true;
            // 
            // txt_broj_telefona
            // 
            this.txt_broj_telefona.Location = new System.Drawing.Point(137, 254);
            this.txt_broj_telefona.Name = "txt_broj_telefona";
            this.txt_broj_telefona.Size = new System.Drawing.Size(100, 20);
            this.txt_broj_telefona.TabIndex = 5;
            // 
            // lbl_ime
            // 
            this.lbl_ime.AutoSize = true;
            this.lbl_ime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ime.Location = new System.Drawing.Point(96, 68);
            this.lbl_ime.Name = "lbl_ime";
            this.lbl_ime.Size = new System.Drawing.Size(32, 15);
            this.lbl_ime.TabIndex = 6;
            this.lbl_ime.Text = "Ime:";
            // 
            // lbl_prezime
            // 
            this.lbl_prezime.AutoSize = true;
            this.lbl_prezime.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_prezime.Location = new System.Drawing.Point(76, 101);
            this.lbl_prezime.Name = "lbl_prezime";
            this.lbl_prezime.Size = new System.Drawing.Size(56, 15);
            this.lbl_prezime.TabIndex = 7;
            this.lbl_prezime.Text = "Prezime:";
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.Location = new System.Drawing.Point(88, 139);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(40, 15);
            this.lbl_email.TabIndex = 8;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.Location = new System.Drawing.Point(84, 182);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(51, 15);
            this.lbl_password.TabIndex = 9;
            this.lbl_password.Text = "Lozinka:";
            // 
            // lbl_password_opet
            // 
            this.lbl_password_opet.AutoSize = true;
            this.lbl_password_opet.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password_opet.Location = new System.Drawing.Point(31, 218);
            this.lbl_password_opet.Name = "lbl_password_opet";
            this.lbl_password_opet.Size = new System.Drawing.Size(104, 15);
            this.lbl_password_opet.TabIndex = 10;
            this.lbl_password_opet.Text = "Potrvdite lozinku:";
            // 
            // lbl_broj_telefona
            // 
            this.lbl_broj_telefona.AutoSize = true;
            this.lbl_broj_telefona.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_broj_telefona.Location = new System.Drawing.Point(54, 257);
            this.lbl_broj_telefona.Name = "lbl_broj_telefona";
            this.lbl_broj_telefona.Size = new System.Drawing.Size(82, 15);
            this.lbl_broj_telefona.TabIndex = 11;
            this.lbl_broj_telefona.Text = "Broj telefona:";
            // 
            // btn_signup
            // 
            this.btn_signup.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.Location = new System.Drawing.Point(108, 298);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(153, 29);
            this.btn_signup.TabIndex = 12;
            this.btn_signup.Text = "Zavrsite registraciju";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click);
            // 
            // btn_nazad
            // 
            this.btn_nazad.BackColor = System.Drawing.Color.Transparent;
            this.btn_nazad.FlatAppearance.BorderSize = 0;
            this.btn_nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nazad.Location = new System.Drawing.Point(329, 9);
            this.btn_nazad.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(51, 36);
            this.btn_nazad.TabIndex = 13;
            this.btn_nazad.Text = "←";
            this.btn_nazad.UseVisualStyleBackColor = false;
            this.btn_nazad.Click += new System.EventHandler(this.btn_nazad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 26);
            this.label1.TabIndex = 14;
            this.label1.Text = "Registracija";
            // 
            // signup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(389, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.lbl_broj_telefona);
            this.Controls.Add(this.lbl_password_opet);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_email);
            this.Controls.Add(this.lbl_prezime);
            this.Controls.Add(this.lbl_ime);
            this.Controls.Add(this.txt_broj_telefona);
            this.Controls.Add(this.txt_password2);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_prezime);
            this.Controls.Add(this.txt_ime);
            this.Name = "signup";
            this.Text = "signup";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_ime;
        private System.Windows.Forms.TextBox txt_prezime;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_password2;
        private System.Windows.Forms.TextBox txt_broj_telefona;
        private System.Windows.Forms.Label lbl_ime;
        private System.Windows.Forms.Label lbl_prezime;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.Label lbl_password_opet;
        private System.Windows.Forms.Label lbl_broj_telefona;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Button btn_nazad;
        private System.Windows.Forms.Label label1;
    }
}