using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using FunzioniCSV;

namespace Elaborazione_dati_CSV___progetto_estivo.user
{
    public partial class UserControlRecordCoda : UserControl
    {
        public UserControlRecordCoda()
        {
            InitializeComponent();
        }

        private void aggiuntaRecordCoda_Click(object sender, EventArgs e)
        {
            string sep = ";", line = textBox1.Text + sep + textBox2.Text + sep + textBox3.Text + sep + textBox4.Text + sep + textBox5.Text + sep + textBox6.Text + sep;
            F.RecordCoda(Form1.file, Form1.RecordLength, line);
        }

        private void chiusuraRecordCoda_Click(object sender, EventArgs e)
        {
            F.addUserControl(Form1.Panel1, Form1.home);
        }
    }
}
