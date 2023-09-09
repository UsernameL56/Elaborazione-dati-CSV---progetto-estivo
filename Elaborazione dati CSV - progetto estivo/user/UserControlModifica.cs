using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FunzioniCSV;

namespace Elaborazione_dati_CSV___progetto_estivo.user
{
    public partial class UserControlModifica : UserControl
    {
        string line;
        int n, x;
        public UserControlModifica()
        {
            InitializeComponent();
            x = F.NumeroCampi(Form1.file, Form1.RecordLength);
        }

        private void modificaModifica_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out n))
            {
                if ((int)numericUpDown1.Value > x)
                    MessageBox.Show("Il numero massimo di campi è: " + x + "\nInserire un numero minore o uguale a: " + x, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    if ((int)numericUpDown1.Value == 6)
                        MessageBox.Show("Il campo numero 6 è il campo univoco, pertanto non è possibile modificarlo", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    else
                    {
                        line = F.Ricerca(Form1.file, Form1.RecordLength, Convert.ToInt32(textBox1.Text));
                        listView1.Clear();
                        listView1.Items.Add(line);
                        F.Modifica(Form1.file, Form1.RecordLength, Convert.ToInt32(textBox1.Text), (int)numericUpDown1.Value, textBox2.Text);
                        line = F.Ricerca(Form1.file, Form1.RecordLength, Convert.ToInt32(textBox1.Text));
                        listView2.Clear();
                        listView2.Items.Add(line);
                    }
                    
                }
                    
            }
            else
                MessageBox.Show("Nella riga bisogna inserire SOLO input di tipo Int", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        }

        private void chiusuraModifica_Click(object sender, EventArgs e)
        {
            F.addUserControl(Form1.Panel1, Form1.home);
        }
    }
}
