namespace DesignPatterns_CSharp.Behavioral.State
{
    // The base state class declares methods that all concrete
    // states should implement and also provides a backreference to
    // the context object associated with the state. States can use
    // the backreference to transition the context to another state.
    public abstract class State
    {
        protected AudioPlayer audioPlayer;

        // Context passes itself through the state constructor. This
        // may help a state fetch some useful context data if it's
        // needed.
        public State(AudioPlayer audioPlayer)
        {
            this.audioPlayer = audioPlayer;
        }

        public abstract void ClickLock();
        public abstract void ClickPlay();
        public abstract void ClickNext();
        public abstract void ClickPrevious();
    }
    
    // Concrete states implement various behaviors associated with a
    // state of the context.
    public class LockedState : State
    {
        public LockedState(AudioPlayer audioPlayer) : base(audioPlayer)
        {
        }

        public override void ClickLock()
        {
            if (true /*audioPlayer.playing*/)
                audioPlayer.ChangeState(new PlayingState(audioPlayer));
            else
                audioPlayer.ChangeState(new ReadyState(audioPlayer));
        }

        public override void ClickPlay()
        {
            // Locked, so do nothing.
        }

        public override void ClickNext()
        {
            // Locked, so do nothing.
        }

        public override void ClickPrevious()
        {
            // Locked, so do nothing.
        }
    }
    
    public class ReadyState : State
    {
        public ReadyState(AudioPlayer audioPlayer) : base(audioPlayer)
        {
        }

        public override void ClickLock()
        {
            audioPlayer.ChangeState(new LockedState(audioPlayer));
        }

        public override void ClickPlay()
        {
            //audioPlayer.startPlayback()
            audioPlayer.ChangeState(new PlayingState(audioPlayer));
        }

        public override void ClickNext()
        {
            // player.nextSong().
        }

        public override void ClickPrevious()
        {
            // player.previousSong()
        }
    }
    
    public class PlayingState : State
    {
        public PlayingState(AudioPlayer audioPlayer) : base(audioPlayer)
        {
        }

        public override void ClickLock()
        {
            audioPlayer.ChangeState(new LockedState(audioPlayer));
        }

        public override void ClickPlay()
        {
            //player.startPlayback()
            audioPlayer.ChangeState(new PlayingState(audioPlayer));
        }

        public override void ClickNext()
        {
            //  if (event.doubleclick)
            // player.nextSong()
            // else
            // player.fastForward(5)
        }

        public override void ClickPrevious()
        {
            // if (event.doubleclick)
            // player.previous()
            // else
            // player.rewind(5)
        }
    }
}