using CalculatorLibrary;
using System.Collections;
using System.Collections.Generic;
using The_Third_Lesson;

double firstValue = 0;
double secondValue = 0;
string sign = "+";
double result = 0;
string instance;
Queue FiveLastTask = new Queue(5);
bool end = false;

while (!end)
{
    Console.WriteLine("If you want to solve the Next task, click 'N'\r\n" +
        "If you want to see the Last five decisions, click 'L'\r\n" +
        "If you want to Exit, click 'E'");
    string WhatsNext = Console.ReadLine();
    switch (WhatsNext)
    {
        case "N":
            InputData();
            Solution(firstValue, secondValue, sign);
            Console.WriteLine(OutputData(firstValue, secondValue, sign));
            Console.WriteLine();
            break;
        case "L":
            foreach (string task in FiveLastTask)
            {
                Console.WriteLine(task);
            }
            Console.WriteLine();
            break;
        case "E":
            end = true;
            break;
        default:
            Console.WriteLine("Something wrong");
            Console.WriteLine();
            break;

            void InputData()
            {
                string a; //variable to store input values
                bool b = true; //variable for loop operation
                while (b) // first value check
                {
                    Console.WriteLine("Input first value:");
                    a = Console.ReadLine();
                    if (double.TryParse(a, out firstValue))
                    {
                        b = false;
                    }
                    else
                    {
                        Console.WriteLine("Please, enter the number");
                    }
                }
                b = true;
                while (b) // second value check
                {
                    Console.WriteLine("Input second value:");
                    a = Console.ReadLine();
                    if (double.TryParse(a, out secondValue))
                    {
                        b = false;
                    }
                    else
                    {
                        Console.WriteLine("Please, enter the number");
                    }
                }
                b = true;
                while (b) // sign check
                {
                    Console.WriteLine("Input '+', '-', '*', or '/'");
                    a = Console.ReadLine();
                    if (a == "+" || a == "-" || a == "*" || a == "/")
                    {
                        sign = a;
                        b = false;
                    }
                    else
                    {
                        Console.WriteLine("Please, enter '+', '-', '*', or '/'");
                    }
                }
            }

            double Solution(double firstValue, double secondValue, string sign)
            {
                switch (sign)
                {
                    case "+":
                        return result = firstValue + secondValue;
                    case "-":
                        return result = firstValue - secondValue;
                    case "*":
                        return result = firstValue * secondValue;
                    case "/":
                        return result = firstValue / secondValue;
                }
                return result;
            }

            string OutputData(double firstValue, double secondValue, string sign)
            {
                instance = $"{firstValue} {sign} {secondValue} = {result}";
                FiveLastTask.Enqueue(instance);
                if (FiveLastTask.Count > 5)
                {
                    FiveLastTask.Dequeue();
                }
                return instance;
            }
    }
}






































//// new realization with helping Enum

// DoOperation(5, 5, MainOperation.Add);



//void DoOperation(double num1, double num2, MainOperation operation)
//{
//    double result;


//    switch (operation)
//    {
//        case MainOperation.Add:
//            result = num1 + num2;
//            Console.Write($"Input first enter: {num1}");
//            Console.Write(num2);
//            Console.WriteLine($"{num1}+{num2}={result}");
//            break;

//        case MainOperation.Subtract:
//            result = num1 - num2;
//            Console.WriteLine("Output: " + result);
//            break;
//        case MainOperation.Multiply:
//            result = num1 * num2;
//            Console.WriteLine("Output: " + result);
//            break;
//        case MainOperation.Divide:
//            result = num1 / num2;
//            Console.WriteLine("Output: " + result);
//            break;
//    }





//double result = operation switch
//{

//    MainOperation.Add => num1 + num2,
//    MainOperation.Subtract => num1 - num2,
//    MainOperation.Multiply => num1 * num2,
//    MainOperation.Divide => num1 / num2

//};


//}

//enum MainOperation
//{
//    Add,
//    Subtract,
//    Multiply,
//    Divide
//}














//bool endApp = false;
//Console.WriteLine("Console Calculator in C#\r");
//Console.WriteLine("------------------------\n");

//Calculator calculator = new Calculator();

//while (!endApp)
//{
//    string numInput1 = "";
//    string numInput2 = "";
//    double result = 0;

//    Console.Write("Type a number, and then press Enter: ");
//    numInput1 = Console.ReadLine();

//    double cleanNum1 = 0;
//    while (!double.TryParse(numInput1, out cleanNum1))
//    {
//        Console.Write("This is not valid input. Please Enter an integer value ");
//        numInput1 = Console.ReadLine();
//    }

//    Console.Write("Type another number, and then press Enter: ");
//    numInput2 = Console.ReadLine();

//    double cleanNum2 = 0;
//    while (!double.TryParse(numInput2, out cleanNum2))
//    {
//        Console.Write("This is not valid input. Please enter an integer value ");
//        numInput2 = Console.ReadLine();
//    }


//    Console.WriteLine("Choose an operator from the following list: ");
//    Console.WriteLine("\ta - Add");
//    Console.WriteLine("\ts - Substract");
//    Console.WriteLine("\tm - Multiply");
//    Console.WriteLine("\td - Divide");
//    Console.WriteLine("Your Option? ");

//    string operators = Console.ReadLine();

//    try
//    {
//        result = calculator.DoOperation(cleanNum1, cleanNum2, operators);
//        if (double.IsNaN(result))
//        {
//            Console.WriteLine("This operation will result in a mathematical error.\n");
//        }
//        else
//            Console.WriteLine("Your result: {0:0.##}\n", result);
//    }
//    catch (Exception error)
//    {
//        Console.WriteLine("Oh no! An exception occured trying to do the math. \n - Details: " + error.Message);
//    }

//    Console.WriteLine("----------------------\n");

//    Console.Write("Press 'n' and Enter to close the app, or press any other key and Enter to continue: ");
//    if (Console.ReadLine() == "n") endApp = true;

//    Console.WriteLine("\n");
//}

//calculator.Finish();

//return;
