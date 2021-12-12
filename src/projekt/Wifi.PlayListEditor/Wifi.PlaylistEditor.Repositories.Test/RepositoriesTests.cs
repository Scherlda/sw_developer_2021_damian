using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Factories;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Repositories.Test
{
    [TestFixture]
    public class M3uRepositoryTests
    {
        private M3uRepository _fixture;

        [SetUp]
        public void Init()
        {
            Mock<IPlaylistItemFactory> mockedPlaylistItemFactory = new Mock<IPlaylistItemFactory>();

            _fixture = new M3uRepository(mockedPlaylistItemFactory.Object);
        }


        [Test]
        public void Save()
        {
            //Arrange
            Mock<IPlaylist> mockedPlaylist = new Mock<IPlaylist>();
            Mock<IPlaylistItem> mockedItem1 = new Mock<IPlaylistItem>();
            Mock<IPlaylistItem> mockedItem2 = new Mock<IPlaylistItem>();

            mockedPlaylist.Setup(x => x.Name).Returns("Demo Playlist");
            mockedPlaylist.Setup(x => x.Author).Returns("Gandalf");
            mockedPlaylist.Setup(x => x.CreateDate).Returns(new DateTime(2021, 12, 8, 15, 15, 15));
            mockedPlaylist.Setup(x => x.Items).Returns(new IPlaylistItem[] { mockedItem1.Object, mockedItem2.Object });

            mockedItem1.Setup(x => x.Arthist).Returns("Lotte 1");
            mockedItem1.Setup(x => x.Title).Returns("Lotte Song 1");
            mockedItem1.Setup(x => x.Duration).Returns(TimeSpan.FromSeconds(25));
            mockedItem1.Setup(x => x.Path).Returns(@"c:\tmp\LotteSong1.mp3");

            mockedItem2.Setup(x => x.Arthist).Returns("Lotte 2");
            mockedItem2.Setup(x => x.Title).Returns("Lotte Song 2");
            mockedItem2.Setup(x => x.Duration).Returns(TimeSpan.FromSeconds(35));
            mockedItem2.Setup(x => x.Path).Returns(@"c:\tmp\LotteSong2.mp3");

            //Act
            var erg = _fixture.Save(mockedPlaylist.Object, "meineDemoPlaylist.m3u");

            //Assert
            Assert.That(erg, Is.True);
        }

        [Test]
        public void Save_FileNameEmpty()
        {
            //Arrange
            Mock<IPlaylist> mockedPlaylist = new Mock<IPlaylist>();
            Mock<IPlaylistItem> mockedItem1 = new Mock<IPlaylistItem>();
            Mock<IPlaylistItem> mockedItem2 = new Mock<IPlaylistItem>();

            mockedPlaylist.Setup(x => x.Name).Returns("Demo Playlist");
            mockedPlaylist.Setup(x => x.Author).Returns("Gandalf");
            mockedPlaylist.Setup(x => x.CreateDate).Returns(new DateTime(2021, 12, 8, 15, 15, 15));
            mockedPlaylist.Setup(x => x.Items).Returns(new IPlaylistItem[] { mockedItem1.Object, mockedItem2.Object });

            //Act
            var erg = _fixture.Save(mockedPlaylist.Object, "");

            //Assert
            Assert.That(erg, Is.False);
        }

        [Test]
        public void Save_FileNameNull()
        {
            //Arrange
            Mock<IPlaylist> mockedPlaylist = new Mock<IPlaylist>();
            Mock<IPlaylistItem> mockedItem1 = new Mock<IPlaylistItem>();
            Mock<IPlaylistItem> mockedItem2 = new Mock<IPlaylistItem>();

            mockedPlaylist.Setup(x => x.Name).Returns("Demo Playlist");
            mockedPlaylist.Setup(x => x.Author).Returns("Gandalf");
            mockedPlaylist.Setup(x => x.CreateDate).Returns(new DateTime(2021, 12, 8, 15, 15, 15));
            mockedPlaylist.Setup(x => x.Items).Returns(new IPlaylistItem[] { mockedItem1.Object, mockedItem2.Object });

            //Act
            var erg = _fixture.Save(mockedPlaylist.Object, null);

            //Assert
            Assert.That(erg, Is.False);
        }


        [Test]
        public void Load()
        {
            //Act
            var playlist = _fixture.Load("meineDemoPlaylist.m3u");

            //Assert
            Assert.That(playlist, Is.Not.Null);
        }

        [Test]
        public void Load_WrongFileExtension()
        {
            //Act
            var playlist = _fixture.Load("meineDemoPlaylist.pls");

            Assert.That(playlist, Is.Not.Null);
        }

        [Test]
        public void Load_NoFileExtension()
        {
            //Act            
            var playlist = _fixture.Load("meineDemoPlaylist");

            Assert.That(playlist, Is.Not.Null);
        }

        [Test]
        public void Load_FileNameEmpty()
        {
            //Act            
            var playlist = _fixture.Load("");

            Assert.That(playlist, Is.Null);
        }

        [Test]
        public void Load_FileNameNull()
        {
            //Act            
            var playlist = _fixture.Load(null);

            Assert.That(playlist, Is.Null);
        }
        //Meine Tests zu meiner alten M3u
        //[Test]
        //public void Load()
        //{
        //    // Arrange
        //    _fixture = new M3uRepository();

        //    // Act
        //    var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"C:\mycode\sw_developer_2021_damian\src\projekt\Wifi.PlayListEditor\playlist_files\Playlist_1.m3u");
        //    var result = _fixture.Load(path);

        //    // Assert
        //    Assert.That(result.Items.ToList().Count, Is.EqualTo(2));
        //    Assert.That(result.Items.ToList()[0].Path, Is.EqualTo("Title 1.mp3"));
        //    Assert.That(result.Items.ToList()[1].Path, Is.EqualTo("Testsong.mp3"));
        //}

        //[Test]
        //public void Save()
        //{
        //    // Arrange
        //    _fixture = new M3uRepository();

        //    Playlist playlist = new Playlist("Playlist_1", "Damian");

        //    Mock<IPlaylistItem> mockedItem = new Mock<IPlaylistItem>();
        //    mockedItem.Setup(x => x.Title).Returns("Super Song 1");
        //    mockedItem.Setup(x => x.Path).Returns(@"Title 1.mp3");
        //    mockedItem.Setup(x => x.Artist).Returns("Hans Jörg");

        //    Mock<IPlaylistItem> mockedItem2 = new Mock<IPlaylistItem>();
        //    mockedItem2.Setup(x => x.Title).Returns("Super Song 2");
        //    mockedItem2.Setup(x => x.Path).Returns(@"Testsong.mp3");
        //    mockedItem2.Setup(x => x.Artist).Returns("Hans Günther");

        //    playlist.Add(mockedItem.Object);
        //    playlist.Add(mockedItem2.Object);

        //    // Act
        //    var result = _fixture.Save(playlist, @"C:opt\playlist\");

        //    // Assert
        //    Assert.That(result, Is.True);
        //}

    }
}
