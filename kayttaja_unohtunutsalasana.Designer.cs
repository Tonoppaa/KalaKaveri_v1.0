namespace KalaKaveri_v1
{
    partial class kayttaja_unohtunutsalasana
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayttaja_unohtunutsalasana));
            panel1 = new Panel();
            label2 = new Label();
            suljeNappi = new Button();
            label1 = new Label();
            sähköpostiTextbox = new TextBox();
            panel2 = new Panel();
            lähetäNappi = new Button();
            label5 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(874, 48);
            panel1.TabIndex = 6;
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
            suljeNappi.Location = new Point(827, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.ForeColor = Color.White;
            label1.Location = new Point(63, 74);
            label1.Name = "label1";
            label1.Size = new Size(298, 28);
            label1.TabIndex = 3;
            label1.Text = "Kirjoita alle sähköpostiosoitteesi,";
            // 
            // sähköpostiTextbox
            // 
            sähköpostiTextbox.Location = new Point(83, 169);
            sähköpostiTextbox.MaxLength = 100;
            sähköpostiTextbox.Name = "sähköpostiTextbox";
            sähköpostiTextbox.Size = new Size(278, 27);
            sähköpostiTextbox.TabIndex = 2;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Transparent;
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Controls.Add(lähetäNappi);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(sähköpostiTextbox);
            panel2.Location = new Point(226, 95);
            panel2.Name = "panel2";
            panel2.Size = new Size(426, 369);
            panel2.TabIndex = 7;
            // 
            // lähetäNappi
            // 
            lähetäNappi.Location = new Point(125, 234);
            lähetäNappi.Name = "lähetäNappi";
            lähetäNappi.Size = new Size(171, 44);
            lähetäNappi.TabIndex = 11;
            lähetäNappi.Text = "Lähetä";
            lähetäNappi.UseVisualStyleBackColor = true;
            lähetäNappi.Click += lähetäNappi_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.ForeColor = Color.White;
            label5.Location = new Point(89, 102);
            label5.Name = "label5";
            label5.Size = new Size(248, 28);
            label5.TabIndex = 10;
            label5.Text = "johon salasana palautetaan";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 163);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(36, 33);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Dock = DockStyle.Fill;
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, 0);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(874, 507);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // kayttaja_unohtunutsalasana
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(874, 507);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(pictureBox3);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kayttaja_unohtunutsalasana";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kayttaja_unohtunutsalasana";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button suljeNappi;
        private Label label1;
        private TextBox sähköpostiTextbox;
        private Panel panel2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Label label5;
        private Button lähetäNappi;
    }
}