namespace DesignPatterns_CSharp.Structural.Bridge
{
    // The "abstraction" defines the interface for the "control"
    // part of the two class hierarchies. It maintains a reference
    // to an object of the "implementation" hierarchy and delegates
    // all of the real work to this object.
    public class RemoteControl
    {
        protected IDevice device;

        public RemoteControl(IDevice device)
        {
            this.device = device;
        }

        public void TogglePower()
        {
            this.device.Enable();
        }

        public void SetVolume()
        {
            this.device.SetVolume();
        }
    }

    public class AdvancedRemoteControl : RemoteControl
    {
        public AdvancedRemoteControl(IDevice device) : base(device)
        {
        }

        public void Mute()
        {
            this.device.SetVolume();
        }
    }
}