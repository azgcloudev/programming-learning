using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesDemo
{
    class Ticket : IEquatable<Ticket>
    {
        public int DurationInHours { get; set; }

        public Ticket(int durationInHours)
        {
            DurationInHours = durationInHours;
        }

        // interface method
        public bool Equals(Ticket other)
        {
            return DurationInHours == other.DurationInHours;
        }
    }
}
