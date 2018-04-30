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

        int[] LH = new int[48]; // Die Anzahl der Länder mit Array
        int Länder = 0;
        int countdown = 15;
        string[] zeilen;
        int anzGespielterLänder = 0;
        int schwierigkeit;
        bool EingabeArt;
        int schwierigkeitL = 0;
        string istland;
        string isths;
        bool click1 = true;

        int Punktestand = 0;
        int maxpunkte = 0;
        string Land_ID;
        bool zoom = true;


        Random random = new Random();
        Land[] LänderListe = new Land[1];
        private SpeechRecognitionEngine spracherkennung = new SpeechRecognitionEngine();
        string[] SVG = File.ReadAllLines(Application.StartupPath + @"\Europa.svg");// SVG wird in Array eingelesen

        public Europaquiz()
        {
            InitializeComponent();
            CountdownZaehler.Hide();    //Der Countdown wird zu Beginn ausgeblendet
        }

        private void Europaquiz_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds; // Formulargröße auf Größe des Bildschirms festlegen

            File.WriteAllLines(Application.StartupPath + @"\NeueEuropa.svg", SVG);// Soll darauf zugreifen
            webBrowser1.Navigate(Application.StartupPath + @"\NeueEuropa.svg");//im Webbrowser wird Svg angezeigt
            webBrowser1.Document.BackColor = tableLayoutPanel3.BackColor;//Hintergrundfarbe wird der der Tabelle angepast

            for (int i = 0; i < LH.Length; i++)
            {
                LH[i] = -1;// Damit Array nicht mit 0 gefüllt werden soll 
            }

            string[] einstellungEN = File.ReadAllLines(Application.StartupPath + @"\Einstellungen.txt");//einstellungen aus Textdatei werden ausgewertet
            if (einstellungEN[0] == "true")
            {
                EingabeArt = true;//Eingabe über Mikrofon aktiviert
            }
            else
            {
                EingabeArt = false;//Eingabe über Mikrofon deaktiviert
            }

            switch (einstellungEN[1])//Schwierigkeit wird ausgelesen
            {
                case "1":
                    schwierigkeit = 1;
                    break;
                case "2":
                    schwierigkeit = 2;
                    break;
                case "3":
                    schwierigkeit = 3;
                    break;
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

            Button_prüfe_Land_neu.Hide();//verstecke dich während der Eingabe
            zeilen = File.ReadAllLines(Application.StartupPath + @"\Länder und Hauptstadt.txt");//einlesen der txt mit Ländernamen und Hauptstädten
            int Land = -1;

            do
            {
                Land = random.Next(0, zeilen.Length);// 
                istland = zeilen[Land].Split(';')[0];// 0 Weil der bei 0 anfängt zu zählen und ; weil der dort sich von HP trennt.
                isths = zeilen[Land].Split(';')[1];
                schwierigkeitL = Convert.ToInt32(zeilen[Land].Split(';')[2]);

            } while (LH.Contains(Land) || schwierigkeitL > schwierigkeit); // Anderes Land nehmen, wenn das eine Land schon vor kam und Überprüfung ob Schwierigkeit <= Einstellung
            LänderListe[0] = new Land(istland, isths, schwierigkeitL);//Schreibe in Liste von Ländern
            maxpunkte = maxpunkte + (LänderListe[0].getschwierigkeit() * 2);//erhöhe maxpunkt um 2-mal Schwierigkeit je ein mal für Land und HS
            Färbe("fil1", "fil8");
            LH[Länder] = Land;// Land wird auf dem Wert gesetzt, welches dann vorkommt NR des gespielten Landes
            Länder++;// Die Werte werden mehr // # der gespielten Länder

            string Switchcase = LänderListe[0].getLandname();
            switch (Switchcase)// Für die Zoom Funktion 
            {
                case "Andorra":
                    Land_ID = Application.StartupPath + @"\Kleine Länder\Andorra.png";
                    break;
                case "Malta":
                    Land_ID = Application.StartupPath + @"\Kleine Länder\Malta.png";
                    break;
                case "San Marino":
                    Land_ID = Application.StartupPath + @"\Kleine Länder\San Marino.png";
                    break;
                case "Vatikanstadt":
                    Land_ID = Application.StartupPath + @"\Kleine Länder\Vatikanstadt.png";
                    break;
                case "Monaco":
                    Land_ID = Application.StartupPath + @"\Kleine Länder\Monaco.png";
                    break;
                case "Liechtenstein":
                    Land_ID = Application.StartupPath + @"\Kleine Länder\Liechtenstein.png";
                    break;
                default:
                    zoom = false;
                    break;
            }
            if (zoom == true)//entsprechend wird ein Bild eingeladen
            {
                Zoom.Load(Land_ID);
                Zoom.Show();
            }
            else//oder auch nicht
            {
                zoom = true;
                Zoom.Hide();
            }

            if (Länder == 1)//beim ersten Land wird ...
            {
                try//.. versucht die Spracherkennung zu starten und die Grammar zu laden
                {
                    spracherkennung.SetInputToDefaultAudioDevice();
                    spracherkennung.SpeechRecognized += new EventHandler<SpeechRecognizedEventArgs>(spracherkennung_SpeechRecognized);

                    //Wörter laden
                    Grammar grammar = new Grammar("grammar.xml", "LuS");
                    spracherkennung.UnloadAllGrammars();
                    spracherkennung.LoadGrammar(grammar);
                    //Erkennung starten
                    spracherkennung.RecognizeAsync(RecognizeMode.Multiple);

                }
                catch (Exception) //glingt das nicht wird...
                {
                    if (EingabeArt)
                    {
                        MessageBox.Show("Nur Text eingabe möglich."); //... eine Information Angezeigt
                        EingabeArt = false;// und Standerteingabe methode auf "Text" gesetzt
                    }
                }

            }
            tb_Land.Show();//frage Land ab
            tb_Land.Focus();
            Timer.Start();//Starte Timer
            CountdownZaehler.Show(); //zeige Countdown Zähler

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

            if (tb_Land.Visible)
            {
                tb_Land.Text = e.Result.Text;
                Prüfe();
            }
            else if (tb_Hauptstadt.Visible)
            {

                tb_Hauptstadt.Text = e.Result.Text;
                Prüfe();
            }
        }

        private void Ergebnis_speichern_Click(object sender, EventArgs e)//Offne Fenster zum Speichern
        {
            Ergebnis_Speichern es = new Ergebnis_Speichern();
            es.Show();
        }

        private void Vorzeitig_beenden_Click(object sender, EventArgs e)//offne Fenster zum Vorzeitigen verlassen
        {
            PunktE.anzGespLändder = anzGespielterLänder;// und übergebe #gespielter Länder sowie Punktestand und Bis hierher zuerreichende maxpunkte
            PunktE.maxpunkte = maxpunkte;
            PunktE.punkte = Punktestand;
            Vorzeitig_verlassen_bestätigen vb = new Vorzeitig_verlassen_bestätigen();
            vb.Show();
        }




        private void tb_Land_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Wenn in TB Land Enter gedrückt
                Prüfe();
        }

        private void tb_Hauptstadt_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)//Wenn in TB Land Enter gedrückt
                Prüfe();
        }

        public void Prüfe()
        {
            Timer.Stop();           //Countdown
            CountdownZaehler.Hide();
            countdown = 15;
            CountdownZaehler.Text = countdown.ToString();
            if (tb_Land.Visible == true)
            {
                //Landeingabe RICHTIG:
                string eingLand = tb_Land.Text;
                if (eingLand.ToUpper() == LänderListe[0].getLandname().ToUpper() || eingLand == LänderListe[0].getLandname())
                {
                    Färbe("fil8", "fil9");
                    // Färben mit methode-> Hell Grün (Wenn Land richtig Hauptstad nach fragen)
                    tb_Land.Hide();
                    tb_Hauptstadt.Show();       //tb = Textbox. Textbox Land und Hauptstadt werden ein-/ausgeblendet.
                    tb_Hauptstadt.Focus();
                    Timer.Start();              //Timer startet und Punkte werden vergeben/angezeigt
                    CountdownZaehler.Show();
                    Punktestand = Punktestand + LänderListe[0].getschwierigkeit();
                    PunkteZahlAnzeige.Text = Punktestand.ToString();

                }
                else //Landeingabe FALSCH:
                {
                    Färbe("fil8", "fil11");     //Land wird rot gefärbt
                    Button_prüfe_Land_neu.Text = "Nächstes Land";
                    tb_Land.Hide();
                    anzGespielterLänder++;
                    zeigeLösng(false, false);   //Lösungen werden angezeigt
                    Button_prüfe_Land_neu.Show();
                    Button_prüfe_Land_neu.Focus();
                }
            }
            else  //Hauptstadteingabe RICHTIG:
            {
                string eingStadt = tb_Hauptstadt.Text;
                if (eingStadt.ToUpper() == LänderListe[0].getHauptstadt().ToUpper() || eingStadt == LänderListe[0].getHauptstadt())
                {
                    Färbe("fil9", "fil10");     //Land wird dunkel grün gefärbt
                    Button_prüfe_Land_neu.Text = "Nächstes Land";
                    tb_Hauptstadt.Hide();
                    anzGespielterLänder++;      //#gespielter Länder wird erhöht und Punkte vergeben/angezeigt
                    Punktestand = Punktestand + LänderListe[0].getschwierigkeit();
                    PunkteZahlAnzeige.Text = Punktestand.ToString();
                    zeigeLösng(true, true);         //Lösungen und Buttonfür Nächstes Land werden angezeigt
                    Button_prüfe_Land_neu.Show();  
                    Button_prüfe_Land_neu.Focus();
                }
                else  //Hauptstadteingabe FALSCH
                {
                    Button_prüfe_Land_neu.Text = "Nächstes Land";
                    tb_Hauptstadt.Hide();
                    anzGespielterLänder++;
                    zeigeLösng(true, false);     //Es wird farblich signalisiert, dass Land richtig & Hauptstadt falsch ist
                    Button_prüfe_Land_neu.Show();
                    Button_prüfe_Land_neu.Focus();
                }
            }

            if (anzGespielterLänder == 20)      //Maximale Anzahl an gespielten Ländern bis das Spiel vorbei ist
            {
                Button_prüfe_Land_neu.Hide();//Zwei Buttons für das Spiel werden Versteckt
                Vorzeitig_beenden.Hide();
                Ergebnis_speichern.Show();//dafür 2 Zum Speicher/nicht Speichern angeziegt
                Ohne_Speichern.Show();

                PunktE.anzGespLändder = anzGespielterLänder;// Übergebe #gespielter Länder sowie Punktestand und Bis hierher zuerreichende maxpunkte
                PunktE.maxpunkte = maxpunkte;
                PunktE.punkte = Punktestand;
            }
        }

        private void zeigeLösng(bool land, bool hs)     //Lösungen werden farblich makiert
        {
            LösungLand.Text = LänderListe[0].getLandname();
            LösungHS.Text = LänderListe[0].getHauptstadt();

            //Land
            LetzteEingabeLand.Text = tb_Land.Text;
            if (land)   //RICHTIGE Eingabe = Grün makiert
                LetzteEingabeLand.BackColor = Color.DarkSeaGreen;
            else        //FALSCHE Eingabe = rot makiert
                LetzteEingabeLand.BackColor = Color.IndianRed;

            //Haupstadt
            LetzteEIngabeHS.Text = tb_Hauptstadt.Text;
            if (hs)     //RICHITGE Eingabe = Grün makiert
                LetzteEIngabeHS.BackColor = Color.DarkSeaGreen;
            else        //FALSCHE Eingabe = Grün makiert
                LetzteEIngabeHS.BackColor = Color.IndianRed;

            tb_Hauptstadt.Clear();
            tb_Land.Clear();        //Letzte Eingabe wird gelöscht
        }

        //Countdown, welcher runterzählt
        private void Timer_Tick(object sender, EventArgs e)
        {
            countdown--;
            CountdownZaehler.Text = countdown.ToString();

            if (CountdownZaehler.Text == "0")
                Prüfe();
        }

        private void Ohne_Speichern_Click_1(object sender, EventArgs e)
        {
            Application.Restart();
        }
    }
    public class PunktE //Klasse zum über geben von Werten in Urkunden Fenster
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