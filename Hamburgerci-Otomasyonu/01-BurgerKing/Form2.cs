﻿using System;
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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMenuEkle_Click(object sender, EventArgs e)
        {
            Form1.menuler.Add(new Menu { MenuAdi = txtMenuAdi.Text, Fiyati = nmrMenuFiyati.Value });

            // TODO: Ekledikten sonra temizle metodu çağrılsın.

            MessageBox.Show("Menü Eklendi");
        }
    }
}

