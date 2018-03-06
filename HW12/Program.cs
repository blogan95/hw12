using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace HW12
{
    class Program
    {
    
  static string Check(ref string userInput)
        {
            //should change input to an array + reverse
            char[] convInput = userInput.ToCharArray();
            Array.Reverse(convInput);
            string backwards = new string(convInput);
          return backwards;
       
        }

        static void Main(string[] args)
        {
         WriteLine($"Enter text to check palindrome.");
         string userInput = ReadLine();
         string backwards = Check(ref userInput);
         WriteLine($"{backwards}");
            if (userInput.Equals(backwards))
            {
                WriteLine($"This is a palindrome");
            }
            else
            {
                WriteLine($"This is not a palindrome");
            }

            Repeat(ref userInput);
        }
      static string Repeat(ref string userInput)
        {
            WriteLine($"Try again or type Exit");
            if (userInput.Equals("Exit"))
            {
              
            }
            else
            {
                WriteLine($"Enter text to check palindrome.");
                string userInput = ReadLine();
                string backwards = Check(ref userInput);
                WriteLine($"{backwards}");
                if (userInput.Equals(backwards))
                {
                    WriteLine($"This is a palindrome");
                }
                else
                {
                    WriteLine($"This is not a palindrome");
                }
            }

        }

    }
}
