using AmazonPrimeBridgePattern.Streams;
using AmazonPrimeBridgePattern.UserInterfaces;
using System;

namespace AmazonPrimeBridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logging in.");

            MobileUserInterface mobileUser = new MobileUserInterface(new HighDefinition());
            mobileUser.Select("3idiots");

            TelevisionUserInterface televisionUser = new TelevisionUserInterface(new UltraHighDefinition());
            televisionUser.OK("Dangal");
        }
    }
}
