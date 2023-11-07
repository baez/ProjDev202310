using System.IO;
using Models.Journal;

namespace ProjDev220310.Examples
{
    public class JournalRepository : IJournalRepository
    {
        public bool Save(string filename, Journal journal)
        {
            if (!File.Exists(filename))
            {
                File.WriteAllText(filename, journal.ToString());
                return true;
            }

            return false;
        }
    }
}
