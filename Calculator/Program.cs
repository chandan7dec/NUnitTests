// See https://aka.ms/new-console-template for more information
using Sparky;
using System.Linq.Expressions;
using System.Xml.Linq;

Calculate calculate = new Calculate();
Console.WriteLine("Enter first No : ");
double x = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter second No : ");
double y = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter operator : ");
string expression = Console.ReadLine();

double? result = 0.0;
switch (expression)
{
    case "X":
        // code block
        result = calculate.multiply(x, y);
        break;
    case "/":
        // code block
        result = calculate.Divide(x, y);
        break;

    case "+":
        result = calculate.Add(x, y);
        break;

    case "-":
        result = calculate.Substract(x, y);
        break;

    default:
        result = null;
        break;
}

Console.WriteLine("@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
Console.WriteLine("Result is : {0}", result);