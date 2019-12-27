using AmazonPrimeBridgePattern.Streams.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace AmazonPrimeBridgePattern.UserInterfaces
{
    public class MobileUserInterface : UserInterface
    {
        public MobileUserInterface(IStream stream) : base(stream) { }
        public long Select(string movieName)
        {
            return Play(movieName);
        }
    }
}
