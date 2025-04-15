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
    public partial class admin_kalapankki : Form
    {
        MySqlConnection yhteys;
        string userID;
        public admin_kalapankki(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            yhteys = yhteysOlio;
            userID = uID;
        }

        private void poistaKalabutton_Click(object sender, EventArgs e) // Avaa poista kala-form, jossa datagridview kalalajeista
        {
            admin_kalapankki_poista_kalanakyma kalapankkipoistakalanakyma = new admin_kalapankki_poista_kalanakyma(yhteys, userID);
            kalapankkipoistakalanakyma.Show();
            this.Close();
        }

        private void kirjauduUlosNappi_Click(object sender, EventArgs e) // Kirjaa käyttäjä ulos
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti kirjautua ulos?", "Vahvista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                kirjaudu kirjauduUlos = new kirjaudu();
                kirjauduUlos.Show();
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

        private void muokkaaKalabutton_Click(object sender, EventArgs e) // Avaa mmuokkaa kalapankin kalaa-form
        {
            admin_kalapankki_muokkaa_kalanakyma kalapankkimuokkaakalanakyma = new admin_kalapankki_muokkaa_kalanakyma(yhteys, userID);
            kalapankkimuokkaakalanakyma.Show();
            this.Close();
        }

        private void lisääKalabutton_Click(object sender, EventArgs e) // Avaa lisää kala-form
        {
            admin_kalapankki_lisää_lisääkalanäkymä kalapankkilisaakalanakyma = new admin_kalapankki_lisää_lisääkalanäkymä(yhteys, userID);
            kalapankkilisaakalanakyma.Show();
            this.Close();
        }

        private void kalastuspaikatNappi_Click(object sender, EventArgs e) // Avaa kalastuspaikat-form
        {
            admin_kalastuspaikat adminkalastuspaikat = new admin_kalastuspaikat(yhteys, userID);
            adminkalastuspaikat.Show();
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
            admin_käyttäjähallinta adminKayttajahallinta = new admin_käyttäjähallinta(yhteys, userID);
            adminKayttajahallinta.Show();
            this.Close();
        }
    }
}
