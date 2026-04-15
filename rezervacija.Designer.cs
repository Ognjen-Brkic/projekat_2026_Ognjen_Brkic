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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.grid_cenovnik = new System.Windows.Forms.DataGridView();
            this.lbl_biranje = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
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
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(38, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(271, 134);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(426, 134);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // grid_cenovnik
            // 
            this.grid_cenovnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_cenovnik.Location = new System.Drawing.Point(38, 222);
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
            // rezervacija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_biranje);
            this.Controls.Add(this.grid_cenovnik);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.cmb_frizer);
            this.Controls.Add(this.lbl_frizer);
            this.Name = "rezervacija";
            this.Text = "rezervacija";
            this.Load += new System.EventHandler(this.rezervacija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_cenovnik)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_frizer;
        private System.Windows.Forms.ComboBox cmb_frizer;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.DataGridView grid_cenovnik;
        private System.Windows.Forms.Label lbl_biranje;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}