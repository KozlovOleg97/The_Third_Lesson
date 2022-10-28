﻿using The_Third_Lesson;

bool endApp = false;
Console.WriteLine("Console Calculator in C#\r");
Console.WriteLine("------------------------\n");

while (!endApp)
{
    string numInput1 = "";
    string numInput2 = "";
    double result = 0;

    Console.Write("Type a number, and then press Enter: ");
    numInput1 = Console.ReadLine();

    double cleanNum1 = 0;
    while (!double.TryParse(numInput1, out cleanNum1))
    {
        Console.Write("This is not valid input. Please Enter an integer value ");
        numInput1 = Console.ReadLine();
    }

    Console.Write("Type another number, and then press Enter: ");
    numInput2 = Console.ReadLine();

    double cleanNum2 = 0;
    while (!double.TryParse(numInput2, out cleanNum2))
    {
        Console.Write("This is not valid input. Please enter an integer value ");
        numInput2 = Console.ReadLine();
    }


    Console.WriteLine("Choose an operator from the following list: ");
    Console.WriteLine("\ta - Add");
    Console.WriteLine("\ts - Substract");
    Console.WriteLine("\tm - Multiply");
    Console.WriteLine("\td - Divide");
    Console.WriteLine("Your Option? ");

    string operators = Console.ReadLine();

    try
    {
        result = Calculator.DoOperation(cleanNum1, cleanNum2, operators);
        if (double.IsNaN(result))
        {
            Console.WriteLine("This operation will result in a mathematical error.\n");
        }
        else
            Console.WriteLine("Your result: {0:0.##}\n", result);
    }
    catch (Exception error)
    {
        Console.WriteLine("Oh no! An exception occured trying to do the math. \n - Details: " + error.Message);
    }

    Console.WriteLine("----------------------\n");

    Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
    if (Console.ReadLine() == "n") endApp = true;

    Console.WriteLine("\n");
}
return;