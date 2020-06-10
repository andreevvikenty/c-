using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Kitchen : Room
    {
        public override void AddFurniture(Furniture a)
        {
            if((a & Furniture.Bed) != 0)
            {
                Console.WriteLine("Sleeping two steps from the fridge might be convenient, but yikes, man");
            }
            else
            {
                base.AddFurniture(a);
            }
        }
    }
}
