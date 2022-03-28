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
    public partial class MyMDIForm : Form
    {
        public MyMDIForm()
        {
            InitializeComponent();
        }

        void ChildForm(Form childForm)
        {
            this.Width = childForm.Width + 20;
            this.Height = childForm.Height + 70;


            bool durum = false;

            foreach (Form item in MdiChildren)
            {
                if (item.Text == childForm.Text)
                {
                    durum = true;
                    item.Activate();
                }
                else
                {
                    item.Close();
                }
            }
            if (durum == false)
            {
                childForm.MdiParent = this;
                childForm.Show();
            }
        }
        private void tsmSiparisOlustur_Click(object sender, EventArgs e)
        {
            ChildForm(new Form1());
        }

        private void tsmSiparisBilgileri_Click(object sender, EventArgs e)
        {
            ChildForm(new Form4());
        }

        private void tsmMenuEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form2());
        }

        private void tsmExtraMalzemeEkle_Click(object sender, EventArgs e)
        {
            ChildForm(new Form3());
        }
    }
}
