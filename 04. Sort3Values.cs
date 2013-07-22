/*Sort 3 real values in descending order using nested if statements.*/


using System;
class Sort3Values
{
    static void Main()
    {
        int firstInt = int.Parse(Console.ReadLine());  
        int secondInt = int.Parse(Console.ReadLine());  
        int thirdInt = int.Parse(Console.ReadLine());  

        int a = 0;
        int b = 0;
        int c = 0;

        if ((firstInt == secondInt) || (firstInt == thirdInt) || (thirdInt == secondInt))
        {
            Console.WriteLine("\n\nThis program cannot compare equal numbers!\n Please,kindly restart the program and give three different values.");
            System.Environment.Exit(-1);
        }

        if ((firstInt>secondInt) && (firstInt > thirdInt))
        {
            a = firstInt;
            if (secondInt > thirdInt)
            {
                b = secondInt;
                c = thirdInt;
            }
            else
            {
                b = thirdInt;
                c = secondInt;
            }
        }
         if ((secondInt > firstInt) && (secondInt > thirdInt))
         {
             a = secondInt;
             if (thirdInt > firstInt)
             {
                 b = thirdInt;
                 c = firstInt;
             }
             else
             {
                 c = thirdInt;
                 b = firstInt;
             }
         }
         if ((thirdInt > secondInt) && (thirdInt > firstInt))
         {
             a = thirdInt;
                if (secondInt > firstInt)
              {
                    b = secondInt;
                    c = firstInt;		 
	            }
                else
	            {
                    c = firstInt;
                    b = secondInt;
	            }
         }
         Console.WriteLine("\n{0}\n{1}\n{2}\n", a,b,c);
        
    }
}


