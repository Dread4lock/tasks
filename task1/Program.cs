using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using Task1.CustomList;

namespace Task1
{
    class Program
    {

        static void Main(string[] args)
        {
            MyHashTable hashTable = new MyHashTable(100);
            hashTable.divNumber = Convert.ToInt32(Console.ReadLine());
            string[] tokens = Console.ReadLine().Split();
            foreach (string token in tokens)
            {
                int usernumber = Convert.ToInt32(token);
                hashTable.Insert(usernumber);
                hashTable.ShowNumbers(usernumber); 
            } 
            Console.ReadKey();

        }

    }
}
