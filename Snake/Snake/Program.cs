using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake( p, 4, Direction.RIGHT );
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
                if (walls.isHit(snake) || snake.IsHitTail())
                {
                    break;
                }

                if ( snake.Eat(food)) // важно распределять зоны ответствености
                {
                    food = foodCreator.CreateFood();
                    food.Draw();
                }
                else
                {
                    snake.Move();
                }
                Thread.Sleep(100);

                if (Console.KeyAvailable) // была ли нажата какая - нибудь клавиша?
                {
                    ConsoleKeyInfo key = Console.ReadKey(); // получаем значение клавиши

                    snake.HandleKey(key);
                }
               
                
            }
      

           


            Console.ReadLine();
        }



    }
}
