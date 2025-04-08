namespace CalculatorLib
{
    public class Calculator
    {
        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Divide(double a, double b)
        {
            if (b == 0) throw new ArgumentException("Cannot divide by zero.");
            return a / b;
        }
        public double Power(double baseNum, double exponent) => Math.Pow(baseNum, exponent);
        public double SquareRoot(double num)
        {
            if (num < 0) throw new ArgumentException("Cannot calculate square root of a negative number.");
            return Math.Sqrt(num);
        }
    }
}