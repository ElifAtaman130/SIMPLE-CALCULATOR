Console.WriteLine("SIMPLE CALCULATOR");
Console.WriteLine("Select the operation you want to perform.");
Console.WriteLine("(+,-,*,/)");
string choice = Console.ReadLine();
Console.WriteLine("Enter the first number:");
if (!int.TryParse(Console.ReadLine(), out int number1))
{
    Console.WriteLine("Invalid input.");
    return;
}
Console.WriteLine("Enter the second number:");
if(!int.TryParse(Console.ReadLine(),out int number2))
{
    Console.WriteLine("Invalid input.");
    return;
}
switch (choice)
{
    case "+":
        Console.WriteLine("Result: " + (number1 + number2)); //Addition
        break;
    case "-":
        Console.WriteLine("Result: " + (number1 - number2)); //Subtraction
        break;
    case "*":
        Console.WriteLine("Result: " + (number1 * number2)); //Multiplication
        break;
    case "/":
        if (number2 == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return;
        }
        Console.WriteLine("Result: " + (number1 / number2)); //Division
        break;
    default:
        Console.WriteLine("Please enter a valid operation"); //Invalid selection
        break;
}
Console.ReadKey();


