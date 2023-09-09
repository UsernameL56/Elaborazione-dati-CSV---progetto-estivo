namespace Elaborazione_dati_CSV___progetto_estivo.user
{
    partial class UserControlCancella
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
            this.label2 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.chiusuraCancella = new System.Windows.Forms.Button();
            this.cancellazioneCancella = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(400, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 34);
            this.label2.TabIndex = 26;
            this.label2.Text = "Originale";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(406, 124);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(877, 33);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(118, 124);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 33);
            this.textBox1.TabIndex = 24;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(112, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "Riga";
            // 
            // chiusuraCancella
            // 
            this.chiusuraCancella.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiusuraCancella.Location = new System.Drawing.Point(773, 309);
            this.chiusuraCancella.Name = "chiusuraCancella";
            this.chiusuraCancella.Size = new System.Drawing.Size(199, 58);
            this.chiusuraCancella.TabIndex = 22;
            this.chiusuraCancella.Text = "Chiudi";
            this.chiusuraCancella.UseVisualStyleBackColor = true;
            this.chiusuraCancella.Click += new System.EventHandler(this.chiusuraCancella_Click);
            // 
            // cancellazioneCancella
            // 
            this.cancellazioneCancella.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancellazioneCancella.Location = new System.Drawing.Point(406, 309);
            this.cancellazioneCancella.Name = "cancellazioneCancella";
            this.cancellazioneCancella.Size = new System.Drawing.Size(199, 58);
            this.cancellazioneCancella.TabIndex = 21;
            this.cancellazioneCancella.Text = "Cancella";
            this.cancellazioneCancella.UseVisualStyleBackColor = true;
            this.cancellazioneCancella.Click += new System.EventHandler(this.cancellazioneCancella_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(400, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 34);
            this.label3.TabIndex = 28;
            this.label3.Text = "Nuovo";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(406, 208);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(877, 33);
            this.listView2.TabIndex = 27;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // UserControlCancella
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chiusuraCancella);
            this.Controls.Add(this.cancellazioneCancella);
            this.Name = "UserControlCancella";
            this.Size = new System.Drawing.Size(1392, 452);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chiusuraCancella;
        private System.Windows.Forms.Button cancellazioneCancella;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView listView2;
    }
}
