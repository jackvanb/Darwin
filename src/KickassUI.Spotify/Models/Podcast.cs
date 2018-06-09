using System;
using System.Collections.Generic;

namespace Darwin.Models
{
    public class Podcast : AudioFile
    {
		public List<AudioFile> Episodes { get; set; } = null;
    }
}
