using System.Collections.Generic;
using System.Text;

namespace Models.Journal
{
    public class Journal
    {
        private readonly string _title;
        private readonly List<JournalEntry> _entries = new List<JournalEntry>();
        private int _count = 0;
        private int _lastIndex = 0;

        public Journal(string title) 
        { 
            _title = title;
        }

        public int Add(string text)
        {
            _entries.Add(new JournalEntry(text, _lastIndex++));
            return _count++;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine(this._title);

            foreach(var entry in _entries)
            {
                builder.AppendLine(entry.ToString());
            }
                
            return builder.ToString();
        }
    }
}
