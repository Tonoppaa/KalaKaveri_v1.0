using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalaKaveri_v1
{
    public partial class admin_käyttäjähallinta_muokkaa_käyttäjä : Form
    {
        string userID;
        MySqlConnection yhteys;
        public admin_käyttäjähallinta_muokkaa_käyttäjä(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            userID = uID;
            yhteys = yhteysOlio;
            this.käyttäjädataGridView.CellDoubleClick += new DataGridViewCellEventHandler(this.käyttäjädataGridView_CellDoubleClick);
            // Tapahtumakäsittelijä, jonka avulla käyttäjän tuplaklikatessa datagridView:n solua avautuu valitun käyttäjän tiedot formiin
        }

        private void HaeKäyttäjäID() // Metodi, joka hakee käyttäjän käyttäjäID perusteella
        {
            try
            {
                yhteys.Open();
                {
                    if (!string.IsNullOrEmpty(kayttajaIDtextBox.Text))
                    {
                        string haeKäyttäjäID = "SELECT kayttajaID AS 'Käyttäjän ID', etunimi AS Etunimi, sukunimi AS Sukunimi, osoite as Osoite, email AS " +
                        "Sähköposti, salasana AS Salasana, rooli AS Rooli FROM kayttaja WHERE kayttajaID LIKE @kayttajaID";
                        MySqlCommand haeKäyttäjäIDkomento = new MySqlCommand(haeKäyttäjäID, yhteys);
                        haeKäyttäjäIDkomento.Parameters.AddWithValue("@kayttajaID", "%" + kayttajaIDtextBox.Text + "%");
                        MySqlDataAdapter käyttäjäIDadapter = new MySqlDataAdapter(haeKäyttäjäIDkomento);
                        DataTable käyttäjäTable = new DataTable();
                        käyttäjäIDadapter.Fill(käyttäjäTable);
                        if (käyttäjäTable.Rows.Count > 0)
                        {
                            käyttäjädataGridView.DataSource = käyttäjäTable;
                            TyylitaDataGridView(käyttäjädataGridView); // Tuodaan parempi tyyli datagridView:n
                            käyttäjädataGridView.Columns["Käyttäjän ID"].Width = 130; // Asetetaan käyttäjäID-sarakkeen leveys
                            käyttäjädataGridView.Columns["Etunimi"].Width = 80; // Asetetaan etunimi-sarakkeen leveys
                            käyttäjädataGridView.Columns["Rooli"].Width = 80; // Asetetaan rooli-sarakkeen leveys
                            tyhjennäTaulubutton.Visible = true; // Näytä tyhjennä taulu -nappi
                        }
                        else
                        {
                            MessageBox.Show("KäyttäjäID:tä ei löytynyt. Tarkista syöttämäsi käyttäjäID.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Jätit syöttämättä käyttäjäID:n. Syötä ensin käyttäjäID ja paina sitten 'Hae'.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe käyttäjäID:n haussa: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void HaeKokonimi() // Haetaan käyttäjää kokonimen (etunimi + sukunimi) perusteella
        {
            try
            {
                yhteys.Open();
                {
                    if (!string.IsNullOrEmpty(etunimitextBox.Text) || !string.IsNullOrEmpty(sukunimitextBox.Text))
                    {
                        string haeKokonimi = "SELECT kayttajaID AS 'Käyttäjän ID', etunimi AS Etunimi, sukunimi AS Sukunimi, osoite as Osoite, email AS " +
                        "Sähköposti, salasana AS Salasana, rooli AS Rooli FROM kayttaja WHERE etunimi LIKE @etunimi AND sukunimi LIKE @sukunimi";
                        MySqlCommand haeKokonimikomento = new MySqlCommand(haeKokonimi, yhteys);
                        haeKokonimikomento.Parameters.AddWithValue("@etunimi", "%" + etunimitextBox.Text + "%");
                        haeKokonimikomento.Parameters.AddWithValue("@sukunimi", "%" + sukunimitextBox.Text + "%");
                        MySqlDataAdapter kokonimiadapter = new MySqlDataAdapter(haeKokonimikomento);
                        DataTable käyttäjäTable = new DataTable();
                        kokonimiadapter.Fill(käyttäjäTable);
                        if (käyttäjäTable.Rows.Count > 0)
                        {
                            käyttäjädataGridView.DataSource = käyttäjäTable;
                            TyylitaDataGridView(käyttäjädataGridView); // Tuodaan parempi tyyli datagridView:n
                            käyttäjädataGridView.Columns["Käyttäjän ID"].Width = 130; // Asetetaan käyttäjäID-sarakkeen leveys
                            käyttäjädataGridView.Columns["Etunimi"].Width = 80; // Asetetaan etunimi-sarakkeen leveys
                            käyttäjädataGridView.Columns["Rooli"].Width = 80; // Asetetaan rooli-sarakkeen leveys
                            tyhjennäTaulubutton.Visible = true; // Näytä tyhjennä taulu -nappi
                        }
                        else
                        {
                            MessageBox.Show("Käyttäjää ei löytynyt nimen (etunimi tai sukunimi) avulla. Tarkista syöttämäsi nimi.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Jätit syöttämättä nimen (etunimi tai sukunimi). Syötä ensin nimi ja paina sitten 'Hae'.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe käyttäjän haussa: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void HaeOsoite() // Haetaan käyttäjää osoitteen perusteella
        {
            try
            {
                yhteys.Open();
                {
                    if (!string.IsNullOrEmpty(osoitetextBox.Text))
                    {
                        string haeOsoite = "SELECT kayttajaID AS 'Käyttäjän ID', etunimi AS Etunimi, sukunimi AS Sukunimi, osoite as Osoite, email AS " +
                        "Sähköposti, salasana AS Salasana, rooli AS Rooli FROM kayttaja WHERE osoite LIKE @osoite";
                        MySqlCommand haeOsoiteKomento = new MySqlCommand(haeOsoite, yhteys);
                        haeOsoiteKomento.Parameters.AddWithValue("@osoite", "%" + osoitetextBox.Text + "%");
                        MySqlDataAdapter osoiteadapter = new MySqlDataAdapter(haeOsoiteKomento);
                        DataTable käyttäjäTable = new DataTable();
                        osoiteadapter.Fill(käyttäjäTable);
                        if (käyttäjäTable.Rows.Count > 0)
                        {
                            käyttäjädataGridView.DataSource = käyttäjäTable;
                            TyylitaDataGridView(käyttäjädataGridView); // Tuodaan parempi tyyli datagridView:n
                            käyttäjädataGridView.Columns["Käyttäjän ID"].Width = 130; // Asetetaan käyttäjäID-sarakkeen leveys
                            käyttäjädataGridView.Columns["Etunimi"].Width = 80; // Asetetaan etunimi-sarakkeen leveys
                            käyttäjädataGridView.Columns["Rooli"].Width = 80; // Asetetaan rooli-sarakkeen leveys
                            tyhjennäTaulubutton.Visible = true; // Näytä tyhjennä taulu -nappi
                        }
                        else
                        {
                            MessageBox.Show("Käyttäjää ei löytynyt osoitteen avulla. Tarkista syöttämäsi osoite.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Jätit syöttämättä osoitteen. Syötä ensin osoite ja paina sitten 'Hae'.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe osoitteen haussa: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void HaeSähköposti() // Haetaan käyttäjää sähköpostin perusteella
        {
            try
            {
                yhteys.Open();
                {
                    if (!string.IsNullOrEmpty(emailtextBox.Text))
                    {
                        string haeSähköposti = "SELECT kayttajaID AS 'Käyttäjän ID', etunimi AS Etunimi, sukunimi AS Sukunimi, osoite as Osoite, email AS " +
                        "Sähköposti, salasana AS Salasana, rooli AS Rooli FROM kayttaja WHERE email LIKE @email";
                        MySqlCommand haeSähköpostiKomento = new MySqlCommand(haeSähköposti, yhteys);
                        haeSähköpostiKomento.Parameters.AddWithValue("@email", "%" + emailtextBox.Text + "%");
                        MySqlDataAdapter sähköpostiadapter = new MySqlDataAdapter(haeSähköpostiKomento);
                        DataTable käyttäjäTable = new DataTable();
                        sähköpostiadapter.Fill(käyttäjäTable);
                        if (käyttäjäTable.Rows.Count > 0)
                        {
                            käyttäjädataGridView.DataSource = käyttäjäTable;
                            TyylitaDataGridView(käyttäjädataGridView); // Tuodaan parempi tyyli datagridView:n
                            käyttäjädataGridView.Columns["Käyttäjän ID"].Width = 130; // Asetetaan käyttäjäID-sarakkeen leveys
                            käyttäjädataGridView.Columns["Etunimi"].Width = 80; // Asetetaan etunimi-sarakkeen leveys
                            käyttäjädataGridView.Columns["Rooli"].Width = 80; // Asetetaan rooli-sarakkeen leveys
                            tyhjennäTaulubutton.Visible = true; // Näytä tyhjennä taulu -nappi
                        }
                        else
                        {
                            MessageBox.Show("Käyttäjää ei löytynyt sähköpostin avulla. Tarkista syöttämäsi sähköposti.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Jätit syöttämättä sähköpostin. Syötä ensin sähköposti ja paina sitten 'Hae'.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe sähköpostin haussa: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void käyttäjädataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Tuplaklikkaamalla datagridviewin riviä avataan uusi ikkuna, jossa käyttäjän tiedot näkyvät
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rivi = this.käyttäjädataGridView.Rows[e.RowIndex];
                string kayttajaID = rivi.Cells["Käyttäjän ID"].Value.ToString();
                string etunimi = rivi.Cells["Etunimi"].Value.ToString();
                string sukunimi = rivi.Cells["Sukunimi"].Value.ToString();
                string osoite = rivi.Cells["Osoite"].Value.ToString();
                string email = rivi.Cells["Sähköposti"].Value.ToString();
                string salasana = rivi.Cells["Salasana"].Value.ToString();
                string rooli = rivi.Cells["Rooli"].Value.ToString();
                admin_käyttäjähallinta_muokkaa_muokkaakäyttäjä muokkaaKäyttäjä = new admin_käyttäjähallinta_muokkaa_muokkaakäyttäjä(kayttajaID, etunimi, sukunimi, osoite, email, salasana, rooli, yhteys, userID);
                muokkaaKäyttäjä.Show();
                this.Close();
            }
        }

        private void tyhjennäKentätbutton_Click(object sender, EventArgs e) // Nappia painamalla kentät pyyhitään
        {
            kayttajaIDtextBox.Clear();
            etunimitextBox.Clear();
            sukunimitextBox.Clear();
            osoitetextBox.Clear();
            emailtextBox.Clear();
        }

        private void haeKayttajaIDbutton_Click(object sender, EventArgs e) // Nappia painamalla suoritetaan HaeKäyttäjäID-metodi, joka hakee käyttäjäID:n perusteella käyttäjän
        {
            HaeKäyttäjäID();
        }

        private void haeKokonimibutton_Click(object sender, EventArgs e) // Nappia painamalla suoritetaan HaeKokonimi-metodi, joka hakee käyttäjän etu- ja sukunimen perusteella
        {
            HaeKokonimi();
        }

        private void haeOsoitebutton_Click(object sender, EventArgs e) // Nappia painamalla suoritetaan HaeOsoite-metodi, joka hakee käyttäjän osoitteen perusteella
        {
            HaeOsoite();
        }

        private void haeEmailbutton_Click(object sender, EventArgs e)  // Nappia painamalla suoritetaan HaeSähköposti-metodi, joka hakee käyttäjän sähköpostin perusteella
        {
            HaeSähköposti();
        }

        private void tyhjennäTaulubutton_Click(object sender, EventArgs e) // Tyhjennä taulu -nappi, joka tyhjentää datagridviewin
        {
            käyttäjädataGridView.DataSource = null;
            käyttäjädataGridView.Rows.Clear();
            käyttäjädataGridView.Columns.Clear();
            tyhjennäTaulubutton.Visible = false; // Piilota tyhjennä taulu -nappi
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje nappi, joka sulkee tämän formin ja avaa edellisen formin
        {
            this.Close();
            admin_käyttäjähallinta adminKäyttäjähallinta = new admin_käyttäjähallinta(yhteys, userID);
            adminKäyttäjähallinta.Show();
        }

        private void TyylitaDataGridView(DataGridView dgv) // Tyylitellään datagridView:n ulkoasu
        {
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dgv.EnableHeadersVisualStyles = false;

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10);
            dgv.DefaultCellStyle.BackColor = Color.White;
            dgv.DefaultCellStyle.ForeColor = Color.Black;
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray;

            dgv.BorderStyle = BorderStyle.None;
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            dgv.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue;
            dgv.DefaultCellStyle.SelectionForeColor = Color.White;

            dgv.RowTemplate.Height = 28;
            dgv.ColumnHeadersHeight = 35;

            dgv.RowHeadersVisible = false;
            dgv.AllowUserToAddRows = false;
            dgv.ReadOnly = true;
        }

        private void haeKaikkiKäyttäjätbutton_Click(object sender, EventArgs e) // Nappia painamalla haetaan datagridView:n kaikki käyttäjät tietokannasta
        {
            try
            {
                yhteys.Open();
                {
                    string haeKaikkiKäyttäjät = "SELECT kayttajaID AS 'Käyttäjän ID', etunimi AS Etunimi, sukunimi AS Sukunimi, osoite as Osoite, email AS " +
                    "Sähköposti, salasana AS Salasana, rooli AS Rooli FROM kayttaja";
                    MySqlCommand haeKaikkiKäyttäjätKomento = new MySqlCommand(haeKaikkiKäyttäjät, yhteys);
                    MySqlDataAdapter käyttäjätadapter = new MySqlDataAdapter(haeKaikkiKäyttäjätKomento);
                    DataTable käyttäjäTable = new DataTable();
                    käyttäjätadapter.Fill(käyttäjäTable);
                    if (käyttäjäTable.Rows.Count > 0)
                    {
                        käyttäjädataGridView.DataSource = käyttäjäTable;
                        TyylitaDataGridView(käyttäjädataGridView); // Tuodaan parempi tyyli datagridView:n
                        käyttäjädataGridView.Columns["Käyttäjän ID"].Width = 130; // Asetetaan käyttäjäID-sarakkeen leveys
                        käyttäjädataGridView.Columns["Etunimi"].Width = 80; // Asetetaan etunimi-sarakkeen leveys
                        käyttäjädataGridView.Columns["Rooli"].Width = 80; // Asetetaan rooli-sarakkeen leveys
                        tyhjennäTaulubutton.Visible = true; // Näytä tyhjennä taulu -nappi
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Virhe kaikkien käyttäjien haussa: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }
    }
}
