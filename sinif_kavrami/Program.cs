using System;
using System.Collections.Generic;

namespace sinif_kavrami
{
    class Program
    {
        static void Main(string[] args)
        {
            calisan calisan1=new calisan();
            calisan1.Ad="Volkan";
            calisan1.Soyad="Şallı";
            calisan1.No="00001004";
            calisan1.Departman="IT";
            //calisan1.CalisanBilgileri();
            calisan calisan2=new calisan();
            calisan2.Ad="Polat";
            calisan2.Soyad="Alemdar";
            calisan2.No="00000001";
            calisan2.Departman="KGT";
            //calisan2.CalisanBilgileri();
            List<calisan> calisanlistesi=new List<calisan>();
            calisanlistesi.Add(calisan1);
            calisanlistesi.Add(calisan2);
            foreach (var item in calisanlistesi)
            {
                Console.WriteLine(item.Ad);
                Console.WriteLine(item.Soyad);
                Console.WriteLine(item.No);
                Console.WriteLine(item.Departman);
                Console.WriteLine("******************");
            }
        
            
        }
        
    }
    class calisan
    {
        public string Ad;
        public string Soyad;
        public string No;
        public string Departman;
        public void CalisanBilgileri()
        {
            Console.WriteLine("Calisanin Adi {0}",Ad);
            Console.WriteLine("Calisanin Adi {0}",Soyad);
            Console.WriteLine("Calisanin Adi {0}",No);
            Console.WriteLine("Calisanin Adi {0}",Departman);
        }

    }
    
}
