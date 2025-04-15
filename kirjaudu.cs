using MySql.Data.MySqlClient;

namespace KalaKaveri_v1
{
    public partial class kirjaudu : Form
    {
        MySqlConnection yhteys; // SQL-yhteys
        string userID; // Käyttäjätunnus
        // string yhteysMerkkijono = "SERVER=localhost;PORT=3306;DATABASE=kalakaveri-db-new;UID=root;PASSWORD=pass123"; // SQL-yhteyden muodostamiseen tarvittava merkkijono
        string yhteysMerkkijono = "SERVER=switchback.proxy.rlwy.net;PORT=33933;DATABASE=railway;UID=root;PASSWORD=mBwuGEYPaWcesFCVCGuBNlhOkUElAfui"; // Railway MySQL-yhteys
        public kirjaudu()
        {
            InitializeComponent();
            yhteys = new MySqlConnection(yhteysMerkkijono);
        }
        private void kirjauduNappi_Click(object sender, EventArgs e) // Nappia klikkaamalla käyttäjä kirjautuu sisään
        {
            try
            {
                if (string.IsNullOrEmpty(kayttajatunnusTextbox.Text) || string.IsNullOrEmpty(salasanaTextbox.Text))
                {
                    MessageBox.Show("Tekstikenttä/tekstikentät ovat tyhjiä. Syötä käyttäjätunnus ja salasana.");
                    return;
                }
                yhteys.Open();
                {
                    string kayttajaKirjautuminen = "SELECT kayttajaID, salasana, email, rooli FROM kayttaja WHERE email = @email";
                    MySqlCommand mysqlKomento = new MySqlCommand(kayttajaKirjautuminen, yhteys);
                    mysqlKomento.Parameters.AddWithValue("@email", kayttajatunnusTextbox.Text);
                    MySqlDataReader lukija = mysqlKomento.ExecuteReader();
                    while (lukija.Read())
                    {
                        string sahkoposti = lukija.GetString("email");
                        string salasana = lukija.GetString("salasana");
                        string kayttajatunnus = lukija.GetString("kayttajaID");
                        string rooli = lukija.GetString("rooli");

                        if (kayttajatunnusTextbox.Text == sahkoposti && salasana == salasanaTextbox.Text && rooli == "USER")
                        {
                            MessageBox.Show("Onnistunut sisäänkirjautuminen.");
                            userID = kayttajatunnus;
                            lukija.Close();
                            kayttaja_etusivu kayttajaEtusivu = new kayttaja_etusivu(yhteys, userID);
                            kayttajaEtusivu.Show();
                            this.Hide();
                            return;
                        }
                        else if(kayttajatunnusTextbox.Text == sahkoposti && salasana == salasanaTextbox.Text && rooli == "ADMIN")
                        {
                            MessageBox.Show("Onnistunut sisäänkirjautuminen.");
                            userID = kayttajatunnus;
                            lukija.Close();
                            admin_etusivu adminEtusivu = new admin_etusivu(yhteys, userID);
                            adminEtusivu.Show();
                            this.Hide();
                            return;
                        }
                        else
                        {
                            MessageBox.Show("Virheellinen käyttäjätunnus tai salasana.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe kirjautuessa: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void unohtunutsalasanaLinkki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Avaa form, jossa voi tilata sähköpostiin unohtuneen salasanan
        {
            kayttaja_unohtunutsalasana unohtunutsalasana = new kayttaja_unohtunutsalasana();
            unohtunutsalasana.Show();
            this.Hide();
        }

        private void luouusitiliLinkki_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) // Avaa form, jossa voi luoda uuden käyttäjätunnuksen
        {
            kayttaja_luouusikayttaja luouusikayttaja = new kayttaja_luouusikayttaja();
            luouusikayttaja.Show();
            this.Hide();
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje ohjelma
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Vahvista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
