using System;
using System.Collections.Generic;
using System.Threading;

namespace SnakeOOP
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = 0;
            Walls walls = new Walls(80, 25);
            walls.Draw();

            point snaketail = new point(15, 15, 's');
            Snake snake = new Snake(snaketail, 5, Direction.RIGHT);
            snake.Draw();

            FoodGenerator foodGenerator = new FoodGenerator(80,25,'$');
            point food = foodGenerator.GenerateFood();
            food.Draw();
            FoodGenerator badfood = new FoodGenerator(80, 25, '@');
            point food2 = badfood.badfood();
            food2.Draw();
            
            while (true)
            {
                if(walls.IsHit(snake) || snake.ishittail())
                {
                    break;
                }

                if (snake.Eat(food))
                {
                    food = foodGenerator.GenerateFood();
                    food.Draw();
                    score++;
                }
                else
                {
                    snake.Move();
                }

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.Handlekeys(key.Key);
                }
                
                if (snake.Eat(food2))
                {

                    break;
                }
                Thread.Sleep(300);
            }

            string str_score = Convert.ToString(score);
            WriteGameOver(str_score);
            Console.ReadLine();
        }

        public static void WriteGameOver(string score)
        {
            Console.Beep();
            int xOffset = 25;
            int yOffset = 8;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.SetCursorPosition(xOffset, yOffset++);
            Writetext("==========================", xOffset, yOffset++);
            Writetext("         GAME OVER        ", xOffset+1, yOffset++);
            yOffset++;
            Writetext($"You scored {score} points.", xOffset + 2, yOffset++);
            Writetext("", xOffset, yOffset);
            Writetext("==========================", xOffset, yOffset++);
        }

        public static void Writetext(string text, int xOffset, int yOffset)
        {
            Console.SetCursorPosition(xOffset, yOffset);
            Console.WriteLine(text);
        }

    }
}
