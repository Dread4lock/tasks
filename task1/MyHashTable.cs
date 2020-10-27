using System;
using System.Collections.Generic;
using System.Text;
using Task1.CustomList;

namespace Task1
{
    class MyHashTable
    {
        public int divNumber;
        private MyList<int>[] MyList;

        public MyHashTable(int size)
        {
            MyList = new MyList<int>[size];
        }

        public void Insert(int newValue)
        {
            var key = GetHash(newValue);
            if (MyList[key] == null)
            {
                MyList[key] = new MyList<int>() { newValue };
            }
            else
            {
                MyList[key].Add(newValue);
            }
        }

        public int GetHash(int newValue)
        {
            int key = newValue % divNumber;
            return key;
        }


        public void ShowNumbers(int before)
        {
            int after = GetHash(before); 
            Console.WriteLine("{0}: " + "{1}", after, before); 
        }

    }
}
