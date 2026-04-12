Console.Write("Terim sayısını giriniz: ");
int maxNumber = Convert.ToInt32(Console.ReadLine());

int firstNumber = 0;
int secondNumber = 1;

Console.Write($"{firstNumber} {secondNumber} ");

for (int i = 2; i < maxNumber; i++)
{
    int newNumber = firstNumber + secondNumber;
    Console.Write($"{newNumber} ");
    firstNumber = secondNumber;
    secondNumber = newNumber;
}