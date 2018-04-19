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
    public partial class Einstellungen : Form
    {

        public Einstellungen()
        {
            InitializeComponent();
            Schwierigkeitsbox.SelectedItem = "Anfänger";        //Standardauswahl
            Eingabe_Artbox.SelectedItem = "Text";


        }


        public void Einstellungen_Load(object sender, EventArgs e)
        {
            Schwierigkeitsbox.SelectedItem = Schwierigkeit;        //Standardauswahl
            Eingabe_Artbox.SelectedItem = Eingabe_Artbox;
        }

        public void Speichern_Click(object sender, EventArgs e)
        {
            string Schwierigkeitsgrad = Schwierigkeitsbox.Text;        // NOCH NICHT FERTIG

            string Eingabe_Art = Eingabe_Artbox.Text;

            this.Close();
        }
    }
}
