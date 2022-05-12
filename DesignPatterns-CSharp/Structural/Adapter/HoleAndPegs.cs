namespace DesignPatterns_CSharp.Structural.Adapter
{
    public class HoleAndPegs
    {
        
        // Say you have two classes with compatible interfaces:
        // RoundHole and RoundPeg.
        public class RoundHole
        {
            private float radius;

            public RoundHole(float radius)
            {
                this.radius = radius;
            }

            // Return the radius of the hole.
            public float GetRadius()
            {
                return radius;
            }

            public bool Fits(RoundPeg peg)
            {
                return this.GetRadius() >= peg.GetRadius();
            }
        }

        public class RoundPeg
        {
            private float radius;

            public RoundPeg(float radius)
            {
                this.radius = radius; 
            }

            protected RoundPeg()
            {
                
            }

            // Return the radius of the peg.
            public float GetRadius()
            {
                return radius;
            }
        }

        
        // But there's an incompatible class: SquarePeg.
        public class SquarePeg
        {
            private float width;

            public SquarePeg(float width)
            {
                this.width = width;
            }

            // Return the square peg width.
            public float GetWidth()
            {
                return width;
            }
        }
    }
}