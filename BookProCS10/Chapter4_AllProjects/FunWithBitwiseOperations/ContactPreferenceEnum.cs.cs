using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithBitwiseOperations
{
    [Flags]
    public enum ContactPreference
    {
        None = 1,
        Email = 2,
        Phone = 4,
        Ponyexpress = 6
    }
}
