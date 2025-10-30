using System.Collections.Concurrent;
using _14_StatiClassExtensionMethodsExceptions.Exceptions;
using _14_StatiClassExtensionMethodsExceptions.Models;

namespace _14_StatiClassExtensionMethodsExceptions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LoginSystem loginSystem = new LoginSystem();
            while (true) 
            {
                Console.WriteLine("User daxil edin:");
                string username = Console.ReadLine();

                Console.WriteLine("Parol daxil edin");
                String password = Console.ReadLine();

                try
                {
                    bool success = loginSystem.Login(username, password)
                        if (success)
                        break;
                }

                catch (InvalidUsernameException ex)
                {
                    Console.WriteLine("ERROR:" + ex.Message);

                }
                catch (InvalidPasswordException ex)
                {
                    Console.WriteLine("ERROR:" + ex.Message);

                }
                catch (UserNotFoundException ex)
                {
                    Console.WriteLine("ERROR:" + ex.Message);

                    loginSystem.ShowUsers();

                }
                catch (IncorrectPasswordException ex)
                {
                    Console.WriteLine("WARNING: " + ex.Message);
                }
                catch (AccountLockedException ex)
                {
                    Console.WriteLine("CRITICAL:" + ex.Message + "Contanct admin.");
                    break;

                }
                catch (Exception ex) 
                
                {
                    Console.WriteLine("UNEXEPTED ERROR:" ex.Message);
                }
                Console.WriteLine();
                 

            
            }
        }
    }
}
