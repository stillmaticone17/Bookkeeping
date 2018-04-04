// EmployeeList Class
// Contains our employee list read from the current file
// contains methods and data needed to manipulate and work with this list

// Brendan J Power
// tuf73760@temple.edu
// CIS 3309 - Section 001
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public class EmployeeListClass
    {
        public List<EmployeeClass> InternalList = new List<EmployeeClass>();
        public EmployeeClass employee = new EmployeeClass();
        public int index = 0;

        // A method for reading records from the Employee File and Storing these records, one by one in the
        // Internal Employee List
        public Boolean initializeEntireList()
        {

            string nextRecord;
            Boolean isEndOfFile = true;
            Boolean success;
            int countProcessedRecords = 0;
            nextRecord = BookStoreClass.currentEmployeeFile.getNextRecord(ref isEndOfFile);
            while (!isEndOfFile)
            {
                countProcessedRecords++;
                EmployeeClass emp = new EmployeeClass();
                success = emp.createEmployeeObject(nextRecord);
                if (success != true)
                {
                    MessageBox.Show
                        ("Unable to create Employee Object. Employee list not created.",
                         "Employee List creation failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    return false;
                } // end if statement
                InternalList.Add(emp);
                nextRecord = BookStoreClass.currentEmployeeFile.getNextRecord(ref isEndOfFile);
            } // end while loop


            if (countProcessedRecords > 0)
                return true;
            else
                return false;
        } // end InitializeEntireList


        // getCount()
        //   gets the count of the number of books in the list
        public int getCount()
        {

            return InternalList.Count;

        } // end count 


        // updateEmpTransDate()
        //   takes current date of transaction as a parameter
        //   updates Employee object with date
        public void updateEmpTransDate()
        {

            employee.updateEmployeeTransactionDate();

        } // end updateEmpTransDate


        // writeEntireList()
        // writes contents of entire employee list to the updatedEmployeeFile
        public void writeEntireList()
        {
            foreach (EmployeeClass emp in InternalList)
            {
                string s = Convert.ToString(emp.getHiddenAccessID()) + " * " + Convert.ToString(emp.getHiddenPIN()) + " * " + emp.getHiddenName() +
                    " * " + Convert.ToString(emp.getHiddenAnnualPay()) + " * " + Convert.ToString(emp.getHiddenLastDateAccessed());
                
                BookStoreClass.updatedEmployeeFile.putNextRecord(s);
            } // end foreach loop
        } // end writeEntireList



        /// findEmployeeInList
        /// IN: Employee AccessID, entered by Employee on form1, to be checked
        /// 
        /// <param name="ID"></param>
        public EmployeeClass findEmployeeInList(int ID)
        {

            foreach (EmployeeClass emp in InternalList)
            {
                if (emp.checkEmployeeID(ID) == true)
                {
                    employee = InternalList[index];
                    return employee;
                }
                else
                {
                    index += 1;
                }



            }
            return null;
        } //end findEmployeeInList

        // verifyPIN
        // calls verifyPIN from Employee class to verify the PIN in the current Employee Object
        public Boolean verifyPIN(int pin)
        {
            if (employee.getHiddenPIN() == pin)
            {
                return true;
            }
            return false;

        } // end verifyPIN
    }
}