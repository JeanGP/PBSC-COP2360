using System;
public class BooleanExample
{
    public static void Main(string[] args)
    {
        bool isTrue = true;
        bool isFalse = false;
        Console.WriteLine("The value of isTrue is: " + isTrue);
        Console.WriteLine("The vlue of isFalse is: " + isFalse);

        // Using boolean in conditional statement
        if (isTrue)
        {
            Console.WriteLine("This will execute because isTrue is true.");
        }
        if (!isFalse)
        {
            Console.Write("This will execute because isFalse.");
        }
    }
}