using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using NUnit.Framework.Internal;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
    class StackTests
    {
        [Test]
        public void Push_inputIsNull_ReturnArgumentNullException()
        {
            //Arrange
            var stack = new Fundamentals.Stack<string>();
            //Act

            //Assert
            Assert.That(() => stack.Push(null), Throws.ArgumentNullException);



        }

        [Test]
        public void Push_ValidObject_ObjectWillBeAddToList()
        {
            //Arrange
            var stack = new Fundamentals.Stack<string>();
            //Act
            stack.Push("Robert");
            //Assert
            Assert.That(stack.Count,Is.EqualTo(1));

        }

        [Test]
        public void Count_EmptyStack_ReturnZero()
        {
            //Arrange
            var stack = new Fundamentals.Stack<string>();
            //Assert
            Assert.That(stack.Count,Is.EqualTo(0));
        }



        [Test]
        public void Pop_EmptyStack_ThrowInvalidOperationException()
        {
            //Arrange
            var stack = new Fundamentals.Stack<string>();
            
            
            //Assert
            Assert.That(()=> stack.Pop(),Throws.InvalidOperationException);
            
        }

        [Test]
        public void Pop_StackWithFewObjects_RemoveObjectOnTheTop()
        {
            //Arrange
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            //Act
            var result = stack.Pop();

            //Assert
            Assert.That(result, Is.EqualTo("c"));

        }

        [Test]
        public void Pop_StackWithFewObjects_RemoveOneObjectFromStack()
        {
            //Arrange
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            //Act
            stack.Pop();

            //Assert
            Assert.That(stack.Count, Is.EqualTo(1));

        }

        [Test]
        public void Peek_emptyStack_ThrowInvalidOperationException()
        {
            //Arrange
            var stack = new Fundamentals.Stack<string>();
            
            //Assert
            Assert.That(()=> stack.Peek(),Throws.InvalidOperationException);

        }

        [Test]
        public void Peek_StackWithObjects_ReturnTopObjectFromStack()
        {
            //Arrange
            var stack = new Fundamentals.Stack<string>();
            stack.Push("a");
            stack.Push("b");
            stack.Push("c");
            //Act
            var result = stack.Peek();

            //Assert
            Assert.That(result,Is.EqualTo("c"));
        }

    }
}
