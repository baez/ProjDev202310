using System;
using Models.Journal;
using ProjDev220310.Examples;

namespace ProjDev220310
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Press a key to terminate the application.");

            var program = new Program();
            program.TestJournal();
        }

        public void TestJournal()
        {
            // test preparation / initialization / setup
            var journal = new Journal("Daily Journal");
            journal.Add("line one in my journal");
            journal.Add("line two in my journal");
            journal.Add("end =====");

            var journalRepository = new JournalRepository();
            JournalManager journalManager = new JournalManager(journalRepository);

            // actual test
            var result = journalManager.AddJournal("filetest1", journal, isPrivate: true);


            // validating the result
            if(result == false)
            {
                Console.WriteLine("test failed");
            }
        }
    }
}
