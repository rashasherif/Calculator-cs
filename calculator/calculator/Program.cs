do
{
    double num1 = 0;
    double num2 = 0;
    double result = 0;

    num1 = GetNumberFromUser("Enter num 1:");
    num2 = GetNumberFromUser("Enter num 2:"); ;

    Console.WriteLine("Enter an option: ");
    Console.WriteLine("\t* : Multible");
    Console.WriteLine("\t- : Sub");
    Console.WriteLine("\t+ : Add");
    Console.WriteLine("\t/ : Divide");

    switch (Console.ReadLine())
    {
        case "*":
            result = num1 * num2;
            Console.WriteLine($"Your result : {num1} * {num2} = " + result);
            break;

        case "+":
            result = num1 + num2;
            Console.WriteLine($"Your result : {num1} + {num2} = " + result);

            break;

        case "-":
            result = num1 - num2;
            Console.WriteLine($"Your result : {num1} - {num2} = " + result);

            break;

        case "/":
            if (num2 != 0)
            {
                result = num1 / num2;


                Console.WriteLine($"Your result : {num1} / {num2} = " + result);
            }
            else
            {
                Console.WriteLine("Invalid Division");
            }
            break;
        default:
            Console.WriteLine("This is not a valid option");
            break; 
    }
    Console.WriteLine("Would you like to continue? (Y = Yes):");
} 
while (Console.ReadLine().ToUpper()=="Y");

Console.WriteLine("Thank you!");


static double GetNumberFromUser(string message)
{
    double number;
    while (true)
    {
        Console.WriteLine(message);
        string input = Console.ReadLine();

        // Try to convert the input to a double  
        if (double.TryParse(input, out number))
        {
            return number;
        }
        else
        {
            Console.WriteLine("Error: Please enter a valid number.");
        }
    }
}