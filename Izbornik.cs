using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MilanovicMatej
{
    public partial class Izbornik : Form
    {
        public Izbornik()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NoviRibic novi = new NoviRibic();
            novi.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            UnosUlova ulov = new UnosUlova();
            ulov.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Ljestvica_poredak otvori = new Ljestvica_poredak();
            otvori.Show();
        }
    }
}
