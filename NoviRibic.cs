using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MilanovicMatej
{
    public partial class NoviRibic : Form
    {
        public NoviRibic()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var konekcija = BazaPodataka.konekcija();
            konekcija.Open();
            string zadatak = "INSERT INTO Ribic  VALUES('" + this.textBox1.Text + "' ,'" + this.textBox2.Text + "' ,  '" + this.textBox3.Text + "' , '" + this.dateTimePicker1.Text + "','" + this.textBox5.Text + "',"+0+");";
            SqlCommand cmd = new SqlCommand(zadatak, konekcija);

            cmd.ExecuteNonQuery();
            

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox5.Text = "";

            konekcija.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Izbornik otvori = new Izbornik();
            otvori.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
