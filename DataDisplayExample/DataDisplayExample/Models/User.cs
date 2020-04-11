using System;
using System.Collections.Generic;
using System.Text;

namespace DataDisplayExample
{
    public class User
    {
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }


//if we were to combine all into one string for only one label to display, use the ToString function

        public string ToString()
        {
            return Name + " " + Address + ", " + Email + " " + Age + " : " + PhoneNumber;
        }
    }
}
