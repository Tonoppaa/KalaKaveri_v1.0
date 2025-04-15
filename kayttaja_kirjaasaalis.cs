using MySql.Data.MySqlClient;
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
using Newtonsoft.Json;

namespace KalaKaveri_v1
{
    public partial class kayttaja_kirjaasaalis : Form
    {
        string userID;
        MySqlConnection yhteys;
        private const string ImgurClientID = "807261f03ff79c8"; // Imgur API client ID, käytetään kuvan lataamiseen
        public kayttaja_kirjaasaalis(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            userID = uID;
            yhteys = yhteysOlio;
            LataaKalat(); // Lataa kalalajit kalalajicomboBoxiin
            LataaKalastuspaikat(); // Lataa kalastuspaikat paikkacomboBoxiin
            HaeKalalajiID(); // Lataa kala_ID tiedot textboxiin
            kalalajicomboBox.SelectedIndexChanged += KalalajicomboBox_SelectedIndexChanged; // Kalalajit päivittyvät
            paikkacomboBox.SelectedIndexChanged += paikkacomboBox_SelectedIndexChanged; // Paikat päivittyvät
            poistakuvaNappi.Visible = (kalakuvapictureBox.Image != null); // Piilota poista-nappi, jos kuvaa ei ole
        }

        private void LataaKalat() // Metodi, joka lataa kaikki kalat kalalajicomboBoxiin, kun form avataan
        {
            try
            {
                yhteys.Open();
                {
                    string haeKalat = "SELECT kalanimi FROM kalalaji";
                    MySqlCommand tietueKysely = new MySqlCommand(haeKalat, yhteys);
                    MySqlDataReader tietueLukija = tietueKysely.ExecuteReader();
                    while (tietueLukija.Read())
                    {
                        string kalanimi = tietueLukija["kalanimi"].ToString();
                        kalalajicomboBox.Items.Add(kalanimi);
                    }
                    tietueLukija.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe ladatessa kaloja: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void HaeKalalajiID() // Tämä metodi tuo kalalajien ID:t textboxiin, jonka avulla saadaan kirjattua kala_ID saalistauluun
        {
            try
            {
                if (kalalajicomboBox.SelectedItem == null) // Varmistetaan, että jotain on valittu
                {
                    return;
                }
                yhteys.Open();
                {
                    string haeKalalajiID = "SELECT kalaID FROM kalalaji WHERE kalanimi = @kalanimi";
                    MySqlCommand tietueKysely = new MySqlCommand(haeKalalajiID, yhteys);
                    tietueKysely.Parameters.AddWithValue("@kalanimi", kalalajicomboBox.SelectedItem.ToString());
                    MySqlDataReader tietueLukija = tietueKysely.ExecuteReader();
                    if (tietueLukija.Read())
                    {
                        string kalaID = tietueLukija["kalaID"].ToString();
                        kalaIDtextBox.Text = kalaID; // Asetetaan kalaID textBoxiin
                    }
                    tietueLukija.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe hakiessa kalan ID:tä: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void LataaKalastuspaikat() // Tässä metodissa ladataan kaupungit ja vesistöt comboboxiin
        {
            try
            {
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
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe ladatessa kalastuspaikkoja: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void LataaPaikkaID() /* Tässä metodissa ladataan kalastuspaikka-taulun paikkaID comboboxiin paikkaIDcomboBoxin index päivittyy aina, 
                                     kun paikkacomboBox päivittyy */
        {
            try
            {
                if (paikkacomboBox.SelectedItem == null) // Varmistetaan, että jotain on valittu
                {
                    return;
                }

                yhteys.Open();
                {
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
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe ladatessa paikkoja: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private async void kirjaasaalisNappi_Click(object sender, EventArgs e) // Kun nappia painetaan, suoritetaan VahvistaLisäys-metodi
        {
            if (kalalajicomboBox.SelectedIndex == -1 || paikkacomboBox.SelectedIndex == -1 || string.IsNullOrWhiteSpace(pituustextBox.Text) ||
                string.IsNullOrWhiteSpace(painotextBox.Text) || string.IsNullOrWhiteSpace(säätextBox.Text)) // Jos jokin kenttä tyhjänä
            {
                MessageBox.Show("Täytä kaikki kentät ennen saaliin lisäämistä.");
                return;
            }
            await VahvistaLisäys();
        }

        private async Task VahvistaLisäys() // Vahvistetaan saaliin lisäys
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti lisätä kyseisen saaliin?", "Vahvista saaliin lisäys", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                string imgurUrl = imgurKuvalinkkitextBox.Text; // Kuvan URL-osoite

                if (kalakuvapictureBox.Image != null) // Jos kuvaa on muutettu
                {
                    try
                    {
                        string tiedostoPolku = Path.GetTempFileName(); // Tallennetaan väliaikainen tiedosto
                        kalakuvapictureBox.Image.Save(tiedostoPolku); // Tallennetaan kuva väliaikaiseen tiedostoon
                        imgurUrl = await LataaKuva(tiedostoPolku); // Ladataan kuva Imgur-palveluun ja otetaan vastaus URL-osoitteena
                        imgurKuvalinkkitextBox.Text = imgurUrl; // Asetetaan URL-osoite tekstikenttään
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Virhe kuvan lataamisessa: " + ex.Message);
                    }
                }
                try
                {
                    if (yhteys.State != ConnectionState.Open)
                    {
                        yhteys.Open();
                        // Haetaan ensin seuraava saalis_ID, jotta voidaan luoda yksilöity saalis_ID
                        string haeSaalis = "SELECT MAX(saalis_ID) FROM saalis";
                        MySqlCommand saalisKysely = new MySqlCommand(haeSaalis, yhteys);
                        MySqlDataReader saalisLukija = saalisKysely.ExecuteReader();
                        if (saalisLukija.Read())
                        {
                            string haettuSaalisID = saalisLukija[0].ToString();
                            nykyinensaalisIDtextBox.Text = haettuSaalisID;
                        }
                        saalisLukija.Close();

                        // Kirjataan saalis tietokantaan
                        string lisääSaalis = "INSERT INTO saalis (saalis_ID, kayttaja_ID, kala_ID, paikka_ID, pituus, paino, pvm, sää, " +
                            "lisätiedot, saaliskuva) VALUES (@saalis_ID, @kayttaja_ID, @kalaID, @paikka_ID, @pituus, @paino, @pvm, @sää, " +
                            "@lisätiedot, @saaliskuva)";

                        MySqlCommand lisääKala = new MySqlCommand(lisääSaalis, yhteys);
                        string nykyinenSaalisID = nykyinensaalisIDtextBox.Text;
                        int juoksevaNumerointiSaalisID = int.Parse(nykyinenSaalisID) + 1; // Lisätään 1 nykyiseen saalis_ID:hen
                        string seuraavaSaalisID = juoksevaNumerointiSaalisID.ToString().PadLeft(10, '0'); // Muutetaan saalis_ID merkkijonoksi ja lisätään nollat eteen
                        string muutettuPvm = pvmdateTimePicker.Value.ToString("yyyy-MM-dd"); // Muutetaan päivämäärä oikeaan muotoon
                        int muutettuPituus = int.Parse(pituustextBox.Text);
                        int muutettuPaino = int.Parse(painotextBox.Text);

                        // Lisätään parametrien arvot
                        lisääKala.Parameters.AddWithValue("@saalis_ID", seuraavaSaalisID);
                        lisääKala.Parameters.AddWithValue("@kayttaja_ID", userID);
                        lisääKala.Parameters.AddWithValue("@kalaID", kalaIDtextBox.Text);
                        lisääKala.Parameters.AddWithValue("@paikka_ID", paikkaIDtextBox.Text);
                        lisääKala.Parameters.AddWithValue("@pituus", muutettuPituus);
                        lisääKala.Parameters.AddWithValue("@paino", muutettuPaino);
                        lisääKala.Parameters.AddWithValue("@pvm", muutettuPvm);
                        lisääKala.Parameters.AddWithValue("@sää", säätextBox.Text);
                        lisääKala.Parameters.AddWithValue("@lisätiedot", lisätiedotrichTextBox.Text);
                        lisääKala.Parameters.AddWithValue("@saaliskuva", imgurKuvalinkkitextBox.Text);
                        lisääKala.ExecuteNonQuery(); // Suoritetaan tietojen syöttäminen tietokantaan
                        MessageBox.Show("Saalis kirjattu onnistuneesti!");
                        string infoLisättySaalis = $"{DateTime.Now}: Lisäsit saaliin ({kalalajicomboBox.Text}, pyydetty: {paikkacomboBox.Text}).{Environment.NewLine}";
                        LisääSaalisViestiTiedostoon(infoLisättySaalis); // Tallennetaan lisätty saalis viestitiedostoon
                        TyhjennäKentät(); // Tyhjennetään kentät saaliin lisäyksen jälkeen
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe: " + ex.Message);
                }
                finally
                {
                    if (yhteys.State == ConnectionState.Open) // Varmistetaan, että yhteys suljetaan
                    {
                        yhteys.Close();
                    }
                }
            }
        }

        private void LisääSaalisViestiTiedostoon(string viesti) // Tallennetaan lisätty saalis viestitiedostoon
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

        private async Task<string> LataaKuva(string tiedostoPolku) // Lataa kuvan Imgur-palveluun
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

        private void TyhjennäKentät() // Kun saalis on syötetty onnistuneesti tietokantaan, tyhjennetään kaikki kentät
        {
            kalakuvapictureBox.Image = null; // Tyhjennetään kuva
            kalalajicomboBox.SelectedIndex = -1; // Tyhjennetään kalalaji
            paikkacomboBox.SelectedIndex = -1; // Tyhjennetään paikka
            pituustextBox.Clear(); // Tyhjennetään pituus
            painotextBox.Clear(); // Tyhjennetään paino
            säätextBox.Clear(); // Tyhjennetään sää
            lisätiedotrichTextBox.Clear(); // Tyhjennetään lisätiedot
            imgurKuvalinkkitextBox.Clear(); // Tyhjennetään Imgur-linkki
            lisaakuvaNappi.Visible = false; // Piilotetaan kuva-nappi
        }

        private void HaePaikkaID() // Suoritetaan LataaPaikkaID-metodi, jonka avulla paikkacomboBoxissa muuttuva arvo päivittää paikkaID:n
        {
            LataaPaikkaID(); // Päivitä paikkaID, kun käyttäjä vaihtaa comboboxin valintaa
        }

        private void KalalajicomboBox_SelectedIndexChanged(object sender, EventArgs e) // Tapahtumankäsittelijä, joka suoritetaan kalalajia valittaessa (suorittaa HaeKalalajiID-metodin)
        {
            HaeKalalajiID(); // Päivitä kalaID, kun käyttäjä vaihtaa comboboxin valintaa
        }

        private void paikkacomboBox_SelectedIndexChanged(object sender, EventArgs e) // Tapahtumankäsittelijä, joka suoritetaan paikkaa valittaessa (suorittaa HaePaikkaID-metodin)
        {
            HaePaikkaID(); // Esim. Tampere - Tohloppi comboBoxissa
        }
 
        private void KalalajiIDcomboBox_SelectIndexChanged(object sender, EventArgs e) // Kun kalalajiIDcomboBoxin arvoa muutetaan, suoritetaan HaeKalalajiID-metodi
        {
            HaeKalalajiID();
        }

        private void lisaakuvaNappi_Click(object sender, EventArgs e) // Tämän napin avulla käyttäjä voi lisätä kuvan saaliista pictureBoxiin
        {
            // Luodaan OpenFileDialog-ikkuna
            OpenFileDialog avaaTiedostoDialogi = new OpenFileDialog();
            avaaTiedostoDialogi.Title = "Valitse kuva";
            avaaTiedostoDialogi.Filter = "Kuvatiedostot|*.jpg;*.jpeg;*.png;";

            if (avaaTiedostoDialogi.ShowDialog() == DialogResult.OK) // Jos käyttäjä valitsee tiedoston ja painaa "Avaa"
            {
                Image alkuperainenKuva = Image.FromFile(avaaTiedostoDialogi.FileName); // Asetetaan valittu kuva PictureBoxiin
                Image skaalattuKuva = new Bitmap(alkuperainenKuva, new Size(320, 240)); // Muutetaan kuvan koko 320x240
                kalakuvapictureBox.Image = skaalattuKuva;
                kalakuvapictureBox.SizeMode = PictureBoxSizeMode.Zoom;  // Skaalaa kuvan sopivaksi
            }
            poistakuvaNappi.Visible = true; // Näytä poista-nappi, kun kuva on lisätty
        }

        private void poistakuvaNappi_Click(object sender, EventArgs e) // Tyhjennetään pictureBox, jos käyttäjä haluaa poistaa kuvan
        {
            try
            {
                kalakuvapictureBox.Image = null; // Tyhjennetään pictureBox
                poistakuvaNappi.Visible = false; // Piilota poista-nappi, kun kuva on poistettu
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe kuvan poistamisessa: " + ex.Message);
            }
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje form ja avaa omatsaaliit-form
        {
            this.Close();
            kayttaja_omatsaaliit omatsaaliit = new kayttaja_omatsaaliit(yhteys, userID);
            omatsaaliit.Show();
        }
    }
}
