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
        public string lastName { get; set; }
        public DateTime birthday { get; set; }
        public int socialSecurity { get; set; }
        
        
        public Person()
        {

        }

        public Person(string n) : this()
        {
            this.firstName = n;
        }

        public void SetSocialSecurityNumber(int a)
        {
            this.socialSecurity = a; 
            
        }

        public object CalculateAge()
        {
            var age = DateTime.Today - birthday;
            return age;
        }
    }
}
