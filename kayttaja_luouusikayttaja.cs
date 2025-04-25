using MySql.Data.MySqlClient;
using System;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace KalaKaveri_v1
{
    public partial class kayttaja_luouusikayttaja : Form
    {
        MySqlConnection yhteys; // SQL-yhteys
        string userID; // Käyttäjätunnus
        // string yhteysMerkkijono = "SERVER=localhost;PORT=3306;DATABASE=kalakaveri-db-new;UID=root;PASSWORD=pass123"; // SQL-yhteyden muodostamiseen tarvittava merkkijono
        string yhteysMerkkijono = "SERVER=switchback.proxy.rlwy.net;PORT=33933;DATABASE=railway;UID=root;PASSWORD=mBwuGEYPaWcesFCVCGuBNlhOkUElAfui"; // Railway MySQL-yhteys

        public kayttaja_luouusikayttaja()
        {
            InitializeComponent();
            yhteys = new MySqlConnection(yhteysMerkkijono);
            näytäSalasanaButton.MouseDown += new MouseEventHandler(näytäSalasanaButton_MouseDown); // Tapahtumakäsittelijä, kun salasana halutaan nähdä nappia painamalla
            näytäSalasanaButton.MouseUp += new MouseEventHandler(näytäSalasanaButton_MouseUp); // Tapahtumakäsittelijä, kun salasana halutaan piilottaa nappia painamalla
        }

        private void luotunnusNappi_Click(object sender, EventArgs e) // Nappia painamalla voidaan luoda uusi käyttäjätunnus (vain USER)
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti luoda käyttäjätunnuksen ylläolevilla tiedoilla?", "Vahvista käyttäjäntunnuksen luonti", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                string uusiKayttajaID = "";
                try
                {
                    if (string.IsNullOrEmpty(etunimiTextbox.Text) || string.IsNullOrEmpty(sukunimiTextbox.Text) ||
                        string.IsNullOrEmpty(osoiteTextbox.Text) || string.IsNullOrEmpty(emailTextbox.Text) ||
                        string.IsNullOrEmpty(salasanatextBox.Text))
                    {
                        MessageBox.Show("Kaikki kentät on täytettävä, jotta voit luoda käyttäjätunnuksen!");
                        return;
                    }

                    if (!TarkistaSalasanaPituus() || // Tarkistetaan, onko salasana riittävän pitkä
                    !TarkistaSisältääköErikoismerkkejä() || // Tarkistetaan, sisältääkö salasana erikoismerkkejä
                    !TarkistaSisältääköIsojaJaPieniäKirjaimia() || // Tarkistetaan, sisältääkö salasana isoja ja pieniä kirjaimia
                    !TarkistaSisältääköNumeroita()) // Tarkistetaan, sisältääkö salasana numeroita
                    {
                        return;
                    }

                    yhteys.Open();
                    {
                        // Hae viimeisin käyttäjäID
                        string haeKayttaja = "SELECT kayttajaID FROM kayttaja ORDER BY kayttajaID DESC LIMIT 1";
                        MySqlCommand kayttajaIDHaku = new MySqlCommand(haeKayttaja, yhteys);
                        MySqlDataReader lukija = kayttajaIDHaku.ExecuteReader();
                        if (lukija.Read()) // Jos löytyy olemassa oleva käyttäjä
                        {
                            string nykyinenID = lukija["kayttajaID"].ToString();
                            // Tarkistetaan, onko ID "USER" alussa, jos ei, aloitetaan "USER00000001"
                            if (nykyinenID.StartsWith("USER"))
                            {
                                string numeroOsa = nykyinenID.Substring(4); // Poistetaan "USER" alkuosa
                                int seuraavaNumero = int.Parse(numeroOsa) + 1; // Kasvatetaan numeroa yhdellä
                                string muutettuID = seuraavaNumero.ToString().PadLeft(8, '0'); // Lisätään tarvittavat nollat
                                uusiKayttajaID = "USER" + muutettuID; // Esim. USER000002
                            }
                            else
                            {
                                // Jos ID ei ole vielä USER000001, alustetaan se tietokantaan
                                uusiKayttajaID = "USER00000001";
                            }
                        }
                        else
                        {
                            // Jos ei ole vielä käyttäjiä
                            uusiKayttajaID = "USER00000001";
                        }
                        lukija.Close();

                        // Lisää uusi käyttäjä tietokantaan
                        string luoKayttaja = "INSERT INTO kayttaja (kayttajaID, etunimi, sukunimi, osoite, email, salasana, rooli) " +
                        "VALUES (@kayttajaID, @etunimi, @sukunimi, @osoite, @email, @salasana, @rooli)";
                        MySqlCommand kayttajanLisays = new MySqlCommand(luoKayttaja, yhteys);
                        kayttajanLisays.Parameters.AddWithValue("@kayttajaID", uusiKayttajaID);
                        kayttajanLisays.Parameters.AddWithValue("@etunimi", etunimiTextbox.Text);
                        kayttajanLisays.Parameters.AddWithValue("@sukunimi", sukunimiTextbox.Text);
                        kayttajanLisays.Parameters.AddWithValue("@osoite", osoiteTextbox.Text);
                        kayttajanLisays.Parameters.AddWithValue("@email", emailTextbox.Text);
                        kayttajanLisays.Parameters.AddWithValue("@salasana", salasanatextBox.Text);
                        kayttajanLisays.Parameters.AddWithValue("@rooli", "USER");
                        kayttajanLisays.ExecuteNonQuery();

                        MessageBox.Show("Loit käyttäjätunnuksen onnistuneesti! Saat vahvistuksen käyttäjätunnuksen luomisesta sähköpostiisi.");

                        // Lähetetään sähköposti Mailtrapin kautta
                        try
                        {
                            // Määritetään sähköpostiviesti
                            MailMessage mail = new MailMessage();
                            mail.From = new MailAddress("no-reply@KalaKaveri.app"); // Lähettäjän sähköposti
                            mail.To.Add(emailTextbox.Text); // Vastaanottajan sähköposti
                            mail.Subject = "Käyttäjätunnus luotu!";
                            mail.Body = $"Hei {etunimiTextbox.Text},\n\nTunnuksesi on luotu onnistuneesti.\n\n" +
                                        $"Käyttäjätunnus: {emailTextbox.Text}\n\n" +
                                        $"Salasana: {salasanatextBox.Text}\n\n" +
                                        $"Terveisin,\n\nKalaKaveri";

                            // Määritetään Mailtrapin SMTP-palvelin
                            SmtpClient smtp = new SmtpClient("sandbox.smtp.mailtrap.io", 2525)
                            {
                                Credentials = new NetworkCredential("b6f15facf32fcc", "30c3e2a7c5c6dd"), // Korvaa omilla Mailtrap-tiedoilla
                                EnableSsl = true
                            };
                            smtp.Send(mail); // Lähetetään sähköposti
                            MessageBox.Show("Sähköposti lähetetty onnistuneesti osoitteeseen: " + emailTextbox.Text);
                        }
                        catch (Exception emailEx)
                        {
                            MessageBox.Show("Sähköpostin lähetys epäonnistui: " + emailEx.Message);
                        }

                        MessageBox.Show("Tämä ikkuna suljetaan.");
                        this.Close();
                        kirjaudu kirjauduForm = new kirjaudu();
                        kirjauduForm.Show(); // Näytetään kirjautumisikkuna
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Virhe käyttäjätunnuksen luomisessa: " + ex.Message);
                }
                finally
                {
                    yhteys.Close(); // Suljetaan tietokantayhteys
                }
            }
        }

        private bool TarkistaSalasanaPituus() // Metodi, jonka avulla tarkistetaan, onko salasana riittävän pitkä
        {
            // Tarkistetaan, että salasanan pituus on vähintään 8 merkkiä, turvallisuussyistä
            if (salasanatextBox.Text.Length < 8)
            {
                MessageBox.Show("Salasanassa on oltava vähintään 8 merkkiä.");
                return false;
            }
            return true;
        }

        private bool TarkistaSisältääköErikoismerkkejä() // Metodi, jonka avulla tarkistetaan, sisältääkö salasana erikoismerkkejä
        {
            string erikoisMerkit = "!@#$%&*";
            bool sisältääErikoisMerkit = false;
            foreach (char merkki in salasanatextBox.Text)
            {
                if (erikoisMerkit.Contains(merkki))
                {
                    return true;
                }
            }
            MessageBox.Show("Salasanassa on oltava vähintään yksi erikoismerkki (!@#$%&*).");
            return false;
        }

        private bool TarkistaSisältääköIsojaJaPieniäKirjaimia() // Metodi, jonka avulla tarkistetaan, sisältääkö salasana isoja ja pieniä kirjaimia
        {
            bool iso = false, pieni = false;
            foreach (char merkki in salasanatextBox.Text)
            {
                if (char.IsUpper(merkki)) iso = true;
                else if (char.IsLower(merkki)) pieni = true;
            }

            if (iso && pieni) return true;

            MessageBox.Show("Salasanassa on oltava sekä isoja että pieniä kirjaimia.");
            return false;
        }

        private bool TarkistaSisältääköNumeroita() // Metodi, jonka avulla tarkistetaan, sisältääkö salasana numeroita
        {
            foreach (char merkki in salasanatextBox.Text)
            {
                if (char.IsDigit(merkki)) return true;
            }
            MessageBox.Show("Salasanassa on oltava vähintään yksi numero.");
            return false;
        }

        private void näytäSalasanaButton_MouseDown(object sender, EventArgs e) // Näytä salasana, kun nappia pidetään pohjassa
        {
            salasanatextBox.UseSystemPasswordChar = false;
        }

        private void näytäSalasanaButton_MouseUp(object sender, EventArgs e) // Piilota salasana, kun nappia ei paineta
        {
            salasanatextBox.UseSystemPasswordChar = true;
        }

        private void generoiSalasanabutton_Click(object sender, EventArgs e) // Nappia painamalla voidaan generoida salasana
        {
            salasanatextBox.Clear(); // Tyhjennetään salasanateksikenttä ennen uuden salasanan luomista
            List<char> merkit = new List<char>()
            {
                'a','b','c','d','e','f','g','h','i','j','k','l','m','n','o','p','q','r','s','t','u','v','w','x','y','z',
                'å','ä','ö',

                'A','B','C','D','E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z',
                'Å','Ä','Ö',

                '0','1','2','3','4','5','6','7','8','9',

                '!','@','#','$','%','&','*'
            };
            Random salasanaGeneroija = new Random();
            string salasana = "";
            int pituus = salasanaGeneroija.Next(8, 20); // Salasanan pituus väh. 8 merkkiä, mutta max. 20 merkkiä pitkä
            for (int i = 0; i < pituus; i++)
            {
                int satunnainenIndeksi = salasanaGeneroija.Next(merkit.Count);
                salasana += merkit[satunnainenIndeksi];
            }
            salasanatextBox.Text = salasana;
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje tämä ikkuna
        {
            this.Close();
        }
    }
}