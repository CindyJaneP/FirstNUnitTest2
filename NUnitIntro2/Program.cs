// See https://aka.ms/new-console-template for more information
using NUnit.Framework;

Console.WriteLine("Hello, Cindy! Welcome to Paradise!");

namespace Tests
{
    [TestFixture]
        public class TestFixture
    {
        [Test]
        public void DisplayWelcome()
        {
            Console.WriteLine("Hello");
        }
    }
}