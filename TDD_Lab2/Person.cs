using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD_Lab2
{
    public class Person

    {
        public string firstName { get; set; }
        
        
        public Person()
        {

        }

        public Person(string n)
        {
            this.firstName = n;
        }

    }
}
