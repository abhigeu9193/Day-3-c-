// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using System;
class geometry2
{
    private static int axisCheck;

    static void Main(string[] args)
    {
        int x = 0, y = 0;


        Random random = new Random();
        int xaxisCheck = random.Next(0, 2);
        int yaxisCheck = random.Next(0, 2);
        Console.WriteLine(random);
        if (xaxisCheck == yaxisCheck)
        {
            Console.WriteLine("true");
        }
        else
        {
            Console.WriteLine("false");
        }



    }
}
