using DesignPatterns_CSharp.Prototype;
using NUnit.Framework;

namespace TestDesignPatterns
{
    public class UnitTestPrototype
    {
        [Test]
        public void PrototypeClient()
        {
            Circle circle = new Circle();
            circle.X = 10;
            circle.Y = 10;
            circle.Radius = 20;
            
            // The `anotherCircle` variable contains an exact copy
            // of the `circle` object.
            Circle anotherCircle = (Circle)circle.Clone();


            Rectangle rectangle = new Rectangle();
            rectangle.Width = 10;
            rectangle.Height = 20;
            Rectangle anotherRectangle = (Rectangle)rectangle.Clone();
        }

        
    }
}