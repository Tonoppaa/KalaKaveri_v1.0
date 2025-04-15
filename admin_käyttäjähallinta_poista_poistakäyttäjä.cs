using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KalaKaveri_v1
{
    public partial class admin_käyttäjähallinta_poista_poistakäyttäjä : Form
    {
        string userID;
        MySqlConnection yhteys;
        public admin_käyttäjähallinta_poista_poistakäyttäjä(string kayttajaID, string etunimi, string sukunimi, string osoite, string email, string salasana, string rooli, MySqlConnection yhteysOlio, string uID)
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
            admin_käyttäjähallinta_poista_käyttäjä adminPoistaKäyttäjä = new admin_käyttäjähallinta_poista_käyttäjä(yhteys, userID);
            adminPoistaKäyttäjä.Show();
        }

        private void poistaNappi_Click(object sender, EventArgs e) // Nappia painamalla poistetaan käyttäjä tietokannasta
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti poistaa tämän käyttäjän tietokannasta?", "Vahvista käyttäjän poistaminen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                try
                {
                    yhteys.Open();
                    {
                        string poistaKäyttäjä = "DELETE FROM kayttaja WHERE kayttajaID = @kayttajaID";
                        MySqlCommand poistaKäyttäjäKomento = new MySqlCommand(poistaKäyttäjä, yhteys);
                        poistaKäyttäjäKomento.Parameters.AddWithValue("@kayttajaID", käyttäjäIDtextBox.Text);
                        poistaKäyttäjäKomento.ExecuteNonQuery();

                        string infoPoistettuKäyttäjä = $"{DateTime.Now}: Poistit käyttäjän ({etunimitextBox.Text} {sukunimitextBox.Text}, ID: " +
                            $"{käyttäjäIDtextBox.Text}) tietokannasta.{Environment.NewLine}";
                        TallennaKäyttäjänpoistoTiedostoon(infoPoistettuKäyttäjä);
                        MessageBox.Show("Käyttäjä poistettu onnistuneesti.");
                        admin_käyttäjähallinta_poista_käyttäjä admin_poistakäyttäjä = new admin_käyttäjähallinta_poista_käyttäjä(yhteys, userID);
                        admin_poistakäyttäjä.Show(); // Avataan edellinen form, kun käyttäjä on poistettu
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe käyttäjän poistamisessa: " + ex.Message);
                }
                finally
                {
                    yhteys.Close();
                }
            }
        }

        private void TallennaKäyttäjänpoistoTiedostoon(string poisto) // Tallentaa tiedon käyttäjän poistamisesta tiedostoon
        {
            try
            {
                string tiedostoPolku = $"{userID}-toiminnot.txt";
                if (!File.Exists(tiedostoPolku)) // Tarkistetaan, onko tiedosto olemassa. Jos ei ole, luodaan uusi tyhjä tiedosto
                {
                    File.Create(tiedostoPolku).Dispose(); // Luo tyhjä tiedosto, jos sitä ei ole
                }
                File.AppendAllLines(tiedostoPolku, new string[] { poisto }); // Lisätään viesti tiedostoon
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe viestien tallentamisessa: " + ex.Message);
            }
        }
    }
}
