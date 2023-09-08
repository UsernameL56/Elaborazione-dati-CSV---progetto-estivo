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
            this.SuspendLayout();
            // 
            // Funzione1
            // 
            this.Funzione1.Location = new System.Drawing.Point(35, 92);
            this.Funzione1.Name = "Funzione1";
            this.Funzione1.Size = new System.Drawing.Size(136, 42);
            this.Funzione1.TabIndex = 0;
            this.Funzione1.Text = "Aggiunta in coda";
            this.Funzione1.UseVisualStyleBackColor = true;
            this.Funzione1.Click += new System.EventHandler(this.Funzione1_Click);
            // 
            // Funzione2
            // 
            this.Funzione2.Location = new System.Drawing.Point(186, 92);
            this.Funzione2.Name = "Funzione2";
            this.Funzione2.Size = new System.Drawing.Size(136, 42);
            this.Funzione2.TabIndex = 1;
            this.Funzione2.Text = "Numero campi";
            this.Funzione2.UseVisualStyleBackColor = true;
            this.Funzione2.Click += new System.EventHandler(this.Funzione2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1416, 552);
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
    }
}

