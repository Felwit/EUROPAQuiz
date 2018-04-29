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
        int[] LH = new int[48]; // Die Anzahl der Länder mit Array
        int Länder = 0;
        Random random = new Random();
        //int anzLänder = 0;
        //int Auswahl;
        int countdown = 15;
        //int[] gespielte = new int[1];//max. Größe ergibt sich eigentlich aus Schwierigkeit
        Land[] LänderListe = new Land[1];
        string[] zeilen;
        int anzGespielterLänder = 0;
        int schwierigkeit = EinstellungenQuiz.Schwierigkeitsgrad;
        bool EingabeArt = EinstellungenQuiz.Spracheingabe;
        int schwierigkeitL = 0;
        string istland;
        string isths;
        bool click1 = true;
        bool spiel = true;
        int Punktestand = 0;
        int maxpunkte=0;


        private SpeechRecognitionEngine spracherkennung = new SpeechRecognitionEngine();

        public Europaquiz()
        {
            InitializeComponent();



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
        


        public class Land
        {
            //Eigenschaften
            private string Landname;
            private string Hauptstadt;
            private int Schwierigkeit;
            



            public Land(string Landname, string Hauptstadt, int Schwierigkeit)
            {
                this.Landname = Landname;
                this.Hauptstadt = Hauptstadt;
                this.Schwierigkeit = Schwierigkeit;
            }

            //Get & Set von Landname und Hauptstadt
            public void setLandname(string Landname) { this.Landname = Landname; }
            public string getLandname() { return this.Landname; }

            public void setHauptstadt(string Hauptstadt) { this.Hauptstadt = Hauptstadt; }
            public string getHauptstadt() { return this.Hauptstadt; }

            public void setSchwierigkei(int Schwierigkeit) { this.Schwierigkeit = Schwierigkeit; }
            public int getschwierigkeit() { return this.Schwierigkeit; }

        }

        private void Button_prüfe_Land_neu_Click(object sender, EventArgs e)
        {
            while (spiel == true)
            {
                if (Button_prüfe_Land_neu.Text == "Nächstes Land")
                {
                    zeilen = File.ReadAllLines(Application.StartupPath + @"\Länder und Hauptstadt.txt");
                    int Land = -1;

                    do
                    {
                        Land = random.Next(0, zeilen.Length);// Anderes Land nehmen wenn das eine Land schon vor kam
                        istland = zeilen[Land].Split(';')[0];// 0 Weil der bei 0 anfängt zu zählen und ; weil der dort sich von HP trennt.
                        isths = zeilen[Land].Split(';')[1];
                        schwierigkeitL = Convert.ToInt32(zeilen[Land].Split(';')[2]);


                    } while (LH.Contains(Land) && schwierigkeitL > schwierigkeit); // Damit kein Land nochmal vor kommt

                    LänderListe[0] = new Land(istland, isths, schwierigkeitL);

                    Färbe("fil1", "fil8");
                    LH[Länder] = Land;// Land wird auf dem Wert gesetzt welches dann vorkommt NR des gespielten Landes
                    Länder++;// Die Werte werden mehr // # der gespielten Länder



                    if (click1 == true)
                    {
                        try
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


                        }
                        catch (Exception)
                        {
                            MessageBox.Show("Nur Text eingabe möglich.");
                            EingabeArt = false;
                        }
                        click1 = false;
                    }

                    Button_prüfe_Land_neu.Text = "Prüfe";
                    tb_Land.Show();
                    Timer.Start();
                    break;

                }
                else if (Button_prüfe_Land_neu.Text == "Prüfe")
                {
                        Prüfe();
                }
            }

        }


        public void Färbe(string istfarbe, string farbe)
        {

            for (int i = 24; i < SVG.Length; i++)// Die Zeile durch gehen
            {
                if (SVG[i].Contains(istland)) // Das was in der SVG steht soll in Label1 stehen
                {
                    SVG[i] = SVG[i].Replace(istfarbe, farbe);

                }
            }  // Auswählen = Gelb/Orange fil8
               // Land richtig = Hell Grün fil9
               // Land und Hauptstad richtig = Dunkel Grün fil10
               // Alles falsch = Rot fil11

            File.WriteAllLines(Application.StartupPath + @"\NeueEuropa.svg", SVG); // Soll das in diesem Namen speichern

            webBrowser1.Refresh();// Wb neu Laden wenn was ändert
        }


        void spracherkennung_SpeechRecognized(object sender, SpeechRecognizedEventArgs e)
        {
            //MessageBox.Show(e.Result.Text);
            if (tb_Land.Visible)
            {
                tb_Land.Text = e.Result.Text;
                Prüfe();
            }
            else if (tb_Hauptstadt.Visible)
            {
                //MessageBox.Show(e.Result.Text);
                tb_Hauptstadt.Text = e.Result.Text;
                Prüfe();
            }
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
            PunktE.anzGespLändder = anzGespielterLänder;
            PunktE.maxpunkte = maxpunkte;
            PunktE.punkte = Punktestand;
            Vorzeitig_verlassen_bestätigen vb = new Vorzeitig_verlassen_bestätigen();
            vb.Show();
        }



        private void tb_Land_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Prüfe();
            }
        }

        private void tb_Hauptstadt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Prüfe();
            }
        }

        public void Prüfe()
        {
            Timer.Stop();
            countdown = 15;
            if (tb_Land.Visible == true)
            {
                string eingLand = tb_Land.Text;

                if (eingLand.ToUpper() == LänderListe[0].getLandname().ToUpper() || eingLand == LänderListe[0].getLandname())
                {
                    Färbe("fil8", "fil9");
                    // Färben mit methode-> Hell Grün (Wenn Land richtig Hauptstad nach fragen)
                    tb_Land.Hide();
                    tb_Hauptstadt.Show();
                    Timer.Start();
                    Punktestand = Punktestand + LänderListe[0].getschwierigkeit();
                    PunkteZahlAnzeige.Text = Punktestand.ToString();
                    maxpunkte = maxpunkte + LänderListe[0].getschwierigkeit();
                }

                else
                {
                    Färbe("fil8", "fil11");
                    Button_prüfe_Land_neu.Text = "Nächstes Land";
                    tb_Land.Hide();
                    anzGespielterLänder++;
                    zeigeLösng();
                    maxpunkte = maxpunkte + (LänderListe[0].getschwierigkeit() * 2);
                }
            }
            else
            {
                string eingStadt = tb_Hauptstadt.Text;

                if (eingStadt.ToUpper() == LänderListe[0].getHauptstadt().ToUpper() || eingStadt == LänderListe[0].getHauptstadt())
                {
                    Färbe("fil9", "fil10");
                    Button_prüfe_Land_neu.Text = "Nächstes Land";
                    tb_Hauptstadt.Hide();
                    anzGespielterLänder++;
                    Punktestand= Punktestand + LänderListe[0].getschwierigkeit();
                    PunkteZahlAnzeige.Text = Punktestand.ToString();
                    maxpunkte = maxpunkte + LänderListe[0].getschwierigkeit();
                    zeigeLösng();
                    
                }
                else
                {
                    Button_prüfe_Land_neu.Text = "Nächstes Land";
                    tb_Hauptstadt.Hide();
                    anzGespielterLänder++;
                    maxpunkte = maxpunkte + LänderListe[0].getschwierigkeit();
                    zeigeLösng();
                }
            }
            
            if (anzGespielterLänder == 20)
            {
                Button_prüfe_Land_neu.Hide();
                Vorzeitig_beenden.Hide();
                Ergebnis_speichern.Show();
                Ohne_Speichern.Show();
                spiel = false;
                PunktE.anzGespLändder = anzGespielterLänder;
                PunktE.maxpunkte = maxpunkte;
                PunktE.punkte = Punktestand;


            }
        }

        private void zeigeLösng()
        {
            LösungLand.Text = LänderListe[0].getLandname();
            LösungHS.Text = LänderListe[0].getHauptstadt();
            LetzteEingabeLand.Text = tb_Land.Text;
            LetzteEIngabeHS.Text = tb_Land.Text;
        }

        private void Ohne_Speichern_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            countdown--;
            CountdownZaehler.Text = countdown.ToString();

            if (CountdownZaehler.Text == "0")
            {
                Prüfe();
            }
        }
    }
    public class PunktE
    {
        public static int maxpunkte { get; set; }
        public static int punkte { get; set; }
        public static int anzGespLändder { get; set; }

        public PunktE(int maxpunkte, int punkte, int gespielteländer)
        {
            PunktE.maxpunkte = maxpunkte;
            PunktE.punkte = punkte;
            PunktE.anzGespLändder = gespielteländer;
        }

    }
}




