using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Memur : Personel
    {
        public Memur(string ısim, string unvan) : base(ısim, unvan)
        {
        }

        public string Derece { get; set; }

        // Memurun saatlik ücretini belirleyen metot
        private decimal SaatlikUcretBelirle()
        {
            switch (Derece)
            {
                case "1":
                    return 500; // Varsayılan ücret
                case "2":
                    return 600; // Örnek olarak 2. derece için 600 TL olarak belirlendi
                case "3":
                    return 700; // Örnek olarak 3. derece için 700 TL olarak belirlendi
                default:
                    return 500; // Varsayılan ücret
            }
        }
        public override decimal MaasHesapla(int calismaSaati)
        {
            decimal saatlikUcret=SaatlikUcretBelirle();
            decimal normalMaas = calismaSaati <= 180 ? saatlikUcret * calismaSaati : saatlikUcret * 180;
            decimal ekMesaiMaasi = calismaSaati > 180 ? (calismaSaati - 180) * (saatlikUcret * 1.5m) : 0;
            return normalMaas + ekMesaiMaasi;
        }

        
    }
}
