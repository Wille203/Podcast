namespace Podd
{
    partial class LaggTillPodd2
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
            lblPodd = new Label();
            tbPoddNamn = new TextBox();
            lblValKategori = new Label();
            lblNamn = new Label();
            lblLank = new Label();
            cbValKategori = new ComboBox();
            tbNamn = new TextBox();
            btnSparaPodd = new Button();
            tbLank = new TextBox();
            menuStrip1 = new MenuStrip();
            startsidanToolStripMenuItem = new ToolStripMenuItem();
            minaPoddarToolStripMenuItem = new ToolStripMenuItem();
            läggTillPoddToolStripMenuItem = new ToolStripMenuItem();
            hanteraKategoriToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblPodd
            // 
            lblPodd.AutoSize = true;
            lblPodd.Location = new Point(552, 101);
            lblPodd.Name = "lblPodd";
            lblPodd.Size = new Size(74, 25);
            lblPodd.TabIndex = 28;
            lblPodd.Text = "Podcast";
            // 
            // tbPoddNamn
            // 
            tbPoddNamn.Location = new Point(551, 142);
            tbPoddNamn.Name = "tbPoddNamn";
            tbPoddNamn.Size = new Size(291, 31);
            tbPoddNamn.TabIndex = 27;
            // 
            // lblValKategori
            // 
            lblValKategori.AutoSize = true;
            lblValKategori.Location = new Point(120, 310);
            lblValKategori.Name = "lblValKategori";
            lblValKategori.Size = new Size(109, 25);
            lblValKategori.TabIndex = 26;
            lblValKategori.Text = "Välj kategori";
            // 
            // lblNamn
            // 
            lblNamn.AutoSize = true;
            lblNamn.Location = new Point(123, 204);
            lblNamn.Name = "lblNamn";
            lblNamn.Size = new Size(90, 25);
            lblNamn.TabIndex = 25;
            lblNamn.Text = "Ge Namn:";
            // 
            // lblLank
            // 
            lblLank.AutoSize = true;
            lblLank.Location = new Point(120, 101);
            lblLank.Name = "lblLank";
            lblLank.Size = new Size(48, 25);
            lblLank.TabIndex = 24;
            lblLank.Text = "Länk";
            // 
            // cbValKategori
            // 
            cbValKategori.FormattingEnabled = true;
            cbValKategori.Location = new Point(111, 338);
            cbValKategori.Name = "cbValKategori";
            cbValKategori.Size = new Size(251, 33);
            cbValKategori.TabIndex = 23;
            // 
            // tbNamn
            // 
            tbNamn.Location = new Point(111, 240);
            tbNamn.Name = "tbNamn";
            tbNamn.Size = new Size(251, 31);
            tbNamn.TabIndex = 22;
            // 
            // btnSparaPodd
            // 
            btnSparaPodd.Location = new Point(391, 459);
            btnSparaPodd.Name = "btnSparaPodd";
            btnSparaPodd.Size = new Size(235, 34);
            btnSparaPodd.TabIndex = 21;
            btnSparaPodd.Text = "Spara Podd";
            btnSparaPodd.UseVisualStyleBackColor = true;
            btnSparaPodd.Click += btnSparaPodd_Click;
            // 
            // tbLank
            // 
            tbLank.Location = new Point(111, 142);
            tbLank.Name = "tbLank";
            tbLank.Size = new Size(251, 31);
            tbLank.TabIndex = 20;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { startsidanToolStripMenuItem, minaPoddarToolStripMenuItem, läggTillPoddToolStripMenuItem, hanteraKategoriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1030, 35);
            menuStrip1.TabIndex = 19;
            menuStrip1.Text = "menuStrip1";
            // 
            // startsidanToolStripMenuItem
            // 
            startsidanToolStripMenuItem.Name = "startsidanToolStripMenuItem";
            startsidanToolStripMenuItem.Size = new Size(106, 29);
            startsidanToolStripMenuItem.Text = "Startsidan";
            // 
            // minaPoddarToolStripMenuItem
            // 
            minaPoddarToolStripMenuItem.Name = "minaPoddarToolStripMenuItem";
            minaPoddarToolStripMenuItem.Size = new Size(131, 29);
            minaPoddarToolStripMenuItem.Text = "Mina poddar";
            // 
            // läggTillPoddToolStripMenuItem
            // 
            läggTillPoddToolStripMenuItem.Name = "läggTillPoddToolStripMenuItem";
            läggTillPoddToolStripMenuItem.Size = new Size(139, 29);
            läggTillPoddToolStripMenuItem.Text = "Lägg till podd";
            // 
            // hanteraKategoriToolStripMenuItem
            // 
            hanteraKategoriToolStripMenuItem.Name = "hanteraKategoriToolStripMenuItem";
            hanteraKategoriToolStripMenuItem.Size = new Size(160, 29);
            hanteraKategoriToolStripMenuItem.Text = "Hantera kategori";
            // 
            // LaggTillPodd2
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1030, 573);
            Controls.Add(lblPodd);
            Controls.Add(tbPoddNamn);
            Controls.Add(lblValKategori);
            Controls.Add(lblNamn);
            Controls.Add(lblLank);
            Controls.Add(cbValKategori);
            Controls.Add(tbNamn);
            Controls.Add(btnSparaPodd);
            Controls.Add(tbLank);
            Controls.Add(menuStrip1);
            Name = "LaggTillPodd2";
            Text = "LaggTillPodd2";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPodd;
        private TextBox tbPoddNamn;
        private Label lblValKategori;
        private Label lblNamn;
        private Label lblLank;
        private ComboBox cbValKategori;
        private TextBox tbNamn;
        private Button btnSparaPodd;
        private TextBox tbLank;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem startsidanToolStripMenuItem;
        private ToolStripMenuItem minaPoddarToolStripMenuItem;
        private ToolStripMenuItem läggTillPoddToolStripMenuItem;
        private ToolStripMenuItem hanteraKategoriToolStripMenuItem;
    }
}