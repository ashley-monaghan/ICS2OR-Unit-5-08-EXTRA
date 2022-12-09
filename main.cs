using System;
class Program
{
    public static void Main(string[] args)
    {
        System.Random random = new System.Random();
        // This function accepts user input
        double diviser;
        double secondNumber;
        Console.Write("Enter two numbers to find the diviser!");
        Console.WriteLine("");
        Console.Write("Enter the first number: ");
        diviser = Convert.ToDouble(Console.ReadLine());
        Console.Write("Enter the second number: ");
        secondNumber = Convert.ToDouble(Console.ReadLine());

        double counter = 0;

        while (diviser >= Math.Abs(secondNumber))
        {
        diviser = diviser - Math.Abs(secondNumber
        );
        counter++;
        };

        Console.WriteLine("The answer is: " + counter + " R" + diviser + "!");

        Console.WriteLine("");
        Console.Write("/Done");
    }
}