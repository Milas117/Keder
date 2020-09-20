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
    public partial class UnosUlova : Form
    {
        public UnosUlova()
        {
            InitializeComponent();
            prijenos();
        }

        private void prijenos()
        {

            var konekcija = BazaPodataka.konekcija();
            konekcija.Open();
            string izvadi = "select * from  Ribic;";
            SqlCommand izvadi_cmd = new SqlCommand(izvadi, konekcija);
            SqlDataReader citac;
            citac = izvadi_cmd.ExecuteReader();

            

            while (citac.Read())
            {

                string broj_dozvole = citac.GetString(0);

                comboBox1.Items.Add(broj_dozvole);
            }
            konekcija.Close();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            var konekcija = BazaPodataka.konekcija();
            konekcija.Open();
            string zadatak = "UPDATE Ribic set Ukupna_kilaza= Ukupna_kilaza+"+numericUpDown1.Value+" where sifra_dozvole='"+comboBox1.Text+"';";
            SqlCommand cmd = new SqlCommand(zadatak, konekcija);

            cmd.ExecuteNonQuery();
            comboBox1.Text = "";
            konekcija.Close();
            numericUpDown1.Value = 0;

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Izbornik otvori = new Izbornik();
            otvori.Show();
        }
    }
}
