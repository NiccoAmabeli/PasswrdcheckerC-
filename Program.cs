using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Passwrdchecker
{
    class Program
    {
        static void Main(string[] args)
        {
            int minLength = 5;
            string uppercase = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string lowercase = "abcdefghijklmnopqrstuvwxyz";
            string digits = "0123456789";
            string specialChars = "#?!,-'/`_*$";
            string password = "2woRDsss";
            int score = 0;
            if ((score) >= (minLength))
            {
                score++;
            }

            if (Tools.Contains(password, uppercase))
            {
                score++;
            }

            if (Tools.Contains(password, lowercase))
            {
                score++;
            }

            if (Tools.Contains(password, digits))
            {
                score++;
            }

            if (Tools.Contains(password, specialChars))
            {
                score++;
            }

            Console.WriteLine(password);
            Console.WriteLine(score);

            switch (score)
            {
                case 5:
                case 4:
                    Console.WriteLine("That should work...for now.");
                    break;
                case 3:
                    Console.WriteLine("It's better, but still kinda sucks.");
                    break;
                case 2:
                    Console.WriteLine("Meh...just meh.");
                    break;
                case 1:
                    Console.WriteLine("This is as weak as you.");
                    break;
                default:
                    Console.WriteLine("Are you even trying??");
                    break;
            }
            Console.ReadLine();
        }
    }
}
