namespace Elaborazione_dati_CSV___progetto_estivo.user
{
    partial class UserControlTreCampi
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.aggiuntaTreCampi = new System.Windows.Forms.Button();
            this.chiusuraTreCampi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(46, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(332, 33);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(384, 58);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(332, 33);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(722, 58);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(332, 33);
            this.textBox3.TabIndex = 2;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(46, 97);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1008, 302);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 34);
            this.label1.TabIndex = 4;
            this.label1.Text = "Split 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(378, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 34);
            this.label2.TabIndex = 5;
            this.label2.Text = "Split 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(716, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 34);
            this.label3.TabIndex = 6;
            this.label3.Text = "Split 3";
            // 
            // aggiuntaTreCampi
            // 
            this.aggiuntaTreCampi.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aggiuntaTreCampi.Location = new System.Drawing.Point(1124, 191);
            this.aggiuntaTreCampi.Name = "aggiuntaTreCampi";
            this.aggiuntaTreCampi.Size = new System.Drawing.Size(199, 58);
            this.aggiuntaTreCampi.TabIndex = 15;
            this.aggiuntaTreCampi.Text = "Invia";
            this.aggiuntaTreCampi.UseVisualStyleBackColor = true;
            // 
            // chiusuraTreCampi
            // 
            this.chiusuraTreCampi.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiusuraTreCampi.Location = new System.Drawing.Point(1124, 255);
            this.chiusuraTreCampi.Name = "chiusuraTreCampi";
            this.chiusuraTreCampi.Size = new System.Drawing.Size(199, 58);
            this.chiusuraTreCampi.TabIndex = 16;
            this.chiusuraTreCampi.Text = "Chiudi";
            this.chiusuraTreCampi.UseVisualStyleBackColor = true;
            // 
            // UserControlTreCampi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.chiusuraTreCampi);
            this.Controls.Add(this.aggiuntaTreCampi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "UserControlTreCampi";
            this.Size = new System.Drawing.Size(1392, 452);
            this.Load += new System.EventHandler(this.UserControlTreCampi_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button aggiuntaTreCampi;
        private System.Windows.Forms.Button chiusuraTreCampi;
    }
}
