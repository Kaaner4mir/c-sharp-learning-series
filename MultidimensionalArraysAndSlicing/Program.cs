using System;

namespace MultidimensionalArraysAndSlicing
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- 'var' Kullanımı ---");
            // 'var' kullanarak dizi tanımlama (Derleyici tipi otomatik algılar)
            var sehirler = new string[] { "Ankara", "İstanbul", "İzmir", "Bursa", "Antalya" };
            Console.WriteLine($"İlk şehir: {sehirler[0]} | Veri tipi: {sehirler.GetType().Name}\n");

            Console.WriteLine("--- Çok Boyutlu Diziler (Multidimensional Arrays) ---");
            // 3 satır, 2 sütundan oluşan 2 boyutlu bir dizi (matris)
            int[,] matris = new int[,] 
            {
                { 10, 20 },
                { 30, 40 },
                { 50, 60 }
            };

            Console.WriteLine("Matris Elemanları:");
            // GetLength(0) satır sayısını, GetLength(1) sütun sayısını verir
            for (int satir = 0; satir < matris.GetLength(0); satir++)
            {
                for (int sutun = 0; sutun < matris.GetLength(1); sutun++)
                {
                    Console.Write(matris[satir, sutun] + "\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("--- Dizilerde Dilimleme (Array Slicing) ---");
            int[] rakamlar = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Console.WriteLine($"Orijinal Dizi: {string.Join(", ", rakamlar)}");

            // Range (..) operatörü kullanımı (Başlangıç dahil, bitiş hariçtir)
            var dilim1 = rakamlar[2..6]; 
            Console.WriteLine($"2..6  (2. - 5. indeksler):  {string.Join(", ", dilim1)}");

            // Baştan belirli bir indekse kadar
            var ilkDort = rakamlar[..4];
            Console.WriteLine($"..4   (Baştan 4. indekse):  {string.Join(", ", ilkDort)}");

            // Belirli bir indeksten sona kadar
            var sonYarisi = rakamlar[5..];
            Console.WriteLine($"5..   (5. indeksten sona):  {string.Join(", ", sonYarisi)}");

            // Index (^) operatörü kullanımı (Sondan indeks) -> ^1 son elemandır
            Console.WriteLine($"^1    (Dizinin son elemanı): {rakamlar[^1]}");

            // İlk ve son elemanı atlayarak dilimleme
            var icKisim = rakamlar[1..^1];
            Console.WriteLine($"1..^1 (İlk ve son hariç):   {string.Join(", ", icKisim)}");

            Console.ReadLine();
        }
    }
}
