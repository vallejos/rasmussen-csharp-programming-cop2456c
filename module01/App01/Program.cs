using System;

class App01
{
    static void Main(string[] args)
    {
        ReadNames();
    }

    private static void ReadNames()
    {
        Console.WriteLine("Hi, please enter your name: ");
        string str01 = Console.ReadLine();

        Console.WriteLine("Hello " + str01 + "!");

        while (true)
        {
            Console.WriteLine("Enter a name: ");
            str01 = Console.ReadLine();

            if (str01 == "")
            {
                Console.WriteLine("See you again soon!");
                break;
            }

            Console.WriteLine("Hello " + str01 + "!");
        }
    }
}
