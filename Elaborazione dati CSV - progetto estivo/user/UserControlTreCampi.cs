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
using static System.Net.Mime.MediaTypeNames;

namespace Elaborazione_dati_CSV___progetto_estivo.user
{
    public partial class UserControlTreCampi : UserControl
    {
        string[,] matrice;
        string sep;
        int j, x;
        public UserControlTreCampi()
        {
            InitializeComponent();
            sep = ";";
            j = F.NumRighe(Form1.file);
            x = F.NumeroCampi(Form1.file, Form1.RecordLength);
            matrice = F.TreCampi(Form1.file, Form1.RecordLength, (int)numericUpDown1.Value, (int)numericUpDown2.Value, (int)numericUpDown3.Value);
        }

        private void UserControlTreCampi_Load(object sender, EventArgs e)
        {

        }

        private void aggiuntaTreCampi_Click(object sender, EventArgs e)
        {
            if ((int)numericUpDown1.Value > x || (int)numericUpDown2.Value > x || (int)numericUpDown3.Value > x)
            {
                MessageBox.Show("Il numero massimo di campi è: " + x +"\nInserire un numero minore o uguale a: " + x, "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {   
                for (int i = 0; i < j; i++)
                {
                    listView1.Items.Add(matrice[i, 0] + sep + (matrice[i, 1]) + sep + (matrice[i, 2]));
                }
            }
            
        }

        private void chiusuraTreCampi_Click(object sender, EventArgs e)
        {
            F.addUserControl(Form1.Panel1, Form1.home);
        }
    }
}
