using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Svg;
using System.Speech.Recognition;
using System.IO;

namespace Europaquiz
{

    public partial class Europaquiz : Form
    {
        string[] SVG = File.ReadAllLines(Application.StartupPath + @"\Europa.svg");
        int[] LH = new int[47]; // Die Anzahl der Länder mit Array
        int Länder = 0;
        Random random = new Random();
        int anzLänder = 0;
        int Auswahl;
        int countdown = 0;
        int[] gespielte = new int[1];//max. Größe ergibt sich eigentlich aus Schwierigkeit
        bool click1 = true;
        string[] zeilen;
        int schwierigkeit;
        int schwierigkeitL = 0;
        string istland;
        string isths;

        private SpeechRecognitionEngine spracherkennung = new SpeechRecognitionEngine();

        public Europaquiz()
        {
            InitializeComponent();
            // LetzteLösung.BackColor = Color.FromArgb(1,0,50,50);
        }

        private void Europaquiz_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds; // Formulargröße auf Größe des Bildschirms festlegen

            File.WriteAllLines(Application.StartupPath + @"\NeueEuropa.svg", SVG);// Soll darauf zugreifen
            webBrowser1.Navigate(Application.StartupPath + @"\NeueEuropa.svg");

            for (int i = 0; i < LH.Length; i++)
            {
                LH[i] = -1;// Damit Array nicht mit 0 gefüllt werden soll 
            }


        }

        //private void TimerZumAntworten_Tick(object sender, EventArgs e)
        //{
        //    countdown--;
        //    TimerZumAntwortenAnzeige.Text = countdown.ToString();

        //    if (TimerZumAntwortenAnzeige.Text == "0")
        //    {
        //        TimerZumAntworten.Stop();

        //    }
        //}





        class Land
        {
            //Eigenschaften
            private string Landname;
            private string Hauptstadt;


            public Land(string Landname, string Hauptstadt)
            {
                this.Landname = Landname;
                this.Hauptstadt = Hauptstadt;
            }

            //Get & Set von Landname und Hauptstadt
            public void setLandname(string Landname) { this.Landname = Landname; }
            public string getLandname() { return this.Landname; }

            public void setHauptstadt(string Hauptstadt) { this.Hauptstadt = Hauptstadt; }
            public string getHauptstadt() { return this.Hauptstadt; }

            public void Prüfeland(string Land, string Hauptstadt)
            {
                if (this.Landname == Land)
                {


                    //färbe hellgrün
                    if (this.Hauptstadt == Hauptstadt)
                    {
                        //färbe dunkelgrün
                    }
                }
                else
                {
                    //färbe rot
                    if (this.Hauptstadt == Hauptstadt)
                    {
                        //färbe orange
                    }
                }
            }
        }


        private void Button_prüfe_Land_neu_Click(object sender, EventArgs e)
        {
            if (click1 == true)
            {
                spracherkennung.SetInputToDefaultAudioDevice();
                spracherkennung.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(spracherkennung_SpeechRecognized);
                try
                {
                    //Wörter laden
                    Grammar grammar = new Grammar("grammar.xml", "LuS");
                    spracherkennung.UnloadAllGrammars();
                    spracherkennung.LoadGrammar(grammar);
                    //Erkennung starten
                    spracherkennung.RecognizeAsync(RecognizeMode.Multiple);
                }
                catch (Exception a)
                {
                    MessageBox.Show("Exception aufgetreten: " + a.Message);
                    Application.Exit();
                }
                click1 = false;
            // Text Datei einfügen 
            zeilen = File.ReadAllLines(Application.StartupPath + @"\Länder und Hauptstadt.txt");

            }



            int Land = -1;

            do
            {
                Land = random.Next(0, zeilen.Length);// Anderes Land nehmen wenn das eine Land schon vor kam
                istland = zeilen[Land].Split(';')[0];// 0 Weil der bei 0 anfängt zu zählen und ; weil der dort sich von HP trennt.
                isths = zeilen[Land].Split(';')[1];
                schwierigkeitL= Convert.ToInt32( zeilen[Land].Split(';')[2]);
            } while (LH.Contains(Land) &&  schwierigkeitL > schwierigkeit); // Damit kein Land nochmal vor kommt

            LH[Länder] = Land;// Land wird auf dem Wert gesetzt welches dann vorkommt
            Länder++;// Die Werte werden mehr


            

            for (int i = 24; i < SVG.Length; i++)// Die Zeile durch gehen
            {
                if (SVG[i].Contains(istland)) // Das was in der SVG steht soll in Label1 stehen
                {
                    SVG[i] = SVG[i].Replace("fil1", "fil4");
                }
            }

            File.WriteAllLines(Application.StartupPath + @"\NeueEuropa.svg", SVG); // Soll das in diesem Namen speichern

            webBrowser1.Refresh();// Wb neu Laden wenn was ändert


        }




        //countdown = 10;
        //Button_starte_prüfe_Land.Text = "Neues Land";
        //TimerZumAntworten.Start();



        //bool i = false;//brake Variable
        //if (Button_starte_prüfe_Land.Text == "Neues Land")
        //{
        //    Button_starte_prüfe_Land.Text = "Prüfe";//ein Button für zwei Funktionen
        //    while (i == false)
        //    {
        //        Auswahl = random.Next(1, anzLänder);//ein Land auswählen
        //        if (!gespielte.Contains(Auswahl))
        //        {
        //            //färben gelb
        //            i = true;
        //        }
        //    }
        //}

        //else
        //{
        //    string Land = tb_Land.Text;
        //    string Hauptstadt = tb_Hauptstadt.Text;
        //    //Land[1].Prüfeland(Land,tb_Hauptstadt);//Methode der Klasse Land
        //}

        void spracherkennung_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            MessageBox.Show(e.Result.Text);
            //foreach (RecognizedWordUnit wort in e.Result.Words)
            //{
            //    listBox1.Items.Add(wort.Text);
            //}
        }

        private void Ergebnis_speichern_Click(object sender, EventArgs e)
        {
            Ergebnis_Speichern es = new Ergebnis_Speichern();
            es.Show();
        }

        private void Vorzeitig_beenden_Click(object sender, EventArgs e)
        {
            Vorzeitig_verlassen_bestätigen vb = new Vorzeitig_verlassen_bestätigen();
            vb.Show();
        }
    }
}



