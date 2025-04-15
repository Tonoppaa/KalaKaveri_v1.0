using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalaKaveri_v1
{
    public partial class admin_kalapankki_poista_poistakala : Form
    {
        MySqlConnection yhteys;
        string userID;
        public admin_kalapankki_poista_poistakala(string kalaID, string kalanimi, string tyypillinenkoko, string tyypillinenpaino, string alamitta, 
        string elinymparisto, string kuvaus, string kalakuva, MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            kalaIDtextBox.Text = kalaID;
            kalanimitextBox.Text = kalanimi;
            tyypillinenkokotextBox.Text = tyypillinenkoko;
            tyypillinenpainotextBox.Text = tyypillinenpaino;
            alamittatextBox.Text = alamitta;
            elinympäristötextBox.Text = elinymparisto;
            kalakuvausrichTextBox.Text = kuvaus;
            yhteys = yhteysOlio;
            userID = uID;
            LataaKuva(kalakuva);
        }

        private void LataaKuva(string valittukalakuva) // Lataa kuvan URL:n perusteella ja näyttää sen pictureboxissa
        {
            try
            {
                yhteys.Open();
                {
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] kuvaData = webClient.DownloadData(valittukalakuva);
                        using (var stream = new MemoryStream(kuvaData))
                        {
                            kalapictureBox.Image = Image.FromStream(stream);
                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Tapahtui virhe kuvan haussa: " + x.Message);
            }
            finally
            {
                yhteys.Close();
            }
        } // Lataa kuva tietokannasta ja näyttää sen pictureboxissa

        private void suljeNappi_Click(object sender, EventArgs e) // Nappia painamalla form sulkeutuu ja palaa Adminin kalapankki-formiin
        {
            this.Close();
            admin_kalapankki_poista_kalanakyma kalapankki_poistakala = new admin_kalapankki_poista_kalanakyma(yhteys, userID);
            kalapankki_poistakala.Show();
        }

        private void poistaNappi_Click(object sender, EventArgs e) // Poistaa kalan tietokannasta
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti poistaa tämän kalan tietokannasta?", "Vahvista kalan poistaminen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                try
                {
                    yhteys.Open();
                    {
                        string poistaKalalaji = "DELETE FROM kalalaji WHERE kalaID = @kalaID";
                        MySqlCommand poistaKalalajiKomento = new MySqlCommand(poistaKalalaji, yhteys);
                        poistaKalalajiKomento.Parameters.AddWithValue("@kalaID", kalaIDtextBox.Text);
                        poistaKalalajiKomento.ExecuteNonQuery();

                        string infoPoistettuKalapankkiKala = $"{DateTime.Now}: Poistit kalapankin kalan ({kalanimitextBox.Text}) tietokannasta." +
                        $"{Environment.NewLine}";
                        TallennaKalapoistoTiedostoon(infoPoistettuKalapankkiKala); // Tallentaa poistotapahtuman tiedostoon
                        MessageBox.Show("Kala poistettu tietokannasta onnistuneesti.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe kalojen poistamisessa: " + ex.Message);
                }
                finally
                {
                    yhteys.Close();
                    this.Close();
                    admin_kalapankki_poista_kalanakyma kalapankki_poistakala = new admin_kalapankki_poista_kalanakyma(yhteys, userID);
                    kalapankki_poistakala.Show();
                }
            }
        }
        
        private void TallennaKalapoistoTiedostoon(string poisto) // Tallenttaa poistotapahtuman tiedostoon, joka näytetään adminin etusivun infotaulussa
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
