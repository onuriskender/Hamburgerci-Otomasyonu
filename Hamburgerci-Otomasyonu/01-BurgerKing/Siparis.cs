using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BurgerKing
{
    // Bir siparişin .... özellikleri vardır.
    public class Siparis
    {
        public Menu SeciliMenusu { get; set; }
        public List<Extra> ExtraMalzemeleri { get; set; }
        public Boyut Boyutu { get; set; }
        public int Adet { get; set; }
        public decimal ToplamTutar { get; set; }


        public void Hesapla()
        {
            ToplamTutar = 0;
            ToplamTutar += SeciliMenusu.Fiyati;

            switch (Boyutu)
            {
                case Boyut.Orta:
                    ToplamTutar += ToplamTutar * 0.10M;
                    break;
                case Boyut.Buyuk:
                    ToplamTutar += ToplamTutar * 0.25M;
                    break;
            }

            ToplamTutar *= Adet;

            foreach (Extra item in ExtraMalzemeleri)
            {
                ToplamTutar += item.Fiyati;
            }
        }

        public override string ToString()
        {
            if (ExtraMalzemeleri.Count < 1)
            {
                return string.Format("{0} Menü x{1} Adet, {2} Boy, Toplam: {3}", SeciliMenusu.MenuAdi, Adet, Boyutu.ToString(), ToplamTutar.ToString("C2"));
            }
            else
            {
                string extraMalzemeler = null;
                foreach (Extra item in ExtraMalzemeleri)
                {
                    extraMalzemeler += item.ExtraAdi + ",";
                }

                extraMalzemeler = extraMalzemeler.Trim(',');

                return string.Format("{0} Menü x{1} Adet, {2} Boy, ({3}) Toplam: {4}", SeciliMenusu.MenuAdi, Adet, Boyutu.ToString(), extraMalzemeler, ToplamTutar.ToString("C2"));
            }
        }
    }
}
