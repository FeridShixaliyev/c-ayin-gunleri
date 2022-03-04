using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            string mounth;
                mounth=Console.ReadLine();
            switch (mounth)
            {
                case "january":
                    Console.WriteLine("31");
                    break;
                case "february":
                    Console.WriteLine("28");
                    break;
                case "march":
                    Console.WriteLine("31");
                    break;
                case "april":
                    Console.WriteLine("30");
                    break;
                case "may":
                    Console.WriteLine("31");
                    break;
                case "june":
                    Console.WriteLine("30");
                    break;
                case "jule":
                    Console.WriteLine("31");
                    break;
                case "august":
                    Console.WriteLine("31");
                    break;
                case "september":
                    Console.WriteLine("30");
                    break;
                case "october":
                    Console.WriteLine("31");
                    break;
                case "novomber":
                    Console.WriteLine("30");
                    break;
                case "december":
                    Console.WriteLine("31");
                    break;
                default:
                    Console.WriteLine("ayi duzgun qeyd edin");
                    break;
            }
        }
    }
}
