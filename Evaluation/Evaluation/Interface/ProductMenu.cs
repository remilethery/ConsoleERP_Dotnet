using Evaluation.LinqRequests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation.Interface
{
    class ProductMenu
    {
        // Déclaration d'un produit et d'une liste auxquels on pourra 
        // accéder et modifier dans ce menu.
        Product product;
        List<Product> listProducts;

        internal void Run()
        {
            // String permettant de choisir le sous-menu ou de quitter
            string userEntry;
            Console.Clear();
            do
            {
                
                Display.ProductMenu();
                userEntry = UserEntry.GetAnswerString().ToUpper();
                switch (userEntry)
                {
                    case "ADD":
                        AddProduct();
                        break;
                    case "RMV":
                        RemoveProduct();
                        break;
                    case "MOD":
                        ModifyProduct();
                        break;
                    case "LIST":
                        ListProduct();
                        break;
                    case "QUIT":
                        break;
                }

            } while (userEntry != "QUIT");
            Console.Clear();
        }

        private void ListProduct()
        {
            listProducts = SQLRequestsProduct.ListProducts();
            Display.DisplayListProducts(listProducts);
        }

        private void ModifyProduct()
        {
            ListProduct();
            Console.WriteLine("Quel produit voulez-vous modifier (ID) ?");
            int productID = UserEntry.GetAnswerInt();
            Console.WriteLine("Entrez un nouveau nom pour ce produit");
            string productName = UserEntry.GetAnswerString();
            Console.WriteLine("Entrez un nouveau prix");
            decimal productPrice = UserEntry.GetAnswerDecimal();
            Console.WriteLine("Entrez une nouvelle description pour ce produit (optionnelle)");
            string productDesc = UserEntry.GetAnswerString();
            if (String.IsNullOrEmpty(productName.Trim()) || productPrice <= 0)
            {
                Console.WriteLine("Entrées invalides");
            }
            else
            {
                if (String.IsNullOrEmpty(productDesc)) { 
                    SQLRequestsProduct.ModifyProduct(productID, productName, productPrice);
                }
                else
                {
                    SQLRequestsProduct.ModifyProduct(productID, productName, productPrice, productDesc);
                }
            }

        }

        private void AddProduct()
        {
            Console.WriteLine("Entrez un nom de produit");
            string productName = UserEntry.GetAnswerString();
            Console.WriteLine("Entrez un prix");
            decimal productPrice= UserEntry.GetAnswerDecimal();
            Console.WriteLine("Entrez une quantité");
            int productQuantity = UserEntry.GetAnswerInt();
            Console.WriteLine("Entrez une description (optionnelle)");
            string productDesc = UserEntry.GetAnswerString();

            if (String.IsNullOrEmpty(productName.Trim()) || productPrice <= 0)
            {
                Console.WriteLine("Entrées invalides");
            }
            else
            {
                // Ajout d'un produit dans la table Product
                product = new Product
                {
                    ProductName = productName,
                    ProductPrice = productPrice,
                    ProductDesc = productDesc
                };
                SQLRequestsProduct.AddProduct(product);
                // Ajout d'une quantité du produit dans la table Stock

                SQLRequestsStock.AddStock(product, productQuantity);
                Console.WriteLine("Produit Ajouté:{0} \t---\tQuantité Initiale {1}", productName, productQuantity);
            }
        }

        private void RemoveProduct()
        {
            ListProduct();
            Console.WriteLine("Entrez l'ID du produit à supprimer");
            int userID = UserEntry.GetAnswerInt();
            if (SQLRequestsProduct.RemoveProduct(userID))
            { 
                Console.WriteLine("Produit Supprimé !"); 
            }
            
        }



    }
}
