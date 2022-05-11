using DesignPatterns_CSharp.Creational.Builder;
using NUnit.Framework;

namespace TestDesignPatterns
{
    
    public class UnitTestBuilder
    {
        [Test]
        public void BuilderClient()
        {
            Director director = new Director();

            CarBuilder builder = new CarBuilder();
            director.ConstructSportsCar(builder);
            Car car = builder.GetProduct();

            CarManualBuilder builder2 = new CarManualBuilder();
            director.ConstructSportsCar(builder2);

            // The final product is often retrieved from a builder
            // object since the director isn't aware of and not
            // dependent on concrete builders and products.
            Manual manual = builder2.GetProduct();
        }
    }
}