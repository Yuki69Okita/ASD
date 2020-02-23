using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1Struct
{
    struct User
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }

        public User(string firstName, string middleName, string lastName)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }
        public override string ToString()
        {
            return (string.Format("{0},{1},{2}", FirstName, MiddleName, LastName));
        }

        public string Initials()
        {
            return (string.Format("{0}{1}{2}",
                FirstName.Substring(0, 1),
                MiddleName.Substring(0, 1),
                LastName.Substring(0, 1)));
        }
    }
}
