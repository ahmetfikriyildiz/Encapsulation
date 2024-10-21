using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Araba
    {
        // Özellikler (Properties)
        public string Marka { get; set; }
        public string Model { get; set; }
        public string Renk { get; set; }

        // Kapı Sayısı için özel alan (field)
        private int _kapiSayisi;

        // Kapı Sayısı özelliği (Property) - Kapsülleme ile
        public int KapiSayisi
        {
            get { return _kapiSayisi; }
            set
            {
                // Eğer kapı sayısı 2 veya 4 değilse uyarı mesajı verilir ve -1 atanır
                if (value == 2 || value == 4)
                {
                    _kapiSayisi = value;
                }
                else
                {
                    Console.WriteLine("Geçersiz Kapı Sayısı! Kapı sayısı 2 veya 4 olmalıdır.");
                    _kapiSayisi = -1;
                }
            }
        }

        // Constructor (Yapıcı Metot)
        public Araba(string marka, string model, string renk, int kapiSayisi)
        {
            Marka = marka;
            Model = model;
            Renk = renk;
            KapiSayisi = kapiSayisi; // Kapsüllenen özellik kullanılır
        }

        // Bilgileri yazdırma metodu
        public void BilgileriYazdir()
        {
            Console.WriteLine($"Marka: {Marka}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Renk: {Renk}");
            Console.WriteLine($"Kapı Sayısı: {KapiSayisi}");
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            // Geçerli kapı sayısı ile araba nesnesi oluşturma
            Araba araba1 = new Araba("Toyota", "Corolla", "Beyaz", 4);
            araba1.BilgileriYazdir();

            Console.WriteLine();

            // Geçersiz kapı sayısı ile araba nesnesi oluşturma
            Araba araba2 = new Araba("Honda", "Civic", "Kırmızı", 3);
            araba2.BilgileriYazdir();
            Console.ReadKey();
        }
    }
}
