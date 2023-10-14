namespace Models.Journal
{
    public class JournalEntry
    {
        public string Entry { get; }
        public int EntryIndex { get; }

        public JournalEntry(string entry, int entryIndex)
        {
            Entry = entry;
            EntryIndex = entryIndex;
        }

        public override string ToString() 
        {
            return $"{this.EntryIndex} - {Entry}";
        }
    }
}
