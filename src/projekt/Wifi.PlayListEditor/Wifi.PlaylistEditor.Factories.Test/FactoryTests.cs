using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Factories.Test
{
    [TestFixture]
    public class FactoryTests
    {
        private PlaylistItemFactory _fixture;
        [SetUp]
        public void Init()
        {
            Mock<PlaylistItemFactory> mockedPlaylistItemFactory = new Mock<PlaylistItemFactory>();
            _fixture = new PlaylistItemFactory();
        }

        [Test]
        public void Create_get()
        {
            //Arange
            //var testCreate = new PlaylistItemFactory().Create;
            var erg = _fixture.Create(@"c:\opt\testfile.mp3");

            //Act
            //var result = _fixture.

            //Assert
            //Assert.That(erg, );
        }
        
    }
}
