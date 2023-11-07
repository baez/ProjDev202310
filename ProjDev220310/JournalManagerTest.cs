namespace ProjDev220310
{
    using System;
    using System.IO;
    using Models.Journal;
    using ProjDev220310.Examples;

    public class JournalManagerTest
    {
        //          What       Pre-condition         Post-condition
        public void AddJournal_WhenNewJournalFileDoesNotExist_ShouldSucceed()
        {
            // Pre-condition - Arrange - test preparation / initialization / setup
            var testFileName = "filetest1";
            if (File.Exists(testFileName))
            {
                File.Delete(testFileName);
            }

            // Actual test - Act
            var result = this.CreateSaveJournal(testFileName);

            // Post-condition - Assert - validating the result
            if (result == false)
            {
                Console.WriteLine("************* test failed *************");
            }
        }

        public void AddJournal_WhenNewJournalFileExists_ShouldNotCreateAndFail()
        {
            // Pre-condition - Arrange - test preparation / initialization / setup
            var testFileName = "filetest2";
            if (!File.Exists(testFileName))
            {
                _ = this.CreateSaveJournal(testFileName);
            }

            // Actual test - Act
            var result = this.CreateSaveJournal(testFileName);

            // Post-condition - Assert - validating the result
            if (result == true)
            {
                Console.WriteLine("***** Test failed *****");
            }
        }

        private bool CreateSaveJournal(string fileName)
        {
            var journal1 = new Journal("Daily Journal");
            journal1.Add("line one in my journal");
            journal1.Add("line two in my journal");
            journal1.Add("end =====");

            var journalRepository1 = new JournalRepository();
            JournalManager journalManager1 = new JournalManager(journalRepository1);

            return journalManager1.AddJournal(fileName, journal1, isPrivate: true);
        }
    }
}
