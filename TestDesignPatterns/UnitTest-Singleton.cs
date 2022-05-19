using DesignPatterns_CSharp.Creational.Singleton;
using NUnit.Framework;

namespace TestDesignPatterns
{
    public class UnitTestSingleton
    {
        [Test]
        public void SingletonClient()
        {
            Database foo = Database.getInstance();
            foo.Query("SELECT ...");
            // ...
            Database bar = Database.getInstance();
            bar.Query("SELECT ...");
        }
    }
}