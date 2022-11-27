using System;
namespace Translator
{
    class PigLatinTranslator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your favorite quote and we will translate it to Pig Latin for you: ");
            string sentence = Console.ReadLine();
            string[] words = sentence.Split(' ');

            foreach (string word in words)
            {
                string toAppend = word.Substring(0, 1); 
                string newWord = word.Remove(0, 1);

                newWord += toAppend;

                newWord = newWord.Insert(newWord.Length, "ay");

                newWord += " ";

                Console.Write(newWord);
            }
        }
        
    }
    
}



