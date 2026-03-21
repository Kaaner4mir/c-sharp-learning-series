Console.WriteLine("--- 1. Tek Boyutlu Diziler (Single-Dimensional Arrays) ---");

// Yöntem 1: Boyut belirtme (Varsayılan değerlerle dolar. string için null olur)
string[] names = new string[3];
names[0] = "David";
names[1] = "Melina";
names[2] = "Jhonny";
// names[3] = "Alice"; // BU HATA VERİR: IndexOutOfRangeException (Dizi boyutu aşıldı)

// Yöntem 2: Boyut ve elemanları aynı anda belirtme
string[] names2 = new string[3] { "David", "Melina", "Jhonny" };

// Yöntem 3: Boyutu atanan elemanlardan anlayan tanımlama
string[] names3 = new string[] { "David", "Melina", "Jhonny" };

// Yöntem 4: En kısa syntax
string[] names4 = { "David", "Melina", "Jhonny" };

Console.WriteLine("Dizinin elemanları foreach kullanılarak ekrana yazdırılıyor:");
foreach (string name in names4)
{
    Console.WriteLine(name);
}

Console.WriteLine("\n--- 2. Dizi Özellikleri ve Sık Kullanılan Metotlar (Array Methods) ---");
int[] numbers = { 50, 20, 10, 80, 40 };

Console.WriteLine($"Length - Toplam eleman sayısı: {numbers.Length}");

Array.Sort(numbers); // Küçükten büyüğe sıralar: 10, 20, 40, 50, 80
Console.WriteLine("Sort() sonrası İlk Eleman [0]: " + numbers[0]); // 10

Array.Reverse(numbers); // Diziyi ters çevirir (şu an sıralı olduğu için büyükten küçüğe döner): 80, 50, 40, 20, 10
Console.WriteLine("Reverse() sonrası İlk Eleman [0]: " + numbers[0]); // 80

int index = Array.IndexOf(numbers, 20); // 20 sayısını bulur, indeksini döner.
Console.WriteLine("IndexOf() - 20 sayısının dizideki index değeri: " + index); // 3

// Clear metodu: Başlangıç indisi (0) ve sıfırlanacak eleman adedini (2) alır. 
// Sayısal değerler için sıfırlar (0 yapar).
Array.Clear(numbers, 0, 2); 
Console.WriteLine("Clear(0,2) sonrası ilk iki eleman: " + numbers[0] + " ve " + numbers[1]);

Console.WriteLine("\n--- 3. Çok Boyutlu Diziler (Multidimensional Arrays - Matrices) ---");
// 2 satır ve 3 sütunluk bir matris
int[,] matrix = new int[2, 3] 
{ 
    { 1, 2, 3 }, // 0. Satır
    { 4, 5, 6 }  // 1. Satır
};

// Değere erişme ve değeri değiştirme
Console.WriteLine("Matrisin [0,1] konumundaki elemanı: " + matrix[0, 1]); // 2 yazar
matrix[1, 2] = 99; // 1. satır 2. sütundaki elemanı (6) 99 yaptık
Console.WriteLine("Matrisin [1,2] konumundaki yeni elemanı: " + matrix[1, 2]);

Console.WriteLine("\n--- 4. Düzensiz Diziler (Jagged Arrays) ---");
// İçinde diziler tutan dizilerdir. Her satırın sütun (eleman) sayısı birbirinden farklı olabilir.
int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[2] { 1, 2 };          // 0. satır 2 elemanlı
jaggedArray[1] = new int[4] { 3, 4, 5, 6 };    // 1. satır 4 elemanlı
jaggedArray[2] = new int[1] { 7 };             // 2. satır sadece 1 elemanlı

Console.WriteLine("Jagged Array [1][2] konumundaki elemanı: " + jaggedArray[1][2]); // 5 yazar