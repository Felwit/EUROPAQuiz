﻿using System;
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
    public partial class Verlassen_bestätigen : Form
    {
        public Verlassen_bestätigen()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Kontrollfrage_Click(object sender, EventArgs e)
        {

        }
    }
}
