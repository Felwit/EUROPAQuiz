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
    public partial class Anleitungcs : Form
    {
        public Anleitungcs()
        {
            InitializeComponent();
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            webBrowser1.Navigate(Application.StartupPath + "\\Anleitung.htm");
        }
    }
}
