﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Wifi.PlaylistEditor.Types;

namespace Wifi.PlaylistEditor.Repositories
{
    internal class PlsRepository : IRepository
    {
        public string Extension => ".pls";

        public string Description => "PLS Playlist Format";

        public IPlaylist Load(string filePath)
        {
            throw new NotImplementedException();
        }

        public bool Save(IPlaylist playlist, string FilePath)
        {
            if (playlist == null || string.IsNullOrEmpty(FilePath))
            {
                return false;
            }

            filePath = FixFilePathExtension(FilePath);




            return true;
        }

        private object FixFilePathExtension(string filePath)
        {
            var fi = new FileInfo(filePath);
            if (fi.Extension != Extension)
            {
                if (!string.IsNullOrEmpty(fi.Extension))
                {
                    filePath = filePath.Replace(fi.Extension, Extension);
                }
                else
                {
                    filePath = filePath + Extension;
                }
            }

            return filePath;
        }
    }
}
