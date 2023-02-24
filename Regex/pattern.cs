using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Regex_
{
    public class pattern
    {
        public static string Firstname = "^[A-Z][a-z]{2,9}$";
        public static string Fullname = "^[A-Z][a-z]{2,9}[ ][A-Z][a-z]{2,9}$";
        public static string Email = @"[a-z]{3,9}.?[a-z0-9]{3,8}[@][a-z]{3,8}[\.](com|org|in|net)$";
        public static string PhoneNumber = @"^[0-9]{2}[ ][0-9]{10,}$";
        public static string Password = @"^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";
        public static string FullName,EmailId,PhoneNum,PasswordId;
        public string patterncheck(string Fname,string email,string phonenum,string password)
        {
            Regex r1= new Regex(Fullname);
            Console.WriteLine("Enter the FullName:");
            //string Fnames = Console.ReadLine();
             Console.WriteLine(r1.IsMatch(Fname));
            if (r1.IsMatch(Fname))
                FullName = Fname;
            Regex r2 = new Regex(Email);
            Console.WriteLine("Enter the EmailId:");
            //string emails = Console.ReadLine();
            Console.WriteLine(r2.IsMatch(email));
            if (r2.IsMatch(email))
                EmailId = email;
            Regex r3 = new Regex(PhoneNumber);
            Console.WriteLine("Enter the PhoneNumber:");
            //string phonenums = Console.ReadLine();
            Console.WriteLine(r3.IsMatch(phonenum));
            if (r3.IsMatch(phonenum))
                PhoneNum = phonenum;
            Regex r4 = new Regex(Password);
            Console.WriteLine("Enter the Password:");
            //string passwords = Console.ReadLine();
            Console.WriteLine(r4.IsMatch(password));
            if (r4.IsMatch(password))
                PasswordId = password;
           string res=$"Name:{FullName},Email:{EmailId},PhoneNumber:{PhoneNum},Password:{PasswordId}";
            return res ;
        }
    }
}
