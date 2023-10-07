namespace ProjDev220310.Examples
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
    }
}
