namespace KalaKaveri_v1
{
    partial class admin_kalastuspaikat_lisää_kalastuspaikka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_kalastuspaikat_lisää_kalastuspaikka));
            label12 = new Label();
            imgurUrltextBox = new TextBox();
            lisääKuvabutton = new Button();
            poistaKuvabutton = new Button();
            label9 = new Label();
            paikkaIDtextBox = new TextBox();
            label8 = new Label();
            lisääKalastuspaikkabutton = new Button();
            panel1 = new Panel();
            label2 = new Label();
            suljeNappi = new Button();
            paikkakuvausrichTextBox = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            kalastusmenetelmärichTextBox = new RichTextBox();
            label7 = new Label();
            kaupunkitextBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            vesistötextBox = new TextBox();
            label4 = new Label();
            vesistöpictureBox = new PictureBox();
            koordinaatittextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vesistöpictureBox).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(526, 429);
            label12.Name = "label12";
            label12.Size = new Size(72, 20);
            label12.TabIndex = 132;
            label12.Text = "imgur url:";
            label12.Visible = false;
            // 
            // imgurUrltextBox
            // 
            imgurUrltextBox.Location = new Point(599, 423);
            imgurUrltextBox.Name = "imgurUrltextBox";
            imgurUrltextBox.ReadOnly = true;
            imgurUrltextBox.Size = new Size(192, 27);
            imgurUrltextBox.TabIndex = 131;
            imgurUrltextBox.Visible = false;
            // 
            // lisääKuvabutton
            // 
            lisääKuvabutton.Location = new Point(32, 411);
            lisääKuvabutton.Name = "lisääKuvabutton";
            lisääKuvabutton.Size = new Size(99, 29);
            lisääKuvabutton.TabIndex = 130;
            lisääKuvabutton.Text = "Lisää kuva";
            lisääKuvabutton.UseVisualStyleBackColor = true;
            lisääKuvabutton.Click += lisääKuvabutton_Click;
            // 
            // poistaKuvabutton
            // 
            poistaKuvabutton.BackgroundImage = (Image)resources.GetObject("poistaKuvabutton.BackgroundImage");
            poistaKuvabutton.BackgroundImageLayout = ImageLayout.Zoom;
            poistaKuvabutton.Location = new Point(403, 378);
            poistaKuvabutton.Name = "poistaKuvabutton";
            poistaKuvabutton.Size = new Size(30, 29);
            poistaKuvabutton.TabIndex = 129;
            poistaKuvabutton.UseVisualStyleBackColor = true;
            poistaKuvabutton.Visible = false;
            poistaKuvabutton.Click += poistaKuvabutton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(32, 77);
            label9.Name = "label9";
            label9.Size = new Size(447, 35);
            label9.TabIndex = 127;
            label9.Text = "Kalastuspaikka - Lisää kalastuspaikka";
            // 
            // paikkaIDtextBox
            // 
            paikkaIDtextBox.Location = new Point(32, 145);
            paikkaIDtextBox.Name = "paikkaIDtextBox";
            paikkaIDtextBox.ReadOnly = true;
            paikkaIDtextBox.Size = new Size(365, 27);
            paikkaIDtextBox.TabIndex = 126;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(32, 122);
            label8.Name = "label8";
            label8.Size = new Size(73, 20);
            label8.TabIndex = 125;
            label8.Text = "Paikan ID:";
            // 
            // lisääKalastuspaikkabutton
            // 
            lisääKalastuspaikkabutton.Location = new Point(32, 613);
            lisääKalastuspaikkabutton.Name = "lisääKalastuspaikkabutton";
            lisääKalastuspaikkabutton.Size = new Size(759, 53);
            lisääKalastuspaikkabutton.TabIndex = 124;
            lisääKalastuspaikkabutton.Text = "Lisää kalastuspaikka";
            lisääKalastuspaikkabutton.UseVisualStyleBackColor = true;
            lisääKalastuspaikkabutton.Click += lisääKalastuspaikkabutton_Click;
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
            panel1.TabIndex = 111;
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
            // paikkakuvausrichTextBox
            // 
            paikkakuvausrichTextBox.Location = new Point(32, 481);
            paikkakuvausrichTextBox.Name = "paikkakuvausrichTextBox";
            paikkakuvausrichTextBox.Size = new Size(759, 117);
            paikkakuvausrichTextBox.TabIndex = 121;
            paikkakuvausrichTextBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(32, 458);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 120;
            label6.Text = "Paikan kuvaus:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(430, 345);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 119;
            // 
            // kalastusmenetelmärichTextBox
            // 
            kalastusmenetelmärichTextBox.Location = new Point(464, 281);
            kalastusmenetelmärichTextBox.Name = "kalastusmenetelmärichTextBox";
            kalastusmenetelmärichTextBox.Size = new Size(327, 54);
            kalastusmenetelmärichTextBox.TabIndex = 117;
            kalastusmenetelmärichTextBox.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(464, 356);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 122;
            label7.Text = "Koordinaatit:";
            // 
            // kaupunkitextBox
            // 
            kaupunkitextBox.Location = new Point(464, 210);
            kaupunkitextBox.Name = "kaupunkitextBox";
            kaupunkitextBox.Size = new Size(327, 27);
            kaupunkitextBox.TabIndex = 116;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(459, 187);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 115;
            label3.Text = "Kaupunki:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(464, 122);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 114;
            label1.Text = "Vesistö:";
            // 
            // vesistötextBox
            // 
            vesistötextBox.Location = new Point(464, 145);
            vesistötextBox.Name = "vesistötextBox";
            vesistötextBox.Size = new Size(327, 27);
            vesistötextBox.TabIndex = 113;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(459, 258);
            label4.Name = "label4";
            label4.Size = new Size(194, 20);
            label4.TabIndex = 118;
            label4.Text = "Sallitut kalastusmenetelmät:";
            // 
            // vesistöpictureBox
            // 
            vesistöpictureBox.Location = new Point(32, 178);
            vesistöpictureBox.Name = "vesistöpictureBox";
            vesistöpictureBox.Size = new Size(365, 227);
            vesistöpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            vesistöpictureBox.TabIndex = 112;
            vesistöpictureBox.TabStop = false;
            // 
            // koordinaatittextBox
            // 
            koordinaatittextBox.Location = new Point(464, 379);
            koordinaatittextBox.Name = "koordinaatittextBox";
            koordinaatittextBox.Size = new Size(327, 27);
            koordinaatittextBox.TabIndex = 123;
            // 
            // admin_kalastuspaikat_lisää_kalastuspaikka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(828, 694);
            Controls.Add(label12);
            Controls.Add(imgurUrltextBox);
            Controls.Add(lisääKuvabutton);
            Controls.Add(poistaKuvabutton);
            Controls.Add(label9);
            Controls.Add(paikkaIDtextBox);
            Controls.Add(label8);
            Controls.Add(lisääKalastuspaikkabutton);
            Controls.Add(panel1);
            Controls.Add(paikkakuvausrichTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(kalastusmenetelmärichTextBox);
            Controls.Add(label7);
            Controls.Add(kaupunkitextBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(vesistötextBox);
            Controls.Add(label4);
            Controls.Add(vesistöpictureBox);
            Controls.Add(koordinaatittextBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_kalastuspaikat_lisää_kalastuspaikka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_kalastuspaikat_lisää_kalastuspaikka";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vesistöpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label12;
        private TextBox imgurUrltextBox;
        private Button lisääKuvabutton;
        private Button poistaKuvabutton;
        private Label label9;
        private TextBox paikkaIDtextBox;
        private Label label8;
        private Button lisääKalastuspaikkabutton;
        private Panel panel1;
        private Label label2;
        private Button suljeNappi;
        private RichTextBox paikkakuvausrichTextBox;
        private Label label6;
        private Label label5;
        private RichTextBox kalastusmenetelmärichTextBox;
        private Label label7;
        private TextBox kaupunkitextBox;
        private Label label3;
        private Label label1;
        private TextBox vesistötextBox;
        private Label label4;
        private PictureBox vesistöpictureBox;
        private TextBox koordinaatittextBox;
    }
}