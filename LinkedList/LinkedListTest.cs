using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace portfolio.LinkedList
{
    [TestFixture]
    class LinkedListTest
    {
        [Test]
        public void InsertBeginning()
        {
            var list = new LinkedList<int>();

            list.InsertBeginning(1);
            Assert.That(list.Length, Is.EqualTo(1));
            Assert.That(list.At(0), Is.EqualTo(1));
        }

        [Test]
        public void InsertAfter()
        {
            var list = new LinkedList<int>();

            list.InsertBeginning(1);

            list.InsertAfter(0, 5);
            Assert.That(list.Length, Is.EqualTo(2));
            Assert.That(list.At(0), Is.EqualTo(1));
            Assert.That(list.At(1), Is.EqualTo(5));
        }

        [Test]
        public void RemoveBeginning()
        {
            var list = new LinkedList<int>();
        }

        [Test]
        public void RemoveAfter()
        {
            
        }

        [Test]
        public void Length()
        {
            
        }
    }
}
