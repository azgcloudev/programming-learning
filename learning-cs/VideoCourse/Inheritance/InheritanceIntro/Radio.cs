using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceIntro
{
    // CHILD CLASS FROM ELECTRCALDEVICE CLASS
    internal class Radio : ElectricalDevice
    {

        public Radio(bool isOn, string brand) : base(isOn, brand) { }


        public void ListenRadio()
        {
            if (IsOn == true)
            {
                Console.WriteLine("Listening to radio");
            }
        }
    }

}
