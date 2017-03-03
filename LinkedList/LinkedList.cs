using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace portfolio.LinkedList
{

    public class LinkedList<T>
    {
        public int Length { get; private set; }

        public class Node<T>
        {
            public T Data;
            public Node<T> NextNode;
        }

        public void InsertBeginning(T value)
        {
            throw new NotImplementedException();
        }

        public void InsertAfter(int index, T value)
        {
            throw new NotImplementedException();
        }

        public T At(int index)
        {
            throw new NotImplementedException();
        }

        public void RemoveBeginning()
        {
            throw new NotImplementedException();
        }

        public void RemoveAfter(int index)
        {
            throw new NotImplementedException();
        }
    }
}
