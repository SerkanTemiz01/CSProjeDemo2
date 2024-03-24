using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class MaasBordro
    {
        public void BordroOlustur(List<Personel> personeller)
        {
            foreach (var personel in personeller)
            {
                decimal maas = personel.MaasHesapla(new Random().Next(150, 250)); // 150-250 arası rastgele çalışma saati
                string dosyaAdi = $"{personel.Isim}_{DateTime.Now:yyyy_MM_dd_HH_mm_ss}.json";
                using (StreamWriter file = File.CreateText(dosyaAdi))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(file, new
                    {
                        PersonelIsmi = personel.Isim,
                        CalismaSaati = new Random().Next(150, 250),
                        AnaOdeme = maas,
                        ToplamOdeme = maas
                    });
                }
            }
        }
        public void RaporGoruntule(List<Personel> personeller)
        {
            Console.WriteLine("Maaş Bordrosu");
            Console.WriteLine("--------------------");
            foreach (var personel in personeller)
            {
                decimal maas = personel.MaasHesapla(new Random().Next(150, 250)); // 150-250 arası rastgele çalışma saati
                Console.WriteLine($"{personel.Isim}: {maas} TL");
            }
        }
    }
}
