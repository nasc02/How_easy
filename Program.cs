using System;

public class URI
{
    public static void Main(string[] args)
    {
        string statement;
        while ((statement = Console.ReadLine()) != null)
        {
            int wordCount = 0;
            int totalWordLength = 0;

            string[] words = statement.Split(' ');
            foreach (string word in words)
            {
                int wordLength = GetWordLength(word);
                if (wordLength > 0)
                {
                    wordCount++;
                    totalWordLength += wordLength;
                }
            }

            int avgWordLength = wordCount > 0 ? totalWordLength / wordCount : 0;
            int problemDifficulty;

            if (avgWordLength <= 3)
            {
                problemDifficulty = 250;
            }
            else if (avgWordLength <= 5)
            {
                problemDifficulty = 500;
            }
            else
            {
                problemDifficulty = 1000;
            }

            Console.WriteLine(problemDifficulty);
        }
    }

    private static int GetWordLength(string word)
    {
        // Remove any trailing period
        if (word.EndsWith("."))
        {
            word = word.Substring(0, word.Length - 1);
        }

        // Check if the remaining characters are letters
        foreach (char c in word)
        {
            if (!char.IsLetter(c))
            {
                return 0; // Not a valid word
            }
        }

        return word.Length;
    }
}
