using System;
using Project;
using log4net;

namespace ConsoleApp5
{
    class Program
    {
         public static readonly ILog Log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);

        static void Main(string[] args)
        {
            Log.Info("started calucaltor");
            
           Console.WriteLine("Результат сложения");
            double result = MyLibrary.Add(27, 3);
            Console.WriteLine(result);
            

            Console.WriteLine("Результат деления");
            double result1 = MyLibrary.Divide(27, 3);
            Console.WriteLine(result1);

            Console.WriteLine("Результат умножения");
            double result2 = MyLibrary.Myltiply(9, 3);
            Console.WriteLine(result2);

            Console.WriteLine("Результат вычитания");
            double result3 = MyLibrary.Substract(27, 3);
            Console.WriteLine(result3);

            Log.Info("finishing calucaltor");

            Console.ReadLine();

        }
    }
}
