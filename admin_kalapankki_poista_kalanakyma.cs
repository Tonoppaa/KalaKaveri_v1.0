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
    public partial class admin_kalapankki_poista_kalanakyma : Form
    {
        MySqlConnection yhteys;
        string userID;
        public admin_kalapankki_poista_kalanakyma(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            yhteys = yhteysOlio;
            userID = uID;
            LataaKalat();
            this.kalatiedotdataGridView.CellDoubleClick += new DataGridViewCellEventHandler(this.kalatiedotdatagridview_CellDoubleClick);
            // Tämä rivi yhdistää datagridviewin tuplaklikkauksen tapahtuman omaan metodiin
        }

        private void LataaKalat() // Lataa kalat tietokannasta ja näyttää ne datagridviewissä
        {
            try
            {
                yhteys.Open();
                {
                    string haeKalat = "SELECT kalanimi AS 'Kalan nimi', kalaID AS 'Kalan ID', tyypillinenkoko AS 'Tyypillinen pituus', " +
                    "tyypillinenpaino AS 'Tyypillinen paino', alamitta AS Alamitta, elinympäristö AS Elinympäristö, kalakuvaus " +
                    "AS Kuvaus, kalakuva AS 'Kuva URL' FROM kalalaji ORDER BY kalanimi ASC";
                    MySqlCommand haeKalatKomento = new MySqlCommand(haeKalat, yhteys);
                    MySqlDataAdapter kalatAdapter = new MySqlDataAdapter(haeKalatKomento);
                    DataTable kalatTable = new DataTable();
                    kalatAdapter.Fill(kalatTable);
                    kalatiedotdataGridView.DataSource = kalatTable;
                    TyylitaDataGridView(kalatiedotdataGridView);
                    kalatiedotdataGridView.Columns["Kalan ID"].Width = 110; // Kalan ID-kentän leveys pikseleinä
                    kalatiedotdataGridView.Columns["Kalan nimi"].Width = 90; // Kalan nimi-kentän leveys pikseleinä
                    kalatiedotdataGridView.Columns["Tyypillinen pituus"].Width = 100; // Tyypillinen pituus-kentän leveys pikseleinä
                    kalatiedotdataGridView.Columns["Tyypillinen paino"].Width = 100; // Tyypillinen paino-kentän leveys pikseleinä
                    kalatiedotdataGridView.Columns["Alamitta"].Width = 80; // Alamitta-kentän leveys pikseleinä
                    kalatiedotdataGridView.Columns["Elinympäristö"].Width = 120; // Elinympäristö-kentän leveys pikseleinä
                    kalatiedotdataGridView.Columns["Kuvaus"].Width = 75; // Kuvaus-kentän leveys pikseleinä
                    kalatiedotdataGridView.Columns["Kuva URL"].Width = 57; // Kalakuva-kentän leveys pikseleinä
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

        private void kalatiedotdatagridview_CellDoubleClick(object sender, DataGridViewCellEventArgs e) /* Solua tuplaklikkaamalla avataan uusi ikkuna ja
                                                                                            viedään datagridViewin rivin tiedot seuraavan formin kenttiin */
        {
            if (e.RowIndex >= 0) // Tarkistus, että rivi on valittu
            {
                DataGridViewRow rivi = this.kalatiedotdataGridView.Rows[e.RowIndex];
                string kalaID = rivi.Cells["Kalan ID"].Value.ToString();
                string kalanimi = rivi.Cells["Kalan nimi"].Value.ToString();
                string tyypillinenkoko = rivi.Cells["Tyypillinen pituus"].Value.ToString();
                string tyypillinenpaino = rivi.Cells["Tyypillinen paino"].Value.ToString();
                string alamitta = rivi.Cells["Alamitta"].Value.ToString();
                string elinymparisto = rivi.Cells["Elinympäristö"].Value.ToString();
                string kuvaus = rivi.Cells["Kuvaus"].Value.ToString();
                string kuva = rivi.Cells["Kuva URL"].Value.ToString();
                admin_kalapankki_poista_poistakala poistakala_kalapankki = new admin_kalapankki_poista_poistakala(kalaID, kalanimi, tyypillinenkoko, tyypillinenpaino, alamitta, elinymparisto, kuvaus, kuva, yhteys, userID);
                poistakala_kalapankki.Show();
                this.Close();
            }
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Nappia painamalla form sulkeutuu ja palaa Adminin kalapankki-formiin
        {
            this.Close();
            admin_kalapankki adminkalapankki = new admin_kalapankki(yhteys, userID);
            adminkalapankki.Show();
        }
    }
}
