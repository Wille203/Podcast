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
        public LaggTillPodd2()
        {
            InitializeComponent();
        }

        private void btnSparaPodd_Click(object sender, EventArgs e)
        {
            string urlText = tbLank.Text;
            string namnText = tbNamn.Text;
            string valKategori = cbValKategori.SelectedItem.ToString();
        }
    }
}
