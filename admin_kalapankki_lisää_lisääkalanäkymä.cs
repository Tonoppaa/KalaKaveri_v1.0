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
    public partial class admin_kalapankki_lisää_lisääkalanäkymä : Form
    {
        string userID;
        MySqlConnection yhteys;
        private const string ImgurClientID = "807261f03ff79c8"; // Imgur API client ID, käytetään kuvan lataamiseen
        public admin_kalapankki_lisää_lisääkalanäkymä(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            yhteys = yhteysOlio;
            userID = uID;
        }

        private async Task VahvistaKalalajinLisäys() // Metodi, joka lisää kalalajin tietokantaan
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti lisätä kyseisen kalalajin?", "Vahvista kalalajin lisäys", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                string imgurUrl = imgurUrltextBox.Text; // Kuvan URL-osoite

                if (kalapictureBox.Image != null) // Jos kuvaa on muutettu
                {
                    try
                    {
                        string tiedostoPolku = Path.GetTempFileName(); // Tallennetaan väliaikainen tiedosto
                        kalapictureBox.Image.Save(tiedostoPolku); // Tallennetaan kuva väliaikaiseen tiedostoon
                        imgurUrl = await LataaKuva(tiedostoPolku); // Ladataan kuva Imgur-palveluun ja otetaan vastaus URL-osoitteena
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
                        // Haetaan ensin seuraava kalaID, jotta voidaan luoda seuraava yksilöity kalaID
                        string haekalaID = "SELECT MAX(kalaID) FROM kalalaji";
                        MySqlCommand kalaIDKysely = new MySqlCommand(haekalaID, yhteys);
                        MySqlDataReader kalaIDLukija = kalaIDKysely.ExecuteReader();
                        if (kalaIDLukija.Read())
                        {
                            string haettuSaalisID = kalaIDLukija[0].ToString();
                            kalaIDtextBox.Text = haettuSaalisID;
                        }
                        kalaIDLukija.Close();

                        // Kirjataan kalalaji tietokantaan parametrisoidulla toiminnolla
                        string lisääKalalaji = "INSERT INTO kalalaji (kalaID, kalanimi, tyypillinenkoko, tyypillinenpaino, alamitta, elinympäristö, kalakuva, kalakuvaus) " +
                        "VALUES (@kalaID, @kalanimi, @tyypillinenkoko, @tyypillinenpaino, @alamitta, @elinympäristö, @kalakuva, @kalakuvaus)";
                        MySqlCommand lisääKalalajiKysely = new MySqlCommand(lisääKalalaji, yhteys);
                        string nykyinenKalaID = kalaIDtextBox.Text;
                        string numerot = nykyinenKalaID.Substring(4); // Otetaan vain numerot nykyisestä kalaID:stä
                        int juoksevaNumerointi = int.Parse(numerot) + 1; // Lisätään juokseva numerointi eli lisätään 1 nykyisen kalaID:n
                        string seuraavaKalaID = "KALA" + juoksevaNumerointi.ToString("D6"); // Muutetaan juokseva numerointi merkkijonoksi

                        // Lisätään parametrien arvot
                        lisääKalalajiKysely.Parameters.AddWithValue("@kalaID", seuraavaKalaID);
                        lisääKalalajiKysely.Parameters.AddWithValue("@kalanimi", kalanimitextBox.Text);
                        lisääKalalajiKysely.Parameters.AddWithValue("@tyypillinenkoko", tyypillinenkokotextBox.Text);
                        lisääKalalajiKysely.Parameters.AddWithValue("@tyypillinenpaino", tyypillinenpainotextBox.Text);
                        lisääKalalajiKysely.Parameters.AddWithValue("@alamitta", alamittatextBox.Text);
                        lisääKalalajiKysely.Parameters.AddWithValue("@elinympäristö", elinympäristötextBox.Text);
                        lisääKalalajiKysely.Parameters.AddWithValue("@kalakuvaus", kalakuvausrichTextBox.Text);
                        lisääKalalajiKysely.Parameters.AddWithValue("@kalakuva", imgurUrltextBox.Text);
                        lisääKalalajiKysely.ExecuteNonQuery();
                        MessageBox.Show("Uusi kalalaji lisätty järjestelmään onnistuneesti!");
                        string infoLisättyKalalaji = $"{DateTime.Now}: Lisäsit uuden kalalajin järjestelmään ({kalanimitextBox.Text}, ID: {seuraavaKalaID}).{Environment.NewLine}";
                        LisääKalalajiViestiTiedostoon(infoLisättyKalalaji);
                        TyhjennäKentät(); // Tyhjennetään kentät kalalajin lisäyksen jälkeen
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe: " + ex.Message);
                }
                finally
                {
                    if (yhteys.State == ConnectionState.Open) // Varmistetaan, että yhteys suljetaan ennen metodin suoritusta
                    {
                        yhteys.Close();
                    }
                }
            }
        }

        private void TyhjennäKentät() // Kun kalalaji on lisätty tietokantaan, tyhjennetään formin kentät
        {
            kalapictureBox.Image = null; // Tyhjennetään kuva
            kalaIDtextBox.Clear(); // Tyhjennetään kalaID-kenttä
            kalanimitextBox.Clear(); // Tyhjennetään kalanimi-kenttä
            tyypillinenkokotextBox.Clear(); // Tyhjennetään tyypillinen koko -kenttä
            tyypillinenpainotextBox.Clear(); // Tyhjennetään tyypillinen paino -kenttä
            alamittatextBox.Clear(); // Tyhjennetään alamitta-kenttä
            elinympäristötextBox.Clear(); // Tyhjennetään elinympäristö-kenttä
            imgurUrltextBox.Clear(); // Tyhjennetään imgur URL -kenttä
            poistaKuvabutton.Visible = false; // Piilotetaan poista-nappi
            kalakuvausrichTextBox.Clear(); // Tyhjennetään kalakuvaus-kenttä
        }

        private void LisääKalalajiViestiTiedostoon(string lisäys) // Tallennetaan lisätty kalalaji viestitiedostoon
        {
            try
            {
                string tiedostoPolku = $"{userID}-toiminnot.txt";
                if (!File.Exists(tiedostoPolku)) // Tarkistetaan, onko tiedosto olemassa. Jos ei ole, luodaan uusi tyhjä tiedosto
                {
                    File.Create(tiedostoPolku).Dispose(); // Luo tyhjä tiedosto, jos sitä ei ole
                }
                File.AppendAllLines(tiedostoPolku, new string[] { lisäys }); // Lisätään viesti tiedostoon
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

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje form ja avaa admin_kalapankki-form
        {
            this.Close();
            admin_kalapankki kalapankki = new admin_kalapankki(yhteys, userID);
            kalapankki.Show();
        }

        private void lisääKuvabutton_Click(object sender, EventArgs e) // Nappia painamalla voidaan lisätä kalan kuva paikallisesta tiedostosta
        {
            // Luodaan OpenFileDialog-ikkuna
            OpenFileDialog avaaTiedostoDialogi = new OpenFileDialog();
            avaaTiedostoDialogi.Title = "Valitse kuva";
            avaaTiedostoDialogi.Filter = "Kuvatiedostot|*.jpg;*.jpeg;*.png;";

            if (avaaTiedostoDialogi.ShowDialog() == DialogResult.OK) // Jos käyttäjä valitsee tiedoston ja painaa "Avaa"
            {
                Image alkuperainenKuva = Image.FromFile(avaaTiedostoDialogi.FileName); // Asetetaan valittu kuva PictureBoxiin
                Image skaalattuKuva = new Bitmap(alkuperainenKuva, new Size(354, 200)); // Muutetaan kuvan koko
                kalapictureBox.Image = skaalattuKuva;
                kalapictureBox.SizeMode = PictureBoxSizeMode.Zoom;  // Skaalaa kuvan sopivaksi
            }
            poistaKuvabutton.Visible = true; // Näytä poista-nappi, kun kuva on lisätty
        }

        private void poistaKuvabutton_Click(object sender, EventArgs e) // Nappia painamalla pictureBox tyhjennetään
        {
            kalapictureBox.Image = null; // Tyhjennetään pictureBox
            poistaKuvabutton.Visible = false; // Piilota poista-nappi, kun kuva on poistettu
        }

        private async void lisääNappi_Click(object sender, EventArgs e) // Nappia painamalla suoritetaan VahvistaKalalajinLisäys-metodi, joka lisää kalalajin tietokantaan
        {
            if (string.IsNullOrWhiteSpace(kalanimitextBox.Text) || string.IsNullOrWhiteSpace(tyypillinenkokotextBox.Text) || 
                string.IsNullOrWhiteSpace(tyypillinenpainotextBox.Text) || string.IsNullOrWhiteSpace(alamittatextBox.Text) || 
                string.IsNullOrWhiteSpace(elinympäristötextBox.Text)) // Tarkistetaan, että kaikki kentät on täytetty
            {
                MessageBox.Show("Kaikki kentät on täytettävä ennen kalalajin lisäämistä!");
                return;
            }
            await VahvistaKalalajinLisäys(); // Suoritetaan VahvistaKalalajinLisäys-metodi
        }
    }
}