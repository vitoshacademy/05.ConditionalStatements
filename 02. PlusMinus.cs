//BAD Example of a code! :)

/*Write a program that shows the sign (+ or -) of the 
product of three real numbers without calculating it. 
Use a sequence of if statements.*/
using System;

class PlusMinus
{
    static void Main()
    {
        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        int thirdInt = int.Parse(Console.ReadLine());

        int countZeroes = 0;
        int countMinus = 0;

        if (firstInt == 0)
        {
            countZeroes++;
        }
        if (firstInt < 0)
        {
            countMinus++;
        }
        if (secondInt == 0)
        {
            countZeroes++;
        }
        if (secondInt < 0)
        {
            countMinus++;
        }
        if (thirdInt == 0)
        {
            countZeroes++;
        }
        if (thirdInt < 0)
        {
            countMinus++;
        }
        if ((countMinus == 0 && countZeroes == 0) || (countMinus == 2 && countZeroes == 0))
        {
            Console.WriteLine("The product is positive");
        }
        else if (countZeroes > 0)
        {
            Console.WriteLine("The product is ZERO");
        }
        else
        {
            Console.WriteLine("The product is negative");
        }
    }
}
