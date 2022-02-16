using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary.Assistansts
{
    public class Monitor
    {
        public static int ReadInteger(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            int a;

            try
            {
                a = Convert.ToInt32(aStr);
            }
            catch (Exception)
            {
                Console.Beep();
                PrintError("Sayi duzgun daxil edin !");
                goto l1;
            }

            return a;

        }

        public static void PrintError(string msg)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static string ReadString(string caption)
        {
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.Green;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;

            return aStr;
        }

        public static double ReadDouble(string caption)
        {
        l1:
            Console.Write(caption);
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string aStr = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.White;
            double a;

            try
            {
                a = Convert.ToDouble(aStr);
            }
            catch
            {
                Console.Beep();
                PrintError("Yeniden daxil edin!");
                goto l1;
            }

            return a;
        }

        public static void Print(string msg)
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(msg);
            Console.ForegroundColor = ConsoleColor.White;
        }

        public static bool Confirm(string message)
        {
            Console.Beep();
            Console.Write(message);

            string whiteSpace = new string(' ', Console.WindowWidth);
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Console.CursorLeft = 0;               
                Console.WriteLine(whiteSpace);

                if (Console.CursorTop > 0)
                {
                    Console.CursorTop -= 1;
                    Console.Write(whiteSpace);
                    Console.CursorLeft = 0;
                }
                return true;
            }

            Console.CursorLeft = 0;            
            Console.WriteLine(whiteSpace);

            return false;
        }



    }
}
