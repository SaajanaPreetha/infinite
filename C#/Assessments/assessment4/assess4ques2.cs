using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assess4ques2
{
    public delegate int CalculatorDelegate(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            CalculatorDelegate addition = Add;
            CalculatorDelegate subtraction = Subtract;
            CalculatorDelegate multiplication = Multiply;

            Console.Write("Enter a number\n ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter another number\n ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int resultAdd = PerformOperation(addition, num1, num2);
            Console.WriteLine($"Result of Addition: {resultAdd}");

            int resultSubtract = PerformOperation(subtraction, num1, num2);
            Console.WriteLine($"Result of Subtraction: {resultSubtract}");

            int resultMultiply = PerformOperation(multiplication, num1, num2);
            Console.WriteLine($"Result of Multiplication: {resultMultiply}");
            Console.ReadLine();
        }

        static int PerformOperation(CalculatorDelegate operation, int a, int b)
        {
            return operation(a, b);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }

        static int Subtract(int a, int b)
        {
            return a - b;
        }

        static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
