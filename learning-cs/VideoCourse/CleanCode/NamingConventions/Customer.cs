using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamingConventions
{
    /// <summary>
    /// Represents a customer by Id and Name
    /// </summary>
    internal class Customer
    {
        /// <summary>
        /// Gets the customer Id.
        /// </summary>
        public int Id { get; }

        /// <summary>
        /// Get or set customer Name.
        /// </summary>
        public string Name { get; set; }
    }
}
