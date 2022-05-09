using System;

namespace DesignPatterns_CSharp.Creational
{
    /// <summary>
    /// The creator class declares the factory method that must
    /// return an object of a product class. The creator's subclasses
    /// usually provide the implementation of this method.
    /// </summary>
    public abstract class Dialog
    {
        protected abstract IButton CreateButton();

        public virtual void Render()
        {
            IButton button = CreateButton();
            button.OnClick(() => { System.Console.WriteLine("OnClick"); });
            button.Render();
        }
    }
    
    /// <summary>
    /// Concrete creators override the factory method to change the
    /// resulting product's type.
    /// </summary>
    public class WindowsDialog : Dialog
    {
        protected override IButton CreateButton()
        {
            return new WindowsButton(); 
        }
    }
    
    public class IosDialog : Dialog
    {
        protected override IButton CreateButton()
        {
            return new IosButton(); 
        }
    }
}