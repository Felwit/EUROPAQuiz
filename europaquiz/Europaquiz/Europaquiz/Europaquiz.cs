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
    public partial class Europaquiz : Form
    {
        public Europaquiz()
        {
            InitializeComponent();
        }
    }
}
