namespace KalaKaveri_v1
{
    partial class kirjaudu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kirjaudu));
            panel1 = new Panel();
            label2 = new Label();
            suljeNappi = new Button();
            kirjauduNappi = new Button();
            kayttajatunnusTextbox = new TextBox();
            label1 = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            luouusitiliLinkki = new LinkLabel();
            unohtunutsalasanaLinkki = new LinkLabel();
            salasanaTextbox = new TextBox();
            label4 = new Label();
            label3 = new Label();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            panel1.TabIndex = 0;
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
            // kirjauduNappi
            // 
            kirjauduNappi.Location = new Point(72, 252);
            kirjauduNappi.Name = "kirjauduNappi";
            kirjauduNappi.Size = new Size(278, 44);
            kirjauduNappi.TabIndex = 1;
            kirjauduNappi.Text = "Kirjaudu";
            kirjauduNappi.UseVisualStyleBackColor = true;
            kirjauduNappi.Click += kirjauduNappi_Click;
            // 
            // kayttajatunnusTextbox
            // 
            kayttajatunnusTextbox.Location = new Point(72, 101);
            kayttajatunnusTextbox.MaxLength = 100;
            kayttajatunnusTextbox.Name = "kayttajatunnusTextbox";
            kayttajatunnusTextbox.Size = new Size(278, 27);
            kayttajatunnusTextbox.TabIndex = 2;
            kayttajatunnusTextbox.Text = "sauli.niinistomrexpresident@gmail.com";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(107, 28);
            label1.Name = "label1";
            label1.Size = new Size(195, 37);
            label1.TabIndex = 3;
            label1.Text = "Kirjaudu sisään";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(luouusitiliLinkki);
            panel2.Controls.Add(unohtunutsalasanaLinkki);
            panel2.Controls.Add(kirjauduNappi);
            panel2.Controls.Add(salasanaTextbox);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(kayttajatunnusTextbox);
            panel2.Location = new Point(226, 109);
            panel2.Name = "panel2";
            panel2.Size = new Size(426, 369);
            panel2.TabIndex = 4;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(26, 163);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(40, 37);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(26, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 37);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // luouusitiliLinkki
            // 
            luouusitiliLinkki.AutoSize = true;
            luouusitiliLinkki.LinkColor = Color.FromArgb(128, 255, 255);
            luouusitiliLinkki.Location = new Point(170, 312);
            luouusitiliLinkki.Name = "luouusitiliLinkki";
            luouusitiliLinkki.Size = new Size(84, 20);
            luouusitiliLinkki.TabIndex = 8;
            luouusitiliLinkki.TabStop = true;
            luouusitiliLinkki.Text = "Luo uusi tili";
            luouusitiliLinkki.LinkClicked += luouusitiliLinkki_LinkClicked;
            // 
            // unohtunutsalasanaLinkki
            // 
            unohtunutsalasanaLinkki.AutoSize = true;
            unohtunutsalasanaLinkki.LinkColor = Color.FromArgb(128, 255, 255);
            unohtunutsalasanaLinkki.Location = new Point(139, 216);
            unohtunutsalasanaLinkki.Name = "unohtunutsalasanaLinkki";
            unohtunutsalasanaLinkki.Size = new Size(145, 20);
            unohtunutsalasanaLinkki.TabIndex = 7;
            unohtunutsalasanaLinkki.TabStop = true;
            unohtunutsalasanaLinkki.Text = "Unohtunut salasana?";
            unohtunutsalasanaLinkki.LinkClicked += unohtunutsalasanaLinkki_LinkClicked;
            // 
            // salasanaTextbox
            // 
            salasanaTextbox.Location = new Point(72, 173);
            salasanaTextbox.MaxLength = 500;
            salasanaTextbox.Name = "salasanaTextbox";
            salasanaTextbox.Size = new Size(278, 27);
            salasanaTextbox.TabIndex = 6;
            salasanaTextbox.Text = "mrpresident";
            salasanaTextbox.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.ForeColor = Color.White;
            label4.Location = new Point(72, 150);
            label4.Name = "label4";
            label4.Size = new Size(67, 20);
            label4.TabIndex = 5;
            label4.Text = "Salasana";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.White;
            label3.Location = new Point(72, 78);
            label3.Name = "label3";
            label3.Size = new Size(191, 20);
            label3.TabIndex = 4;
            label3.Text = "Käyttäjätunnus (sähköposti)";
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(892, 554);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
            // 
            // kirjaudu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(892, 554);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(pictureBox3);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kirjaudu";
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "4";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button suljeNappi;
        private Button kirjauduNappi;
        private TextBox kayttajatunnusTextbox;
        private Label label1;
        private Label label2;
        private Panel panel2;
        private LinkLabel unohtunutsalasanaLinkki;
        private TextBox salasanaTextbox;
        private Label label4;
        private Label label3;
        private LinkLabel luouusitiliLinkki;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
    }
}
