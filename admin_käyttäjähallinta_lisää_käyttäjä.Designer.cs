namespace KalaKaveri_v1
{
    partial class admin_käyttäjähallinta_lisää_käyttäjä
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_käyttäjähallinta_lisää_käyttäjä));
            lisääKäyttäjäbutton = new Button();
            salasanatextBox = new TextBox();
            label7 = new Label();
            etunimitextBox = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            suljeNappi = new Button();
            sukunimitextBox = new TextBox();
            panel1 = new Panel();
            käyttäjäIDtextBox = new TextBox();
            roolicomboBox = new ComboBox();
            sähköpostitextBox = new TextBox();
            osoitetextBox = new TextBox();
            generoiSalasanabutton = new Button();
            näytäSalasanaButton = new Button();
            admintekstitextBox = new TextBox();
            usertekstitextBox = new TextBox();
            userNumerotextBox = new TextBox();
            adminNumerotextBox = new TextBox();
            uusiKäyttäjäIDtextBox = new TextBox();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            label13 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lisääKäyttäjäbutton
            // 
            lisääKäyttäjäbutton.Location = new Point(68, 477);
            lisääKäyttäjäbutton.Name = "lisääKäyttäjäbutton";
            lisääKäyttäjäbutton.Size = new Size(580, 53);
            lisääKäyttäjäbutton.TabIndex = 78;
            lisääKäyttäjäbutton.Text = "Lisää käyttäjä";
            lisääKäyttäjäbutton.UseVisualStyleBackColor = true;
            lisääKäyttäjäbutton.Click += lisääKäyttäjäbutton_Click;
            // 
            // salasanatextBox
            // 
            salasanatextBox.Font = new Font("Segoe UI", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            salasanatextBox.Location = new Point(172, 354);
            salasanatextBox.MaxLength = 20;
            salasanatextBox.Name = "salasanatextBox";
            salasanatextBox.PlaceholderText = "väh. 8, max. 20 merkkiä";
            salasanatextBox.Size = new Size(363, 27);
            salasanatextBox.TabIndex = 76;
            salasanatextBox.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(68, 361);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 75;
            label7.Text = "Salasana:";
            // 
            // etunimitextBox
            // 
            etunimitextBox.Location = new Point(172, 171);
            etunimitextBox.MaxLength = 50;
            etunimitextBox.Name = "etunimitextBox";
            etunimitextBox.Size = new Size(363, 27);
            etunimitextBox.TabIndex = 73;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(62, 596);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 72;
            label9.Text = "käyttäjäID:";
            label9.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 430);
            label8.Name = "label8";
            label8.Size = new Size(47, 20);
            label8.TabIndex = 70;
            label8.Text = "Rooli:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(68, 312);
            label6.Name = "label6";
            label6.Size = new Size(85, 20);
            label6.TabIndex = 69;
            label6.Text = "Sähköposti:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(68, 269);
            label5.Name = "label5";
            label5.Size = new Size(55, 20);
            label5.TabIndex = 68;
            label5.Text = "Osoite:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(68, 220);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 67;
            label4.Text = "Sukunimi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 174);
            label3.Name = "label3";
            label3.Size = new Size(62, 20);
            label3.TabIndex = 66;
            label3.Text = "Etunimi:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(126, 84);
            label1.Name = "label1";
            label1.Size = new Size(454, 41);
            label1.TabIndex = 63;
            label1.Text = "Käyttäjähallinta - lisää käyttäjä";
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
            suljeNappi.Location = new Point(679, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // sukunimitextBox
            // 
            sukunimitextBox.Location = new Point(172, 213);
            sukunimitextBox.MaxLength = 80;
            sukunimitextBox.Name = "sukunimitextBox";
            sukunimitextBox.Size = new Size(363, 27);
            sukunimitextBox.TabIndex = 74;
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(suljeNappi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 48);
            panel1.TabIndex = 62;
            // 
            // käyttäjäIDtextBox
            // 
            käyttäjäIDtextBox.Location = new Point(62, 653);
            käyttäjäIDtextBox.Name = "käyttäjäIDtextBox";
            käyttäjäIDtextBox.ReadOnly = true;
            käyttäjäIDtextBox.Size = new Size(363, 27);
            käyttäjäIDtextBox.TabIndex = 80;
            käyttäjäIDtextBox.Visible = false;
            // 
            // roolicomboBox
            // 
            roolicomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            roolicomboBox.FormattingEnabled = true;
            roolicomboBox.Location = new Point(172, 422);
            roolicomboBox.Name = "roolicomboBox";
            roolicomboBox.Size = new Size(363, 28);
            roolicomboBox.TabIndex = 81;
            // 
            // sähköpostitextBox
            // 
            sähköpostitextBox.Location = new Point(172, 305);
            sähköpostitextBox.MaxLength = 100;
            sähköpostitextBox.Name = "sähköpostitextBox";
            sähköpostitextBox.Size = new Size(363, 27);
            sähköpostitextBox.TabIndex = 82;
            // 
            // osoitetextBox
            // 
            osoitetextBox.Location = new Point(172, 262);
            osoitetextBox.MaxLength = 100;
            osoitetextBox.Name = "osoitetextBox";
            osoitetextBox.Size = new Size(363, 27);
            osoitetextBox.TabIndex = 83;
            // 
            // generoiSalasanabutton
            // 
            generoiSalasanabutton.Font = new Font("Segoe UI", 7F);
            generoiSalasanabutton.Location = new Point(541, 388);
            generoiSalasanabutton.Name = "generoiSalasanabutton";
            generoiSalasanabutton.Size = new Size(107, 29);
            generoiSalasanabutton.TabIndex = 84;
            generoiSalasanabutton.Text = "Generoi salasana";
            generoiSalasanabutton.UseVisualStyleBackColor = true;
            generoiSalasanabutton.Click += generoiSalasanabutton_Click;
            // 
            // näytäSalasanaButton
            // 
            näytäSalasanaButton.Font = new Font("Segoe UI", 7F);
            näytäSalasanaButton.Location = new Point(541, 354);
            näytäSalasanaButton.Name = "näytäSalasanaButton";
            näytäSalasanaButton.Size = new Size(107, 29);
            näytäSalasanaButton.TabIndex = 85;
            näytäSalasanaButton.Text = "Näytä salasana";
            näytäSalasanaButton.UseVisualStyleBackColor = true;
            näytäSalasanaButton.MouseUp += näytäSalasanaButton_MouseUp;
            // 
            // admintekstitextBox
            // 
            admintekstitextBox.Location = new Point(431, 686);
            admintekstitextBox.Name = "admintekstitextBox";
            admintekstitextBox.ReadOnly = true;
            admintekstitextBox.Size = new Size(61, 27);
            admintekstitextBox.TabIndex = 86;
            admintekstitextBox.Visible = false;
            // 
            // usertekstitextBox
            // 
            usertekstitextBox.Location = new Point(431, 653);
            usertekstitextBox.Name = "usertekstitextBox";
            usertekstitextBox.ReadOnly = true;
            usertekstitextBox.Size = new Size(61, 27);
            usertekstitextBox.TabIndex = 87;
            usertekstitextBox.Visible = false;
            // 
            // userNumerotextBox
            // 
            userNumerotextBox.Location = new Point(498, 653);
            userNumerotextBox.Name = "userNumerotextBox";
            userNumerotextBox.ReadOnly = true;
            userNumerotextBox.Size = new Size(163, 27);
            userNumerotextBox.TabIndex = 88;
            userNumerotextBox.Visible = false;
            // 
            // adminNumerotextBox
            // 
            adminNumerotextBox.Location = new Point(498, 686);
            adminNumerotextBox.Name = "adminNumerotextBox";
            adminNumerotextBox.ReadOnly = true;
            adminNumerotextBox.Size = new Size(163, 27);
            adminNumerotextBox.TabIndex = 89;
            adminNumerotextBox.Visible = false;
            // 
            // uusiKäyttäjäIDtextBox
            // 
            uusiKäyttäjäIDtextBox.Location = new Point(166, 589);
            uusiKäyttäjäIDtextBox.Name = "uusiKäyttäjäIDtextBox";
            uusiKäyttäjäIDtextBox.ReadOnly = true;
            uusiKäyttäjäIDtextBox.Size = new Size(363, 27);
            uusiKäyttäjäIDtextBox.TabIndex = 91;
            uusiKäyttäjäIDtextBox.Visible = false;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(62, 576);
            label10.Name = "label10";
            label10.Size = new Size(69, 20);
            label10.TabIndex = 90;
            label10.Text = "Seuraava";
            label10.Visible = false;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(62, 635);
            label11.Name = "label11";
            label11.Size = new Size(143, 20);
            label11.TabIndex = 92;
            label11.Text = "Nykyinen käyttäjäID:";
            label11.Visible = false;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(385, 635);
            label12.Name = "label12";
            label12.Size = new Size(107, 20);
            label12.TabIndex = 93;
            label12.Text = "USER / ADMIN";
            label12.Visible = false;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(498, 635);
            label13.Name = "label13";
            label13.Size = new Size(119, 20);
            label13.TabIndex = 94;
            label13.Text = "Eritellyt numerot";
            label13.Visible = false;
            // 
            // admin_käyttäjähallinta_lisää_käyttäjä
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(726, 559);
            Controls.Add(label13);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(uusiKäyttäjäIDtextBox);
            Controls.Add(label10);
            Controls.Add(adminNumerotextBox);
            Controls.Add(userNumerotextBox);
            Controls.Add(usertekstitextBox);
            Controls.Add(admintekstitextBox);
            Controls.Add(näytäSalasanaButton);
            Controls.Add(generoiSalasanabutton);
            Controls.Add(osoitetextBox);
            Controls.Add(sähköpostitextBox);
            Controls.Add(roolicomboBox);
            Controls.Add(käyttäjäIDtextBox);
            Controls.Add(lisääKäyttäjäbutton);
            Controls.Add(salasanatextBox);
            Controls.Add(label7);
            Controls.Add(etunimitextBox);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(sukunimitextBox);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_käyttäjähallinta_lisää_käyttäjä";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_käyttäjähallinta_lisää_käyttäjä";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ComboBox paikkacomboBox;
        private Button lisääKäyttäjäbutton;
        private TextBox salasanatextBox;
        private Label label7;
        private TextBox etunimitextBox;
        private Label label9;
        private Label label8;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label label2;
        private Button suljeNappi;
        private TextBox sukunimitextBox;
        private Panel panel1;
        private TextBox käyttäjäIDtextBox;
        private ComboBox roolicomboBox;
        private TextBox sähköpostitextBox;
        private TextBox osoitetextBox;
        private Button generoiSalasanabutton;
        private Button näytäSalasanaButton;
        private TextBox admintekstitextBox;
        private TextBox usertekstitextBox;
        private TextBox userNumerotextBox;
        private TextBox adminNumerotextBox;
        private TextBox uusiKäyttäjäIDtextBox;
        private Label label10;
        private Label label11;
        private Label label12;
        private Label label13;
    }
}