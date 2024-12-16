// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System;
class Program
{
    static void Main()
    {
        string[] answers = { "Zihuatanejo", "Hope", "Freedom", "Justice", "Shawshank" }; // new line/updated
        Random random = new Random(); // new line
        string secretWord = answers[random.Next(answers.Length)]; // new line
        char[] guessedWord = new string('_', secretWord.Length).ToCharArray();
        int attemptsCapacity = 10;
        Console.WriteLine("Hello!");
        Console.WriteLine("Welcome to the Gallows game!");
        Console.WriteLine("You have incredible option to try to guess the encrepted word!");
        Console.WriteLine("Today we will be talking about the The Shawshank Redemption movie.");
        Console.WriteLine("Try to guess one of these words: Zihuatanejo, Hope, Freedom, Justice, Shawshank");
        Console.WriteLine();
        //Console.WriteLine("QUESTION: What is the name of the lake mentioned in Andy's note to Red, where he invites him to meet after their time in Shawshank, describing it as a peaceful place in Mexico where he dreams of starting a new life?");
        //Console.WriteLine();
        Console.WriteLine($"The number of letters in the word is equil to: {secretWord.Length}");
        Console.WriteLine();
        Console.WriteLine($"The number of possible attempts: {attemptsCapacity}");
        Console.WriteLine("Note: The first letter of the word is capital!");
        while (attemptsCapacity > 0 && new string(guessedWord) != secretWord)
        {
            Console.WriteLine("Please enter your letter: ");
            char guess = Console.ReadKey().KeyChar;
            Console.WriteLine();

            if (secretWord.Contains(guess))
            {
                Console.WriteLine("Congratulations, the letter is present in the word!");
                for (int i = 0; i < guessedWord.Length; i++)
                {
                    if (secretWord[i] == guess)
                        guessedWord[i] = guess;
                }
                Console.WriteLine($"Current stage of the word: {new string(guessedWord)}");
                if (new string(guessedWord) == secretWord)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Congratulations you have guessed the wordd! The secret word is {secretWord}");
                    Console.ResetColor();
                    return;
                }
            }
            else
            {
                attemptsCapacity--;
                Console.WriteLine($"This letter is NOT presented in the word. You still have: {attemptsCapacity}.");
            }
        }
        if (new string(guessedWord) == secretWord)
        {
            /* Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"Encrypted word: {secretWord}");
            Console.ResetColor(); */
            Console.Write("Congratulations you have guessed the wordd! The secret word is ");
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(secretWord);
            Console.ResetColor();
        }
        else
        {
            Console.WriteLine("Unfortunately you have lost. The word was ");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(secretWord);
            Console.ResetColor();
        }
    }
}
