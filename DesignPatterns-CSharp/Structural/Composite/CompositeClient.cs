using System.Collections.Generic;

namespace DesignPatterns_CSharp.Structural.Composite
{
    public static class CompositeClient
    {
        public static void Run()
        {
            ImageEditor editor = new ImageEditor();
            editor.Selected(new List<IGraphic>()
            {
                new Circle(1, 2, 3),
                new Circle(1, 2, 5),
                new Dot(3, 5),
            });
        }
    }
}