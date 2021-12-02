﻿using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Types.Test
{
    [TestFixture]
    public class PlayListTests
    {
        private PlayList _fixture;
        [Test]
        public void DummyTest()
        {
            //Arrange
            int eineZahl = 5;

            //Act
            var result = eineZahl + 15;

            //Assert
            Assert.That(result, Is.EqualTo(20));
        }
    }
}
