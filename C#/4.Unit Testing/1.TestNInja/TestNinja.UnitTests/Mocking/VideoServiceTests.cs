using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Moq;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
    [TestFixture]
    class VideoServiceTests
    {
        private VideoService _service;
        private Mock<IFileReader> _fileReader;

        //Dependency injection by method Parameters.
        [Test]
        [Ignore("ignorowane")]
        public void ReadVideoTitle_EmptyFile_ReturnErrorMessage()
        {
            var service = new VideoService();
            var result = service.ReadVideoTitle(new FakeFileReader());

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }


        //dependency injection by properties
        [Test]
        [Ignore("ignorowane")]
        public void ReadVideoTitle_EmptyFile_ReturnErrorMessageVer2()
        {
            var service = new VideoService();
            service.FileReader = new FakeFileReader();

            var result = service.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }


        [SetUp]
        public void Setup()
        {
            _fileReader = new Mock<IFileReader>();
            _service = new VideoService(_fileReader.Object);
        }

        //dependency injection via Constructor
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnErrorMessageVer3()
        {
            
            _fileReader.Setup(fr => fr.Read("video.txt")).Returns("");
            
            var result = _service.ReadVideoTitle();

            Assert.That(result, Does.Contain("error").IgnoreCase);
        }
    }


    
    
        

    

}
