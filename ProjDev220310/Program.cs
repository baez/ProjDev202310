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

            var journalManagerTest = new JournalManagerTest();

            journalManagerTest.AddJournal_WhenNewJournalFileDoesNotExist_ShouldSucceed();
            journalManagerTest.AddJournal_WhenNewJournalFileExists_ShouldNotCreateAndFail();
        }
    }
}
