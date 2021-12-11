using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wifi.PlaylistEditor.UI
{
    internal class NewPlaylistCreator : INewPlaylistCreator
    {
        private string _title;
        private string _author;
        private DateTime _createAt;


        public NewPlaylistCreator(string title, string author)
        {
            _title = title;
            _author = author;
            _createAt = DateTime.Now;
        }



        public string Title
        {
            get { return _title; }
        }

        public string Author => _author;

        public DateTime CreateAt => _createAt;

        public DialogResult OpenDialog()
        {
            throw new NotImplementedException();
        }
    }
}
