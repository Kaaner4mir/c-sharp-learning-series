class Program
{
    public static void Main()
    {
        // String bir char dizisidir.
        string text = "C# eğitim serisine Hoş Geldiniz!";

        foreach (var item in text)
        {
            Console.WriteLine(item);
        }

        // Value Type
        int a = 7;
        int b = a;
        a = 10;

        Console.WriteLine("a: "+a);  // 10
        Console.WriteLine("b: "+b);  // 7

        // Reference Type
        Person person1=new Person();
        person1.Name = "Alice";

        Person person2 = person1;
        person2.Name = "Jack";

        // Immutable
        string s1 = "Merhaba";
        string s2 = s1;

        s1 = s1 + " Dünya";

        Console.WriteLine(s1);

        // String tanımlama yolları
        // String Literal

        string p = "Selamlar";

        // String sınıfı

        String p2 = "Selamlar";
        Console.WriteLine(p);

        // new anahtar kelimesi ile

        string p3 = new string("Selamlar");

        // Verbatim String

        string path = @"C:\Users\Files";

        // String Interpolation

        string p4 = "Selamlar";
        Console.WriteLine($"path: {path}");
    }

    class Person
    {
        public string Name;
    }
}