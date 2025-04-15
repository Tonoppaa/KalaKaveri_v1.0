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
    public partial class admin_käyttäjähallinta_muokkaa_muokkaakäyttäjä : Form
    {
        string userID;
        MySqlConnection yhteys;
        public admin_käyttäjähallinta_muokkaa_muokkaakäyttäjä(string kayttajaID, string etunimi, string sukunimi, string osoite, string email, string salasana, string rooli, MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            käyttäjäIDtextBox.Text = kayttajaID;
            etunimitextBox.Text = etunimi;
            sukunimitextBox.Text = sukunimi;
            osoitetextBox.Text = osoite;
            sähköpostitextBox.Text = email;
            salasanatextBox.Text = salasana;
            roolitextBox.Text = rooli;
            userID = uID;
            yhteys = yhteysOlio;
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulkee tämän formin ja avaa edellisen formin
        {
            this.Close();
            admin_käyttäjähallinta_muokkaa_käyttäjä adminKäyttäjähallintaMuokkaaKäyttäjä = new admin_käyttäjähallinta_muokkaa_käyttäjä(yhteys, userID);
            adminKäyttäjähallintaMuokkaaKäyttäjä.Show();
        }

        private void muokkaaTietojabutton_Click(object sender, EventArgs e) // Nappia klikkaamalla kenttien muokkausmahdollisuus avautuu
        {
            etunimitextBox.ReadOnly = false;
            sukunimitextBox.ReadOnly = false;
            osoitetextBox.ReadOnly = false;
            sähköpostitextBox.ReadOnly = false;
            salasanatextBox.ReadOnly = false;
            muokkaaTietojabutton.Visible = false;
            muokkaaKäyttäjäbutton.Visible = true;
            huomiolabel.Visible = true;
        }

        private void muokkaaKäyttäjäbutton_Click(object sender, EventArgs e) // Nappia klikkaamalla käyttäjän tietoja päivitetään tietokantaan
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti päivittää tämän käyttäjän tietoja?", "Vahvista tietojen päivittäminen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                try
                {
                    yhteys.Open();
                    {
                        string päivitäKäyttäjä = "UPDATE kayttaja SET etunimi = @etunimi, sukunimi = @sukunimi, osoite = @osoite, email = @email, " +
                        "salasana = @salasana, rooli = @rooli WHERE kayttajaID = @kayttajaID";
                        MySqlCommand päivitäKäyttäjäKomento = new MySqlCommand(päivitäKäyttäjä, yhteys);
                        päivitäKäyttäjäKomento.Parameters.AddWithValue("@etunimi", etunimitextBox.Text);
                        päivitäKäyttäjäKomento.Parameters.AddWithValue("@sukunimi", sukunimitextBox.Text);
                        päivitäKäyttäjäKomento.Parameters.AddWithValue("@osoite", osoitetextBox.Text);
                        päivitäKäyttäjäKomento.Parameters.AddWithValue("@email", sähköpostitextBox.Text);
                        päivitäKäyttäjäKomento.Parameters.AddWithValue("@salasana", salasanatextBox.Text);
                        päivitäKäyttäjäKomento.Parameters.AddWithValue("@rooli", roolitextBox.Text);
                        päivitäKäyttäjäKomento.Parameters.AddWithValue("@kayttajaID", käyttäjäIDtextBox.Text);
                        päivitäKäyttäjäKomento.ExecuteNonQuery();
                        MessageBox.Show("Käyttäjän tiedot päivitetty onnistuneesti!");

                        string infoPoistettuKäyttäjä = $"{DateTime.Now}: Päivitit käyttäjän ({etunimitextBox.Text} {sukunimitextBox.Text}, ID: " +
                        $"{käyttäjäIDtextBox.Text}) tietoja.{Environment.NewLine}";
                        TallennaKäyttäjänPäivitysTiedostoon(infoPoistettuKäyttäjä); // Tallentaa käyttäjän tietojen päivityksen tiedostoon
                        admin_käyttäjähallinta_muokkaa_käyttäjä adminMuokkaaKäyttäjä = new admin_käyttäjähallinta_muokkaa_käyttäjä(yhteys, userID);
                        adminMuokkaaKäyttäjä.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe käyttäjän tietojen päivittämisessä: " + ex.Message);
                }
                finally
                {
                    yhteys.Close();
                }
            }
        }

        private void TallennaKäyttäjänPäivitysTiedostoon(string päivitys) // Tallentaa tiedon käyttäjän tietojen päivittämisestä tiedostoon
        {
            try
            {
                string tiedostoPolku = $"{userID}-toiminnot.txt";
                if (!File.Exists(tiedostoPolku)) // Tarkistetaan, onko tiedosto olemassa. Jos ei ole, luodaan uusi tyhjä tiedosto
                {
                    File.Create(tiedostoPolku).Dispose(); // Luo tyhjä tiedosto, jos sitä ei ole
                }
                File.AppendAllLines(tiedostoPolku, new string[] { päivitys }); // Lisätään viesti tiedostoon
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe viestien tallentamisessa: " + ex.Message);
            }
        }
    }
}