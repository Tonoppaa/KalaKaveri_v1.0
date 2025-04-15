namespace KalaKaveri_v1
{
    partial class admin_kalapankki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_kalapankki));
            panel1 = new Panel();
            kirjauduUlosNappi = new Button();
            kalapankkiNappi = new Button();
            käyttäjähallintaNappi = new Button();
            etusivuNappi = new Button();
            kalastuspaikatNappi = new Button();
            label2 = new Label();
            suljeNappi = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            muokkaaKalabutton = new Button();
            poistaKalabutton = new Button();
            lisääKalabutton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(kirjauduUlosNappi);
            panel1.Controls.Add(kalapankkiNappi);
            panel1.Controls.Add(käyttäjähallintaNappi);
            panel1.Controls.Add(etusivuNappi);
            panel1.Controls.Add(kalastuspaikatNappi);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(suljeNappi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 48);
            panel1.TabIndex = 12;
            // 
            // kirjauduUlosNappi
            // 
            kirjauduUlosNappi.Location = new Point(707, 2);
            kirjauduUlosNappi.Name = "kirjauduUlosNappi";
            kirjauduUlosNappi.Size = new Size(112, 45);
            kirjauduUlosNappi.TabIndex = 13;
            kirjauduUlosNappi.Text = "Kirjaudu ulos";
            kirjauduUlosNappi.UseVisualStyleBackColor = true;
            kirjauduUlosNappi.Click += kirjauduUlosNappi_Click;
            // 
            // kalapankkiNappi
            // 
            kalapankkiNappi.BackColor = Color.Khaki;
            kalapankkiNappi.Location = new Point(492, 2);
            kalapankkiNappi.Name = "kalapankkiNappi";
            kalapankkiNappi.Size = new Size(112, 45);
            kalapankkiNappi.TabIndex = 12;
            kalapankkiNappi.Text = "Kalapankki";
            kalapankkiNappi.UseVisualStyleBackColor = false;
            // 
            // käyttäjähallintaNappi
            // 
            käyttäjähallintaNappi.Location = new Point(245, 2);
            käyttäjähallintaNappi.Name = "käyttäjähallintaNappi";
            käyttäjähallintaNappi.Size = new Size(123, 45);
            käyttäjähallintaNappi.TabIndex = 11;
            käyttäjähallintaNappi.Text = "Käyttäjähallinta";
            käyttäjähallintaNappi.UseVisualStyleBackColor = true;
            käyttäjähallintaNappi.Click += käyttäjähallintaNappi_Click;
            // 
            // etusivuNappi
            // 
            etusivuNappi.BackColor = SystemColors.Control;
            etusivuNappi.Location = new Point(127, 2);
            etusivuNappi.Name = "etusivuNappi";
            etusivuNappi.Size = new Size(112, 45);
            etusivuNappi.TabIndex = 10;
            etusivuNappi.Text = "Etusivu";
            etusivuNappi.UseVisualStyleBackColor = false;
            etusivuNappi.Click += etusivuNappi_Click;
            // 
            // kalastuspaikatNappi
            // 
            kalastuspaikatNappi.Location = new Point(374, 2);
            kalastuspaikatNappi.Name = "kalastuspaikatNappi";
            kalastuspaikatNappi.Size = new Size(112, 45);
            kalastuspaikatNappi.TabIndex = 9;
            kalastuspaikatNappi.Text = "Kalastuspaikat";
            kalastuspaikatNappi.UseVisualStyleBackColor = true;
            kalastuspaikatNappi.Click += kalastuspaikatNappi_Click;
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
            suljeNappi.Location = new Point(823, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(285, 114);
            label1.Name = "label1";
            label1.Size = new Size(283, 41);
            label1.TabIndex = 13;
            label1.Text = "Mitä haluat tehdä?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(84, 225);
            label3.Name = "label3";
            label3.Size = new Size(165, 20);
            label3.TabIndex = 17;
            label3.Text = "Lisätä kala tietokantaan";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(349, 225);
            label4.Name = "label4";
            label4.Size = new Size(153, 20);
            label4.TabIndex = 18;
            label4.Text = "Muokata kalan tietoja";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(587, 225);
            label5.Name = "label5";
            label5.Size = new Size(188, 20);
            label5.TabIndex = 19;
            label5.Text = "Poistaa kalan tietokannasta";
            // 
            // muokkaaKalabutton
            // 
            muokkaaKalabutton.Location = new Point(349, 271);
            muokkaaKalabutton.Name = "muokkaaKalabutton";
            muokkaaKalabutton.Size = new Size(153, 102);
            muokkaaKalabutton.TabIndex = 1;
            muokkaaKalabutton.Text = "Muokkaa";
            muokkaaKalabutton.UseVisualStyleBackColor = true;
            muokkaaKalabutton.Click += muokkaaKalabutton_Click;
            // 
            // poistaKalabutton
            // 
            poistaKalabutton.Location = new Point(603, 271);
            poistaKalabutton.Name = "poistaKalabutton";
            poistaKalabutton.Size = new Size(153, 102);
            poistaKalabutton.TabIndex = 2;
            poistaKalabutton.Text = "Poista";
            poistaKalabutton.UseVisualStyleBackColor = true;
            poistaKalabutton.Click += poistaKalabutton_Click;
            // 
            // lisääKalabutton
            // 
            lisääKalabutton.Location = new Point(84, 271);
            lisääKalabutton.Name = "lisääKalabutton";
            lisääKalabutton.Size = new Size(164, 102);
            lisääKalabutton.TabIndex = 0;
            lisääKalabutton.Text = "Lisää";
            lisääKalabutton.UseVisualStyleBackColor = true;
            lisääKalabutton.Click += lisääKalabutton_Click;
            // 
            // admin_kalapankki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 510);
            Controls.Add(poistaKalabutton);
            Controls.Add(muokkaaKalabutton);
            Controls.Add(lisääKalabutton);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_kalapankki";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_kalapankki";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button kirjauduUlosNappi;
        private Button kalapankkiNappi;
        private Button käyttäjähallintaNappi;
        private Button etusivuNappi;
        private Button kalastuspaikatNappi;
        private Label label2;
        private Button suljeNappi;
        private Label label1;
        private Button muokkaaKalabutton;
        private Button poistaKalabutton;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button lisääKalabutton;
    }
}