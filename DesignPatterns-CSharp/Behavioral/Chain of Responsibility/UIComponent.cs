using System.Collections.Generic;

namespace DesignPatterns_CSharp.Behavioral.Chain_of_Responsibility
{
    // The handler interface declares a method for building a chain
    // of handlers. It also declares a method for executing a
    // request.
    public interface ComponentWithContextualHelp
    {
        void ShowHelp();
    }

    public abstract class UIComponent : ComponentWithContextualHelp
    {
        protected string tooltipText;

        // The component's container acts as the next link in the
        // chain of handlers.
        public Container container; 
        
        public virtual void ShowHelp()
        {
            if (tooltipText != null)
            {
                // Show tooltip.
            }
            else
            {
                container.ShowHelp();
            }
        }
    }
    
    // Containers can contain both simple components and other
    // containers as children. The chain relationships are
    // established here. The class inherits showHelp behavior from
    // its parent.
    public abstract class Container : UIComponent
    {
        private List<UIComponent> children;

        public void Add(UIComponent child)
        {
            children.Add(child);
            child.container = this;
        }
    }

    // But complex components may override the default
    // implementation. If the help text can't be provided in a new
    // way, the component can always call the base implementation
    // (see Component class).
    public class Panel : Container
    {
        public string modalHelpText;

        public override void ShowHelp()
        {
            if (modalHelpText != null)
            {
                // Show a modal window with the help text.
            }
            else
            {
                base.ShowHelp();
            }
        }
    }
    
    public class Dialog : Container
    {
        public string wikiPageURL;

        public override void ShowHelp()
        {
            if (wikiPageURL != null)
            {
                // Show a modal window with the help text.
            }
            else
            {
                base.ShowHelp();
            }
        }
    }
}