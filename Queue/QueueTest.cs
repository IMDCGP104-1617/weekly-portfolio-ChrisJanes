using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace portfolio.Queue
{
    [TestFixture]
    class QueueTest
    {
        [Test]
        public void Enqueue1()
        {
            var queueTest = new Queue<int>();

            queueTest.Enqueue(15);

            Assert.That(queueTest.Length, Is.EqualTo(1));
        }

        [Test]
        public void Enqueue2()
        {
            var queueTest = new Queue<string>();

            queueTest.Enqueue("hello world");

            Assert.That(queueTest.Length, Is.EqualTo(1));
        }

        [Test]
        public void Dequeue()
        {
            var queueTest = new Queue<int>();

            queueTest.Enqueue(15);
            queueTest.Enqueue(20);
            queueTest.Enqueue(25);
            queueTest.Dequeue();

            Assert.That(queueTest.Length, Is.EqualTo(2));
        }

        [Test]
        public void IsEmpty()
        {
            var queueTest = new Queue<int>();

            queueTest.Enqueue(25);
            queueTest.Dequeue();

            Assert.IsTrue(queueTest.IsEmpty());
        }

        [Test]
        public void IsNotEmpty()
        {
            var queueTest = new Queue<int>();

            queueTest.Enqueue(25);

            Assert.IsFalse(queueTest.IsEmpty());
        }

        [Test]
        public void Peek()
        {
            var queueTest = new Queue<int>();

            queueTest.Enqueue(25);
            queueTest.Enqueue(15);
            queueTest.Enqueue(5);

            Assert.That(queueTest.Peek(), Is.EqualTo(25));
        }
    }
}
