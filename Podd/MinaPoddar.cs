using BLL.Controller;
using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Podd
{
    public partial class MinaPoddar : Form
    {
        private PoddController poddController;
        KategoriController kategoriController;
        public MinaPoddar()
        {
            InitializeComponent();
            rtbAvsnitt.WordWrap = false;
            rtbAvsnitt.ScrollBars = RichTextBoxScrollBars.Both;
            rtbBeskrivning.ScrollBars = RichTextBoxScrollBars.Both;
            rtbAvsnitt.ReadOnly = true;
            rtbBeskrivning.ReadOnly = true;
            tbMinaPoddar.ReadOnly = true;
            poddController = new PoddController();
            kategoriController = new KategoriController();

            Fyllcb(); // Fyller combo-boxen med kategorier
            VisaPoddar(); // Visar alla poddar initialt

        }

        private void VisaPoddar()
        {
            var poddar = poddController.GetAllPods();
            tbMinaPoddar.Clear();

            foreach (var podd in poddar)
            {
                tbMinaPoddar.AppendText(podd.PodTitel + Environment.NewLine);
            }
        }

        private void Fyllcb()
        {
            cbValKategori.Items.Clear(); // Rensar tidigare innehåll om något finns
            List<string> kategoriLista = kategoriController.LasAllaKategorier();
            foreach (string kategori in kategoriLista)
            {
                cbValKategori.Items.Add(kategori);
            }
        }

        private void cbValKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

            // Hämta den valda kategorins namn från combo-boxen
            string valdKategori = cbValKategori.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(valdKategori))
            {
                // Hämta poddar för den valda kategorin via KategoriController
                var poddarForKategori = kategoriController.HamtaPoddarForKategori(valdKategori);

                // Rensa tidigare visade poddar i tbMinaPoddar
                tbMinaPoddar.Clear();

                // Lägg till varje podds titel i tbMinaPoddar
                foreach (var podd in poddarForKategori)
                {
                    tbMinaPoddar.AppendText(podd.PodTitel + Environment.NewLine);
                }
            }
        }



        private void startsidanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartSida startSida = new StartSida();
            startSida.Show();
        }

        private void minaPoddarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MinaPoddar minaPoddar = new MinaPoddar();
            minaPoddar.Show();
        }

        private void läggTillPoddToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            LaggTillPodd2 laggTillPodd = new LaggTillPodd2();
            laggTillPodd.Show();
        }

        private void hanteraKategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            HanteraKategorier hanteraKategorier = new HanteraKategorier();
            hanteraKategorier.Show();
        }


        private void VisaAvsnittForPodd(Pod poddTitel)
        {
            rtbAvsnitt.Clear();
            Color[] colors = { Color.White, Color.LightGray };
            int colorIndex = 0;

            foreach (var avsnitt in poddTitel.Avsnitt)
            {
                rtbAvsnitt.SelectionBackColor = colors[colorIndex];
                rtbAvsnitt.AppendText(avsnitt.Titel + Environment.NewLine);
                colorIndex = (colorIndex + 1) % colors.Length;
            }

            rtbAvsnitt.SelectionBackColor = rtbAvsnitt.BackColor;
        }

        private void VisaBeskrivningForAvsnitt(string avsnittTitel)
        {
            var poddar = poddController.GetAllPods();
            foreach (var podd in poddar)
            {
                var avsnitt = podd.Avsnitt.FirstOrDefault(a => a.Titel.Equals(avsnittTitel));
                if (avsnitt != null)
                {
                    rtbBeskrivning.Clear();
                    rtbBeskrivning.AppendText(avsnitt.Beskrivning);
                    break;
                }
            }
        }

        private void tbMinaPoddar_MouseClick(object sender, MouseEventArgs e)
        {

            int index = tbMinaPoddar.GetLineFromCharIndex(tbMinaPoddar.SelectionStart);
            if (index >= 0 && index < tbMinaPoddar.Lines.Length)
            {
                string valdPodTitel = tbMinaPoddar.Lines[index].Trim();
                Pod podd = poddController.GetPodByTitle(valdPodTitel);
                tbAndraNamn.Text = valdPodTitel;
                if (podd != null)
                {
                    VisaAvsnittForPodd(podd);
                }
                else
                {
                    MessageBox.Show("Podd not found: " + valdPodTitel);
                }
            }
        }


        private void rtbAvsnitt_MouseClick(object sender, MouseEventArgs e)
        {
            int index = rtbAvsnitt.GetLineFromCharIndex(rtbAvsnitt.SelectionStart);
            if (index >= 0 && index < rtbAvsnitt.Lines.Length)
            {
                string selectedAvsnittTitle = rtbAvsnitt.Lines[index];
                VisaBeskrivningForAvsnitt(selectedAvsnittTitle);
            }
        }

        private void tbMinaPoddar_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAndraNamn_Click(object sender, EventArgs e)
        {
            string nyttNamn = tbAndraNamn.Text;
            string valdPodTitel = tbMinaPoddar.Text;

            Pod nyttPodNamn = poddController.GetPodByTitle(valdPodTitel);
            poddController.UppdateraPoddNamn(nyttPodNamn, nyttNamn);
            VisaPoddar();
        }
    }
}
