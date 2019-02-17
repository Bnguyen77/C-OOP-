using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1
{
    public abstract class Person //using abstract class, cant use directly
    {

        public string Name { get; set; }

        public void updateName(string newName)
        {
            Name = newName;
        }
    }

    public class Customer: Person
    {
        //this is example of ENCAPSULATION where customerID and CustomerName and Method only exist 
        //and work with class Customer.

        public int customerID {get; set;}    
    }

    public class Supplier: Person
    {
        // INHERITANCE is sub class that support the main class.
        public int SupplierID { get; set; }
    }
}
