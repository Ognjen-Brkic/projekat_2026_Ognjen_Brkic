namespace projekat_2026_Ognjen_Brkic
{
    partial class blokiraj
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
            this.grid_blokirani = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_termin1 = new System.Windows.Forms.ComboBox();
            this.cmb_termin2 = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.blok_datum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_blokirani)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_blokirani
            // 
            this.grid_blokirani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_blokirani.Location = new System.Drawing.Point(12, 38);
            this.grid_blokirani.Name = "grid_blokirani";
            this.grid_blokirani.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_blokirani.Size = new System.Drawing.Size(483, 185);
            this.grid_blokirani.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Blokirani termini";
            // 
            // cmb_termin1
            // 
            this.cmb_termin1.FormattingEnabled = true;
            this.cmb_termin1.Location = new System.Drawing.Point(224, 266);
            this.cmb_termin1.Name = "cmb_termin1";
            this.cmb_termin1.Size = new System.Drawing.Size(121, 21);
            this.cmb_termin1.TabIndex = 2;
            // 
            // cmb_termin2
            // 
            this.cmb_termin2.FormattingEnabled = true;
            this.cmb_termin2.Location = new System.Drawing.Point(374, 266);
            this.cmb_termin2.Name = "cmb_termin2";
            this.cmb_termin2.Size = new System.Drawing.Size(121, 21);
            this.cmb_termin2.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(12, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(96, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Blokiraj";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 241);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pocetni termin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 241);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "Krajni termin";
            // 
            // blok_datum
            // 
            this.blok_datum.Location = new System.Drawing.Point(12, 266);
            this.blok_datum.Name = "blok_datum";
            this.blok_datum.Size = new System.Drawing.Size(200, 20);
            this.blok_datum.TabIndex = 7;
            this.blok_datum.ValueChanged += new System.EventHandler(this.blok_datum_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "Izaberi datum";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(399, 320);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(96, 36);
            this.button2.TabIndex = 9;
            this.button2.Text = "Odblokiraj";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // blokiraj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.blok_datum);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmb_termin2);
            this.Controls.Add(this.cmb_termin1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_blokirani);
            this.Name = "blokiraj";
            this.Text = "blokiraj";
            this.Load += new System.EventHandler(this.blokiraj_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_blokirani)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_blokirani;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_termin1;
        private System.Windows.Forms.ComboBox cmb_termin2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker blok_datum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
    }
}