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

        [Fact]
        public void TestVoteEligible()
        {
            var Guy1 = new Person();
            Guy1.citizen = "N";
            var expected = "No";
            var actual = Guy1.VoteEligible();

            Assert.Equal(expected,actual);
            
        }


        [Fact]
        public void TestLastNameChange()
        {
            var girl1 = new Person();
            var maiden = "Smith";
            var married = "Miller";

            girl1.lastName = maiden;
            girl1.ChangeLastName(married);

            Assert.Equal(maiden, girl1.maidenName);
            Assert.Equal(married, girl1.lastName);
        }

        [Fact]
        public void IsNameFormatting()
        {
            var girl1 = new Person();
            girl1.firstName = "Jane";
            girl1.lastName = "Baker";

            var actual = girl1.FormatAsFirstLast();
            var actual2 = girl1.FormatAsLastFirst();
            
            Assert.Equal("Jane Baker", actual);
            Assert.Equal("Baker, Jane", actual2);

        }





        


    }
}
