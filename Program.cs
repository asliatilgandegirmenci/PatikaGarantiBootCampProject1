using System;

class MainClass
{

    static int FirstFactorial(int num)
    {
        // code goes here  
        if (num <= 1)
        {
            return 1;
        }
        else
        {
            return num * FirstFactorial(num - 1);
        }
    }

    static void Main()
    {
        // keep this function call here
        int num = 4;
        int result = FirstFactorial(num);
        Console.WriteLine("The factorial " + num + " is " + result);
    }
}