using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
    // BASE CLASS   
    internal class ElectricalDevice
    {
        // Fields
        public bool IsOn { get; set; }
        public string Brand { get; set; }

        // constructors
        public ElectricalDevice(bool isOn, string brand)
        {
            IsOn = isOn;
            Brand = brand;
        }

        // methods

        /// <summary>
        /// Turns on the device switch.
        /// </summary>
        public void SwitchOn()
        {
            IsOn = true;
        }

        /// <summary>
        /// Turns the switch off.
        /// </summary>
        public void SwitchOff()
        {
            IsOn = false;
        }

    }
}
