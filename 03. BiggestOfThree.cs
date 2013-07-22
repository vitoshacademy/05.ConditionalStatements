/*Write a program that finds the biggest of three integers using nested if statements.*/

using System;
class BiggestOfThree
{
    static void Main()
    {
        int firstInt = int.Parse(Console.ReadLine());
        int secondInt = int.Parse(Console.ReadLine());
        int thirdInt = int.Parse(Console.ReadLine());
        if (firstInt>secondInt)
        {
            secondInt = firstInt;
        }
        else if (secondInt>thirdInt)
      {
                thirdInt = secondInt;
	    }
        if (thirdInt < firstInt)
        {
            thirdInt = firstInt;
        }
        Console.WriteLine("The biggest number is {0}", thirdInt);
    }
}
