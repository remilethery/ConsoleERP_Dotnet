using Evaluation.Interface;
using System;

namespace Evaluation
{
    internal class MainMenu
    {


        internal void Run()
        {
            // String permettant de choisir le sous-menu ou de quitter
            string userEntry;
            
            // Affichage message d'accueil
            Display.Welcome();

            do
            {
                Display.MainMenu();
                userEntry = UserEntry.GetAnswerString().ToUpper();
                switch (userEntry)
                {
                    case "CLI":
                        ClientMenu clientMenu = new ClientMenu();
                        clientMenu.Run();
                        break;
                    case "CMD":
                        CommandMenu commandMenu = new CommandMenu();
                        commandMenu.Run();
                        break;
                    case "PRD":
                        ProductMenu productMenu = new ProductMenu();
                        productMenu.Run();
                        break;
                    case "STK":
                        StockMenu stockMenu = new StockMenu();
                        stockMenu.Run();
                        break;
                    case "QUIT":
                        break;
                    default:
                        Display.NoEntry();
                        break;
                }

            } while (userEntry != "QUIT");

            Display.Byebye();
        }
    }
}