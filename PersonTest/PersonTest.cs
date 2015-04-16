using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TDD_Lab2;
using Xunit;

namespace TDDLab2.Test
{
    public class PersonTest
    {
        [Fact]
        public void IsObject()
        {
            var Guy1 = new Person("John");

            Assert.Equal("John", Guy1.firstname);
        

        
        }


    }
}
