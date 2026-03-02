class Program
{
    public static void Main()
    {
        Student s1, s2, s3;

        s1.ID = 1;
        s1.FirstName = "John";
        s1.Average = 42.44;

        s2.ID = 2;
        s2.FirstName = "Alice";
        s2.Average = 53.14;

        s3.ID = 3;
        s3.FirstName = "Connan";
        s3.Average = 51.57;

    }

    struct Student
    {
        public int ID;
        public string FirstName;
        public double Average;

    }
}