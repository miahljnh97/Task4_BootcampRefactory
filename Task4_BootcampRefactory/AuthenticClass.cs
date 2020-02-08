using System;
namespace Task4_BootcampRefactory
{
    //public class AuthenticClass
    //{
    //    public static List<user> database { get; set; }

    //    public static List<user> log { get; set; }

    //    public static user currentUser { get; set; }

    //    public Auth()
    //    {
    //        database = new List<user>();
    //        log = new List<user>();
    //    }

    //    public static void createUser(string user, string pwd)
    //    {
    //        database.Add(new user { Username = user, Password = pwd });
    //    }

    //    public static void login(string username, string pwd)
    //    {
    //        var user = new user
    //        {
    //            Username = username,
    //            Password = pwd
    //        };
    //        if (database.Contains(user) && currentUser == null)
    //        {
    //            currentUser = user;
    //            log.Add(user);
    //            Console.WriteLine("Loggin Succesfully");
    //        }
    //        else { Console.WriteLine("Incorrect username or password") };
    //    }

    //    public static void validate(string username, string pwd)
    //    {
    //        var user = new user
    //        {
    //            Username = username,
    //            Password = pwd
    //        };
    //        if (database.Contains(user))
    //        {
    //            Console.WriteLine("Verify");
    //        }
    //        else { Console.WriteLine("Not Verify")};
    //    }

    //    public static void logout()
    //    {
    //        currentUser = null;
    //        Console.WriteLine("Logout Succesfull");
    //    }

    //    public static void user()
    //    {
    //        Console.WriteLine($"Current user logged in : {currentUser}");
    //    }

    //    public static void id()
    //    {
    //        foreach (var i in database)
    //        {
    //            Console.WriteLine($"user_id : {currentUser.Username}");
    //        }
    //    }

    //    public static bool check()
    //    {
    //        if (currentUser != null)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }

    //    public static bool guest()
    //    {
    //        if (currentUser == null)
    //        {
    //            return true;
    //        }
    //        return false;
    //    }

    //    public static void lastlogin()
    //    {
    //        Console.WriteLine(log[log.Count - 1]);
    //    }

    //}

    //class user
    //{
    //    public string Username { get; set; }
    //    public string Password { get; set; }
    //}

}
