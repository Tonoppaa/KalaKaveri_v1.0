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
    public partial class kayttaja_tarkastelekalastuspaikka : Form
    {
        string userID;
        MySqlConnection yhteys;
        public kayttaja_tarkastelekalastuspaikka(string vesistö, string kaupunki, string kalastusmenetelmä, string paikkakuvaus, 
        string koordinaatit, string paikkakuva, MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            vesistötextBox.Text = vesistö;
            kaupunkitextBox.Text = kaupunki;
            kalastusmenetelmärichTextBox.Text = kalastusmenetelmä;
            paikkakuvausrichTextBox.Text = paikkakuvaus;
            koordinaatittextBox.Text = koordinaatit;
            userID = uID;
            yhteys = yhteysOlio;
            LataaKuva(paikkakuva); // Ladataan kuva tietokannasta
        }

        private void LataaKuva(string valittupaikka) // Metodi, jonka avulla ladataan kuva tietokannassa olevasta url:sta pictureBoxiin
        {
            if (string.IsNullOrEmpty(valittupaikka)) // Jos kuva puuttuu eli on tietokannassa tyhjä/null, näytetään viesti
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

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje form ja avaa kalastuspaikat-form
        {
            this.Close();
        }
    }
}
