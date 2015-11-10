using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {           
            Point p1 = new Point(1, 3, '*' );
            p1.Draw();

            Point p2 = new Point(4, 5, '#');
            p2.Draw();

            //Инкапсуляция - свойство системы, позволяющее объединить данные и методы, работающие 
            //с ними в классе и скрыть все делати реализации от пользователя

            List<int> numList = new List<int>();

            numList.Add(0);
            numList.Add(1);
            numList.Add(4);

            int x = numList[0];
            int y = numList[1];
            int z = numList[2];

            numList.RemoveAt(2);

            Console.WriteLine();
            foreach (int i in numList)
            {
                Console.Write(i + "\t");
            }


            Console.ReadLine();
        }

    }
}
