using Evaluation.Interface;
using Evaluation.LinqRequests;
using System;
using System.Collections.Generic;

namespace Evaluation
{
    internal class CommandMenu
    {
        Command command;
        List<Command> listCommand;
        List<Stock> listStock;
        List<Client> listClients;

        internal void Run()
        {
            string userEntry;

            Console.Clear();
            do
            {
                Display.CommandMenu();
                userEntry = UserEntry.GetAnswerString().ToUpper();
                switch (userEntry)
                {
                    case "ADD":
                        AddCommand();
                        break;
                    case "LIST":
                        ListCommand();
                        break;
                    case "MOD":
                        ModifyCommand();
                        break;
                    case "QUIT":
                        break;
                }

            } while (userEntry != "QUIT");
            Console.Clear();
        }

        private void ModifyCommand()
        {
            throw new NotImplementedException();
        }

        private void ListCommand()
        {
            listCommand = SQLRequestsCommand.GetListCommands();
            Display.DisplayListCommands(listCommand);
        }

        private void AddCommand()
        {

            listClients = SQLRequestsClients.ListClients();
            Display.DisplayListClients(listClients);
            listStock = SQLRequestsStock.ListStock();
            Display.DisplayListStock(listStock);

            Console.WriteLine("\tCréation d'une commande\t");
            Console.WriteLine("Vous allez créer une commande");
            Console.Write("ID Client : ");
            int clientID = UserEntry.GetAnswerInt();
            Console.Write("ID Produit : ");
            int productID = UserEntry.GetAnswerInt();
            Console.Write("Quantité Produit : ");
            int productQuantity = UserEntry.GetAnswerInt();
            Console.Write("Adresse commande : ");
            string commandAddress = UserEntry.GetAnswerString();




        }
    }
}