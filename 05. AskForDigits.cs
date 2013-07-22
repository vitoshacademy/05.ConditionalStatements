/*Write program that asks for a digit and depending on the input shows the name of that digit (in English) using a switch statement.*/

using System;
class AskForDigit
{
    static void Main()
    {
        Console.WriteLine("Please give a denary digit:");
        int digit = int.Parse(Console.ReadLine());  

        switch (digit)
        {
            case 1: Console.WriteLine("ONE");
                break;
            case 2: Console.WriteLine("TWO");
                break;
            case 3: Console.WriteLine("THREE");
                break;
            case 4: Console.WriteLine("FOUR");
                break;
            case 5: Console.WriteLine("FIVE");
                break;
            case 6: Console.WriteLine("SIX");
                break;
            case 7: Console.WriteLine("SEVEN");
                break;
            case 8: Console.WriteLine("EIGHT");
                break;
            case 9: Console.WriteLine("NINE");
                break;
            case 0: Console.WriteLine("ZERO");
                break;
            default: Console.WriteLine("You should have given a digit. In the denary system the digits are from 0 to 9.\n Now restart and start the program again");
                System.Threading.Thread.Sleep(5000);
                System.Environment.Exit(-1);
                break;
            Console.WriteLine(digit);
        }
    }
}

