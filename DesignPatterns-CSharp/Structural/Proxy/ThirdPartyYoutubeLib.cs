namespace DesignPatterns_CSharp.Structural.Proxy
{
    public class ThirdPartyYoutubeLib
    {
        // The interface of a remote service.
        public interface IThirdPartyYouTubeLib
        {
            string ListVideos();
            string GetVideoInfo(int id);
            string DownloadVideo(int id);
        }

        // The concrete implementation of a service connector. Methods
        // of this class can request information from YouTube. The speed
        // of the request depends on a user's internet connection as
        // well as YouTube's. The application will slow down if a lot of
        // requests are fired at the same time, even if they all request
        // the same information.
        public class ThirdPartyYouTubeClass : IThirdPartyYouTubeLib
        {
            // Send an API request to YouTube.
            public string ListVideos()
            {
                return string.Empty;
            }

            // Get metadata about some video.
            public string GetVideoInfo(int id)
            {
                return string.Empty;
            }

            // Download a video file from YouTube.
            public string DownloadVideo(int id)
            {
                return string.Empty;
            }
        }

        // To save some bandwidth, we can cache request results and keep
        // them for some time. But it may be impossible to put such code
        // directly into the service class. For example, it could have
        // been provided as part of a third party library and/or defined
        // as `final`. That's why we put the caching code into a new
        // proxy class which implements the same interface as the
        // service class. It delegates to the service object only when
        // the real requests have to be sent.
        public class CachedYouTubeClass : IThirdPartyYouTubeLib
        {
            private IThirdPartyYouTubeLib service;
            private string listCache, videoCache;
            public bool needReset;

            public CachedYouTubeClass(IThirdPartyYouTubeLib service)
            {
                this.service = service;
            }

            public string ListVideos()
            {
                if (listCache == null || needReset)
                    listCache = service.ListVideos();
                return listCache;
            }


            public string GetVideoInfo(int id)
            {
                if (videoCache == null || needReset)
                    videoCache = service.GetVideoInfo(id);
                return videoCache;
            }

            public string DownloadVideo(int id)
            {
                if ( /*!downloadExists(id) || */needReset)
                    return service.DownloadVideo(id);

                return videoCache;
            }
        }
    }
}