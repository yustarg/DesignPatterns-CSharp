namespace DesignPatterns_CSharp.Structural.Facade
{
    public class FacadeClient
    {
        public static void Run()
        {
            VideoConverter converter = new VideoConverter();
            converter.Convert("filename", "mp3");
        }
    }
}