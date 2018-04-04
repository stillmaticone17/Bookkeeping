// Updated File Class
// Data and methods related to a updated input text file processed by the project

// Brendan J Power
// tuf73760@temple.edu
// CIS 3309 - Section 001
using System;

using System.Windows.Forms;

namespace BookStore
{
    public class updatedFileClass
    {
        private string updatedFilePath;
        private System.IO.StreamWriter updatedFileSW; // Reference variable of type SW

        private int recordWrittenCount;

        // Constructor with file path input
        // creates instance of StreamWriter class and stores reference

        public updatedFileClass
            (string filePath)
        {
            recordWrittenCount = 0;
            updatedFilePath = filePath;
            try
            {
                updatedFileSW = new System.IO.StreamWriter(updatedFilePath);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Cannot open file" + updatedFilePath + "Terminate program.",
                    "Input File Connection Error.", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } // end try/catch
        } // end updatedFileClass Constructor



        // Write a record to the updated file
        public void putNextRecord(string record)
        {
            try
            {
                updatedFileSW.WriteLine(record);
            }
            catch (Exception ex)
            {
                MessageBox.Show("IO error in file write. Terminate program.",
                                "File Write Error", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            // end try/catch
            recordWrittenCount += 1;
        } // end putNextRecord



        // Get value of number of records written
        public int getRecordsWrittenCount()
        {
            return recordWrittenCount;
        } // end getRecordsWrittenCount



        // Close the output (updated) file
        public void closeUpdatedFile()
        {
        //    updatedFileSW.Flush(); 
            updatedFileSW.Close();
        } // end closeFile



        // Rewind the output file
        public void rewindFile()
        {
            recordWrittenCount = 0;
            closeUpdatedFile();
            updatedFileSW = new System.IO.StreamWriter(updatedFilePath);
            updatedFileSW.BaseStream.Seek(0, System.IO.SeekOrigin.Begin);
        } // end rewindFile

    } // end updatedFileClass

} // end namespace

