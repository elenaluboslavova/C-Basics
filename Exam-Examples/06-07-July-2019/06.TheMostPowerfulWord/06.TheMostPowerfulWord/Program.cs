using System;

namespace _06.TheMostPowerfulWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputWord = Console.ReadLine();

            int currentLetter = 0;
            int currentLetterPower = 0;

            string mostPowerfulWord = "";
            int mostPowerfulWordPower = 0;

            while (inputWord != "End of words")
            {
                currentLetterPower = 0;
                currentLetter = 0;
                for (int i = 0; i < inputWord.Length; i++)
                {
                    currentLetter = (int)inputWord[i];
                    currentLetterPower += currentLetter;
                }

                bool vowel = inputWord[0] == 'a' || inputWord[0] == 'e' ||
                       inputWord[0] == 'i' || inputWord[0] == 'o' || inputWord[0] == 'u' ||
                       inputWord[0] == 'y' || inputWord[0] == 'A' || inputWord[0] == 'E' ||
                       inputWord[0] == 'I' || inputWord[0] == 'O' || inputWord[0] == 'U' ||
                       inputWord[0] == 'Y'; 

                if (vowel)
                {
                    currentLetterPower *= inputWord.Length;
                }
                else
                {
                    currentLetterPower /= inputWord.Length;
                }
                if (currentLetterPower > mostPowerfulWordPower)
                {
                    mostPowerfulWordPower = currentLetterPower;
                    mostPowerfulWord = inputWord;
                }



                inputWord = Console.ReadLine();
            }
            Console.WriteLine($"The most powerful word is {mostPowerfulWord} - {mostPowerfulWordPower:F0}");
        }
    }
}
