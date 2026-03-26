namespace RecapDemo6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;

            Console.Write("Bir sayı girin: ");
            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 2)
            {
                isPrime = false;
            }
            else
            {
                for (int i = 2; i <= Math.Sqrt(number); i++)
                {
                    if (number % i == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }
            }

            if (isPrime)
            {
                Console.WriteLine($"{number} bir asal sayıdır.");
            }
            else
            {
                Console.WriteLine($"{number} bir asal sayı değildir.");
            }
        }
    }
}
