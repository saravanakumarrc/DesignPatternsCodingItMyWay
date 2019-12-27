using AmazonPrimeBridgePattern.Streams.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AmazonPrimeBridgePattern.UserInterfaces
{
    public abstract class UserInterface
    {
        protected IStream stream;
        public UserInterface(IStream stream)
        {
            this.stream = stream;
        }
        protected long Play(string movieName)
        {
            using (FileStream fs = stream.GetStream(movieName))
            {
                return fs.Length;
            }
        }
    }
}
