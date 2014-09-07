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
