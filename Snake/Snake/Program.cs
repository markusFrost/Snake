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

            VerticalLine v1 = new VerticalLine(0, 10, 5, '%');

            Draw(v1);

            Point p = new Point(4, 5, '*');

            Figure fSnake = new Snake(p, 4, Direction.RIGHT);

            Draw(fSnake);

            Snake snake = (Snake) fSnake;

            HorizontalLine h1 = new HorizontalLine(0, 5, 6, '&');

            List<Figure> figures = new List<Figure>();
            figures.Add(fSnake);
            figures.Add(v1);
            figures.Add(h1);

            foreach (var f in figures)
            {
                f.Draw();
            }

           /* Point p1 = new Point(1, 3, '*' );
           // p1.Draw();

            Point p2 = new Point(4, 5, '#');
           // p2.Draw();

            //Инкапсуляция - свойство системы, позволяющее объединить данные и методы, работающие 
            //с ними в классе и скрыть все делати реализации от пользователя

            //Наследоваие - свойство системы, позволяющее писать новый класс на основе уже существующего
            // частично или полностью земещающийся функциональностью

            HorizontalLine upLine = new HorizontalLine(0, 78, 0, '+');
            HorizontalLine downLine = new HorizontalLine(0, 78, 24, '+');

            VerticalLine leftLine = new VerticalLine(0, 24, 0, '+' );
            VerticalLine rigthLine = new VerticalLine(0, 24, 78, '+');

            upLine.Draw();
            downLine.Draw();
            leftLine.Draw();
            rigthLine.Draw();

            Point p = new Point(4, 5, '*');
            Snake snake = new Snake( p, 4, Direction.RIGHT );
            snake.Draw();

            FoodCreator foodCreator = new FoodCreator(80, 25, '$');
            Point food = foodCreator.CreateFood();
            food.Draw();

            while (true)
            {
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
            */

           


            Console.ReadLine();
        }

        static void Draw(Figure figure)
        {
           // figure.Draw();
        }

    }
}
