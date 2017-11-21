using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman_Console
{
    class Program

    {
       
      
      
       


        private static int nWrongGuesses;
        private static int nWrongGuess;
        private static int intnWrongGuess;

        static string strLettersGuessed;
        private static string strLettersGussed;
        private static string strLettersGuesses;

        static void Main(string[] args)
        {

            string strSecretWord = GetWord();
            int nWrongGusses = 0;
            string[] WordDisplay = InitializeWordDisplay(strSecretWord);
            bool guessedIt = false; 

            //print Worddisplay
            printSecretWord(WordDisplay);

            //display all gallows
            while (!guessedIt && nWrongGuesses < 10)
            {


               HangmanGallows. DrawGallow(nWrongGuesses);

                //print Worddisplay
                printSecretWord(WordDisplay);
                Console.WriteLine("Letter gusses: " + strLettersGuesses);

                nWrongGuesses += PlayerGuess(WordDisplay, strSecretWord);
                guessedIt = GuessedWord(WordDisplay);
            }//end while

            if (guessedIt)
            {

                Console.WriteLine(" you got it!!" + strSecretWord);

            }
            else
            {
                Console.WriteLine("Executed!! The word was " + strSecretWord);


            }
            Console.ReadLine();
            
        }//end main

      

        private static bool GuessedWord(string[] WordDisplay)
        {
            //loop through WordDisplay and see if theword in guess
            for (int n = 0; n < WordDisplay.Length; n++)
            {
                if (WordDisplay[n] == " _ ")
                {

                    return false;
                }//end if

            }//end for loop

            return true;

        }//end guessWord



        private static int PlayerGuess(string[] WordDisplay, string strSecretWord)
        {
            string strUserGuess;
            int nWrongGuess = 1;

            //prompt user
            Console.Write("\nGuess a letter:");
            strUserGuess = Console.ReadLine();
            strLettersGuessed += strUserGuess;

            //process guess
            for (int n = 0; n < strSecretWord.Length; n++)

            {
                if (strSecretWord[n].ToString() == strUserGuess)

                {
                    WordDisplay[n] = strUserGuess;
                    nWrongGuess = 0;

                }

            }
            return nWrongGuess;

        }

        private static void PrintSecretWord(string[] wordDisplay)
        {
            //print word display
            for (int n = 0; n < wordDisplay.Length; n++)
            {
                Console.Write(wordDisplay[n]);
            }

            Console.WriteLine();

        }

        private static void printSecretWord(string[] WordDisplay)
        {


            //print word display
            for (int i = 0; i < WordDisplay.Length; i++)

            {
                Console.Write(WordDisplay[i]);

            }
        } 


        private static string[] InitializeWordDisplay(string strSecretword)
        {
            string[] wordDisplay = new string[strSecretword.Length];

            //fill wordDisplay array with_
            for (int i = 0; i < wordDisplay.Length; i++)
                
            {
                wordDisplay[i] = " _ ";
            }

            return wordDisplay;
        }

        

    }
}
    
