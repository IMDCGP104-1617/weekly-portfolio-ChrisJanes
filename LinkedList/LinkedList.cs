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

        private Node<T> head;

        public class Node<T>
        {
            public T Data;
            public Node<T> NextNode;
        }

        public void InsertBeginning(T value)
        {
            Length++;
            var newNode = new LinkedList<T>.Node<T> {Data = value};

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                newNode.NextNode = head;
                head = newNode;
            }
        }

        public void InsertAfter(int index, T value)
        {
            throw new NotImplementedException();
        }

        public T At(int index)
        {
            if ( Length == 0 || index >= Length)
                throw new IndexOutOfRangeException();

            var current = 0;
            var returnNode = head;

            while (current != index)
            {
                returnNode = returnNode.NextNode;

                current++;
            }

            return returnNode.Data;
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
