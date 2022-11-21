using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistrationForm
{
    public class UserForm
    {
        public static void userForm()
        {
            string first = @"^[A-Z]{1}[a-z A-Z]{2,10}";
            string emailPattern = @"^[a-z A-Z]+([.][a-z A-Z]+)*@[a-z A-Z]+.[a-z A-Z]{2,10}([.][a-z A-Z]{2,3})?$";

            Console.Write("Enter first name : ");
            string fName = Console.ReadLine();
            Console.Write("Enter last name : ");
            string lName = Console.ReadLine();
            Console.Write("Enter your email address : ");
            string email = Console.ReadLine();

            Regex name = new Regex(first);

            Regex emailValidate = new Regex(emailPattern);

            bool frst = name.IsMatch(fName);
            bool lst = name.IsMatch(lName);
            bool emailResult = emailValidate.IsMatch(email);




            if (frst)
            {
                Console.WriteLine($" Valide First Name {fName}");
            }
            else
            {
                Console.WriteLine("Invalide first name");
            }
            if (lst)
            {
                Console.WriteLine($" Valide Last Name {lName}");
            }
            else
            {
                Console.WriteLine("Invalide last name");
            }
            if (emailResult)
            {
                Console.WriteLine($" Valide email  {email}");
            }
            else
            {
                Console.WriteLine("Invalide email");
            }


        }
    }
}
