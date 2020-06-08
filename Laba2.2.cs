using System;
using System.IO;

namespace lab2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            string str;
            Console.WriteLine("Set string");
            str = Console.ReadLine();

            var rnd = new Random();

            char[] a = str.ToCharArray();
               
            for (int i = a.Length - 1; i > 0; i--)
            {
                int j = rnd.Next(i);
                (a[i], a[j]) = (a[j], a[i]);
            }

            new string(a);
            Console.WriteLine(a);

            Console.ReadKey();
        }
    }
}
© 2020 GitHub, Inc.
