using System;
using System.Collections.Generic;
using System.Text;

namespace Task1.CustomList
{
    public class MyNode  
    {
        public int Value { get; set; }
        public MyNode Next { get; set; }

        public MyNode(int value)
        {
            Value = value;
            Next = null;
        }
        public void Insert(int newValue)
        {
            if (Next==null)
            {
                Next = new MyNode(newValue);
            }
            else
            {
                Next.Insert(newValue);
            }
        }
    }
}
