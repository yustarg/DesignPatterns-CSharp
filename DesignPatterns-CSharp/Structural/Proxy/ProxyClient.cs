namespace DesignPatterns_CSharp.Structural.Proxy
{
    public class ProxyClient
    {
        public static void Run()
        {
            var aYouTubeService = new ThirdPartyYoutubeLib.ThirdPartyYouTubeClass();
            var aYouTubeProxy = new ThirdPartyYoutubeLib.CachedYouTubeClass(aYouTubeService);
            var manager = new YouTubeManager(aYouTubeProxy);
            manager.ReactOnUserInput();
        }
    }
}