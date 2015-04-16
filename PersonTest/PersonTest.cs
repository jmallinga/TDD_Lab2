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

            Assert.Equal("John", Guy1.firstName);
        }

        [Fact]
        public void HasLastNameAndBirthday()
        {
            var Guy1 = new Person();
            Guy1.lastName = "Mallinga";
            Guy1.birthday = new DateTime(1987, 06, 05);
            var testDate = new DateTime(1987, 06, 05);

            Assert.Equal("Mallinga", Guy1.lastName);
            Assert.Equal(testDate, Guy1.birthday);

        }

        [Fact]
        public void HasSocialSecurityNumber()
        {

            var Guy1 = new Person();
            Guy1.SetSocialSecurityNumber(999999999);

            Assert.Equal(999999999, Guy1.socialSecurity);
        }

        [Fact]
        public void TestAge()
        {
            var Guy1 = new Person();
            var testBirthday = new DateTime(1962, 10, 18);
            Guy1.birthday = testBirthday;

            var actualAge = Guy1.CalculateAge();

            Assert.Equal(DateTime.Today - testBirthday, actualAge);

        }


    }
}
