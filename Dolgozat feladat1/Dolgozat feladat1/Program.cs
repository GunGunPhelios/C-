using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat_feladat1
{
    internal class Program
    {
        static void Main()
        {
            string[] etelek = { "pizza", "Lasagne", "Palacsinta", "gyors pitában", "Paradicsomleves" };
            Console.WriteLine("A tömbben található ételek: " + string.Join(" ", etelek));
            bool vanPizza=false;
            foreach(string etel in etelek) 
            {
                if (etel.Equals("Pizza", StringComparison.OrdinalIgnoreCase))
                { vanPizza = true;
                break;
                }
            }
        if (vanPizza)
            {
                Console.WriteLine("Van pizza a tömbben! 🍕");

            }
        else
            {
                Console.WriteLine("Nincs pizza a tömbben. 😢");
                
            }
        }
        
    }
}
