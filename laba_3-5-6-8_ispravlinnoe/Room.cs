using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
   
    class Room : Space<Furniture>
    {
        private static int idStart = 0;
        protected Furniture furniture;
        public int id;

        public Room() : base()
        {
            id = idStart;
            idStart++;
            furniture = 0;
        }

        public override Furniture Contents() => furniture;
        public virtual void AddFurniture(Furniture a) => furniture |= a;
        public void RemoveFurniture(Furniture a) => furniture = furniture ^ (furniture & a);
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value < idStart)
                {
                    Console.WriteLine("Are you sure? This id might have already been used y/n");
                    string x = Console.ReadLine();
                    if (x == "y")
                    {
                        id = value;
                    }
                    else
                    {
                        Console.WriteLine("Id input cancelled");
                    }
                    Console.In.ReadLine();
                }
            }
        }
    }
}
