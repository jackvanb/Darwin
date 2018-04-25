using System;

namespace Darwin.Controls
{
    public class TileTappedEventArgs : EventArgs
    {
        private Type _page;
        public Type Page
        {
            get { return _page; }
        }

        public TileTappedEventArgs(Type page)
        {
            _page = page;
        }
    }
}
