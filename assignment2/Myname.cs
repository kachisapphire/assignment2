using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment2
{
    public class Myname
    {
        public string Firstname;
        public string Lastname;

        public Myname(string firstname, string lastname)
        {
            Firstname = firstname;
            Lastname = lastname;
        }

        public void Myfullname()
        {
            Console.WriteLine("My name is " + Firstname + " " + Lastname);
        }
    }
}
