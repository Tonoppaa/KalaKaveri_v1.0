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
    public partial class admin_kalastuspaikat : Form
    {
        string userID;
        MySqlConnection yhteys;
        public admin_kalastuspaikat(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            userID = uID;
            yhteys = yhteysOlio;
        }

        private void suljeButton_Click(object sender, EventArgs e) // Sulje ohjelma
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Vahvista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                Application.Exit();
            }
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

        private void poistaKalastuspaikkaButton_Click(object sender, EventArgs e) // Avaa kalastuspaikka form, jossa voi valita poistettava kalastuspaikka
        {
            admin_kalastuspaikat_poista_kalastuspaikka adminPoistaKalastuspaikka = new admin_kalastuspaikat_poista_kalastuspaikka(yhteys, userID);
            adminPoistaKalastuspaikka.Show();
            this.Close();
        }

        private void kalapankkiNappi_Click(object sender, EventArgs e) // Avaa kalapankki form
        {
            admin_kalapankki adminKalapankki = new admin_kalapankki(yhteys, userID);
            adminKalapankki.Show();
            this.Close();
        }

        private void lisääKalastuspaikkabutton_Click(object sender, EventArgs e) // Avaa form, jossa voidaan luoda uusi kalastuspaikka
        {
            admin_kalastuspaikat_lisää_kalastuspaikka adminLisääKalastuspaikka = new admin_kalastuspaikat_lisää_kalastuspaikka(yhteys, userID);
            adminLisääKalastuspaikka.Show();
            this.Close();
        }

        private void muokkaaKalastuspaikkabutton_Click(object sender, EventArgs e) // Avaa kalastuspaikka-form, josta voidaan valita haluttu kalastuspaikka, jota muokataan
        {
            admin_kalastuspaikat_muokkaa_kalastuspaikka adminMuokkaaKalastuspaikka = new admin_kalastuspaikat_muokkaa_kalastuspaikka(yhteys, userID);
            adminMuokkaaKalastuspaikka.Show();
            this.Close();
        }

        private void etusivuNappi_Click(object sender, EventArgs e) // Avaa etusivu-form
        {
            admin_etusivu adminEtusivu = new admin_etusivu(yhteys, userID);
            adminEtusivu.Show();
            this.Close();
        }

        private void käyttäjähallintaNappi_Click(object sender, EventArgs e) // Avaa käyttäjähallinta-form
        {
            admin_käyttäjähallinta admin_Käyttäjähallinta = new admin_käyttäjähallinta(yhteys, userID);
            admin_Käyttäjähallinta.Show();
            this.Close();
        }
    }
}
