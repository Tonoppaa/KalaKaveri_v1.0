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
    public partial class kayttaja_kalastuspaikat : Form
    {
        string userID;
        MySqlConnection yhteys;
        public kayttaja_kalastuspaikat(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            userID = uID;
            yhteys = yhteysOlio;
            LataaKalapaikat(); // Ladataan kalapaikat comboboxiin, kun form latautuu
            this.kalapaikatdataGridView.CellDoubleClick += new DataGridViewCellEventHandler(this.kalapaikatdatagridView_CellDoubleClick);
        }

        private void LataaKalapaikat() // Ladataan kalapaikat (kaupungit) comboboxiin
        {
            try
            {
                yhteys.Open();
                {
                    string haeKalapaikat = "SELECT DISTINCT kaupunki FROM kalastuspaikka ORDER BY kaupunki ASC"; // Erotellaan duplikaatit kaupunkien nimistä
                    MySqlCommand haeKalapaikatKomento = new MySqlCommand(haeKalapaikat, yhteys);
                    MySqlDataReader kalapaikkaLukija = haeKalapaikatKomento.ExecuteReader();
                    while (kalapaikkaLukija.Read())
                    {
                        string kaupunki = kalapaikkaLukija.GetString("kaupunki");
                        kalapaikatcomboBox.Items.Add(kaupunki);
                    }
                    kalapaikkaLukija.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe kalapaikkojen lataamisessa: " + ex.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void LataaVesistöt() // Lataa vesistön tiedot formin kenttiin
        {
            try
            {
                yhteys.Open();
                {
                    string haeVesistot = "SELECT kaupunki, vesistö AS Vesistö, kalastusmenetelmä AS Kalastusmenetelmä, koordinaatit AS Koordinaatit, " +
                    "paikkakuvaus AS Paikkakuvaus, paikkakuva FROM kalastuspaikka WHERE kaupunki = @kaupunki ORDER BY vesistö ASC";
                    MySqlCommand haeVesistotKomento = new MySqlCommand(haeVesistot, yhteys);
                    haeVesistotKomento.Parameters.AddWithValue("@kaupunki", kalapaikatcomboBox.Text);
                    MySqlDataAdapter vesistoAdapter = new MySqlDataAdapter(haeVesistotKomento);
                    DataTable vesistoTaulu = new DataTable();
                    vesistoAdapter.Fill(vesistoTaulu);
                    TyylitaDataGridView(kalapaikatdataGridView);
                    kalapaikatdataGridView.DataSource = vesistoTaulu;
                    kalapaikatdataGridView.Columns["kaupunki"].Visible = false; // Piilotetaan kaupunki, kaupunki näkyy comboboxissa
                    kalapaikatdataGridView.Columns["paikkakuva"].Visible = false; // Piilotetaan paikkakuva, sisältää vain kuvan URL, ei oleellinen tieto käyttäjälle
                    kalapaikatdataGridView.Columns["Vesistö"].Width = 150; // Vesistö-kentän leveys pikseleinä
                    kalapaikatdataGridView.Columns["Koordinaatit"].Width = 120;
                    kalapaikatdataGridView.Columns["Kalastusmenetelmä"].Width = 180; // Kalastusmenetelmä-kentän leveys pikseleinä
                    kalapaikatdataGridView.Columns["Paikkakuvaus"].Width = 145; // Paikkakuvaus-kentän leveys pikseleinä
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Tapahtui virhe vesistöjen lataamisessa: " + ex.Message);
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

        private void kalapaikatdatagridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Kun solua tuplaklikataan, avautuu kalastuspaikka form
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rivi = this.kalapaikatdataGridView.Rows[e.RowIndex];
                string vesistö = rivi.Cells["vesistö"].Value.ToString();
                string kaupunki = rivi.Cells["kaupunki"].Value.ToString();
                string kalastusmenetelmä = rivi.Cells["kalastusmenetelmä"].Value.ToString();
                string paikkakuvaus = rivi.Cells["Paikkakuvaus"].Value.ToString();
                string koordinaatit = rivi.Cells["koordinaatit"].Value.ToString();
                string paikkakuva = rivi.Cells["paikkakuva"].Value.ToString();
                kayttaja_tarkastelekalastuspaikka tarkasteleKalastuspaikka = new kayttaja_tarkastelekalastuspaikka(vesistö, kaupunki, kalastusmenetelmä, paikkakuvaus, koordinaatit, paikkakuva, yhteys, userID);
                tarkasteleKalastuspaikka.Show();
            }
        }

        private void haeNappi_Click(object sender, EventArgs e) // Kun nappia klikataan, LataaVesistöt()-metodi suoritetaan
        {
            LataaVesistöt();
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

        private void kalapankkiNappi_Click(object sender, EventArgs e) // Avaa kalapankki-form
        {
            kayttaja_kalapankki kalapankki = new kayttaja_kalapankki(yhteys, userID);
            kalapankki.Show();
            this.Close();
        }

        private void kirjauduUlosNappi_Click(object sender, EventArgs e) // Kirjaa käyttäjä ulos
        {
            DialogResult vahvistus = MessageBox.Show("Haluatko varmasti kirjautua ulos?", "Vahvista", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (vahvistus == DialogResult.Yes)
            {
                kirjaudu kirjauduUlos = new kirjaudu();
                kirjauduUlos.Show();
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
    }
}
