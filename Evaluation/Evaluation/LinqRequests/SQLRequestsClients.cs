using Evaluation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation.LinqRequests
{

    class SQLRequestsClients
    {
        internal static void AddClient(Client client)
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                dbContext.Client.Add(client);
                dbContext.SaveChanges();
            }
        }

        internal static bool RemoveClient(int userID)
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                Client client = dbContext.Client.FirstOrDefault(f => f.ClientID == userID);
                if (client != null)
                {
                    dbContext.Client.Remove(client);
                    dbContext.SaveChanges();
                    return true;
                }
                else
                { 
                    Display.NoEntry();
                    return false;
                }
                
            }
        }

        internal static List<Client> ListClients()
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                return dbContext.Client.ToList();
            }
        }

        internal static Client GetClient(int userID)
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                return dbContext.Client.FirstOrDefault(f => f.ClientID == userID);
            }
        }

        internal static void ModifyClient(int userID, string clientName, string clientEmail)
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                var client = dbContext.Client.SingleOrDefault(f => f.ClientID == userID);
                client.ClientName = clientName;
                client.ClientEmail = clientEmail;
                dbContext.SaveChanges();
            }
        }
    }
}
