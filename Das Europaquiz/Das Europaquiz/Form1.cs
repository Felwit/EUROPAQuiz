using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Das_Europaquiz
{
    public partial class Form1 : Form
    {
        string[] SVG = File.ReadAllLines(Application.StartupPath + @"\Europa.svg");
        int[] LH = new int[47]; // Die Anzahl der Länder mit Array
        int Länder = 0;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            File.WriteAllLines(Application.StartupPath + @"\NeueEuropa.svg", SVG);// Soll darauf zugreifen
            webBrowser1.Navigate(Application.StartupPath + @"\NeueEuropa.svg");

            for (int i = 0; i < LH.Length; i++)
            {
                LH[i] = -1;// Damit Array nicht mit 0 gefüllt werden soll 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Text Datei einfügen 
            string[] zeilen = File.ReadAllLines(Application.StartupPath + @"\Länder und Hauptsadt.txt");

            int Land = -1;

            do
            {
                Land = rnd.Next(0, zeilen.Length);// Anderes Land nehmen wenn das eine Land schon vor kam
            } while (LH.Contains(Land)); // Damit kein Land nochmal vor kommt
            
                LH[Länder] = Land;// Land wird auf dem Wert gesetzt welches dann vorkommt
            Länder++;// Die werrten werden mehr


            label1.Text = zeilen[Land].Split(';')[0];// 0 Weil der bei 0 anfängt zu zählen und ; weil der dort sich von HP trennt.
            label2.Text = zeilen[Land].Split(';')[1];

            for (int i = 24; i < SVG.Length; i++)// Die Zeile durch gehen
            {
                if (SVG[i].Contains(label1.Text)) // Das was in der SVG steht soll in Label1 stehen
                {
                    SVG[i] = SVG[i].Replace("fil1", "fil4");
                }
            }

            File.WriteAllLines(Application.StartupPath + @"\NeueEuropa.svg", SVG); // Soll das in diesem Namen speichern

            webBrowser1.Refresh();// Wb neu Laden wenn was ändert
            if (Länder == 45)
            {
                MessageBox.Show("Beendet drücke auf das X");
                button1.Show();
            }
        }
    }
}