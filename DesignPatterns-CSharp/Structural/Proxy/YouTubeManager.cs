namespace DesignPatterns_CSharp.Structural.Proxy
{
    // The GUI class, which used to work directly with a service
    // object, stays unchanged as long as it works with the service
    // object through an interface. We can safely pass a proxy
    // object instead of a real service object since they both
    // implement the same interface.
    public class YouTubeManager
    {
        protected ThirdPartyYoutubeLib.IThirdPartyYouTubeLib service;

        public YouTubeManager(ThirdPartyYoutubeLib.IThirdPartyYouTubeLib service)
        {
            this.service = service;
        }

        public void RenderVideoPage(int id)
        {
            string info = service.GetVideoInfo(id);
            
            // Render the video page.
           
        }

        public void RenderListPanel()
        {
            string list = service.ListVideos();
            // Render the list of video thumbnails.
        }



        public void ReactOnUserInput()
        {
            RenderVideoPage(0);
            RenderListPanel();
        }
    }
}