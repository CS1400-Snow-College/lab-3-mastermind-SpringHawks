//Annette Hawks Due 6/23/2025 CS-1405
//Mastermind Lab #4
//1. comment Add a comment to the top of your source code with your name, the date, and the name of the lab. (Remember to run, add, and commit your code.)

//2. greeting Print a greeting and description of the program to the user. (Remember to run, add, and commit.)

Console.WriteLine("Thank you for playing Mastermind. What is your name?");

Console.Write("Player, what is your name? ");

string playerName = Console.ReadLine();

string currentPlayer = playerName;

string rules = "THE RULES\n" +
               " How quickly can you get the puzzle right?\n " +
               "1. We use the letters a, b, c, d, e, f, and g.\n" +
               "2. Each letter only appears once.\n" +
               "3. There are 5 letters used at any one time.\n" +
               "4. The player's goal will be to guess the secret string using the following clues that your program will provide to the player in response to each guess:\n" +
               " 4.a. How many of the letters in the current guess are in the secret and are in the same position as they appeared in the guess.\n" +
               " 4.b. How many of the letters in the current guess are somewhere in the secret but not in the position where they appeared in the guess.\n" +
               "5. Example: If the secret were \"afdbc\", then the string \"adbcf\" has one letter in the correct position ('a') and two letters that are correct but in the wrong positions ('d' and 'b').\n";

Console.WriteLine(rules);
