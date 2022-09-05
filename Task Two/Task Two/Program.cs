// See https://aka.ms/new-console-template for more information
//Task Two : Write a guessing game where the user has to guess a secret number. After every guess, the program
//tells the user whether their number was too large or too small. At the end, the number of tries needed should be
//printed. It counts only as one try if they input the same number multiple times, consecutively.

/*
 A random number from 1 to 50 is generated which the user has to guess correctly.
 There is no maximum number of tries required. At the end, it states the number of tries used. 
 I couldn't figure out how to make it count as one try if they input the same number multiple times, consecutively. :(
*/


Console.WriteLine("This is a random number guessing game.\nTry to guess the correct number. You have unlimited tries.\nLet's go!");

Random number = new Random();
int myNumber = number.Next(1, 51);

int tries = 1;

while (true)
{
    Console.Write("Enter a number between 1 and 50: ");
    int userGuess = Convert.ToInt32(Console.ReadLine());

    if ((userGuess <= 0) || (userGuess > 50))
    {
        Console.WriteLine("Number is out of range. Try again");
        tries++;
        continue;
    }
    else if (userGuess > myNumber)
    {
        Console.WriteLine("Number is too big. Try again.");
        tries++;
        continue;
    }
    else if (userGuess < myNumber)
    {
        Console.WriteLine("Number is too small. Try again");
        tries++;
        continue;
    }
    else
    {
        Console.WriteLine($"{userGuess} is correct!");
        Console.WriteLine("It took {0} {1} to guess it right.", tries, tries == 1 ? "try" : "tries");
        break;
    }
}
