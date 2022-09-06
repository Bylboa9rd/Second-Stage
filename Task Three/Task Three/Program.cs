// See https://aka.ms/new-console-template for more information
//Task Three: Write a program that translates a text to Pig Latin and back. English is translated
//to Pig Latin by taking the first letter of every word, moving it to the end of the word and adding 'ay'.
//such that "The quick brown fox" becomes "Hetay uickqay rownbay oxfay".


/* The user input is collected after which the sentence would be split by the spaces between the words.
 * The individual words would be stored in an array for reference after which each word loses its first letter.
 *  That (first) letter is then stored in a variable for reattachment at the end of the word. 
 *  At the end of each word, "ay" is attached, followed by the space we removed at the beginning, which
 *  would help us form the sentence in Pig Latin. Since Console.WriteLine() prints each new word on a new line,
 *  the alternative Console.Write() is adopted instead.
 */

Console.WriteLine("Write your favorite quote and we will translate it to Pig Latin for you: ");
string sentence = Console.ReadLine();
string[] words = sentence.Split(' ');

foreach (string word in words)
{
    char toAppend = Convert.ToChar(word.Substring(0, 1)); 
    string newWord = word.Remove(0, 1);

    newWord += toAppend;

    newWord = newWord.Insert(newWord.Length, "ay");

    newWord = newWord + " ";

    Console.Write(newWord);
}



