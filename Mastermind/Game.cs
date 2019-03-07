using System;
using System.Collections.Generic;
using System.Text;

namespace Mastermind
{
    public class Game
    {
        Answer Answer = new Answer();
        int NumberOfTriesRemaining = 10;
        List<Tuple<string,string>> previousGuesses = new List<Tuple<string,string>>();
        bool IsRunning = false;

        public void Run()
        {
            this.IsRunning = true;
            while (this.IsRunning)
            {
                Draw();
                if (NumberOfTriesRemaining == 0)
                {
                    Console.WriteLine(Strings.LossText);
                    this.IsRunning = false;
                }
                else
                {
                    ProcessGuess();
                }
            }
        }

        public void ProcessGuess()
        {
            string userInput = Console.ReadLine();
            Tuple<string, string> result = CheckInput(userInput);
            if (result.Item1 == "++++")
            {
                Console.WriteLine(Strings.WinText);
                this.IsRunning = false;
            }
            else
            {
                previousGuesses.Add(result);
                NumberOfTriesRemaining--;
            }
        }

        void Draw()
        {
            Console.Clear();
            Console.WriteLine(this.Answer.ToString());
            Console.WriteLine(Strings.TriesRemainingText, NumberOfTriesRemaining);
            Console.WriteLine(Strings.AwaitingInputText);
            foreach(Tuple<string,string> previousResult in previousGuesses)
            {
                Console.WriteLine(previousResult.Item1);
                Console.WriteLine(previousResult.Item2);
                Console.WriteLine("Try again!");
            }
        }

        Tuple<string,string> CheckInput(string input)
        {
            int plusCount = 0;
            int dashCount = 0;
            string digitsFound = string.Empty;
            string plusString = string.Empty;
            string dashString = string.Empty;
            for (int i = 0; i < input.Length; i++)
            {
                if(this.Answer.CheckIfDigitCorrect(input[i]))
                {
                    if(this.Answer.CheckDigitPosition(input[i], i))
                    {
                        plusCount++;
                    }
                    else if(!digitsFound.Contains(input[i].ToString()))
                    {
                        dashCount++;
                    }
                    digitsFound += input[i];
                }
            }
            for (int i = 0; i < plusCount; i++)
            {
                plusString += "+";
            }
            for (int i = 0; i < dashCount; i++)
            {
                dashString += "-";
            }
            return new Tuple<string, string>(plusString, dashString);
        }
    }
}
