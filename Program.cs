using System;
using System.Threading;
using HostelManagementSystem.Entities;

namespace HostelManagementSystem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n\n\t\tWELCOME TO PORTO HOSTEL MANAGEMET\n\n");

            Console.Write("\tLogin\n\t    Id: ");
            string id = Console.ReadLine().ToUpper();
            Console.Write("\t    Password: ");
            string password = Console.ReadLine().ToUpper();
            Console.WriteLine("\n\nCheking...");
            Thread.Sleep(3000);
            Console.Clear();

            DoLogin(id, password);
            Thread.Sleep(2000);
            Console.Clear();

            
            
        }
        static void DoLogin(string id, string password)
        {

            if (Login.UserCheck(id, password) == false)
            {
                while(Login.UserCheck(id, password) == false)
                {

                    Console.WriteLine("ID or PASSWORD is incorrect. Try again\n");
                    Console.Write("Login\nId: ");
                    id = Console.ReadLine().ToUpper();
                    Console.Write("Password: ");
                    password = Console.ReadLine().ToUpper();

                    Console.WriteLine("Cheking...");

                    Login.UserCheck(id, password);
                    Thread.Sleep(3000);
                    Console.Clear();
                }
            }

            if (Login.UserCheck(id, password) == true)
            {
                Console.WriteLine("Allowed access");
                Thread.Sleep(3000);
                Console.Clear();
            }



        }

        static void MainMenu()
        {

        }
    }
}
