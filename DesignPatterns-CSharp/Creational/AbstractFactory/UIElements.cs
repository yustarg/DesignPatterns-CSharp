using System;

namespace DesignPatterns_CSharp.Creational.AbstractFactory
{
    public interface IButton
    {
        void Render();
    }

    public class WinButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("WinButton");
        }
    }
    
    public class MacButton : IButton
    {
        public void Render()
        {
            System.Console.WriteLine("MacButton");
        }
    }

    public interface ICheckbox
    {
        void Render();
    }
    
    public class WinCheckBox : ICheckbox
    {
        public void Render()
        {
            System.Console.WriteLine("WinCheckBox");
        }
    }
    
    public class MacCheckBox : ICheckbox
    {
        public void Render()
        {
            System.Console.WriteLine("MacCheckBox");
        }
    }
    
}