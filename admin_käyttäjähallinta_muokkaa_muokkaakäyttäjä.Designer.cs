namespace KalaKaveri_v1
{
    partial class admin_käyttäjähallinta_muokkaa_muokkaakäyttäjä
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_käyttäjähallinta_muokkaa_muokkaakäyttäjä));
            label6 = new Label();
            label2 = new Label();
            suljebutton = new Button();
            käyttäjäIDtextBox = new TextBox();
            label11 = new Label();
            muokkaaKäyttäjäbutton = new Button();
            salasanatextBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            osoitetextBox = new TextBox();
            sähköpostitextBox = new TextBox();
            label7 = new Label();
            label5 = new Label();
            label4 = new Label();
            sukunimitextBox = new TextBox();
            label3 = new Label();
            label10 = new Label();
            etunimitextBox = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            muokkaaTietojabutton = new Button();
            roolitextBox = new TextBox();
            huomiolabel = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 301);
            label6.Name = "label6";
            label6.Size = new Size(47, 20);
            label6.TabIndex = 120;
            label6.Text = "Rooli:";
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
            // suljebutton
            // 
            suljebutton.BackgroundImage = (Image)resources.GetObject("suljebutton.BackgroundImage");
            suljebutton.BackgroundImageLayout = ImageLayout.Center;
            suljebutton.Dock = DockStyle.Right;
            suljebutton.FlatAppearance.BorderSize = 0;
            suljebutton.FlatStyle = FlatStyle.Flat;
            suljebutton.Location = new Point(753, 0);
            suljebutton.Name = "suljebutton";
            suljebutton.Size = new Size(47, 48);
            suljebutton.TabIndex = 1;
            suljebutton.UseVisualStyleBackColor = true;
            suljebutton.Click += suljeNappi_Click;
            // 
            // käyttäjäIDtextBox
            // 
            käyttäjäIDtextBox.Location = new Point(42, 186);
            käyttäjäIDtextBox.Name = "käyttäjäIDtextBox";
            käyttäjäIDtextBox.ReadOnly = true;
            käyttäjäIDtextBox.Size = new Size(327, 27);
            käyttäjäIDtextBox.TabIndex = 119;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(42, 163);
            label11.Name = "label11";
            label11.Size = new Size(93, 20);
            label11.TabIndex = 118;
            label11.Text = "Käyttäjän ID:";
            // 
            // muokkaaKäyttäjäbutton
            // 
            muokkaaKäyttäjäbutton.Location = new Point(42, 452);
            muokkaaKäyttäjäbutton.Name = "muokkaaKäyttäjäbutton";
            muokkaaKäyttäjäbutton.Size = new Size(716, 56);
            muokkaaKäyttäjäbutton.TabIndex = 117;
            muokkaaKäyttäjäbutton.Text = "Päivitä käyttäjän tietoja";
            muokkaaKäyttäjäbutton.UseVisualStyleBackColor = true;
            muokkaaKäyttäjäbutton.Visible = false;
            muokkaaKäyttäjäbutton.Click += muokkaaKäyttäjäbutton_Click;
            // 
            // salasanatextBox
            // 
            salasanatextBox.Location = new Point(425, 252);
            salasanatextBox.MaxLength = 20;
            salasanatextBox.Name = "salasanatextBox";
            salasanatextBox.ReadOnly = true;
            salasanatextBox.Size = new Size(333, 27);
            salasanatextBox.TabIndex = 116;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(425, 227);
            label8.Name = "label8";
            label8.Size = new Size(70, 20);
            label8.TabIndex = 115;
            label8.Text = "Salasana:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(444, 381);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 114;
            // 
            // osoitetextBox
            // 
            osoitetextBox.Location = new Point(42, 394);
            osoitetextBox.MaxLength = 100;
            osoitetextBox.Name = "osoitetextBox";
            osoitetextBox.ReadOnly = true;
            osoitetextBox.Size = new Size(327, 27);
            osoitetextBox.TabIndex = 113;
            // 
            // sähköpostitextBox
            // 
            sähköpostitextBox.Location = new Point(425, 188);
            sähköpostitextBox.MaxLength = 100;
            sähköpostitextBox.Name = "sähköpostitextBox";
            sähköpostitextBox.ReadOnly = true;
            sähköpostitextBox.Size = new Size(333, 27);
            sähköpostitextBox.TabIndex = 112;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(425, 163);
            label7.Name = "label7";
            label7.Size = new Size(49, 20);
            label7.TabIndex = 111;
            label7.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(444, 317);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 110;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(42, 371);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 109;
            label4.Text = "Osoite:";
            // 
            // sukunimitextBox
            // 
            sukunimitextBox.Location = new Point(42, 324);
            sukunimitextBox.MaxLength = 80;
            sukunimitextBox.Name = "sukunimitextBox";
            sukunimitextBox.ReadOnly = true;
            sukunimitextBox.Size = new Size(327, 27);
            sukunimitextBox.TabIndex = 108;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 301);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 107;
            label3.Text = "Sukunimi:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(42, 229);
            label10.Name = "label10";
            label10.Size = new Size(62, 20);
            label10.TabIndex = 106;
            label10.Text = "Etunimi:";
            // 
            // etunimitextBox
            // 
            etunimitextBox.Location = new Point(42, 252);
            etunimitextBox.MaxLength = 50;
            etunimitextBox.Name = "etunimitextBox";
            etunimitextBox.ReadOnly = true;
            etunimitextBox.Size = new Size(327, 27);
            etunimitextBox.TabIndex = 105;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(suljebutton);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 48);
            panel1.TabIndex = 103;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(37, 88);
            label1.Name = "label1";
            label1.Size = new Size(442, 35);
            label1.TabIndex = 104;
            label1.Text = "Käyttäjähallinta - Muokkaa käyttäjää";
            // 
            // muokkaaTietojabutton
            // 
            muokkaaTietojabutton.Location = new Point(621, 88);
            muokkaaTietojabutton.Name = "muokkaaTietojabutton";
            muokkaaTietojabutton.Size = new Size(137, 50);
            muokkaaTietojabutton.TabIndex = 122;
            muokkaaTietojabutton.Text = "Muokkaa käyttäjän tietoja";
            muokkaaTietojabutton.UseVisualStyleBackColor = true;
            muokkaaTietojabutton.Click += muokkaaTietojabutton_Click;
            // 
            // roolitextBox
            // 
            roolitextBox.Location = new Point(425, 324);
            roolitextBox.Name = "roolitextBox";
            roolitextBox.ReadOnly = true;
            roolitextBox.Size = new Size(333, 27);
            roolitextBox.TabIndex = 123;
            // 
            // huomiolabel
            // 
            huomiolabel.AutoSize = true;
            huomiolabel.Location = new Point(425, 381);
            huomiolabel.Name = "huomiolabel";
            huomiolabel.Size = new Size(333, 20);
            huomiolabel.TabIndex = 124;
            huomiolabel.Text = "Huom. Et voi muokata käyttäjän ID:tä etkä roolia.";
            huomiolabel.Visible = false;
            // 
            // admin_käyttäjähallinta_muokkaa_muokkaakäyttäjä
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 528);
            Controls.Add(huomiolabel);
            Controls.Add(roolitextBox);
            Controls.Add(muokkaaTietojabutton);
            Controls.Add(label6);
            Controls.Add(käyttäjäIDtextBox);
            Controls.Add(label11);
            Controls.Add(muokkaaKäyttäjäbutton);
            Controls.Add(salasanatextBox);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(osoitetextBox);
            Controls.Add(sähköpostitextBox);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(sukunimitextBox);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(etunimitextBox);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_käyttäjähallinta_muokkaa_muokkaakäyttäjä";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_käyttäjähallinta_muokkaa_muokkaakäyttäjä";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label6;
        private Label label2;
        private Button suljebutton;
        private TextBox käyttäjäIDtextBox;
        private Label label11;
        private Button muokkaaKäyttäjäbutton;
        private TextBox salasanatextBox;
        private Label label8;
        private Label label9;
        private TextBox osoitetextBox;
        private TextBox sähköpostitextBox;
        private Label label7;
        private Label label5;
        private Label label4;
        private TextBox sukunimitextBox;
        private Label label3;
        private Label label10;
        private TextBox etunimitextBox;
        private Panel panel1;
        private Label label1;
        private Button muokkaaTietojabutton;
        private TextBox roolitextBox;
        private Label huomiolabel;
    }
}