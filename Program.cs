namespace nsam;

internal class Program
{
    static void GetConsent()
    {
        Console.WriteLine("\nI understand that by using this program to modify achievements, I may mess something up and I can only blame myself for the damage I cause. (y/n)");
        if (Console.ReadLine() != "y")
        {
            Console.WriteLine("\nConsent failed.");
            System.Environment.Exit(1);
        }
    }

    static void Main()
    {
        Console.WriteLine(" _        _______  _______  _______ ");
        Console.WriteLine("( (    /|(  ____ \\(  ___  )(       )");
        Console.WriteLine("|  \\  ( || (    \\/| (   ) || () () |");
        Console.WriteLine("|   \\ | || (_____ | (___) || || || |");
        Console.WriteLine("| (\\ \\) |(_____  )|  ___  || |(_)| |");
        Console.WriteLine("| | \\   |      ) || (   ) || |   | |");
        Console.WriteLine("| )  \\  |/\\____) || )   ( || )   ( |");
        Console.WriteLine("|/    )_)\\_______)|/     \\||/     \\|");

        Console.WriteLine("\nPlease enter your Steam login name:");
        var CurrentSteamUsername = Console.ReadLine();
        Console.WriteLine("\nPlease enter your Steam password:");
        var CurrentSteamPassword = Console.ReadLine();

        GetConsent();
        Console.WriteLine("\nConsented.");
    }
}
