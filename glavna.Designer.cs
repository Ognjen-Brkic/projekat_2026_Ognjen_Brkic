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
            ((System.ComponentModel.ISupportInitialize)(this.grid_recenzije)).BeginInit();
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
            // glavna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_rec);
            this.Controls.Add(this.grid_recenzije);
            this.Name = "glavna";
            this.Text = "glavna";
            this.Load += new System.EventHandler(this.glavna_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_recenzije)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_recenzije;
        private System.Windows.Forms.Button btn_rec;
    }
}