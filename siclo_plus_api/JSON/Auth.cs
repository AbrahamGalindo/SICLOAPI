using siclo_plus_api.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace siclo_plus_api.JSON
{
    public class Auth
    {
        //01_Post_forgot_password
        public static string GenerateJSONForPostForgotPassword(string email)
        {
            return @"{""email"": " + Helper.PutQuotes(email) + "}";
        }
        //02_Post_forgot_password_bad_request
        public static string GenerateJSONForPostForgotPasswordBadRequest(string email)
        {
            return @"{""emal"": " + Helper.PutQuotes(email) + "}";
        }
        //03_Post_login
        public static string GenerateJSONForPostLogin(string email, string password)
        {
            return @"{""email"": " + Helper.PutQuotes(email) + @",""password"": " + Helper.PutQuotes(password) + "}";
        }


    }
}
