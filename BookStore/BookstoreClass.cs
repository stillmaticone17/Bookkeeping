// BookStore Class
// Main class of the program
// home to our book and employeeList objects
// home to our file writing and reading objects

// Brendan J Power
// tuf73760@temple.edu
// CIS 3309 - Section 001

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public class BookStoreClass
    {
        // Books and the EmployeeList and all the text files belong to the Bookstore
        public BookClass book = new BookClass();
        public EmployeeListClass employeeList = new EmployeeListClass();


        public int AccessIDLength
        {
            get
            {
                return hiddenAccessIDLength;
            }
        }

        public int ISBNLeftLength
        {
            get
            {
                return hiddenISBNLeftLength;
            }
        }

        public int ISBNRightLength
        {
            get
            {
                return hiddenISBNRightLength;
            }
        }

        public int tryCountMax
        {
            get
            {
                return hiddenTryCountMax;
            }
        }

        public int getHiddenPINLength
        {
            get
            {
                return hiddenPINLength;
            }
        }
        // The files the Bookstore owns
        private static string currentBookFilePath = "currentBookFile.txt";
        private static string updatedBookFilePath = "updatedBookFile.txt";
        private static string currentEmployeeFilePath = "currentEmployeeFile.txt";
        private static string updatedEmployeeFilePath = "updatedEmployeeFile.txt";

        public static currentFileClass currentBookFile = new currentFileClass(currentBookFilePath);
        public static updatedFileClass updatedBookFile = new updatedFileClass(updatedBookFilePath);
        public static currentFileClass currentEmployeeFile = new currentFileClass(currentEmployeeFilePath);
        public static updatedFileClass updatedEmployeeFile = new updatedFileClass(updatedEmployeeFilePath);

        // Bookstore parameters (named constants defined by the Bookstore)
        private int hiddenAccessIDLength = 5;  // Length of AccessNet ID
        private int hiddenISBNLeftLength = 3;  // Length of left part of ISBN
        private int hiddenISBNRightLength = 3; // Length of right part of ISBN
        private int hiddenPINLength = 4; // Length of PIN

        // Number of attempts BookStore allows a user before terminating an inventory
        private int hiddenTryCountMax = 3;


        // closes all external files
        public void closeFiles()
        {
            currentBookFile.closeFile();
            updatedBookFile.closeUpdatedFile();

        } // end closeFiles


        // After an employee's changes are processed, copies all remaining records
        // in the currentEmployeeFile to the updatedEmployeeFile
        public void copyRemainingRecords()
        {
            string nextRecord;
            Boolean isEndOfFile = true;
            int countProcessedRecord = 0;

            nextRecord = BookStoreClass.currentBookFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                countProcessedRecord++;
                writeOneRecord(nextRecord);
                nextRecord = BookStoreClass.currentBookFile.getNextRecord(ref isEndOfFile);
            }
        } // end copyRemainingRecords


        // Find Employee in Employee List
        // Returns a ref to the employee found and returns true or false
        // IN: employee ID to be found
        // OUT: flag indicating if Employee ID found in current Employee object
        public EmployeeClass findEmployee(int ID, out Boolean found)
        {
            EmployeeClass emp;  // reference to current Employee being checked for ID

            if ((emp = employeeList.findEmployeeInList(ID)) != null)
            {
                found = true;
            }
            else
            {
                found = false;
            }
            return emp;
        } // end findEmployee


        // rewindFiles rewinds all external files prior to closing
        public void rewindFiles()
        {
            currentEmployeeFile.rewindFile(); // rewinds currentEmployeeFile
            updatedEmployeeFile.rewindFile(); // rewinds updatedEmployeeFile
            currentBookFile.rewindFile();     // rewinds currentBookFile
            updatedBookFile.rewindFile();     // rewinds updatedBookFile

        } // end rewindFiles

        // checks for duplicate ISBN when attempting to add
        public Boolean checkForDuplicateRecordAdd(string enteredISBN)
        {
            string nextRecord;
            Boolean isEndOfFile = true;
            Boolean success;
            int countProcessedRecords = 0;
            nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                countProcessedRecords++;
                BookClass book = new BookClass();
                success = book.createBookObject(nextRecord);
                if (success != true)
                {
                    MessageBox.Show
                        ("Unable to create Book Object. Book not created.",
                         "Book creation failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                } // end if statement
                if (book.bookMatch(enteredISBN) == false)
                {
                    writeOneRecord(nextRecord);

                }
                else
                {
                    MessageBox.Show
                        ("Book with ISBN: " + enteredISBN + " already exists in our library.", "ISBN error",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return true;
                }

                nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);
            }
            return false;
        }

        // checks for duplicate ISBN when attempting to update
        public Boolean checkForDuplicateRecordUpdate(string enteredISBN)
        {
            string nextRecord;
            Boolean isEndOfFile = true;
            Boolean success;
            int countProcessedRecords = 0;
            nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                countProcessedRecords++;
                success = book.createBookObject(nextRecord);
                if (success != true)
                {
                    MessageBox.Show
                        ("Unable to create Book Object. Book not created.",
                         "Book creation failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                } // end if statement
                if (book.bookMatch(enteredISBN) == false)
                {
                    writeOneRecord(nextRecord);

                }
                else
                {
                    return true;
                }
                nextRecord = currentBookFile.getNextRecord(ref isEndOfFile);
            }
            return false;
        }

        // calls method 'writeEmployeeList' in the EmployeeListClass to write all Employee records
        // in the List back out to the updatedEmployeeFile
        public void writeEntireEmployeeList()
        {
            employeeList.writeEntireList();
        } // end writeEntireEmployeeList


        // Writes the contents of one Book record to the updatedBookFile
        public void writeOneRecord(string record)
        {
            updatedBookFile.putNextRecord(record);
        } // end writeOneRecord
    }
}
