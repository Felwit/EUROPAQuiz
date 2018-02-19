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
                if (this.Hauptstadt == Hauptstadt)
                {
                    //färbe orange
                }
            }
        }


    }
    public partial class Europaquiz : Form
    {
        Random random = new Random();
        int anzLänder = 0;
        int Auswahl;
        int[] gespielte = new int[1];//max. Größe ergibt sich eigentlich aus Schwierigkeit
        public Europaquiz()
        {
            InitializeComponent();
        }

        private void Europaquiz_Load(object sender, EventArgs e)
        {
           
            Menü menü = new Menü(); //Deine 2. Form
            menü.Show();
            Hide();

        }

        private void Button_prüfe_Land_neu_Click(object sender, EventArgs e)
        {
            bool i = false;//brake Variable
            if (Button_prüfe_Land_neu.Text == "Neues Land")
            {
                Button_prüfe_Land_neu.Text = "Prüfe";//ein Button für zwei Funktionen
                while (i == false)
                {
                    Auswahl = random.Next(1, anzLänder);//ein Land auswählen
                    if (!gespielte.Contains(Auswahl))
                    {
                        //färben gelb
                        i = true;
                    }
                }
            }

            else
            {
                string Land = tb_Land.Text;
                string Hauptstadt = tb_Hauptstadt.Text;
                //Land[1].Prüfeland(Land,tb_Hauptstadt);//Methode der Klasse Land
            }







            }

        }
    }

