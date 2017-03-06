using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;
using portfolio.LinkedList;

namespace portfolio.Queue
{
    class Queue<T>
    {
        private readonly LinkedList<T> queueList = new LinkedList<T>();

        public int Length => queueList.Length;

        public void Enqueue(T value)
        {
            queueList.InsertAfter(queueList.Length - 1, value);
        }

        public void Dequeue()
        {
            queueList.RemoveBeginning();
        }

        public bool? IsEmpty()
        {
            return Length == 0;
        }

        public T Peek()
        {
            return queueList.At(0);
        }
    }
}
