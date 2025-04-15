namespace KalaKaveri_v1
{
    partial class kayttaja_tarkastelekalastuspaikka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayttaja_tarkastelekalastuspaikka));
            panel1 = new Panel();
            label2 = new Label();
            suljeNappi = new Button();
            vesistöpictureBox = new PictureBox();
            vesistötextBox = new TextBox();
            label1 = new Label();
            label3 = new Label();
            kaupunkitextBox = new TextBox();
            kalastusmenetelmärichTextBox = new RichTextBox();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            paikkakuvausrichTextBox = new RichTextBox();
            label7 = new Label();
            koordinaatittextBox = new TextBox();
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
            panel1.Size = new Size(890, 48);
            panel1.TabIndex = 17;
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
            // vesistöpictureBox
            // 
            vesistöpictureBox.Location = new Point(52, 130);
            vesistöpictureBox.Name = "vesistöpictureBox";
            vesistöpictureBox.Size = new Size(365, 217);
            vesistöpictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            vesistöpictureBox.TabIndex = 18;
            vesistöpictureBox.TabStop = false;
            // 
            // vesistötextBox
            // 
            vesistötextBox.Location = new Point(52, 90);
            vesistötextBox.Name = "vesistötextBox";
            vesistötextBox.ReadOnly = true;
            vesistötextBox.Size = new Size(365, 27);
            vesistötextBox.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 67);
            label1.Name = "label1";
            label1.Size = new Size(109, 20);
            label1.TabIndex = 20;
            label1.Text = "Kalastuspaikka:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(460, 67);
            label3.Name = "label3";
            label3.Size = new Size(73, 20);
            label3.TabIndex = 21;
            label3.Text = "Kaupunki:";
            // 
            // kaupunkitextBox
            // 
            kaupunkitextBox.Location = new Point(460, 90);
            kaupunkitextBox.Name = "kaupunkitextBox";
            kaupunkitextBox.ReadOnly = true;
            kaupunkitextBox.Size = new Size(327, 27);
            kaupunkitextBox.TabIndex = 22;
            // 
            // kalastusmenetelmärichTextBox
            // 
            kalastusmenetelmärichTextBox.Location = new Point(460, 153);
            kalastusmenetelmärichTextBox.Name = "kalastusmenetelmärichTextBox";
            kalastusmenetelmärichTextBox.ReadOnly = true;
            kalastusmenetelmärichTextBox.Size = new Size(327, 140);
            kalastusmenetelmärichTextBox.TabIndex = 23;
            kalastusmenetelmärichTextBox.Text = "";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(460, 130);
            label4.Name = "label4";
            label4.Size = new Size(194, 20);
            label4.TabIndex = 24;
            label4.Text = "Sallitut kalastusmenetelmät:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(450, 273);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 25;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 363);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 26;
            label6.Text = "Paikan kuvaus:";
            // 
            // paikkakuvausrichTextBox
            // 
            paikkakuvausrichTextBox.Location = new Point(52, 386);
            paikkakuvausrichTextBox.Name = "paikkakuvausrichTextBox";
            paikkakuvausrichTextBox.ReadOnly = true;
            paikkakuvausrichTextBox.Size = new Size(735, 117);
            paikkakuvausrichTextBox.TabIndex = 27;
            paikkakuvausrichTextBox.Text = "";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(460, 297);
            label7.Name = "label7";
            label7.Size = new Size(95, 20);
            label7.TabIndex = 28;
            label7.Text = "Koordinaatit:";
            // 
            // koordinaatittextBox
            // 
            koordinaatittextBox.Location = new Point(460, 320);
            koordinaatittextBox.Name = "koordinaatittextBox";
            koordinaatittextBox.ReadOnly = true;
            koordinaatittextBox.Size = new Size(327, 27);
            koordinaatittextBox.TabIndex = 29;
            // 
            // kayttaja_tarkastelekalastuspaikka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 539);
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
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kayttaja_tarkastelekalastuspaikka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kayttaja_tarkastelekalastuspaikka";
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
        private PictureBox vesistöpictureBox;
        private TextBox vesistötextBox;
        private Label label1;
        private Label label3;
        private TextBox kaupunkitextBox;
        private RichTextBox kalastusmenetelmärichTextBox;
        private Label label4;
        private Label label5;
        private Label label6;
        private RichTextBox paikkakuvausrichTextBox;
        private Label label7;
        private TextBox koordinaatittextBox;
    }
}