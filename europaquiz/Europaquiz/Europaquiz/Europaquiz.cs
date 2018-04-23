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
        //int countdown = 0;
        //int[] gespielte = new int[1];//max. Größe ergibt sich eigentlich aus Schwierigkeit
        Land[] LänderListe = new Land[2];
        string[] zeilen;

        int schwierigkeit = EinstellungenQuiz.Schwierigkeitsgrad;
        bool EingabeArt = EinstellungenQuiz.Spracheingabe;
        int schwierigkeitL = 0;
        string istland;
        string isths;
        bool click1 = true;


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

        //private void TimerZumAntworten_Tick(object sender, EventArgs e)
        //{
        //    countdown--;
        //    TimerZumAntwortenAnzeige.Text = countdown.ToString();

        //    if (TimerZumAntwortenAnzeige.Text == "0")
        //    {
        //        TimerZumAntworten.Stop();

        //    }
        //}





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

                }

                tb_Land.Show();
                Button_prüfe_Land_neu.Hide();

            }
            else if (Button_prüfe_Land_neu.Text == "Prüfe")
            {
                if (tb_Land.Visible == true)
                {
                    string eingLand = tb_Land.Text;

                    if (eingLand == LänderListe[0].getLandname())
                    {
                        Färbe("fil8", "fil9");
                        // Färben mit methode-> Hell Grün (Wenn Land richtig Hauptstad nach fragen)
                        tb_Land.Hide();
                        tb_Hauptstadt.Show();

                    }

                    else
                    {
                        Färbe("fil8", "fil11");
                        Button_prüfe_Land_neu.Text = "Nächstes Land";
                        tb_Land.Hide();

                    }
                }
                else
                {
                    string eingStadt = tb_Hauptstadt.Text;

                    if (eingStadt == LänderListe[0].getHauptstadt())
                    {
                        Färbe("fil9", "fil10");
                        Button_prüfe_Land_neu.Text = "Nächstes Land";
                        tb_Hauptstadt.Hide();

                    }
                    else
                    {
                        Button_prüfe_Land_neu.Text = "Nächstes Land";
                        tb_Hauptstadt.Hide();
                    }

                }
                string Switchcase = LänderListe[Länder].getLandname();
                switch (Switchcase)// Für die Zoom Funktion
                {
                    case "Andorra":
                        string[] Land_ID = File.ReadAllLines(Application.StartupPath + @"\Kleine Länder\Andorra");
                        break;
                    case "Malta":
                        Land_ID = File.ReadAllLines(Application.StartupPath + @"\Kleine Länder\Malta");
                        break;
                    case "San Marino":
                        Land_ID = File.ReadAllLines(Application.StartupPath + @"\Kleine Länder\San Marino");
                        break;
                    case "Vatikanstadt":
                        Land_ID = File.ReadAllLines(Application.StartupPath + @"\Kleine Länder\Vatikanstadt");
                        break;
                    case "Monaco":
                       Land_ID = File.ReadAllLines(Application.StartupPath + @"\Kleine Länder\Monaco");
                        break;
                    default:
                        break;
                }
            }

        }
    }




    //countdown = 10;
    //Button_starte_prüfe_Land.Text = "Neues Land";
    //TimerZumAntworten.Start();



    //bool i = false;//brake Variable

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

    private void tb_Land_TextChanged(object sender, EventArgs e)
    {
        if (this.Text != "")
        {
            Button_prüfe_Land_neu.Text = "Prüfe";
            Button_prüfe_Land_neu.Show();
        }
    }



    private void tb_Land_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string eingLand = tb_Land.Text;

            if (eingLand == LänderListe[0].getLandname())
            {
                Färbe("fil8", "fil9");
                // Färben mit methode-> Hell Grün (Wenn Land richtig Hauptstad nach fragen)
                tb_Land.Hide();
                tb_Hauptstadt.Show();

            }

            else
            {
                Färbe("fil8", "fil11");
                Button_prüfe_Land_neu.Text = "Nächstes Land";
                tb_Land.Hide();

            }
        }
        else { }
    }

    private void tb_Hauptstadt_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.KeyCode == Keys.Enter)
        {
            string eingStadt = tb_Hauptstadt.Text;

            if (eingStadt == LänderListe[0].getHauptstadt())
            {
                Färbe("fil9", "fil10");
                Button_prüfe_Land_neu.Text = "Nächstes Land";
                tb_Hauptstadt.Hide();

            }
            else
            {
                Button_prüfe_Land_neu.Text = "Nächstes Land";
                tb_Hauptstadt.Hide();
            }

        }
        else
        { }
    }
}
public class PunktE
{


    public static int maxpunkte { get; set; }
    public static int punkte { get; set; }

    public PunktE(int maxpunkte, int punkte)
    {
        PunktE.maxpunkte = maxpunkte;
        PunktE.punkte = punkte;
    }

}

}
    


