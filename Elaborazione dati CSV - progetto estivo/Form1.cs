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

namespace Elaborazione_dati_CSV___progetto_estivo
{
    public partial class Form1 : Form
    {
        string line, file;
        int n, RecordLength;

        public Form1()
        {
            InitializeComponent();
            line = "";
            file = "corsi.csv";
            RecordLength = 250;

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





    }
}
