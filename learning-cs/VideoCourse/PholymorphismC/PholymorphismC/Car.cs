using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PholymorphismC
{
    class Car
    {
        public string Color { get; set; }
        public int HP { get; set; }

        public Car() { }
        public Car(string color, int hp)
        {
            Color = color;
            HP = hp;
        }

        // Has as property
        protected CardIDInfo cardIDInfo = new CardIDInfo();
        public void SetCardIDNumber(int cardID, string owner)
        {
            cardIDInfo.CardIDNumber = cardID;
            cardIDInfo.Owner = owner;
        }

        public void GetCardIDNumber()
        {
            Console.WriteLine("The car has the ID {0} and is owned by {1}", cardIDInfo.CardIDNumber, cardIDInfo.Owner);
        }
        // end of has as

        public void ShowDetails()
        {
            Console.WriteLine($"Car color is '{Color}', HP is {HP}");
        }

        public virtual void Repair()
        {
            Console.WriteLine("Car mode was repaired!");
        }
    }
}
