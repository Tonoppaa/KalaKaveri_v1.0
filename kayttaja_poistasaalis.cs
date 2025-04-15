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
    public partial class kayttaja_poistasaalis : Form
    {
        string userID;
        MySqlConnection yhteys;
        public kayttaja_poistasaalis(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            userID = uID;
            yhteys = yhteysOlio;
            LataaSaalis(); // Suorita metodi
            this.omatsaaliitdataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.omatsaaliitdataGridView_CellDoubleClick);
        }

        private void LataaSaalis() // Metodi, jonka avulla ladataan käyttäjän saaliit datagridview:n
        {
            try
            {
                yhteys.Open();
                {
                    string haeSaalis = $"SELECT kalanimi AS Kala, kaupunki AS Kaupunki, vesistö AS Sijainti, " +
                    $"pituus AS Pituus, paino AS Paino, pvm AS Päivämäärä, sää AS Sää, lisätiedot AS Lisätiedot, saaliskuva" +
                    $", saalis_ID FROM saalis, kalalaji, kayttaja, kalastuspaikka WHERE kayttaja_ID = @kayttaja_ID AND" +
                    $" kala_ID = kalaID AND paikka_ID = paikkaID AND kayttaja_ID = kayttajaID";
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
                    omatsaaliitdataGridView.Columns["saaliskuva"].Visible = false; // Ei tärkeä tieto käyttäjälle, siksi piilotetaan; sisältää URL-osoitteen
                    omatsaaliitdataGridView.Columns["saalis_ID"].Visible = false; // Ei tärkeä tieto käyttäjälle, siksi piilotetaan; sisältää saalis_ID:n
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe tietojen lataamisessa: " + ex.Message);
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

        private void omatsaaliitdataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Tuplaklikkaamalla solua avautuu saaliskorttipoista-form
        {
            if (e.RowIndex >= 0) // Tarkistetaan, että rivi on valittu
            {
                DataGridViewRow valittuRivi = this.omatsaaliitdataGridView.Rows[e.RowIndex]; // Valitaan rivi, jota tuplaklikataan
                string kalanimi = valittuRivi.Cells["Kala"].Value.ToString();
                string kaupunki = valittuRivi.Cells["Kaupunki"].Value.ToString();
                string vesistö = valittuRivi.Cells["Sijainti"].Value.ToString();
                string pituus = valittuRivi.Cells["Pituus"].Value.ToString();
                string paino = valittuRivi.Cells["Paino"].Value.ToString();
                string pvm = Convert.ToDateTime(valittuRivi.Cells["Päivämäärä"].Value).ToString("dd.MM.yyyy");
                string sää = valittuRivi.Cells["Sää"].Value.ToString();
                string lisätiedot = valittuRivi.Cells["Lisätiedot"].Value.ToString();
                string saaliskuva = valittuRivi.Cells["saaliskuva"].Value.ToString();
                string saalisID = valittuRivi.Cells["saalis_ID"].Value.ToString();
                kayttaja_saaliskorttipoista saalisKorttiPoista = new kayttaja_saaliskorttipoista(kalanimi, kaupunki, vesistö, pituus, paino, pvm, sää, lisätiedot, saaliskuva, saalisID, yhteys, userID);
                saalisKorttiPoista.Show();
                this.Close();
            }
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje ikkuna ja avaa edellinen form
        {
            this.Close();
            kayttaja_omatsaaliit omatsaaliit = new kayttaja_omatsaaliit(yhteys, userID);
            omatsaaliit.Show();
        }
    }
}
