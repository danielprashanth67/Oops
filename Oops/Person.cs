using System;
using System.Collections.Generic;
using System.Text;

namespace Oops
{
    class Person
    {
        public string FirstName;
        public string LastName;
        public Person()
        {
            FirstName = "Daniel";
            LastName = "Naguri";
            string FullName = FirstName + LastName;
                }
        public Person(string FName,string LName)
        {
            FirstName = FName;
            LastName = LName;
            string FullName = FirstName + LastName;
        }
    }
}
