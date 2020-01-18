using Evaluation.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation.LinqRequests
{
    class SQLRequestsProduct
    {
        internal static void AddProduct(Product product)
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                dbContext.Product.Add(product);
                dbContext.SaveChanges();
            }
        }

        internal static bool RemoveProduct(int productID)
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                Product product = dbContext.Product.FirstOrDefault(f => f.ProductID == productID);
                if (product != null)
                {
                    dbContext.Product.Remove(product);
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

        internal static List<Product> ListProducts()
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                return dbContext.Product.ToList();
            }
        }

        internal static Product GetProduct(int productID)
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                return dbContext.Product.FirstOrDefault(f => f.ProductID == productID);
            }
        }

        internal static void ModifyProduct(int productID, string productName, decimal productPrice, string productDesc)
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                var product = dbContext.Product.SingleOrDefault(f => f.ProductID == productID);
                product.ProductName = productName;
                product.ProductPrice = productPrice;
                product.ProductDesc = productDesc;
                dbContext.SaveChanges();
            }
        }

        internal static void ModifyProduct(int productID, string productName, decimal productPrice)
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                var product = dbContext.Product.SingleOrDefault(f => f.ProductID == productID);
                product.ProductName = productName;
                product.ProductPrice = productPrice;
                dbContext.SaveChanges();
            }
        }

        internal static string GetName(int productID)
        {
            using (ErpEntities dbContext = new ErpEntities())
            {
                var product = dbContext.Product.SingleOrDefault(f => f.ProductID == productID);
                return product.ProductName;
            }

        }
    }
}
