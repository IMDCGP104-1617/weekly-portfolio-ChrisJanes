using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace portfolio.Stack
{
    [TestFixture]
    class StackTest
    {
        [Test]
        public void CreateStack()
        {
           var testStack = new Stack<int>();

            Assert.IsNotNull(testStack);
            Assert.That(testStack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Pop()
        {
            var testStack = new Stack<int>();

            testStack.Push(15);
            testStack.Push(14);

            int output;

            testStack.Pop(out output);

            Assert.That(testStack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Push()
        {
            var testStack = new Stack<int>();

            testStack.Push(15);

            Assert.That(testStack.Count, Is.EqualTo(1));
        }

        [Test]
        public void IsEmpty()
        {
            var testStack = new Stack<int>();

            Assert.That(testStack.IsEmpty(), Is.EqualTo(true));

            testStack.Push(15);

            Assert.That(testStack.IsEmpty(), Is.EqualTo(false));
        }
    }
}
