namespace KalaKaveri_v1
{
    partial class kayttaja_luouusikayttaja
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayttaja_luouusikayttaja));
            panel1 = new Panel();
            label2 = new Label();
            suljeNappi = new Button();
            label1 = new Label();
            panel2 = new Panel();
            näytäSalasanaButton = new Button();
            generoiSalasanabutton = new Button();
            label8 = new Label();
            label7 = new Label();
            salasanatextBox = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            emailTextbox = new TextBox();
            osoiteTextbox = new TextBox();
            sukunimiTextbox = new TextBox();
            etunimiTextbox = new TextBox();
            luotunnusNappi = new Button();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
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
            panel1.Size = new Size(892, 48);
            panel1.TabIndex = 9;
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
            suljeNappi.Location = new Point(845, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(34, 19);
            label1.Name = "label1";
            label1.Size = new Size(356, 23);
            label1.TabIndex = 3;
            label1.Text = "Luodaksesi tunnuksen, täytä alla olevat tiedot";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(näytäSalasanaButton);
            panel2.Controls.Add(generoiSalasanabutton);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(salasanatextBox);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(emailTextbox);
            panel2.Controls.Add(osoiteTextbox);
            panel2.Controls.Add(sukunimiTextbox);
            panel2.Controls.Add(etunimiTextbox);
            panel2.Controls.Add(luotunnusNappi);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(229, 54);
            panel2.Name = "panel2";
            panel2.Size = new Size(434, 525);
            panel2.TabIndex = 10;
            // 
            // näytäSalasanaButton
            // 
            näytäSalasanaButton.Font = new Font("Segoe UI", 7F);
            näytäSalasanaButton.Location = new Point(196, 360);
            näytäSalasanaButton.Name = "näytäSalasanaButton";
            näytäSalasanaButton.Size = new Size(93, 23);
            näytäSalasanaButton.TabIndex = 24;
            näytäSalasanaButton.Text = "Näytä salasana";
            näytäSalasanaButton.UseVisualStyleBackColor = true;
            // 
            // generoiSalasanabutton
            // 
            generoiSalasanabutton.Font = new Font("Segoe UI", 7F);
            generoiSalasanabutton.Location = new Point(295, 360);
            generoiSalasanabutton.Name = "generoiSalasanabutton";
            generoiSalasanabutton.Size = new Size(105, 23);
            generoiSalasanabutton.TabIndex = 23;
            generoiSalasanabutton.Text = "Generoi salasana";
            generoiSalasanabutton.UseVisualStyleBackColor = true;
            generoiSalasanabutton.Click += generoiSalasanabutton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 10F);
            label8.ForeColor = Color.White;
            label8.Location = new Point(34, 51);
            label8.Name = "label8";
            label8.Size = new Size(366, 23);
            label8.TabIndex = 22;
            label8.Text = "Sähköpostiosoitteesi toimii käyttäjätunnuksena";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.White;
            label7.Location = new Point(34, 360);
            label7.Name = "label7";
            label7.Size = new Size(76, 23);
            label7.TabIndex = 21;
            label7.Text = "Salasana";
            // 
            // salasanatextBox
            // 
            salasanatextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            salasanatextBox.Location = new Point(34, 386);
            salasanatextBox.MaxLength = 20;
            salasanatextBox.Name = "salasanatextBox";
            salasanatextBox.PlaceholderText = "Väh. 8, max. 20 merkkiä pitkä";
            salasanatextBox.Size = new Size(366, 27);
            salasanatextBox.TabIndex = 20;
            salasanatextBox.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.White;
            label6.Location = new Point(34, 293);
            label6.Name = "label6";
            label6.Size = new Size(51, 23);
            label6.TabIndex = 19;
            label6.Text = "Email";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(34, 227);
            label5.Name = "label5";
            label5.Size = new Size(59, 23);
            label5.TabIndex = 18;
            label5.Text = "Osoite";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10F);
            label4.ForeColor = Color.White;
            label4.Location = new Point(34, 160);
            label4.Name = "label4";
            label4.Size = new Size(80, 23);
            label4.TabIndex = 17;
            label4.Text = "Sukunimi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.White;
            label3.Location = new Point(34, 94);
            label3.Name = "label3";
            label3.Size = new Size(68, 23);
            label3.TabIndex = 16;
            label3.Text = "Etunimi";
            // 
            // emailTextbox
            // 
            emailTextbox.Location = new Point(34, 319);
            emailTextbox.MaxLength = 100;
            emailTextbox.Name = "emailTextbox";
            emailTextbox.Size = new Size(366, 27);
            emailTextbox.TabIndex = 15;
            // 
            // osoiteTextbox
            // 
            osoiteTextbox.Location = new Point(34, 253);
            osoiteTextbox.MaxLength = 100;
            osoiteTextbox.Name = "osoiteTextbox";
            osoiteTextbox.Size = new Size(366, 27);
            osoiteTextbox.TabIndex = 14;
            // 
            // sukunimiTextbox
            // 
            sukunimiTextbox.Location = new Point(34, 186);
            sukunimiTextbox.MaxLength = 80;
            sukunimiTextbox.Name = "sukunimiTextbox";
            sukunimiTextbox.Size = new Size(366, 27);
            sukunimiTextbox.TabIndex = 13;
            // 
            // etunimiTextbox
            // 
            etunimiTextbox.Location = new Point(34, 120);
            etunimiTextbox.MaxLength = 50;
            etunimiTextbox.Name = "etunimiTextbox";
            etunimiTextbox.Size = new Size(366, 27);
            etunimiTextbox.TabIndex = 12;
            // 
            // luotunnusNappi
            // 
            luotunnusNappi.Location = new Point(34, 444);
            luotunnusNappi.Name = "luotunnusNappi";
            luotunnusNappi.Size = new Size(366, 57);
            luotunnusNappi.TabIndex = 11;
            luotunnusNappi.Text = "Luo käyttäjätunnus";
            luotunnusNappi.UseVisualStyleBackColor = true;
            luotunnusNappi.Click += luotunnusNappi_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(892, 591);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 11;
            pictureBox3.TabStop = false;
            // 
            // kayttaja_luouusikayttaja
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 591);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kayttaja_luouusikayttaja";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kayttaja_luouusikayttaja";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button suljeNappi;
        private Label label1;
        private Panel panel2;
        private Button luotunnusNappi;
        private PictureBox pictureBox3;
        private Label label3;
        private TextBox emailTextbox;
        private TextBox osoiteTextbox;
        private TextBox sukunimiTextbox;
        private TextBox etunimiTextbox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label7;
        private TextBox salasanatextBox;
        private Label label8;
        private Button generoiSalasanabutton;
        private Button näytäSalasanaButton;
    }
}