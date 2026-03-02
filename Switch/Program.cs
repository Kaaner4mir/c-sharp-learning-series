string message;
Console.Write("Bir sayı girin: ");

if (!int.TryParse(Console.ReadLine(), out int number))
{
    Console.WriteLine("Geçersiz bir sayı girdiniz.");
    return;
}

switch (number)
{
    case 1:
        message = "Sayı 1.";
        break;
    case 2:
        message = "Sayı 2.";
        break;
    case 3:
        message = "Sayı 3.";
        break;
    default:
        message = "Sayı 1, 2 veya 3 değil.";
        break;
}


Console.WriteLine(message);

string day;

Console.Write("Haftanın gününü numerik olarak giriniz: ");
if (!short.TryParse(Console.ReadLine(), out short dayValue))
{
    Console.WriteLine("Geçersiz bir sayı girdiniz.");
    return;
}

switch (dayValue)
{
    case 1:
        day = DayOfWeek.Pazartesi.ToString();
        break;
    case 2:
        day = DayOfWeek.Salı.ToString();
        break;
    case 3:
        day = DayOfWeek.Çarşamba.ToString();
        break;
    case 4:
        day = DayOfWeek.Perşembe.ToString();
        break;
    case 5:
        day = DayOfWeek.Cuma.ToString();
        break;
    case 6:
        day = DayOfWeek.Cumartesi.ToString();
        break;
    case 7:
        day = DayOfWeek.Pazartesi.ToString();
        break;
    default:
        day = "Geçersiz bir gün girdiniz.";
        break;
}

Console.WriteLine($"Girdiğiniz gün: {day}");

Console.Write("Bir sayı girin: ");
if (!int.TryParse(Console.ReadLine(), out int num))
{
    Console.WriteLine("Geçersiz bir sayı girdiniz.");
    return;
}

string result = num switch
{
    1 => "Sayı 1.",
    2 => "Sayı 2.",
    3 => "Sayı 3.",
    _ => "Sayı 1, 2 veya 3 değil."
};

enum DayOfWeek
{
    Pazartesi = 0,
    Salı,
    Çarşamba,
    Perşembe,
    Cuma,
    Cumartesi,
    Pazar
}