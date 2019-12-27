using AmazonPrimeBridgePattern.Streams.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonPrimeBridgePattern.UserInterfaces
{
    public class TelevisionUserInterface : UserInterface
    {
        public TelevisionUserInterface(IStream stream) : base(stream) { }
        public long OK(string movieName)
        {
            return Play(movieName);
        }
    }
}
