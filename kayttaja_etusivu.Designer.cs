namespace KalaKaveri_v1
{
    partial class kayttaja_etusivu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayttaja_etusivu));
            panel1 = new Panel();
            kirjauduUlosNappi = new Button();
            kalapankkiNappi = new Button();
            omatsaaliitNappi = new Button();
            etusivuNappi = new Button();
            kalastuspaikatNappi = new Button();
            label2 = new Label();
            suljeNappi = new Button();
            label1 = new Label();
            label3 = new Label();
            nimitextBox = new TextBox();
            inforichTextBox = new RichTextBox();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
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
            panel1.Size = new Size(875, 48);
            panel1.TabIndex = 6;
            // 
            // kirjauduUlosNappi
            // 
            kirjauduUlosNappi.Location = new Point(710, 3);
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
            omatsaaliitNappi.Location = new Point(245, 2);
            omatsaaliitNappi.Name = "omatsaaliitNappi";
            omatsaaliitNappi.Size = new Size(112, 45);
            omatsaaliitNappi.TabIndex = 11;
            omatsaaliitNappi.Text = "Omat saaliit";
            omatsaaliitNappi.UseVisualStyleBackColor = true;
            omatsaaliitNappi.Click += omatsaaliitNappi_Click;
            // 
            // etusivuNappi
            // 
            etusivuNappi.BackColor = Color.Aqua;
            etusivuNappi.Location = new Point(127, 2);
            etusivuNappi.Name = "etusivuNappi";
            etusivuNappi.Size = new Size(112, 45);
            etusivuNappi.TabIndex = 10;
            etusivuNappi.Text = "Etusivu";
            etusivuNappi.UseVisualStyleBackColor = false;
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
            suljeNappi.Location = new Point(828, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(65, 143);
            label1.Name = "label1";
            label1.Size = new Size(175, 20);
            label1.TabIndex = 8;
            label1.Text = "Viimeaikainen toimintasi:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(65, 92);
            label3.Name = "label3";
            label3.Size = new Size(81, 20);
            label3.TabIndex = 9;
            label3.Text = "Tervetuloa,";
            // 
            // nimitextBox
            // 
            nimitextBox.BorderStyle = BorderStyle.None;
            nimitextBox.Location = new Point(152, 92);
            nimitextBox.Name = "nimitextBox";
            nimitextBox.ReadOnly = true;
            nimitextBox.Size = new Size(175, 20);
            nimitextBox.TabIndex = 10;
            // 
            // inforichTextBox
            // 
            inforichTextBox.BackColor = Color.White;
            inforichTextBox.Location = new Point(3, 0);
            inforichTextBox.Name = "inforichTextBox";
            inforichTextBox.ReadOnly = true;
            inforichTextBox.Size = new Size(732, 315);
            inforichTextBox.TabIndex = 11;
            inforichTextBox.Text = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(inforichTextBox);
            panel2.Location = new Point(68, 166);
            panel2.Name = "panel2";
            panel2.Size = new Size(739, 333);
            panel2.TabIndex = 56;
            // 
            // kayttaja_etusivu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(875, 539);
            Controls.Add(panel2);
            Controls.Add(nimitextBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kayttaja_etusivu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kayttaja_etusivu";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button suljeNappi;
        private Button kalastuspaikatNappi;
        private Button omatsaaliitNappi;
        private Button etusivuNappi;
        private Button kirjauduUlosNappi;
        private Button kalapankkiNappi;
        private Label label1;
        private Label label3;
        private TextBox nimitextBox;
        private RichTextBox inforichTextBox;
        private Panel panel2;
    }
}