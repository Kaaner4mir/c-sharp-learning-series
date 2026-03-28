namespace RecapDemo8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Birinci sayıyı girin: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int ebob = 1;
            int minNumber = Math.Min(number1, number2);

            for (int i = minNumber; minNumber > 0; i--)
            {
                if (number1 % i == 0 && number2 % i == 0)
                {
                    ebob = i;
                    break;
                }
            }

            int ekok = (number1 * number2) / ebob;

            Console.WriteLine($"Ebob: {ebob}\nEkok: {ekok}");
        }
    }
}
