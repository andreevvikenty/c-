using System;
using System.IO;

namespace Lab2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] alph = new char[26];
            
            for (char i = 'a'; i <= 'z'; i++)
            {
                alph[i - 'a'] = i;
            }

            Console.Write("Press <Enter> to continue\n");

            function(alph);
        }

        static void function(char[] alph)
        {
            while (true)
            {
                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {
                    Random rnd = new Random();
                    int val = rnd.Next(1, 5);
                    char[] mas = new char[val];

                    for (int i = 0; i < val; i++)
                    {
                        int index = rnd.Next(0, 26);
                        mas[i] = alph[index];
                    }

                    string str;
                    str = new string(mas);

                    Console.WriteLine(str);
                }
                else break;  
            }
        }
    }
}
