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
    public partial class kayttaja_etusivu : Form
    {
        string userID;
        MySqlConnection yhteys;
        public kayttaja_etusivu(MySqlConnection yhteysOlio, string uID) // Käytetään MySQL-yhteyttä, joka on muodostettu kirjaudu-sivulla
        {
            InitializeComponent();
            userID = uID;
            yhteys = yhteysOlio;
            LataaNimi(); // Ladataan käyttäjän nimi tekstikenttään
        }

        private void LataaNimi() // Ladataan käyttäjän nimi tekstikenttään ja ladataan tiedot tiedostosta infolaatikkoon
        {
            try
            {
                if (yhteys.State == ConnectionState.Closed) // Varmistetaan, että tietokantayhteys on auki
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

        private void LataaViestitTiedostosta() // Metodi, joka lataa "{userID}-toiminnot.txt"-tiedostosta viestit inforichTextBoxiin
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
                MessageBox.Show("Tapahtui virhe viestin lataamisessa: " + ex.Message);
            }
        }

        private void omatsaaliitNappi_Click(object sender, EventArgs e) // Avaa omat saaliit-form
        {
            kayttaja_omatsaaliit omatsaaliit = new kayttaja_omatsaaliit(yhteys, userID);
            omatsaaliit.Show();
            this.Close();
        }

        private void kalastuspaikatNappi_Click(object sender, EventArgs e) // Avaa kalastuspaikat-form
        {
            kayttaja_kalastuspaikat kalastuspaikat = new kayttaja_kalastuspaikat(yhteys, userID);
            kalastuspaikat.Show();
            this.Close();
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje ohjelma
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Vahvista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kalapankkiNappi_Click(object sender, EventArgs e) // Avaa kalapankki-form
        {
            kayttaja_kalapankki kalapankki = new kayttaja_kalapankki(yhteys, userID);
            kalapankki.Show();
            this.Close();
        }

        private void kirjauduUlosNappi_Click(object sender, EventArgs e) // Kirjaa käyttäjä ulos ja näytä kirjautumissivu
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti kirjautua ulos?", "Vahvista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                kirjaudu kirjauduSisään = new kirjaudu();
                kirjauduSisään.Show();
                this.Close();
            }
        }
    }
}
