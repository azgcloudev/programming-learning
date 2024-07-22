using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NamingConventions
{
    /// <summary>
    /// Provides functionalities to handle customers.
    /// </summary>
    internal class CustomerService // class name in Pascal Case
    {
        /*
         * For code formatting follow the next conventions for order:
         * 1- Properties
         * 2- Fields
         * 3- Constructors
         * 4- Methods
         */

        // properties
        public int CustomerCount { get; set; } // Pascal Case
        // constant variable
        public const int MAX_CUSTOMERS = 100; // all caps with underscore

        // private field
        private string lastCustomerName = "Doe"; // camel case
        // private field 2
        private string _customerName;

        // Constructor because allows to create an empty object
        public CustomerService() { }
        /// <summary>
        /// Creates a CustomerService class object with customerName
        /// </summary>
        /// <param name="customerName">Sets the name of the customer</param>
        public CustomerService(string customerName)
        {
            _customerName = customerName;
        }

        //method
        public string GetCustomerName(int id) // Name is in Pascal Case and parameters are camel case
        {
            string customerName = "John Doe"; // local variable in camel case
            return customerName;
        }
        /// <summary>
        /// Gets a customer by Id
        /// </summary>
        /// <param name="customerId">Id for the Customer to be retrieve</param>
        /// <returns>Return the Customer found by the Id</returns>
        public Customer GetCustomerById(int customerId)
        {
            return new Customer { Name = "John Doe" };
        }
    }
}
