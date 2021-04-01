using SpotifyManager.Classes.Models.SubObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyManager.Classes.Models.RootObjects
{
    public class Recommendation
    {
        public List<Track> tracks { get; set; }
        public List<Seed> seeds { get; set; }
    }
}
