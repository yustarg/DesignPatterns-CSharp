using DesignPatterns_CSharp.Structural.Adapter;
using NUnit.Framework;

namespace TestDesignPatterns
{
    public class UnitTestAdapter
    {
        [Test]
        public void AdapterClient()
        {
            HoleAndPegs.RoundHole hole = new HoleAndPegs.RoundHole(5);
            HoleAndPegs.RoundPeg rpeg = new HoleAndPegs.RoundPeg(5);
            hole.Fits(rpeg); // true

            HoleAndPegs.SquarePeg smallSqpeg = new HoleAndPegs.SquarePeg(5);
            HoleAndPegs.SquarePeg largeSqpeg = new HoleAndPegs.SquarePeg(10);
            //hole.Fits(small_sqpeg); // this won't compile (incompatible types)

            SquarePegAdapter smallSqpegAdapter = new SquarePegAdapter(smallSqpeg);
            SquarePegAdapter largeSqpegAdapter = new SquarePegAdapter(largeSqpeg);
            hole.Fits(smallSqpegAdapter); // true
            hole.Fits(largeSqpegAdapter); // false
        }
    }
}