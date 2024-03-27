using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseSQLMusicApp
{
    internal class Album
    {
        public int ID { get; set; }
        public String AlbumName { get; set; }
        public String ArtistName { get; set; }
        public int Year { get; set; }
        public String ImageUrl { get; set; }
        public String Description { get; set; }

        //Later make a List<Track>
    }
}
