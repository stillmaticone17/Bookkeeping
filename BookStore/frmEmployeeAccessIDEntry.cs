// Code behind for Access ID form
// Takes AccessID entered by user and searches employee list for match

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
    public partial class frmEmployeeAccessIDEntry : Form
    {
        private int attempts = 0;
        public int enteredID;
        public frmEmployeeAccessIDEntry()
        {
            InitializeComponent();
            Globals.bookStore.employeeList.initializeEntireList();
        }


        // Button handler for OK button
        // Validates AccessID length, then calls boolean findEmployee() from BookstoreClass
        // If false, displays error message and resetes form
        // If true, creates EmployeeObject and moves on to PIN form
        private void btnAccessIDOK_Click(object sender, EventArgs e)
        {
            bool found;
            attempts += 1;

            txtAccessID.Text = txtAccessID.Text.Trim();
            if (txtAccessID.Text.Length != Globals.bookStore.employeeList.employee.getValidAccessIDLength())
            {
                MessageBox.Show("Invalid length. Please enter a 5-digit integer.", "Error."
                    , MessageBoxButtons.OK, MessageBoxIcon.Stop);

                // Close program after 3 attempts 
                if (attempts >= Globals.bookStore.tryCountMax)
                {
                    MessageBox.Show("Incorrect Employee AccessID entered for the third time.", "Third time invalid.",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    return;
                }
                txtAccessID.Clear();
                txtAccessID.Focus();
                return;
            }
            try
            {
                enteredID = Convert.ToInt32(txtAccessID.Text);
            }
            catch
            {
                MessageBox.Show("Invalid AccessID. Please enter a 5-digit integer.", "Error."
                , MessageBoxButtons.OK, MessageBoxIcon.Stop);

                // After 3 attempts close program
                if (attempts >= Globals.bookStore.tryCountMax)
                {
                    MessageBox.Show("Incorrect Employee AccessID entered for the third time.", "Third time invalid.",
                        MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    this.Close();
                    return;
                }
                txtAccessID.Clear();
                txtAccessID.Focus();
                return;
            }

            Globals.bookStore.findEmployee(enteredID, out found);
            if (found == false)
            {
                MessageBox.Show("Employee not found. Please try again.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtAccessID.Clear();
                txtAccessID.Focus();
            }
            else // if employee found
            {
                MessageBox.Show("Employee found! \n\n Name: " + Globals.bookStore.employeeList.employee.getHiddenName());
                frmEmployeePINEntry frmPIN = new frmEmployeePINEntry(txtAccessID.Text);
                frmPIN.Show();
                this.Hide();
            }






        }

    }
}

