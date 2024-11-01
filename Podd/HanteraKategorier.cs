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
    public partial class HanteraKategorier : Form
    {
        KategoriController kategoriController;
        public HanteraKategorier()
        {
            InitializeComponent();
            kategoriController = new KategoriController();

            Fyllcb();

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


        private void Fyllcb()
        {
            cbBytNamnKategori.Items.Clear();
            cbKategori.Items.Clear();
            List<string> kategoriLista = kategoriController.LasAllaKategorier();
            foreach (string kategori in kategoriLista)
            {
                cbBytNamnKategori.Items.Add(kategori);
                cbKategori.Items.Add(kategori);
            }
            cbBytNamnKategori.SelectedIndex = 0;
            cbKategori.SelectedIndex = 0;
        }

        private void btnSparaNamn_Click(object sender, EventArgs e)
        {
            string valdKategori = cbBytNamnKategori.SelectedItem.ToString();
            string nyttKategoriNamn = tbBytNamn.Text;
            //kategoriController.LasAllaKategorier();
            Kategori kategori = kategoriController.hamtaKategoriByName(valdKategori);
            DialogResult dialogResult = MessageBox.Show("Är du säker?", "Byt namn på kategori", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                if (kategori != null)
                {
                    kategori.KattNamn = nyttKategoriNamn;

                    kategoriController.UpdateraKategori(kategori);
                }


                kategoriController.AndraKategoriNamn(valdKategori, nyttKategoriNamn);
                cbBytNamnKategori.Items.Clear();
                tbBytNamn.Clear();
            }
            else if (dialogResult == DialogResult.No)
            {
                HanteraKategorier hanteraKategorier = new HanteraKategorier();
            }
        }
    }
}
