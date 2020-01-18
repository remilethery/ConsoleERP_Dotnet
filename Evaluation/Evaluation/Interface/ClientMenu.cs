using Evaluation.Interface;
using Evaluation.LinqRequests;
using System;
using System.Collections.Generic;

namespace Evaluation
{
    internal class ClientMenu
    {
        // Déclaration d'un client et d'une liste auxquels on pourra 
        // accéder et modifier dans ce menu.
        Client client;
        List<Client> listeClients;

        internal void Run()
        {
            string userEntry;

            Console.Clear();
            do
            {
                Display.ClientMenu();
                userEntry = UserEntry.GetAnswerString().ToUpper();
                switch (userEntry)
                {
                    case "ADD":
                        AddClient();
                        break;
                    case "RMV":
                        RemoveClient();
                        break;
                    case "MOD":
                        ModifyClient();
                        break;
                    case "LIST":
                        ListClient();
                        break;
                    case "QUIT":
                        break;
                }

            } while (userEntry != "QUIT");
            Console.Clear();
        }

        private void ListClient()
        {
            listeClients = SQLRequestsClients.ListClients();
            Display.DisplayListClients(listeClients);
        }

        private void ModifyClient()
        {
            ListClient();
            Console.WriteLine("Quel utilisateur voulez-vous modifier (ID) ?");
            int userID = UserEntry.GetAnswerInt();
            Console.WriteLine("Entrez un nouveau nom de client");
            string clientName = UserEntry.GetAnswerString();
            Console.WriteLine("Entrez un nouvel email");
            string clientEmail = UserEntry.GetAnswerString();
            if (String.IsNullOrEmpty(clientName.Trim()) || String.IsNullOrEmpty(clientEmail.Trim()))
            {
                Console.WriteLine("Entrées invalides");
            }
            else
            {
                SQLRequestsClients.ModifyClient(userID, clientName, clientEmail);
            }

        }

        private void AddClient()
        {
            Console.WriteLine("Entrez un nom de client");
            string clientName = UserEntry.GetAnswerString();
            Console.WriteLine("Entrez un email");
            string clientEmail = UserEntry.GetAnswerString();
            if (String.IsNullOrEmpty(clientName.Trim()) || String.IsNullOrEmpty(clientEmail.Trim()))
            {
                Console.WriteLine("Entrées invalides");
            }
            else
            {
                SQLRequestsClients.AddClient(new Client { ClientName = clientName, ClientEmail = clientEmail});
            }
        }

        private void RemoveClient()
        {
            ListClient();
            Console.WriteLine("Entrez l'ID du client à supprimer");
            int userID = UserEntry.GetAnswerInt();
            if (SQLRequestsClients.RemoveClient(userID))
            {
                Console.WriteLine("Client Supprimé !");
            }
            
        }


    }
}