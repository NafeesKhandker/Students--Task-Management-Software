using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace MyStudentLifeController
{
    public class ControllerClass
    {

        public bool IsValidEmail(string email)
        {
            
            //connection string name
            const string MatchEmailPattern =
            @"^(([\w-]+\.)+[\w-]+|([a-zA-Z]{1}|[\w-]{2,}))@" + @"((([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
            [0-9]{1,2}|25[0-5]|2[0-4][0-9])\." + @"([0-1]?[0-9]{1,2}|25[0-5]|2[0-4][0-9])\.([0-1]?
			[0-9]{1,2}|25[0-5]|2[0-4][0-9])){1}|" + @"([a-zA-Z]+[\w-]+\.)+[a-zA-Z]{2,4})$";



            if (email != null)
            {
                return Regex.IsMatch(email, MatchEmailPattern);
            }
            else
            {
                return false;
            }
        }

        public bool IsValidPassword(string password)
        {

            const string MatchPasswordPattern = @"^.*(?=.{6,})(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[._@#$%^&+=]).*$";

            if (password != null)
            {
                return Regex.IsMatch(password, MatchPasswordPattern);
            }
            else
            {
                return false;
            }
        }

    }
}
