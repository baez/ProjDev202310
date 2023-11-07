using Models.Journal;
using ProjDev220310.Examples;
using System;

namespace ProjDev220310
{
    public class JournalManager
    {
        private IJournalRepository journalRepository;

        public JournalManager(IJournalRepository journalRepository)
        {
            this.journalRepository = journalRepository;
        }

        public bool AddJournal(string name, Journal journal, bool isPrivate = true)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentNullException(nameof(name));
            }

            if (!this.journalRepository.Save(name, journal))
            {
                throw new Exception("Journal save failed");
            }

            return true;
        }
    }
}
