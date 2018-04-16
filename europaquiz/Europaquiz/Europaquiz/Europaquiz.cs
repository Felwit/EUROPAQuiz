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

namespace Europaquiz
{

    public partial class Europaquiz : Form
    {
        /// <summary>
        /// Instance reference for the svgDocument used and updated throughout the manipulation of the image.
        /// </summary>
        private Svg.SvgDocument svgDocument;


        Random random = new Random();
        int anzLänder = 0;
        int Auswahl;
        int countdown = 0;
        int[] gespielte = new int[1];//max. Größe ergibt sich eigentlich aus Schwierigkeit
        bool click1 = true;


        public Europaquiz()
        {
            InitializeComponent();
            // LetzteLösung.BackColor = Color.FromArgb(1,0,50,50);
        }

        private SpeechRecognitionEngine spracherkennung = new SpeechRecognitionEngine();

        private void Europaquiz_Load(object sender, EventArgs e)
        {
            this.Bounds = Screen.PrimaryScreen.Bounds; // Formulargröße auf Größe des Bildschirms festlegen

            // Textdatei öffnen, Umlaute richtig lesen
            System.IO.StreamReader DateiLesen = new System.IO.StreamReader(@"D:\Europa09.04\EUROPAQuiz\europaquiz\Europaquiz\Länder und Hauptsadt.txt", Encoding.Default);
            // Solange Dateiende nicht erreicht
            while (!DateiLesen.EndOfStream)
            {
                //eine Zeile aus der Textdatei lese
                string zeile = DateiLesen.ReadLine();
                string[] spalten = zeile.Split(';');
            }

            svgDocument = SvgDocument.Open(@"D:\Europa09.04\EUROPAQuiz\europaquiz\Europaquiz\Europa.svg");


            SVGParser.MaximumSize = new Size(pictureBox1.Width, pictureBox1.Height);

            pictureBox1.Image = SVGParser.GetBitmapFromSVG(@"D:\Europa09.04\EUROPAQuiz\europaquiz\Europaquiz\Europa.svg");
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


        /// <summary>
        /// Checks if there is an image selected.
        /// </summary>
        /// <returns>Returns the boolean results whether an image is selected.</returns>
        private bool ValidateFormControls()
        {
            if (svgDocument == null)
            {
                MessageBox.Show("Please select a SVG image to continue");
                return false;
            }
            return true;
        }

        /// <summary>
        ///  Recursive fill function to change the color of a selected node and all of its children.
        /// </summary>
        /// <param name="element">The current element been resolved.</param>
        /// <param name="sourceColor">The source color to search for.</param>
        /// <param name="replaceColor">The color to be replaced the source color with.</param>
        private void ChangeFill(SvgElement element, Color sourceColor, Color replaceColor)
        {
            if (element is SvgPath)
            {
                if (((element as SvgPath).Fill as SvgColourServer).Colour.ToArgb() == sourceColor.ToArgb())
                {
                    (element as SvgPath).Fill = new SvgColourServer(replaceColor);
                }
            }

            if (element.Children.Count > 0)
            {
                foreach (var item in element.Children)
                {
                    ChangeFill(item, sourceColor, replaceColor);
                }
            }

        }
        int i = -1;
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (!ValidateFormControls())
                return;
            i++;
            //for (int i=20; i<svgDocument.Children[1].Children.Count;i++)
            {
                ChangeFill(svgDocument.Children[1].Children[i], Color.White, Color.Red);// bestimmtes Land rot färben
            }
            pictureBox1.Image = svgDocument.Draw();
        }

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
            }

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

        }
    }


}

