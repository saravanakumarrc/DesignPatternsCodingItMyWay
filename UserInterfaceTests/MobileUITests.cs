using AmazonPrimeBridgePattern.Streams;
using AmazonPrimeBridgePattern.UserInterfaces;
using NUnit.Framework;

namespace UserInterfaceTests
{
    public class MobileUITests
    {
        MobileUserInterface userInterfaces;
        string movieName;

        [SetUp]
        public void Setup()
        {
            userInterfaces = new MobileUserInterface(new HighDefinition());
            movieName = "3idiots";
        }

        [Test]
        public void StreamStarted()
        {
            Assert.IsTrue(userInterfaces.Select(movieName) > 0, "Stream Started from Mobile UI", movieName);
        }
    }
}