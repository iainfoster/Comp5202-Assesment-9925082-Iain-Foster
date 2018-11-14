using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp5202_9925082_Login_System
{
    class Account
    {

        //Auto properties byt useing the type prop then Tabx2
        public string Username { get; set; }
        public string Password1 { get; set; }
        public string Password2 { get; set; }
        //Constructor
        public Account(string username, string password1, string password2)
        {
            Username = username;
            Password1 = password1;
            Password2 = password2;
        }
        //Method
        public string Login()
        {
            return "\nlogin username: " + Username + "\nPassword1: " + Password1 + "\nPassword2: " + Password2;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Welcome to the User Login Page: ");
            Console.WriteLine("--------------------------------");
            // Gathers username.
            Console.WriteLine("Please enter account Username: ");
            string username = Console.ReadLine();
            //Gathers first password.
            Console.WriteLine("Please enter account Password: ");
            string password1 = Console.ReadLine();
            //Gathhers second password.
            Console.WriteLine("Please re enter account password to confirm: ");
            string password2 = Console.ReadLine();

            Account a1 = new Account(username, password1, password2);

            Console.Clear();
            Console.WriteLine(a1.Login());
        }

    }
}
