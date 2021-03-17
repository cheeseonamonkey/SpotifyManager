using SpotifyManager.Classes.Models.SubObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyManager.Classes.Models.RootObjects
{
    public class RecentlyPlayed
    {
        public List<Item> items { get; set; }
        public string next { get; set; }
        public Cursors cursors { get; set; }
        public int limit { get; set; }
        public string href { get; set; }
    }
}
