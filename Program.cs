using System;

namespace Method_Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayName();

        }

        static void DisplayName()
        {
            Console.WriteLine("May I have your name?");
            string sName = Console.ReadLine();
            WelcomeMessage(sName);
        }

        static void WelcomeMessage(string strName)
        {
            Console.WriteLine("Hello... Jon Snow... eehhh I mean " + strName + "! \nWelcome to my world!");
        }
    }
}
