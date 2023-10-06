using SteamWebAPI2.Interfaces;
using SteamWebAPI2.Utilities;

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
        };

        Console.WriteLine("\nI understand that this program is currently in development and there may exist glitches or bugs which mess up my Steam account. I will not use this program with my main Steam account. (y/n)");
        if (Console.ReadLine() != "y")
        {
            Console.WriteLine("\nConsent failed.");
            System.Environment.Exit(1);
        };
    }

    static async Task Main()
    {
        Console.WriteLine(" _        _______  _______  _______ ");
        Console.WriteLine("( (    /|(  ____ \\(  ___  )(       )");
        Console.WriteLine("|  \\  ( || (    \\/| (   ) || () () |");
        Console.WriteLine("|   \\ | || (_____ | (___) || || || |");
        Console.WriteLine("| (\\ \\) |(_____  )|  ___  || |(_)| |");
        Console.WriteLine("| | \\   |      ) || (   ) || |   | |");
        Console.WriteLine("| )  \\  |/\\____) || )   ( || )   ( |");
        Console.WriteLine("|/    )_)\\_______)|/     \\||/     \\|");

        GetConsent();
        Console.WriteLine("\nConsented.");

        Console.WriteLine("\nPlease enter your Steam API key:");
        var CurrentSteamAPIKey = Console.ReadLine();

        var WebInterfaceFactory = new SteamWebInterfaceFactory(CurrentSteamAPIKey);
        var SteamInterface = WebInterfaceFactory.CreateSteamWebInterface<SteamUser>(new HttpClient());

        var PlayerSummaryResponse = await SteamInterface.GetPlayerSummaryAsync(76561199083880215);
        var PlayerSummaryData = PlayerSummaryResponse.Data.Nickname;
        Console.WriteLine(PlayerSummaryData.ToString());
    }
}