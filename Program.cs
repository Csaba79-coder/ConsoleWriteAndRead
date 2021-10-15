using System;

namespace ConsoleWriteAndRead
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            // stops the program till not press enter!!!
            Console.ReadLine();
            
            // the console window pops up for a second and program stops! ...
            Console.WriteLine("This program is shutting down!");

            Console.WriteLine("Hello, hello World");
            // this stops the window till pressing any button on keyboard ...
            Console.ReadKey();

            Console.WriteLine("Hello World, new way to stop the program! How to make the program to sleep ...");
            // this requires millisecond --> 1000 milliseconds == 1 sec
            System.Threading.Thread.Sleep(3000);

            Console.WriteLine("Press enter to contiue ...");
            Console.ReadLine();

            Console.WriteLine("Press any key to continue ...");
            Console.ReadKey();

            Console.WriteLine("Let me tell you a good joke! ...");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("How does NASA organize a party?");
            System.Threading.Thread.Sleep(3000);
            Console.WriteLine("They planet!");
            Console.ReadKey();
        }
    }
}
