using System;
using System.Text;

namespace StringBuilderProj
{
    class Program
    {
        static void Main(string[] args)
        {
            // --- StringBuilder Sınıfı ve Kullanımı --- //
            
            // 📌 Neden StringBuilder Kullanılır?
            // C#'ta string ifadeler "immutable" (değiştirilemez) yapılardır.
            // Bu nedenle, bir string üzerinde her değişiklik (ekleme, çıkarma, birleştirme) yaptığımızda, 
            // bellek (RAM) üzerinde eski string tutulurken yeni bir string nesnesi tahsis edilir.
            // Döngüsel veya sürekli string birleştirme işlemleri (+, +=, Concat) belleği yorar ve performansı düşürür.

            // 💡 Çözüm: System.Text altında bulunan "StringBuilder" sınıfıdır.
            // StringBuilder, metin üzerinde değişikliklerin doğrudan aynı bellek alanı üzerinde
            // (mutable - değiştirilebilir olarak) yeni kopyalar üretmeden yapılabilmesini sağlar.

            Console.WriteLine("--- StringBuilder Metotları ---");

            // 1. StringBuilder Nesnesi Oluşturma
            StringBuilder builder = new StringBuilder();
            
            // Opsiyonel olarak başlangıç kapasitesi belirterek performansı daha da arttırmak mümkündür:
            // StringBuilder builder = new StringBuilder(50); // İlk baştan itibaren bellekte 50 karakterlik yer ayırır.

            // 2. Veri Ekleme (Append)
            builder.Append("Merhaba");
            builder.Append(" ");
            builder.Append("Dünya!");

            // AppendLine ile sonuna enter (yeni satır sembolü \n) ekleyerek metni ekleriz
            builder.AppendLine(" Bugün günlerden C#.");
            builder.AppendLine("StringBuilder performansı arttırır.");

            Console.WriteLine("--- Mevcut Durum ---");
            Console.WriteLine(builder.ToString()); // StringBuilder'daki metni normal C# string veri tipine dönüştürmek için ToString() kullanılır.

            // 3. Araya Veri Ekleme (Insert)
            // 8. indexten sonraya "Kaan " kelimesini araya sıkıştıralım
            builder.Insert(8, "Kaan "); 
            Console.WriteLine("\n--- Insert (Araya Ekleme) Sonrası ---");
            Console.WriteLine(builder.ToString());

            // 4. İçerikteki Veriyi Değiştirme (Replace)
            // "Dünya" kelimesini "Galaksi" ile değiştirelim
            builder.Replace("Dünya", "Galaksi");
            Console.WriteLine("\n--- Replace (Değiştirme) Sonrası ---");
            Console.WriteLine(builder.ToString());

            // 5. Belirli Bir Aralıktaki Veriyi Silme (Remove)
            // 0. indexten itibaren 8 karakteri ("Merhaba ") silelim
            builder.Remove(0, 8); 
            Console.WriteLine("\n--- Remove (Silme) Sonrası ---");
            Console.WriteLine(builder.ToString());

            // 6. İçeriği Tamamen Temizleme (Clear)
            builder.Clear();
            Console.WriteLine("\n--- Clear (Temizleme) Sonrası Uzunluk ---");
            Console.WriteLine("Karakter sayısı: " + builder.Length);
            
            Console.ReadLine();
        }
    }
}
