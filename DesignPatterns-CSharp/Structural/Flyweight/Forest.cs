using System.Collections.Generic;

namespace DesignPatterns_CSharp.Structural.Flyweight
{
    public class Forest
    {
        private List<Tree> trees;

        public Forest()
        {
            trees = new List<Tree>();
        }

        public void PlantTree(int x, int y, string name, string color, string texture)
        {
            TreeType t = TreeFactory.GetTreeType(name, color, texture);
            Tree tree = new Tree(x, y, t);
            trees.Add(tree);
        }

        public void Draw()
        {
            foreach (var tree in trees)
            {
                tree.Draw("canvas");
            }
        }
    }
}