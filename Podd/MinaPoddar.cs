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
            VisaPoddar();

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


        private void VisaAvsnittForPodd(string poddTitel)
        {
            var podd = poddController.GetAllPods().FirstOrDefault(p => p.PodTitel.Equals(poddTitel));
            if (podd != null)
            {
                rtbAvsnitt.Clear();
                Color[] colors = { Color.White, Color.LightGray };
                int colorIndex = 0; 
                foreach (var avsnitt in podd.Avsnitt)
                {
                    string avsnittsTitel = avsnitt.Titel.Trim();

                    rtbAvsnitt.SelectionBackColor = colors[colorIndex];
                    rtbAvsnitt.AppendText(avsnittsTitel + Environment.NewLine);

                    colorIndex = (colorIndex + 1) % colors.Length;
                }

                rtbAvsnitt.SelectionBackColor = rtbAvsnitt.BackColor; 
            }
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
            if (index >= 0)
            {
                string valdPodTitel = tbMinaPoddar.Lines[index];
                VisaAvsnittForPodd(valdPodTitel);
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

}
}
