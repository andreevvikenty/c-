using System;
using System.IO;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                string str;
                Console.WriteLine("Set string: ");
                str = Console.ReadLine();

                string[] str1 = str.Split(' ');

                function(str);

                Console.ReadKey();
            }
        }

        static void function(string str)
        {
            string res= string.Join(" ", str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries));

            string[] tmp = res.Split(' ');

            for (int i = 0; i < tmp.Length; i++)
            {
                Console.Write(tmp[tmp.Length-i-1] + " ");
            }
        }
    }
}
