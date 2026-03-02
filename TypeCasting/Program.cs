class Program
{
    public static void Main()
    {
        // Implicit (Örtülü) Casting (otomatik)

        int myIntNumber = 9;
        int myDoubleNumber = myIntNumber;

        Console.WriteLine($"myIntNumber: {myIntNumber}\n" +
                          $"myDoubleNumber: {myDoubleNumber}");

        // Explicit (Açık) Casting (manuel)  

        double myDouble = 9.78;
        int myInt = (int)myDouble; 

        Console.WriteLine($"\nmyDouble: {myDouble}\n" +
                          $"myInt: {myInt}");

        // Convert Sınıfı Kullanımı

        Console.WriteLine($"\n5,49: {Convert.ToInt32(5.49)}");
        Console.WriteLine($"5,50: {Convert.ToInt32(5.5)}");
        Console.WriteLine($"5,51: {Convert.ToInt32(5.51)}");

        Console.WriteLine($"\nTrue : {Convert.ToInt32(true)}");
        Console.WriteLine($"False: {Convert.ToInt32(false)}");
        Console.WriteLine($"Null : {Convert.ToInt32(null)}");

        Console.WriteLine($"\n1: {Convert.ToBoolean(1)}");
        Console.WriteLine($"0: {Convert.ToBoolean(0)}");
        Console.WriteLine($"0: {Convert.ToBoolean(0)}");

        // Parse Metodu Kullanımı

        string strNumber = "1234";
        int parsedNumber = int.Parse(strNumber);

        Console.WriteLine($"\nstrNumber: {strNumber}\n" +
                          $"parsedNumber: {parsedNumber}");

        // Kullanıcıdan Girdi (Input) Alma  

        Console.Write("\nBir sayı giriniz: ");
        string userInput = Console.ReadLine();

        Console.WriteLine("Girdiğiniz değer: " + userInput);

        Console.Write("Yaşınızı giriniz: ");
        byte age = Convert.ToByte(Console.ReadLine());

        Console.WriteLine("Yaşınız: " + age);

        // Nullable (Boş olabilir) Tipler ve Casting

        int? nullableInt = null;
        int nonNullableInt = nullableInt ?? 0; // Null-coalescing (Null birleştirme) Operatörü Kullanımı

        int? number = null;

        Console.WriteLine($"\nNumara (Değeri var mı?): {number.HasValue}");
        Console.WriteLine($"Numara (Değer veya Varsayılan): {number.GetValueOrDefault()}");

    }
}