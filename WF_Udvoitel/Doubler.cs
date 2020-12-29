using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WF_Udvoitel
{
    class Doubler
    {
        private Stack<int> history = new Stack<int>();
        public int CurrentValue { get { return currentValue; } private set { currentValue = value; history.Push(value); } }
        private int currentValue { get; set; }
        private Random random = new Random();
        public int TargetValue{ get { return targetValue; } }
        private int targetValue { get; set; }
        public int CurrentStep { get { return history.Count; } }
        public int MaxSteps { get; private set; }
        public bool IsTargetAchived { get { return IsTargetAchivedF(); } }
        public bool IsWin { get { return IsWinF(); } }


        public Doubler()
        {
            Start();
        }

        public void DoubleValue()
        {
            if (!IsTargetAchived)
            {
                CurrentValue *= 2;
            }
        }

        public void AddOneToValue()
        {
            if (!IsTargetAchived)
            {
                CurrentValue++;
            }
        }

        public void Cancel()
        {
            if (history.Count > 1)
            {
                history.Pop();
                CurrentValue = history.Pop();
            }
        }

        public void Start()
        {
            CurrentValue = 0;
            history.Clear();
            targetValue = random.Next(1, 20);
            CountMinSteps();
        }

        private void CountMinSteps()
        {
            MaxSteps = 0;
            int curVal = TargetValue;
            while(curVal != 0)
            {
                if(curVal % 2 == 0)
                {
                    curVal /= 2;
                    MaxSteps++;
                }
                else
                {
                    MaxSteps++;
                    curVal--;
                }
            }
        }

        private bool IsTargetAchivedF()
        {
            return CurrentValue >= TargetValue;
        }

        private bool IsWinF()
        {
            return CurrentStep <= MaxSteps;
        }

    }
}
