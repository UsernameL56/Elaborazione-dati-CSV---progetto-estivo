namespace Elaborazione_dati_CSV___progetto_estivo.user
{
    partial class UserControlModifica
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
            this.label1 = new System.Windows.Forms.Label();
            this.chiusuraModifica = new System.Windows.Forms.Button();
            this.modificaModifica = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.listView2 = new System.Windows.Forms.ListView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 34);
            this.label2.TabIndex = 26;
            this.label2.Text = "Originale";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(88, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "Riga";
            // 
            // chiusuraModifica
            // 
            this.chiusuraModifica.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chiusuraModifica.Location = new System.Drawing.Point(770, 333);
            this.chiusuraModifica.Name = "chiusuraModifica";
            this.chiusuraModifica.Size = new System.Drawing.Size(199, 58);
            this.chiusuraModifica.TabIndex = 22;
            this.chiusuraModifica.Text = "Chiudi";
            this.chiusuraModifica.UseVisualStyleBackColor = true;
            this.chiusuraModifica.Click += new System.EventHandler(this.chiusuraModifica_Click);
            // 
            // modificaModifica
            // 
            this.modificaModifica.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificaModifica.Location = new System.Drawing.Point(443, 333);
            this.modificaModifica.Name = "modificaModifica";
            this.modificaModifica.Size = new System.Drawing.Size(199, 58);
            this.modificaModifica.TabIndex = 21;
            this.modificaModifica.Text = "Modifica";
            this.modificaModifica.UseVisualStyleBackColor = true;
            this.modificaModifica.Click += new System.EventHandler(this.modificaModifica_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(443, 102);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(827, 33);
            this.listView1.TabIndex = 25;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.List;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 102);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 33);
            this.textBox1.TabIndex = 24;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(94, 186);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(111, 34);
            this.numericUpDown1.TabIndex = 29;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(88, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 34);
            this.label3.TabIndex = 28;
            this.label3.Text = "Campo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 34);
            this.label4.TabIndex = 31;
            this.label4.Text = "Nuovo";
            // 
            // listView2
            // 
            this.listView2.HideSelection = false;
            this.listView2.Location = new System.Drawing.Point(443, 186);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(827, 33);
            this.listView2.TabIndex = 30;
            this.listView2.UseCompatibleStateImageBehavior = false;
            this.listView2.View = System.Windows.Forms.View.List;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 270);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(186, 33);
            this.textBox2.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(88, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 34);
            this.label5.TabIndex = 32;
            this.label5.Text = "Input";
            // 
            // UserControlModifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chiusuraModifica);
            this.Controls.Add(this.modificaModifica);
            this.Name = "UserControlModifica";
            this.Size = new System.Drawing.Size(1392, 452);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button chiusuraModifica;
        private System.Windows.Forms.Button modificaModifica;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label5;
    }
}
