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
            new RNGCryptoServiceProvider().GetBytes(salt = new byte[16]);

            var Rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, salt, 100000);
            byte[] hash = Rfc2898DeriveBytes.GetBytes(20); 

            byte[] hashbytes = new byte[36];
            Array.Copy(salt, 0, hashbytes, 0, 16);
            Array.Copy(hash, 0, hashbytes, 16, 20);

            return Convert.ToBase64String(hashbytes);
        }

        public static Boolean unHashPassword(String PasswordHash, String PasswordUserEnter)
        {
            byte[] hashBytes = Convert.FromBase64String(PasswordHash);

            byte[] salt = new byte[16];
            Array.Copy(hashBytes, 0, salt, 0, 16);

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
