using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Europaquiz_Eingabe_und_Eingabeprügfung
{
    class Land
    {
        //Eigenschaften
        public string Landname;
        public string Hauptstadt;


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

        Prüfeland(string Land, string Hauptstadt)
        {
            if(this.Landname==Land)
            {
                //färbe hellgrün
                if(this.Hauptstadt==Hauptstadt)
                {
                    //färbe dunkelgrün
                }
            }
            else
            {
                //färbe rot
            }
        }


    }
    public partial class Europaquiz : Form
    {
        Random random = new Random();
        int anzLänder = 0;
        int Auswahl;
        int[] gewälte = new int[1];//max. Größe ergibt sich eigentlich aus Schwierigkeit
        public Europaquiz()
        {
            InitializeComponent();
        }

        private void Europaquiz_Load(object sender, EventArgs e)
        {

        }

        private void Button_prüfe_Land_neu_Click(object sender, EventArgs e)
        {
            bool i = false;//brake Variable
            if (Button_prüfe_Land_neu.Text == "Neues Land")
            {
                Button_prüfe_Land_neu.Text = "Prüfe";//ein Button für zwei Funktionen
                Auswahl = random.Next(1, anzLänder);//ein land auswählen
                while (i == false)
                {
                    if (!gewälte.Contains(Auswahl))
                    {
                        //färben gelb
                        i = true;
                    }
                }
            }

            else
            {
                string Land = tb_Land.Text;
                string HStadt = tb_Hauptstadt.Text;
                Prüfeland(Land,tb_Hauptstadt);//Methode der Klasse Land
            }







            }

        }
    }
}
