using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hey There! What's your name?");
           string name = System.Console.ReadLine(); 
           foreach(char letter in name.ToLower())
           {
               if (Char.IsLetter(letter))
               {
                   string mnemonic = "halfnorsemix";
                   string article = "a ";

                   if (mnemonic.Contains(letter))
                   {
                       article = "an";
                   }

                   System.Console.WriteLine("Give me " + article + " ... " + letter);
               }
                 
            }
            System.Console.WriteLine( name.ToUpper() + " is AWESOME!");
            System.Console.WriteLine("Hey, " + name + " when's your birthday? (MM/DD)");
            string bday = System.Console.ReadLine();
            DateTime input = Convert.ToDateTime(bday);

            if (input < DateTime.Today)
            {
                input = input.AddYears(1);
              //  System.Console.WriteLine(input);
                // Difference in days, hours, and minutes.
                TimeSpan ts = input - DateTime.Today;
                // Difference in days.
                int differenceInDays = ts.Days;

                Console.WriteLine("Your birthday is " + differenceInDays + " days away!");
            }
            else
            {
                // Difference in days, hours, and minutes.
                TimeSpan ts = input - DateTime.Today;
                // Difference in days.
                int differenceInDays = ts.Days;

                Console.WriteLine("Your birthday is " + differenceInDays + " days away!");

            }
           
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
           }
          
      
        }
    }

