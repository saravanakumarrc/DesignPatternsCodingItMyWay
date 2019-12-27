using AmazonPrimeBridgePattern.Streams.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AmazonPrimeBridgePattern.Streams
{
    public class UltraHighDefinition : IStream
    {
        public FileStream GetStream(string movieName)
        {
            string movieFileName = Path.Combine("Movies", movieName,"UHD.mkv");
            using (FileStream fs = File.OpenRead(movieFileName))
            {
                return fs;
            }
        }
    }
}
