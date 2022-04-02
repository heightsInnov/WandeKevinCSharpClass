using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WandeKevin
{
    public class UtilHelper
    {
        public static bool IsValidEmail(string email)
        {
            try
            {
                Regex regex = new(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
                Match match = regex.Match(email);

                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email && match.Success;
            }
            catch
            {
                return false;
            }
        }

        public static bool IsValidBvn(string bvn)
        {
            return true;
        }
    }
}
