using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalaKaveri_v1
{
    public partial class kayttaja_tarkastelekalalaji : Form
    {
        string userID;
        MySqlConnection yhteys;
        public kayttaja_tarkastelekalalaji(string kalanimi, string tyypillinenkoko, string tyypillinenpaino, string alamitta, string elinymparisto, string kuvaus, string kalakuva, MySqlConnection yhteysOlio, string uID)
        {
            InitializeComponent();
            kalanimitextBox.Text = kalanimi;
            tyypillinenkokotextBox.Text = tyypillinenkoko;
            tyypillinenpainotextBox.Text = tyypillinenpaino;
            alamittatextBox.Text = alamitta;
            elinympäristötextBox.Text = elinymparisto;
            kalakuvausrichTextBox.Text = kuvaus;
            yhteys = yhteysOlio;
            userID = uID;
            LataaKuva(kalakuva);

        }
        private void LataaKuva(string valittukalakuva)
        {
            try
            {
                yhteys.Open();
                {
                    using (WebClient webClient = new WebClient())
                    {
                        byte[] kuvaData = webClient.DownloadData(valittukalakuva);
                        using (var stream = new MemoryStream(kuvaData))
                        {
                            kalapictureBox.Image = Image.FromStream(stream);
                        }
                    }
                }
            }
            catch (Exception x)
            {
                MessageBox.Show("Tapahtui virhe kuvan haussa: " + x.Message);
            }
            finally
            {
                yhteys.Close();
            }
        }

        private void suljeNappi_Click(object sender, EventArgs e)
        {
            this.Close();
            kayttaja_kalapankki kalapankki = new kayttaja_kalapankki(yhteys, userID);
            kalapankki.Show();
        }
    }
}
