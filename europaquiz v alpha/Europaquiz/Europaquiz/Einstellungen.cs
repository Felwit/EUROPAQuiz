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
        bool micophon=true;
        int schwierigkeit=2;

        public Einstellungen()
        {
            InitializeComponent();
        }



        public void Einstellungen_Load(object sender, EventArgs e)//Lade Aktuelle EInstellungen und Zeige diese an
        {
            string[] einstellungEN = System.IO.File.ReadAllLines(Application.StartupPath + @"\Einstellungen.txt");
            if (einstellungEN[0] == "true")
            {
                Eingabe_Artbox.SelectedIndex = 0;
            }
            else
            {
                Eingabe_Artbox.SelectedIndex = 1;
            }
            switch (einstellungEN[1])
            {
                case "1":
                    Schwierigkeitsbox.SelectedIndex = 0;
                    break;

                case "2":
                    Schwierigkeitsbox.SelectedIndex = 1;
                    break;
                case "3":
                    Schwierigkeitsbox.SelectedIndex = 2;
                    break;
            }
        }
        

        private void Speichern_Click_1(object sender, EventArgs e)//Lese EIngaben aus 
        {
            if (Eingabe_Artbox.Text == "Text")
            {
                micophon = false;
            }
            else
                micophon = true;

            if (Schwierigkeitsbox.Text == "Einfach")
                schwierigkeit = 1;
            else if (Schwierigkeitsbox.Text == "Schwehr")
                schwierigkeit = 3;
            else
                schwierigkeit = 2;
            string[] lines = { micophon.ToString(), schwierigkeit.ToString()  };// und speichere diese
            System.IO.File.WriteAllLines(Application.StartupPath + @"\Einstellungen.txt", lines);
            this.Close();
        }
        
    }

}