/*Write an if statement that examines two integer variables 
 * and exchanges their values if the first one is greater 
 * than the second one.*/


using System;


class TwoIntegers
{
    static void Main()
    {
        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        if (firstInt > secondInt)
        {
            secondInt = firstInt;
        }
        Console.WriteLine("The bigger number is {0}.", secondInt);
    }
}
