namespace KalaKaveri_v1
{
    partial class admin_käyttäjähallinta_poista_käyttäjä
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_käyttäjähallinta_poista_käyttäjä));
            panel1 = new Panel();
            label2 = new Label();
            suljeNappi = new Button();
            panel2 = new Panel();
            käyttäjädataGridView = new DataGridView();
            label1 = new Label();
            haeKayttajaIDbutton = new Button();
            label3 = new Label();
            kayttajaIDtextBox = new TextBox();
            etunimitextBox = new TextBox();
            haeKokonimibutton = new Button();
            label4 = new Label();
            emailtextBox = new TextBox();
            haeEmailbutton = new Button();
            label5 = new Label();
            osoitetextBox = new TextBox();
            haeOsoitebutton = new Button();
            label6 = new Label();
            haeKaikkiKäyttäjätbutton = new Button();
            tyhjennäTaulubutton = new Button();
            sukunimitextBox = new TextBox();
            tyhjennäKentätbutton = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)käyttäjädataGridView).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(suljeNappi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(919, 48);
            panel1.TabIndex = 63;
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
            suljeNappi.Location = new Point(872, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(käyttäjädataGridView);
            panel2.Location = new Point(389, 132);
            panel2.Name = "panel2";
            panel2.Size = new Size(504, 338);
            panel2.TabIndex = 68;
            // 
            // käyttäjädataGridView
            // 
            käyttäjädataGridView.AllowUserToAddRows = false;
            käyttäjädataGridView.AllowUserToDeleteRows = false;
            käyttäjädataGridView.AllowUserToResizeColumns = false;
            käyttäjädataGridView.AllowUserToResizeRows = false;
            käyttäjädataGridView.BackgroundColor = Color.White;
            käyttäjädataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            käyttäjädataGridView.GridColor = Color.LightGray;
            käyttäjädataGridView.Location = new Point(3, 0);
            käyttäjädataGridView.MultiSelect = false;
            käyttäjädataGridView.Name = "käyttäjädataGridView";
            käyttäjädataGridView.ReadOnly = true;
            käyttäjädataGridView.RowHeadersWidth = 51;
            käyttäjädataGridView.Size = new Size(498, 323);
            käyttäjädataGridView.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(41, 67);
            label1.Name = "label1";
            label1.Size = new Size(406, 31);
            label1.TabIndex = 64;
            label1.Text = "Valitse käyttäjä, jonka haluat poistaa";
            // 
            // haeKayttajaIDbutton
            // 
            haeKayttajaIDbutton.Location = new Point(302, 189);
            haeKayttajaIDbutton.Name = "haeKayttajaIDbutton";
            haeKayttajaIDbutton.Size = new Size(45, 29);
            haeKayttajaIDbutton.TabIndex = 67;
            haeKayttajaIDbutton.Text = "Hae";
            haeKayttajaIDbutton.UseVisualStyleBackColor = true;
            haeKayttajaIDbutton.Click += haeKayttajaIDbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(41, 167);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 65;
            label3.Text = "Hae käyttäjänimellä";
            // 
            // kayttajaIDtextBox
            // 
            kayttajaIDtextBox.Location = new Point(41, 190);
            kayttajaIDtextBox.MaxLength = 12;
            kayttajaIDtextBox.Name = "kayttajaIDtextBox";
            kayttajaIDtextBox.PlaceholderText = "Esim. muodossa 'USER000001'";
            kayttajaIDtextBox.Size = new Size(255, 27);
            kayttajaIDtextBox.TabIndex = 69;
            // 
            // etunimitextBox
            // 
            etunimitextBox.Location = new Point(41, 274);
            etunimitextBox.Name = "etunimitextBox";
            etunimitextBox.PlaceholderText = "Etunimi";
            etunimitextBox.Size = new Size(113, 27);
            etunimitextBox.TabIndex = 72;
            // 
            // haeKokonimibutton
            // 
            haeKokonimibutton.Location = new Point(302, 273);
            haeKokonimibutton.Name = "haeKokonimibutton";
            haeKokonimibutton.Size = new Size(45, 29);
            haeKokonimibutton.TabIndex = 71;
            haeKokonimibutton.Text = "Hae";
            haeKokonimibutton.UseVisualStyleBackColor = true;
            haeKokonimibutton.Click += haeKokonimibutton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 251);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 70;
            label4.Text = "Hae käyttäjän nimellä";
            // 
            // emailtextBox
            // 
            emailtextBox.Location = new Point(41, 444);
            emailtextBox.Name = "emailtextBox";
            emailtextBox.PlaceholderText = "etunimi.sukunimi@osoite.com";
            emailtextBox.Size = new Size(255, 27);
            emailtextBox.TabIndex = 75;
            // 
            // haeEmailbutton
            // 
            haeEmailbutton.Location = new Point(302, 443);
            haeEmailbutton.Name = "haeEmailbutton";
            haeEmailbutton.Size = new Size(45, 29);
            haeEmailbutton.TabIndex = 74;
            haeEmailbutton.Text = "Hae";
            haeEmailbutton.UseVisualStyleBackColor = true;
            haeEmailbutton.Click += haeEmailbutton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 421);
            label5.Name = "label5";
            label5.Size = new Size(191, 20);
            label5.TabIndex = 73;
            label5.Text = "Hae käyttäjän sähköpostilla";
            // 
            // osoitetextBox
            // 
            osoitetextBox.Location = new Point(41, 357);
            osoitetextBox.Name = "osoitetextBox";
            osoitetextBox.PlaceholderText = "Osoite";
            osoitetextBox.Size = new Size(255, 27);
            osoitetextBox.TabIndex = 78;
            // 
            // haeOsoitebutton
            // 
            haeOsoitebutton.Location = new Point(302, 356);
            haeOsoitebutton.Name = "haeOsoitebutton";
            haeOsoitebutton.Size = new Size(45, 29);
            haeOsoitebutton.TabIndex = 77;
            haeOsoitebutton.Text = "Hae";
            haeOsoitebutton.UseVisualStyleBackColor = true;
            haeOsoitebutton.Click += haeOsoitebutton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 334);
            label6.Name = "label6";
            label6.Size = new Size(174, 20);
            label6.TabIndex = 76;
            label6.Text = "Hae käyttäjän osoitteella";
            // 
            // haeKaikkiKäyttäjätbutton
            // 
            haeKaikkiKäyttäjätbutton.Location = new Point(198, 132);
            haeKaikkiKäyttäjätbutton.Name = "haeKaikkiKäyttäjätbutton";
            haeKaikkiKäyttäjätbutton.Size = new Size(149, 29);
            haeKaikkiKäyttäjätbutton.TabIndex = 79;
            haeKaikkiKäyttäjätbutton.Text = "Hae kaikki käyttäjät";
            haeKaikkiKäyttäjätbutton.UseVisualStyleBackColor = true;
            haeKaikkiKäyttäjätbutton.Click += haeKaikkiKäyttäjätbutton_Click;
            // 
            // tyhjennäTaulubutton
            // 
            tyhjennäTaulubutton.Location = new Point(590, 97);
            tyhjennäTaulubutton.Name = "tyhjennäTaulubutton";
            tyhjennäTaulubutton.Size = new Size(114, 29);
            tyhjennäTaulubutton.TabIndex = 80;
            tyhjennäTaulubutton.Text = "Tyhjennä taulu";
            tyhjennäTaulubutton.UseVisualStyleBackColor = true;
            tyhjennäTaulubutton.Visible = false;
            tyhjennäTaulubutton.Click += tyhjennäTaulubutton_Click;
            // 
            // sukunimitextBox
            // 
            sukunimitextBox.Location = new Point(160, 275);
            sukunimitextBox.Name = "sukunimitextBox";
            sukunimitextBox.PlaceholderText = "Sukunimi";
            sukunimitextBox.Size = new Size(136, 27);
            sukunimitextBox.TabIndex = 81;
            // 
            // tyhjennäKentätbutton
            // 
            tyhjennäKentätbutton.Location = new Point(41, 132);
            tyhjennäKentätbutton.Name = "tyhjennäKentätbutton";
            tyhjennäKentätbutton.Size = new Size(120, 29);
            tyhjennäKentätbutton.TabIndex = 82;
            tyhjennäKentätbutton.Text = "Tyhjennä kentät";
            tyhjennäKentätbutton.UseVisualStyleBackColor = true;
            tyhjennäKentätbutton.Click += tyhjennäKentätbutton_Click;
            // 
            // admin_käyttäjähallinta_poista_käyttäjä
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(919, 510);
            Controls.Add(tyhjennäKentätbutton);
            Controls.Add(sukunimitextBox);
            Controls.Add(tyhjennäTaulubutton);
            Controls.Add(haeKaikkiKäyttäjätbutton);
            Controls.Add(osoitetextBox);
            Controls.Add(haeOsoitebutton);
            Controls.Add(label6);
            Controls.Add(emailtextBox);
            Controls.Add(haeEmailbutton);
            Controls.Add(label5);
            Controls.Add(etunimitextBox);
            Controls.Add(haeKokonimibutton);
            Controls.Add(label4);
            Controls.Add(kayttajaIDtextBox);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(haeKayttajaIDbutton);
            Controls.Add(label3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_käyttäjähallinta_poista_käyttäjä";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_käyttäjähallinta_poista_käyttäjä";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)käyttäjädataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button suljeNappi;
        private Panel panel2;
        private DataGridView käyttäjädataGridView;
        private Label label1;
        private Button haeKayttajaIDbutton;
        private Label label3;
        private TextBox kayttajaIDtextBox;
        private TextBox etunimitextBox;
        private Button haeKokonimibutton;
        private Label label4;
        private TextBox emailtextBox;
        private Button haeEmailbutton;
        private Label label5;
        private TextBox osoitetextBox;
        private Button haeOsoitebutton;
        private Label label6;
        private Button haeKaikkiKäyttäjätbutton;
        private Button tyhjennäTaulubutton;
        private TextBox sukunimitextBox;
        private Button tyhjennäKentätbutton;
    }
}