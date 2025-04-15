namespace KalaKaveri_v1
{
    partial class admin_kalastuspaikat_muokkaa_muokkaakalastuspaikka
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_kalastuspaikat_muokkaa_muokkaakalastuspaikka));
            paikkaIDtextBox = new TextBox();
            label8 = new Label();
            muokkaaKalastuspaikkabutton = new Button();
            panel1 = new Panel();
            label2 = new Label();
            suljeNappi = new Button();
            label7 = new Label();
            paikkakuvausrichTextBox = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            kalastusmenetelmärichTextBox = new RichTextBox();
            kaupunkitextBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            vesistötextBox = new TextBox();
            vesistöpictureBox = new PictureBox();
            koordinaatittextBox = new TextBox();
            label4 = new Label();
            label9 = new Label();
            muutaTietojabutton = new Button();
            poistaKuvabutton = new Button();
            muutaKuvabutton = new Button();
            label12 = new Label();
            imgurUrltextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vesistöpictureBox).BeginInit();
            SuspendLayout();
            // 
            // paikkaIDtextBox
            // 
            paikkaIDtextBox.Location = new Point(464, 137);
            paikkaIDtextBox.Name = "paikkaIDtextBox";
            paikkaIDtextBox.ReadOnly = true;
            paikkaIDtextBox.Size = new Size(327, 27);
            paikkaIDtextBox.TabIndex = 61;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(459, 114);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 60;
            label8.Text = "PaikkaID:";
            // 
            // muokkaaKalastuspaikkabutton
            // 
            muokkaaKalastuspaikkabutton.Location = new Point(32, 605);
            muokkaaKalastuspaikkabutton.Name = "muokkaaKalastuspaikkabutton";
            muokkaaKalastuspaikkabutton.Size = new Size(759, 53);
            muokkaaKalastuspaikkabutton.TabIndex = 59;
            muokkaaKalastuspaikkabutton.Text = "Muokkaa kalastuspaikan tietoja";
            muokkaaKalastuspaikkabutton.UseVisualStyleBackColor = true;
            muokkaaKalastuspaikkabutton.Visible = false;
            muokkaaKalastuspaikkabutton.Click += muokkaaKalastuspaikkabutton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(suljeNappi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(828, 48);
            panel1.TabIndex = 46;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.White;
            label2.Location = new Point(12, 14);
            label2.Name = "label2";
            label2.Size = new Size(79, 20);
            label2.TabIndex = 4;
            label2.Text = "KalaKaveri";
            // 
            // suljeNappi
            // 
            suljeNappi.BackgroundImage = (Image)resources.GetObject("suljeNappi.BackgroundImage");
            suljeNappi.BackgroundImageLayout = ImageLayout.Center;
            suljeNappi.Dock = DockStyle.Right;
            suljeNappi.FlatAppearance.BorderSize = 0;
            suljeNappi.FlatStyle = FlatStyle.Flat;
            suljeNappi.Location = new Point(781, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(464, 348);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 57;
            label7.Text = "Koordinaatit:";
            // 
            // paikkakuvausrichTextBox
            // 
            paikkakuvausrichTextBox.Location = new Point(32, 473);
            paikkakuvausrichTextBox.Name = "paikkakuvausrichTextBox";
            paikkakuvausrichTextBox.ReadOnly = true;
            paikkakuvausrichTextBox.Size = new Size(759, 117);
            paikkakuvausrichTextBox.TabIndex = 56;
            paikkakuvausrichTextBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 450);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 55;
            label6.Text = "Paikan kuvaus:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 337);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 54;
            // 
            // kalastusmenetelmärichTextBox
            // 
            kalastusmenetelmärichTextBox.Location = new Point(464, 273);
            kalastusmenetelmärichTextBox.Name = "kalastusmenetelmärichTextBox";
            kalastusmenetelmärichTextBox.ReadOnly = true;
            kalastusmenetelmärichTextBox.Size = new Size(327, 54);
            kalastusmenetelmärichTextBox.TabIndex = 52;
            kalastusmenetelmärichTextBox.Text = "";
            // 
            // kaupunkitextBox
            // 
            kaupunkitextBox.Location = new Point(464, 202);
            kaupunkitextBox.Name = "kaupunkitextBox";
            kaupunkitextBox.ReadOnly = true;
            kaupunkitextBox.Size = new Size(327, 27);
            kaupunkitextBox.TabIndex = 51;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 179);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 50;
            label3.Text = "Kaupunki:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 114);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 49;
            label1.Text = "Kalastuspaikka:";
            // 
            // vesistötextBox
            // 
            vesistötextBox.Location = new Point(32, 137);
            vesistötextBox.Name = "vesistötextBox";
            vesistötextBox.ReadOnly = true;
            vesistötextBox.Size = new Size(365, 27);
            vesistötextBox.TabIndex = 48;
            // 
            // vesistöpictureBox
            // 
            vesistöpictureBox.Location = new Point(32, 170);
            vesistöpictureBox.Name = "vesistöpictureBox";
            vesistöpictureBox.Size = new Size(365, 227);
            vesistöpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            vesistöpictureBox.TabIndex = 47;
            vesistöpictureBox.TabStop = false;
            // 
            // koordinaatittextBox
            // 
            koordinaatittextBox.Location = new Point(464, 371);
            koordinaatittextBox.Name = "koordinaatittextBox";
            koordinaatittextBox.ReadOnly = true;
            koordinaatittextBox.Size = new Size(327, 27);
            koordinaatittextBox.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 250);
            label4.Name = "label4";
            label4.Size = new Size(194, 20);
            label4.TabIndex = 53;
            label4.Text = "Sallitut kalastusmenetelmät:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(16, 68);
            label9.Name = "label9";
            label9.Size = new Size(582, 35);
            label9.TabIndex = 62;
            label9.Text = "Kalastuspaikka - Muokkaa kalastuspaikan tietoja";
            // 
            // muutaTietojabutton
            // 
            muutaTietojabutton.Location = new Point(161, 403);
            muutaTietojabutton.Name = "muutaTietojabutton";
            muutaTietojabutton.Size = new Size(106, 29);
            muutaTietojabutton.TabIndex = 106;
            muutaTietojabutton.Text = "Muuta tietoja";
            muutaTietojabutton.UseVisualStyleBackColor = true;
            muutaTietojabutton.Click += muutaTietojabutton_Click;
            // 
            // poistaKuvabutton
            // 
            poistaKuvabutton.BackgroundImage = (Image)resources.GetObject("poistaKuvabutton.BackgroundImage");
            poistaKuvabutton.BackgroundImageLayout = ImageLayout.Zoom;
            poistaKuvabutton.Location = new Point(403, 370);
            poistaKuvabutton.Name = "poistaKuvabutton";
            poistaKuvabutton.Size = new Size(30, 29);
            poistaKuvabutton.TabIndex = 107;
            poistaKuvabutton.UseVisualStyleBackColor = true;
            poistaKuvabutton.Visible = false;
            poistaKuvabutton.Click += poistaKuvabutton_Click;
            // 
            // muutaKuvabutton
            // 
            muutaKuvabutton.Location = new Point(32, 403);
            muutaKuvabutton.Name = "muutaKuvabutton";
            muutaKuvabutton.Size = new Size(99, 29);
            muutaKuvabutton.TabIndex = 108;
            muutaKuvabutton.Text = "Vaihda kuva";
            muutaKuvabutton.UseVisualStyleBackColor = true;
            muutaKuvabutton.Visible = false;
            muutaKuvabutton.Click += muutaKuvabutton_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(464, 418);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 110;
            label12.Text = "imgur url:";
            // 
            // imgurUrltextBox
            // 
            imgurUrltextBox.Location = new Point(542, 415);
            imgurUrltextBox.Name = "imgurUrltextBox";
            imgurUrltextBox.ReadOnly = true;
            imgurUrltextBox.Size = new Size(249, 27);
            imgurUrltextBox.TabIndex = 109;
            // 
            // admin_kalastuspaikat_muokkaa_muokkaakalastuspaikka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 675);
            Controls.Add(label12);
            Controls.Add(imgurUrltextBox);
            Controls.Add(muutaKuvabutton);
            Controls.Add(poistaKuvabutton);
            Controls.Add(muutaTietojabutton);
            Controls.Add(label9);
            Controls.Add(paikkaIDtextBox);
            Controls.Add(label8);
            Controls.Add(muokkaaKalastuspaikkabutton);
            Controls.Add(panel1);
            Controls.Add(label7);
            Controls.Add(paikkakuvausrichTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(kalastusmenetelmärichTextBox);
            Controls.Add(kaupunkitextBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(vesistötextBox);
            Controls.Add(vesistöpictureBox);
            Controls.Add(koordinaatittextBox);
            Controls.Add(label4);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_kalastuspaikat_muokkaa_muokkaakalastuspaikka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_kalastuspaikat_muokkaa_muokkaakalastuspaikka";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vesistöpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox paikkaIDtextBox;
        private Label label8;
        private Button muokkaaKalastuspaikkabutton;
        private Panel panel1;
        private Label label2;
        private Button suljeNappi;
        private Label label7;
        private RichTextBox paikkakuvausrichTextBox;
        private Label label6;
        private Label label5;
        private RichTextBox kalastusmenetelmärichTextBox;
        private TextBox kaupunkitextBox;
        private Label label3;
        private Label label1;
        private TextBox vesistötextBox;
        private PictureBox vesistöpictureBox;
        private TextBox koordinaatittextBox;
        private Label label4;
        private Label label9;
        private Button muutaTietojabutton;
        private Button poistaKuvabutton;
        private Button muutaKuvabutton;
        private Label label12;
        private TextBox imgurUrltextBox;
    }
}