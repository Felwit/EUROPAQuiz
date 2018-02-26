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

        private void Spiel_verlassen_Click(object sender, EventArgs e)
        {
            

        }

        private void Neues_Spiel_Click(object sender, EventArgs e)
        {
            Europaquiz f = new Europaquiz();
            f.Show();
          
        }
    }
}
