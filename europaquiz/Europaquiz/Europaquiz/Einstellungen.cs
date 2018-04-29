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
        
        int art;
        bool micophon=true;
        int schwierigkeit=2;


        public Einstellungen()
        {
            InitializeComponent();

        }



        public void Einstellungen_Load(object sender, EventArgs e)
        {

            
            Schwierigkeitsbox.SelectedIndex = EinstellungenQuiz.Schwierigkeitsgrad - 1;        //Standardauswahl
            Eingabe_Artbox.SelectedIndex = art;

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

            if (Schwierigkeitsbox.Text == "Leicht")
                schwierigkeit = 1;
            else if (Schwierigkeitsbox.Text == "Schwehr")
                schwierigkeit = 3;
            else
                schwierigkeit = 2;
            EinstellungenQuiz.Schwierigkeitsgrad = schwierigkeit;
            EinstellungenQuiz.Spracheingabe = micophon;
            //EinstellungenQuiz EinstQ = new EinstellungenQuiz(micophon, schwierigkeit);
            
            this.Close();
        }

        private void info_Schwierigkeit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wählen Sie ihre Schwiegigkeitsstufe.");

        }

        private void info_Eing_art_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wählen Sie ihre Eingabemethode.Wenn Sie kein Mikrofon besitzen oder kein Mikrofon angeschlossen haben wählen Sie 'Text'.");
        }
        
    }
    public class EinstellungenQuiz
    {

        //Einstellungen Schwieriegkeit und Eingabe Art

        public static int Schwierigkeitsgrad { get; set; }
        public static bool Spracheingabe { get; set; }

        public EinstellungenQuiz(bool Spracheingabe, int Schwierigkeitsgrad)
        {
            EinstellungenQuiz.Schwierigkeitsgrad = Schwierigkeitsgrad;
            EinstellungenQuiz.Spracheingabe = Spracheingabe;
        }

    }
}