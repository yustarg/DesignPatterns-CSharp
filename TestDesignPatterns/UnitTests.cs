using System;
using NUnit.Framework;
using DesignPatterns_CSharp.Creational;

namespace TestDesignPatterns
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void FactoryMethodTest()
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