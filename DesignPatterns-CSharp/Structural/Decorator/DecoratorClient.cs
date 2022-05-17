namespace DesignPatterns_CSharp.Structural.Decorator
{
    public class DecoratorClient
    {
        public static void Run()
        {
            IDataSource source = new FileDataSource(/*"somefile.dat"*/);
            // The target file has been written with plain data
            source.WriteData("salaryRecords");
            
            // The source variable now contains this:
            // Encryption > FileDataSource
            source = new EncryptionDecorator(source);
            source.WriteData("salaryRecords");
            // The file has been written with encrypted data.
        }
    }
}