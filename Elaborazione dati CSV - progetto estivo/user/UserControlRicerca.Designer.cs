namespace Elaborazione_dati_CSV___progetto_estivo.user
{
    partial class UserControlRicerca
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
            this.cercaRicerca = new System.Windows.Forms.Button();
            this.chiusuraRicerca = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cercaRicerca
            // 
            this.cercaRicerca.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cercaRicerca.Location = new System.Drawing.Point(421, 335);
            this.cercaRicerca.Name = "cercaRicerca";
            this.cercaRicerca.Size = new System.Drawing.Size(199, 58);
            this.cercaRicerca.TabIndex = 15;
            this.cercaRicerca.Text = "Ricerca";
            this.cercaRicerca.UseVisualStyleBackColor = true;
            this.cercaRicerca.Click += new System.EventHandler(this.cercaRicerca_Click);
            // 
            // chiusuraRicerca
            // 
            this.chiusuraRicerca.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiusuraRicerca.Location = new System.Drawing.Point(788, 335);
            this.chiusuraRicerca.Name = "chiusuraRicerca";
            this.chiusuraRicerca.Size = new System.Drawing.Size(199, 58);
            this.chiusuraRicerca.TabIndex = 16;
            this.chiusuraRicerca.Text = "Chiudi";
            this.chiusuraRicerca.UseVisualStyleBackColor = true;
            this.chiusuraRicerca.Click += new System.EventHandler(this.chiusuraRicerca_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(175, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 34);
            this.label1.TabIndex = 17;
            this.label1.Text = "Riga";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(181, 149);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 33);
            this.textBox1.TabIndex = 18;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(421, 150);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(827, 33);
            this.listView1.TabIndex = 19;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(415, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 34);
            this.label2.TabIndex = 20;
            this.label2.Text = "Output";
            // 
            // UserControlRicerca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chiusuraRicerca);
            this.Controls.Add(this.cercaRicerca);
            this.Name = "UserControlRicerca";
            this.Size = new System.Drawing.Size(1392, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cercaRicerca;
        private System.Windows.Forms.Button chiusuraRicerca;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
    }
}
