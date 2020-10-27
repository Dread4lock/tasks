using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Task1.CustomList
{
   public class MyList <T> : IEnumerable<T>
    { 
        public MyNode Head { get;  set; }
        public MyNode Tail { get;  set; }
        public int Count { get;  set; }

        public MyList()
        {
            Head = null;
            Tail = null;
            Count = 0;
        }
        public MyList(int data)
        {
            var node = new MyNode(data);
            Head = node;
            Tail = node;
            Count = 1;
        }

        public void Add(int newValue)
        {
            var item = new MyNode(newValue);
            if (Tail != null)
            {
                Tail.Next = item;
                Tail = item;
                Count++;
            }
            else
            {
                SetHeadAndTail(item);
            }
        }
        private void SetHeadAndTail(MyNode item)
        {
            Head = item;
            Tail = item;
            Count = 1;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return (IEnumerator<T>)((IEnumerable)this).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            MyNode current = Head;
            while (current != null)
            {
                yield return current.Value;
                current = current.Next;
            }
        }
    }
}
