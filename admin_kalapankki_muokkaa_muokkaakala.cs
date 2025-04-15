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
    public partial class admin_kalapankki_muokkaa_muokkaakala : Form
    {
        string userID;
        MySqlConnection yhteys;
        private const string ImgurClientID = "807261f03ff79c8"; // Imgur API client ID, käytetään kuvan lataamiseen (tässä tapauksessa vaihtamiseen)
        public admin_kalapankki_muokkaa_muokkaakala(string kalaID, string kalanimi, string tyypillinenkoko, string tyypillinenpaino, string alamitta,
        string elinymparisto, string kuvaus, string kuva, MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            kalaIDtextBox.Text = kalaID;
            kalanimitextBox.Text = kalanimi;
            tyypillinenkokotextBox.Text = tyypillinenkoko;
            tyypillinenpainotextBox.Text = tyypillinenpaino;
            alamittatextBox.Text = alamitta;
            elinympäristötextBox.Text = elinymparisto;
            kalakuvausrichTextBox.Text = kuvaus;
            imgurUrltextBox.Text = kuva; // Kuvan URL-osoite
            yhteys = yhteysOlio;
            userID = uID;
            LataaKuva(kuva);           
        }

        private async Task VahvistaMuutokset() // Metodi, joka suorittaa muutokset tietokantaan
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti päivittää kalan tietoja?", "Vahvista tietojen päivitys", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                string imgurUrl = imgurUrltextBox.Text; // Kuvan URL-osoite

                if (kalapictureBox.Image != null && string.IsNullOrEmpty(imgurUrl)) // Jos kuva on valittu mutta URL-osoitetta ei ole
                {
                    try
                    {
                        string tiedostoPolku = Path.GetTempFileName();
                        kalapictureBox.Image.Save(tiedostoPolku);
                        imgurUrl = await MuutaKuva(tiedostoPolku);
                        imgurUrltextBox.Text = imgurUrl;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe kuvan lataamisessa: " + ex.Message);
                    }
                }
                else if (kalapictureBox.Image == null && string.IsNullOrEmpty(imgurUrl)) // Jos kuvaa ei ole valittu eikä URL-osoitetta saatu
                {
                    imgurUrl = ""; // Tietokantaan tallennetaan tyhjä URL-osoite
                    imgurUrltextBox.Text = ""; // Tyhjennetään URL-osoite tekstikentästä
                }

                try
                    {
                        yhteys.Open();
                        {
                            string päivitäKalatiedot = "UPDATE kalalaji SET kalanimi = @kalanimi, tyypillinenkoko = @tyypillinenkoko, " +
                            "tyypillinenpaino = @tyypillinenpaino, alamitta = @alamitta, elinympäristö = @elinympäristö, kalakuva = @kalakuva, " +
                            "kalakuvaus = @kalakuvaus WHERE kalaID = @kalaID";
                            MySqlCommand päivitäKomento = new MySqlCommand(päivitäKalatiedot, yhteys);
                            päivitäKomento.Parameters.AddWithValue("@kalaID", kalaIDtextBox.Text);
                            päivitäKomento.Parameters.AddWithValue("@kalanimi", kalanimitextBox.Text);
                            päivitäKomento.Parameters.AddWithValue("@tyypillinenkoko", tyypillinenkokotextBox.Text);
                            päivitäKomento.Parameters.AddWithValue("@tyypillinenpaino", tyypillinenpainotextBox.Text);
                            päivitäKomento.Parameters.AddWithValue("@alamitta", alamittatextBox.Text);
                            päivitäKomento.Parameters.AddWithValue("@elinympäristö", elinympäristötextBox.Text);
                            päivitäKomento.Parameters.AddWithValue("@kalakuva", imgurUrl); // Käytetään Imgur URL-osoitetta
                            päivitäKomento.Parameters.AddWithValue("@kalakuvaus", kalakuvausrichTextBox.Text);
                            päivitäKomento.ExecuteNonQuery();

                            // Tallennetaan tieto käyttäjän päivityksestä tiedostoon
                            string infoPäivitettyKalapankkiKala = $"{DateTime.Now}: Päivitit kalapankin kalan ({kalanimitextBox.Text}) tietoja." +
                            $"{Environment.NewLine}";
                            TallennaKalapäivitysTiedostoon(infoPäivitettyKalapankkiKala); // Tallennetaan tieto kalan tietojen päivityksestä tiedostoon
                            MessageBox.Show("Kalan tiedot päivitetty onnistuneesti!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Tapahtui virhe tietojen päivittämisessä: " + ex.Message);
                    }
                    finally
                    {
                        yhteys.Close();
                        this.Close();
                        admin_kalapankki_muokkaa_kalanakyma kalapankkimuokkaakalanakyma = new admin_kalapankki_muokkaa_kalanakyma(yhteys, userID);
                        kalapankkimuokkaakalanakyma.Show();
                    }
            }
        }

        private void TallennaKalapäivitysTiedostoon(string päivitys) // Tallennetaan päivitys tiedostoon, joka näytetään käyttäjän etusivun infotaulussa
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

        private async Task<string> MuutaKuva(string tiedostoPolku) // Lataa päivitetyn kuvan Imgur-palveluun
        {
            try
            {
                using (var client = new HttpClient()) // Luodaan uusi HttpClient-olio
                {
                    client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Client-ID", ImgurClientID); // Lisätään Imgur API client ID
                    var tiedosto = File.ReadAllBytes(tiedostoPolku); // Luetaan tiedosto tavuina
                    var kuva = Convert.ToBase64String(tiedosto); // Muutetaan tiedosto Base64-muotoon
                    var content = new StringContent(JsonConvert.SerializeObject(new { image = kuva }), Encoding.UTF8, "application/json"); // Luodaan JSON-muotoinen data
                    var vastaus = await client.PostAsync("https://api.imgur.com/3/image", content); // Lähetetään POST-pyyntö Imgur API:lle
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

        private void LataaKuva(string kalakuva) // Lataa kuvan pictureBoxiin
        {
            if (string.IsNullOrEmpty(kalakuva))
            {
                MessageBox.Show("Kuva ei ole saatavilla.");
                return;
            }
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] kuvaData = webClient.DownloadData(kalakuva);
                    using (var stream = new MemoryStream(kuvaData))
                    {
                        kalapictureBox.Image = Image.FromStream(stream);
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Tapahtui virhe kuvan haussa: " + x.Message);
            }
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulkee formin ja avaa edellisen formin
        {
            this.Close();
            admin_kalapankki_muokkaa_kalanakyma kalapankkimuokkaakalanakyma = new admin_kalapankki_muokkaa_kalanakyma(yhteys, userID);
            kalapankkimuokkaakalanakyma.Show();
        }

        private void muutaKuvabutton_Click(object sender, EventArgs e) // Nappia klikkaamalla voidaan muuttaa pictureBoxin kuvaa
        {
            try
            {
                OpenFileDialog avaaTiedostoDialogi = new OpenFileDialog(); // Avataan tiedosto-dialogi, josta voi valita kuvan
                avaaTiedostoDialogi.Title = "Valitse kuva"; // Asetetaan dialogin otsikko
                avaaTiedostoDialogi.Filter = "Kuvatiedostot|*.jpg;*.jpeg;*.png;*.bmp"; // Asetetaan sallitut tiedostomuodot

                if (avaaTiedostoDialogi.ShowDialog() == DialogResult.OK) // Jos käyttäjä valitsee tiedoston ja painaa "Avaa"
                {
                    Image alkuperainenKuva = Image.FromFile(avaaTiedostoDialogi.FileName); // Asetetaan valittu kuva PictureBoxiin
                    Image skaalattuKuva = new Bitmap(alkuperainenKuva, new Size(354, 200)); // Muutetaan kuvan koko
                    kalapictureBox.Image = skaalattuKuva; // Asetetaan kuva PictureBoxiin
                    kalapictureBox.SizeMode = PictureBoxSizeMode.Zoom;  // Skaalaa kuvan sopivaksi
                    poistaKuvabutton.Visible = true; // Näytetään Poista kuva-nappi, kun kuva on lisätty pictureBoxiin
                    imgurUrltextBox.Text = ""; // Tyhjennetään URL-osoite teksikentästä
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show("Tapahtui virhe kuvan päivittämisessä: " + exx.Message);
            }
        }

        private void poistaKuvabutton_Click(object sender, EventArgs e) // Tyhjennetään pictureBox
        {
            try
            {
                kalapictureBox.Image = null; // Tyhjennetään kuva
                imgurUrltextBox.Text = ""; // Tyhjennetään URL-osoite teksikentästä
                poistaKuvabutton.Visible = false; // Piilotetaan Poista kuva-nappi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe kuvan poistamisessa: " + ex.Message);
            }
        }

        private void muutaTietojabutton_Click(object sender, EventArgs e)  // Nappia klikkaamalla voidaan muuttaa kenttien tietoja
        {
            muutaTietojabutton.Visible = false; // Piilotetaan Muuta tietoja-nappi
            muokkaaNappi.Visible = true; // Näytetään Muokkaa-nappi
            kalanimitextBox.ReadOnly = false;
            tyypillinenkokotextBox.ReadOnly = false;
            tyypillinenpainotextBox.ReadOnly = false;
            alamittatextBox.ReadOnly = false;
            elinympäristötextBox.ReadOnly = false;
            kalakuvausrichTextBox.ReadOnly = false;
            muutaKuvabutton.Visible = true; // Näytetään Muuta kuva-nappi
            poistaKuvabutton.Visible = (kalapictureBox.Image != null); // Piilota poista-nappi, jos kuvaa ei ole
        }

        private async void muokkaaNappi_Click(object sender, EventArgs e) // Suoritetaan VahvistaMuutokset()-metodi, päivittää kalan tiedot tietokantaan
        {
            await VahvistaMuutokset(); // Kutsutaan VahvistaMuutokset-metodia, joka päivittää kalatiedot tietokantaan
        }
    }
}
