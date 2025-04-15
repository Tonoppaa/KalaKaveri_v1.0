using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalaKaveri_v1
{
    public partial class admin_etusivu : Form
    {
        string userID;
        MySqlConnection yhteys;
        public admin_etusivu(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            userID = uID;
            yhteys = yhteysOlio;
            LataaNimi();
        }

        private void LataaNimi() // Ladataan käyttäjän nimi tekstikenttään ja näytetään käyttäjän toiminnat infotaulussa
        {
            try
            {
                if (yhteys.State == ConnectionState.Closed)
                {
                    yhteys.Open();
                }
                string haeNimi = "SELECT etunimi, sukunimi FROM kayttaja WHERE kayttajaID = @kayttajaID";
                MySqlCommand komento = new MySqlCommand(haeNimi, yhteys);
                komento.Parameters.AddWithValue("@kayttajaID", userID);
                MySqlDataReader lukija = komento.ExecuteReader();
                while (lukija.Read())
                {
                    string etunimi = lukija.GetString("etunimi");
                    string sukunimi = lukija.GetString("sukunimi");
                    string kokonimi = etunimi + " " + sukunimi;
                    nimitextBox.Text = kokonimi;
                }
                lukija.Close();
                LataaViestitTiedostosta(); // Ladataan käyttäjän toiminta inforichtextBoxiin
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe nimen lataamisessa: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void LataaViestitTiedostosta() // Metodi, joka lataa "{userID}-toiminnot.txt"-tiedostosta viestit
        {
            try
            {
                string tiedostoPolku = $"{userID}-toiminnot.txt";
                if (File.Exists(tiedostoPolku))  // Tarkistetaan, että tiedosto on olemassa
                {
                    var rivit = File.ReadAllLines(tiedostoPolku);  // Luetaan tiedoston rivit
                    foreach (var viesti in rivit.Reverse()) // Käydään rivit läpi käänteisessä järjestyksessä
                    {
                        inforichTextBox.AppendText(viesti + Environment.NewLine);  // Lisää viesti richTextBoxiin
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message);
            }
        }

        private void suljeButton_Click(object sender, EventArgs e) // Sulje ohjelma
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Vahvista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kirjauduUlosNappi_Click(object sender, EventArgs e) // Kirjaudu ulos
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti kirjautua ulos?", "Vahvista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                kirjaudu kirjauduUlos = new kirjaudu();
                kirjauduUlos.Show();
                this.Close();
            }
        }

        private void kalapankkiNappi_Click(object sender, EventArgs e) // Avaa kalapankki-form
        {
            admin_kalapankki kalapankki = new admin_kalapankki(yhteys, userID);
            kalapankki.Show();
            this.Close();
        }

        private void kalastuspaikatNappi_Click(object sender, EventArgs e) // Avaa kalastuspaikat-form
        {
            admin_kalastuspaikat adminkalastuspaikat = new admin_kalastuspaikat(yhteys, userID);
            adminkalastuspaikat.Show();
            this.Close();
        }

        private void käyttäjähallintaNappi_Click(object sender, EventArgs e) // Avaa käyttäjähallinta-form
        {
            admin_käyttäjähallinta käyttäjähallinta = new admin_käyttäjähallinta(yhteys, userID);
            käyttäjähallinta.Show();
            this.Close();
        }
    }
}