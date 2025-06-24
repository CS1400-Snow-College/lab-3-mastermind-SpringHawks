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

//Just making a note here that I did 5&6. But I also turned this in before midnight completed. This was an afterthought. 
//5 correct positions Add a nested loop that counts the number positions in the guess where the character at that position in the guess matches the character at that position in the secret. Report that count to the user. For now, you can assume that the guess is of the same length as the secret. (hints: remember that you can get the length of a string s with s.Length and you can get the next character after skipping the first i characters with s[i], so a for-loop can conveniently loop over all positions from 0 up to the length and count the number of positions with matching characters.) (Remember to run, add, and commit.)
// 6 .correct letters at wrong positions Within the main loop body, create a variable that will hold the number of letters that are out of place in the guess. Modify the body of the nested loop so that if the character at a given position in the guess does not match the character at the same position in the secret, then you will check if any of the positions in the secret match that letter (hint: this will be yet another level of nesting; a for loop would work nicely since you know to simply look at every index in the secret). (Remember to run, add, and commit.)