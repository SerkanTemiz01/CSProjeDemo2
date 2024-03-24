using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public abstract class Personel
    {
        public string Isim { get; set; }
        public string Unvan { get; set; }
        protected Personel(string ısim, string unvan)
        {
            Isim = ısim;
            Unvan = unvan;
        }

        public abstract decimal MaasHesapla(int calismaSaati);
      
    }
}
