namespace KalaKaveri_v1
{
    partial class admin_etusivu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_etusivu));
            panel1 = new Panel();
            suljeButton = new Button();
            kirjauduUlosNappi = new Button();
            kalapankkiNappi = new Button();
            käyttäjähallintaNappi = new Button();
            etusivuNappi = new Button();
            kalastuspaikatNappi = new Button();
            label2 = new Label();
            inforichTextBox = new RichTextBox();
            nimitextBox = new TextBox();
            label3 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(suljeButton);
            panel1.Controls.Add(kirjauduUlosNappi);
            panel1.Controls.Add(kalapankkiNappi);
            panel1.Controls.Add(käyttäjähallintaNappi);
            panel1.Controls.Add(etusivuNappi);
            panel1.Controls.Add(kalastuspaikatNappi);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(870, 48);
            panel1.TabIndex = 12;
            // 
            // suljeButton
            // 
            suljeButton.BackgroundImage = (Image)resources.GetObject("suljeButton.BackgroundImage");
            suljeButton.BackgroundImageLayout = ImageLayout.Center;
            suljeButton.Dock = DockStyle.Right;
            suljeButton.FlatAppearance.BorderSize = 0;
            suljeButton.FlatStyle = FlatStyle.Flat;
            suljeButton.Location = new Point(823, 0);
            suljeButton.Name = "suljeButton";
            suljeButton.Size = new Size(47, 48);
            suljeButton.TabIndex = 14;
            suljeButton.UseVisualStyleBackColor = true;
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
            kalapankkiNappi.Location = new Point(490, 2);
            kalapankkiNappi.Name = "kalapankkiNappi";
            kalapankkiNappi.Size = new Size(112, 45);
            kalapankkiNappi.TabIndex = 12;
            kalapankkiNappi.Text = "Kalapankki";
            kalapankkiNappi.UseVisualStyleBackColor = true;
            kalapankkiNappi.Click += kalapankkiNappi_Click;
            // 
            // käyttäjähallintaNappi
            // 
            käyttäjähallintaNappi.Location = new Point(245, 2);
            käyttäjähallintaNappi.Name = "käyttäjähallintaNappi";
            käyttäjähallintaNappi.Size = new Size(121, 45);
            käyttäjähallintaNappi.TabIndex = 11;
            käyttäjähallintaNappi.Text = "Käyttäjähallinta";
            käyttäjähallintaNappi.UseVisualStyleBackColor = true;
            käyttäjähallintaNappi.Click += käyttäjähallintaNappi_Click;
            // 
            // etusivuNappi
            // 
            etusivuNappi.BackColor = Color.Khaki;
            etusivuNappi.Location = new Point(127, 2);
            etusivuNappi.Name = "etusivuNappi";
            etusivuNappi.Size = new Size(112, 45);
            etusivuNappi.TabIndex = 10;
            etusivuNappi.Text = "Etusivu";
            etusivuNappi.UseVisualStyleBackColor = false;
            // 
            // kalastuspaikatNappi
            // 
            kalastuspaikatNappi.Location = new Point(372, 2);
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
            // inforichTextBox
            // 
            inforichTextBox.BackColor = Color.White;
            inforichTextBox.Location = new Point(3, 0);
            inforichTextBox.Name = "inforichTextBox";
            inforichTextBox.ReadOnly = true;
            inforichTextBox.Size = new Size(733, 315);
            inforichTextBox.TabIndex = 16;
            inforichTextBox.Text = "";
            // 
            // nimitextBox
            // 
            nimitextBox.BorderStyle = BorderStyle.None;
            nimitextBox.Location = new Point(152, 83);
            nimitextBox.Name = "nimitextBox";
            nimitextBox.ReadOnly = true;
            nimitextBox.Size = new Size(175, 20);
            nimitextBox.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 83);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 14;
            label3.Text = "Tervetuloa,";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 130);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 13;
            label1.Text = "Viimeaikainen toimintasi:";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(inforichTextBox);
            panel2.Location = new Point(65, 153);
            panel2.Name = "panel2";
            panel2.Size = new Size(739, 333);
            panel2.TabIndex = 57;
            // 
            // admin_etusivu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 522);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(nimitextBox);
            Controls.Add(label3);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_etusivu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_etusivu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
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
        private RichTextBox inforichTextBox;
        private TextBox nimitextBox;
        private Label label3;
        private Label label1;
        private Button suljeButton;
        private Panel panel2;
    }
}