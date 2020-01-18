using Evaluation.Interface;
using Evaluation.LinqRequests;
using System;
using System.Collections.Generic;

namespace Evaluation
{
    internal class StockMenu
    {
        private List<Stock> listStock;

        internal void Run()
        {
            string userEntry;
            Console.Clear();
            do
            {

                Display.StockMenu();
                userEntry = UserEntry.GetAnswerString().ToUpper();
                switch (userEntry)
                {
                    case "MOD":
                        ModQuantity();
                        break;
                    case "LIST":
                        listStock = SQLRequestsStock.ListStock();
                        Display.DisplayListStock(listStock);
                        break;
                    case "QUIT":
                        break;
                }

            } while (userEntry != "QUIT");
            Console.Clear();
        }

        private void ModQuantity()
        {
            listStock = SQLRequestsStock.ListStock();
            Display.DisplayListStock(listStock);
            Console.WriteLine("Entrez l'ID du produit dont vous voulez modifier la quantité");
            int productID = UserEntry.GetAnswerInt();

            Stock stock = SQLRequestsStock.GetStock(productID); 
            if (stock != null)
            {
                Console.WriteLine("Entrez la modification sur la quantité");
                Console.WriteLine("!!!\tSi vous dépassez le zéro, la quantité sera mise à zéro\t!!!");
                int quantity = UserEntry.GetAnswerInt();
                int new_quantity = stock.ProductQuantity + quantity;
                new_quantity = (new_quantity < 0) ? 0 : new_quantity;

                SQLRequestsStock.ChangeStock(productID, new_quantity);
            }
            else
            {
                Console.WriteLine("Ce stock n'existe pas.");
            }
        }
    }
}