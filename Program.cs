using CalculatorLibrary;
using The_Third_Lesson;

double _firstValue, _secondValue;
string _DoOperation;
double output = 0;

while (true)
{
    try
    {
        Console.Write("Input the first number: ");
        _firstValue = double.Parse(Console.ReadLine());

        Console.Write("Input the second number: ");
        _secondValue = double.Parse(Console.ReadLine());

        
    }

    catch (Exception)
    {
        Console.WriteLine("You must enter a number ");
        Console.ReadLine();
        continue;

    }

    Console.WriteLine("Choose Operations: '+' '-' '*' '/' ");
    _DoOperation = Console.ReadLine();

    switch (_DoOperation)
    {
        case "+":
            Console.WriteLine($"Output: {_firstValue + _secondValue}");
            break;
        case "-":
            Console.WriteLine($"Output: {_firstValue - _secondValue}");
            break;
        case "*":
            Console.WriteLine($"Output: {_firstValue * _secondValue}");
            break;
        case "/":
            if (_secondValue == 0)
            {
                Console.WriteLine("can't divided by 0! Try Again");
                continue;
            }
            Console.WriteLine($"Output: {_firstValue / _secondValue}");
            break;

        default:
            Console.WriteLine("Incorrect input! Pls. Try Again");
            break;
    }

    AlgorithmQueue result = new AlgorithmQueue();
    result.AddToQueue(output);
    result.OutputLast5Results();
    Console.ReadLine();


    Console.Clear();
}







    //catch
    //{




//}




























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
