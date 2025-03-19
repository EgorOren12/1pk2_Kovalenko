using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_14_04
{
    class User
    {
        public static string CurrentUser
        {
            get; set;
        }
        public static void SetCurrentUser(string a)
        {
            CurrentUser = a;
        }
    }
}
