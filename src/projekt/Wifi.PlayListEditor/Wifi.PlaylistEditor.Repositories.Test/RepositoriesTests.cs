using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Types;

//- moq
//-NUnit
//- NUnit3TestAdapter

namespace Wifi.PlaylistEditor.Repositories.Test
{
    public class RepositoriesTests
    { 
        private M3uRepository _fixture;

        [Test]
        public void Load()
        {
            // Arrange
            _fixture = new M3uRepository();

            // Act
            var path = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), @"C:\mycode\sw_developer_2021_damian\src\projekt\Wifi.PlayListEditor\playlist_files\Playlist_1.m3u");
            var result = _fixture.Load(path);

            // Assert
            Assert.That(result.Items.ToList().Count, Is.EqualTo(2));
            Assert.That(result.Items.ToList()[0].Path, Is.EqualTo("Title 1.mp3"));
            Assert.That(result.Items.ToList()[1].Path, Is.EqualTo("Testsong.mp3"));
        }

        [Test]
        public void Save()
        {
            // Arrange
            _fixture = new M3uRepository();

            Playlist playlist = new Playlist("Playlist_1", "Damian");

            Mock<IPlaylistItem> mockedItem = new Mock<IPlaylistItem>();
            mockedItem.Setup(x => x.Title).Returns("Super Song 1");
            mockedItem.Setup(x => x.Path).Returns(@"Title 1.mp3");
            mockedItem.Setup(x => x.Artist).Returns("Hans Jörg");

            Mock<IPlaylistItem> mockedItem2 = new Mock<IPlaylistItem>();
            mockedItem2.Setup(x => x.Title).Returns("Super Song 2");
            mockedItem2.Setup(x => x.Path).Returns(@"Testsong.mp3");
            mockedItem2.Setup(x => x.Artist).Returns("Hans Günther");

            playlist.Add(mockedItem.Object);
            playlist.Add(mockedItem2.Object);

            // Act
            var result = _fixture.Save(playlist, @"C:opt\playlist\");

            // Assert
            Assert.That(result, Is.True);
        }

    }
}
