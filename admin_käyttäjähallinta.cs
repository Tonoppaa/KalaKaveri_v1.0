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
    public partial class admin_käyttäjähallinta : Form
    {
        string userID;
        MySqlConnection yhteys;
        public admin_käyttäjähallinta(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            userID = uID;
            yhteys = yhteysOlio;
        }

        private void kirjauduUlosNappi_Click(object sender, EventArgs e) // Kirjaa käyttäjä ulos
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti kirjautua ulos?", "Vahvista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                kirjaudu kirjauduSisään = new kirjaudu();
                kirjauduSisään.Show();
                this.Close();
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

        private void poistaKäyttäjäButton_Click(object sender, EventArgs e) // Avaa form, josta voi hakea poistettavia käyttäjiä
        {
            admin_käyttäjähallinta_poista_käyttäjä adminPoistaKäyttäjä = new admin_käyttäjähallinta_poista_käyttäjä(yhteys, userID);
            adminPoistaKäyttäjä.Show();
            this.Close();
        }

        private void muokkaaKäyttäjäbutton_Click(object sender, EventArgs e) // Avaa form, josta voi hakea muokattavia käyttäjiä
        {
            admin_käyttäjähallinta_muokkaa_käyttäjä adminMuokkaaKäyttäjä = new admin_käyttäjähallinta_muokkaa_käyttäjä(yhteys, userID);
            adminMuokkaaKäyttäjä.Show();
            this.Close();
        }

        private void lisääKäyttäjäbutton_Click(object sender, EventArgs e) // Avaa form, jossa voi lisätä käyttäjiä
        {
            admin_käyttäjähallinta_lisää_käyttäjä adminLisääKäyttäjä = new admin_käyttäjähallinta_lisää_käyttäjä(yhteys, userID);
            adminLisääKäyttäjä.Show();
            this.Close();
        }

        private void etusivuNappi_Click(object sender, EventArgs e) // Avaa etusivu-form
        {
            admin_etusivu etusivu = new admin_etusivu(yhteys, userID);
            etusivu.Show();
            this.Close();
        }

        private void kalastuspaikatNappi_Click(object sender, EventArgs e) // Avaa kalastuspaikat-form
        {
            admin_kalastuspaikat adminKalastuspaikat = new admin_kalastuspaikat(yhteys, userID);
            adminKalastuspaikat.Show();
            this.Close();
        }

        private void kalapankkiNappi_Click(object sender, EventArgs e) // Avaa kalapankki-form
        {
            admin_kalapankki adminKalapankki = new admin_kalapankki(yhteys, userID);
            adminKalapankki.Show();
            this.Close();
        }
    }
}