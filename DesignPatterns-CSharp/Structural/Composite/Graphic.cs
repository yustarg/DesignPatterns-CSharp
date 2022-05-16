using System.Collections.Generic;

namespace DesignPatterns_CSharp.Structural.Composite
{
    // The component interface declares common operations for both
    // simple and complex objects of a composition.
    public interface IGraphic
    {
        void Move(float x, float y);
        void Draw();
    }
    
    // The leaf class represents end objects of a composition. A
    // leaf object can't have any sub-objects. Usually, it's leaf
    // objects that do the actual work, while composite objects only
    // delegate to their sub-components.
    public class Dot : IGraphic
    {
        private float x;
        private float y;
        
        public Dot(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void Move(float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public void Draw()
        {
            System.Console.WriteLine("Dot Draw");
        }
    }

    public class Circle : Dot
    {
        private float radius;
        
        public Circle(float x, float y, float r) : base(x, y)
        {
            this.radius = radius;
        }
        
        public new void Draw()
        {
            System.Console.WriteLine("Circle Draw");
        }
    }

    public class CompoundGraphic : IGraphic
    {
        private List<IGraphic> children = new List<IGraphic>();

        public void Add(IGraphic child)
        {
            children.Add(child);
        }
        
        public void Remove(IGraphic child)
        {
            children.Remove(child);
        }

        public void Move(float x, float y)
        {
            foreach (var child in children)
            {
                child.Move(x, y);
            }
        }
        
        // A composite executes its primary logic in a particular
        // way. It traverses recursively through all its children,
        // collecting and summing up their results. Since the
        // composite's children pass these calls to their own
        // children and so forth, the whole object tree is traversed
        // as a result.
        public void Draw()
        {
            foreach (var child in children)
            {
                child.Draw();
            }
        }
    }
}