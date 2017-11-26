using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMod5
{
    class Student
    {
        private string firstName;
        private string lastName;
        private DateTime birthday;
        public static int objectCount = 0;

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }

        public Student( string firstname, string lastName, DateTime birthday)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.birthday = birthday;
            objectCount++;
        }


    }
}
