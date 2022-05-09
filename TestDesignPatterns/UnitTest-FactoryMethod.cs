using System;
using NUnit.Framework;
using DesignPatterns_CSharp.Creational;

namespace TestDesignPatterns
{
    public class UnitTestFactoryMethod
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FactoryMethodClient()
        {
            //Assert.Pass();
            Random r = new Random();
            int type = r.Next(0, 2);
            Dialog dialog = null;
            if (type == 1)
            {
                dialog = new IosDialog();
            }
            else
            {
                dialog = new WindowsDialog();
            }
            dialog.Render();
        }
    }
}