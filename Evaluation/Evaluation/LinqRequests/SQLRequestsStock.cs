using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation.LinqRequests
{
    class SQLRequestsStock
    {
        internal static void AddStock(Product product, int productQuantity)
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                Stock stock = new Stock
                {
                    ProductID = product.ProductID,
                    ProductQuantity = productQuantity
                };

                dbContext.Stock.Add(stock);
                dbContext.SaveChanges();
            }
        }

        internal static List<Stock> ListStock()
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                return dbContext.Stock.ToList();
            }
        }

        internal static Stock GetStock(int productID)
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                return dbContext.Stock.FirstOrDefault(f => f.ProductID == productID);
            }
        }

        internal static void ChangeStock(int productID, int new_quantity)
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                Stock stock = dbContext.Stock.FirstOrDefault(f => f.ProductID == productID);
                stock.ProductQuantity = new_quantity;
                dbContext.SaveChanges();
            }
        }
    }
}
