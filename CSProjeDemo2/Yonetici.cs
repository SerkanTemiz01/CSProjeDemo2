using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Yonetici : Personel
    {
        public Yonetici(string ısim, string unvan) : base(ısim, unvan)
        {
        }

        public decimal Bonus { get; set; }  
        public override decimal MaasHesapla(int calismaSaati)
        {
            decimal saatlikUcret = 500;
            return saatlikUcret * calismaSaati + Bonus;
        }

      
    }
}
