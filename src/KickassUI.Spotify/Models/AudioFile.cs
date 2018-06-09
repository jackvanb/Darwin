using System;
namespace Darwin.Models
{
    public class AudioFile
    {
        public string Author { get; set; }
        public string Title { get; set; }
        public string Image { get; set; }
		public string URL { get; set; } = "url"; // Playable URL
		public int LengthInSeconds { get; set; } = 3600;

    }
}
