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

        public Node<T> Head { get; private set; }

        public class Node<T>
        {
            public T Data;
            public Node<T> NextNode;
        }

        public void InsertBeginning(T value)
        {
            Length++;
            var newNode = new LinkedList<T>.Node<T> {Data = value};

            if (Head == null)
            {
                Head = newNode;
            }
            else
            {
                newNode.NextNode = Head;
                Head = newNode;
            }
        }

        public void InsertAfter(int index, T value)
        {
            if (Length == 0 || index >= Length)
                throw new IndexOutOfRangeException();

            var current = 0;
            var returnNode = Head;
            var newNode = new LinkedList<T>.Node<T>() {Data = value};

            while (current != index)
            {
                returnNode = returnNode.NextNode;

                current++;
            }

            newNode.NextNode = returnNode.NextNode;
            returnNode.NextNode = newNode;

            Length++;
        }

        public T At(int index)
        {
            if ( Length == 0 || index >= Length)
                throw new IndexOutOfRangeException();

            var current = 0;
            var returnNode = Head;

            while (current != index)
            {
                returnNode = returnNode.NextNode;

                current++;
            }

            return returnNode.Data;
        }

        public void RemoveBeginning()
        {
            if (Length == 0 || Head == null)
                return;

            Head = Head.NextNode;
            Length--;
        }

        public void RemoveAfter(int index)
        {
            if (Length == 0 || index >= Length)
                throw new IndexOutOfRangeException();

            var current = 0;
            var returnNode = Head;

            while (current != index)
            {
                returnNode = returnNode.NextNode;

                current++;
            }

            returnNode.NextNode = returnNode.NextNode.NextNode;

            Length--;
        }
    }
}
