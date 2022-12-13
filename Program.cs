//Set the console to white and text to black
Console.BackgroundColor = ConsoleColor.White;
Console.Clear();
Console.ForegroundColor = ConsoleColor.Black;

Console.WriteLine("Roll the dice! A dice rolling application for your game nights!");
Console.WriteLine("\nThe dice used for this application has 6 sides, with chances to roll results from 1 to 6.");
Console.WriteLine("Press any key to roll the dice! Good luck on your roll!");
ConsoleKey keyPressed = Console.ReadKey().Key;
while (keyPressed != ConsoleKey.Escape)
{
    Console.Clear();
    int randomDiceRoll = 0;
    Random random = new Random();
    randomDiceRoll = random.Next(1, 7);
    Console.WriteLine("You rolled the number " + randomDiceRoll);
    Console.WriteLine("\nPress any key to reroll! Press ESC to stop the application");
    keyPressed = Console.ReadKey().Key;
}

