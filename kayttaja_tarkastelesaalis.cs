using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto;
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
    public partial class kayttaja_tarkastelesaalis : Form
    {
        string userID;
        MySqlConnection yhteys;
        public kayttaja_tarkastelesaalis(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            userID = uID;
            yhteys = yhteysOlio;
            LataaSaalis();
            this.omatsaaliitdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.omatsaaliitdataGridView_CellDoubleClick);
        }

        private void LataaSaalis() // Lataa käyttäjän saaliit datagridView:n
        {
            try
            {
                if (yhteys.State != ConnectionState.Open) // Tarkistetaan onko yhteys auki; tarkistus tarvitaan, kun palataan tähän formiin takaisin saaliskortista
                {
                    yhteys.Open();
                }
                string haeSaalis = $"SELECT pvm AS Päivämäärä, kalanimi AS Kala, kalaID, paikkaID, kaupunki AS Kaupunki, vesistö AS Vesistö, " +
                $"saalis_ID, pituus AS Pituus, paino AS Paino, sää AS Sää, lisätiedot AS Lisätiedot, saaliskuva" +
                $" FROM saalis, kalalaji, kayttaja, kalastuspaikka WHERE kayttaja_ID = @kayttaja_ID AND" +
                $" kala_ID = kalaID AND paikka_ID = paikkaID AND kayttaja_ID = kayttajaID ORDER BY pvm DESC";
                MySqlCommand tietueKysely = new MySqlCommand(haeSaalis, yhteys);
                tietueKysely.Parameters.AddWithValue("@kayttaja_ID", userID);
                MySqlDataAdapter täyttäjä = new MySqlDataAdapter(tietueKysely);
                DataTable saalisTaulu = new DataTable();
                täyttäjä.Fill(saalisTaulu);
                TyylitaDataGridView(omatsaaliitdataGridView);
                omatsaaliitdataGridView.DataSource = saalisTaulu;
                omatsaaliitdataGridView.Columns["Kala"].Width = 85; // Kala-kentän leveys pikseleinä
                omatsaaliitdataGridView.Columns["Pituus"].Width = 70; // Pituus-kentän leveys pikseleinä
                omatsaaliitdataGridView.Columns["Paino"].Width = 70; // Paino-kentän leveys pikseleinä
                omatsaaliitdataGridView.Columns["Sää"].Width = 60; // Päivämäärä-kentän leveys pikseleinä
                omatsaaliitdataGridView.Columns["saaliskuva"].Visible = false; // Piilotetaan saaliskuva-sarake, ei tärke tieto käyttäjälle (sisältää vain URL:n)
                omatsaaliitdataGridView.Columns["kalaID"].Visible = false; // Piilotetaan kalaID-sarake, ei tärke tieto käyttäjälle
                omatsaaliitdataGridView.Columns["paikkaID"].Visible = false; // Piilotetaan paikkaID-sarake, ei tärke tieto käyttäjälle
                omatsaaliitdataGridView.Columns["saalis_ID"].Visible = false; // Piilotetaan saalis_ID-sarake, ei tärke tieto käyttäjälle
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe: " + ex.Message);
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

        private void omatsaaliitdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Tuplaklikkaamalla solua avautuu saaliskortti
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow valittuRivi = omatsaaliitdataGridView.Rows[e.RowIndex];
                string kalanimi = valittuRivi.Cells["Kala"].Value.ToString();
                string kaupunki = valittuRivi.Cells["Kaupunki"].Value.ToString();
                string vesistö = valittuRivi.Cells["Vesistö"].Value.ToString();
                string pituus = valittuRivi.Cells["Pituus"].Value.ToString();
                string paino = valittuRivi.Cells["Paino"].Value.ToString();
                string pvm = Convert.ToDateTime(valittuRivi.Cells["Päivämäärä"].Value).ToString("dd.MM.yyyy");
                string sää = valittuRivi.Cells["Sää"].Value.ToString();
                string lisätiedot = valittuRivi.Cells["Lisätiedot"].Value.ToString();
                string saaliskuva = valittuRivi.Cells["saaliskuva"].Value.ToString();
                string kalaID = valittuRivi.Cells["kalaID"].Value.ToString();
                string paikkaID = valittuRivi.Cells["paikkaID"].Value.ToString();
                string saalis_ID = valittuRivi.Cells["saalis_ID"].Value.ToString();
                kayttaja_saaliskortti saalisKortti = new kayttaja_saaliskortti(kalanimi, kaupunki, vesistö, pituus, paino, pvm, sää, lisätiedot, saaliskuva, kalaID, paikkaID, saalis_ID, yhteys, userID);
                saalisKortti.Show();
                this.Close();
            }
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje tämä form ja avaa omatsaaliit-form
        {
            this.Close();
            kayttaja_omatsaaliit omatsaaliit = new kayttaja_omatsaaliit(yhteys, userID);
            omatsaaliit.Show();
        }
    }
}