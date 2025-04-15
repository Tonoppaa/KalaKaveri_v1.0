using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalaKaveri_v1
{
    public partial class kayttaja_omatsaaliit : Form
    {
        string userID;
        MySqlConnection yhteys;
        public kayttaja_omatsaaliit(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            userID = uID;
            yhteys = yhteysOlio;
            LataaKuva(); // Lataa kuvat URL:sta pictureBoxeihin
        }

        private void LataaKuva() // Lataa kuvat asynkronisesti pictureBoxeihin
        {
            try
            {
                kirjaapictureBox.LoadAsync("https://i.postimg.cc/RFsgTgtf/lis-kuva-kuva.png");
                tarkastelepictureBox.LoadAsync("https://i.postimg.cc/tJ8DK724/tarkastele-kuva.png");
                poistapictureBox.LoadAsync("https://i.postimg.cc/RhWXpw1Y/poista-kuva.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe kuvan lataamisessa: " + ex.Message);
            }
        }

        private void etusivuNappi_Click(object sender, EventArgs e) // Avaa etusivu-form
        {
            kayttaja_etusivu kayttajaEtusivu = new kayttaja_etusivu(yhteys, userID);
            kayttajaEtusivu.Show();
            this.Close();
        }

        private void kalastuspaikatNappi_Click(object sender, EventArgs e) // Avaa kalastuspaikat-form
        {
            kayttaja_kalastuspaikat kalastuspaikat = new kayttaja_kalastuspaikat(yhteys, userID);
            kalastuspaikat.Show();
            this.Close();
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

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje ohjelma
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Vahvista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void kirjaaNappi_Click(object sender, EventArgs e) // Avaa kirjaa saalis-form
        {
            kayttaja_kirjaasaalis kirjaaSaalis = new kayttaja_kirjaasaalis(yhteys, userID);
            kirjaaSaalis.Show();
            this.Close();
        }

        private void tarkasteleNappi_Click(object sender, EventArgs e) // Avaa tarkastele saalis-form
        {
            kayttaja_tarkastelesaalis tarkasteleSaalis = new kayttaja_tarkastelesaalis(yhteys, userID);
            tarkasteleSaalis.Show();
            this.Close();
        }

        private void poistaNappi_Click(object sender, EventArgs e) // Avaa poista saalis-form
        {
            kayttaja_poistasaalis poistaSaalis = new kayttaja_poistasaalis(yhteys, userID);
            poistaSaalis.Show();
            this.Close();
        }
    }
}
