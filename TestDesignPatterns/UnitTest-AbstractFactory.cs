using System;
using DesignPatterns_CSharp.Creational;
using DesignPatterns_CSharp.Creational.AbstractFactory;
using NUnit.Framework;
using IButton = DesignPatterns_CSharp.Creational.AbstractFactory.IButton;

namespace TestDesignPatterns
{
    public class UnitTestAbstractFactory
    {
        [Test]
        public void AbstractFactoryClient()
        {
            Random r = new Random();
            int type = r.Next(0, 2);

            IGUIFactory factory = null;
            IButton button = null;

            switch (type)
            {
                case 0: 
                    factory = new WinFactory();
                    break;
                case 1:
                    factory = new MacFactory();
                    break;
            }

            button = factory.CreateButton();
            button.Render();
        }
    }
}