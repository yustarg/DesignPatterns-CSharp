using System;

namespace DesignPatterns_CSharp.Structural.Adapter
{
    // An adapter class lets you fit square pegs into round holes.
    // It extends the RoundPeg class to let the adapter objects act
    // as round pegs.
    public class SquarePegAdapter : HoleAndPegs.RoundPeg
    {
        // In reality, the adapter contains an instance of the
        // SquarePeg class.
        private HoleAndPegs.SquarePeg peg;
        
        public SquarePegAdapter(HoleAndPegs.SquarePeg peg)
        {
            this.peg = peg;
        }

        // The adapter pretends that it's a round peg with a
        // radius that could fit the square peg that the adapter
        // actually wraps.
        public float GetRadius()
        {
            return peg.GetWidth() * (float)Math.Sqrt(2f) / 2;
        }
    }
}