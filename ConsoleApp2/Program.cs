using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            DosyaOku dosyaOku = new DosyaOku();
           
            List<Personel> personeller = dosyaOku.PersonelleriOku("personeller.json");

            MaasBordro maasBordro = new MaasBordro();
            maasBordro.BordroOlustur(personeller);
            maasBordro.RaporGoruntule(personeller);

            Console.ReadLine();
        }
    }
}
