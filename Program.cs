// See https://aka.ms/new-console-template for more information
//using a do-while loop which will run this code once and then
//check the condition
do
{
    double num1 = 0, num2 = 0, result = 0;
    Console.WriteLine("-------------------");
    Console.WriteLine("Calculator Program");
    Console.WriteLine("-------------------");
    Console.Write("Enter number 1: ");
    num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter number 2: ");
    num2 = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Enter an option!");
    Console.WriteLine("\t+ : Add");
    Console.WriteLine("\t- : Subtract");
    Console.WriteLine("\t* : Multiply");
    Console.WriteLine("\t/ : Divide");
    switch (Console.ReadLine())
    {
        case "+":
            result = num1 + num2;
            Console.WriteLine($"Your result: {num1} + {num2} = " + result);
            break;
        case "-":
            result = num1 - num2;
            Console.WriteLine($"Your result: {num1} - {num2} = " + result);
            break;
        case "*":
            result = num1 * num2;
            Console.WriteLine($"Your result: {num1} * {num2} = " + result);
            break;
        case "/":
            result = num1 / num2;
            Console.WriteLine($"Your result: {num1} / {num2} = " + result);
            break;
        default:
            Console.WriteLine("That was not a valid option!");
            break;
    }
    Console.WriteLine("Would you like to continue? (Y/N)");
} while (Console.ReadLine().ToUpper() == "Y");
Console.WriteLine("Bye");