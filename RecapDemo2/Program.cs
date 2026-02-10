// Kullanıcının yaşı girilerek Ehliyet alma durumunu kontrol eden bir program yazınız.

Console.Write("Yaşınızı giriniz: ");
int age = Convert.ToInt32(Console.ReadLine());

if (age < 18)
    Console.WriteLine("Ehliyet alamazsınız.");
else
    Console.WriteLine("Ehliyet alabilirsiniz.");

// Kullanıcının girdiği sayının tek mi çift mi olduğunu kontrol eden bir program yazınız.

Console.Write("Bir sayı giriniz: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number % 2 == 0)
    Console.WriteLine("Sayı çifttir.");
else
    Console.WriteLine("Sayı tektir.");

// Kullanıcının girdiği sayının pozitif, negatif veya sıfır olduğunu kontrol eden bir program yazınız.

Console.Write("Bir sayı giriniz: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
    Console.WriteLine("Sayı pozitiftir.");
else if (num < 0)
    Console.WriteLine("Sayı negatiftir.");
else
    Console.WriteLine("Sayı sıfırdır.");

// Kullanıcıdan alınan vize ve final notlarına göre öğrencinin geçip kalma durumunu kontrol eden bir program yazınız.
// Geçme notu 50'dir.
// Bütünleme sınavına girmek için vize notunun en az 40 olması gerekmektedir.

Console.Write("Vize notunuzu giriniz: ");
double midterm = Convert.ToDouble(Console.ReadLine());

Console.Write("Final notunuzu giriniz: ");
double final = Convert.ToDouble(Console.ReadLine());

double average = (midterm * 0.4) + (final * 0.6);

if (average >= 50)
    Console.WriteLine("Tebrikler, geçtiniz!");
else
{
    Console.Write("Bütünleme notunuzu giriniz: ");
    double makeup = Convert.ToDouble(Console.ReadLine());

    average = (midterm * 0.4) + (makeup * 0.6);

    if(average>=50)
        Console.WriteLine("Tebrikler, geçtiniz!");
    else
        Console.WriteLine("Maalesef, kaldınız.");
}