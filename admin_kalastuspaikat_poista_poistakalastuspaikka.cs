using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalaKaveri_v1
{
    public partial class admin_kalastuspaikat_poista_poistakalastuspaikka : Form
    {
        string userID;
        MySqlConnection yhteys;
        public admin_kalastuspaikat_poista_poistakalastuspaikka(string paikkaID, string vesistö, string kaupunki, string kalastusmenetelmä, string paikkakuvaus,
        string koordinaatit, string paikkakuva, MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            paikkaIDtextBox.Text = paikkaID;
            vesistötextBox.Text = vesistö;
            kaupunkitextBox.Text = kaupunki;
            kalastusmenetelmärichTextBox.Text = kalastusmenetelmä;
            paikkakuvausrichTextBox.Text = paikkakuvaus;
            koordinaatittextBox.Text = koordinaatit;
            LataaKuva(paikkakuva); // Ladataan kuva tietokannasta pictureBoxiin
            userID = uID;
            yhteys = yhteysOlio;
        }

        private void LataaKuva(string valittupaikka) // Metodi, jonka avulla ladataan kuva tietokannassa olevasta url:sta pictureBoxiin
        {
            if (string.IsNullOrEmpty(valittupaikka))
            {
                MessageBox.Show("Kuva ei ole saatavilla.");
                return;
            }

            try
            {
                using (WebClient webClient = new WebClient()) // Käytetään WebClient-luokkaa kuvan lataamiseen
                {
                    byte[] kuvaData = webClient.DownloadData(valittupaikka); // Ladataan kuva url:stä
                    using (var stream = new MemoryStream(kuvaData)) // Käytetään MemoryStream-luokkaa kuvan näyttämiseen
                    {
                        vesistöpictureBox.Image = Image.FromStream(stream); // Näytetään kuva pictureBoxissa
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Tapahtui virhe kuvan haussa: " + x.Message);
            }
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje form ja avataan edellinen form
        {
            this.Close();
            admin_kalastuspaikat_poista_kalastuspaikka admin_poistakalastuspaikka = new admin_kalastuspaikat_poista_kalastuspaikka(yhteys, userID);
            admin_poistakalastuspaikka.Show();
        }

        private void poistaKalastuspaikkabutton_Click(object sender, EventArgs e) // Nappia painamalla kalastuspaikka poistetaan tietokannasta
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti poistaa tämän kalastuspaikan tietokannasta?", "Vahvista poistaminen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                try
                {
                    yhteys.Open();
                    {
                        string poistaKalastuspaikka = "DELETE FROM kalastuspaikka WHERE paikkaID = @paikkaID";
                        MySqlCommand poistaKalastuspaikkaKomento = new MySqlCommand(poistaKalastuspaikka, yhteys);
                        poistaKalastuspaikkaKomento.Parameters.AddWithValue("@paikkaID", paikkaIDtextBox.Text);
                        poistaKalastuspaikkaKomento.ExecuteNonQuery();

                        string yhdistetty = $"{kaupunkitextBox.Text} - {vesistötextBox.Text}";
                        string infoPoistettuKalastuspaikka = $"{DateTime.Now}: Poistit kalastuspaikan ({yhdistetty}, ID: {paikkaIDtextBox.Text}) " +
                        $"tietokannasta.{Environment.NewLine}";
                        TallennaKalastuspaikanpoistoTiedostoon(infoPoistettuKalastuspaikka);
                        MessageBox.Show("Kalastuspaikka poistettu onnistuneesti.");
                        admin_kalastuspaikat_poista_kalastuspaikka admin_poistakalastuspaikka = new admin_kalastuspaikat_poista_kalastuspaikka(yhteys, userID);
                        admin_poistakalastuspaikka.Show();
                        this.Close();
                    }
                }
                catch (Exception  ex)
                {
                    MessageBox.Show("Tapahtui virhe kalastuspaikan poistamisessa: " + ex.Message);
                }
                finally
                {
                    yhteys.Close();
                }
            }
        }

        private void TallennaKalastuspaikanpoistoTiedostoon(string poisto) // Tallenttaa poistotapahtuman tiedostoon, joka näytetään adminin etusivun infotaulussa
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