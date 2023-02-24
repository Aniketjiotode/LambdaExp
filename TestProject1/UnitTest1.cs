using NUnit.Framework;
using Regex_;
using System.Text.RegularExpressions;
using System;

namespace TestProject1
{
    public class Tests
    {


        [Test]
        [TestCase("aniket Jiotode", "aniket@gmail.com", "91 9623211205", "Pass@123")]
        public void InvalidUserNameShouldThrowCustomException(string name,string email,string number,string password)
        {
            string expecxted = "Invalid Name";
            try
            {
                pattern p = new pattern();
                var res = p.patterncheck(name, email, number, password);
            }
            catch (Exception e)
            {
                Assert.AreEqual(expecxted, e.Message);
            }
        }
        [Test]
        [TestCase("Aniket Jiotode", "aniketgmail.com", "91 9623211205", "Pass@123")]
        public void InvalidEmailShouldThrowCustomException(string name,string email,string number,string password)
        {
            string expecxted = "Invalid EmailId";
            try
            {
                pattern p = new pattern();
                var res = p.patterncheck(name, email, number, password);
            }
            catch (Exception e)
            {
                Assert.AreEqual(expecxted, e.Message);
            }
        }
        [Test]
        [TestCase("Aniket Jiotode", "aniket@gmail.com", "9623211205", "Pass@123")]
        public void InvalidPhoneNumberShouldThrowCustomException(string name,string email,string number,string password)
        {
            string expecxted = "Invalid phoneNumber";
            try
            {
                pattern p = new pattern();
                var res = p.patterncheck(name, email, number, password);
            }
            catch (Exception e)
            {
                Assert.AreEqual(expecxted, e.Message);
            }
        }
        [Test]
        [TestCase("Aniket Jiotode", "aniket@gmail.com", "91 9623211205", "Pass123")]
        public void InvalidPasswordShouldThrowCustomException(string name,string email,string number,string password)
        {
            string expecxted = "Invalid password";
            try
            {
                pattern p = new pattern();
                var res = p.patterncheck(name, email, number, password);
            }
            catch (Exception e)
            {
                Assert.AreEqual(expecxted, e.Message);
            }
        }

        //[Test]
        //[TestCase("aniket@gmail.com")]
        //[TestCase("aniket.jio@gmail.org")]
        //[TestCase("aniket@gmail.in")]
        //[TestCase("aniket@yahoo.net")]
        //[TestCase("aniket.@gmail.in")]

        //public void GivenEmailshouldReturnTrueIfPatternIsCorrect(string email)
        //{
        //    bool expected=true;
        //    pattern p = new pattern();
        //    var res = p.EmailCheck(email);
        //    Assert.AreEqual(expected, res);

        //}

    }
}