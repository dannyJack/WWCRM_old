using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WritersWeb.Base
{
    public class UserProfile
    {
        #region Properties

        private static string Username { get; set; }
        private static string Password { get; set; }
        public static string Fullname { get; set; }
        private static string Restriction { get; set; }
        public static int IdEmployee { get; set; }
        public static string Lastname { get; set; }
        public static string Firstname { get; set; }
        public static string Middlename { get; set; }
        #endregion

        #region FactoryMethods

        public static void SetProperties(string uname, string pword, string fullname, string restric, int id, string lastname, string firstname, string middlename)
        {
            Username = uname;
            Password = pword;
            Fullname = fullname;
            Restriction = restric;
            IdEmployee = id;
            Lastname = lastname;
            Firstname = firstname;
            Middlename = middlename;
        }

        public static bool IsInRole(string restricCode)
        {
            if (Restriction.Contains(restricCode))
                return true;
            else
                return false;
        }

        #endregion

    }
}
