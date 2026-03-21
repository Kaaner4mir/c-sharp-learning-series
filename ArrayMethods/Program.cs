using System;

Console.WriteLine("--- Kapsamlı Dizi Metotları (Comprehensive Array Methods) ---");

int[] numbers = { 5, 2, 8, 1, 9, 3, 2, 7 };

Console.WriteLine("Orijinal Dizi: " + string.Join(", ", numbers));

// 1. Array.Sort()
Array.Sort(numbers);
Console.WriteLine("\n1. Array.Sort() (Sıralı): " + string.Join(", ", numbers));

// 2. Array.Reverse()
Array.Reverse(numbers);
Console.WriteLine("2. Array.Reverse() (Ters Çevrilmiş): " + string.Join(", ", numbers));

// 3. Array.IndexOf()
int indexOf8 = Array.IndexOf(numbers, 8);
Console.WriteLine($"\n3. Array.IndexOf(numbers, 8) -> {indexOf8}. indeks");

// 4. Array.LastIndexOf()
int lastIndexOf2 = Array.LastIndexOf(numbers, 2);
Console.WriteLine($"4. Array.LastIndexOf(numbers, 2) -> {lastIndexOf2}. indeks (Sondan arar, baştan sayarak indeks verir)");

// 5. Array.BinarySearch() (Dizi sıralı olmalıdır!)
Array.Sort(numbers); // BinarySearch öncesi sıraladık (Önemli!)
int binarySearchIndex = Array.BinarySearch(numbers, 7);
Console.WriteLine($"\n5. Array.BinarySearch(numbers, 7) (Sıralı dizide arar) -> {binarySearchIndex}. indeks");

// --- Predicate (Lambda =>) İsteyen Gelişmiş Arama Metotları ---

// 6. Array.Exists()
bool existsGreaterThan5 = Array.Exists(numbers, n => n > 5);
Console.WriteLine($"\n6. Array.Exists(numbers, n => n > 5) -> 5'ten büyük eleman var mı? {existsGreaterThan5}");

// 7. Array.Find()
int firstGreaterThan5 = Array.Find(numbers, n => n > 5);
Console.WriteLine($"7. Array.Find(numbers, n => n > 5) -> 5'ten büyük İLK eleman: {firstGreaterThan5}");

// 8. Array.FindAll()
int[] allGreaterThan5 = Array.FindAll(numbers, n => n > 5);
Console.WriteLine($"8. Array.FindAll(numbers, n => n > 5) -> 5'ten büyük TÜM elemanlar: {string.Join(", ", allGreaterThan5)}");

// 9. Array.FindIndex()
int indexGreaterThan5 = Array.FindIndex(numbers, n => n > 5);
Console.WriteLine($"9. Array.FindIndex(numbers, n => n > 5) -> 5'ten büyük ilk elemanın indeksi: {indexGreaterThan5}");

// 10. Array.FindLast()
int lastGreaterThan5 = Array.FindLast(numbers, n => n > 5);
Console.WriteLine($"10. Array.FindLast(numbers, n => n > 5) -> 5'ten büyük SON eleman: {lastGreaterThan5}");

// 11. Array.TrueForAll()
bool allPositive = Array.TrueForAll(numbers, n => n > 0);
Console.WriteLine($"11. Array.TrueForAll(numbers, n => n > 0) -> Tüm elemanlar 0'dan büyük mü? {allPositive}");

// 12. Array.ForEach()
Console.Write("12. Array.ForEach(numbers, action) -> Her elemanı ekrana yazdırır: ");
Array.ForEach(numbers, n => Console.Write($"[{n}] "));
Console.WriteLine();

// --- Yapısal (Dizileri Değiştiren) Metotlar ---

// 13. Array.Copy()
int[] copyDestination = new int[4];
// numbers dizisinin 2. indeksinden itibaren, 4 adet elemanı kopyala
Array.Copy(numbers, 2, copyDestination, 0, 4);
Console.WriteLine($"\n13. Array.Copy() ile kopyalanan alt dizi -> {string.Join(", ", copyDestination)}");

// 14. Array.Resize()
int[] resizableArray = { 1, 2, 3 };
// Boyutu 3'ten 5'e çıkar. Yeni açılan kısımlar int'in varsayılanı (0) ile dolar.
Array.Resize(ref resizableArray, 5);
Console.WriteLine($"14. Array.Resize() (Boyut 3'ten 5'e çıkarıldı) -> {string.Join(", ", resizableArray)}");

// 15. Array.Clear()
// Başlangıç indeksinden itibaren (0), belirtilen miktar kadar (2) elemanı sil (0 yapar).
Array.Clear(numbers, 0, 2); 
Console.WriteLine($"\n15. Array.Clear(numbers, 0, 2) (İlk 2 elemanı sıfırladık) -> {string.Join(", ", numbers)}");
