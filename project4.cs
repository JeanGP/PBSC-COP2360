using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

    Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        try
        {

            int num1 = Convert.ToInt32(input1);
            int num2 = Convert.ToInt32(input2);

    if (num2 == 0)
    {
            trow new DivideByZeroException("Cannot divide by zero.");
}
int result = num1 / num2;
Console.WriteLine("Result: " + result);
        }
        catch (FormatException)
        {
    Console.WriteLine("Error: Invalid input format. Please enter valid integers");
}
    catch (DivideByZeroException ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
    catch (Exception ex)
    {
        Console.WriteLine("An unexpected error occured: " + ex.Message);
    }
    Console.Readkey(); // keep console open until a key is pressed
    }

} 