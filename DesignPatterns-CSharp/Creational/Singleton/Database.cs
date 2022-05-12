namespace DesignPatterns_CSharp.Creational.Singleton
{
    // The Database class defines the `getInstance` method that lets
    // clients access the same instance of a database connection
    // throughout the program.
    public class Database
    {
        // The field for storing the singleton instance should be
        // declared static.
        private static Database instance;
        
        private static readonly object lockObj = new object();
        
        // The singleton's constructor should always be private to
        // prevent direct construction calls with the `new`
        // operator.
        private Database()
        {
        }
        // Some initialization code, such as the actual
        // connection to a database server.
        // ...

        // The static method that controls access to the singleton
        // instance.
        public static Database getInstance()
        {
            if (instance == null)
            {
                // Ensure that the instance hasn't yet been
                // initialized by another thread while this one
                // has been waiting for the lock's release.
                lock (lockObj)
                {
                    if (instance == null)
                    {
                        instance = new Database();
                    }
                }
            }
            
            return instance;
        }
       

        // Finally, any singleton should define some business logic
        // which can be executed on its instance.
        // For instance, all database queries of an app go
        // through this method. Therefore, you can place
        // throttling or caching logic here.
        // ...
        public string Query(string key)
        {
            return string.Empty;
        }
    }
}