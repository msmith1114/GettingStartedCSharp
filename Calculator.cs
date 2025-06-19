// Build a Calculator class with Add, Subtract, Multiply, and Divide methods

DemoCalc calculator = new DemoCalc("Welcome to the Demo Calculator!");
calculator.Start();


public sealed class DemoCalc
{
    // Defines initialization-only properties for immutability
    private string _welcomeMessage;

    // Constructor to initialize the welcome message
    public DemoCalc(string welcomeMessage)
    {
        _welcomeMessage = welcomeMessage;
    }

    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
    public int Divide(int a, int b)
    {
        if (b == 0) throw new DivideByZeroException("Cannot divide by zero.");
        return a / b;
    }

    public void Start()
    {
        Console.WriteLine(_welcomeMessage);

        Dictionary<string, string> supportedOperators = new()
        {
            { "+", "Addition" },
            { "-", "Subtraction" },
            { "*", "Multiplication" },
            { "/", "Division" }
        };

        while (true)
        {
            Console.WriteLine("\nSupported operations:");
            foreach (var op in supportedOperators)
            {
                Console.WriteLine(op.Key + " : " + op.Value);
            }

            Console.Write("\nEnter an operator (or 'exit' to quit): ");
            string? operatorInput = Console.ReadLine();
            if (!supportedOperators.TryGetValue(
                operatorInput,
                out var selectOperatorDescription))
            {
                Console.WriteLine("Invalid operator. Please try again.");
                continue;
            }

            Console.WriteLine($"You selected: {selectOperatorDescription}");
            Console.Write("Enter the first number: ");
            string? firstInput = Console.ReadLine();
            if (!int.TryParse(firstInput, out int firstNumber))
            {
                Console.WriteLine("Invalid number. Please try again.");
                continue;
            }
            Console.Write("Enter the second number: ");
            string? secondInput = Console.ReadLine();
            if (!int.TryParse(secondInput, out int secondNumber))
            {
                Console.WriteLine("Invalid number. Please try again.");
                continue;
            }

            int result = operatorInput switch
            {
                "+" => Add(firstNumber, secondNumber),
                "-" => Subtract(firstNumber, secondNumber),
                "*" => Multiply(firstNumber, secondNumber),
                "/" => Divide(firstNumber, secondNumber),
                _ => throw new InvalidOperationException("Unsupported operator")
            };
            Console.WriteLine($"Result: {result}");
        }
    }
}