Console.Write("Birinci sayıyı girin: ");
if (!double.TryParse(Console.ReadLine(), out double number1))
{
    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
    return;
}

Console.Write("İkinci sayıyı girin: ");
if (!double.TryParse(Console.ReadLine(), out double number2))
{
    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
    return;
}

Console.Write("Üçüncü sayıyı girin: ");
if (!double.TryParse(Console.ReadLine(), out double number3))
{
    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı girin.");
    return;
}

double maxNumber = number1;
double minNumber = number1;

if (number2 > maxNumber) maxNumber = number2;
if (number3 > maxNumber) maxNumber = number3;

if (number2 < minNumber) minNumber = number2;
if (number3 < minNumber) minNumber = number3;

Console.WriteLine($"En büyük sayı: {maxNumber}");
Console.WriteLine($"En küçük sayı: {minNumber}");
