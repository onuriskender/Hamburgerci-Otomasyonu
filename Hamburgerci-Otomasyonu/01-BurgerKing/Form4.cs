using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_BurgerKing
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            decimal ciro = 0;
            decimal extraMalzemeGeliri = 0;
            int satisAdedi = 0;

            foreach (Siparis siparis in Form1.tumSiparisler)
            {
                ciro += siparis.ToplamTutar;

                foreach (Extra ekstra in siparis.ExtraMalzemeleri)
                {
                    extraMalzemeGeliri += ekstra.Fiyati;
                }

                satisAdedi += siparis.Adet;

                lbxTumSiparisler.Items.Add(siparis);
            }

            lblCiro.Text = ciro.ToString("c2");
            lblExtraMalzemeGeliri.Text = extraMalzemeGeliri.ToString("c2");
            lblToplamSiparis.Text = lbxTumSiparisler.Items.Count.ToString();
            lblSatilanUrunSayisi.Text = satisAdedi.ToString();
        }
    }
}
