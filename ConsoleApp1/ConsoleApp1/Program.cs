using System;

internal class Program
{
    private static void Main(string[] args)
    {
        // Main game information
        string gameTitle = "Minecraft";
        int releaseDateUnix = 1242514801; // Unix timestamp for 17th May 2009
        double priceStandard = 24.99;
        double priceDeluxe = 34.99;

        // Achievement related variables
        bool isCompleted = false;
        int achievements = 129;
        int achievementsUnlocked = 90;
        int achievementsRemaining = achievements - achievementsUnlocked;

        // User stats
        int hoursPlayed = 688;
        int blocksBroken = 221208;
        int monstersKilled = 2500;
        int distanceTravelled = 450785787;

        // Calculate the difference between the current date and the release date
        DateTime releaseDate = DateTimeOffset.FromUnixTimeSeconds(releaseDateUnix).UtcDateTime;
        DateTime currentDateTime = DateTime.UtcNow;

        // Calculate years, months, and days
        int years = currentDateTime.Year - releaseDate.Year;
        int months = currentDateTime.Month - releaseDate.Month;
        int days = currentDateTime.Day - releaseDate.Day;

        if (days < 0)
        {
            months--;
            days += DateTime.DaysInMonth(currentDateTime.Year, currentDateTime.Month - 1);
        }

        if (months < 0)
        {
            years--;
            months += 12;
        }

        if (days >= 1)
        {
            string daysText = $"{days} day old";
        }
        else if (days > 1)
        {
            string daysText = $"{days} days old"
        }

        // Print the result
        Console.WriteLine($"{gameTitle}");
        Console.WriteLine($"Standard Price: £{priceStandard}");
        Console.WriteLine($"Deluxe Price: £{priceDeluxe}");
        Console.WriteLine($"Age: {years} years, {months} months, and {daysText}");

        // Print achievements remaining
        Console.WriteLine($"Achievements: {achievementsUnlocked}/{achievements}");
        Console.WriteLine($"Achievements Remaining: {achievementsRemaining}");

        // Print user stats
        Console.WriteLine($"Hours Played: {hoursPlayed}");
        Console.WriteLine($"Blocks Broken: {blocksBroken}");
        Console.WriteLine($"Monsters Killed: {monstersKilled}");
        Console.WriteLine($"Distance Travelled: {distanceTravelled} blocks");
    }
}
