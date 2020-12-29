using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Udvoitel
{
    class TryGuess
    {

        private Random random = new Random();
        private int secretNumber { get; set; }
        public int CurrentTries { get { return currentTries; } }
        private int currentTries { get; set; }
        public int MaxSteps { get { return CountMaxSteps(0, 100); } }

        public TryGuess()
        {
            currentTries = 0;
            secretNumber = random.Next(1, 100);
        }

        private int CountMaxSteps(int leftB, int rightB)
        {
            int number = (rightB - leftB) / 2 + leftB;
            if (number == secretNumber)
            {
                return 1;
            }
            else
            {
                if (IsMoreThanSecret(number))
                {
                    return CountMaxSteps(leftB, number) + 1;
                }
                else
                {
                    return CountMaxSteps(number, rightB) + 1;
                }
                
            }
        }

        public bool Try(int value)
        {
            currentTries++;
            return value == secretNumber;
        }

        public bool IsMoreThanSecret(int value)
        {
            return value > secretNumber;
        }

        public bool CheckLoss()
        {
            return currentTries > MaxSteps;
        }
    }
}
