using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace KalaKaveri_v1
{
    public partial class kayttaja_unohtunutsalasana : Form
    {
        MySqlConnection yhteys; // SQL-yhteys
        // string yhteysMerkkijono = "SERVER=localhost;PORT=3306;DATABASE=kalakaveri-db-new;UID=root;PASSWORD=pass123"; // SQL-yhteyden muodostamiseen tarvittava merkkijono
        string yhteysMerkkijono = "SERVER=switchback.proxy.rlwy.net;PORT=33933;DATABASE=railway;UID=root;PASSWORD=mBwuGEYPaWcesFCVCGuBNlhOkUElAfui"; // Railway MySQL-yhteys
        public kayttaja_unohtunutsalasana()
        {
            InitializeComponent();
            yhteys = new MySqlConnection(yhteysMerkkijono);
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje tämä form
        {
            this.Close();
        }

        private void lähetäNappi_Click(object sender, EventArgs e) // Nappia painamalla lähetetään viesti käyttäjän sähköpostiin, joka sisältää käyttäjän salasanan
        {
            try
            {
                // Tarkistetaan, että sähköpostikenttä ei ole tyhjä
                if (string.IsNullOrWhiteSpace(sähköpostiTextbox.Text))
                {
                    MessageBox.Show("Kirjoita sähköpostiosoite, johon haluat palauttaa unohtuneen salasanan.");
                    return;
                }
                yhteys.Open();
                {
                    // Hae sähköposti tietokannasta
                    string salasanaKysely = "SELECT salasana FROM kayttaja WHERE email = @email";
                    MySqlCommand salasanaKyselyKomento = new MySqlCommand(salasanaKysely, yhteys);
                    salasanaKyselyKomento.Parameters.AddWithValue("@email", sähköpostiTextbox.Text);
                    MySqlDataReader salasanaLukija = salasanaKyselyKomento.ExecuteReader();

                    if (salasanaLukija.Read()) // Jos sähköposti löytyy
                    {
                        string haettuSalasana = salasanaLukija["salasana"].ToString(); // Haetaan salasana tietokannasta

                        // Lähetetään sähköposti Mailtrapin kautta
                        try
                        {
                            // Määritetään sähköpostiviesti
                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress("no-reply@KalaKaveri.app"); // Lähettäjän sähköposti
                            mail.To.Add(sähköpostiTextbox.Text); // Vastaanottajan sähköposti
                            mail.Subject = "Tilaamasi viesti";
                            mail.Body = $"Hei,\n\n" +
                                        $"alla tilaamasi salasana.\n\n" +
                                        $"Salasana: {haettuSalasana}\n\n" +
                                        $"Terveisin,\n\nKalaKaveri";

                            // Määritetään Mailtrapin SMTP-palvelin
                            SmtpClient smtp = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
                            {
                                Credentials = new NetworkCredential("b6f15facf32fcc", "30c3e2a7c5c6dd"), // Korvaa omilla Mailtrap-tiedoilla
                                EnableSsl = true
                            };
                            smtp.Send(mail); // Lähetetään sähköposti
                            MessageBox.Show("Sähköposti lähetetty antamaasi osoitteeseen! Viesti saapuu, jos kyseinen sähköposti löytyy järjestelmästä.");
                        }
                        catch (Exception emailEx)
                        {
                            MessageBox.Show("Sähköpostin lähetys epäonnistui: " + emailEx.Message);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Sähköpostiosoitetta ei löydy.");
                    }
                    salasanaLukija.Close();
                }
                this.Close(); // Suljetaan tämä ikkuna
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe viestin lähettämisessä: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }
    }
}
