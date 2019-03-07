using System;
using System.Text;

namespace Mastermind
{
    public class Answer
    {
        string answerString = string.Empty;
        Random rng = new Random();

        public Answer()
        {
            StringBuilder sb = new StringBuilder(4);
            for (int i = 0; i < 4; i++)
            {
                int answerDigit = this.rng.Next(1, 7);
                sb.Append(answerDigit);
            }
            this.answerString = sb.ToString();
        }

        public Answer(string answerString)
        {
            this.answerString = answerString;
        }

        public override string ToString()
        {
            return this.answerString;
        }

        public bool CheckIfDigitCorrect(char digitToCheck)
        {
            bool result = false;
            foreach (char digit in this.answerString)
            {
                if (digit == digitToCheck)
                {
                    result = true;
                }
            }
            return result;
        }

        public bool CheckDigitPosition(char digitToCheck, int digitIndex)
        {
            bool result = false;
            if(this.answerString[digitIndex] == digitToCheck)
            {
                result = true;
            }
            return result;
        }
    }
}
