using MySql.Data.MySqlClient;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalaKaveri_v1
{
    public partial class admin_kalastuspaikat_lisää_kalastuspaikka : Form
    {
        string userID;
        MySqlConnection yhteys;
        private const string ImgurClientID = "807261f03ff79c8"; // Imgur API client ID, käytetään kuvan lataamiseen (tässä tapauksessa vaihtamiseen)
        public admin_kalastuspaikat_lisää_kalastuspaikka(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            userID = uID;
            yhteys = yhteysOlio;
        }
        private async Task<string> MuutaKuva(string tiedostoPolku) // Lataa lisätyn kuvan Imgur-palveluun
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

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje form ja avaa edellinen form
        {
            this.Close();
            admin_kalastuspaikat adminkalastuspaikat = new admin_kalastuspaikat(yhteys, userID);
            adminkalastuspaikat.Show();
        }

        private void poistaKuvabutton_Click(object sender, EventArgs e) // Metodin avulla tyhjennetään pictureBox
        {
            vesistöpictureBox.Image = null; // Tyhjennetään kuva
            imgurUrltextBox.Text = ""; // Tyhjennetään URL-osoite teksikentästä
            poistaKuvabutton.Visible = false; // Piilotetaan poista kuva-nappi
        }

        private void lisääKuvabutton_Click(object sender, EventArgs e) // Metodin avulla lisätään kuva pictureBoxiin
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
                    poistaKuvabutton.Visible = true;
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show("Tapahtui virhe kuvan päivittämisessä: " + exx.Message);
            }
        } // Metodin avulla lisätään kuva

        private async Task VahvistaLisäys() // Lisätään kalastuspaikka tietokantaan
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti lisätä tämän kalastuspaikan?", "Vahvista kalastuspaikan lisääminen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                string imgurUrl = imgurUrltextBox.Text; // Kuvan URL-osoite

                if (vesistöpictureBox.Image != null) // Jos kuvaa on muutettu
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
                    try
                    {
                        yhteys.Open();
                        {
                            // Tehdään tarkistus, että kaupunki-kenttä on vähintään 7 merkkiä pitkä
                            string kaupunkiSyöte = kaupunkitextBox.Text.Trim().ToUpper();
                            string muokattuKaupunki;
                            if (kaupunkiSyöte.Length >= 7) // Jos kaupunki-kenttä on väh. 7 merkkiä pitkä
                            {
                                muokattuKaupunki = kaupunkiSyöte.Substring(0, 7).ToUpper(); // Otetaan 7 merkkiä vasemmalta, kirjaimet isoina
                            }
                            else
                            {
                                muokattuKaupunki = kaupunkiSyöte.PadRight(7, '0').ToUpper(); // Täytetään nollilla oikealta, jos kaupungin nimi ei 7 merkkiä pitkä, kirjaimet isoina
                                                                                             // Haetaan ensin seuraava paikkaID, jotta voidaan luoda seuraava yksilöity paikkaID
                            }

                            string haettuPaikkaID = "";
                            int juoksevaNumerointi = 1;
                            string haepaikkaID = "SELECT MAX(paikkaID) FROM kalastuspaikka WHERE paikkaID LIKE @paikkaIDprefix";
                            MySqlCommand paikkaIDKysely = new MySqlCommand(haepaikkaID, yhteys);
                            paikkaIDKysely.Parameters.AddWithValue("@paikkaIDprefix", muokattuKaupunki + "%");
                            MySqlDataReader paikkaIDLukija = paikkaIDKysely.ExecuteReader();
                            if (paikkaIDLukija.Read() && paikkaIDLukija[0] != DBNull.Value)
                            {
                                haettuPaikkaID = paikkaIDLukija[0].ToString();
                                paikkaIDtextBox.Text = haettuPaikkaID;
                            }
                            paikkaIDLukija.Close();

                            // Luodaan juokseva numerointi kaupungille
                            string nykyinenPaikkaID = paikkaIDtextBox.Text;
                            if (!string.IsNullOrEmpty(haettuPaikkaID) && haettuPaikkaID.Length >= 10)
                            {
                                string numerot = nykyinenPaikkaID.Substring(nykyinenPaikkaID.Length - 3); // Otetaan vain numerot nykyisestä paikkaID:stä
                                juoksevaNumerointi = int.Parse(numerot) + 1; // Lisätään juokseva numerointi eli lisätään 1 nykyisen paikkaID:n
                            }
                            string seuraavaPaikkaID = $"{muokattuKaupunki}{juoksevaNumerointi.ToString("D3")}"; // Muutetaan juokseva numerointi merkkijonoksi
                            paikkaIDtextBox.Text = seuraavaPaikkaID;

                            string lisääKalastuspaikka = "INSERT INTO kalastuspaikka (paikkaID, kaupunki, vesistö, kalastusmenetelmä, paikkakuvaus, " +
                            "koordinaatit, paikkakuva) VALUES (@paikkaID, @kaupunki, @vesistö, @kalastusmenetelmä, @paikkakuvaus, @koordinaatit, @paikkakuva)";
                            MySqlCommand lisääKalastuspaikkaKomento = new MySqlCommand(lisääKalastuspaikka, yhteys);

                            // Asetetaan parametrit SQL-kyselyyn
                            lisääKalastuspaikkaKomento.Parameters.AddWithValue("@paikkaID", seuraavaPaikkaID);
                            lisääKalastuspaikkaKomento.Parameters.AddWithValue("@kaupunki", kaupunkitextBox.Text);
                            lisääKalastuspaikkaKomento.Parameters.AddWithValue("@vesistö", vesistötextBox.Text);
                            lisääKalastuspaikkaKomento.Parameters.AddWithValue("@kalastusmenetelmä", kalastusmenetelmärichTextBox.Text);
                            lisääKalastuspaikkaKomento.Parameters.AddWithValue("@paikkakuvaus", paikkakuvausrichTextBox.Text);
                            lisääKalastuspaikkaKomento.Parameters.AddWithValue("@koordinaatit", koordinaatittextBox.Text);
                            lisääKalastuspaikkaKomento.Parameters.AddWithValue("@paikkakuva", imgurUrl); // Lisätään kuva URL-osoite
                            lisääKalastuspaikkaKomento.ExecuteNonQuery();

                            // Tallennetaan käyttäjän toiminta tiedostoon
                            string yhdistetty = $"{kaupunkitextBox.Text} - {vesistötextBox.Text}";
                            string infoLisättyKalastuspaikka = $"{DateTime.Now}: Lisäsit uuden kalastuspaikan ({yhdistetty}, ID: {seuraavaPaikkaID}) " +
                            $".{Environment.NewLine}";
                            TallennaKalastuspaikanlisäysTiedostoon(infoLisättyKalastuspaikka); // Tallennetaan tieto lisätystä kalastuspaikasta tiedostoon
                            MessageBox.Show("Kalastuspaikka lisätty onnistuneesti!");
                            TyhjennäKentät(); // Tyhjennetään kentät lisäyksen jälkeen
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe kalastuspaikan lisäyksessä: " + ex.Message);
                    }
                    finally
                    {
                        yhteys.Close();
                    }
            }
        }

        private async void lisääKalastuspaikkabutton_Click(object sender, EventArgs e) // Nappia painamalla lisätään kalastuspaikka tietokantaan (Suoritetaan VahvistaLisäys-metodi)
        {
            if (string.IsNullOrWhiteSpace(kaupunkitextBox.Text) || string.IsNullOrWhiteSpace(vesistötextBox.Text) ||
                string.IsNullOrWhiteSpace(kalastusmenetelmärichTextBox.Text) || string.IsNullOrWhiteSpace(paikkakuvausrichTextBox.Text) ||
                string.IsNullOrWhiteSpace(koordinaatittextBox.Text)) // Tarkistetaan, että kaikki kentät on täytetty
            {
                MessageBox.Show("Kaikki kentät on täytettävä ennen lisäystä!");
                return;
            }
            else
            {
                await VahvistaLisäys();
            }             
        }

        private void TyhjennäKentät() // Tyhjennetään kentät, kun kalastuspaikka on lisätty
        {
            paikkaIDtextBox.Clear(); // Tyhjennetään paikkaID-kenttä
            kaupunkitextBox.Clear(); // Tyhjennetään kaupunki-kenttä
            vesistötextBox.Clear(); // Tyhjennetään vesistö-kenttä
            kalastusmenetelmärichTextBox.Clear(); // Tyhjennetään kalastusmenetelmä-kenttä
            paikkakuvausrichTextBox.Clear(); // Tyhjennetään paikkakuvaus-kenttä
            koordinaatittextBox.Clear(); // Tyhjennetään koordinaatit-kenttä
            imgurUrltextBox.Clear(); // Tyhjennetään URL-osoite-kenttä
            vesistöpictureBox.Image = null; // Tyhjennetään kuva
            poistaKuvabutton.Visible = false; // Piilotetaan poista kuva-nappi
        }

        private void TallennaKalastuspaikanlisäysTiedostoon(string viesti) // Tallennetaan lisätty kalastuspaikka viestitiedostoon
        {
            try
            {
                string tiedostoPolku = $"{userID}-toiminnot.txt";
                if (!File.Exists(tiedostoPolku)) // Tarkistetaan, onko tiedosto olemassa. Jos ei ole, luodaan uusi tyhjä tiedosto
                {
                    File.Create(tiedostoPolku).Dispose(); // Luo tyhjä tiedosto, jos sitä ei ole
                }
                File.AppendAllLines(tiedostoPolku, new string[] { viesti }); // Lisätään viesti tiedostoon
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe viestien tallentamisessa: " + ex.Message);
            }
        }
    }
}
