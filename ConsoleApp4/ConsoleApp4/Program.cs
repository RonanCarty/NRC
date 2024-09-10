using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Constants
        const int monthsInYear = 12;

        // Step 2
        Console.Write("Name: ");
        string name = Console.ReadLine();

        // Step 3
        Console.Write("Age: ");
        int age = int.Parse(Console.ReadLine());

        // Step 4
        Console.Write("Birth Month (1-12): ");
        int birthMonth = int.Parse(Console.ReadLine());

        Console.Write("Birth Day (1-31): ");
        int birthDay = int.Parse(Console.ReadLine());

        // Step 5
        Console.Write("Favorite colour: ");
        string colour = Console.ReadLine();

        DateTime today = DateTime.Now;

        int yearOfBirth = today.Year - age;

        DateTime birthdayThisYear = new DateTime(today.Year, birthMonth, birthDay);

        if (today < birthdayThisYear)
        {
            yearOfBirth--;
        }

        int monthsLived = age * monthsInYear;

        if (today < birthdayThisYear)
        {
            monthsLived -= monthsInYear;
        }

        // Step 7
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Year of birth: {yearOfBirth}");
        Console.WriteLine($"Months lived: {monthsLived}");
        Console.WriteLine($"Favorite colour: {colour}");
        Console.WriteLine("");
        Console.WriteLine("Thank you for using the program!");
        Console.WriteLine("");
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}
