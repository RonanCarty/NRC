internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello there!");
        Console.WriteLine("");
        
        Console.WriteLine("What is your first name?");
        string? firstName = Console.ReadLine();
        if (string.IsNullOrEmpty(firstName))
        {
            Console.WriteLine("You must enter a first name.");
            return;
        }
        else if (firstName.Length < 2)
        {
            Console.WriteLine("First name must be at least 2 characters long.");
            return;
        }
        else if (firstName.Length > 50)
        {
            Console.WriteLine("First name must be less than 50 characters long.");
            return;
        }

        Console.WriteLine("What is your last name?");
        string? lastName = Console.ReadLine();
        if (string.IsNullOrEmpty(lastName))
        {
            Console.WriteLine("You must enter a last name.");
            return;
        }
        else if (lastName.Length < 2)
        {
            Console.WriteLine("Last name must be at least 2 characters long.");
            return;
        }
        else if (lastName.Length > 50)
        {
            Console.WriteLine("Last name must be less than 50 characters long.");
            return;
        }


        Console.WriteLine("What is your age?");
        int? age = int.Parse(Console.ReadLine());
        if (age < 1)
        {
            Console.WriteLine("Age must be greater than 0.");
            return;
        }
        else if (age > 120)
        {
            Console.WriteLine("Age must be less than 120.");
            return;
        }

        Console.WriteLine("");
        Console.WriteLine("Hello " + firstName + " " + lastName + "!");
        Console.WriteLine("You are " + age + " years old.");
        Console.WriteLine("");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}