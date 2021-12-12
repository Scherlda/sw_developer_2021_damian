using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Types.Test
{
    [TestFixture]
    public class PlaylistTests
    {
        private Playlist _fixture;


        [Test]
        public void Name_get()
        {
            //Arrange
            _fixture = new Playlist("NoName", "Gandalf");

            //Act
            var result = _fixture.Name;

            //Assert
            Assert.That(result, Is.EqualTo("NoName"));
        }

        [Test]
        public void Author_get()
        {
            //Arrange
            _fixture = new Playlist("NoName", "Gandalf");

            //Act
            var result = _fixture.Author;

            //Assert
            Assert.That(result, Is.EqualTo("Gandalf"));
        }

        [Test]
        public void CreateDate_get()
        {
            //Arrange
            var testDateTime = new DateTime(2000, 4, 10, 8, 9, 10);
            _fixture = new Playlist("NoName", "Gandalf", testDateTime);

            //Act
            var result = _fixture.CreateDate;

            //Assert
            Assert.That(result, Is.EqualTo(testDateTime));
        }

        [Test]
        public void Duration_get()
        {
            //Arrange
            _fixture = new Playlist("NoName", "Gandalf");
            
            //Das mockedItem erstellt Dummy Items, somit muss kein Playlist Item initialisiert werden
            Mock<IPlaylistItem> mockedItem = new Mock<IPlaylistItem>();
            mockedItem.Setup(x => x.Duration).Returns(TimeSpan.FromSeconds(10));

            Mock<IPlaylistItem> mockedItem2 = new Mock<IPlaylistItem>();
            mockedItem2.Setup(x => x.Duration).Returns(TimeSpan.FromSeconds(5));

            _fixture.Add(mockedItem.Object);
            _fixture.Add(mockedItem2.Object);

            //Act
            var result = _fixture.Duration;

            //Assert
            Assert.That(result, Is.EqualTo(TimeSpan.FromSeconds(15)));
        }

        [Test]
        public void Add()
        {
            //Arrange
            _fixture = new Playlist("NoName", "Gandalf");

            //Das mockedItem erstellt Dummy Items, somit muss kein Playlist Item initialisiert werden
            Mock<IPlaylistItem> mockedItem = new Mock<IPlaylistItem>();
           // mockedItem.Setup(x => x.Duration).Returns(TimeSpan.FromSeconds(12));

            Mock<IPlaylistItem> mockedItem2 = new Mock<IPlaylistItem>();
           // mockedItem2.Setup(x => x.Duration).Returns(TimeSpan.FromSeconds(7));

            _fixture.Add(mockedItem.Object);
            _fixture.Add(mockedItem2.Object);

            //Act
            var result = _fixture.Items;

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(2));
        }

        [Test]
        public void Add_NullItem()
        {
            //Arrange
            _fixture = new Playlist("NoName", "Gandalf");

            _fixture.Add(null);

            //Act
            var result = _fixture.Items;

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }

        [Test]
        public void Add_SameObjekt()
        {
            //Arrange
            _fixture = new Playlist("NoName", "Gandalf");

            Mock<IPlaylistItem> mockedItem = new Mock<IPlaylistItem>();
            mockedItem.Setup(x => x.Title).Returns("Super Song1");

            Mock<IPlaylistItem> mockedItem2 = new Mock<IPlaylistItem>();
            mockedItem2.Setup(x => x.Title).Returns("Super Song2");

            _fixture.Add(mockedItem.Object);
            _fixture.Add(mockedItem.Object);

            //Act
            var result = _fixture.Items;

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(2));
        }

        [Test]
        public void Remove()
        {
            //Arrange
            _fixture = new Playlist("NoName", "Gandalf");

            Mock<IPlaylistItem> mockedItem = new Mock<IPlaylistItem>();
            mockedItem.Setup(x => x.Title).Returns("Super Song1");

            Mock<IPlaylistItem> mockedItem2 = new Mock<IPlaylistItem>();
            mockedItem2.Setup(x => x.Title).Returns("Super Song2");

            _fixture.Add(mockedItem.Object);
            _fixture.Add(mockedItem.Object);

            //Act
            _fixture.Remove(mockedItem.Object);
            var result = _fixture.Items;

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(1));
        }

        [Test]
        public void Clear()
        {
            //Arrange
            _fixture = new Playlist("NoName", "Gandalf");

            Mock<IPlaylistItem> mockedItem = new Mock<IPlaylistItem>();
            mockedItem.Setup(x => x.Duration).Returns(TimeSpan.FromSeconds(12));

            Mock<IPlaylistItem> mockedItem2 = new Mock<IPlaylistItem>();
            mockedItem2.Setup(x => x.Duration).Returns(TimeSpan.FromSeconds(7));

            _fixture.Add(mockedItem.Object);
            _fixture.Add(mockedItem2.Object);

            //Act
            _fixture.Clear();
            var result = _fixture.Items;

            //Assert
            Assert.That(result, Is.Not.Null);
            Assert.That(result.Count(), Is.EqualTo(0));
        }
    }
}
