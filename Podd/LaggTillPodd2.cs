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
    public partial class LaggTillPodd2 : Form
    {
<<<<<<< Updated upstream
=======
        PoddController poddController;
        KategoriController kategoriController;
>>>>>>> Stashed changes
        public LaggTillPodd2()
        {
            InitializeComponent();
<<<<<<< Updated upstream
=======
            tbPoddNamn.ReadOnly = true;
            kategoriController = new KategoriController();
            kategoriController.SkapaFardigKategori();
            Fyllcb();
>>>>>>> Stashed changes
        }

        private void btnSparaPodd_Click(object sender, EventArgs e)
        {
<<<<<<< Updated upstream
            string urlText = tbLank.Text;
            string namnText = tbNamn.Text;
            string valKategori = cbValKategori.SelectedItem.ToString();
=======
            if (tbNamn.Text == null || tbNamn.Text == "")
            {
                poddController.SavePod(tbLank.Text, tbPoddNamn.Text);
                int cbIndex = cbValKategori.SelectedIndex;
            }
            else
            {
                poddController.SavePod(tbLank.Text, tbNamn.Text);
            }
        }

        private void btnHamtaPodd_Click(object sender, EventArgs e)
        {
            poddController.HamtaPoddFranRss(tbLank.Text);
            tbPoddNamn.Text = poddController.GetPodName();
            tbNamn.Text = poddController.GetPodName();
>>>>>>> Stashed changes
        }

        private void cbValKategori_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void Fyllcb()
        {
            List<string> kategoriLista = kategoriController.LasAllaKategorier();
            foreach (string s in kategoriLista)
            {
                cbValKategori.Items.Add(s);
            }

        }
<<<<<<< Updated upstream
=======

        private void btnHamtaPodd1_Click(object sender, EventArgs e)
        {
            poddController.HamtaPoddFranRss(tbLank.Text);
            tbPoddNamn.Text = poddController.GetPodName();
            tbNamn.Text = poddController.GetPodName();
        }

        private void minaPoddarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            MinaPoddar minaPoddar = new MinaPoddar();
            minaPoddar.Show();
        }

        private void startsidanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            StartSida startSida = new StartSida();
            startSida.Show();
        }

        private void minaPoddarToolStripMenuItem_Click_1(object sender, EventArgs e)
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
>>>>>>> Stashed changes
    }
}
