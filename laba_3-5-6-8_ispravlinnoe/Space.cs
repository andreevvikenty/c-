using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    abstract class Space<T> : IPriceable
    {
        public uint area { get; set; }
        public Location location { get; set; }
        abstract public T Contents();
        public double Price()
        {
            return area * (uint)location;
        }
    }

    [Flags]
    public enum Furniture { Bed=1, Chair=2, Table=4, Oven=8, Fridge=16}
    public enum Location { Minsk=1, Moscow=10, London=80}
}
