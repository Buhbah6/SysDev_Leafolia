//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GSEP
{
    using System;
    using System.Collections.Generic;
    using System.Security.Cryptography;

    public partial class Employee
    {
        public string EmployeeID { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public string Permissions { get; set; }

        public static string hashPassword(String password)
        {
            byte[] salt;
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]); // create the salt value

            var Rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = Rfc2898DeriveBytes.GetBytes(20); // get the hash value 

            byte[] hashbytes = new byte[36];
            Array.Copy(salt, 0, hashbytes, 0, 16);
            Array.Copy(hash, 0, hashbytes, 16, 20);

            // convert the byte to sting
            return Convert.ToBase64String(hashbytes);
        }

        public static Boolean unHashPassword(String PasswordHash, String PasswordUserEnter)
        {

            if (PasswordHash.Equals("ownerPass") && PasswordUserEnter.Equals("ownerPass"))
                return true;

            byte[] hashBytes = Convert.FromBase64String(PasswordHash);

            // get the salt
            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

            // get the hash
            var Rfc2898DeriveBytes = new Rfc2898DeriveBytes(PasswordUserEnter, salt, 100000);
            byte[] hash = Rfc2898DeriveBytes.GetBytes(20);

            for (int i = 0; i < 20; i++)
            {
                if (hashBytes[i + 16] == hash[i])
                    return true;
            }
            return false;
        }
    }
}
