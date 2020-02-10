using System;
using static Task4_BootcampRefactory.LogClass;

namespace Task4_BootcampRefactory
{
    public class AuthenticClass
    {
        public static string user = "root";
        public static string password = "secret";
        public static string id = "rx-178";
        public static int condition = 0;
        public static DateTime loginTime = new DateTime();



        public static void login(string User, string Password)
        {
            if (User == user && Password == password)
            {
                Console.WriteLine("Logged in");
                Log1.PopulateLog("Logged in");
                condition = 1;
                loginTime = DateTime.Now;
            }
            else
            {
                Console.WriteLine("Wrong password and/or username");
                Log1.PopulateLog("unknown tried to log in");
            }
        }

        public static void validate(string User, string Password)
        {
            if (User == user && Password == password && condition == 1)
            {
                Console.WriteLine("Already Logged in");
                Log1.PopulateLog("user validated");
            }
            else
            {
                Console.WriteLine("Log in first");
                Log1.PopulateLog("unknown tried to validate");
            }
        }

        public static void ID()
        {
            if (condition == 1)
            {
                Console.WriteLine(id);
                Log1.PopulateLog("user request id");
            }
            else
            {
                Console.WriteLine("log in first");
                Log1.PopulateLog("unknown tried to request id");
            }
        }

        public static void logout()
        {
            condition = 0;
            Console.WriteLine("logged out");
            Log1.PopulateLog($"{user} logged out");
        }

        public static void _user()
        {
            if (condition == 1)
            {
                Console.WriteLine(user[0]);
                Log1.PopulateLog($"{user} shows username");
            }
            else
            {
                Console.WriteLine("log in first");
            }
        }

        public static void check()
        {
            if (condition == 1)
            {
                Console.WriteLine(true);
                Log1.PopulateLog($"{user} is logged in");
            }
            else
            {
                Console.WriteLine(false);
                Log1.PopulateLog("unknown tried to check");
            }
        }
        public static void guest()
        {
            if (condition == 0)
            {
                Console.WriteLine(true);
                Log1.PopulateLog("guest is user");
            }
            else
            {
                Console.WriteLine(false);
                Log1.PopulateLog($"{user} is logged in");
            }
        }
        public static void lastLogin()
        {
            Console.WriteLine(loginTime);
            Log1.PopulateLog($"{user} last log in");
        }
    }

}
