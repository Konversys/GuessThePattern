using GuessThePattern.Model.Models;
using System;

namespace GuessThePattern.Model
{
    public class Controller
    {
        public int RightAnswer { get; private set; }
        int rightAnswers { get; set; }
        public void TakeRightAnwer()
        {
            rightAnswers++;
        }
        bool IsStart { get; set; }
        public int Count { get; private set; }
        public readonly int Max;
        public Pattern[] Patterns;
        Patterns patterns;
        Random random;
        public Controller()
        {
            random = new Random();
            patterns = new Patterns();
            Patterns = new Pattern[4];
            Max = 10;
            rightAnswers = 0;
            IsStart = false;
        }

        public void Start()
        {
            IsStart = true;
        }

        public Pattern GetRightPattern()
        {
            return Patterns[RightAnswer];
        }

        public bool CheckIsStart()
        {
            if ((Count == 10 && IsStart == true) || IsStart == false)
            {
                Count = 0;
                IsStart = false;
                return false;
            }
            return true;
        }

        public void Next()
        {
            Patterns = patterns.GetRandom();
            RightAnswer = random.Next(Patterns.Length);
            Count++;
        }

        public int GetScore()
        {
            return 100 * rightAnswers / Max;
        }

        public bool DetermineTask()
        {
            if (random.Next(2) == 0)
                return true;
            return false;
        }
    }
}
