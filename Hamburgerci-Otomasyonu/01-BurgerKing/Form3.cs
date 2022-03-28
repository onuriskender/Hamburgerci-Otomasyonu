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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnExtraMalzemeEkle_Click(object sender, EventArgs e)
        {
            Form1.extralar.Add(new Extra { ExtraAdi = txtExtraMalzemeAdi.Text, Fiyati = nmrExtraMalzemeFiyati.Value });

            // TODO: Ekledikten sonra Temizle metodu çağrılsın.

            MessageBox.Show("Extra Malzeme Eklendi");
        }
    }
}
