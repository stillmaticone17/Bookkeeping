// Employee Class
// creates our employee object
// verifies employee and corresponding PIN info

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
    public class EmployeeClass
    {
        // declaring variables to be used in all classes
        private int hiddenAccessID;
        private string hiddenName;
        private int hiddenPIN;
        private decimal hiddenAnnualPay;
        private DateTime hiddenLastDateAccessed;
        private int validAccessIDLength = 5;
        private int validPINLength = 4;

        // getters
        public int getHiddenAccessID()
        {
            return this.hiddenAccessID;
        }

        public string getHiddenName()
        {
            return this.hiddenName;
        }

        public int getHiddenPIN()
        {
            return this.hiddenPIN;
        }

        public decimal getHiddenAnnualPay()
        {
            return this.hiddenAnnualPay;
        }

        public DateTime getHiddenLastDateAccessed()
        {
            return this.hiddenLastDateAccessed;
        }

        public int getValidAccessIDLength()
        {
            return this.validAccessIDLength;
        }

        public int getValidPINLength()
        {
            return this.validPINLength;
        }

        public Boolean createEmployeeObject(string s) // IN: string from the Employee Text File
        {
            EmployeeClass thisEmployee = this;
            string[] employeeString = s.Split('*');


            int employeeStringSize = employeeString.GetLength(0);
            employeeString[0] = employeeString[0].Trim();

            // Convert AccessID to an integer of required length

            if (employeeString[0].Length != validAccessIDLength)
            {
                MessageBox.Show(employeeString[0] +
                    ": AccessID string is not exactly 5 characters. Employee File Corrupt. Execution Terminated.",
                    "AccessID in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            try
            {
                hiddenAccessID = Convert.ToInt32(employeeString[0]);
            }
            catch
            {
                MessageBox.Show(employeeString[0] +
                    " AccessID string is not a valid integer. Employee File Corrupt. Execution Terminated.",
                    "AccessID in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }


            // Name string to string (no conversion)
            // Checks for blank names

            hiddenName = employeeString[1].Trim();
            if (hiddenName == " " || hiddenName == "")
            {
                MessageBox.Show(hiddenName +
                    ": Name string is empty or Blank. Employee File Corrupt. Execution Terminated.",
                    "Name in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            employeeString[2] = employeeString[2].Trim();
            // Convert PIN to an integer of required length
            if (employeeString[2].Length != validPINLength)
            {
                MessageBox.Show(employeeString[2] +
                    ": PIN is not exactly 4 characters. Employee File Corrupt. Execution Terminated.",
                    "PIN in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            try
            {
                hiddenPIN = Convert.ToInt32(employeeString[2]);
            }
            catch
            {
                MessageBox.Show(employeeString[2] +
                    ": PIN is empty or blank. Employee File Corrupt. Execution Terminated.",
                    "PIN in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }


            // Convert annualPay to a positive decimal
            try
            {
                hiddenAnnualPay = Convert.ToDecimal(employeeString[3].Replace(",", "").Replace("$", ""));
            }
            catch
            {
                MessageBox.Show(employeeString[3] +
                    ": Annual Pay string is not a valid decimal. Employee File Corrupt. Execution Terminated.",
                    "Annual pay in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert Last Date of Access to a Date
            try
            {
                hiddenLastDateAccessed = DateTime.Parse(employeeString[4]);
            }
            catch
            {
                MessageBox.Show(employeeString[4] +
                    ": Date of Last Access is not a valid date. Employee File Corrupt. Execution Terminated.",
                    "Date Last Accessed in Employee File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            //if all data is valid
            return (true);
        }




        // checkEmployeeID()
        // Compares the Employee AccessID enetered by the user to the AccessID in the InternalList 
        // from the EmployeeListClass.
        // If no match, ask for re-rentry.
        // If there is a match we can then move on to the createEmployeeObject method
        public Boolean checkEmployeeID(int enteredID)
        {
            if (this.hiddenAccessID == enteredID)
            {
                return true;
            }
            return false;
        }



        // verifyPIN()
        //  Called from the EmployeeListClass
        //  takes pin entered by user and compares it to the index specified in the Internal List
        //  return: true if PIN matches, false if it does not
        public Boolean verifyPIN(int enteredPIN)
        {
            if (this.hiddenPIN == enteredPIN)
            {
                return true;
            }
            return false;
        }

        // updateEmployeeTransactionDate()
        //    updates hidden date variable with current time
        public void updateEmployeeTransactionDate()
        {
            this.hiddenLastDateAccessed = DateTime.Now;
        }


        // createStringToDisplay
        // Converts Employee attributes to a string suitable for display in a Message Box
        public string createStringToDisplay()
        {

            string display;
            display = "Employee Record:\n\n" + "AccessID: " + this.hiddenAccessID +
                "\nName: " + this.hiddenName + "\nPIN: " + this.hiddenPIN +
                String.Format("\nAnnual Pay: {0:C}", this.hiddenAnnualPay +
                "\nLast Date Accessed: " + this.hiddenLastDateAccessed + "\n\nEmployee Found!");
            return display;
        }


    }
}
