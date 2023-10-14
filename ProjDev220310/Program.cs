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
            var journal = new Journal("Daily Journal");
            journal.Add("line one in my journal");
            journal.Add("line two in my journal");
            journal.Add("end =====");

            var repository = new JournalRepository();
            repository.Save("file1", journal);
        }
    }
}
