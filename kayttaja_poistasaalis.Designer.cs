namespace KalaKaveri_v1
{
    partial class kayttaja_poistasaalis
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(kayttaja_poistasaalis));
            label9 = new Label();
            label1 = new Label();
            label2 = new Label();
            suljeNappi = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            omatsaaliitdataGridView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)omatsaaliitdataGridView).BeginInit();
            SuspendLayout();
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(47, 129);
            label9.Name = "label9";
            label9.Size = new Size(494, 20);
            label9.TabIndex = 55;
            label9.Text = "Alta voit tarkastella kirjaamiasi saaliita. Valitse saalis, jonka haluat poistaa";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(35, 71);
            label1.Name = "label1";
            label1.Size = new Size(212, 46);
            label1.TabIndex = 54;
            label1.Text = "Poista saalis";
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
            // panel1
            // 
            panel1.BackColor = Color.MidnightBlue;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(suljeNappi);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(890, 48);
            panel1.TabIndex = 53;
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(omatsaaliitdataGridView);
            panel2.Location = new Point(47, 177);
            panel2.Name = "panel2";
            panel2.Size = new Size(791, 336);
            panel2.TabIndex = 56;
            // 
            // omatsaaliitdataGridView
            // 
            omatsaaliitdataGridView.AllowUserToAddRows = false;
            omatsaaliitdataGridView.AllowUserToDeleteRows = false;
            omatsaaliitdataGridView.AllowUserToResizeColumns = false;
            omatsaaliitdataGridView.AllowUserToResizeRows = false;
            omatsaaliitdataGridView.BackgroundColor = Color.White;
            omatsaaliitdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            omatsaaliitdataGridView.GridColor = Color.LightGray;
            omatsaaliitdataGridView.Location = new Point(3, 0);
            omatsaaliitdataGridView.MultiSelect = false;
            omatsaaliitdataGridView.Name = "omatsaaliitdataGridView";
            omatsaaliitdataGridView.ReadOnly = true;
            omatsaaliitdataGridView.RowHeadersWidth = 51;
            omatsaaliitdataGridView.Size = new Size(785, 320);
            omatsaaliitdataGridView.TabIndex = 52;
            // 
            // kayttaja_poistasaalis
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(890, 561);
            Controls.Add(panel2);
            Controls.Add(label9);
            Controls.Add(label1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "kayttaja_poistasaalis";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "kayttaja_poistasaalis";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)omatsaaliitdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label9;
        private Label label1;
        private Label label2;
        private Button suljeNappi;
        private Panel panel1;
        private Panel panel2;
        private DataGridView omatsaaliitdataGridView;
    }
}