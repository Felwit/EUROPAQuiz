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
    public partial class Hauptmenü : Form
    {
        public Hauptmenü()
        {
            InitializeComponent();
            
        }



        private void Neues_Spiel_Click(object sender, EventArgs e)
        {
            Europaquiz f = new Europaquiz();
            f.Show();
          
        }

        private void Einstellungen_Click(object sender, EventArgs e)
        {
            Einstellungen E = new Einstellungen();
            E.Show();
        }

        private void Spiel_verlassen_Click_1(object sender, EventArgs e)
        {
            Verlassen_bestätigen v = new Verlassen_bestätigen();
            v.Show();
        }

        private void Hauptmenü_Load(object sender, EventArgs e)
        {

        }
    }
}
