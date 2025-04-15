using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalaKaveri_v1
{
    public partial class admin_kalastuspaikat_muokkaa_muokkaakalastuspaikka : Form
    {
        string userID;
        MySqlConnection yhteys;
        private const string ImgurClientID = "807261f03ff79c8"; // Imgur API client ID, käytetään kuvan lataamiseen (tässä tapauksessa vaihtamiseen)
        public admin_kalastuspaikat_muokkaa_muokkaakalastuspaikka(string paikkaID, string vesistö, string kaupunki, string kalastusmenetelmä, string paikkakuvaus,
        string koordinaatit, string paikkakuva, MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            paikkaIDtextBox.Text = paikkaID;
            vesistötextBox.Text = vesistö;
            kaupunkitextBox.Text = kaupunki;
            kalastusmenetelmärichTextBox.Text = kalastusmenetelmä;
            paikkakuvausrichTextBox.Text = paikkakuvaus;
            koordinaatittextBox.Text = koordinaatit;
            imgurUrltextBox.Text = paikkakuva;
            userID = uID;
            yhteys = yhteysOlio;
            LataaKuva(paikkakuva); // Ladataan kuva tietokannasta pictureBoxiin
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

        private void TallennaKalastuspaikanmuokkausTiedostoon(string muokkaus) // Tallenttaa muokkaustapahtuman tiedostoon, joka näytetään adminin etusivun infotaulussa
        {
            try
            {
                string tiedostoPolku = $"{userID}-toiminnot.txt";
                if (!File.Exists(tiedostoPolku)) // Tarkistetaan, onko tiedosto olemassa. Jos ei ole, luodaan uusi tyhjä tiedosto
                {
                    File.Create(tiedostoPolku).Dispose(); // Luo tyhjä tiedosto, jos sitä ei ole
                }
                File.AppendAllLines(tiedostoPolku, new string[] { muokkaus }); // Lisätään viesti tiedostoon
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe viestien tallentamisessa: " + ex.Message);
            }
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje form ja avaa edellinen form
        {
            this.Close();
            admin_kalastuspaikat_muokkaa_kalastuspaikka admin_muokkaakalastuspaikka = new admin_kalastuspaikat_muokkaa_kalastuspaikka(yhteys, userID);
            admin_muokkaakalastuspaikka.Show();
        }

        private void muutaKuvabutton_Click(object sender, EventArgs e) // Vaihda pictureBoxin kuva
        {
            try
            {
                OpenFileDialog avaaTiedostoDialogi = new OpenFileDialog(); // Avataan tiedosto-dialogi, josta voi valita kuvan
                avaaTiedostoDialogi.Title = "Valitse kuva"; // Asetetaan dialogin otsikko
                avaaTiedostoDialogi.Filter = "Kuvatiedostot|*.jpg;*.jpeg;*.png;*.bmp"; // Asetetaan sallitut tiedostomuodot

                if (avaaTiedostoDialogi.ShowDialog() == DialogResult.OK) // Jos käyttäjä valitsee tiedoston ja painaa "Avaa"
                {
                    Image alkuperainenKuva = Image.FromFile(avaaTiedostoDialogi.FileName); // Asetetaan valittu kuva PictureBoxiin
                    Image skaalattuKuva = new Bitmap(alkuperainenKuva, new Size(365, 227)); // Muutetaan kuvan koko
                    vesistöpictureBox.Image = skaalattuKuva; // Asetetaan kuva PictureBoxiin
                    vesistöpictureBox.SizeMode = PictureBoxSizeMode.Zoom;  // Skaalaa kuvan sopivaksi
                    imgurUrltextBox.Text = ""; // Tyhjennetään URL-osoite tekstikentästä
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show("Tapahtui virhe kuvan päivittämisessä: " + exx.Message);
            }
        }

        private void poistaKuvabutton_Click(object sender, EventArgs e) // Poista pictureBoxissa oleva kuva
        {
            vesistöpictureBox.Image = null; // Tyhjennetään kuva
            imgurUrltextBox.Text = ""; // Tyhjennetään URL-osoite teksikentästä
        }

        private void muutaTietojabutton_Click(object sender, EventArgs e) // Nappia painamalla formin kenttiin voidaan tehdä muutoksia
        {
            muutaTietojabutton.Visible = false; // Piilotetaan Muuta tietoja-nappi
            vesistötextBox.ReadOnly = false; // Tehdään vesistö-kenttä muokattavaksi
            kaupunkitextBox.ReadOnly = false; // Tehdään kaupunki-kenttä muokattavaksi
            kalastusmenetelmärichTextBox.ReadOnly = false; // Tehdään kalastusmenetelmä-kenttä muokattavaksi
            paikkakuvausrichTextBox.ReadOnly = false; // Tehdään paikkakuvaus-kenttä muokattavaksi
            koordinaatittextBox.ReadOnly = false; // Tehdään koordinaatit-kenttä muokattavaksi
            muutaKuvabutton.Visible = true; // Näytetään Muuta kuva-nappi
            muokkaaKalastuspaikkabutton.Visible = true; // Näytetään Muokkaa kalastuspaikka-nappi
            if (vesistöpictureBox.Image != null) // Jos kuva on valittu
            {
                poistaKuvabutton.Visible = true; // Näytetään Poista kuva-nappi
            }
            else
            {
                poistaKuvabutton.Visible = false; // Piilotetaan Poista kuva-nappi
            }
        }

        private async Task<string> MuutaKuva(string tiedostoPolku) // Lataa päivitetyn kuvan Imgur-palveluun
        {
            try
            {
                using (var client = new HttpClient()) // Luodaan uusi HttpClient-olio
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Client-ID", ImgurClientID); // Lisätään Imgur API client ID
                    var tiedosto = File.ReadAllBytes(tiedostoPolku); // Luetaan tiedosto tavuina
                    var kuva = Convert.ToBase64String(tiedosto); // Muutetaan tiedosto Base64-muotoon
                    var sisältö = new StringContent(JsonConvert.SerializeObject(new { image = kuva }), Encoding.UTF8, "application/json"); // Luodaan JSON-muotoinen data
                    var vastaus = await client.PostAsync("https://api.imgur.com/3/image", sisältö); // Lähetetään POST-pyyntö Imgur API:lle
                    var vastausData = await vastaus.Content.ReadAsStringAsync(); // Luetaan vastaus JSON-muodossa
                    var vastausJson = JsonConvert.DeserializeObject<dynamic>(vastausData); // Muutetaan JSON-muotoiseksi
                    return vastausJson.data.link; // Palautetaan vastauksena kuvan URL-osoite
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe kuvan lataamisessa: " + ex.Message);
                return null; // Palautetaan null, jos kuvan lataaminen epäonnistuu
            }
        }

        private async Task VahvistaMuutokset() // Metodin avulla muokataan kalastuspaikan tietoja tietokantaan
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti muokata tämän kalastuspaikan tietoja?", "Vahvista poistaminen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                string imgurUrl = imgurUrltextBox.Text; // Kuvan URL-osoite

                if (vesistöpictureBox.Image != null && string.IsNullOrEmpty(imgurUrltextBox.Text)) // Jos imgurUrltekstikenttä on tyhjä
                {
                    try
                    {
                        string tiedostoPolku = Path.GetTempFileName(); // Tallennetaan väliaikainen tiedosto
                        vesistöpictureBox.Image.Save(tiedostoPolku); // Tallennetaan kuva väliaikaiseen tiedostoon
                        imgurUrl = await MuutaKuva(tiedostoPolku); // Ladataan kuva Imgur-palveluun ja otetaan vastaus URL-osoitteena
                        imgurUrltextBox.Text = imgurUrl; // Asetetaan URL-osoite tekstikenttään
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe kuvan lataamisessa: " + ex.Message);
                    }
                }
                else if (vesistöpictureBox.Image == null && string.IsNullOrEmpty(imgurUrl)) // Jos kuva on poistettu
                {
                    imgurUrl = ""; // Tallennetaan tietokantaan tyhjä URL-osoite
                    imgurUrltextBox.Text = ""; // Tyhjennetään URL-osoite tekstikentästä
                }

                try
                {
                    yhteys.Open();
                    {
                        string muokkaaKalastuspaikka = "UPDATE kalastuspaikka SET kaupunki = @kaupunki, vesistö = @vesistö, kalastusmenetelmä = " +
                        "@kalastusmenetelmä, paikkakuvaus = @paikkakuvaus, koordinaatit = @koordinaatit, paikkakuva = @paikkakuva WHERE paikkaID = @paikkaID";
                        MySqlCommand muokkaaKalastuspaikkaKomento = new MySqlCommand(muokkaaKalastuspaikka, yhteys);
                        muokkaaKalastuspaikkaKomento.Parameters.AddWithValue("@kaupunki", kaupunkitextBox.Text);
                        muokkaaKalastuspaikkaKomento.Parameters.AddWithValue("@vesistö", vesistötextBox.Text);
                        muokkaaKalastuspaikkaKomento.Parameters.AddWithValue("@kalastusmenetelmä", kalastusmenetelmärichTextBox.Text);
                        muokkaaKalastuspaikkaKomento.Parameters.AddWithValue("@paikkakuvaus", paikkakuvausrichTextBox.Text);
                        muokkaaKalastuspaikkaKomento.Parameters.AddWithValue("@koordinaatit", koordinaatittextBox.Text);
                        muokkaaKalastuspaikkaKomento.Parameters.AddWithValue("@paikkaID", paikkaIDtextBox.Text);
                        muokkaaKalastuspaikkaKomento.Parameters.AddWithValue("@paikkakuva", imgurUrl); // Lisätään kuva tietokantaan
                        muokkaaKalastuspaikkaKomento.ExecuteNonQuery();

                        // Tallennetaan muokkaustapahtuma tiedostoon
                        string yhdistetty = $"{kaupunkitextBox.Text} - {vesistötextBox.Text}";
                        string infoMuokattuKalastuspaikka = $"{DateTime.Now}: Muokkasit kalastuspaikan tietoja ({yhdistetty}, ID: {paikkaIDtextBox.Text}) " +
                        $".{Environment.NewLine}";
                        TallennaKalastuspaikanmuokkausTiedostoon(infoMuokattuKalastuspaikka); // Tallennetaan muokkaustapahtuma tiedostoon
                        MessageBox.Show("Kalastuspaikan tiedot päivitetty onnistuneesti!");
                        admin_kalastuspaikat_muokkaa_kalastuspaikka admin_muokkaakalastuspaikka = new admin_kalastuspaikat_muokkaa_kalastuspaikka(yhteys, userID);
                        admin_muokkaakalastuspaikka.Show();
                        this.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe kalastuspaikan muokkauksessa: " + ex.Message);
                }
                finally
                {
                    yhteys.Close();
                }
            }
        }

        private async void muokkaaKalastuspaikkabutton_Click(object sender, EventArgs e) // Suorittaa VahvistaMuutokset()-metodin
        {
            await VahvistaMuutokset();
        }
    }
}
