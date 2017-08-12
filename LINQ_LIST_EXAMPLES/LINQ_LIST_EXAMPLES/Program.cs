using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_LIST_EXAMPLES
{
    class  ogrenci
    {
        public string isim;
        public double notOrtalamasi;
        public string bolum;
        public ogrenci(string isim, double notOrtalamasi, string bolum)
        {
            this.isim = isim;
            this.notOrtalamasi = notOrtalamasi;
            this.bolum = bolum;
        }
        public override string ToString()
        {
            return "İsim= " + isim + " Bölüm= " + bolum;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ogrenci ali = new ogrenci("ali", 90, "bilgisayar");
            List<ogrenci> sinif = new List<ogrenci>();
            sinif.Add(ali);
            Console.WriteLine(ali.ToString());
            Console.WriteLine(sinif.First());   // Aynı gösterimler
            Console.WriteLine(sinif.ElementAt(0));
            Console.WriteLine(sinif[0]);
            sinif.Add(new ogrenci("burak", 50, "tekstil"));
            sinif.Add(new ogrenci("emre", 20, "endustri"));
            sinif.Add(new ogrenci("yasin", 30, "mekatronik"));
            sinif.Add(new ogrenci("ezgi", 60, "inşaat"));
            foreach (ogrenci item in sinif)
            {
                Console.WriteLine(item);
            }
            var sonuc =
                from x in sinif
                where x.notOrtalamasi > 30
                orderby x.isim//LİNQ KUTUPHANESİNDEN BİR SQUERY YAZDIM
                select x;
            Console.WriteLine("--------------------------------");
            foreach (var item in sonuc)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
