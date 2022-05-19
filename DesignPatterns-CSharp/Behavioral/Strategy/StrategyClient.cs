namespace DesignPatterns_CSharp.Behavioral.Strategy
{
    // The client code picks a concrete strategy and passes it to
    // the context. The client should be aware of the differences
    // between strategies in order to make the right choice.
    public class StrategyClient
    {
        public static void Run()
        {
            Context c = new Context();
            c.SetStrategy(new ConcreteStrategyAdd());
            c.ExecuteStrategy(1, 1);
            
            c.SetStrategy(new ConcreteStrategySubtract());
            c.ExecuteStrategy(1, 1);
            
            c.SetStrategy(new ConcreteStrategyMultiply());
            c.ExecuteStrategy(1, 1);
        }
    }
}