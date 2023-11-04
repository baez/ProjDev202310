using Models.Journal;
using System.Xml.Linq;

namespace ProjDev220310.Examples
{
    public interface IJournalRepository
    {
        bool Save(string journalName, Journal journal);
    }
}