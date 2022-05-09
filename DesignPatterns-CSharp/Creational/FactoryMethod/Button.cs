using System;

namespace DesignPatterns_CSharp.Creational
{
    /// <summary>
    /// The product interface declares the operations that all
    /// concrete products must implement
    /// </summary>
    public interface IButton
    {
        void Render();
        void OnClick(Action onClick);
    }

    public class WindowsButton : IButton
    {
        public void Render()
        {
            // Render a button in Windows style.
            Console.WriteLine("WindowsButton Render()!");
        }

        public void OnClick(Action onClick)
        {
            // Bind a native OS click event.
        }
    }
    
    public class IosButton : IButton
    {
        public void Render()
        {
            // Render a button in iOS style.
            Console.WriteLine("IosButton Render()!");
        }

        public void OnClick(Action onClick)
        {
            // Bind a native OS click event.
        }
    }
}