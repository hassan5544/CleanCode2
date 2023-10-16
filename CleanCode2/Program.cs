using CleanCode2;
using System;

class Program
{
    static void Main(string[] args)
    {
        int UserInput = UserInteraction.GetUserInput("Enter Number: ");

        int result = Calculation.CalculateSquare(UserInput);

        UserInteraction.DisplayOutput(result, "The square of the number is: ");
    }


}