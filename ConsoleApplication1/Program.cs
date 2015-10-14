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
           System.Console.WriteLine("Hi, " + name);
          
           for (int i = 0; i < name.Length; i++)
           {
               bool article = "halfnorsemix".IndexOf(name[i].ToString(), StringComparison.InvariantCultureIgnoreCase) >= 0;
                if(article)
                {
                   System.Console.WriteLine("Give me an ... " + name[i]);
                }
                else
                {
                    System.Console.WriteLine("Give me a ..." + name[i]);
                }
                 
            }
            System.Console.WriteLine( name + " is awesome!");
            System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
           }
          
      
        }
    }

