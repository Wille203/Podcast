using BLL.Controller;
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
        PoddController poddController;
        KategoriController kategoriController;
        public LaggTillPodd2()
        {
            InitializeComponent();
            tbPoddNamn.ReadOnly = true;
            kategoriController = new KategoriController();
            kategoriController.SkapaFardigKategori();
            poddController = new PoddController();
            Fyllcb();
        }

        private void btnSparaPodd_Click(object sender, EventArgs e)
        {
            string podName = string.IsNullOrEmpty(tbNamn.Text) ? tbPoddNamn.Text : tbNamn.Text;
            string kategori = cbValKategori.SelectedItem?.ToString() ?? "";

            poddController.SavePod(tbLank.Text, podName, kategori);

            tbLank.Text = string.Empty;
            tbNamn.Text = string.Empty;
            tbPoddNamn.Text = string.Empty;
            cbValKategori.SelectedIndex = -1;

            MessageBox.Show("Podd sparad!"); 
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

        private void btnHamtaPodd1_Click(object sender, EventArgs e)
        {
            poddController.HamtaPoddFranRss(tbLank.Text);
            tbPoddNamn.Text = poddController.GetPodName();
            tbNamn.Text = poddController.GetPodName();
        }
    }
}
