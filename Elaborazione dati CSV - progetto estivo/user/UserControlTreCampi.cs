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
    public partial class UserControlTreCampi : UserControl
    {
        string[,] matrice;
        public UserControlTreCampi()
        {
            InitializeComponent();
            matrice = new string[F.NumRighe(Form1.file, Form1.RecordLength), 5];
        }

        private void UserControlTreCampi_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < F.NumRighe(Form1.file, Form1.RecordLength); i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    listView1.Items.Add(matrice[i,j]);
                }
            }
           
        }
    }
}
