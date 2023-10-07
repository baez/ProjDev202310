using System.Collections.Generic;
using System.IO;
using System.Xml.Linq;

namespace ProjDev220310.Examples
{
    public class Journal
    {

        private readonly List<JournalEntry> _entries = new List<JournalEntry>();
        private int _count = 0;
        private int _lastIndex = 0;

        public int Add(string text)
        {
            _entries.Add(new JournalEntry(text, _lastIndex++));
            return _count++;
        }

        public override string ToString()
        {
            return base.ToString();
        }

    }
}
