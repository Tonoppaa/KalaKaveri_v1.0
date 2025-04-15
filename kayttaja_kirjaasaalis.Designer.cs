namespace KalaKaveri_v1
{
    partial class kayttaja_kirjaasaalis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayttaja_kirjaasaalis));
            panel1 = new Panel();
            label2 = new Label();
            suljeNappi = new Button();
            label1 = new Label();
            kalakuvapictureBox = new PictureBox();
            lisaakuvaNappi = new Button();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label8 = new Label();
            kalalajicomboBox = new ComboBox();
            label9 = new Label();
            pituustextBox = new TextBox();
            painotextBox = new TextBox();
            label7 = new Label();
            säätextBox = new TextBox();
            lisätiedotrichTextBox = new RichTextBox();
            kirjaasaalisNappi = new Button();
            paikkacomboBox = new ComboBox();
            label10 = new Label();
            label11 = new Label();
            pvmdateTimePicker = new DateTimePicker();
            poistakuvaNappi = new Button();
            label12 = new Label();
            label13 = new Label();
            nykyinensaalisIDtextBox = new TextBox();
            label14 = new Label();
            label16 = new Label();
            imgurKuvalinkkitextBox = new TextBox();
            kalaIDtextBox = new TextBox();
            paikkaIDtextBox = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kalakuvapictureBox).BeginInit();
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
            panel1.Size = new Size(831, 48);
            panel1.TabIndex = 19;
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
            suljeNappi.Location = new Point(784, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 75);
            label1.Name = "label1";
            label1.Size = new Size(207, 46);
            label1.TabIndex = 22;
            label1.Text = "Kirjaa saalis";
            // 
            // kalakuvapictureBox
            // 
            kalakuvapictureBox.Location = new Point(39, 133);
            kalakuvapictureBox.Name = "kalakuvapictureBox";
            kalakuvapictureBox.Size = new Size(332, 221);
            kalakuvapictureBox.TabIndex = 23;
            kalakuvapictureBox.TabStop = false;
            // 
            // lisaakuvaNappi
            // 
            lisaakuvaNappi.Location = new Point(39, 373);
            lisaakuvaNappi.Name = "lisaakuvaNappi";
            lisaakuvaNappi.Size = new Size(332, 43);
            lisaakuvaNappi.TabIndex = 24;
            lisaakuvaNappi.Text = "Lisää kuva";
            lisaakuvaNappi.UseVisualStyleBackColor = true;
            lisaakuvaNappi.Click += lisaakuvaNappi_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(435, 188);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 25;
            label3.Text = "Pituus";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(435, 237);
            label4.Name = "label4";
            label4.Size = new Size(45, 20);
            label4.TabIndex = 26;
            label4.Text = "Paino";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(435, 287);
            label5.Name = "label5";
            label5.Size = new Size(85, 20);
            label5.TabIndex = 27;
            label5.Text = "Päivämäärä";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(435, 334);
            label6.Name = "label6";
            label6.Size = new Size(50, 20);
            label6.TabIndex = 28;
            label6.Text = "Paikka";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(39, 419);
            label8.Name = "label8";
            label8.Size = new Size(74, 20);
            label8.TabIndex = 30;
            label8.Text = "Lisätiedot";
            // 
            // kalalajicomboBox
            // 
            kalalajicomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            kalalajicomboBox.FormattingEnabled = true;
            kalalajicomboBox.Location = new Point(526, 133);
            kalalajicomboBox.Name = "kalalajicomboBox";
            kalalajicomboBox.Size = new Size(262, 28);
            kalalajicomboBox.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(435, 136);
            label9.Name = "label9";
            label9.Size = new Size(58, 20);
            label9.TabIndex = 32;
            label9.Text = "Kalalaji";
            // 
            // pituustextBox
            // 
            pituustextBox.Location = new Point(526, 181);
            pituustextBox.Name = "pituustextBox";
            pituustextBox.Size = new Size(262, 27);
            pituustextBox.TabIndex = 33;
            // 
            // painotextBox
            // 
            painotextBox.Location = new Point(526, 234);
            painotextBox.Name = "painotextBox";
            painotextBox.Size = new Size(262, 27);
            painotextBox.TabIndex = 34;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(435, 384);
            label7.Name = "label7";
            label7.Size = new Size(33, 20);
            label7.TabIndex = 37;
            label7.Text = "Sää";
            // 
            // säätextBox
            // 
            säätextBox.Location = new Point(526, 381);
            säätextBox.MaxLength = 100;
            säätextBox.Name = "säätextBox";
            säätextBox.Size = new Size(262, 27);
            säätextBox.TabIndex = 38;
            // 
            // lisätiedotrichTextBox
            // 
            lisätiedotrichTextBox.Location = new Point(39, 442);
            lisätiedotrichTextBox.MaxLength = 500;
            lisätiedotrichTextBox.Name = "lisätiedotrichTextBox";
            lisätiedotrichTextBox.Size = new Size(735, 91);
            lisätiedotrichTextBox.TabIndex = 39;
            lisätiedotrichTextBox.Text = "";
            // 
            // kirjaasaalisNappi
            // 
            kirjaasaalisNappi.Location = new Point(39, 552);
            kirjaasaalisNappi.Name = "kirjaasaalisNappi";
            kirjaasaalisNappi.Size = new Size(735, 53);
            kirjaasaalisNappi.TabIndex = 40;
            kirjaasaalisNappi.Text = "Kirjaa saalis";
            kirjaasaalisNappi.UseVisualStyleBackColor = true;
            kirjaasaalisNappi.Click += kirjaasaalisNappi_Click;
            // 
            // paikkacomboBox
            // 
            paikkacomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            paikkacomboBox.FormattingEnabled = true;
            paikkacomboBox.Location = new Point(526, 331);
            paikkacomboBox.Name = "paikkacomboBox";
            paikkacomboBox.Size = new Size(262, 28);
            paikkacomboBox.TabIndex = 42;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(794, 188);
            label10.Name = "label10";
            label10.Size = new Size(29, 20);
            label10.TabIndex = 43;
            label10.Text = "cm";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(794, 237);
            label11.Name = "label11";
            label11.Size = new Size(18, 20);
            label11.TabIndex = 44;
            label11.Text = "g";
            // 
            // pvmdateTimePicker
            // 
            pvmdateTimePicker.Checked = false;
            pvmdateTimePicker.Location = new Point(526, 282);
            pvmdateTimePicker.MaxDate = new DateTime(2900, 12, 31, 0, 0, 0, 0);
            pvmdateTimePicker.MinDate = new DateTime(1900, 1, 1, 0, 0, 0, 0);
            pvmdateTimePicker.Name = "pvmdateTimePicker";
            pvmdateTimePicker.Size = new Size(262, 27);
            pvmdateTimePicker.TabIndex = 45;
            // 
            // poistakuvaNappi
            // 
            poistakuvaNappi.BackColor = SystemColors.Control;
            poistakuvaNappi.BackgroundImage = (Image)resources.GetObject("poistakuvaNappi.BackgroundImage");
            poistakuvaNappi.BackgroundImageLayout = ImageLayout.Stretch;
            poistakuvaNappi.Location = new Point(377, 373);
            poistakuvaNappi.Name = "poistakuvaNappi";
            poistakuvaNappi.Size = new Size(39, 35);
            poistakuvaNappi.TabIndex = 46;
            poistakuvaNappi.UseVisualStyleBackColor = false;
            poistakuvaNappi.Click += poistakuvaNappi_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(39, 666);
            label12.Name = "label12";
            label12.Size = new Size(73, 20);
            label12.TabIndex = 52;
            label12.Text = "paikka_ID";
            label12.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(198, 666);
            label13.Name = "label13";
            label13.Size = new Size(57, 20);
            label13.TabIndex = 53;
            label13.Text = "kala_ID";
            label13.Visible = false;
            // 
            // nykyinensaalisIDtextBox
            // 
            nykyinensaalisIDtextBox.Location = new Point(344, 689);
            nykyinensaalisIDtextBox.Name = "nykyinensaalisIDtextBox";
            nykyinensaalisIDtextBox.ReadOnly = true;
            nykyinensaalisIDtextBox.Size = new Size(135, 27);
            nykyinensaalisIDtextBox.TabIndex = 54;
            nykyinensaalisIDtextBox.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(344, 666);
            label14.Name = "label14";
            label14.Size = new Size(127, 20);
            label14.TabIndex = 55;
            label14.Text = "nykyinen saalis_ID";
            label14.Visible = false;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(499, 666);
            label16.Name = "label16";
            label16.Size = new Size(68, 20);
            label16.TabIndex = 59;
            label16.Text = "kuvan url";
            label16.Visible = false;
            // 
            // imgurKuvalinkkitextBox
            // 
            imgurKuvalinkkitextBox.Location = new Point(499, 689);
            imgurKuvalinkkitextBox.Name = "imgurKuvalinkkitextBox";
            imgurKuvalinkkitextBox.ReadOnly = true;
            imgurKuvalinkkitextBox.Size = new Size(355, 27);
            imgurKuvalinkkitextBox.TabIndex = 58;
            imgurKuvalinkkitextBox.Visible = false;
            // 
            // kalaIDtextBox
            // 
            kalaIDtextBox.Location = new Point(198, 689);
            kalaIDtextBox.Name = "kalaIDtextBox";
            kalaIDtextBox.ReadOnly = true;
            kalaIDtextBox.Size = new Size(125, 27);
            kalaIDtextBox.TabIndex = 60;
            kalaIDtextBox.Visible = false;
            // 
            // paikkaIDtextBox
            // 
            paikkaIDtextBox.Location = new Point(39, 689);
            paikkaIDtextBox.Name = "paikkaIDtextBox";
            paikkaIDtextBox.ReadOnly = true;
            paikkaIDtextBox.Size = new Size(125, 27);
            paikkaIDtextBox.TabIndex = 61;
            paikkaIDtextBox.Visible = false;
            // 
            // kayttaja_kirjaasaalis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(831, 630);
            Controls.Add(paikkaIDtextBox);
            Controls.Add(kalaIDtextBox);
            Controls.Add(label16);
            Controls.Add(imgurKuvalinkkitextBox);
            Controls.Add(label14);
            Controls.Add(nykyinensaalisIDtextBox);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(poistakuvaNappi);
            Controls.Add(pvmdateTimePicker);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(paikkacomboBox);
            Controls.Add(kirjaasaalisNappi);
            Controls.Add(lisätiedotrichTextBox);
            Controls.Add(säätextBox);
            Controls.Add(label7);
            Controls.Add(painotextBox);
            Controls.Add(pituustextBox);
            Controls.Add(label9);
            Controls.Add(kalalajicomboBox);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(lisaakuvaNappi);
            Controls.Add(kalakuvapictureBox);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kayttaja_kirjaasaalis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kayttaja_kirjaasaalis";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kalakuvapictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button suljeNappi;
        private Label label1;
        private PictureBox kalakuvapictureBox;
        private Button lisaakuvaNappi;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label8;
        private ComboBox kalalajicomboBox;
        private Label label9;
        private TextBox pituustextBox;
        private TextBox painotextBox;
        private Label label7;
        private TextBox säätextBox;
        private RichTextBox lisätiedotrichTextBox;
        private Button kirjaasaalisNappi;
        private ComboBox paikkacomboBox;
        private Label label10;
        private Label label11;
        private DateTimePicker pvmdateTimePicker;
        private Button poistakuvaNappi;
        private Label label12;
        private Label label13;
        private TextBox nykyinensaalisIDtextBox;
        private Label label14;
        private Label label16;
        private TextBox imgurKuvalinkkitextBox;
        private TextBox kalaIDtextBox;
        private TextBox paikkaIDtextBox;
    }
}