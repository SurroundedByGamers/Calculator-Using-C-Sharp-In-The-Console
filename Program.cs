Console.ForegroundColor = ConsoleColor.DarkBlue;
Console.WriteLine("A SHARP CALCULATOR");
Console.ForegroundColor = ConsoleColor.White;

Console.Write("What Is The First Number - ");
double number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("What Is The Operator Of The Operation You Wanna Do? (+, -, *, /) - ");
String mathOperator = Console.ReadLine();

Console.Write("What Is The Second Number - ");
double number2 = Convert.ToInt32(Console.ReadLine());

switch (mathOperator)
{
    case "+":
        Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
        break;
    case "-":
        Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
        break;
    case "*":
        Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));
        break;
    case "/":
        Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));
        break;
    default:
        Console.WriteLine("Hmmm.. I Did Not Know About The Operator '" + mathOperator + "'");
        break;
}