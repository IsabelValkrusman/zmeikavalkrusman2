using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeikavalkrusman2
{
    class Class2
    {
        private int score;
        public int level;

        public Class2(int score, int level)
        {
            this.score = score;
            this.level = level;
        }
        public void ScoreUp()
        {
            score += 1;
            if(score%10==0)
            {
                level += 1;
            }
        }
        public void ScoreWrite()
        {
            Console.SetCursorPosition(90, 10);
            Console.WriteLine("Score:" + score.ToString());
            Console.SetCursorPosition(90, 11);
            Console.WriteLine("Level:" + level.ToString());
        }
    }
}
