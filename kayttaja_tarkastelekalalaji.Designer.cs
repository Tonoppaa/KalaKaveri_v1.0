namespace KalaKaveri_v1
{
    partial class kayttaja_tarkastelekalalaji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayttaja_tarkastelekalalaji));
            panel1 = new Panel();
            label2 = new Label();
            suljeNappi = new Button();
            alamittatextBox = new TextBox();
            label7 = new Label();
            kalakuvausrichTextBox = new RichTextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            tyypillinenkokotextBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            kalanimitextBox = new TextBox();
            kalapictureBox = new PictureBox();
            tyypillinenpainotextBox = new TextBox();
            elinympäristötextBox = new TextBox();
            label8 = new Label();
            label9 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kalapictureBox).BeginInit();
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
            suljeNappi.Location = new Point(843, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // alamittatextBox
            // 
            alamittatextBox.Location = new Point(460, 223);
            alamittatextBox.Name = "alamittatextBox";
            alamittatextBox.ReadOnly = true;
            alamittatextBox.Size = new Size(327, 27);
            alamittatextBox.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(460, 198);
            label7.Name = "label7";
            label7.Size = new Size(69, 20);
            label7.TabIndex = 41;
            label7.Text = "Alamitta:";
            // 
            // kalakuvausrichTextBox
            // 
            kalakuvausrichTextBox.Location = new Point(52, 358);
            kalakuvausrichTextBox.Name = "kalakuvausrichTextBox";
            kalakuvausrichTextBox.ReadOnly = true;
            kalakuvausrichTextBox.Size = new Size(735, 117);
            kalakuvausrichTextBox.TabIndex = 40;
            kalakuvausrichTextBox.Text = "";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(52, 335);
            label6.Name = "label6";
            label6.Size = new Size(97, 20);
            label6.TabIndex = 39;
            label6.Text = "Kalan kuvaus:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(454, 223);
            label5.Name = "label5";
            label5.Size = new Size(0, 20);
            label5.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(460, 132);
            label4.Name = "label4";
            label4.Size = new Size(124, 20);
            label4.TabIndex = 37;
            label4.Text = "Tyypillinen paino:";
            // 
            // tyypillinenkokotextBox
            // 
            tyypillinenkokotextBox.Location = new Point(460, 93);
            tyypillinenkokotextBox.Name = "tyypillinenkokotextBox";
            tyypillinenkokotextBox.ReadOnly = true;
            tyypillinenkokotextBox.Size = new Size(327, 27);
            tyypillinenkokotextBox.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(460, 70);
            label3.Name = "label3";
            label3.Size = new Size(126, 20);
            label3.TabIndex = 34;
            label3.Text = "Tyypillinen pituus:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(52, 70);
            label1.Name = "label1";
            label1.Size = new Size(82, 20);
            label1.TabIndex = 33;
            label1.Text = "Kalan nimi:";
            // 
            // kalanimitextBox
            // 
            kalanimitextBox.Location = new Point(52, 93);
            kalanimitextBox.Name = "kalanimitextBox";
            kalanimitextBox.ReadOnly = true;
            kalanimitextBox.Size = new Size(354, 27);
            kalanimitextBox.TabIndex = 32;
            // 
            // kalapictureBox
            // 
            kalapictureBox.Location = new Point(52, 132);
            kalapictureBox.Name = "kalapictureBox";
            kalapictureBox.Size = new Size(354, 189);
            kalapictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            kalapictureBox.TabIndex = 31;
            kalapictureBox.TabStop = false;
            // 
            // tyypillinenpainotextBox
            // 
            tyypillinenpainotextBox.Location = new Point(460, 155);
            tyypillinenpainotextBox.Name = "tyypillinenpainotextBox";
            tyypillinenpainotextBox.ReadOnly = true;
            tyypillinenpainotextBox.Size = new Size(327, 27);
            tyypillinenpainotextBox.TabIndex = 43;
            // 
            // elinympäristötextBox
            // 
            elinympäristötextBox.Location = new Point(460, 294);
            elinympäristötextBox.Name = "elinympäristötextBox";
            elinympäristötextBox.ReadOnly = true;
            elinympäristötextBox.Size = new Size(327, 27);
            elinympäristötextBox.TabIndex = 46;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(460, 269);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 45;
            label8.Text = "Elinympäristö:";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(454, 294);
            label9.Name = "label9";
            label9.Size = new Size(0, 20);
            label9.TabIndex = 44;
            // 
            // kayttaja_tarkastelekalalaji
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 510);
            Controls.Add(elinympäristötextBox);
            Controls.Add(label8);
            Controls.Add(label9);
            Controls.Add(tyypillinenpainotextBox);
            Controls.Add(panel1);
            Controls.Add(alamittatextBox);
            Controls.Add(label7);
            Controls.Add(kalakuvausrichTextBox);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(tyypillinenkokotextBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(kalanimitextBox);
            Controls.Add(kalapictureBox);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kayttaja_tarkastelekalalaji";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kayttaja_tarkastelekalalaji";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)kalapictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button suljeNappi;
        private TextBox alamittatextBox;
        private Label label7;
        private RichTextBox kalakuvausrichTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private TextBox tyypillinenkokotextBox;
        private Label label3;
        private Label label1;
        private TextBox kalanimitextBox;
        private PictureBox kalapictureBox;
        private TextBox tyypillinenpainotextBox;
        private TextBox elinympäristötextBox;
        private Label label8;
        private Label label9;
    }
}