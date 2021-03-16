using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpotifyManager.Classes.Models.Objects;
using SpotifyManager.Classes.Models.SubObjects;

namespace SpotifyManager.Classes.Models.RootObjects
{
    public class PlaylistTracks
    {
        public string href { get; set; }
        public List<Item> items { get; set; }
        public int limit { get; set; }
        public object next { get; set; }
        public int offset { get; set; }
        public object previous { get; set; }
        public int total { get; set; }
    }
}
