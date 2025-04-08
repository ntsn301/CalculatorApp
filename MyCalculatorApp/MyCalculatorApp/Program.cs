using CalculatorLib;

namespace CalculatorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine("Calculator App");
            Console.WriteLine($"2 + 3 = {calc.Add(2, 3)}");
            Console.WriteLine($"5 - 2 = {calc.Subtract(5, 2)}");
            Console.WriteLine($"4 * 3 = {calc.Multiply(4, 3)}");
            Console.WriteLine($"8 / 2 = {calc.Divide(8, 2)}");
        }
    }
}