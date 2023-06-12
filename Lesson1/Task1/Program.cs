// Console.WriteLine("We entered a number " + number + "!");
// Console.WriteLine($"We entered a number {number}!"); // Display of the entered munber on the screen/terminal

// int square = number * number;  // The formula for the square of the number
// Console.WriteLine($"Square of {number} equals {square}"); // Display of the result on the screen/terminal


Console.Write("Enter number #1: ");  // Display the invitation on the terminal/screen
string inputedString1 = Console.ReadLine(); // User's entry
Console.Write("Enter number #2: ");  // Display the invitation on the terminal/screen
string inputedString2 = Console.ReadLine(); // User's entry
int number1 = Convert.ToInt32(inputedString1); // The string becames a number
int number2 = Convert.ToInt32(inputedString2); // The string becames a number

if (number2 ==number1 * number1)
{
    Console.WriteLine($"THe number {number2} is a square of {number1}");
}
else
{
    Console.WriteLine($"The number {number2} is not a square of {number1}");
}


