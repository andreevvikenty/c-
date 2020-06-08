using System;
using System.Runtime.InteropServices;

namespace L4.Task2
{
    class Program
    {        
        [DllImport(@"Dll&files\Math.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Sum(int numb1, int numb2);

        [DllImport(@"Dll&files\Math.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int Dif(int numb1, int numb2); 

        [DllImport(@"Dll&files\Math.dll", CallingConvention = CallingConvention.StdCall)]
        public static extern int Mul(int numb1, int numb2); 

        [DllImport(@"Dll&files\Math.dll", CallingConvention = CallingConvention.ThisCall)]
        public static extern Double Division(int numb1, int numb2); 

        [DllImport(@"Dll&files\Math.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int Div(int numb1, int numb2); 

        [DllImport(@"Dll&files\Math.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int Mod(int numb1, int numb2); 

        [DllImport(@"Dll&files\Math.dll", CallingConvention = CallingConvention.Winapi)]
        public static extern int Pow(int numb1, int numb2); 
        
        static void Main(string[] args)
        {            
            int numb1 = Input();
            int numb2 = Input();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("1.numb1 + numb2 = ");
                Console.WriteLine("2.numb1 - numb2 = ");
                Console.WriteLine("3.numb1 * numb2 = ");
                Console.WriteLine("4.numb1 / numb2 = ");
                Console.WriteLine("5.numb1 div numb2 = ");
                Console.WriteLine("6.numb1 mod numb2 = ");
                Console.WriteLine("7.numb1 ^ numb2 = ");                       
                Console.WriteLine("8.exit");  
                                            
                switch (Console.ReadLine())
                {
                    case "1":
                        Console.WriteLine(numb1.ToString() + " + " + numb2.ToString() + "=" +
                            Sum(numb1, numb2).ToString());
                        break;
                    case "2":
                        Console.WriteLine(numb1.ToString() + " - " + numb2.ToString() + " = " +
                            Dif(numb1, numb2).ToString());
                        break;
                    case "3":
                        Console.WriteLine(numb1.ToString() + " * " + numb2.ToString() + " = " +
                            Mul(numb1, numb2).ToString());
                        break;                        
                    case "4":
                        Console.WriteLine(numb1.ToString() + " / " + numb2.ToString() + " = " +
                            Division(numb1, numb2).ToString());
                        break;
                    case "5":
                        Console.WriteLine(numb1.ToString() + " div(" + numb2.ToString() + ") = " +
                            Div(numb1, numb2).ToString());
                        break;
                    case "6":
                        Console.WriteLine(numb1.ToString() + " mod(" + numb2.ToString() + ") = " +
                            Mod(numb1, numb2).ToString());
                        break;
                    case "7":
                        Console.WriteLine(numb1.ToString() + " pow(" + numb2.ToString() + ") = " +
                            Pow(numb1, numb2).ToString());
                        break;
                    case "8":
                        return;             
                    default:
                        Console.WriteLine("no such varient");
                        break;       
                }

                Console.ReadKey();
            }            
        }

        private static int Input()
        {
            Console.WriteLine("number:");

            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int numb))
                {
                    return numb;
                }
                else
                {
                    Console.WriteLine("incorrect input");
                }
            }            
        }
    }
}
