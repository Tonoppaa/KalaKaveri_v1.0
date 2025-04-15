namespace KalaKaveri_v1
{
    partial class admin_käyttäjähallinta_muokkaa_käyttäjä
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_käyttäjähallinta_muokkaa_käyttäjä));
            tyhjennäKentätbutton = new Button();
            sukunimitextBox = new TextBox();
            tyhjennäTaulubutton = new Button();
            haeKaikkiKäyttäjätbutton = new Button();
            osoitetextBox = new TextBox();
            haeOsoitebutton = new Button();
            label6 = new Label();
            emailtextBox = new TextBox();
            haeEmailbutton = new Button();
            label5 = new Label();
            etunimitextBox = new TextBox();
            haeKokonimibutton = new Button();
            kayttajaIDtextBox = new TextBox();
            label1 = new Label();
            haeKayttajaIDbutton = new Button();
            label3 = new Label();
            käyttäjädataGridView = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            suljeNappi = new Button();
            label4 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)käyttäjädataGridView).BeginInit();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // tyhjennäKentätbutton
            // 
            tyhjennäKentätbutton.Location = new Point(34, 140);
            tyhjennäKentätbutton.Name = "tyhjennäKentätbutton";
            tyhjennäKentätbutton.Size = new Size(120, 29);
            tyhjennäKentätbutton.TabIndex = 101;
            tyhjennäKentätbutton.Text = "Tyhjennä kentät";
            tyhjennäKentätbutton.UseVisualStyleBackColor = true;
            tyhjennäKentätbutton.Click += tyhjennäKentätbutton_Click;
            // 
            // sukunimitextBox
            // 
            sukunimitextBox.Location = new Point(153, 283);
            sukunimitextBox.Name = "sukunimitextBox";
            sukunimitextBox.PlaceholderText = "Sukunimi";
            sukunimitextBox.Size = new Size(136, 27);
            sukunimitextBox.TabIndex = 100;
            // 
            // tyhjennäTaulubutton
            // 
            tyhjennäTaulubutton.Location = new Point(583, 105);
            tyhjennäTaulubutton.Name = "tyhjennäTaulubutton";
            tyhjennäTaulubutton.Size = new Size(114, 29);
            tyhjennäTaulubutton.TabIndex = 99;
            tyhjennäTaulubutton.Text = "Tyhjennä taulu";
            tyhjennäTaulubutton.UseVisualStyleBackColor = true;
            tyhjennäTaulubutton.Visible = false;
            tyhjennäTaulubutton.Click += tyhjennäTaulubutton_Click;
            // 
            // haeKaikkiKäyttäjätbutton
            // 
            haeKaikkiKäyttäjätbutton.Location = new Point(191, 140);
            haeKaikkiKäyttäjätbutton.Name = "haeKaikkiKäyttäjätbutton";
            haeKaikkiKäyttäjätbutton.Size = new Size(149, 29);
            haeKaikkiKäyttäjätbutton.TabIndex = 98;
            haeKaikkiKäyttäjätbutton.Text = "Hae kaikki käyttäjät";
            haeKaikkiKäyttäjätbutton.UseVisualStyleBackColor = true;
            haeKaikkiKäyttäjätbutton.Click += haeKaikkiKäyttäjätbutton_Click;
            // 
            // osoitetextBox
            // 
            osoitetextBox.Location = new Point(34, 365);
            osoitetextBox.Name = "osoitetextBox";
            osoitetextBox.PlaceholderText = "Osoite";
            osoitetextBox.Size = new Size(255, 27);
            osoitetextBox.TabIndex = 97;
            // 
            // haeOsoitebutton
            // 
            haeOsoitebutton.Location = new Point(295, 364);
            haeOsoitebutton.Name = "haeOsoitebutton";
            haeOsoitebutton.Size = new Size(45, 29);
            haeOsoitebutton.TabIndex = 96;
            haeOsoitebutton.Text = "Hae";
            haeOsoitebutton.UseVisualStyleBackColor = true;
            haeOsoitebutton.Click += haeOsoitebutton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(34, 342);
            label6.Name = "label6";
            label6.Size = new Size(174, 20);
            label6.TabIndex = 95;
            label6.Text = "Hae käyttäjän osoitteella";
            // 
            // emailtextBox
            // 
            emailtextBox.Location = new Point(34, 452);
            emailtextBox.Name = "emailtextBox";
            emailtextBox.PlaceholderText = "etunimi.sukunimi@osoite.com";
            emailtextBox.Size = new Size(255, 27);
            emailtextBox.TabIndex = 94;
            // 
            // haeEmailbutton
            // 
            haeEmailbutton.Location = new Point(295, 451);
            haeEmailbutton.Name = "haeEmailbutton";
            haeEmailbutton.Size = new Size(45, 29);
            haeEmailbutton.TabIndex = 93;
            haeEmailbutton.Text = "Hae";
            haeEmailbutton.UseVisualStyleBackColor = true;
            haeEmailbutton.Click += haeEmailbutton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(34, 429);
            label5.Name = "label5";
            label5.Size = new Size(191, 20);
            label5.TabIndex = 92;
            label5.Text = "Hae käyttäjän sähköpostilla";
            // 
            // etunimitextBox
            // 
            etunimitextBox.Location = new Point(34, 282);
            etunimitextBox.Name = "etunimitextBox";
            etunimitextBox.PlaceholderText = "Etunimi";
            etunimitextBox.Size = new Size(113, 27);
            etunimitextBox.TabIndex = 91;
            // 
            // haeKokonimibutton
            // 
            haeKokonimibutton.Location = new Point(295, 281);
            haeKokonimibutton.Name = "haeKokonimibutton";
            haeKokonimibutton.Size = new Size(45, 29);
            haeKokonimibutton.TabIndex = 90;
            haeKokonimibutton.Text = "Hae";
            haeKokonimibutton.UseVisualStyleBackColor = true;
            haeKokonimibutton.Click += haeKokonimibutton_Click;
            // 
            // kayttajaIDtextBox
            // 
            kayttajaIDtextBox.Location = new Point(34, 198);
            kayttajaIDtextBox.MaxLength = 12;
            kayttajaIDtextBox.Name = "kayttajaIDtextBox";
            kayttajaIDtextBox.PlaceholderText = "Esim. muodossa 'USER000001'";
            kayttajaIDtextBox.Size = new Size(255, 27);
            kayttajaIDtextBox.TabIndex = 88;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(34, 75);
            label1.Name = "label1";
            label1.Size = new Size(405, 31);
            label1.TabIndex = 84;
            label1.Text = "Valitse käyttäjä, jota haluat muokata";
            // 
            // haeKayttajaIDbutton
            // 
            haeKayttajaIDbutton.Location = new Point(295, 197);
            haeKayttajaIDbutton.Name = "haeKayttajaIDbutton";
            haeKayttajaIDbutton.Size = new Size(45, 29);
            haeKayttajaIDbutton.TabIndex = 86;
            haeKayttajaIDbutton.Text = "Hae";
            haeKayttajaIDbutton.UseVisualStyleBackColor = true;
            haeKayttajaIDbutton.Click += haeKayttajaIDbutton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 175);
            label3.Name = "label3";
            label3.Size = new Size(141, 20);
            label3.TabIndex = 85;
            label3.Text = "Hae käyttäjänimellä";
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
            käyttäjädataGridView.Size = new Size(487, 323);
            käyttäjädataGridView.TabIndex = 52;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(käyttäjädataGridView);
            panel2.Location = new Point(393, 140);
            panel2.Name = "panel2";
            panel2.Size = new Size(493, 338);
            panel2.TabIndex = 87;
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
            suljeNappi.Location = new Point(863, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(34, 259);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 89;
            label4.Text = "Hae käyttäjän nimellä";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(suljeNappi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(910, 48);
            panel1.TabIndex = 83;
            // 
            // admin_käyttäjähallinta_muokkaa_käyttäjä
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(910, 519);
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
            Controls.Add(kayttajaIDtextBox);
            Controls.Add(label1);
            Controls.Add(haeKayttajaIDbutton);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label4);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_käyttäjähallinta_muokkaa_käyttäjä";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_käyttäjähallinta_muokkaa_käyttäjä";
            ((System.ComponentModel.ISupportInitialize)käyttäjädataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button tyhjennäKentätbutton;
        private TextBox sukunimitextBox;
        private Button tyhjennäTaulubutton;
        private Button haeKaikkiKäyttäjätbutton;
        private TextBox osoitetextBox;
        private Button haeOsoitebutton;
        private Label label6;
        private TextBox emailtextBox;
        private Button haeEmailbutton;
        private Label label5;
        private TextBox etunimitextBox;
        private Button haeKokonimibutton;
        private TextBox kayttajaIDtextBox;
        private Label label1;
        private Button haeKayttajaIDbutton;
        private Label label3;
        private DataGridView käyttäjädataGridView;
        private Panel panel2;
        private Label label2;
        private Button suljeNappi;
        private Label label4;
        private Panel panel1;
    }
}