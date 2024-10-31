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
            FyllCbPoddar();
        }

        private void VisaPoddar()
        {
            tbMinaPoddar.Clear();
            var poddar = poddController.GetAllPods();

            foreach (var podd in poddar.Distinct())
            {
                tbMinaPoddar.AppendText(podd.PodTitel + Environment.NewLine);
            }
        }

        private void FyllCbPoddar()
        {
            cbTaBortPodd.Items.Clear();
            cbAndraNamn.Items.Clear();
            List<Pod> poddLista = poddController.GetAllPods();
            foreach (var poddar in poddLista.Distinct())
            {
                cbTaBortPodd.Items.Add(poddar.PodTitel);
                cbAndraNamn.Items.Add(poddar.PodTitel);
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

        private void btnTaBort_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cbTaBortPodd.Text))
            {
                MessageBox.Show("Ingen podd att ta bort är vald!");
                return;
            }

            DialogResult dialogResult = MessageBox.Show("Är du säker?", "Ta bort podcast", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string valdPodd = cbTaBortPodd.SelectedItem.ToString();
                poddController.DeletePod(valdPodd);
                FyllCbPoddar();
                VisaPoddar();
            }
            else if (dialogResult == DialogResult.No)
            {
                MinaPoddar minaPoddar = new MinaPoddar();
            }

        }

        private void btnAndraNamn_Click_1(object sender, EventArgs e)
        {
            string nyttNamn = tbAndraNamn.Text;
            string valdPodTitel = cbAndraNamn.SelectedItem.ToString();

            //Pod nyttPodNamn = poddController.GetPodByTitle(valdPodTitel);
            poddController.UppdateraPoddNamn(valdPodTitel, nyttNamn);
            VisaPoddar();
        }

        private void cbAndraNamn_SelectedIndexChanged(object sender, EventArgs e)
        {
            string valdPodd = cbAndraNamn.SelectedItem.ToString();
            tbAndraNamn.Text = valdPodd.ToString(); 
        }
    }

}
