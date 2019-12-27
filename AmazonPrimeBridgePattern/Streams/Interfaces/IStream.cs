using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AmazonPrimeBridgePattern.Streams.Interfaces
{
    public interface IStream
    {
        FileStream GetStream(string movieName);
    }
}
