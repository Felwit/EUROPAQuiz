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
            //Eingabe_Artbox.SelectedIndex = art;
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

            if (Schwierigkeitsbox.Text == "Einfach")
                schwierigkeit = 1;
            else if (Schwierigkeitsbox.Text == "Schwehr")
                schwierigkeit = 3;
            else
                schwierigkeit = 2;
            string[] lines = { micophon.ToString(), schwierigkeit.ToString()  };
            System.IO.File.WriteAllLines(Application.StartupPath + @"\Einstellungen.txt", lines);
            this.Close();
        }

        

        
    }
////    (//public class EinstellungenQuiz
////    {

////        Einstellungen Schwieriegkeit und Eingabe Art

////        public static int Schwierigkeitsgrad { get; set; }
////    public static bool Spracheingabe { get; set; }

////    public EinstellungenQuiz(bool Spracheingabe, int Schwierigkeitsgrad)
////    {
////        EinstellungenQuiz.Schwierigkeitsgrad = Schwierigkeitsgrad;
////        EinstellungenQuiz.Spracheingabe = Spracheingabe;
////    }

////}
}