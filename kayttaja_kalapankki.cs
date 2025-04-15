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
    public partial class kayttaja_kalapankki : Form
    {
        string userID;
        MySqlConnection yhteys;
        public kayttaja_kalapankki(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            userID = uID;
            yhteys = yhteysOlio;
            LataaKalat(); // Lataa kalat datagridView:n, kun käyttäjä avaa formin
            this.kalatiedotdataGridView.CellDoubleClick += new DataGridViewCellEventHandler(this.kalatiedotdatagridview_CellDoubleClick);
            // Tapahtumakäsittelijä: Kun käyttäjä tuplaklikkaa solua datagridView:ssä, avautuu kyseisen kalan tiedot uuteen formiin
        }

        private void LataaKalat() // Lataa kalojen tiedot datagridView:n
        {
            try
            {
                yhteys.Open();
                {
                    string haeKalat = "SELECT kalaID, kalanimi AS 'Kalan nimi', tyypillinenkoko AS 'Tyypillinen pituus', tyypillinenpaino AS 'Tyypillinen" +
                    " paino', alamitta AS Alamitta, elinympäristö AS Elinympäristö, kalakuva, kalakuvaus AS Kuvaus FROM kalalaji ORDER BY kalanimi ASC";
                    MySqlCommand haeKalatKomento = new MySqlCommand(haeKalat, yhteys);
                    MySqlDataAdapter kalatAdapter = new MySqlDataAdapter(haeKalatKomento);
                    DataTable kalatTable = new DataTable();
                    kalatAdapter.Fill(kalatTable);
                    TyylitaDataGridView(kalatiedotdataGridView);
                    kalatiedotdataGridView.DataSource = kalatTable;
                    kalatiedotdataGridView.Columns["kalaID"].Visible = false; // Piilotetaan käyttäjältä kalaID, ei oleellinen tieto käyttäjälle
                    kalatiedotdataGridView.Columns["kalakuva"].Visible = false; // Piilotetaan käyttäjältä kalakuva, sisältää vain kuvan URL, ei oleellinen tieto käyttäjälle
                    kalatiedotdataGridView.Columns["Kalan nimi"].Width = 90; // Kalan nimi-kentän leveys pikseleinä
                    kalatiedotdataGridView.Columns["Tyypillinen pituus"].Width = 100; // Tyypillinen pituus-kentän leveys pikseleinä
                    kalatiedotdataGridView.Columns["Tyypillinen paino"].Width = 100; // Tyypillinen paino-kentän leveys pikseleinä
                    kalatiedotdataGridView.Columns["Alamitta"].Width = 85; // Alamitta-kentän leveys pikseleinä
                    kalatiedotdataGridView.Columns["Kuvaus"].Width = 75; // Kuvaus-kentän leveys pikseleinä
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe kalojen lataamisessa: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void TyylitaDataGridView(DataGridView dgv) // Tyylitellään datagridView:n ulkoasu
        {
            dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.MidnightBlue; // Päällysrivien väri
            dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White; // Päällysrivien tekstin väri
            dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold); // Päällysrivien fontti
            dgv.EnableHeadersVisualStyles = false; // Poistetaan Windowsin oletustyylit päällysriviltä

            dgv.DefaultCellStyle.Font = new Font("Segoe UI", 10); // Solujen fontti
            dgv.DefaultCellStyle.BackColor = Color.White; // Solujen taustaväri
            dgv.DefaultCellStyle.ForeColor = Color.Black; // Solujen tekstin väri
            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.LightGray; // Vaihdetaan parittomien rivien väri vaaleanharmaaksi

            dgv.BorderStyle = BorderStyle.None; // Poistetaan kehys
            dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal; // Solujen kehys

            dgv.DefaultCellStyle.SelectionBackColor = Color.DodgerBlue; // Valitun solun taustaväri
            dgv.DefaultCellStyle.SelectionForeColor = Color.White; // Valitun solun tekstin väri

            dgv.RowTemplate.Height = 28; // Rivien korkeus pikseleinä
            dgv.ColumnHeadersHeight = 35; // Päällysrivien korkeus pikseleinä

            dgv.RowHeadersVisible = false; // Piilotetaan rivinumerot
            dgv.AllowUserToAddRows = false; // Estetään rivien lisääminen
            dgv.ReadOnly = true; // Estetään solujen muokkaaminen
        }

        private void kalatiedotdatagridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Tuplaklikkaamalla solua, avautuu kyseisen kalan tiedot uuteen formiin ja datagridView:n tiedot siirtyvät uuteen formiin
        {
            if (e.RowIndex >= 0) // Tarkistetaan, että rivi on valittu
            {
                DataGridViewRow rivi = this.kalatiedotdataGridView.Rows[e.RowIndex];
                string kalanimi = rivi.Cells["Kalan nimi"].Value.ToString();
                string tyypillinenkoko = rivi.Cells["Tyypillinen pituus"].Value.ToString();
                string tyypillinenpaino = rivi.Cells["Tyypillinen paino"].Value.ToString();
                string alamitta = rivi.Cells["Alamitta"].Value.ToString();
                string elinymparisto = rivi.Cells["Elinympäristö"].Value.ToString();
                string kuvaus = rivi.Cells["Kuvaus"].Value.ToString();
                string kuva = rivi.Cells["kalakuva"].Value.ToString();
                kayttaja_tarkastelekalalaji tarkastelekalalaji = new kayttaja_tarkastelekalalaji(kalanimi, tyypillinenkoko, tyypillinenpaino, alamitta, elinymparisto, kuvaus, kuva, yhteys, userID);
                tarkastelekalalaji.Show();
                this.Close();
            }
        }

        private void kirjauduUlosNappi_Click(object sender, EventArgs e) // Kirjaa käyttäjä ulos
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti kirjautua ulos?", "Vahvista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                kirjaudu kirjauduSisään = new kirjaudu();
                kirjauduSisään.Show();
                this.Close();
            }
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje ohjelma
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti sulkea ohjelman?", "Vahvista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void etusivuNappi_Click(object sender, EventArgs e) // Avaa etusivu-form
        {
            kayttaja_etusivu kayttajaEtusivu = new kayttaja_etusivu(yhteys, userID);
            kayttajaEtusivu.Show();
            this.Close();
        }

        private void omatsaaliitNappi_Click(object sender, EventArgs e) // Avaa omat saaliit-form
        {
            kayttaja_omatsaaliit omatsaaliit = new kayttaja_omatsaaliit(yhteys, userID);
            omatsaaliit.Show();
            this.Close();
        }

        private void kalastuspaikatNappi_Click(object sender, EventArgs e) // Avaa kalastuspaikat-form
        {
            kayttaja_kalastuspaikat kalastuspaikat = new kayttaja_kalastuspaikat(yhteys, userID);
            kalastuspaikat.Show();
            this.Close();
        }
    }
}
