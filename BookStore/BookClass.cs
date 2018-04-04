// Book Class
// creates and validates our book object 

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
    public class BookClass
    {
        // declaring private variables
        private string hiddenISBN;
        private string hiddenTitle;
        private string hiddenAuthor;
        private string hiddenPrice;
        private string hiddenQuantity;
        private string hiddenDateLastTransaction;

        public string getHiddenISBN()
        {
            return this.hiddenISBN;
        }
        public void setHiddenISBN(string ISBN)
        {
            this.hiddenISBN = ISBN;
        }


        public string getHiddenTitle()
        {
            return this.hiddenTitle;
        }

        public void sethiddenTitle(string title)
        {
            this.hiddenTitle = title;
        }

        public string getHiddenAuthor()
        {
            return this.hiddenAuthor;
        }

        public void setHiddenAuthor(string author)
        {
            this.hiddenAuthor = author;
        }

        public string getHiddenPrice()
        {
            return this.hiddenPrice;
        }

        public void setHiddenPrice(string price)
        {
            this.hiddenPrice = price;
        }

        public string getHiddenQuantity()
        {
            return this.hiddenQuantity;
        }

        public void setHiddenQuantity(string quantity)
        {
            this.hiddenQuantity = quantity;
        }

        public string gethiddenDateLastTransaction()
        {
            return this.hiddenDateLastTransaction;
        }

        public void setHiddenDateLastTransaction(string lastTransaction)
        {
            this.hiddenDateLastTransaction = lastTransaction;
        }


        public Boolean createBookObject(string s) // IN: string from the Book Text File
        {
            BookClass thisBook = this;
            string[] bookString = s.Split('*');

            bookString[0] = bookString[0].Trim();

            // Convert ISBN
            hiddenISBN = bookString[0];
            if (hiddenISBN == "" || hiddenISBN == " ")
            {
                MessageBox.Show(hiddenISBN +
                    ": ISBN cannot be blank. Book File Corrupt. Execution Terminated.",
                    "ISBN in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // title string to string (no conversion)
            // Checks for blank title

            hiddenTitle = bookString[1].Trim();
            if (hiddenTitle == " " || hiddenTitle == "")
            {
                MessageBox.Show(hiddenTitle +
                    ": Title string is empty or Blank. Book File Corrupt. Execution Terminated.",
                    "Title in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            hiddenAuthor = bookString[2].Trim();
            // Convert author to string
            // Checks for blank author
            if (hiddenAuthor == " " || hiddenAuthor == "")
            {
                MessageBox.Show(hiddenAuthor +
                    ": Author cannot be blank. Book File Corrupt. Execution Terminated.",
                    "Author in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert price to hiddenPrice
            hiddenPrice = bookString[3].Trim();
            if (hiddenPrice == " " || hiddenPrice == "")
            {
                MessageBox.Show(hiddenPrice +
                    ": Price cannot be blank. Book File Corrupt. Execution Terminated.",
                    "Price in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }

            // Convert quantity to hiddenQuantity
            hiddenQuantity = bookString[4].Trim();
            if (hiddenQuantity == " " || hiddenQuantity == "")
            {
                MessageBox.Show(hiddenQuantity +
                    ": Quantity cannot be blank. Book File Corrupt. Execution Terminated.",
                    "Quantity in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            // Convert Last Date of Access to a Date
            hiddenDateLastTransaction = bookString[5].Trim();
            if (hiddenDateLastTransaction == " " || hiddenDateLastTransaction == "")
            {
                MessageBox.Show(hiddenDateLastTransaction +
                    ": Date of Last Transaction cannot be blank. Book File Corrupt. Execution Terminated.",
                    "Date in Book File Invalid", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            //if all data is valid
            return (true);
        }


        // bookMatch()
        //  given a book ISBN entered by the user, and a record from the current
        //  book file, checks for a match. 
        //  Reads from the currentBookFile and splits record in substrings.
        public Boolean bookMatch(string enteredISBN)
        {
            if (this.hiddenISBN == enteredISBN)
            {
                Globals.bookStore.book = this;
                return true;

            }

            return false;
        }
        /*
       public void updateDateOfLastTransaction()
       {
           this.hiddenDateLastTransaction = Dat
       }  */
    }
}
