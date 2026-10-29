class SmartCalculator {
    public static void Main (string[] args)
    {
        try
        {
            Console.Write("Enter two numbers x and y: ");
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter an operator +, -, *, /: ");
            char op = Convert.ToChar(Console.ReadLine());
            double result = 0;
             switch (op) {
                case '+':
                    result = x + y;
                    break;
                case '-':
                    result = x - y;
                    break;
                case '*':
                    result = x * y;
                    break;
                case '/':
                    result = x / y;
                    break;
                default:
                    Console.WriteLine("Invalid operator!");
                    break;
            }  
            Console.Write("Result: "+result);  
        }
        catch (DivideByZeroException) {
            Console.WriteLine("Error! Cannot divide by zero!");
        }
        catch (FormatException) {
            Console.WriteLine("Invalid input! Please enter valid numbers and an operator.");
        }
        catch (OverflowException) {
            Console.WriteLine("Error! The number is too large or too small.");
        }
    }
}