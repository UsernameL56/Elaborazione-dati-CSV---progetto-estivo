using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FunzioniCSV;
using System.Runtime.Remoting.Contexts;
using Elaborazione_dati_CSV___progetto_estivo.user;

namespace Elaborazione_dati_CSV___progetto_estivo
{
    public partial class Form1 : Form
    {
        public static string line, file, appoggio;
        public static int n, RecordLength;
        public static UserControlHome home;
        public static Panel Panel1;
        
        public Form1()
        {
            InitializeComponent();
            line = "";
            file = "corsi.csv";
            appoggio = "Originale.csv";
            RecordLength = 250;
            home = new UserControlHome();
            Panel1 = panel1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            F.Spaziatura(file, appoggio, RecordLength);
            F.addUserControl(panel1, home);
        }

        private void Funzione1_Click(object sender, EventArgs e)
        {
            F.AggiuntaRecords(file, RecordLength);
        }

        private void Funzione2_Click(object sender, EventArgs e)
        {
            n = F.NumeroCampi(file, RecordLength);
            MessageBox.Show("Il numero di campi è: " + n, "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Funzione3_Click(object sender, EventArgs e)
        {
            n = F.LunghezzaMassima(file, RecordLength);
            MessageBox.Show("La lunghezza massima dei record presenti è: " + n, "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Funzione5_Click(object sender, EventArgs e)
        {
            UserControlRecordCoda rc = new UserControlRecordCoda();
            F.addUserControl(panel1, rc);
        }
        private void Funzioni6_Click(object sender, EventArgs e)
        {
            UserControlTreCampi tc = new UserControlTreCampi();
            F.addUserControl(panel1, tc);
        }
        private void Funzione7_Click(object sender, EventArgs e)
        {
            UserControlRicerca r = new UserControlRicerca();
            F.addUserControl(panel1, r);
        }





    }
}
