namespace Models.Journal
{
    public class JournalEntry
    {
        public string Entry { get; }
        public int EntryIndex { get; }

        public JournalEntry(string entry, int entryIndex)
        {
            this.Entry = entry;
            this.EntryIndex = entryIndex;
        }

        public override string ToString() 
        {
            return $"{this.EntryIndex} - {this.Entry}";
        }
    }
}
