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
    public partial class admin_kalastuspaikat_poista_kalastuspaikka : Form
    {
        string userID;
        MySqlConnection yhteys;
        public admin_kalastuspaikat_poista_kalastuspaikka(MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            userID = uID;
            yhteys = yhteysOlio;
            LataaKalapaikat(); // Ladataan kalapaikat comboboxiin
            this.kalapaikatdataGridView.CellDoubleClick += new DataGridViewCellEventHandler(this.kalapaikatdatagridView_CellDoubleClick);
            // Tapahtuman laukaisija: Kun solua tuplaklikataan, avautuu kalastuspaikan poistoform
        }

        private void LataaVesistöt() // Kun hae-nappia klikataan, haetaan tietokannasta vesistöjen eli järvien, lampien ym. tiedot datagridView:n
        {
            try
            {
                if (yhteys.State != ConnectionState.Open)
                {
                    yhteys.Open();
                }

                string haeVesistot = "SELECT vesistö AS Vesistö, paikkaID AS PaikkaID, kaupunki AS Kaupunki, koordinaatit AS Koordinaatit," +
                " kalastusmenetelmä AS Kalastusmenetelmä, paikkakuvaus AS Paikkakuvaus, paikkakuva AS 'Kuva URL' FROM kalastuspaikka WHERE " +
                "kaupunki = @kaupunki ORDER BY vesistö ASC";
                MySqlCommand haeVesistotKomento = new MySqlCommand(haeVesistot, yhteys);
                haeVesistotKomento.Parameters.AddWithValue("@kaupunki", kalapaikatcomboBox.Text);
                MySqlDataAdapter vesistoAdapter = new MySqlDataAdapter(haeVesistotKomento);
                DataTable vesistoTaulu = new DataTable();
                vesistoAdapter.Fill(vesistoTaulu);
                kalapaikatdataGridView.DataSource = vesistoTaulu;
                kalapaikatdataGridView.Columns["Kaupunki"].Visible = false; // Piilotetaan Kaupunki-sarake
                TyylitaDataGridView(kalapaikatdataGridView);
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

        private void LataaKalapaikat() // Ladataan kalapaikat (kaupungit) comboboxiin
        {
            try
            {
                if (yhteys.State != ConnectionState.Open)
                {
                    yhteys.Open();
                }

                kalapaikatcomboBox.Items.Clear(); // Tyhjennetään combobox ennen uuden lataamista
                string haeKalapaikat = "SELECT DISTINCT kaupunki FROM kalastuspaikka"; // Jos tulee duplikaatteja, otetaan vain yksi osuma
                MySqlCommand haeKalapaikatKomento = new MySqlCommand(haeKalapaikat, yhteys);
                MySqlDataReader kalapaikkaLukija = haeKalapaikatKomento.ExecuteReader();
                while (kalapaikkaLukija.Read())
                {
                    string kaupunki = kalapaikkaLukija.GetString("kaupunki");
                    kalapaikatcomboBox.Items.Add(kaupunki);
                }
                kalapaikkaLukija.Close();
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

        private void kalapaikatdatagridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e) // Kun solua tuplaklikataan, avautuu kalastuspaikka form
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow rivi = this.kalapaikatdataGridView.Rows[e.RowIndex];
                string paikkaID = rivi.Cells["PaikkaID"].Value.ToString();
                string vesistö = rivi.Cells["Vesistö"].Value.ToString();
                string kaupunki = rivi.Cells["Kaupunki"].Value.ToString();
                string kalastusmenetelmä = rivi.Cells["Kalastusmenetelmä"].Value.ToString();
                string paikkakuvaus = rivi.Cells["Paikkakuvaus"].Value.ToString();
                string koordinaatit = rivi.Cells["Koordinaatit"].Value.ToString();
                string paikkakuva = rivi.Cells["Kuva URL"].Value.ToString();
                admin_kalastuspaikat_poista_poistakalastuspaikka admin_poistakalastuspaikka = new admin_kalastuspaikat_poista_poistakalastuspaikka
                (paikkaID, vesistö, kaupunki, kalastusmenetelmä, paikkakuvaus, koordinaatit, paikkakuva, yhteys, userID);
                admin_poistakalastuspaikka.Show();
                this.Close();
            }
        }

        private void suljeNappi_Click(object sender, EventArgs e) // Sulje form ja palaa admin_kalastuspaikat formiin
        {
            this.Close();
            admin_kalastuspaikat adminkalastuspaikat = new admin_kalastuspaikat(yhteys, userID);
            adminkalastuspaikat.Show();
        }

        private void haeNappi_Click(object sender, EventArgs e) // Suorittaa LataaVesistöt()-metodin, joka lataa vesistöt datagridView:n
        {
            LataaVesistöt();
        }
    }
}
