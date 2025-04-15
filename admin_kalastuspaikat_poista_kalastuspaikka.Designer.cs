namespace KalaKaveri_v1
{
    partial class admin_kalastuspaikat_poista_kalastuspaikka
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_kalastuspaikat_poista_kalastuspaikka));
            panel1 = new Panel();
            label2 = new Label();
            suljeNappi = new Button();
            label1 = new Label();
            panel2 = new Panel();
            kalapaikatdataGridView = new DataGridView();
            haeNappi = new Button();
            kalapaikatcomboBox = new ComboBox();
            label3 = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kalapaikatdataGridView).BeginInit();
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
            panel1.Size = new Size(852, 48);
            panel1.TabIndex = 57;
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
            suljeNappi.Location = new Point(805, 0);
            suljeNappi.Name = "suljeNappi";
            suljeNappi.Size = new Size(47, 48);
            suljeNappi.TabIndex = 1;
            suljeNappi.UseVisualStyleBackColor = true;
            suljeNappi.Click += suljeNappi_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(25, 61);
            label1.Name = "label1";
            label1.Size = new Size(804, 35);
            label1.TabIndex = 58;
            label1.Text = "Valitse alta olevasta taulukosta kalastuspaikka, jonka haluat poistaa";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(kalapaikatdataGridView);
            panel2.Location = new Point(122, 158);
            panel2.Name = "panel2";
            panel2.Size = new Size(602, 306);
            panel2.TabIndex = 62;
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
            // haeNappi
            // 
            haeNappi.Location = new Point(641, 109);
            haeNappi.Name = "haeNappi";
            haeNappi.Size = new Size(83, 29);
            haeNappi.TabIndex = 61;
            haeNappi.Text = "Hae";
            haeNappi.UseVisualStyleBackColor = true;
            haeNappi.Click += haeNappi_Click;
            // 
            // kalapaikatcomboBox
            // 
            kalapaikatcomboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            kalapaikatcomboBox.FormattingEnabled = true;
            kalapaikatcomboBox.Location = new Point(323, 109);
            kalapaikatcomboBox.Name = "kalapaikatcomboBox";
            kalapaikatcomboBox.Size = new Size(309, 28);
            kalapaikatcomboBox.TabIndex = 60;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(122, 112);
            label3.Name = "label3";
            label3.Size = new Size(186, 20);
            label3.TabIndex = 59;
            label3.Text = "Tarkastele kalastuspaikkoja";
            // 
            // admin_kalastuspaikat_poista_kalastuspaikka
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 486);
            Controls.Add(panel2);
            Controls.Add(haeNappi);
            Controls.Add(kalapaikatcomboBox);
            Controls.Add(label3);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_kalastuspaikat_poista_kalastuspaikka";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_kalastuspaikat_poista_kalastuspaikka";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kalapaikatdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button suljeNappi;
        private Label label1;
        private Panel panel2;
        private DataGridView kalapaikatdataGridView;
        private Button haeNappi;
        private ComboBox kalapaikatcomboBox;
        private Label label3;
    }
}