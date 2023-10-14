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
            Console.ReadKey();

            var program = new Program();
            program.TestJournal();
        }

        public void TestJournal()
        {
            var journal = new Journal("Daily Journal");
            journal.Add("line one");
            journal.Add("line two");

            var repository = new JournalRepository();
            repository.Save("file1", journal);
        }
    }
}
