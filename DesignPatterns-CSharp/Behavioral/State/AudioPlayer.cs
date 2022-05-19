namespace DesignPatterns_CSharp.Behavioral.State
{
    public class AudioPlayer
    {
        private State state;

        public AudioPlayer()
        {
            // Context delegates handling user input to a state
            // object. Naturally, the outcome depends on what state
            // is currently active, since each state can handle the
            // input differently.
            this.state = new ReadyState(this);
        }
        
        // Other objects must be able to switch the audio player's
        // active state.
        public void ChangeState(State state)
        {
            this.state = state;
        }

        public void ClickLock()
        {
            this.state.ClickLock();
        }
        
        public void ClickPlay()
        {
            this.state.ClickPlay();
        }
        
        public void ClickNext()
        {
            this.state.ClickNext();
        }
        
        public void ClickPrevious()
        {
            this.state.ClickPrevious();
        }
    }
}