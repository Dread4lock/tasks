using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) //Бесконечный цикл
            { 
                Console.WriteLine(RPN.Calculate(Console.ReadLine())); //Считываем, и выводим результат
            }
        }
    }
}
