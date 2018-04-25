using System;
namespace Darwin.Models
{
    public class Tile
    {
        public string IconImage { get; set; }

        public string BackgroundImage { get; set; }

        public string Text { get; set; }

        public int Column { get; set; }

        public int Row { get; set; }

        public Type NavigateType { get; set; }
    }
}
