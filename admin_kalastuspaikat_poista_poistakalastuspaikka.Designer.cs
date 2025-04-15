namespace KalaKaveri_v1
{
    partial class admin_kalastuspaikat_poista_poistakalastuspaikka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_kalastuspaikat_poista_poistakalastuspaikka));
            panel1 = new Panel();
            label2 = new Label();
            suljeNappi = new Button();
            koordinaatittextBox = new TextBox();
            label7 = new Label();
            paikkakuvausrichTextBox = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            kalastusmenetelmärichTextBox = new RichTextBox();
            kaupunkitextBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            vesistötextBox = new TextBox();
            vesistöpictureBox = new PictureBox();
            poistaKalastuspaikkabutton = new Button();
            paikkaIDtextBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vesistöpictureBox).BeginInit();
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
            panel1.Size = new Size(800, 48);
            panel1.TabIndex = 30;
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
            suljeNappi.Location = new Point(753, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // koordinaatittextBox
            // 
            koordinaatittextBox.Location = new Point(446, 390);
            koordinaatittextBox.Name = "koordinaatittextBox";
            koordinaatittextBox.ReadOnly = true;
            koordinaatittextBox.Size = new Size(327, 27);
            koordinaatittextBox.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(446, 367);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 41;
            label7.Text = "Koordinaatit:";
            // 
            // paikkakuvausrichTextBox
            // 
            paikkakuvausrichTextBox.Location = new Point(38, 455);
            paikkakuvausrichTextBox.Name = "paikkakuvausrichTextBox";
            paikkakuvausrichTextBox.ReadOnly = true;
            paikkakuvausrichTextBox.Size = new Size(735, 117);
            paikkakuvausrichTextBox.TabIndex = 40;
            paikkakuvausrichTextBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(38, 432);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 39;
            label6.Text = "Paikan kuvaus:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(436, 344);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(446, 256);
            label4.Name = "label4";
            label4.Size = new Size(194, 20);
            label4.TabIndex = 37;
            label4.Text = "Sallitut kalastusmenetelmät:";
            // 
            // kalastusmenetelmärichTextBox
            // 
            kalastusmenetelmärichTextBox.Location = new Point(446, 279);
            kalastusmenetelmärichTextBox.Name = "kalastusmenetelmärichTextBox";
            kalastusmenetelmärichTextBox.ReadOnly = true;
            kalastusmenetelmärichTextBox.Size = new Size(327, 85);
            kalastusmenetelmärichTextBox.TabIndex = 36;
            kalastusmenetelmärichTextBox.Text = "";
            // 
            // kaupunkitextBox
            // 
            kaupunkitextBox.Location = new Point(446, 204);
            kaupunkitextBox.Name = "kaupunkitextBox";
            kaupunkitextBox.ReadOnly = true;
            kaupunkitextBox.Size = new Size(327, 27);
            kaupunkitextBox.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(446, 181);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 34;
            label3.Text = "Kaupunki:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(38, 119);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 33;
            label1.Text = "Kalastuspaikka:";
            // 
            // vesistötextBox
            // 
            vesistötextBox.Location = new Point(38, 142);
            vesistötextBox.Name = "vesistötextBox";
            vesistötextBox.ReadOnly = true;
            vesistötextBox.Size = new Size(365, 27);
            vesistötextBox.TabIndex = 32;
            // 
            // vesistöpictureBox
            // 
            vesistöpictureBox.Location = new Point(38, 190);
            vesistöpictureBox.Name = "vesistöpictureBox";
            vesistöpictureBox.Size = new Size(365, 227);
            vesistöpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            vesistöpictureBox.TabIndex = 31;
            vesistöpictureBox.TabStop = false;
            // 
            // poistaKalastuspaikkabutton
            // 
            poistaKalastuspaikkabutton.Location = new Point(38, 587);
            poistaKalastuspaikkabutton.Name = "poistaKalastuspaikkabutton";
            poistaKalastuspaikkabutton.Size = new Size(735, 53);
            poistaKalastuspaikkabutton.TabIndex = 43;
            poistaKalastuspaikkabutton.Text = "Poista kalastuspaikka";
            poistaKalastuspaikkabutton.UseVisualStyleBackColor = true;
            poistaKalastuspaikkabutton.Click += poistaKalastuspaikkabutton_Click;
            // 
            // paikkaIDtextBox
            // 
            paikkaIDtextBox.Location = new Point(446, 142);
            paikkaIDtextBox.Name = "paikkaIDtextBox";
            paikkaIDtextBox.ReadOnly = true;
            paikkaIDtextBox.Size = new Size(327, 27);
            paikkaIDtextBox.TabIndex = 45;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(446, 119);
            label8.Name = "label8";
            label8.Size = new Size(68, 20);
            label8.TabIndex = 44;
            label8.Text = "PaikkaID:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.Location = new Point(28, 72);
            label9.Name = "label9";
            label9.Size = new Size(460, 35);
            label9.TabIndex = 63;
            label9.Text = "Kalastuspaikka - Poista kalastuspaikka";
            // 
            // admin_kalastuspaikat_poista_poistakalastuspaikka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 662);
            Controls.Add(label9);
            Controls.Add(paikkaIDtextBox);
            Controls.Add(label8);
            Controls.Add(poistaKalastuspaikkabutton);
            Controls.Add(panel1);
            Controls.Add(koordinaatittextBox);
            Controls.Add(label7);
            Controls.Add(paikkakuvausrichTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(kalastusmenetelmärichTextBox);
            Controls.Add(kaupunkitextBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(vesistötextBox);
            Controls.Add(vesistöpictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_kalastuspaikat_poista_poistakalastuspaikka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_kalastuspaikat_poista_poistakalastuspaikka";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)vesistöpictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button suljeNappi;
        private TextBox koordinaatittextBox;
        private Label label7;
        private RichTextBox paikkakuvausrichTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private RichTextBox kalastusmenetelmärichTextBox;
        private TextBox kaupunkitextBox;
        private Label label3;
        private Label label1;
        private TextBox vesistötextBox;
        private PictureBox vesistöpictureBox;
        private Button poistaKalastuspaikkabutton;
        private TextBox paikkaIDtextBox;
        private Label label8;
        private Label label9;
    }
}