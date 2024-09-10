internal class Program
{
    private static void Main(string[] args)
    {   
        // Constant cannot be changed.
        const int MAX_SPEED = 150;
        Console.WriteLine(MAX_SPEED);
        MAX_SPEED = 10;

        // Variable can change.
        int speed = 10;
        Console.WriteLine(speed);
        speed = 5;
        Console.WriteLine(speed);
    }
}