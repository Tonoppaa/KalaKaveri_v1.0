namespace KalaKaveri_v1
{
    partial class admin_kalapankki_poista_kalanakyma
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(admin_kalapankki_poista_kalanakyma));
            panel1 = new Panel();
            label2 = new Label();
            suljeNappi = new Button();
            label1 = new Label();
            panel2 = new Panel();
            kalatiedotdataGridView = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)kalatiedotdataGridView).BeginInit();
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
            panel1.TabIndex = 23;
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
            label1.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label1.Location = new Point(47, 77);
            label1.Name = "label1";
            label1.Size = new Size(751, 37);
            label1.TabIndex = 24;
            label1.Text = "Valitse alta olevasta taulukosta kala, jonka haluat poistaa";
            // 
            // panel2
            // 
            panel2.BackColor = Color.MidnightBlue;
            panel2.Controls.Add(kalatiedotdataGridView);
            panel2.Location = new Point(47, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(759, 324);
            panel2.TabIndex = 56;
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
            kalatiedotdataGridView.Size = new Size(753, 303);
            kalatiedotdataGridView.TabIndex = 52;
            // 
            // admin_kalapankki_poista_kalanakyma
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 486);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "admin_kalapankki_poista_kalanakyma";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "admin_kalapankki_poista_kalanakyma";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)kalatiedotdataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label2;
        private Button suljeNappi;
        private Label label1;
        private Panel panel2;
        private DataGridView kalatiedotdataGridView;
    }
}