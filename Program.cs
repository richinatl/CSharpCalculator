// See https://aka.ms/new-console-template for more information
// Console application
// When it starts it prints
// Hello!
// Input the first number
// Then the user will input a number
// Then the program wil print
// Input the second number
// Then the user will enter the number
// Next the program will ask
// What do you want to do with these numbers
// [A]dd
// [S]ubtract
// [M]ultiply
// [D]ivide
// Then the app will handle the input and print result
// Next the app should say press any key to exit
// Program should exit on keystrike


using System.ComponentModel;

Console.WriteLine("Hello!");
Console.WriteLine("Input the first number:");
string firstInput = Console.ReadLine();
int firstNumber = int.Parse(firstInput);
Console.WriteLine("Input the second number:");
string secondInput = Console.ReadLine();
int secondNumber = int.Parse(secondInput);

Console.WriteLine("What do you want to do with the numbers");
Console.WriteLine("[A]dd");
Console.WriteLine("[S]ubtract");
Console.WriteLine("[M]ultiply");
Console.WriteLine("[D]ivide");
Console.WriteLine("[E]xit");
Console.WriteLine("");
Console.WriteLine("");


string userInput = Console.ReadLine();
string userChoice = userInput.ToUpper();


if (userChoice.StartsWith("A"))
{
    CalcAdd();
}

else if (userChoice.StartsWith("S"))
{
    CalcSubtract();
}

else if (userChoice.StartsWith("M"))
{
    CalcMultiply();
}

else if (userChoice.StartsWith("D"))
{
    CalcDivide();
}

else if (userChoice.StartsWith("E"))
{
    exitCalc();
}

else
{
    Console.WriteLine("Please enter a vaid letter ");
}


void CalcAdd()
{
    int sum = firstNumber + secondNumber;
    Console.WriteLine(sum);
}

void CalcSubtract()
{
    int sum = firstNumber - secondNumber;
    Console.WriteLine(sum);
}

void CalcMultiply()
{
    int sum = firstNumber * secondNumber;
    Console.WriteLine(sum);
}

void CalcDivide()
{
    int sum = firstNumber / secondNumber;
    Console.WriteLine(sum);
}


void exitCalc()
{
    Console.ReadKey();
}