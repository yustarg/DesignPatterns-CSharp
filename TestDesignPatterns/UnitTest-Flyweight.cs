using DesignPatterns_CSharp.Structural.Flyweight;
using NUnit.Framework;

namespace TestDesignPatterns
{
    public class UnitTestFlyweight
    {
        [Test]
        public void Test()
        {
            Forest forest = new Forest();
            forest.Draw();
        }
    }
}