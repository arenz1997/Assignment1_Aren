using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputName = Console.ReadLine();
            //This .Net standard delegate uses inputName of one user and checks wether he/she is banned or not.
            //In case of banned user this delegate writes "Welcome to..." or "Sorry, but..." with an anonymus method
            Action action = delegate ()
            {
                if ((inputName == "Jack") || (inputName == "Steven") || (inputName == "Mathew"))
                {
                    Console.WriteLine("Sorry, but " + inputName + " has banned for this organisation");
                }
                else
                {
                    Console.WriteLine("Welcome to " + inputName);
                }
            };
            //Calling the anonymus method with "action" delegate
            action();
        }
    }
}