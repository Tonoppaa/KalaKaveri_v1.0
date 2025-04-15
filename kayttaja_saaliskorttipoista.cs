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
    public partial class kayttaja_saaliskorttipoista : Form
    {
        string userID;
        MySqlConnection yhteys;
        public kayttaja_saaliskorttipoista(string kalanimi, string kaupunki, string vesistö, string pituus, string paino, string pvm, string sää, string lisätiedot, string saaliskuva, string saalisID, MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            kalalajitextBox.Text = kalanimi;
            paikkatextBox.Text = $"{kaupunki} - {vesistö}";
            pituustextBox.Text = pituus;
            painotextBox.Text = paino;
            pvmtextBox.Text = pvm;
            säätextBox.Text = sää;
            lisätiedotrichTextBox.Text = lisätiedot;
            saalisIDtextBox.Text = saalisID;
            yhteys = yhteysOlio;
            userID = uID;
            LataaKuva(saaliskuva);
        }
        private void LataaKuva(string saaliskuva) // Ladataan saaliskuva URL-osoitteesta ja näytetään se PictureBoxissa
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

        private void PoistaSaalisViestiTiedostoon(string viesti) // Tallennetaan tieto poistetusta saaliista viestitiedostoon
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

        private void poistaNappi_Click(object sender, EventArgs e) // Poistetaan saaliskortti
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti poistaa tämän saaliskortin?", "Vahvista saaliskortin poistaminen", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                try
                {
                    yhteys.Open();
                    {
                        string poistaSaalis = "DELETE FROM saalis WHERE kayttaja_ID = @kayttaja_ID AND saalis_ID = @saalis_ID" +
                        " AND pituus = @pituus AND paino = @paino" +
                        " AND sää = @sää AND lisätiedot = @lisätiedot";
                        MySqlCommand poistoKysely = new MySqlCommand(poistaSaalis, yhteys);
                        poistoKysely.Parameters.AddWithValue("@kayttaja_ID", userID);
                        poistoKysely.Parameters.AddWithValue("@saalis_ID", saalisIDtextBox.Text);
                        poistoKysely.Parameters.AddWithValue("@pituus", pituustextBox.Text);
                        poistoKysely.Parameters.AddWithValue("@paino", painotextBox.Text);
                        poistoKysely.Parameters.AddWithValue("@sää", säätextBox.Text);
                        poistoKysely.Parameters.AddWithValue("@lisätiedot", lisätiedotrichTextBox.Text);
                        poistoKysely.ExecuteNonQuery();
                        MessageBox.Show("Saaliskortti poistettu onnistuneesti.");
                        string infoPoistettuSaalis = $"{DateTime.Now}: Poistit saaliin ({kalalajitextBox.Text}, pyydetty: {paikkatextBox.Text}).{Environment.NewLine}";
                        PoistaSaalisViestiTiedostoon(infoPoistettuSaalis);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Tapahtui virhe saaliskortin poistamisessa: " + ex.Message);
                }
                finally
                {
                    yhteys.Close();
                    kayttaja_poistasaalis poistasaalis = new kayttaja_poistasaalis(yhteys, userID);
                    poistasaalis.Show();
                    this.Close();
                }
            }
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje ikkuna ja avaa edellinen form
        {
            this.Close();
            kayttaja_poistasaalis poistasaalis = new kayttaja_poistasaalis(yhteys, userID);
            poistasaalis.Show();
        }
    }
}
