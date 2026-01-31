class Program
{
    public static void Main()
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        const decimal MONTHLY_FEE = 1540.13M;
        const byte MONTH_IN_YEAR = 12;

        Console.Write("Enter your first name: ");
        string? memberFirstName = Console.ReadLine();

        Console.Write("Enter your last name: ");
        string? memberLastName = Console.ReadLine();

        Console.Write("Enter your age: ");
        byte memberAge = byte.Parse(Console.ReadLine());

        Console.Write("Enter your height: ");
        double memberHeight = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter your weight: ");
        double memberWeight = Convert.ToDouble(Console.ReadLine());

        double bmi = memberWeight / (memberHeight * memberHeight);
        decimal totalCost = MONTHLY_FEE * MONTH_IN_YEAR;

        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("===== Member Information =====");
        Console.WriteLine($"\nMember    : {memberFirstName + " " + memberLastName}\n" +
                            $"Age       : {memberAge}\n" +
                            $"Height    : {memberHeight}cm\n" +
                            $"Weight    : {memberWeight}kg\n" +
                            $"BMI       : {bmi}\n" +
                            $"Total Cost: {totalCost}₺");

        Console.ResetColor();


    }
}