using System;

Console.WriteLine("=== C# DÖNGÜLER (LOOPS) ===");
Console.WriteLine("Döngüler, aynı kodu tekrar tekrar çalıştırmak için kullanılır.\n");

// --- 1. FOR DÖNGÜSÜ ---
Console.WriteLine("--- 1. For Döngüsü ---");
/*
 * Neden 'i'? -> 'i', 'index' (indeks), 'iterator' (yineleyici) veya 'integer' (tamsayı) 
 * kelimelerinin kısaltması olarak ağırlıklı matematikten ve eski dillerden (örneğin Fortran ve C) gelir. 
 * Döngünün hangi adımda olduğunu (kaçar kaçar çalıştığını) tutan sayaç (counter) değişkeni olarak kullanılır. 
 * 
 * 'i++' nedir? -> '++' increment (arttırma) operatörüdür. 'i = i + 1' ile aynı anlama gelir, 
 * yani her döngü turunda değerini 1 arttırır.
 */
for (int i = 1; i <= 5; i++) 
{
    Console.WriteLine($"For Döngüsü Adım: {i}");
}

Console.WriteLine("\nÇift sayıları yazdırmak için artış miktarını değiştirme (i += 2):");
// İlla 'i' olmak zorunda değil. Herhangi bir isim verebiliriz ('j', 'sayac', 'siradakiDeger' vb.)
for (int j = 0; j <= 10; j += 2) 
{
    Console.Write(j + " ");
}
Console.WriteLine("\n");


// --- 2. WHILE DÖNGÜSÜ ---
Console.WriteLine("--- 2. While Döngüsü ---");
/*
 * Döngü başlangıcında koşul doğru (true) olduğu sürece blok çalışır.
 * Sayacı kendimiz dışarıda tanımlayıp, şartlar değiştikçe döngü içinde artırır veya azaltırız.
 */
int counter = 3;
while (counter > 0)
{
    Console.WriteLine($"While Döngüsü Sayac: {counter}");
    counter--; // Decrement: counter'ı her adımda 1 azaltır (counter = counter - 1)
}
Console.WriteLine();


// --- 3. DO-WHILE DÖNGÜSÜ ---
Console.WriteLine("--- 3. Do-While Döngüsü ---");
/*
 * 'While'dan farklı olarak, koşul sona yazıldığı ve en sonda kontrol edildiği için 
 * koşul BASTAN (false) OLSA BİLE kod EN AZ BİR KEZ ÇALIŞTIRILIR.
 */
int startValue = 100;
do
{
    Console.WriteLine($"Do-While Döngüsü (Koşul sağlamasa bile 1 kez çalıştı): {startValue}");
    startValue++;
} while (startValue < 10); // startValue 10'dan küçük değil (false) ama önce blok 1 kez çalıştı, sonra kontrol edildi.
Console.WriteLine();


// --- 4. FOREACH DÖNGÜSÜ ---
Console.WriteLine("--- 4. Foreach Döngüsü ---");
/*
 * Koleksiyonların (diziler, listeler vb.) her bir elemanı üzerinde
 * işlemler yapmak için kullanılır. Sayaca veya bitiş kontrolüne gerek yoktur.
 * Koleksiyon içerisindeki elemanlar bitene kadar dönmeye devam eder.
 */
string[] students = { "Ali", "Ayşe", "Mehmet", "Fatma" };

foreach (string student in students)
{
    Console.WriteLine($"Öğrenci: {student}");
}
Console.WriteLine();


// --- 5. DÖNGÜ KONTROL İFADELERİ (BREAK VE CONTINUE) ---
Console.WriteLine("--- 5. Break ve Continue ---");
for (int i = 1; i <= 5; i++)
{
    if (i == 3)
    {
        Console.WriteLine("Adım 3'ü atla (Continue)");
        continue; // 3 numaralı adımı burada es geçer ve sayacı arttırıp 4 numaralı iteration'a atlar.
    }
    
    if (i == 5)
    {
        Console.WriteLine("Adım 5'te döngüyü kır (Break)");
        break; // Döngüyü tamamen sonlandırır, döngünün dışına çıkar.
    }

    Console.WriteLine($"Mevcut Adım: {i}");
}

Console.WriteLine("\n--- Döngüler (Loops) incelemesi tamamlandı! ---");
