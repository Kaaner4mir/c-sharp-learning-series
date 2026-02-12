double result = 0;

Console.Write("Birinci sayıyı giriniz: ");
if (!double.TryParse(Console.ReadLine(), out double number1))
{
    Console.WriteLine($"Geçersiz bir sayı girdiniz!");
    return;
}

Console.Write("Yapmak istediğiniz matematiksel operatörü giriniz ( + - * / ): ");
string operatorInput = Console.ReadLine();

if (string.IsNullOrEmpty(operatorInput) || operatorInput.Length != 1)
{
    Console.WriteLine("Geçersiz bir operatör girdiniz!");
    return;
}



Console.Write("Ikinci sayıyı giriniz: ");
if (!double.TryParse(Console.ReadLine(), out double number2))
{
    Console.WriteLine("Geçersiz bir sayı girdiniz!");
    return;
}

switch (operatorInput)
{
    case "+":
        result = number1 + number2;
        break;
    case "-":
        result = number1 - number2;
        break;
    case "*":
        result = number1 * number2; break;
    case "/":
        if (number2 == 0)
        {
            Console.WriteLine("Bölen 0 olamaz!");
            return;
        }
        else
            result = number1 / number2;
        break;
    default:
        Console.WriteLine("Geçersiz operatör!");
        return;
}

Console.WriteLine($"Sonuç: {result}");