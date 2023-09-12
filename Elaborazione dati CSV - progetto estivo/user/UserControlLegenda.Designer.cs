namespace Elaborazione_dati_CSV___progetto_estivo.user
{
    partial class UserControlLegenda
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

        #region Codice generato da Progettazione componenti

        /// <summary> 
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControlLegenda));
            this.label1 = new System.Windows.Forms.Label();
            this.chiusuraLegenda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1291, 368);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            // 
            // chiusuraLegenda
            // 
            this.chiusuraLegenda.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiusuraLegenda.Location = new System.Drawing.Point(1137, 354);
            this.chiusuraLegenda.Name = "chiusuraLegenda";
            this.chiusuraLegenda.Size = new System.Drawing.Size(199, 58);
            this.chiusuraLegenda.TabIndex = 23;
            this.chiusuraLegenda.Text = "Chiudi";
            this.chiusuraLegenda.UseVisualStyleBackColor = true;
            this.chiusuraLegenda.Click += new System.EventHandler(this.chiusuraLegenda_Click);
            // 
            // UserControlLegenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chiusuraLegenda);
            this.Controls.Add(this.label1);
            this.Name = "UserControlLegenda";
            this.Size = new System.Drawing.Size(1392, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chiusuraLegenda;
    }
}
