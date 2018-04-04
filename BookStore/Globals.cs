// Globals Information Class
// Contains only a reference to the BookStore class and the instantiation of this class

// Brendan J Power - CIS 3309 Section 001
// tuf73760@temple.edu --- TUid # 910794054

using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore
{
    public class Globals
    {
        // Static mathods of this class may be called without instantiating the class

        // Static objects or variables may be accessed without creating an instance of the class
        // that contains them.

        // When you declare a class as static, all its members are automatically static

        // Application classes
        // BookStore is accessible throughout all code without passing it as an argument
        public static BookStoreClass bookStore = new BookStoreClass();

        // frmEmployeeAccessIDEntry 
        public static frmEmployeeAccessIDEntry IDForm = new frmEmployeeAccessIDEntry();

        // frmEmployeePINEntry
        // public static frmEmployeePINEntry PINForm = new frmEmployeePINEntry();

    }   // end Globals Class
} // end namespace
