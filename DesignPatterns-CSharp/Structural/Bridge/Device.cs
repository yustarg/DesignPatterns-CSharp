namespace DesignPatterns_CSharp.Structural.Bridge
{
    // The "implementation" interface declares methods common to all
    // concrete implementation classes. It doesn't have to match the
    // abstraction's interface. In fact, the two interfaces can be
    // entirely different. Typically the implementation interface
    // provides only primitive operations, while the abstraction
    // defines higher-level operations based on those primitives.
    public interface IDevice
    {
        void Enable();
        void SetVolume();
    }

    public class Tv : IDevice
    {
        public void Enable()
        {
            System.Console.WriteLine("Tv Enable");
        }

        public void SetVolume()
        {
            System.Console.WriteLine("Tv SetVolume");
        }
    }
    
    public class Radio : IDevice
    {
        public void Enable()
        {
            System.Console.WriteLine("Radio Enable");
        }

        public void SetVolume()
        {
            System.Console.WriteLine("Radio SetVolume");
        }
    }
}