using System;

namespace Members
{
    class Members
    {
        // member - private field
        private string memberName;
        private string jobTitle;
        private int salary = 2000;

        // member - public field
        public int age;

        // member - property -  exposes jobTitle safely
        // properties start with capital letter
        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                jobTitle = value;
            }
        }


        // public member Method - can be called from other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                SharingPrivateInfo();
            }
            else
            {
                Console.WriteLine("Hi my name is {0}, and my job title is {1}. I'm {2} years old", memberName, jobTitle, age);
            }
        }

        private void SharingPrivateInfo()
        {
            Console.WriteLine("My salary is {0}", salary);
        }


        // member constructor
        public Members()
        {
            age = 30;
            memberName = "Juan";
            salary = 60000;
            jobTitle = "Senior Program Manager";
            Console.WriteLine("Object created");
        }



        // member - finalizer - destructor
        // can be created one per class
        // cannot be inheritent
        ~Members()
        {
            // clean statements
            Console.WriteLine("Deconstruction of Members object");
        }

    }
}
