// Code behind for Employee PIN form
// sends entered PIN to Employee class for authentication

// Brendan J Power
// tuf73760@temple.edu
// CIS 3309 - Section 001
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookStore
{
    public partial class frmEmployeePINEntry : Form
    {
        int attempts = 0;
        public frmEmployeePINEntry(string enteredID)
        {
            InitializeComponent();
            txtEmpNumPIN.Text = enteredID;

        }

        private void btnPINOK_Click(object sender, EventArgs e)
        {
            int enteredPIN;

            attempts += 1;

            txtEnterPIN.Text = txtEnterPIN.Text.Trim();
            if (txtEnterPIN.Text.Length != Globals.bookStore.getHiddenPINLength)
            {

                MessageBox.Show("Invalid length. Please enter a 4-digit integer.", "Error.",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (attempts == Globals.bookStore.tryCountMax)
                {
                    MessageBox.Show("Incorrect Employee PIN entered for the third time.", "Third time invalid.",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    return;
                }
                txtEnterPIN.Clear();
                txtEnterPIN.Focus();
                return;
            }
            try
            {
                enteredPIN = Convert.ToInt32(txtEnterPIN.Text);
            }
            catch
            {
                MessageBox.Show("Invalid PIN. Please enter a 4-digit integer.", "Error."
                , MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (attempts >= Globals.bookStore.tryCountMax)
                {
                    MessageBox.Show("Incorrect Employee PIN entered for the third time.", "Third time invalid.",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    return;
                }
                txtEnterPIN.Clear();
                txtEnterPIN.Focus();
                return;
            }
            Boolean foundPIN = Globals.bookStore.employeeList.verifyPIN(enteredPIN);
            if (foundPIN == false)
            {
                MessageBox.Show(" PIN entered for employee number: " + txtEmpNumPIN.Text + "is incorrect. Please try again.", "PIN error.",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                if (attempts >= Globals.bookStore.tryCountMax)
                {
                    MessageBox.Show("Incorrect Employee PIN entered for the third time.", "Third time invalid.",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    return;
                }
                txtEnterPIN.Clear();
                txtEnterPIN.Focus();
                return;
            }
            else // if PIN is found to be correct
            {
                Globals.bookStore.employeeList.updateEmpTransDate();
                Globals.bookStore.employeeList.writeEntireList();

                BookStoreClass.currentEmployeeFile.closeFile();
                BookStoreClass.updatedEmployeeFile.closeUpdatedFile();
                MessageBox.Show("PIN correct! \n\n Employee record: \n\n Name: " + Globals.bookStore.employeeList.employee.getHiddenName() +
                    "\nAccess ID: " + Globals.bookStore.employeeList.employee.getHiddenAccessID() + "\nPIN: " + Globals.bookStore.employeeList.employee.getHiddenPIN() +
                    "\nAnnual Salary: " + Globals.bookStore.employeeList.employee.getHiddenAnnualPay() + "\nLast Date Accessed: " + Globals.bookStore.employeeList.employee.getHiddenLastDateAccessed());
                frmTransactionSelect frmTrans = new frmTransactionSelect();
                frmTrans.Show();
                this.Hide();
            }


        }

        private void frmEmployeePINEntry_Load(object sender, EventArgs e)
        {
            // sets accessID text-box (read-only)
            txtEnterPIN.Clear();
            txtEnterPIN.Focus();
        }
    }
}
