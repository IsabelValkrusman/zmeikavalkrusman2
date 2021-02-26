using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zmeikavalkrusman2
{
    class Program
    {
        public void game_draw()
        {
            Console.Clear();
            Console.Title = "Snake";
            Console.SetWindowSize(101, 26);
            HorizontalLine upline = new HorizontalLine(0, 100, 0, '+');
            HorizontalLine downline = new HorizontalLine(0, 100, 25, '+');
            VerticalLine leftline = new VerticalLine(1, 25, 0, '+');
            VerticalLine reightline = new VerticalLine(1, 25, 100, '+');
            upline.Draw();
            downline.Draw();
            leftline.Draw();
            rightline.Draw();
            Parametrs settings = new Parametrs();
            Sounds sound = new Sounds(settings.GetResourceFolder());
            sound.Play("stardust.mp3");
            Sounds soundeat = new Sounds(settings.GetResourceFolder());
            soundeat.Play("click.mp3");

            Point p = new Point(4, 5, '*', ConsoleColor.Red);
            Snake snake = new Snake(p, 4, Direction.RIGHT);
            snake.Draw();
            FoodCreator foodCreator = new FoodCreator(101, 26, '¤', ConsoleColor.Green);
            Point food = foodCreator.CreateFood();
            food.Draw();
            Score score = new Score(0, 1);//score =0, level=1
            score.speed = 400;
            score.ScoreWrite();
            while (true)
            {
                if (snake.Eat(food))
                {
                    score.ScoreUp();
                    score.ScoreWrite();
                    food = foodCreator.CreateFood();
                    food.Draw();
                    //sound.Stop("stardust.mp3");
                    if (score.ScoreUp())
                    {
                        score.speed -= 10;
                    }
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(score.speed);
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey(true);
                    snake.HandleKey(key.Key);
                }
            }
        }

        static void Main(string[] args)
        {
            Start start = new Start();
            if (start.choice() == 1)
            {
                Program prog = new Program();
                prog.game_draw();
            }
            else
            {
                start.Game_stop();
            }

        }
    }
}


            //List<int> numList = new List<int>();
            //numList.Add(0);
            //numList.Add(1);
            //numList.Add(2);

            //int x = numList[0];
            //int y = numList[1];
            //int z = numList[2];

            //foreach (int i in numList)
            //{
            //    Console.WriteLine(i);
            //}

            //numList.RemoveAt(0);

            //List<point> pList = new List<point>();

            //pList.Add(p1);
            //pList.Add(p2);


            //int c = 1;
            //Func1(x);
            //Console.WriteLine("Call Func1. x=" + x);

            //x = 1;
            //Func2(x);
            //Console.WriteLine("Call Func2. x=" + x);

            //x = 1;
            //Func3(x);
            //Console.WriteLine("Call Func3. x=" + x);

            //point p1 = new point(1, 3, '*');
            //Move(p1, 10, 10 =);
            //Console.WriteLine("Call Move. p1.x=" + p1.x + ",p1.y" + p1.y);
            ////p1.x = 1;
            ////p1.y = 3;
            ////p1.sym = '*';
            //p1.draw();

            //point p2 = new point(4, 5, '#');
            //p1 = p2;
            //p2.x = 8;
            //p2.y = 8;
            //Console.WriteLine("p1=p2. p1.x=" + p1.x+",p1.y="+p1.y+"; p2.x="+p2.x+", p2.y="+p2.y);

            //p1 = new point(1, 3, '#');
            //update(p1);
            //Console.WriteLine("Call Move. p1.x=" + p1.x + ",p1.y=" + p1.y);



            //int x1 = 1;
            //int y1 = 3;
            //char sym1 = '*';

            //Draw(x1, y1, sym1);

            //int x2 = 4;
            //int y2 = 5;
            //char sym2 = '#';

            //Draw(x2, y2, sym2);

            //Console.ReadLine();

//        }
//          //static void Draw(int x, int y, char sym)
//        //{
//        //    //Console.SetCursorPosition(x, y);
//        //    //Console.Write(sym);



//        //}
//    }
//}
