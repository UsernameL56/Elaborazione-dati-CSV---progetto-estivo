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
        public static string line, file;
        public static int n, RecordLength;
        public static UserControlHome home;
        public static Panel Panel1;
        UserControlRecordCoda rc;
        UserControlTreCampi tc;
        


        public Form1()
        {
            InitializeComponent();
            line = "";
            file = "corsi.csv";
            RecordLength = 250;
            home = new UserControlHome();
            rc = new UserControlRecordCoda();
            tc = new UserControlTreCampi();
            Panel1 = panel1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader("Nuovo Documento di testo.txt");
            StreamWriter writer = new StreamWriter("corsi.csv");
            while ((line = reader.ReadLine()) != null)
            {
                writer.WriteLine((line +";").PadRight(RecordLength - 4) + "##");
            }
            reader.Close();
            writer.Close();

           
            F.addUserControl(panel1, home);
        }

        private void Funzione1_Click(object sender, EventArgs e)
        {
            F.AggiuntaRecords(file, RecordLength);
        }

        private void Funzione2_Click(object sender, EventArgs e)
        {
            n = F.NumeroCampi(file, RecordLength);
            MessageBox.Show("Il numero di campi è: " + n, "info");
        }

        private void Funzione3_Click(object sender, EventArgs e)
        {
            n = F.LunghezzaMassima(file, RecordLength);
            MessageBox.Show("La lunghezza massima dei record presenti è: " + n, "info");
        }

        private void Funzione5_Click(object sender, EventArgs e)
        {
           
            F.addUserControl(panel1, rc);
        }
        private void Funzioni6_Click(object sender, EventArgs e)
        {
            F.addUserControl(panel1, tc);
        }





    }
}
