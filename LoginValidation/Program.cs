using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //login: admin
            //password: pass1234

            //declane variables
            //assign value - initialize a variable
            string login = "admin";
            string password = "pass1234";

            string userName, userPassword;
            Console.WriteLine("Enter your login: ");
            userName = Console.ReadLine();
            Console.WriteLine("Enter your password: ");
            userPassword = Console.ReadLine();

            if (login == userName && password == userPassword)
            {
                Console.WriteLine("Welcome");
            }
            else
            {
                Console.WriteLine("Oops... Something went wrong!");
            }



        }
    }
}
