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
    public partial class Verlassen_bestätigen : Form
    {
        public Verlassen_bestätigen()
        {
            InitializeComponent();
            Ja.Focus();//setze Fokus auf Button_JA
        }


        private void JA_Click(object sender, EventArgs e)
        {
            Application.Exit();// Beende Program
        }

        private void Nein_Click(object sender, EventArgs e)
        {
            this.Close();//Schließe nur dieses Fenster
        }
    }
}
