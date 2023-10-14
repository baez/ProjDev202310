using System.IO;
using Models.Journal;

namespace ProjDev220310.Examples
{
    public class JournalRepository
    {
        public bool Save(string filename, Journal journal)
        {
            File.WriteAllText(filename, journal.ToString());
            return true;
        }
    }
}
