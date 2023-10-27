namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        do
        {
            double num1 = 0;
            double num2 = 0;
            double result = 0;

            Console.WriteLine("-------------------");
            Console.WriteLine("calculator program");
            Console.WriteLine("-------------------");

            Console.Write("enter number 1: ");
            num1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter number 2: ");
            num2 = Convert.ToDouble(Console.ReadLine());


            Console.WriteLine("+ = add");
            Console.WriteLine("- = substract");
            Console.WriteLine("* = multiply");
            Console.WriteLine("/ : divide");
            Console.Write("enter an option: ");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"your result: {num1} + {num2} = " + result);
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"your result: {num1} - {num2} = " + result);
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"your result: {num1} * {num2} = " + result);
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"your result: {num1} / {num2} = " + result);
                    break;
                default:
                    Console.WriteLine("that was not a valid option");
                    break;

            }
            Console.WriteLine("would you like to continue? yes or no");
        }
        
        while (Console.ReadLine() == "yes");
        Console.WriteLine("see you again <3");
        Console.ReadKey();

    }
}
