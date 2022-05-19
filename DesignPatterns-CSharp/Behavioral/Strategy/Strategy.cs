namespace DesignPatterns_CSharp.Behavioral.Strategy
{
    // The strategy interface declares operations common to all
    // supported versions of some algorithm. The context uses this
    // interface to call the algorithm defined by the concrete
    // strategies.
    public interface IStrategy
    {
        int Execute(int a, int b);
    }
    
    // Concrete strategies implement the algorithm while following
    // the base strategy interface. The interface makes them
    // interchangeable in the context.
    public class ConcreteStrategyAdd : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a + b;
        }
    }
    
    public class ConcreteStrategySubtract : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a - b;
        }
    }
    
    public class ConcreteStrategyMultiply : IStrategy
    {
        public int Execute(int a, int b)
        {
            return a * b;
        }
    }
}