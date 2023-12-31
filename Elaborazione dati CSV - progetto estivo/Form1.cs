﻿using System;
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
        public static int n, RecordLength, controllo;
        public static UserControlHome home;
        public static Panel Panel1;
        
        public Form1()
        {
            InitializeComponent();
            line = "";
            file = "corsi.csv";
            appoggio = "Originale.csv";
            RecordLength = 250;
            controllo = 0;
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
            if(controllo == 0)
            {
                F.AggiuntaRecords(file, RecordLength);
                MessageBox.Show("I campi \"miovalore\" e \"cancellazione logica\" sono stati aggiunti con successo", "Informazione", MessageBoxButtons.OK, MessageBoxIcon.Information);
                controllo++;
            }
            else
                MessageBox.Show("Questa funzione è già stata utilizzata", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
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
            if (controllo == 1)
            {
                UserControlRecordCoda rc = new UserControlRecordCoda();
                F.addUserControl(panel1, rc);
            }
            else
                MessageBox.Show("Prima di utilizzare questa funzione è necessario utilizzare l'Aggiunta in coda", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);

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
        private void Funzione8_Click(object sender, EventArgs e)
        {
            UserControlModifica md = new UserControlModifica();
            F.addUserControl(panel1, md);
        }
        private void Funzione9_Click(object sender, EventArgs e)
        {
            if(controllo == 1)
            {
                UserControlCancella cn = new UserControlCancella();
                F.addUserControl(panel1, cn);
            }
            else
                MessageBox.Show("Prima di utilizzare questa funzione è necessario utilizzare l'Aggiunta in coda", "Errore", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
        }
        private void legenda_Click(object sender, EventArgs e)
        {
            UserControlLegenda lg = new UserControlLegenda();
            F.addUserControl(panel1, lg);
        }




    }
}
