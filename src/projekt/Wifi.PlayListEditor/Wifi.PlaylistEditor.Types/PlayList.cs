﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wifi.PlaylistEditor.Types
{
    public class PlayList : IPlaylist
    {
        private string _name;
        private string _autor;        
        private DateTime _createDate;
        private List<IPlayListItem> _items;

        public PlayList(string name, string autor)
            : this(name, autor, DateTime.Now)
        {
        }

        public PlayList(string name, string autor, DateTime createDate)
        {
            _name = name;
            _autor = autor;
            _createDate = createDate;

            _items = new List<IPlayListItem>();
        }

        public string Name
        {
            get { return _name; }
        }
        public string Autor
        {
            get { return _autor;}
        }
        public DateTime CreateDate
        {
            get { return _createDate; }
        }

        public TimeSpan Duration
        {
            get
            {
                var duration = TimeSpan.Zero;
                foreach (var item in _items)
                {
                    duration.Add(item.Duration);
                }

                return duration;
            }
        }

        public IEnumerable<IPlayListItem> Items
        {
            get { return _items; }
        }

        public void Add(IPlayListItem newItem)
        {
            _items.Add(newItem);
        }

        public void Clear()
        {
            _items.Clear();
        }

        public void Remove(IPlayListItem itemToRemove)
        {
            _items.Remove(itemToRemove);
        }
    }
}