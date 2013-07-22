/*Write a program that, depending on the user's choice inputs int, double or string variable. 
 * If the variable is integer or double, increases it with 1. If the variable is string,
 * appends "*" at its end. The program must show the value of that variable as a console 
 * output. Use switch statement.*/

using System;
class VariableEntry
{
    static void Main()
    {
        string someString = "";
        int someInteger = 0;
        double someDouble = 0;
        Console.WriteLine("Please, write:\n1 for interger;\n2 double;\n3 for string");
        int usersChoice = int.Parse(Console.ReadLine());
        if (usersChoice == 1)
        {
            Console.WriteLine("Enter Integer");
        }
        else if (usersChoice == 2)
        {
            Console.WriteLine("Enter double");
        }
        else if (usersChoice == 3)
        {
            Console.WriteLine("Enter string");
        }
        else
        {
            Console.WriteLine("Restart and try again :(");
            System.Threading.Thread.Sleep(5000);
            System.Environment.Exit(-1);
        }

        if (usersChoice == 1)
        {
            someInteger = int.Parse(Console.ReadLine());
        }
        if (usersChoice == 2)
        {
            someDouble = double.Parse(Console.ReadLine());
        }
        if (usersChoice == 3)
        {
            someString = Console.ReadLine();
        }
        switch (usersChoice)
        {
            case 1:
                Console.WriteLine(++someInteger);
                break;
            case 2:                
                Console.WriteLine(++someDouble);
                break;
            case 3: 
                Console.WriteLine(someString+"*");
                break;

        }        
    }
}
