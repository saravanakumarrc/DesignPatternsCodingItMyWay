using AmazonPrimeBridgePattern.Streams.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AmazonPrimeBridgePattern.Streams
{
    public class HighDefinition : IStream
    {
        public FileStream GetStream(string movieName)
        {
            string movieFileName = Path.Combine("Movies", movieName, "HD.mp4");
            using (FileStream fs = File.OpenRead(movieFileName))
            {
                return fs;
            }
        }
    }
}
