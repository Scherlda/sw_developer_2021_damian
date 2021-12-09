﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi.PlaylistEditor.UI
{
    public interface INewPlaylistCreator
    {
        string Title { get; }
        string Autor { get; }
        DateTime CreateAt { get; }
        DialogResult OpenDialog();
    }
}
