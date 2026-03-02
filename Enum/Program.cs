class Program
{
    public static void Main()
    {
        Days today = Days.Monday;

        Console.WriteLine($"Bugün: {today}\n");

        Direction direction = Direction.Down;

        switch (direction)
        {
            case Direction.Up: Console.WriteLine($"Yön: {direction}"); break;
            case Direction.Down: Console.WriteLine($"Yön: {(int)direction}"); break;
            case Direction.Left: Console.WriteLine($"Yön: {direction}"); break;
            case Direction.Right: Console.WriteLine($"Yön: {direction}"); break;
        }

    }
}

enum Days
{
    Monday = 0,
    Tuesday = 1,
    Wednesday = 2,
    Thursday = 3,
    Friday = 4,
    Saturday = 5,
    Sunday = 6,
}

enum Direction
{
    Up, Down, Left, Right,
}