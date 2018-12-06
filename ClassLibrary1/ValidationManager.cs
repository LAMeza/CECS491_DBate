using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PwnedPasswords
{
    public class ValidationManager
    {
        //private static string userAgent = "DBate";
        //private static string URL = "https://api.pwnedpasswords.com/range/";
        private static PasswordValidationService pvs = new PasswordValidationService();

        public async Task<bool> IsPasswordSafe(string password)
        {
            SHA1 sha = SHA1.Create();
            byte[] byteHash = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
            string stringHash = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < byteHash.Length; i++)
            {
                sb.Append(byteHash[i].ToString("X2"));
            }
            stringHash = sb.ToString();

            string prefix = stringHash.Substring(0, 5);
            var checkPwned = await pvs.CheckPassword(prefix);

            string restOfHash = stringHash.Substring(5, stringHash.Length - 5);
            var hashExists = checkPwned.Contains(restOfHash);
            if (checkPwned.Contains(restOfHash))
            {
                int index = checkPwned.IndexOf(restOfHash);
                int passwordAcceptance = AcceptRejectPassword(index, checkPwned);
            }
            else
            {
                //do something else if not contained
            }
            return hashExists;
        }

        public int AcceptRejectPassword(int index, string checkHash)
        {
            Regex colon = new Regex(@":(\d+)");

            return 0;
        }
    }
}
