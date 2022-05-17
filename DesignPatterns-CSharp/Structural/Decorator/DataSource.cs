namespace DesignPatterns_CSharp.Structural.Decorator
{
    // The component interface defines operations that can be
    // altered by decorators.
    public interface IDataSource
    {
        void WriteData(string data);
        string ReadData();
    }

    // Concrete components provide default implementations for the
    // operations. There might be several variations of these
    // classes in a program.
    public class FileDataSource : IDataSource
    {
        public void WriteData(string data)
        {
            System.Console.Out.WriteLine("FileDataSource WriteData " + data);
        }

        public string ReadData()
        {
            System.Console.Out.WriteLine("FileDataSource ReadData ");
            return string.Empty;
        }
    }
    
    // The base decorator class follows the same interface as the
    // other components. The primary purpose of this class is to
    // define the wrapping interface for all concrete decorators.
    // The default implementation of the wrapping code might include
    // a field for storing a wrapped component and the means to
    // initialize it.
    public abstract class DataSourceDecorator : IDataSource
    {
        protected IDataSource wrappee;

        protected DataSourceDecorator(IDataSource source)
        {
            this.wrappee = source;
        }

        public void WriteData(string data)
        {
            wrappee.WriteData(data);
        }

        public string ReadData()
        {
            return wrappee.ReadData();
        }
    }

    // Concrete decorators must call methods on the wrapped object,
    // but may add something of their own to the result. Decorators
    // can execute the added behavior either before or after the
    // call to a wrapped object.
    public class EncryptionDecorator : DataSourceDecorator
    {
        public EncryptionDecorator(IDataSource source) : base(source)
        {
        }
        
        public new void WriteData(string data)
        {
            // 1. Compress passed data.
            // 2. Pass compressed data to the wrappee's writeData
            base.WriteData(data);
        }

        public new string ReadData()
        {
            // 1. Get data from the wrappee's readData method.
            // 2. Try to decompress it if it's compressed.
            return base.ReadData();
        }
    }

}