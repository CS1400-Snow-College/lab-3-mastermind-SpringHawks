//Annette Hawks Due 6/23/2025 CS-1405
//Mastermind Lab #4
//1. comment Add a comment to the top of your source code with your name, the date, and the name of the lab. (Remember to run, add, and commit your code.)
//
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
//3. basic guessing Make a string variable holding your hard-coded secret and then repeatedly ask the user for a guess until the guess matches the secret. (hint: do -while might work well here since you will ask for at least one guess.) (Remember to run, add, and commit.)

string secret = "afdbc";
string guess;
int countGuess = 0;

// making sure people have to make a valid guess 
//4. number of guesses Keep track of the number of guesses and report it to the user during each turn and after the secret has been guessed. (Remember to run, add, and commit.)

bool IsValidGuess(string input)
{
    if (input.Length != 5) return false;


    foreach (char c in input)
    {
        if (c < 'a' || c > 'g')
            return false;
    }

    // make sure each letter is only used once.
    for (int i = 0; i < input.Length; i++)
    {
        for (int j = i + 1; j < input.Length; j++)
        {
            if (input[i] == input[j])
                return false;
        }
    }

    return true;
}

do
{
    countGuess++;
    Console.Write($"Guess #{countGuess}: Please guess a string of 5 letters. a-g.");
    guess = Console.ReadLine();

    if (!IsValidGuess(guess))
    {
        Console.WriteLine("I am afraid that is not right. Try again.");
        continue;
    }

    int rightPositions = 0;
    int rightLettersWrongPosition = 0;

    for (int i = 0; i < secret.Length; i++)
    {
        if (guess[i] == secret[i])
            rightPositions++;
    }

    for (int i = 0; i < guess.Length; i++)
    {
        if (guess[i] != secret[i])
        {
            for (int j = 0; j < secret.Length; j++)
            {
                if (guess[i] == secret[j] && i != j)
                {
                    rightLettersWrongPosition++;
                    break;
                }
            }
        }
    }

    if (guess != secret)
    {
        Console.WriteLine($"  - {rightPositions} in the right positions");
        Console.WriteLine($"  - {rightLettersWrongPosition} in the wrong positions");
        Console.WriteLine($"I am afraid that is not right {playerName},please try again!");
    }

} while (guess != secret);


Console.WriteLine($"That is the right answer {playerName}! You guessed {secret} in {countGuess} guesses.");
//I really like Visual Studio better than VS code. 