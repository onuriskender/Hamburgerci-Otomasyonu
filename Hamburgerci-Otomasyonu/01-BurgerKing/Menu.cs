using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_BurgerKing
{
    public class Menu
    {
        public string MenuAdi { get; set; }
        public decimal Fiyati { get; set; }

        // Nesne adıyla çağrıldığında, ComboBox'ta ..... Menü şeklinde görünebilmesi için:

        public override string ToString()
        {
            string donecekDeger = MenuAdi + " Menü";
            return donecekDeger;
        }
    }
}
