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
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();
        }


        public static List<Siparis> tumSiparisler = new List<Siparis>();
        public static List<Siparis> mevcutSiparisler = new List<Siparis>();

        public static List<Menu> menuler = new List<Menu>()
        {
            new Menu{MenuAdi = "Big King",Fiyati = 20.50M},
            new Menu{MenuAdi = "Whopper Jr.",Fiyati = 19.00M},
            new Menu{MenuAdi = "Double King Chicken",Fiyati = 21.00M},
            new Menu{MenuAdi = "Big Royale",Fiyati = 27.50M},
            new Menu{MenuAdi = "KöfteBurger",Fiyati = 23.50M},
            new Menu{MenuAdi = "Chicken Royale",Fiyati = 18.00M},
            new Menu{MenuAdi = "SteakHouse",Fiyati = 29.75M}
        };

        public static List<Extra> extralar = new List<Extra>()
        {
            new Extra{ExtraAdi = "Ketçap", Fiyati = 1.00M},
            new Extra{ExtraAdi = "Mayonez", Fiyati = 1.00M},
            new Extra{ExtraAdi = "BBQ Sos", Fiyati = 1.50M},
            new Extra{ExtraAdi = "Ranch Sos", Fiyati = 1.50M}
        };

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (Menu item in menuler)
                cmbMenuler.Items.Add(item); // ToString() metodu override edildiği için .... Menü şeklinde bastırılacak.

            foreach (Extra item in extralar)
                flpMalzemeler.Controls.Add(new CheckBox() { Text = item.ExtraAdi, Tag = item });


            foreach (Siparis item in mevcutSiparisler)
                lbxSiparisler.Items.Add(item); // Form açıldığında mevcut(Tamamlanmayan) sipariş varsa ListBox'a ekleyecektir.



            TutarHesapla();


            rdoKucuk.Checked = true;

            cmbMenuler.SelectedIndex = 0; // Default olarak -1 seçilidir. Ancak, -1 olursa herhangi bir eleman seçili olarak gelmez. 0 olursa ilk eleman seçili gelir.
        }

        private decimal TutarHesapla()
        {
            decimal toplamTutar = 0;
            for (int i = 0; i < lbxSiparisler.Items.Count; i++)
            {
                Siparis gelenSiparis = (Siparis)lbxSiparisler.Items[i];
                toplamTutar += gelenSiparis.ToplamTutar;
            }

            lblToplamTutar.Text = toplamTutar.ToString("c2");
            return toplamTutar;
        }

        private void btnSiparisEkle_Click(object sender, EventArgs e)
        {
            Siparis yeniSiparis = new Siparis();

            yeniSiparis.SeciliMenusu = (Menu)cmbMenuler.SelectedItem;

            if (rdoKucuk.Checked) //rdoKucuk.Checed == true
                yeniSiparis.Boyutu = Boyut.Kucuk;
            else if (rdoOrta.Checked)
                yeniSiparis.Boyutu = Boyut.Orta;
            else
                yeniSiparis.Boyutu = Boyut.Buyuk;


            yeniSiparis.ExtraMalzemeleri = new List<Extra>();

            foreach (CheckBox kontrol in flpMalzemeler.Controls)
            {
                if (kontrol.Checked) // kontrol.Checked == true;
                    yeniSiparis.ExtraMalzemeleri.Add((Extra)kontrol.Tag); // FLP'nin kontrollerinden her birinin Tag property'sinde tutulan Extra Malzeme nesnesinin bir kopyasını aldık ve sipariş nesnesinin ExtraMalzemeleri listesine ekledik.
            }

            yeniSiparis.Adet = (int)nmrAdet.Value;


            yeniSiparis.Hesapla(); // Classta yazılan metot sayesinde ToplamTutar hesaplanıp ilgili Property'ye aktarılacak.


            mevcutSiparisler.Add(yeniSiparis);
            lbxSiparisler.Items.Add(yeniSiparis);
            TutarHesapla(); // Toplam Tutarı Label'da gösterecek.
            tumSiparisler.Add(yeniSiparis);

            // Fonksiyon classından Temizle Metodu gelecek.
        }

        private void btnSiparisiTamamla_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Toplam Sipariş Tutarı: "+TutarHesapla().ToString("c2")+"\nSatın alma işlemini onaylıyor musunuz?","Sipariş Bilgisi",MessageBoxButtons.YesNo,MessageBoxIcon.Information);

            if (dr == DialogResult.Yes)
            {
                lbxSiparisler.Items.Clear(); // ListBox'ı temizle.
                mevcutSiparisler.Clear(); // mevcutSiparisler listesini temizle.
                TutarHesapla(); //Label'daki değeri temizle. (₺0,00)
                MessageBox.Show("Siparişiniz Tamamlandı");
            }
            else
            {
                MessageBox.Show("İşleminiz İptal Edildi.");
            }
        }
    }
}
