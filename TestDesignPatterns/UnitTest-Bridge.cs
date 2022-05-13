using DesignPatterns_CSharp.Structural.Bridge;
using NUnit.Framework;

namespace TestDesignPatterns
{
    public class UnitTestBridge
    {
        [Test]
        public void BridgeClient()
        {
            Tv tv = new Tv();
            RemoteControl remote = new RemoteControl(tv);
            remote.TogglePower();

            Radio radio = new Radio();
            remote = new AdvancedRemoteControl(radio);
            ((AdvancedRemoteControl)remote).Mute();
        }
    }
}