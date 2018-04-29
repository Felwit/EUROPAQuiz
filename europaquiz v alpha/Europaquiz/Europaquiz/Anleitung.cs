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
    public partial class Anleitung : Form
    {
        public Anleitung()
        {
            InitializeComponent();
        }

        private void Anleitung_Load(object sender, EventArgs e)
        {
            //webBrowser1.Navigate(@"C:\Users\NoMiGXZ\Source\EUROPAQuiz\Anleitung.htm");

            webBrowser1.Navigate(Application.StartupPath + @"\Anleitung.htm");
        }
    }
}
