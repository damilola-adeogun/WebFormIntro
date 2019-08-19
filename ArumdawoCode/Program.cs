using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArumdawoCode
{
    class Program: car
    {
        static void Main(string[] args)
        {
            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.





            Program p = new Program();
            p.tyres = 5;
            // Console.WriteLine(p.tyres);
            Console.Write("Please enter your nickname: "); string nickName = Console.ReadLine();
            Console.Write("Please enter your Lastname: "); string lastname = Console.ReadLine();
            Console.Write("Please enter your firstname: "); string firstName = Console.ReadLine();
            Console.Write("Please enter your othernames: "); string othernames = Console.ReadLine();
            int calculatedAge;
            p.greet(nickName, out calculatedAge, 10, firstName, lastname, othernames);
            Console.WriteLine($"You will be {calculatedAge} in 5 years time.");
            Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
