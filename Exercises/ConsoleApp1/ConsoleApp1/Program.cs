// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("0 - Coin Flip \n1 - User Permissions\n2 - Info Types");
string? chosenMenu = Console.ReadLine();
 switch (chosenMenu)
{
    case "0":
        CoinFlip _ = new();
        break;
    case "1":
        UserPermissions __ = new("ADMIN", 55);
        break;
    case "2":
        InfoTypes ___ = new();
        break;
    default:
        break;
}
