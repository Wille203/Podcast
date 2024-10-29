namespace Podd
{
    partial class MinaPoddar
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
            lblMinaPoddar = new Label();
            lblSparadePoddar = new Label();
            lblAvsnitt = new Label();
            lblBeskrivning = new Label();
            cbValKategori = new ComboBox();
            lblValKategori = new Label();
            lblAndraKategori = new Label();
            cbAndraKategori = new ComboBox();
            btnSparaKategori = new Button();
            lblTaBortPodd = new Label();
            cbTaBortPodd = new ComboBox();
            btnTaBort = new Button();
            menuStrip1 = new MenuStrip();
            startsidanToolStripMenuItem = new ToolStripMenuItem();
            minaPoddarToolStripMenuItem = new ToolStripMenuItem();
            läggTillPoddToolStripMenuItem = new ToolStripMenuItem();
            hanteraKategoriToolStripMenuItem = new ToolStripMenuItem();
            tbMinaPoddar = new TextBox();
            rtbBeskrivning = new RichTextBox();
            rtbAvsnitt = new RichTextBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMinaPoddar
            // 
            lblMinaPoddar.AutoSize = true;
            lblMinaPoddar.Location = new Point(316, 24);
            lblMinaPoddar.Margin = new Padding(2, 0, 2, 0);
            lblMinaPoddar.Name = "lblMinaPoddar";
            lblMinaPoddar.Size = new Size(75, 15);
            lblMinaPoddar.TabIndex = 0;
            lblMinaPoddar.Text = "Mina Poddar";
            // 
            // lblSparadePoddar
            // 
            lblSparadePoddar.AutoSize = true;
            lblSparadePoddar.Location = new Point(115, 38);
            lblSparadePoddar.Margin = new Padding(2, 0, 2, 0);
            lblSparadePoddar.Name = "lblSparadePoddar";
            lblSparadePoddar.Size = new Size(90, 15);
            lblSparadePoddar.TabIndex = 2;
            lblSparadePoddar.Text = "Sparade poddar";
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Location = new Point(398, 40);
            lblAvsnitt.Margin = new Padding(2, 0, 2, 0);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(44, 15);
            lblAvsnitt.TabIndex = 4;
            lblAvsnitt.Text = "Avsnitt";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Location = new Point(528, 40);
            lblBeskrivning.Margin = new Padding(2, 0, 2, 0);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(68, 15);
            lblBeskrivning.TabIndex = 6;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // cbValKategori
            // 
            cbValKategori.FormattingEnabled = true;
            cbValKategori.Location = new Point(155, 55);
            cbValKategori.Margin = new Padding(2);
            cbValKategori.Name = "cbValKategori";
            cbValKategori.Size = new Size(129, 23);
            cbValKategori.TabIndex = 7;
            // 
            // lblValKategori
            // 
            lblValKategori.AutoSize = true;
            lblValKategori.Location = new Point(71, 56);
            lblValKategori.Margin = new Padding(2, 0, 2, 0);
            lblValKategori.Name = "lblValKategori";
            lblValKategori.Size = new Size(74, 15);
            lblValKategori.TabIndex = 8;
            lblValKategori.Text = "Välj kategori:";
            // 
            // lblAndraKategori
            // 
            lblAndraKategori.AutoSize = true;
            lblAndraKategori.Location = new Point(56, 207);
            lblAndraKategori.Margin = new Padding(2, 0, 2, 0);
            lblAndraKategori.Name = "lblAndraKategori";
            lblAndraKategori.Size = new Size(89, 15);
            lblAndraKategori.TabIndex = 9;
            lblAndraKategori.Text = "Ändra Kategori:";
            // 
            // cbAndraKategori
            // 
            cbAndraKategori.FormattingEnabled = true;
            cbAndraKategori.Location = new Point(155, 205);
            cbAndraKategori.Margin = new Padding(2);
            cbAndraKategori.Name = "cbAndraKategori";
            cbAndraKategori.Size = new Size(129, 23);
            cbAndraKategori.TabIndex = 10;
            // 
            // btnSparaKategori
            // 
            btnSparaKategori.Location = new Point(86, 229);
            btnSparaKategori.Margin = new Padding(2);
            btnSparaKategori.Name = "btnSparaKategori";
            btnSparaKategori.Size = new Size(148, 20);
            btnSparaKategori.TabIndex = 11;
            btnSparaKategori.Text = "Spara Ändring";
            btnSparaKategori.UseVisualStyleBackColor = true;
            // 
            // lblTaBortPodd
            // 
            lblTaBortPodd.AutoSize = true;
            lblTaBortPodd.Location = new Point(52, 283);
            lblTaBortPodd.Margin = new Padding(2, 0, 2, 0);
            lblTaBortPodd.Name = "lblTaBortPodd";
            lblTaBortPodd.Size = new Size(91, 15);
            lblTaBortPodd.TabIndex = 12;
            lblTaBortPodd.Text = "Ta bort podcast:";
            // 
            // cbTaBortPodd
            // 
            cbTaBortPodd.FormattingEnabled = true;
            cbTaBortPodd.Location = new Point(155, 281);
            cbTaBortPodd.Margin = new Padding(2);
            cbTaBortPodd.Name = "cbTaBortPodd";
            cbTaBortPodd.Size = new Size(129, 23);
            cbTaBortPodd.TabIndex = 13;
            // 
            // btnTaBort
            // 
            btnTaBort.Location = new Point(96, 305);
            btnTaBort.Margin = new Padding(2);
            btnTaBort.Name = "btnTaBort";
            btnTaBort.Size = new Size(155, 20);
            btnTaBort.TabIndex = 14;
            btnTaBort.Text = "Ta bort";
            btnTaBort.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { startsidanToolStripMenuItem, minaPoddarToolStripMenuItem, läggTillPoddToolStripMenuItem, hanteraKategoriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(701, 24);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // startsidanToolStripMenuItem
            // 
            startsidanToolStripMenuItem.Name = "startsidanToolStripMenuItem";
            startsidanToolStripMenuItem.Size = new Size(71, 20);
            startsidanToolStripMenuItem.Text = "Startsidan";
            startsidanToolStripMenuItem.Click += startsidanToolStripMenuItem_Click;
            // 
            // minaPoddarToolStripMenuItem
            // 
            minaPoddarToolStripMenuItem.Name = "minaPoddarToolStripMenuItem";
            minaPoddarToolStripMenuItem.Size = new Size(87, 20);
            minaPoddarToolStripMenuItem.Text = "Mina poddar";
            minaPoddarToolStripMenuItem.Click += minaPoddarToolStripMenuItem_Click;
            // 
            // läggTillPoddToolStripMenuItem
            // 
            läggTillPoddToolStripMenuItem.Name = "läggTillPoddToolStripMenuItem";
            läggTillPoddToolStripMenuItem.Size = new Size(92, 20);
            läggTillPoddToolStripMenuItem.Text = "Lägg till podd";
            läggTillPoddToolStripMenuItem.Click += läggTillPoddToolStripMenuItem_Click;
            // 
            // hanteraKategoriToolStripMenuItem
            // 
            hanteraKategoriToolStripMenuItem.Name = "hanteraKategoriToolStripMenuItem";
            hanteraKategoriToolStripMenuItem.Size = new Size(107, 20);
            hanteraKategoriToolStripMenuItem.Text = "Hantera kategori";
            hanteraKategoriToolStripMenuItem.Click += hanteraKategoriToolStripMenuItem_Click;
            // 
            // tbMinaPoddar
            // 
            tbMinaPoddar.Location = new Point(71, 83);
            tbMinaPoddar.Multiline = true;
            tbMinaPoddar.Name = "tbMinaPoddar";
            tbMinaPoddar.Size = new Size(213, 104);
            tbMinaPoddar.TabIndex = 16;
            tbMinaPoddar.MouseClick += tbMinaPoddar_MouseClick;
            // 
            // rtbBeskrivning
            // 
            rtbBeskrivning.Location = new Point(528, 58);
            rtbBeskrivning.Name = "rtbBeskrivning";
            rtbBeskrivning.Size = new Size(161, 129);
            rtbBeskrivning.TabIndex = 18;
            rtbBeskrivning.Text = "";
            // 
            // rtbAvsnitt
            // 
            rtbAvsnitt.Location = new Point(334, 58);
            rtbAvsnitt.Name = "rtbAvsnitt";
            rtbAvsnitt.Size = new Size(188, 316);
            rtbAvsnitt.TabIndex = 19;
            rtbAvsnitt.Text = "";
            rtbAvsnitt.MouseClick += rtbAvsnitt_MouseClick;
            // 
            // MinaPoddar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(701, 386);
            Controls.Add(rtbAvsnitt);
            Controls.Add(rtbBeskrivning);
            Controls.Add(tbMinaPoddar);
            Controls.Add(menuStrip1);
            Controls.Add(btnTaBort);
            Controls.Add(cbTaBortPodd);
            Controls.Add(lblTaBortPodd);
            Controls.Add(btnSparaKategori);
            Controls.Add(cbAndraKategori);
            Controls.Add(lblAndraKategori);
            Controls.Add(lblValKategori);
            Controls.Add(cbValKategori);
            Controls.Add(lblBeskrivning);
            Controls.Add(lblAvsnitt);
            Controls.Add(lblSparadePoddar);
            Controls.Add(lblMinaPoddar);
            Margin = new Padding(2);
            Name = "MinaPoddar";
            Text = "Form3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMinaPoddar;
        private Label lblSparadePoddar;
        private Label lblAvsnitt;
        private Label lblBeskrivning;
        private ComboBox cbValKategori;
        private Label lblValKategori;
        private Label lblAndraKategori;
        private ComboBox cbAndraKategori;
        private Button btnSparaKategori;
        private Label lblTaBortPodd;
        private ComboBox cbTaBortPodd;
        private Button btnTaBort;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem startsidanToolStripMenuItem;
        private ToolStripMenuItem minaPoddarToolStripMenuItem;
        private ToolStripMenuItem läggTillPoddToolStripMenuItem;
        private ToolStripMenuItem hanteraKategoriToolStripMenuItem;
        private TextBox tbMinaPoddar;
        private RichTextBox rtbBeskrivning;
        private RichTextBox rtbAvsnitt;
    }
}