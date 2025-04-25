using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalaKaveri_v1
{
    public partial class admin_käyttäjähallinta_lisää_käyttäjä : Form
    {
        string userID;
        MySqlConnection yhteys;
        public admin_käyttäjähallinta_lisää_käyttäjä(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            userID = uID;
            yhteys = yhteysOlio;
            LataaRoolit(); // Lataa roolit tietokannasta roolicomboBoxiin
            näytäSalasanaButton.MouseDown += new MouseEventHandler(näytäSalasanaButton_MouseDown); // Tapahtumakäsittelijä, kun salasana halutaan nähdä nappia painamalla
            näytäSalasanaButton.MouseUp += new MouseEventHandler(näytäSalasanaButton_MouseUp); // Tapahtumakäsittelijä, kun salasana halutaan piilottaa nappia painamalla
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulkee tämän formin, avaa edellisen formin (käyttäjähallinta)
        {
            this.Close();
            admin_käyttäjähallinta adminKäyttäjähallinta = new admin_käyttäjähallinta(yhteys, userID);
            adminKäyttäjähallinta.Show();
        }

        private void näytäSalasanaButton_MouseDown(object sender, EventArgs e) // Näytä salasana, kun nappia pidetään pohjassa
        {
            salasanatextBox.UseSystemPasswordChar = false;
        }

        private void näytäSalasanaButton_MouseUp(object sender, EventArgs e) // Piilota salasana, kun nappia ei paineta
        {
            salasanatextBox.UseSystemPasswordChar = true;
        }

        private void generoiSalasanabutton_Click(object sender, EventArgs e) // Luodaan satunnainen salasana, väh. 8, max. 20 merkkiä pitkä
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
            int pituus = salasanaGeneroija.Next(8, 21); // Salasanan pituus väh. 8 merkkiä, mutta max. 20 merkkiä pitkä


            for (int i = 0; i < pituus; i++)
            {
                int satunnainenIndeksi = salasanaGeneroija.Next(merkit.Count); // Valitaan satunnainen merkki listasta
                salasana += merkit[satunnainenIndeksi]; // Lisätään merkkejä salasana-muuttujaan
            }
            salasanatextBox.Text = salasana;
        }

        private void LataaRoolit() // Lataa käyttäjien roolit tietokannasta comboBoxiin
        {
            try
            {
                yhteys.Open();
                {
                    string haeRoolit = "SELECT DISTINCT rooli FROM kayttaja";
                    MySqlCommand haeRoolitKomento = new MySqlCommand(haeRoolit, yhteys);
                    MySqlDataReader roolitLukija = haeRoolitKomento.ExecuteReader();
                    while (roolitLukija.Read())
                    {
                        string rooli = roolitLukija["rooli"].ToString();
                        roolicomboBox.Items.Add(rooli);
                    }
                    roolitLukija.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe roolien lataamisessa: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void lisääKäyttäjäbutton_Click(object sender, EventArgs e) // Lisää uusi käyttäjä tietokantaan
        {
            try
            {
                DialogResult vahvistus = MessageBox.Show("Haluatko varmasti lisätä kyseisen käyttäjän?", "Vahvista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (vahvistus == DialogResult.Yes)
                {
                    // Tarkistetaan, onko jokin kenttä tyhjä
                    if (string.IsNullOrWhiteSpace(etunimitextBox.Text) || string.IsNullOrWhiteSpace(sukunimitextBox.Text) ||
                    string.IsNullOrWhiteSpace(osoitetextBox.Text) || string.IsNullOrWhiteSpace(sähköpostitextBox.Text) ||
                    string.IsNullOrWhiteSpace(salasanatextBox.Text) || string.IsNullOrWhiteSpace(roolicomboBox.Text))
                    {
                        MessageBox.Show("Kaikki kentät on täytettävä ennen käyttäjän lisäämistä.");
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
                        // Haetaan kaikki käyttäjäID:t, jotka vastaavat roolia (USER tai ADMIN)
                        string haeKaikkiKäyttäjäIDt = "SELECT kayttajaID FROM kayttaja WHERE rooli = @rooli ORDER BY kayttajaID";
                        MySqlCommand käyttäjäIDKysely = new MySqlCommand(haeKaikkiKäyttäjäIDt, yhteys);
                        käyttäjäIDKysely.Parameters.AddWithValue("@rooli", roolicomboBox.Text);
                        MySqlDataReader käyttäjäIDlukija = käyttäjäIDKysely.ExecuteReader();

                        // Listataan kaikki käyttäjäID:t ja puretaan numerot
                        List<int> käyttäjäIDt = new List<int>();
                        while (käyttäjäIDlukija.Read())
                        {
                            string käyttäjäID = käyttäjäIDlukija[0].ToString();
                            string numerot = käyttäjäID.Substring(roolicomboBox.Text.Length);
                            käyttäjäIDt.Add(int.Parse(numerot));
                        }
                        käyttäjäIDlukija.Close();

                        // Tarkistetaan, löytyykö puuttuva numero
                        int seuraavaNumero = 1; // Aloitetaan numerointi 1:stä
                        for (int i = 0; i < käyttäjäIDt.Count; i++)
                        {
                            if (käyttäjäIDt[i] != seuraavaNumero)
                            {
                                // Löydettiin aukko (puuttuva numero)
                                break; // Ei tarvitse tarkistaa enempää, koska ensimmäinen aukko löytyy
                            }
                            seuraavaNumero++;
                        }

                        // Jos aukko löytyi, luodaan puuttuva käyttäjäID
                        string seuraavaKäyttäjäID = "";
                        if (seuraavaNumero <= käyttäjäIDt.Count)
                        {
                            // Jos aukko löytyi, täytetään puuttuva ID
                            seuraavaKäyttäjäID = roolicomboBox.Text + seuraavaNumero.ToString("D8");
                        }
                        else
                        {
                            // Jos aukkoa ei löytynyt, jatketaan juoksevaa numerointia
                            if (roolicomboBox.Text == "USER")
                            {
                                seuraavaKäyttäjäID = "USER" + seuraavaNumero.ToString("D8");
                            }
                            else if (roolicomboBox.Text == "ADMIN")
                            {
                                seuraavaKäyttäjäID = "ADMIN" + seuraavaNumero.ToString("D7");
                            }
                        }

                        uusiKäyttäjäIDtextBox.Text = seuraavaKäyttäjäID;

                        string lisääKäyttäjä = "INSERT INTO kayttaja (kayttajaID, etunimi, sukunimi, osoite, email, salasana, rooli) VALUES " +
                        "(@kayttajaID, @etunimi, @sukunimi, @osoite, @email, @salasana, @rooli)";
                        MySqlCommand lisääKäyttäjäKomento = new MySqlCommand(lisääKäyttäjä, yhteys);

                        // Lisätään parametrien arvot
                        lisääKäyttäjäKomento.Parameters.AddWithValue("@kayttajaID", uusiKäyttäjäIDtextBox.Text);
                        lisääKäyttäjäKomento.Parameters.AddWithValue("@etunimi", etunimitextBox.Text);
                        lisääKäyttäjäKomento.Parameters.AddWithValue("@sukunimi", sukunimitextBox.Text);
                        lisääKäyttäjäKomento.Parameters.AddWithValue("@osoite", osoitetextBox.Text);
                        lisääKäyttäjäKomento.Parameters.AddWithValue("@email", sähköpostitextBox.Text);
                        lisääKäyttäjäKomento.Parameters.AddWithValue("@salasana", salasanatextBox.Text);
                        lisääKäyttäjäKomento.Parameters.AddWithValue("@rooli", roolicomboBox.Text);
                        lisääKäyttäjäKomento.ExecuteNonQuery(); // Suoritetaan komento
                        MessageBox.Show($"Käyttäjä lisätty tietokantaan onnistuneesti (ID: {uusiKäyttäjäIDtextBox.Text})!");

                        string infoLisättyKäyttäjä = $"{DateTime.Now}: Lisäsit uuden käyttäjän järjestelmään ({etunimitextBox.Text} {sukunimitextBox.Text}, " +
                        $"ID: {uusiKäyttäjäIDtextBox.Text}).{Environment.NewLine}";
                        LisääKäyttäjäViestiTiedostoon(infoLisättyKäyttäjä);
                        TyhjennäTapahtumatTiedostosta(); // Tyhjennetään tiedosto, jos se on jo olemassa
                        TyhjennäKentät(); // Tyhjennetään kaikki kentät, kun käyttäjä on luotu
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe käyttäjän lisäämisessä: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
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

        private void LisääKäyttäjäViestiTiedostoon(string lisäys) // Luodaan merkintä tiedostoon käyttäjän lisäyksestä
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

        private void TyhjennäTapahtumatTiedostosta() // Tyhjennetään tiedosto, johon käyttäjän toiminnot tallennetaan; juuri luodulla käyttäjällä ei pitäisi olla tapahtumia
        {
            try
            {
                string luotuKäyttäjäTiedosto = $"{uusiKäyttäjäIDtextBox.Text}-toiminnot.txt";
                if (File.Exists(luotuKäyttäjäTiedosto))
                {
                    File.WriteAllText(luotuKäyttäjäTiedosto, string.Empty); // Tyhjennetään tiedosto, jos se on olemassa
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe tiedoston tyhjentämisessä: " + ex.Message);
            }
        }

        private void TyhjennäKentät() // Tyhjennetään kaikki kentät, kun käyttäjä on luotu
        {
            etunimitextBox.Clear();
            sukunimitextBox.Clear();
            osoitetextBox.Clear();
            sähköpostitextBox.Clear();
            salasanatextBox.Clear();
            käyttäjäIDtextBox.Clear();
            uusiKäyttäjäIDtextBox.Clear();
            usertekstitextBox.Clear();
            userNumerotextBox.Clear();
            admintekstitextBox.Clear();
            adminNumerotextBox.Clear();
            roolicomboBox.SelectedIndex = -1;
        }
    }
}