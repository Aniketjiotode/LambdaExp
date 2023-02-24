using NUnit.Framework;
using Regex_;
using System.Text.RegularExpressions;
using System;

namespace TestProject1
{
    public class Tests
    {


        //[Test]
        //public void Test1()
        //{
        //    string expected = $"Name:Aniket Jiotode,Email:aniket@gmail.com,PhoneNumber:91 9623211205,Password:Pass@123";
        //    pattern p = new pattern();
        //    var res = p.patterncheck("Aniket Jiotode","aniket@gmail.com","91 9623211205","Pass@123");
        //    Assert.AreEqual(expected, res);
        //}

        [Test]
        [TestCase("aniket@gmail.com")]
        [TestCase("aniket.jio@gmail.org")]
        [TestCase("aniket@gmail.in")]
        [TestCase("aniket@yahoo.net")]
        [TestCase("aniket.12@gmail.in")]
        
        public void GivenEmailshouldReturnTrueIfPatternIsCorrect(string email)
        {
            bool expected=true;
            pattern p = new pattern();
            var res = p.EmailCheck(email);
            Assert.AreEqual(expected, res);

        }
    }
}