
namespace DesignPatterns_CSharp.Prototype
{
    // Prototype is a creational design pattern that lets you copy existing objects 
    // without making your code dependent on their classes.
    public abstract class Shape
    {
        public int X;
        public int Y;

        protected Shape()
        {
            
        }
        
        protected Shape(Shape source)
        {
            this.X = source.X;
            this.Y = source.Y;
        }

        public abstract Shape Clone();
    }
    
    // Concrete prototype. The cloning method creates a new object
    // and passes it to the constructor. Until the constructor is
    // finished, it has a reference to a fresh clone. Therefore,
    // nobody has access to a partly-built clone. This keeps the
    // cloning result consistent.
    public class Rectangle : Shape
    {
        public int Width;
        public int Height;

        public Rectangle()
        {
        }

        // A parent constructor call is needed to copy private
        // fields defined in the parent class.
        public Rectangle(Rectangle source) : 
            base(source)
        {
            this.Width = source.Width;
            this.Height = source.Height;
        }
        
        public override Shape Clone()
        {
            return new Rectangle(this);
        }
    }

    public class Circle : Shape
    {
        public int Radius;

        public Circle()
        {
        }

        // A parent constructor call is needed to copy private
        // fields defined in the parent class.
        public Circle(Circle source) : 
            base(source)
        {
            this.Radius = source.Radius;
        }
        
        public override Shape Clone()
        {
            return new Circle(this);
        }
    }

}