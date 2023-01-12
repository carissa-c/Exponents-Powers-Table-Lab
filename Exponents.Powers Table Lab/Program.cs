
using System;

bool runAgain = true;

do
{
    Console.WriteLine("Please Select a number!");
    int input = int.Parse(Console.ReadLine());

    Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", "Number", "Squared", "Cubed"));

    for (int num1 = 1; num1 <= input; num1++)
    {
        Console.WriteLine(String.Format("{0,15} {1,15} {2,15}", num1, num1 * num1, num1 * num1 * num1));
    }

    Console.WriteLine("Would you like to continue? y/n?");
    string response = Console.ReadLine();

    if (response == "y")
    {
        runAgain = true;
    }
    else
    {
        runAgain = false;
    }
    
 }while (runAgain);