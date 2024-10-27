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
        public LaggTillPodd2()
        {
            poddController = new PoddController();
            InitializeComponent();
            tbPoddNamn.ReadOnly = true;
        }

        private void btnSparaPodd_Click(object sender, EventArgs e)
        {
            if(tbNamn.Text == null || tbNamn.Text == "")
            {
                poddController.SavePod(tbLank.Text, tbPoddNamn.Text);
            }
            else
            {
                poddController.SavePod(tbLank.Text, tbNamn.Text);
            }
        }

        private void btnHamtaPodd_Click(object sender, EventArgs e)
        {
            poddController.HämtaPoddFrånRss(tbLank.Text);
            tbPoddNamn.Text = poddController.GetPodName();
            tbNamn.Text = poddController.GetPodName();
        }
    }
}
