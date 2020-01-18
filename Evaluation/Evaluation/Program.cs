using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {

            // using (ErpEntities dbContext = new ErpEntities())


            // Création et appel d'une instance de la classe menu
            MainMenu mainMenu = new MainMenu();

            mainMenu.Run();


        }
    }
}
