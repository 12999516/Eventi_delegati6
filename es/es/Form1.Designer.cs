namespace es
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_titolo = new System.Windows.Forms.Label();
            this.pct_cane = new System.Windows.Forms.PictureBox();
            this.pct_gatto = new System.Windows.Forms.PictureBox();
            this.pct_mucca = new System.Windows.Forms.PictureBox();
            this.lbl_mucca = new System.Windows.Forms.Label();
            this.lbl_gatto = new System.Windows.Forms.Label();
            this.lbl_cane = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pct_cane)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_gatto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_mucca)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_titolo
            // 
            this.lbl_titolo.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_titolo.Location = new System.Drawing.Point(407, 19);
            this.lbl_titolo.Name = "lbl_titolo";
            this.lbl_titolo.Size = new System.Drawing.Size(264, 87);
            this.lbl_titolo.TabIndex = 0;
            this.lbl_titolo.Text = "fattoria";
            // 
            // pct_cane
            // 
            this.pct_cane.Location = new System.Drawing.Point(722, 192);
            this.pct_cane.Name = "pct_cane";
            this.pct_cane.Size = new System.Drawing.Size(264, 250);
            this.pct_cane.TabIndex = 1;
            this.pct_cane.TabStop = false;
            this.pct_cane.Click += new System.EventHandler(this.pct_mucca_Click);
            // 
            // pct_gatto
            // 
            this.pct_gatto.Location = new System.Drawing.Point(385, 192);
            this.pct_gatto.Name = "pct_gatto";
            this.pct_gatto.Size = new System.Drawing.Size(264, 250);
            this.pct_gatto.TabIndex = 2;
            this.pct_gatto.TabStop = false;
            this.pct_gatto.Click += new System.EventHandler(this.pct_gatto_Click);
            // 
            // pct_mucca
            // 
            this.pct_mucca.Location = new System.Drawing.Point(77, 192);
            this.pct_mucca.Name = "pct_mucca";
            this.pct_mucca.Size = new System.Drawing.Size(264, 250);
            this.pct_mucca.TabIndex = 3;
            this.pct_mucca.TabStop = false;
            this.pct_mucca.Click += new System.EventHandler(this.pct_cane_Click);
            // 
            // lbl_mucca
            // 
            this.lbl_mucca.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mucca.Location = new System.Drawing.Point(43, 159);
            this.lbl_mucca.Name = "lbl_mucca";
            this.lbl_mucca.Size = new System.Drawing.Size(316, 30);
            this.lbl_mucca.TabIndex = 4;
            this.lbl_mucca.Text = "la mucca pancake fa muu";
            // 
            // lbl_gatto
            // 
            this.lbl_gatto.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_gatto.Location = new System.Drawing.Point(365, 159);
            this.lbl_gatto.Name = "lbl_gatto";
            this.lbl_gatto.Size = new System.Drawing.Size(337, 30);
            this.lbl_gatto.TabIndex = 5;
            this.lbl_gatto.Text = "il gatto biscotto fa miao";
            // 
            // lbl_cane
            // 
            this.lbl_cane.Font = new System.Drawing.Font("Consolas", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cane.Location = new System.Drawing.Point(703, 159);
            this.lbl_cane.Name = "lbl_cane";
            this.lbl_cane.Size = new System.Drawing.Size(296, 30);
            this.lbl_cane.TabIndex = 6;
            this.lbl_cane.Text = "il cane diesel fa bau";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lbl_cane);
            this.Controls.Add(this.lbl_gatto);
            this.Controls.Add(this.lbl_mucca);
            this.Controls.Add(this.pct_mucca);
            this.Controls.Add(this.pct_gatto);
            this.Controls.Add(this.pct_cane);
            this.Controls.Add(this.lbl_titolo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pct_cane)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_gatto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pct_mucca)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_titolo;
        private System.Windows.Forms.PictureBox pct_cane;
        private System.Windows.Forms.PictureBox pct_gatto;
        private System.Windows.Forms.PictureBox pct_mucca;
        private System.Windows.Forms.Label lbl_mucca;
        private System.Windows.Forms.Label lbl_gatto;
        private System.Windows.Forms.Label lbl_cane;
    }
}

