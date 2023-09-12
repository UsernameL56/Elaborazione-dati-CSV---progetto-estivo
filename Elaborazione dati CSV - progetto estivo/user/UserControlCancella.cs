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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Elaborazione_dati_CSV___progetto_estivo.user
{
    public partial class UserControlCancella : UserControl
    {
        string line;
        int righe, n;
        public UserControlCancella()
        {
            InitializeComponent();
            righe = F.NumRighe(Form1.file);
        }

        private void cancellazioneCancella_Click(object sender, EventArgs e)
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
                    F.Cancellazione(Form1.file, Form1.RecordLength, Convert.ToInt32(textBox1.Text));
                    line = F.Ricerca(Form1.file, Form1.RecordLength, Convert.ToInt32(textBox1.Text));
                    listView2.Clear();
                    listView2.Items.Add(line);
                }

            }
            else
                MessageBox.Show("Nella riga bisogna inserire SOLO input di tipo Int", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void UserControlCancella_Load(object sender, EventArgs e)
        {

        }

        private void chiusuraCancella_Click(object sender, EventArgs e)
        {
            F.addUserControl(Form1.Panel1, Form1.home);
        }
    }
}
