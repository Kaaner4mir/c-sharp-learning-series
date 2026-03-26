namespace RecapDemo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int correctNumber = rnd.Next(1, 101);

            int attempt = 7;

            Console.WriteLine("7 tahmin hakkın var");
            do
            {
                Console.Write("\n1 ile 100 arasında bir sayı tahmin edin: ");
                int number = Convert.ToInt32(Console.ReadLine());

                if (number > correctNumber)
                {
                    Console.WriteLine($"Daha küçük bir sayı tahmin et! (Kalan tahmin hakkı: {attempt})");
                    attempt--;
                }
                else if (number < correctNumber)
                {
                    Console.WriteLine($"Daha büyük bir sayı tahmin et! (Kalan tahmin hakkı: {attempt})");
                    attempt--;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"\nDoğru! Sayı: {correctNumber}\n");
                    Console.ResetColor();
                    break;
                }
            }
            while (attempt > 0);

            if (attempt == 0)
            {
                Console.WriteLine("\nKaybettiniz!\n" +
                                  $"Doğru sayı: {correctNumber}");

            }

        }
    }
}
