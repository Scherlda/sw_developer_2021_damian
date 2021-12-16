﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wifi.PlaylistEditor.Factories;
using Wifi.PlaylistEditor.Repositories;
using Wifi.PlaylistEditor.Types;
using Wifi.PlaylistEditor.UI;

namespace Wifi.PlaylistEditor.Factories
{
    public class RepositoryFactory : IRepositoryFactory
    {
        private readonly IPlaylistItemFactory _playlistItemFactory;

        public RepositoryFactory(IPlaylistItemFactory playlistItemFactory)
        {
            _playlistItemFactory = playlistItemFactory;
        }
        public IRepository Create(string fileName)
        {
            IRepository repository = null;

            if (string.IsNullOrEmpty(fileName))
            {
                return null;
            }

            var extension = Path.GetExtension(fileName);
            switch (extension)
            {
                case ".m3u":
                    repository = new M3uRepository(_playlistItemFactory);
                    break;

                case ".json":
                    //repository = new JsonReposotory(_playlistItemFactory);
                    break;
            }

            return repository;
        }
    }
}
