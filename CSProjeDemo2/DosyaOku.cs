using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSProjeDemo2
{
    public class DosyaOku
    {
        public List<Personel> PersonelleriOku(string dosyaYolu)
        {
            List<Personel> personeller = new List<Personel>();
            using (StreamReader r = new StreamReader(dosyaYolu))
            {
                string json = r.ReadToEnd();
                personeller = JsonConvert.DeserializeObject<List<Personel>>(json);
            }
            return personeller;
        }
        public List<Yonetici> YoneticileriOku(string dosyaYolu)
        {
            List<Yonetici> yoneticiler = new List<Yonetici>();
            using (StreamReader r = new StreamReader(dosyaYolu))
            {
                string json = r.ReadToEnd();
                yoneticiler = JsonConvert.DeserializeObject<List<Yonetici>>(json);
            }
            return yoneticiler;
        }
        public List<Memur> MemurleriOku(string dosyaYolu)
        {
            List<Memur> memurler = new List<Memur>();
            using (StreamReader r = new StreamReader(dosyaYolu))
            {
                string json = r.ReadToEnd();
                memurler = JsonConvert.DeserializeObject<List<Memur>>(json);
            }
            return memurler;
        }

    }
}
