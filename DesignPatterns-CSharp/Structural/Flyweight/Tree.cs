using System.Collections.Generic;

namespace DesignPatterns_CSharp.Structural.Flyweight
{
    // The flyweight class contains a portion of the state of a
    // tree. These fields store values that are unique for each
    // particular tree. For instance, you won't find here the tree
    // coordinates. But the texture and colors shared between many
    // trees are here. Since this data is usually BIG, you'd waste a
    // lot of memory by keeping it in each tree object. Instead, we
    // can extract texture, color and other repeating data into a
    // separate object which lots of individual tree objects can
    // reference.
    public class TreeType
    {
        private string name;
        private string color;
        private string texture;  // normally the variable is Texture2D

        public TreeType(string name, string color, string texture)
        {
            this.name = name;
            this.color = color;
            this.texture = texture;
        }

        public void Draw(string canvas, int x, int y)
        {
            // 1. Create a bitmap of a given type, color & texture.
            // 2. Draw the bitmap on the canvas at X and Y coords.
        }
    }

    // The contextual object contains the extrinsic part of the tree
    // state. An application can create billions of these since they
    // are pretty small: just two integer coordinates and one
    // reference field.
    public class Tree
    {
        private int x;
        private int y;
        private TreeType treeType;

        public Tree(int x, int y, TreeType treeType)
        {
            this.x = x;
            this.y = y;
            this.treeType = treeType;
        }

        public void Draw(string canvas)
        {
            this.treeType.Draw(canvas, x, y);
        }
    }
    
    // Flyweight factory decides whether to re-use existing
    // flyweight or to create a new object.
    public class TreeFactory
    {
        private static Dictionary<string, TreeType> treeTypes;

        public static TreeType GetTreeType(string name, string color, string texture)
        {
            if (!treeTypes.TryGetValue(name, out TreeType t))
            {
                t = new TreeType(name, color, texture);
                treeTypes.Add(name, t);
            }

            return t;
        }
    }

   
}