using AmazonPrimeBridgePattern.Streams;
using AmazonPrimeBridgePattern.UserInterfaces;
using NUnit.Framework;

namespace UserInterfaceTests
{
    public class TelevisionMobileUITests
    {
        TelevisionUserInterface userInterfaces;
        string movieName;

        [SetUp]
        public void Setup()
        {
            userInterfaces = new TelevisionUserInterface(new UltraHighDefinition());
            movieName = "3idiots";
        }

        [Test]
        public void StreamStarted()
        {
            Assert.IsTrue(userInterfaces.OK(movieName) > 0, "Stream Started from Television UI", movieName);
        }
    }
}