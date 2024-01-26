using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace PholymorphismC
{
   
    // sealed also allows classes to not be inherited
    // M3 is now sealed and cannot be inherited
    sealed class M3 : BMW
    {
        private string Model = "M3";
        public M3(string color, int hp)
        {
            Color = color;
            HP = hp;
        }

        //// cannot use override
        //public override void Repair()
        //// error CS0239: 'M3.Repair()': cannot override inherited member 'BMW.Repair()' because it is sealed
        //{
        //    Console.WriteLine("");
        //}
    }
}
