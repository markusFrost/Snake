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

            Point p1 = new Point(1, 3, '*' );
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

            while (true)
            {
                if (Console.KeyAvailable) // была ли нажата какая - нибудь клавиша?
                {
                    ConsoleKeyInfo key = Console.ReadKey(); // получаем значение клавиши

                    snake.HandleKey(key);
                }
                Thread.Sleep(100);
                snake.Move();
            }


           


            Console.ReadLine();
        }

    }
}
