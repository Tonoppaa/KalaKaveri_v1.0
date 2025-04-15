namespace KalaKaveri_v1
{
    partial class admin_kalapankki_lisää_lisääkalanäkymä
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_kalapankki_lisää_lisääkalanäkymä));
            imgurUrltextBox = new TextBox();
            poistaKuvabutton = new Button();
            lisääKuvabutton = new Button();
            label2 = new Label();
            label12 = new Label();
            suljeNappi = new Button();
            kalaIDtextBox = new TextBox();
            label11 = new Label();
            lisääNappi = new Button();
            elinympäristötextBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            tyypillinenpainotextBox = new TextBox();
            alamittatextBox = new TextBox();
            label7 = new Label();
            kalakuvausrichTextBox = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tyypillinenkokotextBox = new TextBox();
            label3 = new Label();
            label10 = new Label();
            kalanimitextBox = new TextBox();
            kalapictureBox = new PictureBox();
            panel1 = new Panel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)kalapictureBox).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // imgurUrltextBox
            // 
            imgurUrltextBox.Location = new Point(40, 713);
            imgurUrltextBox.Name = "imgurUrltextBox";
            imgurUrltextBox.ReadOnly = true;
            imgurUrltextBox.Size = new Size(327, 27);
            imgurUrltextBox.TabIndex = 128;
            imgurUrltextBox.Visible = false;
            // 
            // poistaKuvabutton
            // 
            poistaKuvabutton.BackgroundImage = (Image)resources.GetObject("poistaKuvabutton.BackgroundImage");
            poistaKuvabutton.BackgroundImageLayout = ImageLayout.Zoom;
            poistaKuvabutton.Location = new Point(400, 369);
            poistaKuvabutton.Name = "poistaKuvabutton";
            poistaKuvabutton.Size = new Size(30, 29);
            poistaKuvabutton.TabIndex = 127;
            poistaKuvabutton.UseVisualStyleBackColor = true;
            poistaKuvabutton.Visible = false;
            poistaKuvabutton.Click += poistaKuvabutton_Click;
            // 
            // lisääKuvabutton
            // 
            lisääKuvabutton.Location = new Point(38, 402);
            lisääKuvabutton.Name = "lisääKuvabutton";
            lisääKuvabutton.Size = new Size(99, 29);
            lisääKuvabutton.TabIndex = 126;
            lisääKuvabutton.Text = "Lisää kuva";
            lisääKuvabutton.UseVisualStyleBackColor = true;
            lisääKuvabutton.Click += lisääKuvabutton_Click;
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
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(40, 690);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 129;
            label12.Text = "imgur url:";
            label12.Visible = false;
            // 
            // suljeNappi
            // 
            suljeNappi.BackgroundImage = (Image)resources.GetObject("suljeNappi.BackgroundImage");
            suljeNappi.BackgroundImageLayout = ImageLayout.Center;
            suljeNappi.Dock = DockStyle.Right;
            suljeNappi.FlatAppearance.BorderSize = 0;
            suljeNappi.FlatStyle = FlatStyle.Flat;
            suljeNappi.Location = new Point(775, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // kalaIDtextBox
            // 
            kalaIDtextBox.Location = new Point(38, 159);
            kalaIDtextBox.Name = "kalaIDtextBox";
            kalaIDtextBox.ReadOnly = true;
            kalaIDtextBox.Size = new Size(356, 27);
            kalaIDtextBox.TabIndex = 125;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(38, 136);
            label11.Name = "label11";
            label11.Size = new Size(68, 20);
            label11.TabIndex = 124;
            label11.Text = "Kalan ID:";
            // 
            // lisääNappi
            // 
            lisääNappi.Location = new Point(40, 612);
            lisääNappi.Name = "lisääNappi";
            lisääNappi.Size = new Size(753, 56);
            lisääNappi.TabIndex = 123;
            lisääNappi.Text = "Lisää kalalaji";
            lisääNappi.UseVisualStyleBackColor = true;
            lisääNappi.Click += lisääNappi_Click;
            // 
            // elinympäristötextBox
            // 
            elinympäristötextBox.Location = new Point(466, 369);
            elinympäristötextBox.MaxLength = 100;
            elinympäristötextBox.Name = "elinympäristötextBox";
            elinympäristötextBox.Size = new Size(327, 27);
            elinympäristötextBox.TabIndex = 122;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(466, 344);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 121;
            label8.Text = "Elinympäristö:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(460, 369);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 120;
            // 
            // tyypillinenpainotextBox
            // 
            tyypillinenpainotextBox.Location = new Point(466, 240);
            tyypillinenpainotextBox.MaxLength = 20;
            tyypillinenpainotextBox.Name = "tyypillinenpainotextBox";
            tyypillinenpainotextBox.Size = new Size(327, 27);
            tyypillinenpainotextBox.TabIndex = 119;
            // 
            // alamittatextBox
            // 
            alamittatextBox.Location = new Point(466, 305);
            alamittatextBox.MaxLength = 50;
            alamittatextBox.Name = "alamittatextBox";
            alamittatextBox.Size = new Size(327, 27);
            alamittatextBox.TabIndex = 118;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(466, 280);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 117;
            label7.Text = "Alamitta:";
            // 
            // kalakuvausrichTextBox
            // 
            kalakuvausrichTextBox.Location = new Point(40, 476);
            kalakuvausrichTextBox.MaxLength = 500;
            kalakuvausrichTextBox.Name = "kalakuvausrichTextBox";
            kalakuvausrichTextBox.Size = new Size(753, 117);
            kalakuvausrichTextBox.TabIndex = 116;
            kalakuvausrichTextBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(40, 453);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 115;
            label6.Text = "Kalan kuvaus:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(460, 305);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 114;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(466, 217);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 113;
            label4.Text = "Tyypillinen paino:";
            // 
            // tyypillinenkokotextBox
            // 
            tyypillinenkokotextBox.Location = new Point(466, 174);
            tyypillinenkokotextBox.MaxLength = 15;
            tyypillinenkokotextBox.Name = "tyypillinenkokotextBox";
            tyypillinenkokotextBox.Size = new Size(327, 27);
            tyypillinenkokotextBox.TabIndex = 112;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 151);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 111;
            label3.Text = "Tyypillinen pituus:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(466, 89);
            label10.Name = "label10";
            label10.Size = new Size(82, 20);
            label10.TabIndex = 110;
            label10.Text = "Kalan nimi:";
            // 
            // kalanimitextBox
            // 
            kalanimitextBox.Location = new Point(466, 112);
            kalanimitextBox.MaxLength = 30;
            kalanimitextBox.Name = "kalanimitextBox";
            kalanimitextBox.Size = new Size(329, 27);
            kalanimitextBox.TabIndex = 109;
            // 
            // kalapictureBox
            // 
            kalapictureBox.Location = new Point(40, 196);
            kalapictureBox.Name = "kalapictureBox";
            kalapictureBox.Size = new Size(354, 200);
            kalapictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            kalapictureBox.TabIndex = 108;
            kalapictureBox.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(suljeNappi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(822, 48);
            panel1.TabIndex = 106;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            label1.Location = new Point(38, 79);
            label1.Name = "label1";
            label1.Size = new Size(319, 35);
            label1.TabIndex = 107;
            label1.Text = "Kalapankki - Lisää kalalaji ";
            // 
            // admin_kalapankki_lisää_lisääkalanäkymä
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 695);
            Controls.Add(imgurUrltextBox);
            Controls.Add(poistaKuvabutton);
            Controls.Add(lisääKuvabutton);
            Controls.Add(label12);
            Controls.Add(kalaIDtextBox);
            Controls.Add(label11);
            Controls.Add(lisääNappi);
            Controls.Add(elinympäristötextBox);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(tyypillinenpainotextBox);
            Controls.Add(alamittatextBox);
            Controls.Add(label7);
            Controls.Add(kalakuvausrichTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tyypillinenkokotextBox);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(kalanimitextBox);
            Controls.Add(kalapictureBox);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_kalapankki_lisää_lisääkalanäkymä";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_kalapankki_lisää_lisääkalanäkymä";
            ((System.ComponentModel.ISupportInitialize)kalapictureBox).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox imgurUrltextBox;
        private Button poistaKuvabutton;
        private Button lisääKuvabutton;
        private Label label2;
        private Label label12;
        private Button suljeNappi;
        private TextBox kalaIDtextBox;
        private Label label11;
        private Button lisääNappi;
        private TextBox elinympäristötextBox;
        private Label label8;
        private Label label9;
        private TextBox tyypillinenpainotextBox;
        private TextBox alamittatextBox;
        private Label label7;
        private RichTextBox kalakuvausrichTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tyypillinenkokotextBox;
        private Label label3;
        private Label label10;
        private TextBox kalanimitextBox;
        private PictureBox kalapictureBox;
        private Panel panel1;
        private Label label1;
    }
}