using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Europaquiz
{
    public partial class Vorzeitig_verlassen_bestätigen : Form
    {
        public Vorzeitig_verlassen_bestätigen()
        {
            InitializeComponent();
        }

        private void Kontrollfrage_Click(object sender, EventArgs e)
        {

        }

        private void Nein_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ja_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void mitSpeichern_Click(object sender, EventArgs e)
        {
            Ergebnis_Speichern es = new Ergebnis_Speichern();
            es.Show();
        }
    }
}
