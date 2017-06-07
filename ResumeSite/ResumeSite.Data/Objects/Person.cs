using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeSite.Data.Objects
{
    public class Person
    {
        public string ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public Person(string _id, string _firstName, string _lastName, string _email)
        {

            ID = _id;
            FirstName = _firstName;
            LastName = _lastName;
            Email = _email;
        }
    }
}
