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

        private void Nein_Click(object sender, EventArgs e)
        {
            this.Close();//schließe dieses Fensters
        }

        private void Ja_Click(object sender, EventArgs e)
        {
            Application.Exit(); // schließe Anwendung
        }

        private void mitSpeichern_Click(object sender, EventArgs e)
        {
            Ergebnis_Speichern es = new Ergebnis_Speichern();//öffe FEnster zum Speichern; Schließen erfolgt nach Speicherung
            es.Show();
        }
    }
}
