using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;
using portfolio.LinkedList;

namespace portfolio.Stack
{
    class Stack<T>
    {
        private readonly LinkedList<T> stackList;

        public int Count => stackList.Length;

        public Stack()
        {
            stackList = new LinkedList<T>();
        }

        public void Push(T value)
        {
            stackList.InsertBeginning(value);
        }

        public bool Pop(out T output)
        {
            output = default(T);

            if (stackList.Length == 0)
                return false;

            output = stackList.Head.Data;

            stackList.RemoveBeginning();

            return true;
        }

        public bool IsEmpty()
        {
            return Count == 0;
        }
    }
}
