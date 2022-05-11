namespace DesignPatterns_CSharp.Creational.Builder
{
    // Using the Builder pattern makes sense only when your products
    // are quite complex and require extensive configuration. The
    // following two products are related, although they don't have
    // a common interface.
    public class Car
    {
    }

    public class Manual
    {
    }

    public interface IBuilder
    {
        void Reset();
        void SetSeats();
        void SetEngine();
        void SetTripComputer();
        void SetGPS();
    }
    
    
    // The concrete builder classes follow the builder interface and
    // provide specific implementations of the building steps. Your
    // program may have several variations of builders, each
    // implemented differently.
    public class CarBuilder : IBuilder
    {
        private Car car;

        // A fresh builder instance should contain a blank product
        // object which it uses in further assembly.
        public CarBuilder()
        {
            this.Reset();
        }
        
        // The reset method clears the object being built.
        public void Reset()
        {
            this.car = new Car();
        }

        // All production steps work with the same product instance.
        // Set the number of seats in the car.
        public void SetSeats()
        {
        }

        // Install a given engine.
        public void SetEngine()
        {
        }

        // Install a trip computer.
        public void SetTripComputer()
        {
        }

        // Install a global positioning system.
        public void SetGPS()
        {
        }

        // Concrete builders are supposed to provide their own
        // methods for retrieving results. That's because various
        // types of builders may create entirely different products
        // that don't all follow the same interface. Therefore such
        // methods can't be declared in the builder interface (at
        // least not in a statically-typed programming language).
        //
        // Usually, after returning the end result to the client, a
        // builder instance is expected to be ready to start
        // producing another product. That's why it's a usual
        // practice to call the reset method at the end of the
        // `getProduct` method body. However, this behavior isn't
        // mandatory, and you can make your builder wait for an
        // explicit reset call from the client code before disposing
        // of the previous result.
        public Car GetProduct()
        {
            return this.car;
        }
    }
    
    public class CarManualBuilder : IBuilder
    {
        private Manual manual;
        
        public CarManualBuilder()
        {
            this.Reset();
        }
        
        // The reset method clears the object being built.
        public void Reset()
        {
            this.manual = new Manual();
        }
        
        public void SetSeats()
        {
        }
        
        public void SetEngine()
        {
        }
        
        public void SetTripComputer()
        {
        }
        
        public void SetGPS()
        {
        }
        
        public Manual GetProduct()
        {
            return this.manual;
        }
    }
}