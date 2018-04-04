// Code behind Transaction Select form
// Controls Add, Update and Delete buttons
// Verifies form data
// Performs corresponding transaction, provided requirements are met

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
    public partial class frmTransactionSelect : Form
    {
        public frmTransactionSelect()
        {
            InitializeComponent();
            resetTransactionForm();
            txtLeftISBN.Focus();
        }

        string enteredISBN;

        // Button handler for btnOKISBN
        //      Validates ISBN is int of proper length.

        private void btnOkISBN_Click(object sender, EventArgs e)
        {
            if (txtLeftISBN.Text.Length != Globals.bookStore.ISBNLeftLength || txtRightISBN.Text.Length != Globals.bookStore.ISBNRightLength)
            {
                MessageBox.Show("ISBN not proper format. Please use XXX-XXX format.", "Invalid ISBN Format.",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLeftISBN.Clear();
                txtRightISBN.Clear();
                txtLeftISBN.Focus();
            }
            try
            {
                Convert.ToInt32(txtLeftISBN.Text);
                Convert.ToInt32(txtRightISBN.Text);
            }
            catch
            {
                MessageBox.Show("ISBN not proper format. Please use XXX-XXX format.", "Invalid ISBN Format.",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLeftISBN.Clear();
                txtRightISBN.Clear();
                txtLeftISBN.Focus();
            }

            // setting ISBN variable to be checked against text file
            enteredISBN = txtLeftISBN.Text + "-" + txtRightISBN.Text;

            // display and enable 3 transaction buttons
            btnAddBook.Visible = true;
            btnAddBook.Enabled = true;
            btnUpdateBook.Visible = true;
            btnUpdateBook.Enabled = true;
            btnDeleteBook.Visible = true;
            btnDeleteBook.Enabled = true;
        }

        // click event for first add button
        //     verifies ISBN does not already exist in current file
        //     if it does NOT, we can move forward with add
        //     if it DOES, we inform the user and reset the transaction form
        private void btnAddBook_Click(object sender, EventArgs e)
        {

            if (Globals.bookStore.checkForDuplicateRecordAdd(enteredISBN) == true)
            {
                MessageBox.Show(" A book with this ISBN already exists in our library.", "Duplicate ISBN.",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLeftISBN.Clear();
                txtRightISBN.Clear();
                txtLeftISBN.Focus();
                btnAddBook.Visible = false;
                btnAddBook.Enabled = false;
                btnUpdateBook.Visible = false;
                btnUpdateBook.Enabled = false;
                btnDeleteBook.Visible = false;
                btnDeleteBook.Enabled = false;
                BookStoreClass.currentBookFile.rewindFile();
            }
            else // if no duplicate found
            {
                // Displays yes/no message box giving user chance to confirm add 

                DialogResult addSure = MessageBox.Show(" Are you sure you wish to add book with ISBN: " + enteredISBN,
                    "Add Book", MessageBoxButtons.YesNo);
                if (addSure == DialogResult.Yes)   // if yes, continue with steps
                {
                    // display book attribute labels
                    lblEnterBookData.Visible = true;
                    lblReadISBN.Visible = true;
                    lblAuthor.Visible = true;
                    lblTitle.Visible = true;
                    lblPrice.Visible = true;
                    lblQuantity.Visible = true;
                    lblLastDateAccessed.Visible = true;

                    // color and disable add button
                    btnAddBook.BackColor = Color.LightYellow;
                    btnAddBook.Enabled = false;
                    btnAddDone.Enabled = true;
                    btnAddDone.Visible = true;
                    btnUpdateDone.Visible = false;
                    btnDeleteDone.Visible = false;

                    // display and enable book attribute textboxes
                    // display entered ISBN in Read-Only ISBN textbox
                    txtReadLeftISBN.Visible = true;
                    txtReadLeftISBN.Text = txtLeftISBN.Text;
                    txtReadRightISBN.Visible = true;
                    txtReadRightISBN.Text = txtRightISBN.Text;
                    txtAuthor.Visible = true;
                    txtAuthor.Enabled = true;
                    txtTitle.Visible = true;
                    txtTitle.Enabled = true;
                    txtPrice.Visible = true;
                    txtPrice.Enabled = true;
                    txtQuantity.Visible = true;
                    txtQuantity.Enabled = true;
                    txtLastDateAccessed.Visible = true;
                    txtLastDateAccessed.Enabled = true;
                }
                else // if user selects no
                {
                    resetTransactionForm();
                    Globals.bookStore.rewindFiles();
                }


            }

        }

        // click handler for first Update Button
        //    verifies ISBN exists in current file
        //    if it does, we can move forward
        //    if NOT, we reset the form
        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            if (Globals.bookStore.checkForDuplicateRecordUpdate(enteredISBN) == false)
            {
                MessageBox.Show(" No book with this ISBN exists in our library. Reenter ISBN.", "Invalid ISBN.",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLeftISBN.Clear();
                txtRightISBN.Clear();
                txtLeftISBN.Focus();
                btnAddBook.Visible = false;
                btnAddBook.Enabled = false;
                btnUpdateBook.Visible = false;
                btnUpdateBook.Enabled = false;
                btnDeleteBook.Visible = false;
                btnDeleteBook.Enabled = false;
                BookStoreClass.currentBookFile.rewindFile();

            }
            else  // if duplicate found
            {
                // Displays yes/no message box giving user chance to confirm update 

                DialogResult updateSure = MessageBox.Show(" Are you sure you wish to update book with ISBN: " + enteredISBN,
                    "Update Book", MessageBoxButtons.YesNo);
                if (updateSure == DialogResult.Yes)   // if yes, continue with steps
                {

                    // display book attribute labels
                    lblEnterBookData.Visible = true;
                    lblReadISBN.Visible = true;
                    lblAuthor.Visible = true;
                    lblTitle.Visible = true;
                    lblPrice.Visible = true;
                    lblQuantity.Visible = true;
                    lblLastDateAccessed.Visible = true;

                    // color and disable add button
                    btnUpdateBook.BackColor = Color.LightYellow;
                    btnUpdateBook.Enabled = false;
                    btnUpdateDone.Visible = true;
                    btnUpdateDone.Enabled = true;
                    btnAddDone.Visible = false;
                    btnDeleteDone.Visible = false;

                    // display and enable book attribute textboxes
                    // display entered ISBN in Read-Only ISBN textbox
                    txtReadLeftISBN.Visible = true;
                    txtReadLeftISBN.Text = txtLeftISBN.Text;
                    txtReadRightISBN.Visible = true;
                    txtReadRightISBN.Text = txtRightISBN.Text;
                    txtAuthor.Visible = true;
                    txtAuthor.Enabled = true;
                    txtTitle.Visible = true;
                    txtTitle.Enabled = true;
                    txtPrice.Visible = true;
                    txtPrice.Enabled = true;
                    txtQuantity.Visible = true;
                    txtQuantity.Enabled = true;
                    txtLastDateAccessed.Visible = true;


                    // set textbox attributes with attributes read from current book object
                    txtAuthor.Text = Globals.bookStore.book.getHiddenAuthor();
                    txtTitle.Text = Globals.bookStore.book.getHiddenTitle();
                    txtPrice.Text = Globals.bookStore.book.getHiddenPrice();
                    txtQuantity.Text = Globals.bookStore.book.getHiddenQuantity();
                    txtLastDateAccessed.Text = Globals.bookStore.book.gethiddenDateLastTransaction();

                }
                else // if user selects no
                {
                    resetTransactionForm();
                    Globals.bookStore.rewindFiles();
                }
            }
        }

        // Click handler for first Delete book button
        //   verifies book exists with ISBN entered by user
        //   if it exists, we can move forward
        //   if NOT, we reset the transaction form
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (Globals.bookStore.checkForDuplicateRecordUpdate(enteredISBN) == false)
            {
                MessageBox.Show(" No book with this ISBN exists in our library. Reenter ISBN.", "Invalid ISBN.",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLeftISBN.Clear();
                txtRightISBN.Clear();
                txtLeftISBN.Focus();
                btnAddBook.Visible = false;
                btnAddBook.Enabled = false;
                btnUpdateBook.Visible = false;
                btnUpdateBook.Enabled = false;
                btnDeleteBook.Visible = false;
                btnDeleteBook.Enabled = false;
                BookStoreClass.currentBookFile.rewindFile();

            }
            else  // if duplicate found
            {
                // Displays yes/no message box giving user chance to confirm update 

                DialogResult deleteSure = MessageBox.Show(" Are you sure you wish to select book with ISBN: " + enteredISBN,
                    "Delete Book", MessageBoxButtons.YesNo);
                if (deleteSure == DialogResult.Yes)   // if yes, continue with steps
                {
                    // display book attribute labels
                    lblEnterBookData.Visible = true;
                    lblReadISBN.Visible = true;
                    lblAuthor.Visible = true;
                    lblTitle.Visible = true;
                    lblPrice.Visible = true;
                    lblQuantity.Visible = true;
                    lblLastDateAccessed.Visible = true;
                    

                    // color and disable delete button
                    btnDeleteBook.BackColor = Color.LightYellow;
                    btnDeleteBook.Enabled = false;
                    btnDeleteDone.Visible = true;
                    btnDeleteDone.Enabled = true;
                    btnUpdateDone.Visible = false;
                    btnAddDone.Visible = false;


                    // display and enable book attribute textboxes
                    // display entered ISBN in Read-Only ISBN textbox
                    txtReadLeftISBN.Visible = true;
                    txtReadLeftISBN.Text = txtLeftISBN.Text;
                    txtReadLeftISBN.ReadOnly = true;

                    txtReadRightISBN.Visible = true;
                    txtReadRightISBN.Text = txtRightISBN.Text;
                    txtReadRightISBN.ReadOnly = true;

                    txtAuthor.Visible = true;
                    txtAuthor.Enabled = true;
                    txtAuthor.ReadOnly = true;

                    txtTitle.Visible = true;
                    txtTitle.Enabled = true;
                    txtTitle.ReadOnly = true;

                    txtPrice.Visible = true;
                    txtPrice.Enabled = true;
                    txtPrice.ReadOnly = true;

                    txtQuantity.Visible = true;
                    txtQuantity.Enabled = true;
                    txtQuantity.ReadOnly = true;

                    txtLastDateAccessed.Visible = true;
                    txtLastDateAccessed.ReadOnly = true;
                    txtLastDateAccessed.Text = Convert.ToString(DateTime.Now);


                    // set textbox attributes with attributes read from current book object
                    txtAuthor.Text = Globals.bookStore.book.getHiddenAuthor();
                    txtTitle.Text = Globals.bookStore.book.getHiddenTitle();
                    txtPrice.Text = Globals.bookStore.book.getHiddenPrice();
                    txtQuantity.Text = Globals.bookStore.book.getHiddenQuantity();
                    txtLastDateAccessed.Text = Globals.bookStore.book.gethiddenDateLastTransaction();
                }
            }
        }



        /*     private void btnTransactionDone_Click(object sender, EventArgs e)
             {
                 string bookString;
                 int recordsReadCount, recordsWrittenCount;

                 btnTransactionDone.Visible = false;

                 bookString = txtReadLeftISBN.Text + "-" + txtReadRightISBN.Text + " * " + txtTitle.Text + " * " + txtAuthor.Text + " * " +
                     txtPrice.Text + " * " + txtQuantity.Text + " * " + txtLastDateAccessed.Text;
                 Globals.bookStore.writeOneRecord(bookString);
                 recordsReadCount = BookStoreClass.currentBookFile.getRecordsReadCount();
                 recordsWrittenCount = BookStoreClass.updatedBookFile.getRecordsWrittenCount();
                 MessageBox.Show("Book added to current Book File. \r\n Records Read Count = " + recordsReadCount +
                     "\r\n Records Written Count = " + recordsReadCount, "Book added to Updated File",
                     MessageBoxButtons.OK, MessageBoxIcon.Stop);
                 Globals.bookStore.writeEntireEmployeeList();
                 Globals.bookStore.closeFiles();
                 MessageBox.Show("Program execution has completed.", "Execution complete.",
                     MessageBoxButtons.OK, MessageBoxIcon.Stop);
             } // end if-else
                         break;
                     case transactionCode.deleteBook:
                         bookString = lblReadISBN.Text + " * " + txtTitle.Text + " * " + txtAuthor.Text + " * " +
                                 txtPrice.Text + " * " + txtQuantity.Text + " * " + txtLastDataAccessed.Text;
                         MessageBox.Show(bookString, "Record to be deleted");
                 */


        // validate transaction data, verifying nothing is blank
        private Boolean validateTransactionData()
        {
            // validate ISBN
            if (txtReadLeftISBN.Text.Length != Globals.bookStore.ISBNLeftLength || txtReadRightISBN.Text.Length != Globals.bookStore.ISBNRightLength)
            {
                MessageBox.Show("ISBN " + (txtReadLeftISBN + "-" + txtReadRightISBN) + " not in proper format. Please reenter.", "ISBN Invalid",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReadLeftISBN.Clear();
                txtReadRightISBN.Clear();
                txtReadLeftISBN.Focus();
                return (false);
            }
            try
            {
                Convert.ToInt32(txtReadLeftISBN.Text);
                Convert.ToInt32(txtReadRightISBN.Text);
            }
            catch
            {
                MessageBox.Show("ISBN " + (txtReadLeftISBN + "-" + txtReadRightISBN) + " not in proper format. Please reenter.", "ISBN Invalid",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtReadLeftISBN.Clear();
                txtReadRightISBN.Clear();
                txtReadLeftISBN.Focus();
                return (false);
            }

            // validate Author 
            if (txtAuthor.Text == "" || txtAuthor.Text == " ")
            {
                MessageBox.Show("Author can not be left blank. Reenter new author", "No Author failure",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtAuthor.Clear();
                txtAuthor.Focus();
                return (false);
            }

            // validate Title
            if (txtTitle.Text == "" || txtTitle.Text == " ")
            {
                MessageBox.Show("Title can not be left blank. Reenter new title", "No title failure",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Clear();
                txtTitle.Focus();
                return (false);
            }

            //validate Price
            if (txtPrice.Text == "" || txtPrice.Text == " ")
            {
                MessageBox.Show("Title can not be left blank. Reenter new title", "No title failure",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTitle.Clear();
                txtTitle.Focus();
                return (false);
            }

            // validate DateTime
            try
            {
                DateTime date = DateTime.Parse(txtLastDateAccessed.Text);
            }
            catch
            {
                MessageBox.Show("(Transaction Date " + txtLastDateAccessed.Text + ")",
                    "Transaction Date Format Failure", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLastDateAccessed.Clear();
                txtLastDateAccessed.Focus();
                return (false);
            }
            return true;

        } // end validateTransactionData  

        // resets transaction form to the beginning if user selects unexecutable transaction
        private void resetTransactionForm()
        {
            // first rewinds book files
            BookStoreClass.currentBookFile.rewindFile();
            BookStoreClass.updatedBookFile.rewindFile();

            btnUpdateBook.UseVisualStyleBackColor = true;
            btnDeleteBook.UseVisualStyleBackColor = true;
            btnAddBook.UseVisualStyleBackColor = true;
            btnUpdateBook.Visible = false;
            btnAddBook.Visible = false;
            btnDeleteBook.Visible = false;

            txtReadLeftISBN.Clear();
            txtReadLeftISBN.Visible = false;
            txtReadRightISBN.Clear();
            txtReadRightISBN.Visible = false;
            lblReadISBN.Visible = false;
            txtLeftISBN.Focus();

            txtAuthor.Clear();
            txtAuthor.Visible = false;
            lblAuthor.Visible = false;

            txtTitle.Clear();
            txtTitle.Visible = false;
            lblTitle.Visible = false;

            txtPrice.Clear();
            txtPrice.Visible = false;
            lblPrice.Visible = false;

            txtQuantity.Clear();
            txtQuantity.Visible = false;
            lblQuantity.Visible = false;

            txtLastDateAccessed.Clear();
            txtLastDateAccessed.Visible = false;
            lblLastDateAccessed.Visible = false;

            lblEnterBookData.Visible = false;
        }


        // Click handler for the Update Done button
        //     finalizes delete transaction
        private void btnUpdateDone_Click(object sender, EventArgs e)
        {
            // validate changes made by user
            validateTransactionData();

            // create variables and assign attribute textbox values
            string author = txtAuthor.Text;
            string title = txtTitle.Text;
            string price = txtPrice.Text;
            string quantity = txtQuantity.Text;

            // set attributes to book object in program
            Globals.bookStore.book.setHiddenAuthor(author);
            Globals.bookStore.book.sethiddenTitle(title);
            Globals.bookStore.book.setHiddenPrice(price);
            Globals.bookStore.book.setHiddenQuantity(quantity);

            // create string to be written to file
            string bookString = Globals.bookStore.book.getHiddenISBN() + " * " + Globals.bookStore.book.getHiddenAuthor() +
                " * " + Globals.bookStore.book.getHiddenTitle() + " * " + Globals.bookStore.book.getHiddenPrice() + " * " +
                Globals.bookStore.book.getHiddenQuantity() + DateTime.Today;

            // display message of transaction being performed
            MessageBox.Show("Updating book: \n\n ISBN: " + Globals.bookStore.book.getHiddenISBN() + "\nAuthor: " + Globals.bookStore.book.getHiddenAuthor() +
                "\nTitle: " + Globals.bookStore.book.getHiddenTitle() + "\nPrice: " + Globals.bookStore.book.getHiddenPrice() + "\nQuantity: " +
                Globals.bookStore.book.getHiddenQuantity() + "\nDate: " + DateTime.Today);

            // first write updated record
            Globals.bookStore.writeOneRecord(bookString);

            // then write remaining book files that were not changed
            Globals.bookStore.copyRemainingRecords();

            // close files which also buffers
            BookStoreClass.currentBookFile.closeFile();
            BookStoreClass.updatedBookFile.closeUpdatedFile();
            BookStoreClass.currentEmployeeFile.closeFile();
            BookStoreClass.updatedEmployeeFile.closeUpdatedFile();

            // display message letting user know transaction was successful
            MessageBox.Show("Book successfully updated! Records written to file.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);

            // close program
            this.Close();
        }

        // Click handler for Add Done button
        //   finalizes add transaction
        private void btnAddDone_Click(object sender, EventArgs e)
        {
            // validate data
            validateTransactionData();

            // create strings and transfer attributes entered by user
            string author = txtAuthor.Text;
            string title = txtTitle.Text;
            string price = txtPrice.Text;
            string quantity = txtQuantity.Text;

            // set book object to new variables
            Globals.bookStore.book.setHiddenAuthor(author);
            Globals.bookStore.book.sethiddenTitle(title);
            Globals.bookStore.book.setHiddenPrice(price);
            Globals.bookStore.book.setHiddenQuantity(quantity);

            // create string to be written to updated file
            string bookString = Globals.bookStore.book.getHiddenISBN() + " * " + Globals.bookStore.book.getHiddenAuthor() +
                " * " + Globals.bookStore.book.getHiddenTitle() + " * " + Globals.bookStore.book.getHiddenPrice() + " * " +
                Globals.bookStore.book.getHiddenQuantity() + DateTime.Today;

            // Show user message of transaction and entered data
            MessageBox.Show("Adding Book: \n\n ISBN: " + Globals.bookStore.book.getHiddenISBN() + "\nAuthor: " + Globals.bookStore.book.getHiddenAuthor() +
                "\nTitle: " + Globals.bookStore.book.getHiddenTitle() + "\nPrice: " + Globals.bookStore.book.getHiddenPrice() + "\nQuantity: " +
                Globals.bookStore.book.getHiddenQuantity() + "\nDate: " + DateTime.Today);

            // first write the new book
            Globals.bookStore.writeOneRecord(bookString);

            // then write the rest of the current book file
            Globals.bookStore.copyRemainingRecords();

            // close files which also buffers
            BookStoreClass.currentBookFile.closeFile();
            BookStoreClass.updatedBookFile.closeUpdatedFile();
            BookStoreClass.currentEmployeeFile.closeFile();
            BookStoreClass.updatedEmployeeFile.closeUpdatedFile();

            // Display message confirming transaction success
            MessageBox.Show("Book successfully added! Records written to file.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);

            // Close program
            this.Close();
        }

        // btnDeleteDone Click Handler
        // handles the final delete button which writes all but the chosen record to the updated file
        private void btnDeleteDone_Click(object sender, EventArgs e)
        {
            string author = txtAuthor.Text;
            string title = txtTitle.Text;
            string price = txtPrice.Text;
            string quantity = txtQuantity.Text;

            Globals.bookStore.book.setHiddenAuthor(author);
            Globals.bookStore.book.sethiddenTitle(title);
            Globals.bookStore.book.setHiddenPrice(price);
            Globals.bookStore.book.setHiddenQuantity(quantity);

            // string to be written
            string bookString = Globals.bookStore.book.getHiddenISBN() + " * " + Globals.bookStore.book.getHiddenAuthor() +
                " * " + Globals.bookStore.book.getHiddenTitle() + " * " + Globals.bookStore.book.getHiddenPrice() + " * " +
                Globals.bookStore.book.getHiddenQuantity() + DateTime.Today;

            // display message when deleting
            MessageBox.Show("Deleting Book: \n \n ISBN: " + Globals.bookStore.book.getHiddenISBN() + "\nAuthor: " + Globals.bookStore.book.getHiddenAuthor() +
                "\nTitle: " + Globals.bookStore.book.getHiddenTitle() + "\nPrice: " + Globals.bookStore.book.getHiddenPrice() + "\nQuantity: " +
                Globals.bookStore.book.getHiddenQuantity() + "\nDate: " + DateTime.Today);

            // delete by copying all other records to updated file
            Globals.bookStore.copyRemainingRecords();

            // close all files which also buffers
            BookStoreClass.currentBookFile.closeFile();
            BookStoreClass.updatedBookFile.closeUpdatedFile();
            BookStoreClass.currentEmployeeFile.closeFile();
            BookStoreClass.updatedEmployeeFile.closeUpdatedFile();

            // Let user know transaction was successful
            MessageBox.Show("Book successfully deleted! Remaining records written to file.", "Success",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            this.Close();
        }
    }
}