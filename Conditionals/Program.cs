using System.ComponentModel.Design;

bool isTrue = true;

if (isTrue == true)
{
    // Eğer şart sağlanırsa çalışacağ kod bloğudur.
}

if (isTrue)
{
    // Eğer şartta eşitlik kontrolü yapılmazsa, şartın kendisi true ise çalışacak kod bloğudur.
}

if(isTrue)
    Console.WriteLine();     // Eğer şart tek satır ise süslü parantezler kullanılmayabilir.

// Yukarıdaki if yapıları birbirine eşdeğerdir. Ancak ikinci ve üçüncü örnekler daha temiz
// ve okunabilir kod yazmak için tercih edilir.

if (isTrue)
{
    Console.WriteLine("Şart sağlandı.");
}
else
{
    Console.WriteLine("Şart sağlanmadı.");
}


int number = 10;

if (number < 10)
    Console.WriteLine("Sayı 10'dan küçüktür.");
else if (number == 10)
    Console.WriteLine("Sayı 10'a eşittir.");
else
    Console.WriteLine("Sayı 10'dan büyüktür.");
