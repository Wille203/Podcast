
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
            components = new System.ComponentModel.Container();
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
            btnAndraNamn = new Button();
            lblAndraNamn = new Label();
            tbAndraNamn = new TextBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            cbAndraNamn = new ComboBox();
            cbAndraPoddKategori = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lblMinaPoddar
            // 
            lblMinaPoddar.AutoSize = true;
            lblMinaPoddar.Location = new Point(451, 40);
            lblMinaPoddar.Name = "lblMinaPoddar";
            lblMinaPoddar.Size = new Size(113, 25);
            lblMinaPoddar.TabIndex = 0;
            lblMinaPoddar.Text = "Mina Poddar";
            // 
            // lblSparadePoddar
            // 
            lblSparadePoddar.AutoSize = true;
            lblSparadePoddar.Location = new Point(164, 63);
            lblSparadePoddar.Name = "lblSparadePoddar";
            lblSparadePoddar.Size = new Size(141, 25);
            lblSparadePoddar.TabIndex = 2;
            lblSparadePoddar.Text = "Sparade poddar";
            // 
            // lblAvsnitt
            // 
            lblAvsnitt.AutoSize = true;
            lblAvsnitt.Location = new Point(569, 67);
            lblAvsnitt.Name = "lblAvsnitt";
            lblAvsnitt.Size = new Size(67, 25);
            lblAvsnitt.TabIndex = 4;
            lblAvsnitt.Text = "Avsnitt";
            // 
            // lblBeskrivning
            // 
            lblBeskrivning.AutoSize = true;
            lblBeskrivning.Location = new Point(754, 67);
            lblBeskrivning.Name = "lblBeskrivning";
            lblBeskrivning.Size = new Size(102, 25);
            lblBeskrivning.TabIndex = 6;
            lblBeskrivning.Text = "Beskrivning";
            // 
            // cbValKategori
            // 
            cbValKategori.FormattingEnabled = true;
            cbValKategori.Location = new Point(221, 92);
            cbValKategori.Name = "cbValKategori";
            cbValKategori.Size = new Size(183, 33);
            cbValKategori.TabIndex = 7;
            cbValKategori.SelectedIndexChanged += cbValKategori_SelectedIndexChanged;
            // 
            // lblValKategori
            // 
            lblValKategori.AutoSize = true;
            lblValKategori.Location = new Point(101, 93);
            lblValKategori.Name = "lblValKategori";
            lblValKategori.Size = new Size(113, 25);
            lblValKategori.TabIndex = 8;
            lblValKategori.Text = "Välj kategori:";
            // 
            // lblAndraKategori
            // 
            lblAndraKategori.AutoSize = true;
            lblAndraKategori.Location = new Point(90, 377);
            lblAndraKategori.Name = "lblAndraKategori";
            lblAndraKategori.Size = new Size(135, 25);
            lblAndraKategori.TabIndex = 9;
            lblAndraKategori.Text = "Ändra Kategori:";
            // 
            // cbAndraKategori
            // 
            cbAndraKategori.FormattingEnabled = true;
            cbAndraKategori.Location = new Point(231, 374);
            cbAndraKategori.Name = "cbAndraKategori";
            cbAndraKategori.Size = new Size(183, 33);
            cbAndraKategori.TabIndex = 10;
            // 
            // btnSparaKategori
            // 
            btnSparaKategori.Location = new Point(133, 414);
            btnSparaKategori.Name = "btnSparaKategori";
            btnSparaKategori.Size = new Size(211, 33);
            btnSparaKategori.TabIndex = 11;
            btnSparaKategori.Text = "Spara Ändring";
            btnSparaKategori.UseVisualStyleBackColor = true;
            btnSparaKategori.Click += btnSparaKategori_Click;
            // 
            // lblTaBortPodd
            // 
            lblTaBortPodd.AutoSize = true;
            lblTaBortPodd.Location = new Point(74, 672);
            lblTaBortPodd.Name = "lblTaBortPodd";
            lblTaBortPodd.Size = new Size(140, 25);
            lblTaBortPodd.TabIndex = 12;
            lblTaBortPodd.Text = "Ta bort podcast:";
            // 
            // cbTaBortPodd
            // 
            cbTaBortPodd.FormattingEnabled = true;
            cbTaBortPodd.Location = new Point(221, 668);
            cbTaBortPodd.Name = "cbTaBortPodd";
            cbTaBortPodd.Size = new Size(183, 33);
            cbTaBortPodd.TabIndex = 13;
            // 
            // btnTaBort
            // 
            btnTaBort.Location = new Point(137, 708);
            btnTaBort.Name = "btnTaBort";
            btnTaBort.Size = new Size(221, 33);
            btnTaBort.TabIndex = 14;
            btnTaBort.Text = "Ta bort";
            btnTaBort.UseVisualStyleBackColor = true;
            btnTaBort.Click += btnTaBort_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { startsidanToolStripMenuItem, minaPoddarToolStripMenuItem, läggTillPoddToolStripMenuItem, hanteraKategoriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1260, 35);
            menuStrip1.TabIndex = 15;
            menuStrip1.Text = "menuStrip1";
            // 
            // startsidanToolStripMenuItem
            // 
            startsidanToolStripMenuItem.Name = "startsidanToolStripMenuItem";
            startsidanToolStripMenuItem.Size = new Size(106, 29);
            startsidanToolStripMenuItem.Text = "Startsidan";
            startsidanToolStripMenuItem.Click += startsidanToolStripMenuItem_Click;
            // 
            // minaPoddarToolStripMenuItem
            // 
            minaPoddarToolStripMenuItem.Name = "minaPoddarToolStripMenuItem";
            minaPoddarToolStripMenuItem.Size = new Size(131, 29);
            minaPoddarToolStripMenuItem.Text = "Mina poddar";
            minaPoddarToolStripMenuItem.Click += minaPoddarToolStripMenuItem_Click;
            // 
            // läggTillPoddToolStripMenuItem
            // 
            läggTillPoddToolStripMenuItem.Name = "läggTillPoddToolStripMenuItem";
            läggTillPoddToolStripMenuItem.Size = new Size(139, 29);
            läggTillPoddToolStripMenuItem.Text = "Lägg till podd";
            läggTillPoddToolStripMenuItem.Click += läggTillPoddToolStripMenuItem_Click;
            // 
            // hanteraKategoriToolStripMenuItem
            // 
            hanteraKategoriToolStripMenuItem.Name = "hanteraKategoriToolStripMenuItem";
            hanteraKategoriToolStripMenuItem.Size = new Size(160, 29);
            hanteraKategoriToolStripMenuItem.Text = "Hantera kategori";
            hanteraKategoriToolStripMenuItem.Click += hanteraKategoriToolStripMenuItem_Click;
            // 
            // tbMinaPoddar
            // 
            tbMinaPoddar.Location = new Point(101, 138);
            tbMinaPoddar.Margin = new Padding(4, 5, 4, 5);
            tbMinaPoddar.Multiline = true;
            tbMinaPoddar.Name = "tbMinaPoddar";
            tbMinaPoddar.Size = new Size(303, 171);
            tbMinaPoddar.TabIndex = 16;
            tbMinaPoddar.MouseClick += tbMinaPoddar_MouseClick;
            // 
            // rtbBeskrivning
            // 
            rtbBeskrivning.Location = new Point(754, 97);
            rtbBeskrivning.Margin = new Padding(4, 5, 4, 5);
            rtbBeskrivning.Name = "rtbBeskrivning";
            rtbBeskrivning.Size = new Size(228, 212);
            rtbBeskrivning.TabIndex = 18;
            rtbBeskrivning.Text = "";
            // 
            // rtbAvsnitt
            // 
            rtbAvsnitt.Location = new Point(477, 97);
            rtbAvsnitt.Margin = new Padding(4, 5, 4, 5);
            rtbAvsnitt.Name = "rtbAvsnitt";
            rtbAvsnitt.Size = new Size(267, 524);
            rtbAvsnitt.TabIndex = 19;
            rtbAvsnitt.Text = "";
            rtbAvsnitt.MouseClick += rtbAvsnitt_MouseClick;
            // 
            // btnAndraNamn
            // 
            btnAndraNamn.Location = new Point(123, 584);
            btnAndraNamn.Name = "btnAndraNamn";
            btnAndraNamn.Size = new Size(221, 33);
            btnAndraNamn.TabIndex = 22;
            btnAndraNamn.Text = "Ändra Namn";
            btnAndraNamn.UseVisualStyleBackColor = true;
            btnAndraNamn.Click += btnAndraNamn_Click_1;
            // 
            // lblAndraNamn
            // 
            lblAndraNamn.AutoSize = true;
            lblAndraNamn.Location = new Point(91, 542);
            lblAndraNamn.Name = "lblAndraNamn";
            lblAndraNamn.Size = new Size(119, 25);
            lblAndraNamn.TabIndex = 20;
            lblAndraNamn.Text = "Ändra namn :";
            lblAndraNamn.TextAlign = ContentAlignment.MiddleRight;
            // 
            // tbAndraNamn
            // 
            tbAndraNamn.Location = new Point(221, 537);
            tbAndraNamn.Margin = new Padding(4, 5, 4, 5);
            tbAndraNamn.Name = "tbAndraNamn";
            tbAndraNamn.Size = new Size(183, 31);
            tbAndraNamn.TabIndex = 23;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(24, 24);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // cbAndraNamn
            // 
            cbAndraNamn.FormattingEnabled = true;
            cbAndraNamn.Location = new Point(123, 496);
            cbAndraNamn.Name = "cbAndraNamn";
            cbAndraNamn.Size = new Size(221, 33);
            cbAndraNamn.TabIndex = 24;
            cbAndraNamn.SelectedIndexChanged += cbAndraNamn_SelectedIndexChanged;
            // 
            // cbAndraPoddKategori
            // 
            cbAndraPoddKategori.FormattingEnabled = true;
            cbAndraPoddKategori.Location = new Point(150, 335);
            cbAndraPoddKategori.Name = "cbAndraPoddKategori";
            cbAndraPoddKategori.Size = new Size(182, 33);
            cbAndraPoddKategori.TabIndex = 25;
            // 
            // MinaPoddar
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1260, 945);
            Controls.Add(cbAndraPoddKategori);
            Controls.Add(cbAndraNamn);
            Controls.Add(tbAndraNamn);
            Controls.Add(btnAndraNamn);
            Controls.Add(lblAndraNamn);
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
            Name = "MinaPoddar";
            Text = "Form3";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnAndraNamn_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
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
        private Button btnAndraNamn;
        private Label lblAndraNamn;
        private TextBox tbAndraNamn;
        private ContextMenuStrip contextMenuStrip1;
        private ComboBox cbAndraNamn;
        private ComboBox cbAndraPoddKategori;
    }
}