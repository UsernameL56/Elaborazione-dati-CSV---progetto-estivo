namespace Elaborazione_dati_CSV___progetto_estivo
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
            this.Funzione1 = new System.Windows.Forms.Button();
            this.Funzione2 = new System.Windows.Forms.Button();
            this.Funzione3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Funzione5 = new System.Windows.Forms.Button();
            this.Funzioni6 = new System.Windows.Forms.Button();
            this.Funzione7 = new System.Windows.Forms.Button();
            this.Funzione8 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Funzione1
            // 
            this.Funzione1.Location = new System.Drawing.Point(12, 12);
            this.Funzione1.Name = "Funzione1";
            this.Funzione1.Size = new System.Drawing.Size(136, 42);
            this.Funzione1.TabIndex = 0;
            this.Funzione1.Text = "Aggiunta in coda";
            this.Funzione1.UseVisualStyleBackColor = true;
            this.Funzione1.Click += new System.EventHandler(this.Funzione1_Click);
            // 
            // Funzione2
            // 
            this.Funzione2.Location = new System.Drawing.Point(154, 12);
            this.Funzione2.Name = "Funzione2";
            this.Funzione2.Size = new System.Drawing.Size(136, 42);
            this.Funzione2.TabIndex = 1;
            this.Funzione2.Text = "Numero campi";
            this.Funzione2.UseVisualStyleBackColor = true;
            this.Funzione2.Click += new System.EventHandler(this.Funzione2_Click);
            // 
            // Funzione3
            // 
            this.Funzione3.Location = new System.Drawing.Point(296, 12);
            this.Funzione3.Name = "Funzione3";
            this.Funzione3.Size = new System.Drawing.Size(136, 42);
            this.Funzione3.TabIndex = 2;
            this.Funzione3.Text = "Lunghezza massima";
            this.Funzione3.UseVisualStyleBackColor = true;
            this.Funzione3.Click += new System.EventHandler(this.Funzione3_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1392, 452);
            this.panel1.TabIndex = 3;
            // 
            // Funzione5
            // 
            this.Funzione5.Location = new System.Drawing.Point(438, 12);
            this.Funzione5.Name = "Funzione5";
            this.Funzione5.Size = new System.Drawing.Size(136, 42);
            this.Funzione5.TabIndex = 4;
            this.Funzione5.Text = "Record in coda";
            this.Funzione5.UseVisualStyleBackColor = true;
            this.Funzione5.Click += new System.EventHandler(this.Funzione5_Click);
            // 
            // Funzioni6
            // 
            this.Funzioni6.Location = new System.Drawing.Point(580, 12);
            this.Funzioni6.Name = "Funzioni6";
            this.Funzioni6.Size = new System.Drawing.Size(136, 42);
            this.Funzioni6.TabIndex = 5;
            this.Funzioni6.Text = "Tre campi a scelta";
            this.Funzioni6.UseVisualStyleBackColor = true;
            this.Funzioni6.Click += new System.EventHandler(this.Funzioni6_Click);
            // 
            // Funzione7
            // 
            this.Funzione7.Location = new System.Drawing.Point(722, 12);
            this.Funzione7.Name = "Funzione7";
            this.Funzione7.Size = new System.Drawing.Size(136, 42);
            this.Funzione7.TabIndex = 6;
            this.Funzione7.Text = "Ricerca";
            this.Funzione7.UseVisualStyleBackColor = true;
            this.Funzione7.Click += new System.EventHandler(this.Funzione7_Click);
            // 
            // Funzione8
            // 
            this.Funzione8.Location = new System.Drawing.Point(864, 12);
            this.Funzione8.Name = "Funzione8";
            this.Funzione8.Size = new System.Drawing.Size(136, 42);
            this.Funzione8.TabIndex = 7;
            this.Funzione8.Text = "Modifica";
            this.Funzione8.UseVisualStyleBackColor = true;
            this.Funzione8.Click += new System.EventHandler(this.Funzione8_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1416, 552);
            this.Controls.Add(this.Funzione8);
            this.Controls.Add(this.Funzione7);
            this.Controls.Add(this.Funzioni6);
            this.Controls.Add(this.Funzione5);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Funzione3);
            this.Controls.Add(this.Funzione2);
            this.Controls.Add(this.Funzione1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Funzione1;
        private System.Windows.Forms.Button Funzione2;
        private System.Windows.Forms.Button Funzione3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Funzione5;
        private System.Windows.Forms.Button Funzioni6;
        private System.Windows.Forms.Button Funzione7;
        private System.Windows.Forms.Button Funzione8;
    }
}

