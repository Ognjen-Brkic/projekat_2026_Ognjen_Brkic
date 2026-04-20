namespace projekat_2026_Ognjen_Brkic
{
    partial class glavna
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
            this.grid_recenzije = new System.Windows.Forms.DataGridView();
            this.btn_rec = new System.Windows.Forms.Button();
            this.btn_rezervacija = new System.Windows.Forms.Button();
            this.grid_termini = new System.Windows.Forms.DataGridView();
            this.btn_otkazi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_recenzije)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_termini)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_recenzije
            // 
            this.grid_recenzije.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_recenzije.Location = new System.Drawing.Point(12, 241);
            this.grid_recenzije.Name = "grid_recenzije";
            this.grid_recenzije.Size = new System.Drawing.Size(476, 131);
            this.grid_recenzije.TabIndex = 0;
            this.grid_recenzije.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.grid_recenzije_CellFormatting);
            // 
            // btn_rec
            // 
            this.btn_rec.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rec.Location = new System.Drawing.Point(12, 390);
            this.btn_rec.Name = "btn_rec";
            this.btn_rec.Size = new System.Drawing.Size(124, 37);
            this.btn_rec.TabIndex = 1;
            this.btn_rec.Text = "Ostavite recenziju";
            this.btn_rec.UseVisualStyleBackColor = true;
            this.btn_rec.Click += new System.EventHandler(this.btn_rec_Click);
            // 
            // btn_rezervacija
            // 
            this.btn_rezervacija.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_rezervacija.Location = new System.Drawing.Point(12, 182);
            this.btn_rezervacija.Name = "btn_rezervacija";
            this.btn_rezervacija.Size = new System.Drawing.Size(124, 33);
            this.btn_rezervacija.TabIndex = 2;
            this.btn_rezervacija.Text = "Rezervisi termin";
            this.btn_rezervacija.UseVisualStyleBackColor = true;
            this.btn_rezervacija.Click += new System.EventHandler(this.btn_rezervacija_Click);
            // 
            // grid_termini
            // 
            this.grid_termini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_termini.Location = new System.Drawing.Point(12, 37);
            this.grid_termini.Name = "grid_termini";
            this.grid_termini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid_termini.Size = new System.Drawing.Size(476, 122);
            this.grid_termini.TabIndex = 3;
            // 
            // btn_otkazi
            // 
            this.btn_otkazi.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_otkazi.Location = new System.Drawing.Point(386, 165);
            this.btn_otkazi.Name = "btn_otkazi";
            this.btn_otkazi.Size = new System.Drawing.Size(102, 32);
            this.btn_otkazi.TabIndex = 4;
            this.btn_otkazi.Text = "Otkazi";
            this.btn_otkazi.UseVisualStyleBackColor = true;
            this.btn_otkazi.Click += new System.EventHandler(this.btn_otkazi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 23);
            this.label1.TabIndex = 5;
            this.label1.Text = "Vasi termini";
            // 
            // glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_otkazi);
            this.Controls.Add(this.grid_termini);
            this.Controls.Add(this.btn_rezervacija);
            this.Controls.Add(this.btn_rec);
            this.Controls.Add(this.grid_recenzije);
            this.Name = "glavna";
            this.Text = "glavna";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.glavna_FormClosed);
            this.Load += new System.EventHandler(this.glavna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_recenzije)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grid_termini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_recenzije;
        private System.Windows.Forms.Button btn_rec;
        private System.Windows.Forms.Button btn_rezervacija;
        private System.Windows.Forms.DataGridView grid_termini;
        private System.Windows.Forms.Button btn_otkazi;
        private System.Windows.Forms.Label label1;
    }
}