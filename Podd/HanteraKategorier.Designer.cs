namespace Podd
{
    partial class HanteraKategorier
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
            cbKategori = new ComboBox();
            label1 = new Label();
            btnTaBort = new Button();
            tbLaggTillKategori = new TextBox();
            label2 = new Label();
            tbBytNamn = new TextBox();
            label3 = new Label();
            menuStrip1 = new MenuStrip();
            startsidanToolStripMenuItem = new ToolStripMenuItem();
            minaPoddarToolStripMenuItem = new ToolStripMenuItem();
            läggTillPoddToolStripMenuItem = new ToolStripMenuItem();
            hanteraKategoriToolStripMenuItem = new ToolStripMenuItem();
            btnSparaKategori = new Button();
            btnSparaNamn = new Button();
            cbBytNamnKategori = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cbKategori
            // 
            cbKategori.FormattingEnabled = true;
            cbKategori.Location = new Point(34, 150);
            cbKategori.Margin = new Padding(4, 5, 4, 5);
            cbKategori.Name = "cbKategori";
            cbKategori.Size = new Size(171, 33);
            cbKategori.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(87, 120);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(78, 25);
            label1.TabIndex = 1;
            label1.Text = "Kategori";
            // 
            // btnTaBort
            // 
            btnTaBort.Location = new Point(34, 198);
            btnTaBort.Margin = new Padding(4, 5, 4, 5);
            btnTaBort.Name = "btnTaBort";
            btnTaBort.Size = new Size(107, 38);
            btnTaBort.TabIndex = 2;
            btnTaBort.Text = "Ta bort";
            btnTaBort.UseVisualStyleBackColor = true;
            // 
            // tbLaggTillKategori
            // 
            tbLaggTillKategori.Location = new Point(34, 518);
            tbLaggTillKategori.Margin = new Padding(4, 5, 4, 5);
            tbLaggTillKategori.Name = "tbLaggTillKategori";
            tbLaggTillKategori.Size = new Size(185, 31);
            tbLaggTillKategori.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 488);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(144, 25);
            label2.TabIndex = 4;
            label2.Text = "Lägg till kategori";
            // 
            // tbBytNamn
            // 
            tbBytNamn.Location = new Point(747, 152);
            tbBytNamn.Margin = new Padding(4, 5, 4, 5);
            tbBytNamn.Name = "tbBytNamn";
            tbBytNamn.Size = new Size(185, 31);
            tbBytNamn.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(695, 120);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(87, 25);
            label3.TabIndex = 7;
            label3.Text = "Byt namn";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { startsidanToolStripMenuItem, minaPoddarToolStripMenuItem, läggTillPoddToolStripMenuItem, hanteraKategoriToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(9, 3, 0, 3);
            menuStrip1.Size = new Size(1143, 35);
            menuStrip1.TabIndex = 8;
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
            // btnSparaKategori
            // 
            btnSparaKategori.Location = new Point(34, 567);
            btnSparaKategori.Margin = new Padding(4, 5, 4, 5);
            btnSparaKategori.Name = "btnSparaKategori";
            btnSparaKategori.Size = new Size(107, 38);
            btnSparaKategori.TabIndex = 5;
            btnSparaKategori.Text = "Spara ";
            btnSparaKategori.UseVisualStyleBackColor = true;
            // 
            // btnSparaNamn
            // 
            btnSparaNamn.Location = new Point(695, 193);
            btnSparaNamn.Margin = new Padding(4, 5, 4, 5);
            btnSparaNamn.Name = "btnSparaNamn";
            btnSparaNamn.Size = new Size(107, 38);
            btnSparaNamn.TabIndex = 9;
            btnSparaNamn.Text = "Spara ";
            btnSparaNamn.UseVisualStyleBackColor = true;
            btnSparaNamn.Click += btnSparaNamn_Click;
            // 
            // cbBytNamnKategori
            // 
            cbBytNamnKategori.FormattingEnabled = true;
            cbBytNamnKategori.Location = new Point(528, 152);
            cbBytNamnKategori.Name = "cbBytNamnKategori";
            cbBytNamnKategori.Size = new Size(182, 33);
            cbBytNamnKategori.TabIndex = 10;
            // 
            // HanteraKategorier
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1143, 750);
            Controls.Add(cbBytNamnKategori);
            Controls.Add(btnSparaNamn);
            Controls.Add(label3);
            Controls.Add(tbBytNamn);
            Controls.Add(btnSparaKategori);
            Controls.Add(label2);
            Controls.Add(tbLaggTillKategori);
            Controls.Add(btnTaBort);
            Controls.Add(label1);
            Controls.Add(cbKategori);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 5, 4, 5);
            Name = "HanteraKategorier";
            Text = "Form4";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbKategori;
        private Label label1;
        private Button btnTaBort;
        private TextBox tbLaggTillKategori;
        private Label label2;
        private TextBox tbBytNamn;
        private Label label3;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem startsidanToolStripMenuItem;
        private ToolStripMenuItem minaPoddarToolStripMenuItem;
        private ToolStripMenuItem läggTillPoddToolStripMenuItem;
        private ToolStripMenuItem hanteraKategoriToolStripMenuItem;
        private Button btnSparaKategori;
        private Button btnSparaNamn;
        private ComboBox cbBytNamnKategori;
    }
}