namespace KalaKaveri_v1
{
    partial class kayttaja_kalastuspaikat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayttaja_kalastuspaikat));
            panel1 = new Panel();
            kirjauduUlosNappi = new Button();
            kalapankkiNappi = new Button();
            omatsaaliitNappi = new Button();
            etusivuNappi = new Button();
            kalastuspaikatNappi = new Button();
            label2 = new Label();
            suljeNappi = new Button();
            label1 = new Label();
            kalapaikatcomboBox = new ComboBox();
            haeNappi = new Button();
            panel2 = new Panel();
            kalapaikatdataGridView = new DataGridView();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kalapaikatdataGridView).BeginInit();
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
            panel1.TabIndex = 12;
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
            kalastuspaikatNappi.BackColor = Color.Aqua;
            kalastuspaikatNappi.Location = new Point(363, 2);
            kalastuspaikatNappi.Name = "kalastuspaikatNappi";
            kalastuspaikatNappi.Size = new Size(112, 45);
            kalastuspaikatNappi.TabIndex = 9;
            kalastuspaikatNappi.Text = "Kalastuspaikat";
            kalastuspaikatNappi.UseVisualStyleBackColor = false;
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
            label1.Location = new Point(127, 130);
            label1.Name = "label1";
            label1.Size = new Size(186, 20);
            label1.TabIndex = 13;
            label1.Text = "Tarkastele kalastuspaikkoja";
            // 
            // kalapaikatcomboBox
            // 
            kalapaikatcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            kalapaikatcomboBox.FormattingEnabled = true;
            kalapaikatcomboBox.Location = new Point(328, 127);
            kalapaikatcomboBox.Name = "kalapaikatcomboBox";
            kalapaikatcomboBox.Size = new Size(309, 28);
            kalapaikatcomboBox.TabIndex = 14;
            // 
            // haeNappi
            // 
            haeNappi.Location = new Point(646, 127);
            haeNappi.Name = "haeNappi";
            haeNappi.Size = new Size(83, 29);
            haeNappi.TabIndex = 16;
            haeNappi.Text = "Hae";
            haeNappi.UseVisualStyleBackColor = true;
            haeNappi.Click += haeNappi_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(kalapaikatdataGridView);
            panel2.Location = new Point(127, 176);
            panel2.Name = "panel2";
            panel2.Size = new Size(602, 306);
            panel2.TabIndex = 54;
            // 
            // kalapaikatdataGridView
            // 
            kalapaikatdataGridView.AllowUserToAddRows = false;
            kalapaikatdataGridView.AllowUserToDeleteRows = false;
            kalapaikatdataGridView.AllowUserToResizeColumns = false;
            kalapaikatdataGridView.AllowUserToResizeRows = false;
            kalapaikatdataGridView.BackgroundColor = Color.White;
            kalapaikatdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            kalapaikatdataGridView.GridColor = Color.LightGray;
            kalapaikatdataGridView.Location = new Point(3, 0);
            kalapaikatdataGridView.MultiSelect = false;
            kalapaikatdataGridView.Name = "kalapaikatdataGridView";
            kalapaikatdataGridView.ReadOnly = true;
            kalapaikatdataGridView.RowHeadersWidth = 51;
            kalapaikatdataGridView.Size = new Size(596, 290);
            kalapaikatdataGridView.TabIndex = 52;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(127, 74);
            label3.Name = "label3";
            label3.Size = new Size(184, 35);
            label3.TabIndex = 55;
            label3.Text = "Kalastuspaikat";
            // 
            // kayttaja_kalastuspaikat
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 512);
            Controls.Add(label3);
            Controls.Add(panel2);
            Controls.Add(haeNappi);
            Controls.Add(kalapaikatcomboBox);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kayttaja_kalastuspaikat";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kayttaja_kalastuspaikat";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kalapaikatdataGridView).EndInit();
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
        private ComboBox kalapaikatcomboBox;
        private Button haeNappi;
        private Panel panel2;
        private DataGridView kalapaikatdataGridView;
        private Label label3;
    }
}