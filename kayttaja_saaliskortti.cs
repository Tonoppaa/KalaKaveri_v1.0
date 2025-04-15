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
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalaKaveri_v1
{
    public partial class kayttaja_saaliskortti : Form
    {
        string userID;
        MySqlConnection yhteys;
        private const string ImgurClientID = "807261f03ff79c8"; // Imgur API client ID, käytetään kuvan lataamiseen (tässä tapauksessa vaihtamiseen)
        public kayttaja_saaliskortti(string kalanimi, string kaupunki, string vesistö, string pituus, string paino, string pvm, string sää, 
        string lisätiedot, string saaliskuva, string kalaID, string paikkaID, string saalis_ID, MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            // Ladataan tiedot konstruktoriin
            kalalajicomboBox.Items.Add(kalanimi); // Lisätään kalan nimi comboBoxin
            kalalajicomboBox.Text = kalanimi; // Asetetaan kalan nimi heti näytille comboBoxiin
            string paikkaJaVesistö = $"{kaupunki} - {vesistö}"; // Esim. Tampere - Tohloppi
            paikkacomboBox.Items.Add(paikkaJaVesistö); // Lisätään comboBoxiin yllä oleva tieto
            paikkacomboBox.Text = paikkaJaVesistö; // Näytetään paikka ja vesistö heti comboBoxissa, kun se tulee näkyviin
            pituustextBox.Text = pituus; // Pituus sentteinä
            painotextBox.Text = paino; // Paino grammoina
            pvmdateTimePicker.Text = pvm; // Päivämäärä
            säätextBox.Text = sää; // Sää
            lisätiedotrichTextBox.Text = lisätiedot; // Lisätiedot
            kalaIDtextBox.Text = kalaID; // kalaID, jonka avulla saadaan päivitettyä tietokantaan tiedot
            paikkaIDtextBox.Text = paikkaID; // paikkaID, jonka avulla saadaan päivitettyä tietokantaan tiedot
            saalisIDtextBox.Text = saalis_ID; // saalis_ID, jonka avulla saadaan päivitettyä tietokantaan tiedot
            yhteys = yhteysOlio; // Tietokantayhteys
            userID = uID; // Käyttäjätunnus
            imgUrltextBox.Text = saaliskuva; // Kuvan URL-osoite
            LataaKuva(saaliskuva); // Suoritetaan metodi, joka lataa kuvan pictureBoxiin url:sta
            kalalajicomboBox.SelectedIndexChanged += KalalajicomboBox_SelectedIndexChanged; // Kalalajit päivittyvät, kun arvoa muutetaan comboBoxissa
            paikkacomboBox.SelectedIndexChanged += paikkacomboBox_SelectedIndexChanged; // Paikka päivittyy, kun arvoa muutetaan comboBoxissa
        }

        private void LataaKalastuspaikat() // Tässä metodissa ladataan kaupungit ja vesistöt comboboxiin
        {
            try
            {
                string valittuPaikka = paikkacomboBox.Text; // Tallennetaan nykyinen valittu paikka
                paikkacomboBox.Items.Clear(); // Poistetaan vanhat arvot ennen uusien lataamista
                yhteys.Open();
                {
                    string haeVesistö = "SELECT kaupunki, vesistö FROM kalastuspaikka";
                    MySqlCommand vesistöKysely = new MySqlCommand(haeVesistö, yhteys);
                    MySqlDataReader tietueLukija = vesistöKysely.ExecuteReader();
                    while (tietueLukija.Read())
                    {
                        string kaupunki = tietueLukija["kaupunki"].ToString();
                        string vesistö = tietueLukija["vesistö"].ToString();
                        string yhdistetty = $"{kaupunki} - {vesistö}";
                        paikkacomboBox.Items.Add(yhdistetty);
                    }
                    tietueLukija.Close();

                    // Jos comboBox ei ole tyhjä, valitaan ensimmäinen arvo
                    if (paikkacomboBox.Items.Count > 0)
                    {
                        int tallennettuIndex = paikkacomboBox.FindStringExact(valittuPaikka); // Etsitään tallennettu indeksi
                        paikkacomboBox.SelectedIndex = tallennettuIndex;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void paikkacomboBox_SelectedIndexChanged(object sender, EventArgs e) // Tapahtumankäsittelijä, joka suoritetaan kalalajia valittaessa: Suorittaa LataaPaikkaID()-metodin
        {
            LataaPaikkaID();
        }

        private void LataaPaikkaID() // Tässä metodissa ladataan kalastuspaikka-taulun paikkaID comboboxiin. paikkaIDcomboBoxin index päivittyy aina, kun paikkacomboBox päivittyy
        {
            try
            {
                if (paikkacomboBox.SelectedItem == null) // Varmistetaan, että jotain on valittu
                {
                    return;
                }

                if (yhteys.State != ConnectionState.Open)
                {
                    yhteys.Open();
                }

                string haePaikkaID = "SELECT paikkaID FROM kalastuspaikka WHERE CONCAT(kaupunki, ' - ', vesistö) = @paikka";
                MySqlCommand paikkaIDKysely = new MySqlCommand(haePaikkaID, yhteys);
                paikkaIDKysely.Parameters.AddWithValue("@paikka", paikkacomboBox.SelectedItem.ToString());
                MySqlDataReader tietueLukija = paikkaIDKysely.ExecuteReader();

                if (tietueLukija.Read())
                {
                    string paikkaID = tietueLukija["paikkaID"].ToString();
                    paikkaIDtextBox.Text = paikkaID;
                }

                tietueLukija.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void HaeKalalajiNimi() // Tämä metodi tuo kalalajit comboboxiin, jonka avulla saadaan kirjattua kala_ID saalistauluun
        {
            try
            {
                string valittuKala = kalalajicomboBox.Text; // Tallennetaan nykyinen valittu kala
                kalalajicomboBox.Items.Clear(); // Tyhjennetään combobox, jotta alkup. lisätty kalanimi ei jää; vältytään duplikaateilta

                yhteys.Open();
                string haeKalalajiID = "SELECT kalanimi FROM kalalaji";
                MySqlCommand tietueKysely = new MySqlCommand(haeKalalajiID, yhteys);
                MySqlDataReader tietueLukija = tietueKysely.ExecuteReader();
                while (tietueLukija.Read())
                {
                    string kalanimi = tietueLukija["kalanimi"].ToString();
                    kalalajicomboBox.Items.Add(kalanimi); // Asetetaan kalojen nimet comboBoxiin
                }
                tietueLukija.Close();

                if (kalalajicomboBox.Items.Contains(valittuKala)) // Jos valittu kala löytyy, asetetaan se valituksi
                {
                    kalalajicomboBox.SelectedItem = valittuKala;
                }
                else if (kalalajicomboBox.Items.Count > 0) // Jos valittu kala ei löydy, asetetaan ensimmäinen kalalaji valituksi
                {
                    kalalajicomboBox.SelectedIndex = 0; // Valitse ensimmäinen, jos edellinen kala ei löydy
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void HaeKalalajiID() // Tämä metodi tuo kalalajit comboboxiin, jonka avulla saadaan kirjattua kala_ID saalistauluun
        {
            try
            {
                if (kalalajicomboBox.SelectedItem == null) // Varmistetaan, että jotain on valittu
                {
                    return;
                }
                if (yhteys.State != ConnectionState.Open)
                {
                    yhteys.Open();
                    {
                        string haeKalalajiID = "SELECT kalaID FROM kalalaji WHERE kalanimi = @kalanimi";
                        MySqlCommand tietueKysely = new MySqlCommand(haeKalalajiID, yhteys);
                        tietueKysely.Parameters.AddWithValue("@kalanimi", kalalajicomboBox.SelectedItem.ToString());
                        MySqlDataReader tietueLukija = tietueKysely.ExecuteReader();
                        if (tietueLukija.Read())
                        {
                            string kalaID = tietueLukija["kalaID"].ToString();
                            kalaIDtextBox.Text = kalaID;
                        }
                        tietueLukija.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void KalalajicomboBox_SelectedIndexChanged(object sender, EventArgs e) // Tapahtumankäsittelijä, joka suoritetaan kalalajia valittaessa: Suorittaa HaeKalalajiID()-metodin
        {
            HaeKalalajiID();
        }

        private void LataaKuva(string saaliskuva) // Lataa kuvan pictureBoxiin
        {
            if (string.IsNullOrEmpty(saaliskuva))
            {
                MessageBox.Show("Kuva ei ole saatavilla.");
                return;
            }
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    byte[] kuvaData = webClient.DownloadData(saaliskuva);
                    using (var stream = new MemoryStream(kuvaData))
                    {
                        kalakuvapictureBox.Image = Image.FromStream(stream);
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Tapahtui virhe kuvan haussa: " + x.Message);
            }
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulkee formin ja avaa kayttaja_tarkastelesaalis-formin
        {
            this.Close();
            kayttaja_tarkastelesaalis tarkastelesaalis = new kayttaja_tarkastelesaalis(yhteys, userID);
            tarkastelesaalis.Show();
        }

        private void muutaTietojabutton_Click(object sender, EventArgs e) // Kun nappia painaa, kenttien muokkausmahdollisuus aukeaa
        {
            pituustextBox.ReadOnly = false;
            painotextBox.ReadOnly = false;
            säätextBox.ReadOnly = false;
            lisätiedotrichTextBox.ReadOnly = false;
            vaihdaKuvabutton.Visible = true;
            päivitäTiedotbutton.Visible = true;
            muutaTietojabutton.Visible = false;
            pvmdateTimePicker.Enabled = true;
            poistaKuvabutton.Visible = true; // Näytetään poista kuva -nappi
            HaeKalalajiNimi(); // Päivitä kalaID, kun käyttäjä vaihtaa comboboxin valintaa
            LataaKalastuspaikat();  // Päivitä kaupunki ja vesistö, kun käyttäjä vaihtaa comboBoxin valintaa
        }

        private void vaihdaKuvabutton_Click(object sender, EventArgs e) // Kun nappia painaa, voi vaihtaa pictureBoxiin kuvan
        {
            try
            {
                OpenFileDialog avaaTiedostoDialogi = new OpenFileDialog(); // Avataan tiedosto-dialogi, josta voi valita kuvan
                avaaTiedostoDialogi.Title = "Valitse kuva"; // Asetetaan dialogin otsikko
                avaaTiedostoDialogi.Filter = "Kuvatiedostot|*.jpg;*.jpeg;*.png;*.bmp"; // Asetetaan sallitut tiedostomuodot

                if (avaaTiedostoDialogi.ShowDialog() == DialogResult.OK) // Jos käyttäjä valitsee tiedoston ja painaa "Avaa"
                {
                    Image alkuperainenKuva = Image.FromFile(avaaTiedostoDialogi.FileName); // Asetetaan valittu kuva PictureBoxiin
                    Image skaalattuKuva = new Bitmap(alkuperainenKuva, new Size(347, 258)); // Muutetaan kuvan koko
                    kalakuvapictureBox.Image = skaalattuKuva; // Asetetaan kuva PictureBoxiin
                    kalakuvapictureBox.SizeMode = PictureBoxSizeMode.Zoom;  // Skaalaa kuvan sopivaksi
                    poistaKuvabutton.Visible = true; // Näytetään poista kuva -nappi
                    imgUrltextBox.Text = ""; // Tyhjennetään URL-osoite tekstikenttä, jotta voidaan päivittää kuva
                }
            }
            catch (Exception exx)
            {
                MessageBox.Show("Tapahtui virhe kuvan päivittämisessä: " + exx.Message);
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

        private async Task VahvistaPäivitys() // Metodi, jonka avulla tehdään päivitys saaliskortin tiedoista tietokantaan
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti päivittää saaliin?", "Vahvista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                string imgurUrl = imgUrltextBox.Text; // Kuvan URL-osoite

                if (string.IsNullOrEmpty(imgUrltextBox.Text)) // Jos kuvaa on muutettu ja tekstikenttä on tyhjä
                {
                    try
                    {
                        string tiedostoPolku = Path.GetTempFileName(); // Tallennetaan väliaikainen tiedosto
                        kalakuvapictureBox.Image.Save(tiedostoPolku); // Tallennetaan kuva väliaikaiseen tiedostoon
                        imgurUrl = await MuutaKuva(tiedostoPolku); // Ladataan kuva Imgur-palveluun ja otetaan vastaus URL-osoitteena
                        imgUrltextBox.Text = imgurUrl; // Asetetaan URL-osoite tekstikenttään
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
                        // Päivitetään ensin kalalaji-taulu
                        string päivitäKala = "UPDATE kalalaji SET kalanimi = @kalanimi WHERE kalaID = @kalaID";
                        MySqlCommand päivitäKalaKomento = new MySqlCommand(päivitäKala, yhteys);
                        päivitäKalaKomento.Parameters.AddWithValue("@kalanimi", kalalajicomboBox.Text);
                        päivitäKalaKomento.Parameters.AddWithValue("@kalaID", kalaIDtextBox.Text);

                        // Sitten päivitetään saalis-taulu
                        string päivitäSaalis = "UPDATE saalis SET pituus = @pituus, paino = @paino, pvm = @pvm, paikka_ID = @paikka_ID, sää = @sää, " +
                        "lisätiedot = @lisätiedot, saaliskuva = @saaliskuva WHERE saalis_ID = @saalis_ID";
                        MySqlCommand päivitäSaalisKomento = new MySqlCommand(päivitäSaalis, yhteys);
                        string muutettuPvm = pvmdateTimePicker.Value.ToString("yyyy-MM-dd");
                        päivitäSaalisKomento.Parameters.AddWithValue("@pituus", pituustextBox.Text);
                        päivitäSaalisKomento.Parameters.AddWithValue("@paino", painotextBox.Text);
                        päivitäSaalisKomento.Parameters.AddWithValue("@pvm", muutettuPvm);
                        päivitäSaalisKomento.Parameters.AddWithValue("@paikka_ID", paikkaIDtextBox.Text);
                        päivitäSaalisKomento.Parameters.AddWithValue("@sää", säätextBox.Text);
                        päivitäSaalisKomento.Parameters.AddWithValue("@lisätiedot", lisätiedotrichTextBox.Text);
                        päivitäSaalisKomento.Parameters.AddWithValue("@saaliskuva", imgUrltextBox.Text);
                        päivitäSaalisKomento.Parameters.AddWithValue("@saalis_ID", saalisIDtextBox.Text);

                        päivitäKalaKomento.ExecuteNonQuery();
                        päivitäSaalisKomento.ExecuteNonQuery();

                        // Päivitetään tieto käyttäjän toiminnosta tiedostoon
                        string infoPäivitettySaalis = $"{DateTime.Now}: Päivitit saaliin ({kalalajicomboBox.Text}, pyydetty: {paikkacomboBox.Text}).{Environment.NewLine}";
                        PäivitäSaalisViestiTiedostoon(infoPäivitettySaalis);
                        MessageBox.Show("Tietojen päivitys onnistui!");
                        this.Close();
                        kayttaja_tarkastelesaalis tarkastelesaalis = new kayttaja_tarkastelesaalis(yhteys, userID);
                        tarkastelesaalis.Show(); // Avataan edellinen form, jossa näkyy päivitetyt tiedot
                    }
                }
                catch (Exception exa)
                {
                    MessageBox.Show("Tapahtui virhe päivittäessä tietoja: " + exa.Message);
                }
            }
        }

        private void PäivitäSaalisViestiTiedostoon(string viesti) // Tallennetaan saaliin tiedon/tietojen päivitys viestitiedostoon
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

        private async void päivitäTiedotbutton_Click(object sender, EventArgs e) // Kun nappia painaa, VahvistaPäivitys()-metodi suoritetaan asynkronisesti
        {
            await VahvistaPäivitys();
        }

        private void poistaKuvabutton_Click(object sender, EventArgs e) // Tämän napin avulla tyhjennetään pictureBox
        {
            try
            {
                kalakuvapictureBox.Image = null; // Tyhjennetään kuva
                imgUrltextBox.Text = ""; // Tyhjennetään URL-osoite
                poistaKuvabutton.Visible = false; // Piilotetaan nappi
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe kuvan poistamisessa: " + ex.Message);
            }
        }
    }
}
