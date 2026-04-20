namespace projekat_2026_Ognjen_Brkic
{
    partial class admin
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
            this.grid_terminiadmin = new System.Windows.Forms.DataGridView();
            this.btn_blokiraj = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grid_terminiadmin)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_terminiadmin
            // 
            this.grid_terminiadmin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_terminiadmin.Location = new System.Drawing.Point(12, 12);
            this.grid_terminiadmin.Name = "grid_terminiadmin";
            this.grid_terminiadmin.Size = new System.Drawing.Size(776, 314);
            this.grid_terminiadmin.TabIndex = 0;
            // 
            // btn_blokiraj
            // 
            this.btn_blokiraj.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_blokiraj.Location = new System.Drawing.Point(12, 332);
            this.btn_blokiraj.Name = "btn_blokiraj";
            this.btn_blokiraj.Size = new System.Drawing.Size(122, 37);
            this.btn_blokiraj.TabIndex = 1;
            this.btn_blokiraj.Text = "Blokiraj termine";
            this.btn_blokiraj.UseVisualStyleBackColor = true;
            this.btn_blokiraj.Click += new System.EventHandler(this.btn_blokiraj_Click);
            // 
            // admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_blokiraj);
            this.Controls.Add(this.grid_terminiadmin);
            this.Name = "admin";
            this.Text = "admin";
            this.Load += new System.EventHandler(this.admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_terminiadmin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView grid_terminiadmin;
        private System.Windows.Forms.Button btn_blokiraj;
    }
}