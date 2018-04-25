using System;
namespace Darwin.Models
{
    public class AudioFile
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public string AlbumImageUrl { get; set; }
        public string URL { get; set; } // Playable URL
        public int LengthInSeconds { get; set; }

    }
}
