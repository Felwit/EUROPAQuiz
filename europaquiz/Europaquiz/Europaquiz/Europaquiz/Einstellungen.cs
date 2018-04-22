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
        string art;
        int schwierigkeit=2;

        public Einstellungen()
        {
            InitializeComponent();
            if (micophon == true)
                art = "M";
            else
                art = "T";  
            Schwierigkeitsbox.SelectedItem = Schwierigkeitsbox.FindStringExact(schwierigkeit.ToString());        //Standardauswahl
            Eingabe_Artbox.SelectedItem = Eingabe_Artbox.FindString(art) ;
        }

        public void Einstellungen_Load(object sender, EventArgs e)
        {
            Schwierigkeitsbox.SelectedItem = Schwierigkeit;        //Standardauswahl
            Eingabe_Artbox.SelectedItem = Eingabe_Artbox;
        }

        

        private void Speichern_Click_1(object sender, EventArgs e)
        {
            //string Schwierigkeitsgrad = Schwierigkeitsbox.Text;        // NOCH NICHT FERTIG
            //string Eingabeart = Eingabe_Artbox.Text;
            //Europaquiz.Einstellungen l = new Europaquiz.Einstellungen(Schwierigkeitsgrad, Eingabeart);
            //string Eingabe_Art = Eingabe_Artbox.Text;

            if (Eingabe_Artbox.Text == "Text")
            {
                micophon = false;
            }
            else
                micophon = true;

            if (Schwierigkeitsbox.Text == "Anfänger")
                schwierigkeit = 1;
            else if (Schwierigkeitsbox.Text == "Profi")
                schwierigkeit = 3;
            else
                schwierigkeit = 2;


            this.Close();
        }

        private void info_Schwierigkeit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wählen Sie ihre Schwiegigkeitsstufe.");

        }

        private void info_Eing_art_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wählen Sie ihre Eingabemethode.Wenn Sie kein Mikrofon besitzen oder kein Mikrofon angeschlossen hben wählen Sie 'Text'.");
        }
        
    }
  }