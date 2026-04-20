namespace projekat_2026_Ognjen_Brkic
{
    partial class rezervacija
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
            this.lbl_frizer = new System.Windows.Forms.Label();
            this.cmb_frizer = new System.Windows.Forms.ComboBox();
            this.datum_picker = new System.Windows.Forms.DateTimePicker();
            this.cmb_usluga = new System.Windows.Forms.ComboBox();
            this.cmb_termin = new System.Windows.Forms.ComboBox();
            this.grid_cenovnik = new System.Windows.Forms.DataGridView();
            this.lbl_biranje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_rezervisi = new System.Windows.Forms.Button();
            this.btn_nazad = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_cenovnik)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_frizer
            // 
            this.lbl_frizer.AutoSize = true;
            this.lbl_frizer.Location = new System.Drawing.Point(35, 30);
            this.lbl_frizer.Name = "lbl_frizer";
            this.lbl_frizer.Size = new System.Drawing.Size(84, 13);
            this.lbl_frizer.TabIndex = 0;
            this.lbl_frizer.Text = "Odaberite frizera";
            // 
            // cmb_frizer
            // 
            this.cmb_frizer.FormattingEnabled = true;
            this.cmb_frizer.Location = new System.Drawing.Point(38, 46);
            this.cmb_frizer.Name = "cmb_frizer";
            this.cmb_frizer.Size = new System.Drawing.Size(121, 21);
            this.cmb_frizer.TabIndex = 1;
            this.cmb_frizer.SelectedIndexChanged += new System.EventHandler(this.cmb_frizer_SelectedIndexChanged);
            // 
            // datum_picker
            // 
            this.datum_picker.Location = new System.Drawing.Point(38, 134);
            this.datum_picker.Name = "datum_picker";
            this.datum_picker.Size = new System.Drawing.Size(200, 20);
            this.datum_picker.TabIndex = 2;
            this.datum_picker.ValueChanged += new System.EventHandler(this.datum_picker_ValueChanged);
            // 
            // cmb_usluga
            // 
            this.cmb_usluga.FormattingEnabled = true;
            this.cmb_usluga.Location = new System.Drawing.Point(271, 134);
            this.cmb_usluga.Name = "cmb_usluga";
            this.cmb_usluga.Size = new System.Drawing.Size(121, 21);
            this.cmb_usluga.TabIndex = 3;
            this.cmb_usluga.SelectedIndexChanged += new System.EventHandler(this.cmb_usluga_SelectedIndexChanged);
            // 
            // cmb_termin
            // 
            this.cmb_termin.FormattingEnabled = true;
            this.cmb_termin.Location = new System.Drawing.Point(426, 134);
            this.cmb_termin.Name = "cmb_termin";
            this.cmb_termin.Size = new System.Drawing.Size(121, 21);
            this.cmb_termin.TabIndex = 4;
            // 
            // grid_cenovnik
            // 
            this.grid_cenovnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cenovnik.Location = new System.Drawing.Point(38, 184);
            this.grid_cenovnik.Name = "grid_cenovnik";
            this.grid_cenovnik.Size = new System.Drawing.Size(449, 175);
            this.grid_cenovnik.TabIndex = 5;
            // 
            // lbl_biranje
            // 
            this.lbl_biranje.AutoSize = true;
            this.lbl_biranje.Location = new System.Drawing.Point(35, 100);
            this.lbl_biranje.Name = "lbl_biranje";
            this.lbl_biranje.Size = new System.Drawing.Size(79, 13);
            this.lbl_biranje.TabIndex = 6;
            this.lbl_biranje.Text = "Izaberite datum";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Izaberite vrstu usluge";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 100);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Izaberite termin";
            // 
            // btn_rezervisi
            // 
            this.btn_rezervisi.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rezervisi.Location = new System.Drawing.Point(38, 375);
            this.btn_rezervisi.Name = "btn_rezervisi";
            this.btn_rezervisi.Size = new System.Drawing.Size(135, 34);
            this.btn_rezervisi.TabIndex = 9;
            this.btn_rezervisi.Text = "Rezervisi";
            this.btn_rezervisi.UseVisualStyleBackColor = true;
            this.btn_rezervisi.Click += new System.EventHandler(this.btn_rezervisi_Click);
            // 
            // btn_nazad
            // 
            this.btn_nazad.BackColor = System.Drawing.Color.Transparent;
            this.btn_nazad.FlatAppearance.BorderSize = 0;
            this.btn_nazad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_nazad.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_nazad.Location = new System.Drawing.Point(740, 7);
            this.btn_nazad.Margin = new System.Windows.Forms.Padding(0);
            this.btn_nazad.Name = "btn_nazad";
            this.btn_nazad.Size = new System.Drawing.Size(51, 36);
            this.btn_nazad.TabIndex = 11;
            this.btn_nazad.Text = "←";
            this.btn_nazad.UseVisualStyleBackColor = false;
            this.btn_nazad.Click += new System.EventHandler(this.btn_nazad_Click);
            // 
            // rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_nazad);
            this.Controls.Add(this.btn_rezervisi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_biranje);
            this.Controls.Add(this.grid_cenovnik);
            this.Controls.Add(this.cmb_termin);
            this.Controls.Add(this.cmb_usluga);
            this.Controls.Add(this.datum_picker);
            this.Controls.Add(this.cmb_frizer);
            this.Controls.Add(this.lbl_frizer);
            this.Name = "rezervacija";
            this.Text = "rezervacija";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.rezervacija_FormClosed);
            this.Load += new System.EventHandler(this.rezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_cenovnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_frizer;
        private System.Windows.Forms.ComboBox cmb_frizer;
        private System.Windows.Forms.DateTimePicker datum_picker;
        private System.Windows.Forms.ComboBox cmb_usluga;
        private System.Windows.Forms.ComboBox cmb_termin;
        private System.Windows.Forms.DataGridView grid_cenovnik;
        private System.Windows.Forms.Label lbl_biranje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_rezervisi;
        private System.Windows.Forms.Button btn_nazad;
    }
}