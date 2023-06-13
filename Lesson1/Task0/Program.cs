Console.Write("Enter a number => ");  // Display the invitation on the terminal/screen
string inputedString = Console.ReadLine(); // User's entry
int number = Convert.ToInt32(inputedString); // The string becames a number
// Console.WriteLine("We entered a number " + number + "!");
Console.WriteLine($"We entered a number {number}!"); // Display of the entered munber on the screen/terminal

int square = number * number;  // The formula for the square of the number
Console.WriteLine($"Square of {number} equals {square}"); // Display of the result on the screen/terminal
Console.WriteLine($"Thanks!");