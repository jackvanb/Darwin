using System;
using System.Collections.Generic;

namespace Darwin.Models
{
    public class Podcast : AudioFile
    {
        public List<Episode> Episodes { get; set; }
    }
}
