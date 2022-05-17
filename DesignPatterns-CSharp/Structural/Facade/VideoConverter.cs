namespace DesignPatterns_CSharp.Structural.Facade
{
    // We create a facade class to hide the framework's complexity
    // behind a simple interface. It's a trade-off between
    // functionality and simplicity.
    public class VideoConverter
    {
        public string Convert(string filename, string format)
        {
            // file = new VideoFile(filename)
            // sourceCodec = new CodecFactory.extract(file)
            // if (format == "mp4")
            //     destinationCodec = new MPEG4CompressionCodec()
            // else
            //     destinationCodec = new OggCompressionCodec()
            // buffer = BitrateReader.read(filename, sourceCodec)
            // result = BitrateReader.convert(buffer, destinationCodec)
            // result = (new AudioMixer()).fix(result)
            // return new File(result)
            return string.Empty;
        }

       
    }
}