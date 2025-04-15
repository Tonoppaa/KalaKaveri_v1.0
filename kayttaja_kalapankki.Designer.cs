namespace KalaKaveri_v1
{
    partial class kayttaja_kalapankki
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayttaja_kalapankki));
            panel1 = new Panel();
            kirjauduUlosNappi = new Button();
            kalapankkiNappi = new Button();
            omatsaaliitNappi = new Button();
            etusivuNappi = new Button();
            kalastuspaikatNappi = new Button();
            label2 = new Label();
            suljeNappi = new Button();
            label1 = new Label();
            panel2 = new Panel();
            kalatiedotdataGridView = new DataGridView();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kalatiedotdataGridView).BeginInit();
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
            panel1.Size = new Size(890, 48);
            panel1.TabIndex = 13;
            // 
            // kirjauduUlosNappi
            // 
            kirjauduUlosNappi.Location = new Point(725, 2);
            kirjauduUlosNappi.Name = "kirjauduUlosNappi";
            kirjauduUlosNappi.Size = new Size(112, 45);
            kirjauduUlosNappi.TabIndex = 13;
            kirjauduUlosNappi.Text = "Kirjaudu ulos";
            kirjauduUlosNappi.UseVisualStyleBackColor = true;
            kirjauduUlosNappi.Click += kirjauduUlosNappi_Click;
            // 
            // kalapankkiNappi
            // 
            kalapankkiNappi.BackColor = Color.Aqua;
            kalapankkiNappi.Location = new Point(481, 2);
            kalapankkiNappi.Name = "kalapankkiNappi";
            kalapankkiNappi.Size = new Size(112, 45);
            kalapankkiNappi.TabIndex = 12;
            kalapankkiNappi.Text = "Kalapankki";
            kalapankkiNappi.UseVisualStyleBackColor = false;
            // 
            // omatsaaliitNappi
            // 
            omatsaaliitNappi.BackColor = Color.Transparent;
            omatsaaliitNappi.Location = new Point(245, 2);
            omatsaaliitNappi.Name = "omatsaaliitNappi";
            omatsaaliitNappi.Size = new Size(112, 45);
            omatsaaliitNappi.TabIndex = 11;
            omatsaaliitNappi.Text = "Omat saaliit";
            omatsaaliitNappi.UseVisualStyleBackColor = false;
            omatsaaliitNappi.Click += omatsaaliitNappi_Click;
            // 
            // etusivuNappi
            // 
            etusivuNappi.Location = new Point(127, 2);
            etusivuNappi.Name = "etusivuNappi";
            etusivuNappi.Size = new Size(112, 45);
            etusivuNappi.TabIndex = 10;
            etusivuNappi.Text = "Etusivu";
            etusivuNappi.UseVisualStyleBackColor = true;
            etusivuNappi.Click += etusivuNappi_Click;
            // 
            // kalastuspaikatNappi
            // 
            kalastuspaikatNappi.BackColor = Color.Transparent;
            kalastuspaikatNappi.Location = new Point(363, 2);
            kalastuspaikatNappi.Name = "kalastuspaikatNappi";
            kalastuspaikatNappi.Size = new Size(112, 45);
            kalastuspaikatNappi.TabIndex = 9;
            kalastuspaikatNappi.Text = "Kalastuspaikat";
            kalastuspaikatNappi.UseVisualStyleBackColor = false;
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
            suljeNappi.Location = new Point(843, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(127, 138);
            label1.Name = "label1";
            label1.Size = new Size(436, 20);
            label1.TabIndex = 14;
            label1.Text = "Tällä sivulla voit tarkastella eri kalalajeja alla olevasta taulukosta.";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(kalatiedotdataGridView);
            panel2.Location = new Point(127, 174);
            panel2.Name = "panel2";
            panel2.Size = new Size(602, 306);
            panel2.TabIndex = 55;
            // 
            // kalatiedotdataGridView
            // 
            kalatiedotdataGridView.AllowUserToAddRows = false;
            kalatiedotdataGridView.AllowUserToDeleteRows = false;
            kalatiedotdataGridView.AllowUserToResizeColumns = false;
            kalatiedotdataGridView.AllowUserToResizeRows = false;
            kalatiedotdataGridView.BackgroundColor = Color.White;
            kalatiedotdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kalatiedotdataGridView.GridColor = Color.LightGray;
            kalatiedotdataGridView.Location = new Point(3, 0);
            kalatiedotdataGridView.MultiSelect = false;
            kalatiedotdataGridView.Name = "kalatiedotdataGridView";
            kalatiedotdataGridView.ReadOnly = true;
            kalatiedotdataGridView.RowHeadersWidth = 51;
            kalatiedotdataGridView.Size = new Size(596, 290);
            kalatiedotdataGridView.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(127, 82);
            label3.Name = "label3";
            label3.Size = new Size(143, 35);
            label3.TabIndex = 56;
            label3.Text = "Kalapankki";
            // 
            // kayttaja_kalapankki
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 517);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kayttaja_kalapankki";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kayttaja_kalapankki";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kalatiedotdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Button kirjauduUlosNappi;
        private Button kalapankkiNappi;
        private Button omatsaaliitNappi;
        private Button etusivuNappi;
        private Button kalastuspaikatNappi;
        private Label label2;
        private Button suljeNappi;
        private Label label1;
        private Panel panel2;
        private DataGridView kalatiedotdataGridView;
        private Label label3;
    }
}