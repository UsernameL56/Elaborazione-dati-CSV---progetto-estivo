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
    public partial class UserControlRicerca : UserControl
    {
        int n, righe;
        string line;
        public UserControlRicerca()
        {
            InitializeComponent();
            righe = F.NumRighe(Form1.file);
        }

        private void cercaRicerca_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox1.Text, out n))
            {
                if (Convert.ToInt32(textBox1.Text) > righe)
                    MessageBox.Show("Inserire un numero compreso tra 1 e " + righe, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    line = F.Ricerca(Form1.file, Form1.RecordLength, Convert.ToInt32(textBox1.Text));
                    listView1.Clear();
                    listView1.Items.Add(line);
                }
                    
            }
            else
                MessageBox.Show("Nella riga bisogna inserire SOLO input di tipo Int", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
           
        }

        private void chiusuraRicerca_Click(object sender, EventArgs e)
        {
            F.addUserControl(Form1.Panel1, Form1.home);
        }
    }
}
