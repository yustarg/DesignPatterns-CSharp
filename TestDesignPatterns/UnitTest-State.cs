using DesignPatterns_CSharp.Behavioral.State;
using DesignPatterns_CSharp.Creational.Singleton;
using NUnit.Framework;

namespace TestDesignPatterns
{
    public class UnitTestState
    {
        [Test]
        public void PrototypeClient()
        {
            AudioPlayer player = new AudioPlayer();
            player.ClickLock();
            player.ClickPlay();
            player.ClickNext();
            player.ClickPrevious();
        }
    }
}