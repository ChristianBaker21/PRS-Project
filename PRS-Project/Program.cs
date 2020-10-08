using PRS_Library;
using PRS_Library.Controllers;
using PRS_Library.Models;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.InteropServices;

namespace PRS_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var prsconn = new PrsConnection("localhost", "PRS");
            prsconn.Connect();

            var user = new User()
            {
                Id = 0,
                Username = "zz",
                Password = "zz",
                Firstname = "zz",
                Lastname = "zz",
                Phone = "zz",
                Email = "zz",
                IsReviewer = true,
                IsAdmin = true
            };


            var usersCtrl = new UsersController(prsconn);

            //var recsAffected = usersCtrl.Insert(user);

            var users = usersCtrl.GetUsers();

            var user1 = usersCtrl.GetUser(8);
            user1.Firstname = "Noah";
            user1.Lastname = "Phence";

            //recsAffected = usersCtrl.Update(user1);
            var user2 = usersCtrl.GetUser(2);

            prsconn.Disconnect();

        }
    }
}
