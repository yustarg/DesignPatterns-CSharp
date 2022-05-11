namespace DesignPatterns_CSharp.Creational.Builder
{
    public class Director
    {
        private IBuilder builder; 

        // The director works with any builder instance that the
        // client code passes to it. This way, the client code may
        // alter the final type of the newly assembled product.
        public void SetBuilder(IBuilder builder)
        {
            this.builder = builder;
        }
        
        // The director can construct several product variations
        // using the same building steps.
        public void ConstructSportsCar(IBuilder builder)
        {
            builder.Reset();
            builder.SetSeats(/*2*/);
            builder.SetEngine(/*new SportEngine()*/);
            builder.SetTripComputer(/*true*/);
            builder.SetGPS(/*true*/);
        }

        public void ConstructSUV(IBuilder builder)
        {
            
        }
    }
}