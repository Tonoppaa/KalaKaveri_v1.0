namespace KalaKaveri_v1
{
    partial class kayttaja_omatsaaliit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayttaja_omatsaaliit));
            panel1 = new Panel();
            kirjauduUlosNappi = new Button();
            kalapankkiNappi = new Button();
            omatsaaliitNappi = new Button();
            etusivuNappi = new Button();
            kalastuspaikatNappi = new Button();
            label2 = new Label();
            suljeNappi = new Button();
            kirjaaNappi = new Button();
            tarkasteleNappi = new Button();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            poistaNappi = new Button();
            kirjaapictureBox = new PictureBox();
            tarkastelepictureBox = new PictureBox();
            poistapictureBox = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kirjaapictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tarkastelepictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)poistapictureBox).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(kirjauduUlosNappi);
            panel1.Controls.Add(kalapankkiNappi);
            panel1.Controls.Add(omatsaaliitNappi);
            panel1.Controls.Add(etusivuNappi);
            panel1.Controls.Add(kalastuspaikatNappi);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(suljeNappi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 48);
            panel1.TabIndex = 11;
            // 
            // kirjauduUlosNappi
            // 
            kirjauduUlosNappi.Location = new Point(725, 2);
            kirjauduUlosNappi.Name = "kirjauduUlosNappi";
            kirjauduUlosNappi.Size = new Size(112, 45);
            kirjauduUlosNappi.TabIndex = 13;
            kirjauduUlosNappi.Text = "Kirjaudu ulos";
            kirjauduUlosNappi.UseVisualStyleBackColor = true;
            kirjauduUlosNappi.Click += kirjauduUlosNappi_Click;
            // 
            // kalapankkiNappi
            // 
            kalapankkiNappi.Location = new Point(481, 2);
            kalapankkiNappi.Name = "kalapankkiNappi";
            kalapankkiNappi.Size = new Size(112, 45);
            kalapankkiNappi.TabIndex = 12;
            kalapankkiNappi.Text = "Kalapankki";
            kalapankkiNappi.UseVisualStyleBackColor = true;
            kalapankkiNappi.Click += kalapankkiNappi_Click;
            // 
            // omatsaaliitNappi
            // 
            omatsaaliitNappi.BackColor = Color.Aqua;
            omatsaaliitNappi.Location = new Point(245, 2);
            omatsaaliitNappi.Name = "omatsaaliitNappi";
            omatsaaliitNappi.Size = new Size(112, 45);
            omatsaaliitNappi.TabIndex = 11;
            omatsaaliitNappi.Text = "Omat saaliit";
            omatsaaliitNappi.UseVisualStyleBackColor = false;
            // 
            // etusivuNappi
            // 
            etusivuNappi.Location = new Point(127, 2);
            etusivuNappi.Name = "etusivuNappi";
            etusivuNappi.Size = new Size(112, 45);
            etusivuNappi.TabIndex = 10;
            etusivuNappi.Text = "Etusivu";
            etusivuNappi.UseVisualStyleBackColor = true;
            etusivuNappi.Click += etusivuNappi_Click;
            // 
            // kalastuspaikatNappi
            // 
            kalastuspaikatNappi.Location = new Point(363, 2);
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
            suljeNappi.Location = new Point(843, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // kirjaaNappi
            // 
            kirjaaNappi.Location = new Point(55, 453);
            kirjaaNappi.Name = "kirjaaNappi";
            kirjaaNappi.Size = new Size(225, 42);
            kirjaaNappi.TabIndex = 12;
            kirjaaNappi.Text = "Kirjaa";
            kirjaaNappi.UseVisualStyleBackColor = true;
            kirjaaNappi.Click += kirjaaNappi_Click;
            // 
            // tarkasteleNappi
            // 
            tarkasteleNappi.Location = new Point(333, 453);
            tarkasteleNappi.Name = "tarkasteleNappi";
            tarkasteleNappi.Size = new Size(225, 42);
            tarkasteleNappi.TabIndex = 13;
            tarkasteleNappi.Text = "Tarkastele";
            tarkasteleNappi.UseVisualStyleBackColor = true;
            tarkasteleNappi.Click += tarkasteleNappi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(286, 78);
            label1.Name = "label1";
            label1.Size = new Size(317, 46);
            label1.TabIndex = 14;
            label1.Text = "Mitä haluat tehdä?";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(118, 142);
            label3.Name = "label3";
            label3.Size = new Size(87, 20);
            label3.TabIndex = 15;
            label3.Text = "Kirjaa saalis";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(381, 142);
            label4.Name = "label4";
            label4.Size = new Size(135, 20);
            label4.TabIndex = 16;
            label4.Text = "Tarkastele saaliitasi";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(679, 142);
            label5.Name = "label5";
            label5.Size = new Size(88, 20);
            label5.TabIndex = 18;
            label5.Text = "Poista saalis";
            // 
            // poistaNappi
            // 
            poistaNappi.Location = new Point(612, 453);
            poistaNappi.Name = "poistaNappi";
            poistaNappi.Size = new Size(225, 42);
            poistaNappi.TabIndex = 17;
            poistaNappi.Text = "Poista";
            poistaNappi.UseVisualStyleBackColor = true;
            poistaNappi.Click += poistaNappi_Click;
            // 
            // kirjaapictureBox
            // 
            kirjaapictureBox.Location = new Point(55, 179);
            kirjaapictureBox.Name = "kirjaapictureBox";
            kirjaapictureBox.Size = new Size(225, 259);
            kirjaapictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            kirjaapictureBox.TabIndex = 19;
            kirjaapictureBox.TabStop = false;
            // 
            // tarkastelepictureBox
            // 
            tarkastelepictureBox.Location = new Point(333, 179);
            tarkastelepictureBox.Name = "tarkastelepictureBox";
            tarkastelepictureBox.Size = new Size(225, 259);
            tarkastelepictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            tarkastelepictureBox.TabIndex = 20;
            tarkastelepictureBox.TabStop = false;
            // 
            // poistapictureBox
            // 
            poistapictureBox.Location = new Point(612, 179);
            poistapictureBox.Name = "poistapictureBox";
            poistapictureBox.Size = new Size(225, 259);
            poistapictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            poistapictureBox.TabIndex = 21;
            poistapictureBox.TabStop = false;
            // 
            // kayttaja_omatsaaliit
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 561);
            Controls.Add(poistapictureBox);
            Controls.Add(tarkastelepictureBox);
            Controls.Add(kirjaapictureBox);
            Controls.Add(label5);
            Controls.Add(poistaNappi);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(tarkasteleNappi);
            Controls.Add(kirjaaNappi);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kayttaja_omatsaaliit";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kayttaja_omatsaaliit";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kirjaapictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)tarkastelepictureBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)poistapictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button kirjauduUlosNappi;
        private Button kalapankkiNappi;
        private Button omatsaaliitNappi;
        private Button etusivuNappi;
        private Button kalastuspaikatNappi;
        private Label label2;
        private Button suljeNappi;
        private Button kirjaaNappi;
        private Button tarkasteleNappi;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Button poistaNappi;
        private PictureBox kirjaapictureBox;
        private PictureBox tarkastelepictureBox;
        private PictureBox poistapictureBox;
    }
}