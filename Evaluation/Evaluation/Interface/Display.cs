using Evaluation.LinqRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation.Interface
{
    class Display
    {
        internal static void Welcome()
        {
            Console.WriteLine("************************************************");
            Console.WriteLine("****     Bienvenue dans l'erp de Rémi       ****");
            Console.WriteLine("************************************************");
            Console.WriteLine();
            Console.WriteLine();
        }

        internal static void CommandMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************************************");
            Console.WriteLine("****              Gestion Commande          ****");
            Console.WriteLine("****     List ===> Liste Produits           ****");
            Console.WriteLine("****     Add ===> Créer commande            ****");
            Console.WriteLine("****     Mod ===> Modifier commande         ****");
            Console.WriteLine("****     Quit ===> Retour au menu principal ****");
            Console.WriteLine("************************************************");
            Console.ResetColor();
        }

        internal static void DisplayListCommands(List<Command> listCommand)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n          Affichage des commandes             ");
            foreach (var command in listCommand)
            {
                Console.WriteLine("--> ID Commande : {0}\tID Client : {1}\tAdresse : {2}",
                                    command.CommandID,
                                    command.ClientID,
                                    command.Address);
            }
            Console.WriteLine("         Fin d'affichage des commandes          \n");
            Console.ResetColor();
        }

        internal static void StockMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************************************");
            Console.WriteLine("****              Gestion Stock             ****");
            Console.WriteLine("****     List ===> Liste Produits           ****");
            Console.WriteLine("****     Mod  ===> Modifier qté produit     ****");
            Console.WriteLine("****     Quit ===> Retour au menu principal ****");
            Console.WriteLine("************************************************");
            Console.ResetColor();
        }



        internal static void MainMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            
            Console.WriteLine("************************************************");
            Console.WriteLine("****              Menu Principal            ****");
            Console.WriteLine("****     Cli  ===> Gestion Clients          ****");
            Console.WriteLine("****     Cmd  ===> Gestion Commandes        ****");
            Console.WriteLine("****     Prd  ===> Gestion Produits         ****");
            Console.WriteLine("****     Stk  ===> Gestion Stocks           ****");
            Console.WriteLine("****     Quit ===> Quitter                  ****");
            Console.WriteLine("************************************************");
            Console.WriteLine("\t\tMajuscules et minuscules autorisées dans les menus");
            Console.ResetColor();

        }

        internal static void NoEntry()
        {
            Console.WriteLine();
            Console.WriteLine("           Cette entrée n'existe pas.        ");
            Console.WriteLine();
        }

        internal static void ClientMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************************************");
            Console.WriteLine("****              Gestion Clients           ****");
            Console.WriteLine("****     List ===> Liste Clients            ****");
            Console.WriteLine("****     Add  ===> Ajouter Client           ****");
            Console.WriteLine("****     Rmv  ===> Supprimer Client         ****");
            Console.WriteLine("****     Mod  ===> Modifier Client          ****");
            Console.WriteLine("****     Quit ===> Retour au menu principal ****");
            Console.WriteLine("************************************************");
            Console.ResetColor();
        }

        internal static void DisplayListClients(List<Client> listeClients)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n          Affichage de la liste des clients    ");
            foreach (var client in listeClients)
            {
                Console.WriteLine("--> ID Client : {0}\tNom : {1}\tEmail : {2}",
                                   client.ClientID,
                                   client.ClientName,
                                   client.ClientEmail);
            }
            Console.WriteLine("         Fin de la liste des clients           \n");
            Console.ResetColor();
        }

        internal static void DisplayListProducts(List<Product> listProducts)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n          Affichage de la liste des produits    ");
            foreach (var product in listProducts)
            {
                Console.WriteLine("--> ID Produit : {0}\tNom : {1}\tPrix : {2}\tDescription : {3}",
                                   product.ProductID,
                                   product.ProductName,
                                   product.ProductPrice,
                                   product.ProductDesc);
            }
            Console.WriteLine("         Fin de la liste des produits           \n");
            Console.ResetColor();
        }

        internal static void DisplayListStock(List<Stock> listStock)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n          Affichage du stock des produits    ");
            foreach (var stock in listStock)
            {
                string productName = SQLRequestsProduct.GetName(stock.ProductID);
                Console.WriteLine("--> ID Produit : {0}\tNom : {1}\tQuantité : {2}",
                                   stock.ProductID,
                                   productName,
                                   stock.ProductQuantity);
            }
            Console.WriteLine("         Fin d'affichage des stocks          \n");
            Console.ResetColor();
        }

        internal static void ProductMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("************************************************");
            Console.WriteLine("****              Gestion Produits          ****");
            Console.WriteLine("****     List ===> Liste Produits           ****");
            Console.WriteLine("****     Add  ===> Ajout Produit            ****");
            Console.WriteLine("****     Rmv  ===> Supprimer Produit        ****");
            Console.WriteLine("****     Mod  ===> Modifier Produit         ****");
            Console.WriteLine("****     Quit ===> Retour au menu principal ****");
            Console.WriteLine("************************************************");
            Console.ResetColor();
        }

        internal static void Byebye()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine("************************************************");
            Console.WriteLine("****     Merci d'avoir utilisé notre erp    ****");
            Console.WriteLine("************************************************");
            Console.ReadKey();
        }

        internal static void EntryQuestionString()
        {
            Console.WriteLine("-----   Veuillez entrer votre choix SVP   ------");
        }


        internal static void EntryQuestionInt()
        {
            Console.WriteLine("-----   Veuillez entrer un entier SVP     ------");
        }

        internal static void DisplayClient(Client client)
        {
            Console.WriteLine("--> ID Client : {0}\tNom : {1}\tEmail : {2}",
                                   client.ClientID,
                                   client.ClientName,
                                   client.ClientEmail);
        }

    }
}
