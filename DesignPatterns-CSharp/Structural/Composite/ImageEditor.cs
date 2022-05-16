using System.Collections.Generic;

namespace DesignPatterns_CSharp.Structural.Composite
{
    // The client code works with all the components via their base
    // interface. This way the client code can support simple leaf
    // components as well as complex composites.
    public class ImageEditor
    {
        private CompoundGraphic all;

        public ImageEditor()
        {
            Load();
        }

        private void Load()
        {
            all = new CompoundGraphic();
            all.Add(new Dot(1, 2));
            all.Add(new Circle(5, 3, 10));
        }

        public void Selected(List<IGraphic> components)
        {
            CompoundGraphic group = new CompoundGraphic();
            foreach (var comp in components)
            {
                group.Add(comp);
            }
            
            all.Add(group);
            all.Draw();
        }
    }
}